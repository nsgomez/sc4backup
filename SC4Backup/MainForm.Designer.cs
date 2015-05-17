namespace SC4Backup
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                trayIcon.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regionWatcher = new System.IO.FileSystemWatcher();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devThreadMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.githubMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.regionPanel = new System.Windows.Forms.Panel();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.regionSelectionLabel = new System.Windows.Forms.Label();
            this.cityPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.backupsListBox = new System.Windows.Forms.ListBox();
            this.availableBackupsLabel = new System.Windows.Forms.Label();
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.cityThumbnailPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.regionWatcher)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.regionPanel.SuspendLayout();
            this.cityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityThumbnailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // regionWatcher
            // 
            this.regionWatcher.EnableRaisingEvents = true;
            this.regionWatcher.SynchronizingObject = this;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(523, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuButton,
            this.quitMenuButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.Name = "settingsMenuButton";
            this.settingsMenuButton.Size = new System.Drawing.Size(116, 22);
            this.settingsMenuButton.Text = "Settings";
            // 
            // quitMenuButton
            // 
            this.quitMenuButton.Name = "quitMenuButton";
            this.quitMenuButton.Size = new System.Drawing.Size(116, 22);
            this.quitMenuButton.Text = "Quit";
            this.quitMenuButton.Click += new System.EventHandler(this.quitMenuButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devThreadMenuButton,
            this.githubMenuButton});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // devThreadMenuButton
            // 
            this.devThreadMenuButton.Name = "devThreadMenuButton";
            this.devThreadMenuButton.Size = new System.Drawing.Size(185, 22);
            this.devThreadMenuButton.Text = "Development Thread";
            // 
            // githubMenuButton
            // 
            this.githubMenuButton.Name = "githubMenuButton";
            this.githubMenuButton.Size = new System.Drawing.Size(185, 22);
            this.githubMenuButton.Text = "GitHub";
            this.githubMenuButton.Click += new System.EventHandler(this.githubMenuButton_Click);
            // 
            // regionPanel
            // 
            this.regionPanel.Controls.Add(this.cityListBox);
            this.regionPanel.Controls.Add(this.regionComboBox);
            this.regionPanel.Controls.Add(this.regionSelectionLabel);
            this.regionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.regionPanel.Location = new System.Drawing.Point(0, 24);
            this.regionPanel.Name = "regionPanel";
            this.regionPanel.Size = new System.Drawing.Size(199, 337);
            this.regionPanel.TabIndex = 1;
            // 
            // cityListBox
            // 
            this.cityListBox.Enabled = false;
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.Location = new System.Drawing.Point(3, 57);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(190, 277);
            this.cityListBox.TabIndex = 3;
            this.cityListBox.SelectedValueChanged += new System.EventHandler(this.cityListBox_SelectedValueChanged);
            // 
            // regionComboBox
            // 
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(3, 30);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(190, 21);
            this.regionComboBox.TabIndex = 2;
            this.regionComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged);
            // 
            // regionSelectionLabel
            // 
            this.regionSelectionLabel.AutoSize = true;
            this.regionSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionSelectionLabel.Location = new System.Drawing.Point(-1, 7);
            this.regionSelectionLabel.Name = "regionSelectionLabel";
            this.regionSelectionLabel.Size = new System.Drawing.Size(130, 20);
            this.regionSelectionLabel.TabIndex = 1;
            this.regionSelectionLabel.Text = "Region Selection";
            // 
            // cityPanel
            // 
            this.cityPanel.Controls.Add(this.deleteButton);
            this.cityPanel.Controls.Add(this.restoreButton);
            this.cityPanel.Controls.Add(this.backupsListBox);
            this.cityPanel.Controls.Add(this.availableBackupsLabel);
            this.cityPanel.Controls.Add(this.cityNameLabel);
            this.cityPanel.Controls.Add(this.cityThumbnailPictureBox);
            this.cityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityPanel.Location = new System.Drawing.Point(199, 24);
            this.cityPanel.Name = "cityPanel";
            this.cityPanel.Size = new System.Drawing.Size(324, 337);
            this.cityPanel.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(162, 306);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // restoreButton
            // 
            this.restoreButton.Enabled = false;
            this.restoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreButton.Location = new System.Drawing.Point(10, 306);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(146, 23);
            this.restoreButton.TabIndex = 4;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            // 
            // backupsListBox
            // 
            this.backupsListBox.Enabled = false;
            this.backupsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupsListBox.FormattingEnabled = true;
            this.backupsListBox.Location = new System.Drawing.Point(10, 166);
            this.backupsListBox.Name = "backupsListBox";
            this.backupsListBox.Size = new System.Drawing.Size(302, 134);
            this.backupsListBox.TabIndex = 3;
            // 
            // availableBackupsLabel
            // 
            this.availableBackupsLabel.AutoSize = true;
            this.availableBackupsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableBackupsLabel.Location = new System.Drawing.Point(7, 150);
            this.availableBackupsLabel.Name = "availableBackupsLabel";
            this.availableBackupsLabel.Size = new System.Drawing.Size(98, 13);
            this.availableBackupsLabel.TabIndex = 2;
            this.availableBackupsLabel.Text = "Available Backups:";
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityNameLabel.Location = new System.Drawing.Point(6, 128);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(81, 20);
            this.cityNameLabel.TabIndex = 1;
            this.cityNameLabel.Text = "City Name";
            // 
            // cityThumbnailPictureBox
            // 
            this.cityThumbnailPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cityThumbnailPictureBox.Location = new System.Drawing.Point(0, 0);
            this.cityThumbnailPictureBox.Margin = new System.Windows.Forms.Padding(8);
            this.cityThumbnailPictureBox.Name = "cityThumbnailPictureBox";
            this.cityThumbnailPictureBox.Size = new System.Drawing.Size(324, 120);
            this.cityThumbnailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cityThumbnailPictureBox.TabIndex = 0;
            this.cityThumbnailPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 361);
            this.Controls.Add(this.cityPanel);
            this.Controls.Add(this.regionPanel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MaximumSize = new System.Drawing.Size(539, 400);
            this.MinimumSize = new System.Drawing.Size(539, 400);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SC4Backup";
            ((System.ComponentModel.ISupportInitialize)(this.regionWatcher)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.regionPanel.ResumeLayout(false);
            this.regionPanel.PerformLayout();
            this.cityPanel.ResumeLayout(false);
            this.cityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityThumbnailPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.IO.FileSystemWatcher regionWatcher;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuButton;
        private System.Windows.Forms.ToolStripMenuItem quitMenuButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devThreadMenuButton;
        private System.Windows.Forms.ToolStripMenuItem githubMenuButton;
        public System.Windows.Forms.Panel cityPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.ListBox backupsListBox;
        private System.Windows.Forms.Label availableBackupsLabel;
        private System.Windows.Forms.Label cityNameLabel;
        private System.Windows.Forms.PictureBox cityThumbnailPictureBox;
        private System.Windows.Forms.Panel regionPanel;
        private System.Windows.Forms.ListBox cityListBox;
        public System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Label regionSelectionLabel;
    }
}

