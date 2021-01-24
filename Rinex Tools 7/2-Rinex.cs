using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Rinex_Tools_6
{
    public partial class Rinex : Form
    {
        public Rinex()
        {
            InitializeComponent();
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // Ouvrir :
        //========
        private void btnSource_Click_1(object sender, EventArgs e)
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
            System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = fbd.SelectedPath;
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // On Rinex button Click :
        //========================
        private void btnRinex_Click(object sender, EventArgs e)
        {
            //int From1; int From1bis;
            //int To1; int To1bis;

            if (tbSource1.Text == "")
            {
                toolTip.Show("Data directory", tbSource1, 10, 10, 2000);
                //MessageBox.Show("Remplir source des données");
            }
            else if (tbCode.Text == "")
            {
                toolTip.Show("Station code", tbCode, 10, 10, 2000);
                //MessageBox.Show("Remplir code de la station");
            }
            else if (tbCode.Text.Length != 4)
            {
                toolTip.Show("4 characters for code station", tbCode, 10, 10, 2000);
                //MessageBox.Show("Le code doit comporter 4 caractères");
            }

            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            // Convertir dates du format string au format int :
            //=================================================
            else if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                toolTip.Show("respect chronological order", dateTimePicker2, 10, 10, 2000);
                //MessageBox.Show("Respecter ordre chronologique SVP !");
            }

            else
            {
                int From = dateTimePicker1.Value.DayOfYear;
                int To = dateTimePicker2.Value.DayOfYear;
                progress.Maximum = dateTimePicker2.Value.Year - dateTimePicker1.Value.Year + 1;

                CalculateAsync();
            }
        }

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public async void CalculateAsync()
        {
            int From1 = dateTimePicker1.Value.DayOfYear;
            int To1 = dateTimePicker2.Value.DayOfYear;

            progress.Maximum = dateTimePicker2.Value.Year - dateTimePicker1.Value.Year + 1;
            //MessageBox.Show(progress.Maximum.ToString());
            progress.Value = 0;
            string station = tbCode.Text; ;
            btnRinex.Enabled = false;

            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            for (DateTime i = dateTimePicker1.Value.Date; i <= dateTimePicker2.Value.Date; i = i.AddDays(1))
            {
                await Rinexage(i, station);

                //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                // Conversion de la date GPS sur 3 digits :
                //=========================================
                string Day;
                if (i.DayOfYear < 10)
                {
                    Day = "00" + i.DayOfYear;
                }
                else if (i.DayOfYear < 100)
                {
                    Day = "0" + i.DayOfYear;
                }
                else
                {
                    Day = Convert.ToString(i.DayOfYear);
                }

                tbstatus.Text = "      teqc " + station + Day + "a.m** / " + i.Year;

                progress.Value = progress.Maximum - (dateTimePicker2.Value.Year - i.Year);
            }
            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            // Suppression de TEQC et dossiers Rinexed :
            //-----------------------------------------
            tbstatus.Text = "Supression des dossier supplémentaires ... ";
            Thread.Sleep(3000);
            for (DateTime i = dateTimePicker1.Value.Date; i <= dateTimePicker2.Value.Date; i = i.AddDays(1))
            {
                if (checkAddPath.Checked == true)
                {
                    //suppression de "...\Rinexed\" :
                    //--------------------------
                    if (Directory.Exists(userSelectedFilePath + @"\\" + i.Year + "\\" + tbCode.Text + "\\Rinexed"))
                    {
                        if (Directory.EnumerateFiles(userSelectedFilePath + "\\" + i.Year + "\\" + tbCode.Text + "\\Rinexed").Count() == 0)
                        {
                            Directory.Delete(userSelectedFilePath + "\\" + i.Year + "\\" + tbCode.Text + "\\Rinexed");
                        }
                    }
                    // Suppression de TEQC :
                    //---------------------
                    if (File.Exists(userSelectedFilePath + "\\" + i.Year.ToString() + "\\" + tbCode.Text + "\\teqc.exe"))
                    {
                        try
                        {
                            File.Delete(userSelectedFilePath + "\\" + i.Year.ToString() + "\\" + tbCode.Text + "\\teqc.exe");
                        }
                        catch { }
                    }
                }
                else
                {
                    //suppression de "...\Rinexed\" :
                    //--------------------------
                    if (Directory.Exists(userSelectedFilePath + "\\Rinexed"))
                    {
                        if (Directory.EnumerateFiles(userSelectedFilePath + "\\Rinexed").Count() == 0)
                        {
                            Directory.Delete(userSelectedFilePath + "\\Rinexed");
                        }
                    }
                    // Suppression de TEQC :
                    //---------------------
                    if (File.Exists(userSelectedFilePath + "\\teqc.exe"))
                    {
                        try
                        {
                            File.Delete(userSelectedFilePath + "\\teqc.exe");
                        }
                        catch { }
                    }
                }
            }

            tbstatus.Text = null;
            MessageBox.Show("Done !");
            btnRinex.Enabled = true;


        }//public async void CalculateAsync()

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        private async Task Rinexage(DateTime i, string station)
        {
            string Code = tbCode.Text;
            string MO = "-O.mo " + tbCode.Text;
            string OutputCode = Code;
            string MN;
            string Op;
            string Ag;
            string AnType;
            string AnNum;
            string AnH;
            string SignalOrder;
            //=========================
            if (tbMO.Text != "")
            {
                MO = "-O.mo " + tbMO.Text;
                OutputCode = tbMO.Text;
            }
            else
            {
                MO = "-O.mo " + tbCode.Text;
                OutputCode = tbCode.Text;
            }
            //=========================
            if (tbMN.Text != "")
            { MN = "-O.mn " + tbMN.Text; }
            else
            { MN = null; }
            //=========================
            if (tbOp.Text != "")
            { Op = "-O.o " + tbOp.Text + " "; }
            else { Op = null; }
            //=========================
            if (tbAg.Text != "")
            { Ag = "-O.ag " + tbAg.Text; }
            else { Ag = "-O.ag C.R.A.A.G."; }
            //=========================
            if (cbAnType.Text != "")
            { AnType = "-O.at " + cbAnType.Text; }
            else { AnType = null; }
            //=========================
            if (tbAnNum.Text != "")
            { AnNum = "-O.an " + tbAnNum.Text; }
            else { AnNum = null; }
            //=========================
            if (tbAnH.Text != "")
            { AnH = "-O.pe " + tbAnH.Text + " 0.0000 0.0000"; }
            else { AnH = null; }
            //=========================
            if (cbSignals.Text == "L1L2C1P2 (TEQC)")
            { SignalOrder = "L1L2C1P2"; }
            else { SignalOrder = "C1L1P2L2"; }

            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            // Conversion de la date GPS sur 3 digits :
            //=========================================
            string Day;
            if (i.DayOfYear < 10)
            {
                Day = "00" + i.DayOfYear;
            }
            else if (i.DayOfYear < 100)
            {
                Day = "0" + i.DayOfYear;
            }
            else
            {
                Day = Convert.ToString(i.DayOfYear);
            }
            //MessageBox.Show(Day);

            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            string Instruction = "/C teqc -O.r RinexTools-CRAAG " + MO + " " + MN + " " + AnType + " " + AnNum + " " + AnH + " " + Op + " " + Ag;

            if (!checkGlonass.Checked)
            {
                Instruction = Instruction + " -R -O.s G";
                //MessageBox.Show(Instruction);
            }

            if (!checkSN.Checked)
            {
                Instruction = Instruction + " -O.obs " + SignalOrder;
                //MessageBox.Show(Instruction);
            }
            else
            {
                Instruction = Instruction + " -O.obs " + SignalOrder + "S1S2";
                //MessageBox.Show(Instruction);
            }

            if (checkNav.Checked)
            {
                Instruction = Instruction + " +obs + +nav +,+ -tbin 1d Rinexed\\" + OutputCode + " " + Code + Day + "*.m**";
                //MessageBox.Show(Instruction);
            }
            else
            {
                Instruction = Instruction + " +obs + -tbin 1d Rinexed\\" + OutputCode + " " + Code + Day + "*.m**";
                //MessageBox.Show(Instruction);
            }

            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            // Créer sous-dossier "Rinexed" :
            //--------------------------
            if (checkAddPath.Checked == true)
            {
                if (!Directory.Exists(userSelectedFilePath + "\\" + i.Year + "\\" + tbCode.Text + "\\Rinexed"))
                {
                    System.IO.Directory.CreateDirectory(userSelectedFilePath + "\\" + i.Year + "\\" + tbCode.Text + "\\Rinexed");
                }
            }
            else
            {
                if (!Directory.Exists(userSelectedFilePath + "\\Rinexed"))
                {
                    System.IO.Directory.CreateDirectory(userSelectedFilePath + "\\Rinexed");
                }
            }
            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            // Copier TEQC sur répertoire des données :
            //-----------------------------------------
            if (checkAddPath.Checked == true)
            {
                if (Directory.Exists(userSelectedFilePath + "\\" + i.Year + "\\" + tbCode.Text))
                {
                    if (!File.Exists(userSelectedFilePath + "\\" + i.Year + "\\" + tbCode.Text + "\\teqc.exe"))
                    {
                        byte[] exeBytes = Rinex_Tools_7.Properties.Resources.teqc;
                        string exeToRun = userSelectedFilePath + "\\" + i.Year + "\\" + tbCode.Text + "\\teqc.exe";

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
            else
            {
                if (Directory.Exists(userSelectedFilePath))
                {
                    if (!File.Exists(userSelectedFilePath + "\\teqc.exe"))
                    {
                        byte[] exeBytes = Rinex_Tools_7.Properties.Resources.teqc;
                        string exeToRun = userSelectedFilePath + "\\teqc.exe";

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
            // Execution :
            //-----------
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            string MyPath;
            if (checkAddPath.Checked == true)
            {
                MyPath = userSelectedFilePath + "\\" + i.Year.ToString() + "\\" + tbCode.Text + "\\";
            }
            else
            {
                MyPath = userSelectedFilePath + "\\";
            }
            //MessageBox.Show(MyPath);
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



        //====================================================================================================================
        // Affichage des dates GPS :
        //==========================
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tbFrom.Text = dateTimePicker1.Value.DayOfYear.ToString();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            tbTo.Text = dateTimePicker2.Value.DayOfYear.ToString();
        }

        private void tbFrom_TextChanged(object sender, EventArgs e)
        {
            if (tbFrom.Text != "")
            {
                int a = Convert.ToInt32(tbFrom.Text);
                DateTime theDate1 = new DateTime(dateTimePicker1.Value.Year, 1, 1).AddDays(a - 1);
                dateTimePicker1.Value = theDate1;
            }
        }

        private void tbTo_TextChanged_1(object sender, EventArgs e)
        {
            if (tbTo.Text != "")
            {
                int b = Convert.ToInt32(tbTo.Text);
                DateTime theDate2 = new DateTime(dateTimePicker2.Value.Year, 1, 1).AddDays(b - 1);
                dateTimePicker2.Value = theDate2;
            }
        }
        //====================================================================================================================
        // Tips :
        //-------
        private void tbSource1_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Data directory", tbSource1, 0, -20, 3000);
        }

        private void btnRinex_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Start", btnRinex, 0, -20, 3000);
        }

        private void checkSN_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Include S1 and S2 signals", checkSN, 0, -20, 3000);
        }

        private void dateTimePicker1_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("From", dateTimePicker1, 0, -20, 3000);
        }

        private void dateTimePicker2_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("To", dateTimePicker2, 0, -20, 3000);
        }

        private void btnSource_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Open directory", btnSource, 0, -20, 3000);
        }

        private void checkNav_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Generate navigation files (.Nav)", checkNav, 0, -20, 3000);
        }

        private void checkGlonass_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Include Glonass ???", checkGlonass, 0, -20, 3000);
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            tbMN.Text = tbCode.Text;
            tbMO.Text = tbCode.Text;
        }

        private void checkAddPath_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

