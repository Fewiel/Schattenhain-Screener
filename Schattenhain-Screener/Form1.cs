using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schattenhain_Screener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblversion.Text = "1.0";
            tbSpeicherort.Text = Properties.Settings.Default.SavePath;
            tbIntervall.Text = Properties.Settings.Default.Intervall;
            timer1.Interval = Convert.ToInt32(tbIntervall.Text) + 1000;
            btnStart.BackColor = Color.Red;
            tbProc.Text = Properties.Settings.Default.ProcName;

            try
            {
                WebClient wClient = new WebClient();
                string strSource = wClient.DownloadString("https://shs.fewiel.de/version.txt");
                if (strSource != "1.0")
                {
                    lblversion.BackColor = Color.Red;
                    btnDownload.Visible = true;
                    MessageBox.Show("Update Verfügbar: " + strSource);
                }
            }
            catch (Exception)
            {
                lblversion.Text = "Updateserver nicht erreichbar.";
            }
        }

        public void CaptureApplication(string procName)
        {
            var proc = Process.GetProcessesByName(procName)[0];
            var rect = new User32.Rect();
            User32.GetWindowRect(proc.MainWindowHandle, ref rect);

            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;
            try
            {
                var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
                using (Graphics graphics = Graphics.FromImage(bmp))
                {
                    graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                }
                var savepath = Path.Combine(tbSpeicherort.Text, DateTime.Now.ToString("dd_MM_yyyy"));
                if (!Directory.Exists(savepath))
                {
                    Directory.CreateDirectory(savepath);
                }
                var fullPath = Path.Combine(savepath, tbProc.Text + " " + DateTime.Now.ToString("dd_MM_yyyy HH-mm-ss") + ".jpeg");
                bmp.Save(@fullPath, ImageFormat.Jpeg);
            }
            catch (Exception)
            {

            }
        }

        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct Rect
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        }

        private void TbSpeicherort_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbSpeicherort.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void TbSpeicherort_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SavePath = tbSpeicherort.Text;
            Properties.Settings.Default.Save();
        }

        private void TbIntervall_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Intervall = tbIntervall.Text;
            Properties.Settings.Default.Save();
            timer1.Interval = Convert.ToInt32(tbIntervall.Text) + 1000;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (tbSpeicherort.Text?.Length == 0)
            {
                MessageBox.Show("Speicherort festlegen!");
                return;
            }
            if (Convert.ToInt32(tbIntervall.Text) < 10)
            {
                MessageBox.Show("Ein Intervall von unter 10 Sek wird nicht empfohlen.");
                return;
            }
            timer1.Interval = Convert.ToInt32(tbIntervall.Text) * 1000;
            if (!timer1.Enabled)
            {
                btnStart.BackColor = Color.Green;
                timer1.Start();
                return;
            }
            timer1.Stop();
            btnStart.BackColor = Color.Red;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(tbProc.Text) == null || Process.GetProcessesByName(tbProc.Text).Length == 0)
            {
                timer1.Stop();
                btnStart.BackColor = Color.Red;
                MessageBox.Show("Schattenhain beendet. Schnüffler Gestoppt!");
                return;
            }
            CaptureApplication(tbProc.Text);
            CreateZip();
        }

        private void TbProc_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProcName = tbProc.Text;
            Properties.Settings.Default.Save();
        }

        private void CreateZip()
        {
            var archivPath = Path.Combine(tbSpeicherort.Text, "archiv");

            if (!Directory.Exists(Path.Combine(tbSpeicherort.Text, "archiv")))
                Directory.CreateDirectory(Path.Combine(tbSpeicherort.Text, "archiv"));


            foreach (var d in Directory.GetDirectories(tbSpeicherort.Text))
            {
                DirectoryInfo dir = new DirectoryInfo(d);
                String dirName = dir.Name;
                if (dirName.Contains("archiv")) continue;
                var newArchivPath = Path.Combine(archivPath, dirName + ".zip");

                if (Directory.GetCreationTime(d) < DateTime.Now.AddDays(-1))
                {
                    ZipFile.CreateFromDirectory(d, newArchivPath, CompressionLevel.Optimal, true);
                    Directory.Delete(d, true);
                }
            }

            foreach (var f in Directory.GetFiles(archivPath))
            {
                DateTime dateString = File.GetCreationTime(f);
                if (dateString < DateTime.Now.AddDays(-14))
                {
                    File.Delete(f);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kontakt auf Schattenhain Discord: Fewiel" + Environment.NewLine + "Email-Kontat: info@panther-host.de");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient wClient = new WebClient(); 
            string target = wClient.DownloadString("https://shs.fewiel.de/download.txt");
            try
            {
                Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}
