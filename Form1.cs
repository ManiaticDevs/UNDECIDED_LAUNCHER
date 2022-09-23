using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Media;

namespace UNDECIDED_LAUNCHER
{
    
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(@"C:\Windows\Media\Windows Background.wav");
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string Paths;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                //0.1
                case 0: getVersion("0.1", "0.1.zip", "https://download1523.mediafire.com/27znxqd0iohg/muyogt6j4wuj4uc/0.1.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.1\UNDECIDED.exe", "UNDECIDED 0.1"); break;
                //0.2
                case 1: getVersion("0.2", "0.2.zip", "https://download1586.mediafire.com/6a8y0y52n7dg/sn38sdj55ob77w3/0.2.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.2\UNDECIDED.exe", "UNDECIDED 0.2"); break;
                case 2: getVersion("0.2.1", "0.2.1.zip", "https://download1590.mediafire.com/6zhubj03yfng/mivxwxepns92fr1/BUGFIX0.2.1.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.2.1\UNDECIDED.exe", "UNDECIDED 0.2.1"); break;
                case 3: getVersion("0.2.2", "0.2.2.zip", "https://download1336.mediafire.com/cay9tctqh5lg/xig224m7qic8498/BUGFIX0.2.2.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.2.2\UNDECIDED.exe", "UNDECIDED 0.2.2"); break;
                //0.3
                case 4: getVersion("0.3", "0.3.zip", "https://download1529.mediafire.com/r54oxzcvs0lg/4t85o04b0vtvc81/BUGFIX0.3.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.3\UNDECIDED.exe", "UNDECIDED 0.3"); break;
                case 5: getVersion("0.3.1", "0.3.1.zip", "https://download1327.mediafire.com/w8iw9ceqbheg/v1zb5bq9eudfojq/BUGFIX0.3.1.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.3.1\UNDECIDED.exe", "UNDECIDED 0.3.1"); break;
                case 6: getVersion("0.3.2", "0.3.2.zip", "https://download1580.mediafire.com/96ai0bwoqk2g/rfcw49zsyr4bcty/BUGFIX0.3.2.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.3.2\UNDECIDED.exe", "UNDECIDED 0.3.2"); break;
                case 7: getVersion("0.3.3", "0.3.3.zip", "https://download1655.mediafire.com/xbccqnhwp9og/x5iqldzuzdrw7eo/BUGFIX0.3.3.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.3.3\UNDECIDED.exe", "UNDECIDED 0.3.3"); break;
                //0.4
                case 8: getVersion("0.4", "0.4.zip", "https://download1530.mediafire.com/1agr2ce7hfrg/qnemz436ulys5k3/0.4.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.4\UNDECIDED.exe", "UNDECIDED 0.4"); break;
                case 9: getVersion("0.4.1", "0.4.1.zip", "https://download1325.mediafire.com/c2c5vq87y4rg/0gtxnn8ysk4lt3z/0.4.1.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.4.1\UNDECIDED.exe", "UNDECIDED 0.4.1"); break;
                //0.5
                case 10: getVersion("0.5", "0.5.zip", "https://download1324.mediafire.com/udq15pck69pg/79adcnaded3atlo/0.5.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.5\UNDECIDED.exe", "UNDECIDED 0.5"); break;
                case 11: getVersion("0.5.1", "0.5.1.zip", "https://download1349.mediafire.com/gv0kkjn8jxyg/ms4wku2rotcej00/0.5.1.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.5.1\UNDECIDED.exe", "UNDECIDED 0.5.1"); break;
                //0.6
                case 12: getVersion("0.6", "0.6.zip", "https://download1532.mediafire.com/gv323ymhs39g/hfykz31hbinwahq/0.6.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.6\UNDECIDED.exe", "UNDECIDED 0.6"); break;
                case 13: getVersion("0.6.1", "0.6.1.zip", "https://download1647.mediafire.com/68tv7vu5xayg/4its4jlofdza6y5/0.6.1.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.6.1\UNDECIDED.exe", "UNDECIDED 0.6.1"); break;
                //0.7
                case 14: getVersion("0.7", "0.7.zip", "https://download1588.mediafire.com/v5zzjaqh43pg/9k3jkcsxrvac7b9/0.7.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.7\UNDECIDED.exe", "UNDECIDED 0.7"); break;
                //0.8
                case 15: getVersion("0.8", "0.8.zip", "https://download1530.mediafire.com/84b4t4hfniqg/yneujzqp602e2kh/0.8.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.8\UNDECIDED.exe", "UNDECIDED 0.8"); break;
                case 16: getVersion("0.8.1", "0.8.1.zip", "https://download1322.mediafire.com/24kk5n9mbjug/hnced7o7zhvpmgx/0.8.1.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.8.1\UNDECIDED.exe", "UNDECIDED 0.8.1"); break;
                case 17: getVersion("0.8.2", "0.8.2.zip", "https://download1530.mediafire.com/83m7y74yzgog/408qdzoqn1xxpwc/0.8.2.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.8.2\UNDECIDED.exe", "UNDECIDED 0.8.2"); break;
                case 18: getVersion("0.8.3", "0.8.3.zip", "https://download1338.mediafire.com/bnoeieav30gg/r99z2knptyzt785/0.8.3.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.8.3\UNDECIDED.exe", "UNDECIDED 0.8.3"); break;
                case 19: getVersion("0.8.4", "0.8.4.zip", "https://download1351.mediafire.com/y908ltyqcnhg/9s0y00tjts3xrrc/0.8.4.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.8.4\UNDECIDED.exe", "UNDECIDED 0.8.4"); break;
                case 20: getVersion("0.8.5", "0.8.5.zip", "https://download854.mediafire.com/v9pzwead2b5g/12pvnh5xecu48cm/0.8.5.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.8.5\UNDECIDED.exe", "UNDECIDED 0.8.5"); break;
                //0.9
                case 21: getVersion("0.9", "0.9.zip", "https://download1507.mediafire.com/72mywpunar5g/8fzysyqkthy44ym/0.9.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.9\UNDECIDED.exe", "UNDECIDED 0.9"); break;
                case 22: getVersion("0.9.1", "0.9.1.zip", "https://download1334.mediafire.com/5ru4kscwufag/qkughv93rsnt0qf/0.9.1-windows.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.9.1\UNDECIDED.exe", "UNDECIDED 0.9.1"); break;
                case 23: getVersion("0.9.1.1", "0.9.1.1.zip", "https://download1521.mediafire.com/bj7hayiraosg/mj7syu1zlbxo5zg/0.9.1.1-windows.zip"); progressBar1.Visible = false; CreateShortcut("UNDECIDED", desktop, desktop + @"\UNDECIDED-LAUNCHER\installations\0.9.1.1\UNDECIDED.exe", "UNDECIDED 0.9.1.1"); break;
            }
        }    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getVersion(string path, string zip, string link)
        {
            if(textBox1.Text != "")
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                var client = new WebClient();
                if (!Directory.Exists(Paths + @"\zips\"))
                {
                    Directory.CreateDirectory(Paths + @"\zips\");
                }
                if (!Directory.Exists(Paths + @"\installations\"))
                {
                    Directory.CreateDirectory(Paths + @"\installations\");
                }
                if (!File.Exists(Paths + @"\zips\" + @zip))
                {
                    progressBar1.Value = 25;
                    //File.Delete(@zip);
                    progressBar1.Value = 50;
                    client.DownloadFile(link, Paths + @"\zips\" + @zip);

                }
                if (Directory.Exists(Paths + @"\installations\" + @path))
                {
                    progressBar1.Value = 75;
                    Directory.Delete(Paths + @"\installations\" + @path, true);
                }
                ZipFile.ExtractToDirectory(Paths + @"\zips\" + @zip, Paths + @"\installations\" + @path);
                player.Play();
                progressBar1.Value = 100;
                MessageBox.Show("download is done wake up.", "", MessageBoxButtons.OK);
            }
            
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation, string desc)
        {
            string shortcutLocation = Path.Combine(shortcutPath, shortcutName + ".lnk");
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = desc;                                                                                            // The description of the shortcut
            shortcut.IconLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\UNDECIDED-LAUNCHER\icon.ico"; // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                                                                               // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                                                                                        // Save the shortcut
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                label2.Visible = false;
            }
            if (textBox1.Text == "")
            {
                label2.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

