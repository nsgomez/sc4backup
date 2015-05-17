using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SC4Backup
{
    class BackupManager
    {
        private string backupDir, regionDir;
        Dictionary<string, Region> regions;
        MainForm parentForm;

        public string GetBackupDir() { return backupDir; }
        public string GetRegionDir() { return regionDir; }
        public Region GetRegion(string name)
        {
            Region r;
            if(!regions.TryGetValue(name, out r))
            {
                return null;
            }

            return r;
        }

        public BackupManager(MainForm parentForm)
        {
            this.parentForm = parentForm;
            string[] dirs = Directory.GetDirectories(Properties.Settings.Default.RegionDirectory);
            regions = new Dictionary<string, Region>();

            foreach (string dir in dirs)
            {
                Region temp = new Region(dir);
                regions.Add(temp.GetName(), temp);

                this.parentForm.regionComboBox.Items.Add(temp.GetName());
            }
        }
    }
}
