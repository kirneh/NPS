namespace NPS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabCapture = new System.Windows.Forms.TabPage();
            this.lblOpenSpotify = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tcSettingsText = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCustomizeSave = new System.Windows.Forms.Button();
            this.lblCustomizeHelp = new System.Windows.Forms.Label();
            this.lblSettingText = new System.Windows.Forms.Label();
            this.tbCustomizeOutput = new System.Windows.Forms.TextBox();
            this.tcSettingsSave = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnLocation = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblAuthorDescription = new System.Windows.Forms.Label();
            this.lblAuthorLink = new System.Windows.Forms.LinkLabel();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Main_Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcUpdate = new System.Windows.Forms.TabPage();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.lblUpdateHeader = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tabCapture.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tcSettingsText.SuspendLayout();
            this.tcSettingsSave.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabCapture);
            this.tcMain.Controls.Add(this.tabSettings);
            this.tcMain.Controls.Add(this.tabAbout);
            this.tcMain.Location = new System.Drawing.Point(1, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(483, 151);
            this.tcMain.TabIndex = 0;
            // 
            // tabCapture
            // 
            this.tabCapture.Controls.Add(this.lblOpenSpotify);
            this.tabCapture.Controls.Add(this.StatusLabel);
            this.tabCapture.Controls.Add(this.btnCapture);
            this.tabCapture.Location = new System.Drawing.Point(4, 22);
            this.tabCapture.Name = "tabCapture";
            this.tabCapture.Padding = new System.Windows.Forms.Padding(3);
            this.tabCapture.Size = new System.Drawing.Size(475, 125);
            this.tabCapture.TabIndex = 0;
            this.tabCapture.Text = "Capture";
            this.tabCapture.UseVisualStyleBackColor = true;
            // 
            // lblOpenSpotify
            // 
            this.lblOpenSpotify.AutoSize = true;
            this.lblOpenSpotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpenSpotify.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Underline);
            this.lblOpenSpotify.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOpenSpotify.Location = new System.Drawing.Point(146, 11);
            this.lblOpenSpotify.Name = "lblOpenSpotify";
            this.lblOpenSpotify.Size = new System.Drawing.Size(96, 18);
            this.lblOpenSpotify.TabIndex = 3;
            this.lblOpenSpotify.Text = "Open Spotify?";
            this.lblOpenSpotify.Visible = false;
            this.lblOpenSpotify.Click += new System.EventHandler(this.lblOpenSpotify_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Underline);
            this.StatusLabel.Location = new System.Drawing.Point(9, 11);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(104, 18);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Not capturing...";
            // 
            // btnCapture
            // 
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCapture.Font = new System.Drawing.Font("Ubuntu", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCapture.Location = new System.Drawing.Point(8, 42);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(460, 75);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Start Capturing!";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tcSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(475, 125);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tcSettingsText);
            this.tcSettings.Controls.Add(this.tcSettingsSave);
            this.tcSettings.Controls.Add(this.tcUpdate);
            this.tcSettings.Location = new System.Drawing.Point(0, 0);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(479, 129);
            this.tcSettings.TabIndex = 5;
            // 
            // tcSettingsText
            // 
            this.tcSettingsText.Controls.Add(this.label3);
            this.tcSettingsText.Controls.Add(this.btnCustomizeSave);
            this.tcSettingsText.Controls.Add(this.lblCustomizeHelp);
            this.tcSettingsText.Controls.Add(this.lblSettingText);
            this.tcSettingsText.Controls.Add(this.tbCustomizeOutput);
            this.tcSettingsText.Location = new System.Drawing.Point(4, 22);
            this.tcSettingsText.Name = "tcSettingsText";
            this.tcSettingsText.Padding = new System.Windows.Forms.Padding(3);
            this.tcSettingsText.Size = new System.Drawing.Size(471, 103);
            this.tcSettingsText.TabIndex = 0;
            this.tcSettingsText.Text = "Text";
            this.tcSettingsText.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.label3.Location = new System.Drawing.Point(1, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remember to save!";
            // 
            // btnCustomizeSave
            // 
            this.btnCustomizeSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCustomizeSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustomizeSave.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.btnCustomizeSave.Location = new System.Drawing.Point(195, 61);
            this.btnCustomizeSave.Name = "btnCustomizeSave";
            this.btnCustomizeSave.Size = new System.Drawing.Size(75, 34);
            this.btnCustomizeSave.TabIndex = 10;
            this.btnCustomizeSave.Text = "Save";
            this.btnCustomizeSave.UseVisualStyleBackColor = true;
            this.btnCustomizeSave.Click += new System.EventHandler(this.btnCustomizeSave_Click);
            // 
            // lblCustomizeHelp
            // 
            this.lblCustomizeHelp.AutoSize = true;
            this.lblCustomizeHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCustomizeHelp.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCustomizeHelp.Location = new System.Drawing.Point(455, 3);
            this.lblCustomizeHelp.Name = "lblCustomizeHelp";
            this.lblCustomizeHelp.Size = new System.Drawing.Size(14, 16);
            this.lblCustomizeHelp.TabIndex = 9;
            this.lblCustomizeHelp.Text = "?";
            this.lblCustomizeHelp.Click += new System.EventHandler(this.lblCustomizeHelp_Click);
            // 
            // lblSettingText
            // 
            this.lblSettingText.AutoSize = true;
            this.lblSettingText.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingText.Location = new System.Drawing.Point(7, 4);
            this.lblSettingText.Name = "lblSettingText";
            this.lblSettingText.Size = new System.Drawing.Size(145, 21);
            this.lblSettingText.TabIndex = 8;
            this.lblSettingText.Text = "Customize output";
            // 
            // tbCustomizeOutput
            // 
            this.tbCustomizeOutput.Location = new System.Drawing.Point(11, 29);
            this.tbCustomizeOutput.Name = "tbCustomizeOutput";
            this.tbCustomizeOutput.Size = new System.Drawing.Size(447, 20);
            this.tbCustomizeOutput.TabIndex = 0;
            this.tbCustomizeOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tcSettingsSave
            // 
            this.tcSettingsSave.Controls.Add(this.label2);
            this.tcSettingsSave.Controls.Add(this.btnSaveSettings);
            this.tcSettingsSave.Controls.Add(this.lblLocation);
            this.tcSettingsSave.Controls.Add(this.btnLocation);
            this.tcSettingsSave.Controls.Add(this.txtLocation);
            this.tcSettingsSave.Location = new System.Drawing.Point(4, 22);
            this.tcSettingsSave.Name = "tcSettingsSave";
            this.tcSettingsSave.Padding = new System.Windows.Forms.Padding(3);
            this.tcSettingsSave.Size = new System.Drawing.Size(471, 103);
            this.tcSettingsSave.TabIndex = 1;
            this.tcSettingsSave.Text = "Save location";
            this.tcSettingsSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.label2.Location = new System.Drawing.Point(1, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Remember to save!";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveSettings.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.btnSaveSettings.Location = new System.Drawing.Point(195, 61);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 34);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(7, 4);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(129, 21);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Output location";
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(365, 28);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(104, 22);
            this.btnLocation.TabIndex = 6;
            this.btnLocation.Text = "Choose Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(9, 29);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(350, 20);
            this.txtLocation.TabIndex = 5;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lblVersion);
            this.tabAbout.Controls.Add(this.lblAuthorName);
            this.tabAbout.Controls.Add(this.lblAuthorDescription);
            this.tabAbout.Controls.Add(this.lblAuthorLink);
            this.tabAbout.Controls.Add(this.pictureBox1);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(475, 125);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.lblVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVersion.Location = new System.Drawing.Point(441, 106);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVersion.Size = new System.Drawing.Size(31, 16);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "v 1.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.lblAuthorName.Location = new System.Drawing.Point(129, 26);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(90, 16);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Made by Kirnehx";
            // 
            // lblAuthorDescription
            // 
            this.lblAuthorDescription.AutoSize = true;
            this.lblAuthorDescription.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.lblAuthorDescription.Location = new System.Drawing.Point(129, 46);
            this.lblAuthorDescription.Name = "lblAuthorDescription";
            this.lblAuthorDescription.Size = new System.Drawing.Size(209, 16);
            this.lblAuthorDescription.TabIndex = 2;
            this.lblAuthorDescription.Text = "Made in the intrest of helping streamers";
            // 
            // lblAuthorLink
            // 
            this.lblAuthorLink.AutoSize = true;
            this.lblAuthorLink.Location = new System.Drawing.Point(129, 67);
            this.lblAuthorLink.Name = "lblAuthorLink";
            this.lblAuthorLink.Size = new System.Drawing.Size(129, 13);
            this.lblAuthorLink.TabIndex = 1;
            this.lblAuthorLink.TabStop = true;
            this.lblAuthorLink.Text = "http://twitter.com/Kirnehx";
            this.lblAuthorLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblAuthorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAuthorLink_LinkClicked);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick_1);
            // 
            // Main_Timer
            // 
            this.Main_Timer.Interval = 5000;
            this.Main_Timer.Tick += new System.EventHandler(this.Main_Timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NPS.Properties.Resources.KirnFace;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tcUpdate
            // 
            this.tcUpdate.Controls.Add(this.lblUpdateHeader);
            this.tcUpdate.Controls.Add(this.cbUpdate);
            this.tcUpdate.Location = new System.Drawing.Point(4, 22);
            this.tcUpdate.Name = "tcUpdate";
            this.tcUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tcUpdate.Size = new System.Drawing.Size(471, 103);
            this.tcUpdate.TabIndex = 2;
            this.tcUpdate.Text = "Update";
            this.tcUpdate.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(134, 45);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(227, 17);
            this.cbUpdate.TabIndex = 0;
            this.cbUpdate.Text = "Automatically check for updates on launch";
            this.cbUpdate.UseVisualStyleBackColor = true;
            this.cbUpdate.CheckedChanged += new System.EventHandler(this.cbUpdate_CheckedChanged);
            // 
            // lblUpdateHeader
            // 
            this.lblUpdateHeader.AutoSize = true;
            this.lblUpdateHeader.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateHeader.Location = new System.Drawing.Point(7, 4);
            this.lblUpdateHeader.Name = "lblUpdateHeader";
            this.lblUpdateHeader.Size = new System.Drawing.Size(72, 21);
            this.lblUpdateHeader.TabIndex = 8;
            this.lblUpdateHeader.Text = "Updates";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 154);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPS - Now Playing on Spotify";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tcMain.ResumeLayout(false);
            this.tabCapture.ResumeLayout(false);
            this.tabCapture.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tcSettings.ResumeLayout(false);
            this.tcSettingsText.ResumeLayout(false);
            this.tcSettingsText.PerformLayout();
            this.tcSettingsSave.ResumeLayout(false);
            this.tcSettingsSave.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcUpdate.ResumeLayout(false);
            this.tcUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabCapture;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Main_Timer;
        private System.Windows.Forms.Label lblAuthorDescription;
        private System.Windows.Forms.LinkLabel lblAuthorLink;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tcSettingsText;
        private System.Windows.Forms.TabPage tcSettingsSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblSettingText;
        private System.Windows.Forms.TextBox tbCustomizeOutput;
        private System.Windows.Forms.Label lblCustomizeHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCustomizeSave;
        private System.Windows.Forms.Label lblOpenSpotify;
        private System.Windows.Forms.TabPage tcUpdate;
        private System.Windows.Forms.Label lblUpdateHeader;
        private System.Windows.Forms.CheckBox cbUpdate;
    }
}

