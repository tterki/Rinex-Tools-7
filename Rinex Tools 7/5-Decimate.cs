using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rinex_Tools_6
{
    public partial class Decimate : Form
    {
        public Decimate()
        {
            InitializeComponent();
        }

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
        //====================================================================================================================//
        private void btnDecimate_Click(object sender, EventArgs e)
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
            int From = Convert.ToInt32(tbFrom.Text);
            int To = Convert.ToInt32(tbTo.Text);

            progress.Maximum = To - From + 1;
            progress.Value = 0;
            string station = tbCode.Text; ;
            btnDecimate.Enabled = false;

            for (int i = From; i <= To; i++)
            {
                await StartDecimate(i, station);

                //====================================================================================================================
                // Conversion de la date GPS sur 3 digits :
                //=========================================
                string Day4;
                if (i < 10)
                {
                    Day4 = "00" + i;
                }
                else if (i < 100)
                {
                    Day4 = "0" + i;
                }
                else
                {
                    Day4 = Convert.ToString(i);
                }
                progress.Value++;
            }

            MessageBox.Show("Done !");
            btnDecimate.Enabled = true;

            //====================================================================================================================
            // Suppression du sous-dossier "Decimated" s'il est vide :
            //================================================
            if (Directory.EnumerateFiles(userSelectedFilePath + "\\Decimated_" + cbOutputRate.Text).Count() == 0)
            {
                MessageBox.Show("Decimated_" + cbOutputRate.Text + " vide");
                Directory.Delete(userSelectedFilePath + "\\Decimated_" + cbOutputRate.Text);
            }
            //====================================================================================================================
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
        }
        //===============================================================================================================
        private async Task StartDecimate(int i, string Station)
        {
            string Code = tbCode.Text;
            //====================================================================================================================
            // Conversion de la date GPS sur 3 digits :
            //=========================================
            string Day;
            if (i < 10)
            {
                Day = "00" + i;
            }
            else if (i < 100)
            {
                Day = "0" + i;
            }
            else
            {
                Day = Convert.ToString(i);
            }
            //====================================================================================================================
            // Créer sous-dossier "Decimated" :
            //=========================
            if (!Directory.Exists(userSelectedFilePath + "\\Decimated_" + cbOutputRate.Text))
            {
                System.IO.Directory.CreateDirectory(userSelectedFilePath + "\\Decimated_" + cbOutputRate.Text);
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
            DirectoryInfo root = new DirectoryInfo(userSelectedFilePath);
            FileInfo[] listfiles4 = root.GetFiles(tbCode.Text + Day + "0.**o");
            foreach (FileInfo file4 in listfiles4)
            {
                string ex = Path.GetExtension(Convert.ToString(file4));
                //MessageBox.Show("extension = " + ex);
                string Instruction = "/C teqc -O.dec " + cbOutputRate.Text + " " + Code + Day + "0" + ex + " > Decimated_" + cbOutputRate.Text + "\\" + Code + Day + "0" + ex;
                tbstatus.Text = "       teqc -O.dec " + cbOutputRate.Text + " " + Station + Day + "0" + ex + " > Decimated\\" + Station + Day + "0" + ex;
                //MessageBox.Show(Instruction4);
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
                p.StartInfo.Arguments = Instruction;
                await Task.Run
                    (() =>
                    {
                        p.Start();
                    });
            }
        }
    }
}

