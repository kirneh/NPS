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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabCapture = new System.Windows.Forms.TabPage();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnLocation = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblAuthorDescription = new System.Windows.Forms.Label();
            this.lblAuthorLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Main_Timer = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.tabCapture.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabCapture);
            this.TabControl.Controls.Add(this.tabSettings);
            this.TabControl.Controls.Add(this.tabAbout);
            this.TabControl.Location = new System.Drawing.Point(1, 3);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(483, 151);
            this.TabControl.TabIndex = 0;
            // 
            // tabCapture
            // 
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
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Underline);
            this.StatusLabel.Location = new System.Drawing.Point(9, 11);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(108, 19);
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
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.btnSaveSettings);
            this.tabSettings.Controls.Add(this.lblLocation);
            this.tabSettings.Controls.Add(this.btnLocation);
            this.tabSettings.Controls.Add(this.txtLocation);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(475, 125);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.label2.Location = new System.Drawing.Point(0, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remember to save!";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveSettings.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.btnSaveSettings.Location = new System.Drawing.Point(194, 83);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 34);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(6, 15);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(128, 20);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Output location";
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(364, 39);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(104, 22);
            this.btnLocation.TabIndex = 1;
            this.btnLocation.Text = "Choose Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(8, 40);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(350, 20);
            this.txtLocation.TabIndex = 0;
            // 
            // tabAbout
            // 
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
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.lblAuthorName.Location = new System.Drawing.Point(129, 26);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(92, 16);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Made by Kirnehx";
            // 
            // lblAuthorDescription
            // 
            this.lblAuthorDescription.AutoSize = true;
            this.lblAuthorDescription.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.lblAuthorDescription.Location = new System.Drawing.Point(129, 46);
            this.lblAuthorDescription.Name = "lblAuthorDescription";
            this.lblAuthorDescription.Size = new System.Drawing.Size(213, 16);
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
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick_1);
            // 
            // Main_Timer
            // 
            this.Main_Timer.Interval = 1000;
            this.Main_Timer.Tick += new System.EventHandler(this.Main_Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 154);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPS - Now Playing on Spotify";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TabControl.ResumeLayout(false);
            this.tabCapture.ResumeLayout(false);
            this.tabCapture.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabCapture;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Main_Timer;
        private System.Windows.Forms.Label lblAuthorDescription;
        private System.Windows.Forms.LinkLabel lblAuthorLink;
        private System.Windows.Forms.Label lblAuthorName;
    }
}

