using NPS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPS
{
    public partial class MainForm : Form
    {
        private string lastArtistName = "N/A";
        private string jsonPath = Application.StartupPath + @"\Newtonsoft.Json.dll";
        private string logPath = Application.StartupPath + @"\NPS-log.txt";
        private string NPSUA = "NPS " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " " + System.Environment.OSVersion;
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("shell32.dll")]
        public static extern bool IsUserAnAdmin();
        private bool enabled;
        private const string website = @"https://github.com/kirneh/Now-Playing-on-Spotify/releases";


        public MainForm()
        {
            if (!HasNet35())
                MessageBox.Show(".Net Framework 3.5 not found. NPS may not work properly.", "NPS");

            InitializeComponent();

            if (Settings.Default.FirstTime == 1)
            {
                Settings.Default.SaveLocation = Application.StartupPath + @"\NPS.txt";
                Settings.Default.FirstTime = 0;
                Settings.Default.Save();
            }

            try
            {
                if (!File.Exists(jsonPath))
                {
                    File.WriteAllBytes(jsonPath, Properties.Resources.Newtonsoft_Json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show("Error loading NPS dependencies. Please run NPS as administrator or put NPS in a user folder.");
            }
            WebHelperResult whr = WebHelperHook.GetStatus();

            // Front Page

            enabled = false;

            if (!whr.isRunning)
            {
                StatusLabel.Text = "Spotify is not running";
                lblOpenSpotify.Visible = true;
            }

            // Settings Page

            tbCustomizeOutput.Text = Settings.Default.OutputText;
            cbUpdate.Checked = Properties.Settings.Default.UpdateSettings;

            if (Properties.Settings.Default.UpdateSettings == true)
            {
                CheckUpdate();
            }

            // About Page

            lblVersion.Text = "v." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.MinorRevision.ToString();

            // Else
            txtLocation.Text = Settings.Default.SaveLocation;

            try
            {
                if (!File.Exists(jsonPath))
                {
                    File.WriteAllBytes(jsonPath, Properties.Resources.Newtonsoft_Json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show("Error loading NPS dependencies. Please run NPS as administrator or put NPS in a user folder.");
            }

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
            WebHelperResult whr = WebHelperHook.GetStatus();

            try
            {
                if (!whr.isRunning)
                {
                    StatusLabel.Text = "Spotify is not running";
                    lastArtistName = "N/A";
                    lblOpenSpotify.Visible = true;
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
                        File.WriteAllText(Settings.Default.SaveLocation, CustomOutput(Settings.Default.OutputText));
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

        public string CustomOutput(string text)
        {
            WebHelperResult whr = WebHelperHook.GetStatus();

            if (text != string.Empty)
            {
                string back;

                back = text.Replace("{artist}", whr.artistName).Replace("{song}", whr.trackName);

                return back;
            }
            else
            {
                return null;
            }
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
            Settings.Default.SaveLocation = txtLocation.Text;

            btnSaveSettings.Enabled = false;

            string originalText = btnSaveSettings.Text;

            var backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += (s, ea) => Thread.Sleep(TimeSpan.FromSeconds(2));

            backgroundWorker1.RunWorkerCompleted += (s, ea) =>
            {
                btnSaveSettings.Text = originalText;
                btnSaveSettings.Enabled = true;
            };

            btnSaveSettings.Text = "Saved!";

            backgroundWorker1.RunWorkerAsync();
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

        private void btnCustomizeSave_Click(object sender, EventArgs e)
        {
            if (tbCustomizeOutput.Text.Contains("{artist}") || tbCustomizeOutput.Text.Contains("{song}"))
            {
                Settings.Default.OutputText = tbCustomizeOutput.Text;

                btnCustomizeSave.Enabled = false;

                string originalText = btnCustomizeSave.Text;

                var backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += (s, ea) => Thread.Sleep(TimeSpan.FromSeconds(2));

                backgroundWorker.RunWorkerCompleted += (s, ea) =>
                {
                    btnCustomizeSave.Text = originalText;
                    btnCustomizeSave.Enabled = true;
                };

                btnCustomizeSave.Text = "Saved!";

                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please check your text. Must contain either {artist} or {song}");
            }
        }

        private void lblCustomizeHelp_Click(object sender, EventArgs e)
        {
            TextHelp th = new TextHelp();
            th.Show();
        }

        private void lblOpenSpotify_Click(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetEnvironmentVariable("APPDATA") + @"\Spotify\Spotify.exe"))
            {
                System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("APPDATA") + @"\Spotify\Spotify.exe");
                lblOpenSpotify.Hide();
            }
            else
            {
                MessageBox.Show("Spotify is not installed.");
            }
        }

        private string GetPage(string URL, string ua)
        {
            WebClient w = new WebClient();
            w.Headers.Add("user-agent", ua);
            string s = w.DownloadString(URL);
            return s;
        }

        /**
         * Checks if the current installation is the latest version. Prompts user if not.
         **/
        private void CheckUpdate()
        {
            try
            {
                int latest = Convert.ToInt32(GetPage("https://raw.githubusercontent.com/kirneh/Now-Playing-on-Spotify/master/version.txt?time" + DateTime.Now.ToString(), NPSUA));
                int current = Convert.ToInt32(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.MinorRevision.ToString());
                if (latest <= current)
                    return;
                if (MessageBox.Show("There is a newer version of NPS available. Would you like to upgrade?", "NPS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start(website);
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error checking for update.", "NPS");
                Console.WriteLine(except);
                File.WriteAllText(logPath, except.ToString());
            }
        }

        private void cbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpdate.Checked)
            {
                Properties.Settings.Default.UpdateSettings = true;
            }
            if (!cbUpdate.Checked)
            {
                Properties.Settings.Default.UpdateSettings = false;
            }
        }
    }
}
