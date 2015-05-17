using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace SC4Backup
{
    class City
    {
        private Dictionary<DateTime, Backup> backups;
        private Region parentRegion;
        private string filename, name;

        public City(string filename, Region parentRegion)
        {
            this.parentRegion = parentRegion;
            this.backups = new Dictionary<DateTime, Backup>();
            this.filename = filename;
            this.name = filename.Replace(".sc4", "");

            PopulateBackups();
        }

        private void PopulateBackups()
        {
            string backupDir = Properties.Settings.Default.BackupDirectory;
            string[] files = Directory.GetFiles(backupDir);

            foreach (string file in files)
            {
                int cityNameOffset = filename.IndexOf("__0");
                int timestampOffset = filename.IndexOf("__1");

                if (cityNameOffset == -1 || timestampOffset == -1)
                {
                    throw new InvalidDataException();
                }

                string regionName = filename.Substring(0, cityNameOffset);
                string cityName = filename.Substring(cityNameOffset + 3, timestampOffset);

                if (regionName.Equals(this.parentRegion.GetName()) && cityName.Equals(this.name))
                {
                    string timestampString = filename.Substring(timestampOffset + 3);

                    UInt64 timestampSecs = 0;
                    if (!UInt64.TryParse(timestampString, out timestampSecs))
                    {
                        // TODO: Handle error and put in a log or console.
                        //throw new InvalidDataException();
                        continue;
                    }

                    try
                    {
                        Backup temp = new Backup(file, this);
                        backups.Add(temp.GetTimestamp(), temp);
                    }
                    catch (Exception e)
                    {
                        // TODO: Handle exception and put in a log or console somewhere.
                        continue;
                    }
                }
            }
        }

        // Can throw unhandled exceptions from File.Copy
        public void MakeBackup()
        {
            string targetName = String.Format("{0}__0{1}__1{2}.sc4",
                this.parentRegion.GetName(),
                this.name,
                Helpers.GetUnixTimestampNow());

            string sourcePath = String.Format("{0}{1}{2}",
                this.parentRegion.GetPath(),
                Path.DirectorySeparatorChar.ToString(),
                this.filename);

            string targetPath = String.Format("{0}{1}{2}",
                Properties.Settings.Default.BackupDirectory,
                Path.DirectorySeparatorChar.ToString(),
                targetName);

            File.Copy(sourcePath, targetPath);

            Backup temp = new Backup(targetName, this);
            backups.Add(temp.GetTimestamp(), temp);
        }

        public Backup GetBackupByTimestamp(DateTime timestamp)
        {
            Backup ret;
            if (!backups.TryGetValue(timestamp, out ret))
            {
                return null;
            }

            return ret;
        }
        
        public override string ToString() { return name; }
        public String GetName() { return name; }
        public Region GetParentRegion() { return parentRegion; }
        public Dictionary<DateTime, Backup> GetBackups() { return backups; }

        public string GetBackupFilename(DateTime timestamp)
        {
            string regionName = parentRegion.ToString();
            UInt64 timeSpan = (UInt64)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;

            string fileName = String.Format("{0}__0{1}__1{2}.sc4", regionName, this.name, timeSpan);
            return fileName;
        }

        public Image GetThumbnail()
        {
            try
            {
                string path = parentRegion.GetPath() + Path.DirectorySeparatorChar + filename;
                FileStream streamSource = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

                // All SC4 files contain a thumbnail starting at the 96th byte after the
                // DBPF header. We seek there and begin reading the PNG from that point.
                streamSource.Seek(96, SeekOrigin.Begin);

                // TODO: Other readers can see the PNG fine from this offset
                MemoryStream stream = new MemoryStream((int)streamSource.Length);

                // Copy the source stream to the memory stream, as .NET 3.5 does not
                // have an in-built method of doing this. Uses 32KB buffers.
                //
                // The reason we have to copy the source from the 96-byte offset to
                // begin with is because Image.FromStream always seeks the stream
                // back to the beginning, causing it to always complain about an
                // invalid parameter.
                byte[] buffer = new byte[32768];
                int read;
                while ((read = streamSource.Read(buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, read);
                }

                // Destroy the original stream.
                streamSource = null;

                // Create the Image holding the bitmap.
                Image image = Image.FromStream(stream);

                // Destroy the memory stream.
                stream = null;

                return image;
            }
            catch (Exception e)
            {
                Image image = Image.FromFile("unreadable_tile.png");
                return image;
            }
        }
    }
}
