using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_downloadergui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void download_Click(object sender, EventArgs e)
        {
            MessageBox.Show("it may look like its frozen its probably not", "AAAAAAAAAAAAA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            downloadee();

        }
        public void downloadee()
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "youtube-dl.exe";
                startInfo.CreateNoWindow = true;
                startInfo.Arguments = "-F " + '"' + tubelink.Text + '"';
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                process.StartInfo = startInfo;
                process.Start();
                det.Text = process.StandardOutput.ReadToEnd();
            }
            catch { }
        }
        public void downloadere()
        {
            try
            {
                string x = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "youtube-dl.exe";
                startInfo.CreateNoWindow = true;
                startInfo.Arguments = "-o " + x + @"\Downloads/%(playlist_index)s-%(title)s" + listBox1.SelectedItem + " -f " + textBox1.Text + " " + '"' + tubelink.Text + '"';
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                process.StartInfo = startInfo;
                process.Start();
                det.Text = process.StandardOutput.ReadToEnd();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("it may look like its frozen its probably not", "AAAAAAAAAAAAA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            downloadere();
            //det.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\" + tubelink.Text + Convert.ToString(listBox1.SelectedItem);
        }
    }
}
