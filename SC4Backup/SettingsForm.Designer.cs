namespace SC4Backup
{
    partial class SettingsForm
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
            this.regionDirLabel = new System.Windows.Forms.Label();
            this.regionDirBox = new System.Windows.Forms.TextBox();
            this.regionDirButton = new System.Windows.Forms.Button();
            this.backupDirButton = new System.Windows.Forms.Button();
            this.backupDirBox = new System.Windows.Forms.TextBox();
            this.backupDirLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveBehaviorGroup = new System.Windows.Forms.GroupBox();
            this.onChangeRadioButton = new System.Windows.Forms.RadioButton();
            this.onQuitRadioButton = new System.Windows.Forms.RadioButton();
            this.backupManagerGroup = new System.Windows.Forms.GroupBox();
            this.mgrPerCityRadioButton = new System.Windows.Forms.RadioButton();
            this.mgrPerRegionRadioButton = new System.Windows.Forms.RadioButton();
            this.mgrTotalRadioButton = new System.Windows.Forms.RadioButton();
            this.backupCountLabel = new System.Windows.Forms.Label();
            this.mgrBackupCount = new System.Windows.Forms.TextBox();
            this.spaceUsedHelpLabel = new System.Windows.Forms.Label();
            this.spaceUsedLabel = new System.Windows.Forms.Label();
            this.saveBehaviorGroup.SuspendLayout();
            this.backupManagerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // regionDirLabel
            // 
            this.regionDirLabel.AutoSize = true;
            this.regionDirLabel.Location = new System.Drawing.Point(13, 13);
            this.regionDirLabel.Name = "regionDirLabel";
            this.regionDirLabel.Size = new System.Drawing.Size(86, 13);
            this.regionDirLabel.TabIndex = 0;
            this.regionDirLabel.Text = "Region Directory";
            // 
            // regionDirBox
            // 
            this.regionDirBox.Location = new System.Drawing.Point(16, 30);
            this.regionDirBox.Name = "regionDirBox";
            this.regionDirBox.Size = new System.Drawing.Size(483, 20);
            this.regionDirBox.TabIndex = 1;
            this.regionDirBox.TextChanged += new System.EventHandler(this.regionDirBox_TextChanged);
            // 
            // regionDirButton
            // 
            this.regionDirButton.Location = new System.Drawing.Point(515, 30);
            this.regionDirButton.Name = "regionDirButton";
            this.regionDirButton.Size = new System.Drawing.Size(27, 20);
            this.regionDirButton.TabIndex = 2;
            this.regionDirButton.Text = "...";
            this.regionDirButton.UseVisualStyleBackColor = true;
            this.regionDirButton.Click += new System.EventHandler(this.regionDirButton_Click);
            // 
            // backupDirButton
            // 
            this.backupDirButton.Location = new System.Drawing.Point(515, 80);
            this.backupDirButton.Name = "backupDirButton";
            this.backupDirButton.Size = new System.Drawing.Size(27, 20);
            this.backupDirButton.TabIndex = 5;
            this.backupDirButton.Text = "...";
            this.backupDirButton.UseVisualStyleBackColor = true;
            this.backupDirButton.Click += new System.EventHandler(this.backupDirButton_Click);
            // 
            // backupDirBox
            // 
            this.backupDirBox.Location = new System.Drawing.Point(16, 80);
            this.backupDirBox.Name = "backupDirBox";
            this.backupDirBox.Size = new System.Drawing.Size(483, 20);
            this.backupDirBox.TabIndex = 4;
            // 
            // backupDirLabel
            // 
            this.backupDirLabel.AutoSize = true;
            this.backupDirLabel.Location = new System.Drawing.Point(13, 63);
            this.backupDirLabel.Name = "backupDirLabel";
            this.backupDirLabel.Size = new System.Drawing.Size(89, 13);
            this.backupDirLabel.TabIndex = 3;
            this.backupDirLabel.Text = "Backup Directory";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 239);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveBehaviorGroup
            // 
            this.saveBehaviorGroup.Controls.Add(this.onChangeRadioButton);
            this.saveBehaviorGroup.Controls.Add(this.onQuitRadioButton);
            this.saveBehaviorGroup.Location = new System.Drawing.Point(16, 107);
            this.saveBehaviorGroup.Name = "saveBehaviorGroup";
            this.saveBehaviorGroup.Size = new System.Drawing.Size(276, 108);
            this.saveBehaviorGroup.TabIndex = 7;
            this.saveBehaviorGroup.TabStop = false;
            this.saveBehaviorGroup.Text = "Backup Behavior";
            // 
            // onChangeRadioButton
            // 
            this.onChangeRadioButton.AutoSize = true;
            this.onChangeRadioButton.Location = new System.Drawing.Point(7, 57);
            this.onChangeRadioButton.Name = "onChangeRadioButton";
            this.onChangeRadioButton.Size = new System.Drawing.Size(247, 30);
            this.onChangeRadioButton.TabIndex = 1;
            this.onChangeRadioButton.Text = "Back up modified cities every time I save.\r\nMuch more reliable but uses much more" +
    " space.";
            this.onChangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // onQuitRadioButton
            // 
            this.onQuitRadioButton.AutoSize = true;
            this.onQuitRadioButton.Checked = true;
            this.onQuitRadioButton.Location = new System.Drawing.Point(7, 20);
            this.onQuitRadioButton.Name = "onQuitRadioButton";
            this.onQuitRadioButton.Size = new System.Drawing.Size(233, 30);
            this.onQuitRadioButton.TabIndex = 0;
            this.onQuitRadioButton.TabStop = true;
            this.onQuitRadioButton.Text = "Back up modified cities after I quit SimCity 4.\r\nUses less space and is still rel" +
    "iable.";
            this.onQuitRadioButton.UseVisualStyleBackColor = true;
            // 
            // backupManagerGroup
            // 
            this.backupManagerGroup.Controls.Add(this.mgrPerCityRadioButton);
            this.backupManagerGroup.Controls.Add(this.mgrPerRegionRadioButton);
            this.backupManagerGroup.Controls.Add(this.mgrTotalRadioButton);
            this.backupManagerGroup.Controls.Add(this.backupCountLabel);
            this.backupManagerGroup.Controls.Add(this.mgrBackupCount);
            this.backupManagerGroup.Location = new System.Drawing.Point(299, 107);
            this.backupManagerGroup.Name = "backupManagerGroup";
            this.backupManagerGroup.Size = new System.Drawing.Size(243, 108);
            this.backupManagerGroup.TabIndex = 8;
            this.backupManagerGroup.TabStop = false;
            this.backupManagerGroup.Text = "Backup Management";
            // 
            // mgrPerCityRadioButton
            // 
            this.mgrPerCityRadioButton.AutoSize = true;
            this.mgrPerCityRadioButton.Checked = true;
            this.mgrPerCityRadioButton.Location = new System.Drawing.Point(28, 83);
            this.mgrPerCityRadioButton.Name = "mgrPerCityRadioButton";
            this.mgrPerCityRadioButton.Size = new System.Drawing.Size(60, 17);
            this.mgrPerCityRadioButton.TabIndex = 4;
            this.mgrPerCityRadioButton.TabStop = true;
            this.mgrPerCityRadioButton.Text = "Per city";
            this.mgrPerCityRadioButton.UseVisualStyleBackColor = true;
            // 
            // mgrPerRegionRadioButton
            // 
            this.mgrPerRegionRadioButton.AutoSize = true;
            this.mgrPerRegionRadioButton.Location = new System.Drawing.Point(28, 60);
            this.mgrPerRegionRadioButton.Name = "mgrPerRegionRadioButton";
            this.mgrPerRegionRadioButton.Size = new System.Drawing.Size(73, 17);
            this.mgrPerRegionRadioButton.TabIndex = 3;
            this.mgrPerRegionRadioButton.Text = "Per region";
            this.mgrPerRegionRadioButton.UseVisualStyleBackColor = true;
            // 
            // mgrTotalRadioButton
            // 
            this.mgrTotalRadioButton.AutoSize = true;
            this.mgrTotalRadioButton.Location = new System.Drawing.Point(28, 37);
            this.mgrTotalRadioButton.Name = "mgrTotalRadioButton";
            this.mgrTotalRadioButton.Size = new System.Drawing.Size(57, 17);
            this.mgrTotalRadioButton.TabIndex = 2;
            this.mgrTotalRadioButton.Text = "In total";
            this.mgrTotalRadioButton.UseVisualStyleBackColor = true;
            // 
            // backupCountLabel
            // 
            this.backupCountLabel.AutoSize = true;
            this.backupCountLabel.Location = new System.Drawing.Point(7, 20);
            this.backupCountLabel.Name = "backupCountLabel";
            this.backupCountLabel.Size = new System.Drawing.Size(126, 13);
            this.backupCountLabel.TabIndex = 1;
            this.backupCountLabel.Text = "Keep this many backups:";
            // 
            // mgrBackupCount
            // 
            this.mgrBackupCount.Location = new System.Drawing.Point(137, 17);
            this.mgrBackupCount.Name = "mgrBackupCount";
            this.mgrBackupCount.Size = new System.Drawing.Size(100, 20);
            this.mgrBackupCount.TabIndex = 0;
            this.mgrBackupCount.Text = "3";
            this.mgrBackupCount.TextChanged += new System.EventHandler(this.mgrBackupCount_TextChanged);
            // 
            // spaceUsedHelpLabel
            // 
            this.spaceUsedHelpLabel.AutoSize = true;
            this.spaceUsedHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceUsedHelpLabel.Location = new System.Drawing.Point(13, 221);
            this.spaceUsedHelpLabel.Name = "spaceUsedHelpLabel";
            this.spaceUsedHelpLabel.Size = new System.Drawing.Size(67, 13);
            this.spaceUsedHelpLabel.TabIndex = 9;
            this.spaceUsedHelpLabel.Text = "Space used:";
            // 
            // spaceUsedLabel
            // 
            this.spaceUsedLabel.AutoSize = true;
            this.spaceUsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceUsedLabel.Location = new System.Drawing.Point(86, 221);
            this.spaceUsedLabel.Name = "spaceUsedLabel";
            this.spaceUsedLabel.Size = new System.Drawing.Size(41, 13);
            this.spaceUsedLabel.TabIndex = 10;
            this.spaceUsedLabel.Text = "0 bytes";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 273);
            this.Controls.Add(this.spaceUsedLabel);
            this.Controls.Add(this.spaceUsedHelpLabel);
            this.Controls.Add(this.backupManagerGroup);
            this.Controls.Add(this.saveBehaviorGroup);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backupDirButton);
            this.Controls.Add(this.backupDirBox);
            this.Controls.Add(this.backupDirLabel);
            this.Controls.Add(this.regionDirButton);
            this.Controls.Add(this.regionDirBox);
            this.Controls.Add(this.regionDirLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(502, 189);
            this.Name = "SettingsForm";
            this.Text = "SC4Backup Settings";
            this.saveBehaviorGroup.ResumeLayout(false);
            this.saveBehaviorGroup.PerformLayout();
            this.backupManagerGroup.ResumeLayout(false);
            this.backupManagerGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regionDirLabel;
        private System.Windows.Forms.TextBox regionDirBox;
        private System.Windows.Forms.Button regionDirButton;
        private System.Windows.Forms.Button backupDirButton;
        private System.Windows.Forms.TextBox backupDirBox;
        private System.Windows.Forms.Label backupDirLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox saveBehaviorGroup;
        private System.Windows.Forms.RadioButton onChangeRadioButton;
        private System.Windows.Forms.RadioButton onQuitRadioButton;
        private System.Windows.Forms.GroupBox backupManagerGroup;
        private System.Windows.Forms.RadioButton mgrTotalRadioButton;
        private System.Windows.Forms.Label backupCountLabel;
        private System.Windows.Forms.TextBox mgrBackupCount;
        private System.Windows.Forms.RadioButton mgrPerCityRadioButton;
        private System.Windows.Forms.RadioButton mgrPerRegionRadioButton;
        private System.Windows.Forms.Label spaceUsedHelpLabel;
        private System.Windows.Forms.Label spaceUsedLabel;
    }
}