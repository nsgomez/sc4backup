using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace SC4Backup
{
    class Backup
    {
        private string filename;
        private City parentCity;
        private DateTime timestamp;
        private long fileSize;

        public Backup(string filename, City parentCity)
        {
            this.parentCity = parentCity;
            this.ParseFromFilename();
        }

        public override string ToString() { return this.filename; }
        public City GetParentCity() { return parentCity; }
        public DateTime GetTimestamp() { return timestamp; }
        public long GetFileSize() { return fileSize; }

        public Image GetThumbnail()
        {
            string path = String.Format("{0}{1}{2}",
                parentCity.GetParentRegion().GetPath(),
                Path.DirectorySeparatorChar,
                filename);

            Stream imageStreamSource = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            imageStreamSource.Seek(96, SeekOrigin.Begin);

            Image image = Image.FromStream(imageStreamSource);
            return image;
        }

        // Can throw an ArgumentOutOfRangeException or InvalidDataException
        public void ParseFromFilename()
        {
            try
            {
                FileInfo info = new FileInfo(parentCity.GetParentRegion().GetPath() + Path.DirectorySeparatorChar + filename);
                fileSize = info.Length;
            }
            catch(IOException e)
            {
                return;
            }
            
            int cityNameOffset = filename.IndexOf("__0");
            int timestampOffset = filename.IndexOf("__1");

            if (cityNameOffset == -1 || timestampOffset == -1)
            {
                throw new ArgumentOutOfRangeException();
            }

            string regionName = filename.Substring(0, cityNameOffset);
            string cityName = filename.Substring(cityNameOffset + 3, timestampOffset);
            string timestampString = filename.Substring(timestampOffset + 3);

            UInt64 timestampSecs = 0;
            if(!UInt64.TryParse(timestampString, out timestampSecs))
            {
                throw new InvalidDataException();
            }

            this.timestamp = new DateTime();
            this.timestamp = this.timestamp.AddSeconds(timestampSecs);
            this.timestamp = this.timestamp.Add(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).TimeOfDay);
        }

        // Any exceptions thrown by File.Copy are expected to be handled by the caller.
        public void Restore()
        {
            string separator = Path.DirectorySeparatorChar.ToString();
            string cityName = parentCity.ToString();
            string regionName = parentCity.GetParentRegion().ToString();

            string sourceDir = Properties.Settings.Default.BackupDirectory;
            string sourcePath = String.Format("{0}{1}{2}",
                sourceDir, separator, filename);

            string targetDir = Properties.Settings.Default.RegionDirectory;
            string targetPath = String.Format("{0}{1}{2}{1}{3}",
                targetDir, separator, regionName, cityName);

            File.Copy(sourcePath, targetPath, true);
        }

        // Can throw an exception from File.Delete
        public void Delete()
        {
            string separator = Path.DirectorySeparatorChar.ToString();
            string sourceDir = Properties.Settings.Default.BackupDirectory;
            string sourcePath = String.Format("{0}{1}{2}",
                sourceDir, separator, filename);

            File.Delete(sourcePath);
        }
    }
}
