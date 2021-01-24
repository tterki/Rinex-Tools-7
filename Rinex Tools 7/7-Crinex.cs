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
using System.Diagnostics;

namespace Rinex_Tools_7
{
    public partial class Crinex : Form
    {
        public Crinex()
        {
            InitializeComponent();
        }

        private void radio_CRXtoRNX_CheckedChanged(object sender, EventArgs e)
        {
            check_Z.Enabled = false;
        }

        private void radio_RNXtoCRX_CheckedChanged(object sender, EventArgs e)
        {
            check_Z.Enabled = true;
        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        // Bouton Start :
        //---------------
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbPath.Text == "")
            {
                toolTip.Show("Data source", tbPath, 5000);
            }

            else
            {
                //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                // Copier "CRX 2 RNX" ou "RNX 2 CRX" sur répertoire des données :
                //-----------------------------------------
                if (radio_CRXtoRNX.Checked == true)
                {
                    if (Directory.Exists(userSelectedFilePath))
                    {
                        if (!File.Exists(userSelectedFilePath + "\\crx2rnx.exe"))
                        {
                            byte[] exeBytes = Rinex_Tools_7.Properties.Resources.teqc;
                            string exeToRun = userSelectedFilePath + "\\crx2rnx.exe";

                            using (FileStream exeFile = new FileStream(exeToRun, FileMode.CreateNew))
                            {
                                exeFile.Write(exeBytes, 0, exeBytes.Length);
                            }

                            using (Process exeProcess = Process.Start(exeToRun))
                            {
                                exeProcess.WaitForExit();
                            }
                        }
                    }
                }

                else //(radio_RNXtoCRX.Checked)
                {
                    if (Directory.Exists(userSelectedFilePath))
                    {
                        if (!File.Exists(userSelectedFilePath + "\\rnx2crx.exe"))
                        {
                            byte[] exeBytes = Rinex_Tools_7.Properties.Resources.teqc;
                            string exeToRun = userSelectedFilePath + "\\rnx2crx.exe";

                            using (FileStream exeFile = new FileStream(exeToRun, FileMode.CreateNew))
                            {
                                exeFile.Write(exeBytes, 0, exeBytes.Length);
                            }

                            using (Process exeProcess = Process.Start(exeToRun))
                            {
                                exeProcess.WaitForExit();
                            }
                        }
                    }
                }
                //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            }
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            
            LoadNewFile();
        }
        public string userSelectedFilePath
        {
            get
            {
                return tbPath.Text;
            }
            set
            {
                tbPath.Text = value;
            }
        }
        private void LoadNewFile()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.SelectedPath = @"D:\";  // Initial directory
            System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = fbd.SelectedPath;
            }
        }
    }
}
