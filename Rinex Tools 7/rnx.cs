using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Rinex_Tools_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //================================================================================================
        // Ouvrir :
        //========
        private void btnSource1_Click(object sender, EventArgs e)
        {
            LoadNewFile();
        }
        public string userSelectedFilePath
        {
            get
            {
                return tbSource1.Text;
            }
            set
            {
                tbSource1.Text = value;
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
        //=================================================================================================//
        //=================================================================================================//
        //                                              RINEXAGE                                           //
        //=================================================================================================//
        //=================================================================================================//
        private void btnRinex_Click(object sender, EventArgs e)
        {
            int From1; int From1bis;
            int To1; int To1bis;

            if (tbSource1.Text == "")
            {
                MessageBox.Show("Remplir source des données");
            }
            else if (tbCode1.Text == "")
            {
                MessageBox.Show("Remplir code de la station");
            }
            else if (tbCode1.Text.Length != 4)
            {
                MessageBox.Show("Le code doit comporter 4 caractères");
            }
            else if (tbFrom1.Text == "")
            {
                MessageBox.Show("Remplir intervalle des jours");
            }
            //====================================================================================================================
            // Convertir dates du format string au format int :
            //=================================================
            else if (int.TryParse(tbFrom1.Text, out From1bis) == false)
            {
                tbFrom1.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (From1bis > 366)
            {
                tbFrom1.Text = "";
                MessageBox.Show("Maximum 366");
            }

            else if (int.TryParse(tbTo1.Text, out To1bis) == false)
            {
                tbTo1.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (To1bis > 366 | To1bis < From1bis)
            {
                tbTo1.Text = "";
                MessageBox.Show(From1bis + "<To<367");
            }
            //====================================================================================================================
            else
            {
                From1 = From1bis;
                To1 = To1bis;
                progress1.Maximum = To1 - From1 + 1;

                CalculateAsync();
            }
        }
        //=============================================================================================================================
        public async void CalculateAsync()
        {
            int From1 = Convert.ToInt32(tbFrom1.Text);
            int To1 = Convert.ToInt32(tbTo1.Text);

            progress1.Maximum = To1 - From1 + 1;
            progress1.Value = 0;
            string station = tbCode1.Text; ;
            btnRinex.Enabled = false;

            for (int i = From1; i <= To1; i++)
            {
                await Rinexage(i, station);

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

                tbstatus1.Text = "      teqc " + station + Day + "a.m** > " + station + Day + "0.**o";
                progress1.Value++;
            }

            MessageBox.Show("Done !");
            btnRinex.Enabled = true;
            //====================================================================================================================
            // Suppression du sous-dossier "Ok" s'il est vide :
            //================================================
            if (Directory.EnumerateFiles(userSelectedFilePath + "\\Ok").Count() == 0)
            {
                Directory.Delete(userSelectedFilePath + "\\Ok");
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
        }//public async void CalculateAsync()
        //====================================================================================================================
        private async Task Rinexage(int i, string station)
        {
            string Code = tbCode1.Text;
            string MO1 = "-O.mo " + tbCode1.Text;
            string OutputCode = Code;
            string MN1;
            string Op1;
            string Ag1;
            string AnType1;
            string AnNum1;
            string AnH1;
            //=========================
            if (tbMO1.Text != "")
            {
                MO1 = "-O.mo " + tbMO1.Text;
                OutputCode = tbMO1.Text;
            }
            else
            {
                MO1 = "-O.mo " + tbCode1.Text;
                OutputCode = tbCode1.Text;
            }
            //=========================
            if (tbMN1.Text != "")
            {
                MN1 = "-O.mn " + tbMN1.Text;
            }
            else
            {
                MN1 = null;
            }
            //=========================
            if (tbOp1.Text != "")
            { Op1 = "-O.o " + tbOp1.Text + " "; }
            else { Op1 = null; }
            //=========================
            if (tbAg1.Text != "")
            { Ag1 = "-O.ag " + tbAg1.Text; }
            else { Ag1 = "-O.ag C.R.A.A.G."; }
            //=========================
            if (cbAnType1.Text != "")
            { AnType1 = "-O.at " + cbAnType1.Text; }
            else { AnType1 = null; }
            //=========================
            if (tbAnNum1.Text != "")
            { AnNum1 = "-O.an " + tbAnNum1.Text; }
            else { AnNum1 = null; }
            //=========================
            if (tbAnH1.Text != "")
            {
                AnH1 = "-O.pe " + tbAnH1.Text + " 0.0000 0.0000";
            }
            else { AnH1 = null; }
            //====================================================================================================================
            // Créer sous-dossier "Ok" :
            //=========================
            if (!Directory.Exists(userSelectedFilePath + "\\Ok")) // 
            {
                System.IO.Directory.CreateDirectory(userSelectedFilePath + "\\Ok");
            }
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
            string Instruction;

            if (radio_mdb.Checked)
            {
                Instruction = "/C copy /b " + Code + Day + "*.m** Ok\\" + Code + Day + "a.m00";
            }

            if (checkNav1.Checked)
            {
                Instruction = "/C teqc " + MO1 + " " + MN1 + " " + AnType1 + " " + AnNum1 + " " + AnH1 + " " + Op1 + " " + Ag1 + " +obs + +nav +,+ -tbin 1d " + "Ok\\" + OutputCode + " " + Code + Day + "*.m**";
            }
            else
            {
                Instruction = "/C teqc " + MO1 + " " + MN1 + " " + AnType1 + " " + AnNum1 + " " + AnH1 + " " + Op1 + " " + Ag1 + " +obs + -tbin 1d " + "Ok\\" + OutputCode + " " + Code + Day + "*.m**";
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
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            string MyPath = tbSource1.Text + "\\";
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
        }//private async Task Rinexage(int i, string station)


        //=================================================================================================//
        //=================================================================================================//
        //                                           Concaténation                                         //
        //=================================================================================================//
        //================================================================================================
        // Ouvrir :
        //========
        private void btnSource2_Click(object sender, EventArgs e)
        {
            LoadNewFile2();
        }
        public string userSelectedFilePath2
        {
            get
            {
                return tbSource2.Text;
            }
            set
            {
                tbSource2.Text = value;
            }
        }
        private void LoadNewFile2()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.SelectedPath = @"D:\";  // Initial directory

            //fbd.ShowDialog();
            System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath2 = fbd.SelectedPath;
            }
        }
        //===========================================================================================
        // Type de fichiers à concaténer (MDB, observation, navigation) :
        //===============================================================
        private void radio_mdb_CheckedChanged(object sender, EventArgs e)
        {
            tbMO2.Enabled = false;
            tbMN2.Enabled = false;
            tbOp2.Enabled = false;
            tbAg2.Enabled = false;
            cbAnType2.Enabled = false;
            tbAnNum2.Enabled = false;
            tbAnH2.Enabled = false;
        }

        private void radio_obs_CheckedChanged(object sender, EventArgs e)
        {
            tbMO2.Enabled = true;
            tbMN2.Enabled = true;
            tbOp2.Enabled = true;
            tbAg2.Enabled = true;
            cbAnType2.Enabled = true;
            tbAnNum2.Enabled = true;
            tbAnH2.Enabled = true;
        }

        private void radio_nav_CheckedChanged(object sender, EventArgs e)
        {
            tbMO2.Enabled = true;
            tbMN2.Enabled = true;
            tbOp2.Enabled = true;
            tbAg2.Enabled = true;
            cbAnType2.Enabled = true;
            tbAnNum2.Enabled = true;
            tbAnH2.Enabled = true;
        }
        //=================================================================================================================
        // Concaténation :
        //================
        private void btnMerge_Click(object sender, EventArgs e)
        {
            int From2; int From2bis;
            int To2; int To2bis;

            if (tbSource2.Text == "")
            {
                MessageBox.Show("Remplir source des données");
            }
            else if (tbCode2.Text == "")
            {
                MessageBox.Show("Remplir code de la station");
            }
            else if (tbCode2.Text.Length != 4)
            {
                MessageBox.Show("Le code doit comporter 4 caractères");
            }
            else if (tbFrom2.Text == "")
            {
                MessageBox.Show("Remplir intervalle des jours");
            }
            //====================================================================================================================
            // Convertir dates du format string au format int :
            //=================================================
            else if (int.TryParse(tbFrom2.Text, out From2bis) == false)
            {
                tbFrom2.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (From2bis > 366)
            {
                tbFrom2.Text = "";
                MessageBox.Show("Maximum 366");
            }

            else if (int.TryParse(tbTo2.Text, out To2bis) == false)
            {
                tbTo2.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (To2bis > 366 | To2bis < From2bis)
            {
                tbTo2.Text = "";
                MessageBox.Show(From2bis + "<To<367");
            }
            //====================================================================================================================
            else
            {
                From2 = From2bis;
                To2 = To2bis;
                progress2.Maximum = To2 - From2 + 1;

                CalculateAsync2();
            }
        }//private void btnMerge_Click(object sender, EventArgs e)
        //=============================================================================================================================
        public async void CalculateAsync2()
        {
            int From2 = Convert.ToInt32(tbFrom2.Text);
            int To2 = Convert.ToInt32(tbTo2.Text);

            progress2.Maximum = To2 - From2 + 1;
            progress2.Value = 0;
            string station2 = tbCode2.Text;
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

                tbStatus2.Text = "      teqc " + station2 + Day2 + "a.m** > " + station2 + Day2 + "0.**o";
                progress2.Value++;
            }
            MessageBox.Show("Done !");
            btnMerge.Enabled = true;

            //====================================================================================================================
            // Suppression du sous-dossier "Ok" s'il est vide :
            //================================================
            if (Directory.EnumerateFiles(userSelectedFilePath2 + "\\Ok").Count() == 0)
            {
                Directory.Delete(userSelectedFilePath2 + "\\Ok");
            }
            //====================================================================================================================
            // Suppression TEQC :
            //===================
            if (File.Exists(userSelectedFilePath2 + "\\teqc.exe"))
            {
                try
                {
                    File.Delete(userSelectedFilePath2 + "\\teqc.exe");
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
            // Créer sous-dossier "Ok" :
            //=========================
            if (!Directory.Exists(userSelectedFilePath2 + "\\Ok")) // 
            {
                System.IO.Directory.CreateDirectory(userSelectedFilePath2 + "\\Ok");
            }
            //====================================================================================================================
            // Copier TEQC sur répertoire des données :
            //========================================
            if (!File.Exists(userSelectedFilePath2 + "\\teqc.exe"))
            {
                byte[] exeBytes = Rinex_Tools_7.Properties.Resources.teqc;
                string exeToRun = userSelectedFilePath2 + "\\teqc.exe";//@"C:\TEST\MyTestExe.exe";

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
            string Code2 = tbCode2.Text;
            string MO2 = "-O.mo " + tbCode2.Text;
            string OutputCode2 = Code2;
            string MN2;
            string Op2;
            string Ag2;
            string AnType2;
            string AnNum2;
            string AnH2;
            //=========================
            if (tbMO2.Text != "")
            {
                MO2 = "-O.mo " + tbMO2.Text;
                OutputCode2 = tbMO1.Text;
            }
            else
            {
                MO2 = "-O.mo " + tbCode2.Text;
                OutputCode2 = tbCode2.Text;
            }
            //=========================
            if (tbMN2.Text != "")
            {
                MN2 = "-O.mn " + tbMN2.Text;
            }
            else
            {
                MN2 = null;
            }
            //=========================
            if (tbOp2.Text != "")
            { Op2 = "-O.o " + tbOp2.Text + " "; }
            else { Op2 = null; }
            //=========================
            if (tbAg2.Text != "")
            { Ag2 = "-O.ag " + tbAg2.Text; }
            else { Ag2 = "-O.ag C.R.A.A.G."; }
            //=========================
            if (cbAnType2.Text != "")
            { AnType2 = "-O.at " + cbAnType2.Text; }
            else { AnType2 = null; }
            //=========================
            if (tbAnNum2.Text != "")
            { AnNum2 = "-O.an " + tbAnNum2.Text; }
            else { AnNum2 = null; }
            //=========================
            if (tbAnH2.Text != "")
            {
                AnH2 = "-O.pe " + tbAnH2.Text + " 0.0000 0.0000";
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
            string Instruction2 = "/C copy /b " + Code2 + Day2 + "*.m** Ok\\" + Code2 + Day2 + "a.m00";

            if (radio_mdb.Checked)
            {
                Instruction2 = "/C copy /b " + Code2 + Day2 + "*.m** Ok\\" + Code2 + Day2 + "a.m00";
            }

            else if (radio_obs.Checked)
            {
                Instruction2 = "/C teqc " + MO2 + " " + MN2 + " " + AnType2 + " " + AnNum2 + " " + AnH2 + " " + Op2 + " " + Ag2 + " +obs + -tbin 1d " + "Ok\\" + tbCode2.Text + " " + tbCode2.Text + Day2 + "*.**o";
            }
            else if (radio_nav.Checked)
            {
                Instruction2 = "/C teqc " + MO2 + " " + MN2 + " " + AnType2 + " " + AnNum2 + " " + AnH2 + " " + Op2 + " " + Ag2 + " +nav + -tbin 1d " + "Ok\\" + tbCode2.Text + " " + tbCode2.Text + Day2 + "*.**n";
            }

            //====================================================================================================================
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            string MyPath = tbSource2.Text + "\\";
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
        }//private async Task Concatenation(int i, string station)


        //========================================================================================================================//
        //========================================================================================================================//
        //                                                Compare Headers                                                         //
        //========================================================================================================================//
        //========================================================================================================================//
        // Choisir dossier :
        //===================
        private void btnSource3_Click_1(object sender, EventArgs e)
        {
            LoadNewFile3();
        }
        public string userSelectedFilePath3
        {
            get
            {
                return tbSource3.Text;
            }
            set
            {
                tbSource3.Text = value;
            }
        }
        private void LoadNewFile3()
        {
            FolderBrowserDialog fbd3 = new FolderBrowserDialog();

            fbd3.SelectedPath = @"D:\";  // Initial directory

            System.Windows.Forms.DialogResult dr3 = fbd3.ShowDialog();
            if (dr3 == DialogResult.OK)
            {
                userSelectedFilePath3 = fbd3.SelectedPath;
            }
        }
        //========================================================================================================================//
        // Comparaison :
        //=============
        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            int From3; int From3bis;
            int To3; int To3bis;

            if (tbSource3.Text == "")
            {
                MessageBox.Show("Remplir source des données");
            }
            else if (tbMO3.Text == "")
            {
                MessageBox.Show("Remplir Marker name");
            }
            else if (tbMO3.Text.Length != 4)
            {
                MessageBox.Show("Le Marker name doit comporter 4 caractères");
            }
            else if (tbMN3.Text == "")
            {
                MessageBox.Show("Remplir Marker number");
            }
            else if (tbMN3.Text.Length != 4)
            {
                MessageBox.Show("Le Marker name doit comporter 4 caractères");
            }
            else if (tbRn3.Text=="")
            {
                MessageBox.Show("remplir numéro de série du récepteur");
            }
            else if (cbAnType3.Text == "")
            {
                MessageBox.Show("Remplir type d'antenne");
            }
            else if (tbAnNum3.Text == "")
            {
                MessageBox.Show("Remplir numéro d'antenne");
            }
            else if (tbAnH3.Text == "")
            {
                MessageBox.Show("Remplir hauteur d'antenne");
            }
            else if (!Directory.Exists(userSelectedFilePath3))
            {
                MessageBox.Show("Répertoire inexistant");
            }
            //====================================================================================================================
            // Convertir dates du format string au format int :
            //=================================================
            else if (int.TryParse(tbFrom3.Text, out From3bis) == false)
            {
                tbFrom3.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (From3bis > 366)
            {
                tbFrom3.Text = "";
                MessageBox.Show("Maximum 366");
            }

            else if (int.TryParse(tbTo3.Text, out To3bis) == false)
            {
                tbTo3.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (To3bis > 366 | To3bis < From3bis)
            {
                tbTo3.Text = "";
                MessageBox.Show(From3bis + " < To < 367");
            }
            //====================================================================================================================
            
            else
            {
                From3 = Convert.ToInt32(tbFrom3.Text);
                To3 = Convert.ToInt32(tbTo3.Text);

                dataGridView.Rows.Clear();
                progress3.Maximum = To3 - From3 + 1;
                //MessageBox.Show("max : " + progress3.Maximum);
                progress3.Value = 0;
                btnCheck.Enabled = false;

                for (int i = From3; i <= To3; i++)
                {
                    //====================================================================================================================
                    // Conversion de la date GPS sur 3 digits :
                    //=========================================
                    string Day3;// = "001";
                    if (i < 10)
                    {
                        Day3 = "00" + i;
                    }
                    else if (i < 100)
                    {
                        Day3 = "0" + i;
                    }
                    else
                    {
                        Day3 = Convert.ToString(i);
                    }

                    string station3 = tbMO3.Text + Day3 + "0.**o";
                    tbStatus3.Text = station3;
                    progress3.Value++;
                    //MessageBox.Show("val progressbar : " + progress3.Value);
                    

                    string line;
                    string extension = "";
                    var MO3 = "MARKER NAME"; string Mo3 = "";
                    var MN3 = "MARKER NUMBER"; string Mn3 = "";
                    var RN3 = "REC # / TYPE / VERS"; string Rn3 = "";
                    var AT_AN3 = "ANT # / TYPE"; string At3 = ""; string An3 = "";
                    var AH3 = "ANTENNA: DELTA H/E/N"; string Ah3 = "";
                    var Logg = "INTERVAL"; string logg = "";
                    string[] Ligne = new string[7];

                    //=====================================================================
                    //=====================================================================
                    DirectoryInfo root = new DirectoryInfo(userSelectedFilePath3);
                    FileInfo[] listfiles = root.GetFiles(tbMO3.Text + Day3 + "0.**o");

                    if (listfiles.Length > 0)
                    {
                        //MessageBox.Show("listfiles.Length > 0");
                        //File exists
                        foreach (FileInfo file3 in listfiles)
                        {
                            string ex = Path.GetExtension(Convert.ToString(file3));
                            //MessageBox.Show(ex);
                            //=====================================================================
                            try
                            {
                                if (File.Exists(userSelectedFilePath3 + "\\" + tbMO3.Text + Day3 + "0" + ex))
                                {
                                    extension = Path.GetExtension(station3);
                                    System.IO.StreamReader file = new System.IO.StreamReader(userSelectedFilePath3 + "\\" + tbMO3.Text + Day3 + "0" + ex);

                                    while ((line = file.ReadLine()) != null)
                                    {
                                        if (line.Contains(RN3))
                                        {
                                            Rn3 = Convert.ToString(line.Remove(6, line.Length - 6));
                                            Ligne[0] = Rn3;
                                        }

                                        else if (line.Contains(MO3))
                                        {
                                            Mo3 = Convert.ToString(line.Remove(4, line.Length - 4));
                                            Ligne[1] = Mo3;
                                        }

                                        else if (line.Contains(MN3))
                                        {
                                            Mn3 = Convert.ToString(line.Remove(4, line.Length - 4));
                                            Ligne[2] = Mn3;
                                        }

                                        else if (line.Contains(AT_AN3))
                                        {
                                            An3 = Convert.ToString(line.Remove(8, line.Length - 8));// MessageBox.Show("An = " + An3);
                                            At3 = Convert.ToString(line.Remove(0, 20)); //MessageBox.Show("At = |" + At3 + "|");
                                            At3 = At3.Remove(20, At3.Length - 20); //MessageBox.Show("At = |" + At3 + "|");
                                            Ligne[3] = At3;
                                            Ligne[4] = An3;
                                           
                                        }

                                        else if (line.Contains(AH3))
                                        {
                                            Ah3 = Convert.ToString(line.Remove(0, 8)); //MessageBox.Show("Ah = |" + Ah3 + "|");
                                            Ah3 = Ah3.Remove(6, Ah3.Length - 6); //MessageBox.Show("Ah = |" + Ah3 + "|");
                                            Ligne[5] = Ah3;
                                        }

                                        else if (line.Contains(Logg))
                                        {
                                            logg = Convert.ToString(line.Remove(0, 4));
                                            logg = logg.Remove(2, logg.Length - 2);
                                            Ligne[6] = logg;
                                        }


                                    }
                                    string[] row1 = new string[] { Day3, Ligne[0], Ligne[1], Ligne[2], Ligne[3], Ligne[4], Ligne[5], Ligne[6] };
                                    string[] row2 = new string[] { Day3, tbRn3.Text, tbMO3.Text, tbMN3.Text, cbAnType3.Text, tbAnNum3.Text, tbAnH3.Text, cbRate3.Text };
                                    if (!row1.SequenceEqual(row2))
                                    {
                                        dataGridView.Rows.Add(row1);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Aucun fichier lu " + userSelectedFilePath3 + "\\" + station3 + extension);
                                }
                                //this.progress3.Value = i;
                            }
                            catch { }
                        }//foreach (FileInfo file3 in listfiles)
                    }//if (listfiles.Length > 0)
                    else
                    {
                        //MessageBox.Show("listfiles.Length <= 0");
                    }
                } //for (int i = 1; i <= 366; i++)
                MessageBox.Show("Done !");
                btnCheck.Enabled = true;
            }
        } //private void btnCheck_Click_1(object sender, EventArgs e)

        //=====================================================================================================================
        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
        }

        //private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //MessageBox.Show(userSelectedFilePath3 + "\\" + tbMO3.Text + dataGridView.SelectedCells[1] + "0");
        //    //Process.Start(userSelectedFilePath3 + "Ok\\" + tbMO3.Text + dataGridView.Rows[0] + "0");
        //    Process.Start(userSelectedFilePath3+"\\ABKD0010.15o");
        //}

        //====================================================================================================================//
        //====================================================================================================================//
        //                                                       DECIMATE                                                     //
        //====================================================================================================================//
        //====================================================================================================================//
        //==================
        //      OUVRIR
        //=================
        private void btnSource4_Click(object sender, EventArgs e)
        {
            LoadNewFile4();
        }
        public string userSelectedFilePath4
        {
            get
            {
                return tbSource4.Text;
            }
            set
            {
                tbSource4.Text = value;
            }
        }
        private void LoadNewFile4()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.SelectedPath = @"D:\";  // Initial directory

            //fbd.ShowDialog();
            System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath4 = fbd.SelectedPath;
            }
        }
        //====================================================================================================================
        // Cliquer sur bouton "Decimate" :
        //===============================
        private void btnDecimate_Click(object sender, EventArgs e)
        {
            int From4; int From4bis;
            int To4; int To4bis;

            if (tbSource4.Text == "")
            {
                MessageBox.Show("Remplir source des données");
            }
            else if (tbCode4.Text == "")
            {
                MessageBox.Show("Remplir code de la station");
            }
            else if (tbCode4.Text.Length != 4)
            {
                MessageBox.Show("Le code doit comporter 4 caractères");
            }
            else if (tbFrom4.Text == "")
            {
                MessageBox.Show("Remplir intervalle des jours");
            }
            //====================================================================================================================
            // Convertir dates du format string au format int :
            //=================================================
            else if (int.TryParse(tbFrom4.Text, out From4bis) == false)
            {
                tbFrom4.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (From4bis > 366)
            {
                tbFrom4.Text = "";
                MessageBox.Show("Maximum 366");
            }

            else if (int.TryParse(tbTo4.Text, out To4bis) == false)
            {
                tbTo4.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (To4bis > 366 | To4bis < From4bis)
            {
                tbTo4.Text = "";
                MessageBox.Show(From4bis + "<To<367");
            }
            //====================================================================================================================
            else
            {
                From4 = From4bis;
                To4 = To4bis;
                progress4.Maximum = To4 - From4 + 1;

                CalculateAsync4();
            }
        }
        //====================================================================================================================
        public async void CalculateAsync4()
        {
            int From4 = Convert.ToInt32(tbFrom4.Text);
            int To4 = Convert.ToInt32(tbTo4.Text);

            progress4.Maximum = To4 - From4 + 1;
            progress4.Value = 0;
            string station4 = tbCode4.Text; ;
            btnDecimate.Enabled = false;

            for (int i = From4; i <= To4; i++)
            {
                await Decimate(i, station4);

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
                progress4.Value++;
            }

            MessageBox.Show("Done !");
            btnDecimate.Enabled = true;

            //====================================================================================================================
            // Suppression du sous-dossier "Ok" s'il est vide :
            //================================================
            if (Directory.EnumerateFiles(userSelectedFilePath4 + "\\Ok_" + cbOutputRate4.Text).Count() == 0)
            {
                MessageBox.Show("Ok_" + cbOutputRate4.Text + " vide");
                Directory.Delete(userSelectedFilePath4 + "\\Ok_" + cbOutputRate4.Text);
            }
            //====================================================================================================================
            if (File.Exists(userSelectedFilePath4 + "\\teqc.exe"))
            {
                try
                {
                    File.Delete(userSelectedFilePath4 + "\\teqc.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //===============================================================================================================
        private async Task Decimate(int i, string station4)
        {
            string Code4 = tbCode4.Text;
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
            //====================================================================================================================
            // Créer sous-dossier "Ok" :
            //=========================
            if (!Directory.Exists(userSelectedFilePath4 + "\\Ok_" + cbOutputRate4.Text))
            {
                System.IO.Directory.CreateDirectory(userSelectedFilePath4 + "\\Ok_" + cbOutputRate4.Text);
            }
            //====================================================================================================================
            // Copier TEQC sur répertoire des données :
            //========================================
            if (!File.Exists(userSelectedFilePath4 + "\\teqc.exe"))
            {
                byte[] exeBytes = Rinex_Tools_7.Properties.Resources.teqc;
                string exeToRun = userSelectedFilePath4 + "\\teqc.exe";//@"C:\TEST\MyTestExe.exe";

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
            DirectoryInfo root = new DirectoryInfo(userSelectedFilePath4);
            FileInfo[] listfiles4 = root.GetFiles(tbCode4.Text + Day4 + "0.**o");
            foreach (FileInfo file4 in listfiles4)
            {
                string ex = Path.GetExtension(Convert.ToString(file4));
                //MessageBox.Show("extension = " + ex);
                string Instruction4 = "/C teqc -O.dec " + cbOutputRate4.Text + " " + Code4 + Day4 + "0" + ex + " > Ok_" + cbOutputRate4.Text + "\\" + Code4 + Day4 + "0" + ex;
                tbstatus4.Text = "       teqc -O.dec " + cbOutputRate4.Text + " " + station4 + Day4 + "0" + ex + " > Ok\\" + station4 + Day4 + "0" + ex;
                //MessageBox.Show(Instruction4);
                //====================================================================================================================
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                string MyPath = tbSource4.Text + "\\";
                p.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(MyPath);
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = Instruction4;
                await Task.Run
                    (() =>
                    {
                        p.Start();
                    });
            }
        }

        private void tbOp2_TextChanged(object sender, EventArgs e)
        {

        }
        //====================================================================================================================


        //====================================================================================================================//
        //====================================================================================================================//
        //                                               SORT DATA                                                            //
        //====================================================================================================================
        //====================================================================================================================
        // ouvrir :
        //========
        private void btn_Source5_Click(object sender, EventArgs e)
        {
            LoadNewFile5();
        }
        public string userSelectedFilePath5
        {
            get
            {
                return tbSource5.Text;
            }
            set
            {
                tbSource5.Text = value;
            }
        }
        private void LoadNewFile5()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.SelectedPath = @"D:\";  // Initial directory

            //fbd.ShowDialog();
            System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath5 = fbd.SelectedPath;
            }
        }
        //====================================================================================================================
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            progress5.Value = 0;
            int From5; int From5bis;
            int To5; int To5bis;

            if (tbSource5.Text == "")
            {
                MessageBox.Show("entrer répertoire des données");
            }
            else if (tbCode5.Text == "")
            {
                MessageBox.Show("entrer code de la station");
            }
            else if (tbFrom5.Text == "")
            {
                MessageBox.Show("entrer");
            }

            else if (tbCode5.Text.Length != 4)
            {
                MessageBox.Show("Le code doit comporter 4 caractères");
            }
            else if (tbFrom5.Text == "")
            {
                MessageBox.Show("Remplir intervalle des jours");
            }
            //====================================================================================================================
            // Convertir dates du format string au format int :
            //=================================================
            else if (int.TryParse(tbFrom5.Text, out From5bis) == false)
            {
                tbFrom1.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (From5bis > 366)
            {
                tbFrom1.Text = "";
                MessageBox.Show("Maximum 366");
            }

            else if (int.TryParse(tbTo5.Text, out To5bis) == false)
            {
                tbTo5.Text = "";
                MessageBox.Show("Entrer une valeur numérique");
            }

            else if (To5bis > 366 | To5bis < From5bis)
            {
                tbTo5.Text = "";
                MessageBox.Show(From5bis + "<To<367");
            }
            //====================================================================================================================
            else
            {
                From5 = From5bis;
                To5 = To5bis;
                progress5.Maximum = To5 - From5 + 1;

                CalculateAsync5();
            }
        }
        //====================================================================================================================
        public async void CalculateAsync5()
        {
            for (int i = Convert.ToInt32(tbFrom5.Text); i <= Convert.ToInt32(tbTo5.Text); i++)
            {
                progress5.Value++;
                await Sorting(i);
            }
            btn_Sort.Enabled = true;
            btn_Source5.Enabled = true;
            MessageBox.Show("Done !");
        }//public async void CalculateAsync()
        //====================================================================================================================
        private async Task Sorting(int i)
        {
            string Day5;
            string Path = tbSource5.Text;
            string MyFile_mxx = tbCode5.Text + "001a.m00";
            string extension_i = ".i00";
            string extension_m = ".m00";
            string sourceDir = tbSource5.Text; ;
            //===============================
            // écrire date gps sur 3 digits :
            //===============================
            if (i.ToString().Length == 1)
            {
                Day5 = "00" + i.ToString();
            }
            else if (i.ToString().Length == 2)
            {
                Day5 = "0" + i.ToString();
            }
            else
            {
                Day5 = i.ToString();
            }
            //=============
            // de 00 à 59 :
            //=============
            for (char Alpha = 'a'; Alpha <= 'x'; Alpha++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if (j.ToString().Length == 1)
                    {
                        extension_m = ".m0" + Convert.ToString(j);
                        extension_i = ".i0" + Convert.ToString(j);
                    }
                    else if (j.ToString().Length == 2)
                    {
                        extension_m = ".m" + Convert.ToString(j);
                        extension_i = ".i" + Convert.ToString(j);
                    }
                    //===============================================================================================================
                    string MyFile_i00 = tbCode5.Text + Day5 + Alpha + extension_i;
                    string MyFile_m00 = tbCode5.Text + Day5 + Alpha + extension_m;

                    string sourceFile_i00 = System.IO.Path.Combine(sourceDir, MyFile_i00);
                    string sourceFile_m00 = System.IO.Path.Combine(sourceDir, MyFile_m00);

                    string DestinationDir = System.IO.Path.Combine(sourceDir, Day5);

                    string DestinationFile_i00 = System.IO.Path.Combine(sourceDir, Day5, MyFile_i00);
                    string DestinationFile_m00 = System.IO.Path.Combine(sourceDir, Day5, MyFile_m00);

                    tbStatus5.Text = "     " + MyFile_m00;

                    if (!System.IO.Directory.Exists(DestinationDir))
                    {
                        System.IO.Directory.CreateDirectory(DestinationDir);
                    }
                    //===============================================================================================================
                    await Task.Run
                    (() =>
                    {
                        try
                        {
                            System.IO.File.Copy(sourceFile_m00, DestinationFile_m00, true);
                            System.IO.File.Copy(sourceFile_i00, DestinationFile_i00, true);
                        }
                        catch
                        {
                        }
                    });


                }
            }
            if (System.IO.Directory.GetFiles(tbSource5.Text + "\\" + Day5).Length == 0 && System.IO.Directory.GetDirectories(tbSource5.Text + "\\" + Day5).Length == 0)
            {
                System.IO.Directory.Delete(tbSource5.Text + "\\" + Day5);
            }
        }

       



        //====================================================================================================================
    }//public partial class Form1 : Form
} // namespace Rinex_Tools_5
