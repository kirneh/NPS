using NPS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPS
{
    public partial class MainForm : Form
    {
        private string lastArtistName = "N/A";
        private string logPath = Application.StartupPath + @"\NPS-log.txt";
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("shell32.dll")]
        public static extern bool IsUserAnAdmin();
        private bool enabled;
        public MainForm()
        {
            if (!HasNet35())
                MessageBox.Show(".Net Framework 3.5 not found. NPS may not work properly.", "NPS");

            InitializeComponent();
            if (Properties.Settings.Default.FirstTime == true)
            {
                TabControl.SelectedTab = tabSettings;
                Properties.Settings.Default.SaveLocation = Application.StartupPath + @"\NPS.txt";
                Properties.Settings.Default.FirstTime = false;
                Properties.Settings.Default.Save();
            }

            // Front Page

            enabled = false;

            WebHelperResult whr = WebHelperHook.GetStatus();

            if (!whr.isRunning)
            {
                StatusLabel.Text = "Spotify is not running";
            }

            // Settings Page

            // About Page

            // Else
            txtLocation.Text = Properties.Settings.Default.SaveLocation;            
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WindowUtilities.WM_SHOWAPP)
            {
                if (!this.ShowInTaskbar)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                }
                else
                {
                    this.Activate();
                }
            }
            base.WndProc(ref m);
        }

        bool HasNet35()
        {
            try
            {
                AppDomain.CurrentDomain.Load(
                    "System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".txt";
            sfd.Filter = "Text file|*.txt;";
            sfd.FileName = "NPS.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = sfd.FileName;
            }

            Console.WriteLine(sfd); // <-- For debugging use.
        }

        private void Main_Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                WebHelperResult whr = WebHelperHook.GetStatus();

                if (!whr.isRunning)
                {
                    StatusLabel.Text = "Spotify is not running";
                    lastArtistName = "N/A";
                }
                else if (!whr.isPlaying)
                {
                    StatusLabel.Text = "Spotify is paused";
                    lastArtistName = "N/A";
                }
                else // Song is playing
                {
                    if (lastArtistName != whr.artistName)
                    {
                        StatusLabel.Text = "Playing: " + whr.artistName + " - " + whr.trackName;
                        lastArtistName = whr.artistName;
                        File.WriteAllText(Properties.Settings.Default.SaveLocation, whr.artistName + " - " + whr.trackName);
                    }
                }
            }
            catch (Exception except)
            {
                StatusLabel.Text = "Connection Error";
                WebHelperHook.CheckWebHelper();
                Console.WriteLine(except);
                File.WriteAllText(logPath, except.ToString());
            }
        }

        private string ShortenName(string name)
        {
            if (name.Length > 12)
            {
                return name.Substring(0, 12) + "...";
            }
            return name;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (!enabled)
            {
                Main_Timer.Enabled = true;
                btnCapture.Text = "Stop capturing!";
                enabled = true;
            }
            else
            {
                Main_Timer.Enabled = false;
                btnCapture.Text = "Start capturing!";
                enabled = false;
                StatusLabel.Text = "Not capturing...";
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveLocation = txtLocation.Text;
        }

        private void lblAuthorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://twitter.com/Kirnehx");
        }
        private void Notify(String message)
        {
            NotifyIcon.ShowBalloonTip(10000, "NPS", message, ToolTipIcon.None);
        }
        private void NotifyIcon_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (!this.ShowInTaskbar)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }
        private void NotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                Notify("NPS is hidden. Double-click this icon to restore.");
            }
        }
    }
}
