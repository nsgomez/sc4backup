using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SC4Backup
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.FirstRun)
            {
                DoFirstRunScreen();
                GuessBackupDirectory();
                GuessRegionDirectory();
            }
        }

        private void DoFirstRunScreen()
        {
            string message = "It looks like this is your first time running SC4Backup.{0}{0}" +
                "The location of your regions and backup folders will be guessed;{0}" +
                "please verify that these settings are correct, then press Save to{0}" +
                "continue.";

            message = String.Format(message, Environment.NewLine);
            MessageBox.Show(message);
        }

        private void GuessRegionDirectory()
        {
            string dir = String.Format(
                "{0}{1}SimCity 4{1}Regions",

                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                System.IO.Path.DirectorySeparatorChar.ToString()
            );

            this.regionDirBox.Text = dir;
        }

        private void GuessBackupDirectory()
        {
            string dir = String.Format(
                "{0}{1}SC4Backup",

                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                System.IO.Path.DirectorySeparatorChar.ToString()
            );

            this.backupDirBox.Text = dir;
        }

        bool ValidateRegionDir()
        {
            if (!System.IO.Directory.Exists(regionDirBox.Text))
            {
                string err = "The given region directory does not exist.";
                MessageBox.Show(this, err, "Invalid Setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        bool ValidateBackupDir()
        {
            try
            {
                if (!System.IO.Directory.Exists(backupDirBox.Text))
                {
                    System.IO.Directory.CreateDirectory(backupDirBox.Text);
                }
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }

        bool ValidateBackupCount()
        {
            int temp;
            if (!Int32.TryParse(mgrBackupCount.Text, out temp) || temp < 0)
            {
                string err = "An invalid backup count was given.{0}Enter an integer (at least zero) without punctuation and try again.";
                err = String.Format(err, Environment.NewLine);

                MessageBox.Show(this, err, "Invalid Setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private bool ValidateAllSettings()
        {
            if (!ValidateBackupCount()) { return false; }
            if (!ValidateBackupDir()) { return false; }
            if (!ValidateRegionDir()) { return false; }

            Properties.Settings.Default["FirstRun"] = false;
            Properties.Settings.Default["BackupDirectory"] = backupDirBox.Text;
            Properties.Settings.Default["RegionDirectory"] = regionDirBox.Text;
            Properties.Settings.Default["BackupCount"] = System.UInt32.Parse(mgrBackupCount.Text);

            if (onQuitRadioButton.Checked) { Properties.Settings.Default["BackupBehavior"] = 0; }
            else { Properties.Settings.Default["BackupBehavior"] = 1; }

            if (mgrTotalRadioButton.Checked) { Properties.Settings.Default["BackupCountType"] = 0; }
            else if (mgrPerRegionRadioButton.Checked) { Properties.Settings.Default["BackupCountType"] = 1; }
            else { Properties.Settings.Default["BackupCountType"] = 2; }

            return true;
        }

        private void mgrBackupCount_TextChanged(object sender, EventArgs e)
        {
            ValidateBackupCount();
        }

        private void regionDirBox_TextChanged(object sender, EventArgs e)
        {
            ValidateRegionDir();
        }

        private void regionDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                regionDirBox.Text = dialog.SelectedPath;
                ValidateRegionDir();
            }
        }

        private void backupDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                backupDirBox.Text = dialog.SelectedPath;
                ValidateBackupDir();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateAllSettings())
            {
                Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}
