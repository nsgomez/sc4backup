using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SC4Backup
{
    public partial class MainForm : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private SettingsForm settingsForm;

        private BackupManager backupManager;
        private Region currentRegion;
        private City currentCity;

        public MainForm()
        {
            InitializeComponent();

            backupManager = new BackupManager(this);
            currentRegion = null;
            currentCity = null;

            settingsForm = null;

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);

            trayIcon = new NotifyIcon();
            trayIcon.Text = "SC4Backup";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            trayIcon.DoubleClick += OnTrayDoubleClick;
        }

        private void quitMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void githubMenuButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/nsgomez/sc4backup");
        }

        private void OnExit(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(this,
                "Are you sure you want to exit?\nBackups will not be performed until SC4Backup is reopened.",
                "Closing SC4Backup",
                MessageBoxButtons.YesNo);

            switch (res)
            {
                case DialogResult.No:
                    break;

                default:
                    Application.Exit();
                    break;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            switch (e.CloseReason)
            {
                case CloseReason.WindowsShutDown:
                case CloseReason.ApplicationExitCall:
                    break;

                default:
                    this.Visible = false;
                    e.Cancel = true;
                    break;
            }
        }

        private void OnTrayDoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = (string)regionComboBox.Items[regionComboBox.SelectedIndex];
            Region r = backupManager.GetRegion(key);
            if (r != null)
            {
                Dictionary<string, City> cities = r.GetCities();

                cityListBox.Items.Clear();
                foreach (KeyValuePair<string, City> pair in cities)
                {
                    cityListBox.Items.Add(pair.Key);
                }

                currentRegion = r;
                cityListBox.Enabled = true;

                backupsListBox.Enabled = false;
                deleteButton.Enabled = false;
                restoreButton.Enabled = false;
            }
        }

        private void cityListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (currentRegion != null)
            {
                string key = (string)cityListBox.Items[cityListBox.SelectedIndex];
                City c = currentRegion.GetCityByName(key);

                cityNameLabel.Text = c.GetName();
                cityThumbnailPictureBox.Image = c.GetThumbnail();
                backupsListBox.Items.Clear();

                Dictionary<DateTime, Backup> backups = c.GetBackups();
                foreach(KeyValuePair<DateTime, Backup> backup in backups)
                {
                    backupsListBox.Items.Add(backup.Key);
                }

                backupsListBox.Enabled = true;
            }
        }
    }
}
