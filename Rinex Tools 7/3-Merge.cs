using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Rinex_Tools_6
{
    public partial class Merge : Form
    {
        public Merge()
        {
            InitializeComponent();
        }

        //================================================================================================
        // Ouvrir :
        //========
        private void btnSource_Click(object sender, EventArgs e)
        {
            LoadNewFile();
        }
        public string userSelectedFilePath
        {
            get
            {
                return tbSource.Text;
            }
            set
            {
                tbSource.Text = value;
            }
        }
        private void LoadNewFile()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.SelectedPath = @"D:\";  // Initial directory

            //fbd.ShowDialog();
            System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = fbd.SelectedPath;
            }
        }

        //===========================================================================================
        // Type de fichiers à concaténer (MDB, observation, navigation) :
        //===============================================================
        private void radio_mdb_CheckedChanged_1(object sender, EventArgs e)
        {
            tbMO.Enabled = false;
            tbMN.Enabled = false;
            tbOp.Enabled = false;
            tbAg.Enabled = false;
            cbAnType.Enabled = false;
            tbAnNum.Enabled = false;
            tbAnH.Enabled = false;
        }

        private void radio_obs_CheckedChanged(object sender, EventArgs e)
        {
            tbMO.Enabled = true;
            tbMN.Enabled = true;
            tbOp.Enabled = true;
            tbAg.Enabled = true;
            cbAnType.Enabled = true;
            tbAnNum.Enabled = true;
            tbAnH.Enabled = true;
        }

        private void radio_nav_CheckedChanged_1(object sender, EventArgs e)
        {
            tbMO.Enabled = true;
            tbMN.Enabled = true;
            tbOp.Enabled = true;
            tbAg.Enabled = true;
            cbAnType.Enabled = true;
            tbAnNum.Enabled = true;
            tbAnH.Enabled = true;
        }
        //=========================================================================================================
        private void btnMerge_Click(object sender, EventArgs e)
        {
            int From; int Frombis;
            int To; int Tobis;

            if (tbSource.Text == "")
            {
                MessageBox.Show("Remplir source des données");
            }
            else if (tbCode.Text == "")
            {
                MessageBox.Show("Remplir code de la station");
            }
            else if (tbCode.Text.Length != 4)
            {
                MessageBox.Show("Le code doit comporter 4 caractères");
            }
            else if (tbFrom.Text == "")
            {
                MessageBox.Show("Remplir intervalle des jours");
            }
            //====================================================================================================================
            // Convertir dates du format string au format int :
            //=================================================
            else if (int.TryParse(tbFrom.Text, out Frombis) == false)
            {
                tbFrom.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (Frombis > 366)
            {
                tbFrom.Text = "";
                MessageBox.Show("Maximum 366");
            }

            else if (int.TryParse(tbTo.Text, out Tobis) == false)
            {
                tbTo.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (Tobis > 366 | Tobis < Frombis)
            {
                tbTo.Text = "";
                MessageBox.Show(Frombis + "<To<367");
            }
            //====================================================================================================================
            else
            {
                From = Frombis;
                To = Tobis;
                progress.Maximum = To - From + 1;

                CalculateAsync();
            }
        }
        //====================================================================================================================
        public async void CalculateAsync()
        {
            int From2 = Convert.ToInt32(tbFrom.Text);
            int To2 = Convert.ToInt32(tbTo.Text);

            progress.Maximum = To2 - From2 + 1;
            progress.Value = 0;
            string station2 = tbCode.Text;
            btnMerge.Enabled = false;

            for (int i = From2; i <= To2; i++)
            {
                await Concatenation(i, station2);

                //====================================================================================================================
                // Conversion de la date GPS sur 3 digits :
                //=========================================
                string Day2;
                if (i < 10)
                {
                    Day2 = "00" + i;
                }
                else if (i < 100)
                {
                    Day2 = "0" + i;
                }
                else
                {
                    Day2 = Convert.ToString(i);
                }

                if (radio_mdb.Checked)
                {
                    tbStatus.Text = "      teqc " + station2 + Day2 + "a.m** > " + station2 + Day2 + "0.**o";
                    progress.Value++;
                }

                else if (radio_obs.Checked)
                {
                    tbStatus.Text = "      teqc " + station2 + Day2 + "0.**o";
                }

                else
                {
                    tbStatus.Text = "      teqc " + station2 + Day2 + "0.**n";
                }

            }
            MessageBox.Show("Done !");
            btnMerge.Enabled = true;

            //====================================================================================================================
            // Suppression du sous-dossier "Merged" s'il est vide :
            //================================================
            if (Directory.EnumerateFiles(userSelectedFilePath + "\\Merged").Count() == 0)
            {
                Directory.Delete(userSelectedFilePath + "\\Merged");
            }
            //====================================================================================================================
            // Suppression TEQC :
            //===================
            if (File.Exists(userSelectedFilePath + "\\teqc.exe"))
            {
                try
                {
                    File.Delete(userSelectedFilePath + "\\teqc.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }//public async void CalculateAsync2()

        //===================================================================================================
        private async Task Concatenation(int i, string station)
        {
            //====================================================================================================================
            // Créer sous-dossier "Merged" :
            //=========================
            if (!Directory.Exists(userSelectedFilePath + "\\Merged")) // 
            {
                System.IO.Directory.CreateDirectory(userSelectedFilePath + "\\Merged");
            }
            //====================================================================================================================
            // Copier TEQC sur répertoire des données :
            //========================================
            if (!File.Exists(userSelectedFilePath + "\\teqc.exe"))
            {
                byte[] exeBytes = Rinex_Tools_7.Properties.Resources.teqc;
                string exeToRun = userSelectedFilePath + "\\teqc.exe";//@"C:\TEST\MyTestExe.exe";

                using (FileStream exeFile = new FileStream(exeToRun, FileMode.CreateNew))
                {
                    exeFile.Write(exeBytes, 0, exeBytes.Length);
                }

                using (Process exeProcess = Process.Start(exeToRun))
                {
                    exeProcess.WaitForExit();
                }
            }
            //====================================================================================================================
            string Code2 = tbCode.Text;
            string MO2 = "-O.mo " + tbCode.Text;
            string OutputCode2 = Code2;
            string MN2;
            string Op2;
            string Ag2;
            string AnType2;
            string AnNum2;
            string AnH2;
            //=========================
            if (tbMO.Text != "")
            {
                MO2 = "-O.mo " + tbMO.Text;
                OutputCode2 = tbMO.Text;
            }
            else
            {
                MO2 = "-O.mo " + tbCode.Text;
                OutputCode2 = tbCode.Text;
            }
            //=========================
            if (tbMN.Text != "")
            {
                MN2 = "-O.mn " + tbMN.Text;
            }
            else
            {
                MN2 = null;
            }
            //=========================
            if (tbOp.Text != "")
            { Op2 = "-O.o " + tbOp.Text + " "; }
            else { Op2 = null; }
            //=========================
            if (tbAg.Text != "")
            { Ag2 = "-O.ag " + tbAg.Text; }
            else { Ag2 = "-O.ag C.R.A.A.G."; }
            //=========================
            if (cbAnType.Text != "")
            { AnType2 = "-O.at " + cbAnType.Text; }
            else { AnType2 = null; }
            //=========================
            if (tbAnNum.Text != "")
            { AnNum2 = "-O.an " + tbAnNum.Text; }
            else { AnNum2 = null; }
            //=========================
            if (tbAnH.Text != "")
            {
                AnH2 = "-O.pe " + tbAnH.Text + " 0.0000 0.0000";
            }
            else { AnH2 = null; }

            //====================================================================================================================
            // Conversion de la date GPS sur 3 digits :
            //=========================================
            string Day2;
            if (i < 10)
            {
                Day2 = "00" + i;
            }
            else if (i < 100)
            {
                Day2 = "0" + i;
            }
            else
            {
                Day2 = Convert.ToString(i);
            }
            //====================================================================================================================
            string Instruction2 = "/C copy /b " + Code2 + Day2 + "*.m** Merged\\" + Code2 + Day2 + "a.m00";

            if (radio_mdb.Checked)
            {
                Instruction2 = "/C copy /b " + Code2 + Day2 + "*.m** Merged\\" + Code2 + Day2 + "a.m00";
            }

            else if (radio_obs.Checked)
            {
                Instruction2 = "/C teqc " + MO2 + " " + MN2 + " " + AnType2 + " " + AnNum2 + " " + AnH2 + " " + Op2 + " " + Ag2 + " +obs + -tbin 1d " + "Merged\\" + tbCode.Text + " " + tbCode.Text + Day2 + "*.**o";
            }
            else if (radio_nav.Checked)
            {
                Instruction2 = "/C teqc " + MO2 + " " + MN2 + " " + AnType2 + " " + AnNum2 + " " + AnH2 + " " + Op2 + " " + Ag2 + " +nav + -tbin 1d " + "Merged\\" + tbCode.Text + " " + tbCode.Text + Day2 + "*.**n";
            }

            //====================================================================================================================
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            string MyPath = tbSource.Text + "\\";
            p.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(MyPath);
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Arguments = Instruction2;
            await Task.Run
                (() =>
                {
                    p.Start();
                });
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            tbMN.Text = tbCode.Text;
            tbMO.Text = tbCode.Text;
        }

    }
}
