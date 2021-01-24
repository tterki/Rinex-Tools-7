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

namespace Rinex_Tools_6
{
    public partial class Compare : Form
    {
        public Compare()
        {
            InitializeComponent();
        }

        //========================================================================================================================//
        // Choisir dossier :
        //==================
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

            System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = fbd.SelectedPath;
            }
        }
        //========================================================================================================================//
        // Comparaison :
        //==============
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int From; int Frombis;
            int To; int Tobis;

            if (tbSource.Text == "")
            {
                MessageBox.Show("Remplir source des données");
            }
            else if (tbMO.Text == "")
            {
                MessageBox.Show("Remplir Marker name");
            }
            else if (tbMO.Text.Length != 4)
            {
                MessageBox.Show("Le Marker name doit comporter 4 caractères");
            }
            else if (tbMN.Text == "")
            {
                MessageBox.Show("Remplir Marker number");
            }
            else if (tbMN.Text.Length != 4)
            {
                MessageBox.Show("Le Marker name doit comporter 4 caractères");
            }
            else if (tbRn3.Text == "")
            {
                MessageBox.Show("remplir numéro de série du récepteur");
            }
            else if (cbAnType.Text == "")
            {
                MessageBox.Show("Remplir type d'antenne");
            }
            else if (tbAnNum.Text == "")
            {
                MessageBox.Show("Remplir numéro d'antenne");
            }
            else if (tbAnH.Text == "")
            {
                MessageBox.Show("Remplir hauteur d'antenne");
            }
            else if (!Directory.Exists(userSelectedFilePath))
            {
                MessageBox.Show("Répertoire inexistant");
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
                MessageBox.Show(Frombis + " < To < 367");
            }
            //====================================================================================================================
            else
            {
                From = Convert.ToInt32(tbFrom.Text);
                To = Convert.ToInt32(tbTo.Text);

                dataGridView.Rows.Clear();
                progress.Maximum = To - From + 1;
                //MessageBox.Show("max : " + progress3.Maximum);
                progress.Value = 0;
                btnCheck.Enabled = false;

                for (int i = From; i <= To; i++)
                {//====================================================================================================================
                    // Conversion de la date GPS sur 3 digits :
                    //=========================================
                    string Day;// = "001";
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

                    string station3 = tbMO.Text + Day + "0.**o";
                    tbStatus.Text = station3;
                    progress.Value++;
                    string line;
                    string extension = "";
                    var MO = "MARKER NAME"; string Mo = "";
                    var MN = "MARKER NUMBER"; string Mn = "";
                    var RN = "REC # / TYPE / VERS"; string Rn = "";
                    var AT_AN = "ANT # / TYPE"; string At = ""; string An = "";
                    var AH = "ANTENNA: DELTA H/E/N"; string Ah = "";
                    var Logg = "INTERVAL"; string logg = "";
                    string[] Ligne = new string[7];
                    //=====================================================================
                    DirectoryInfo root = new DirectoryInfo(userSelectedFilePath);
                    FileInfo[] listfiles = root.GetFiles(tbMO.Text + Day + "0.**o");

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
                                if (File.Exists(userSelectedFilePath + "\\" + tbMO.Text + Day + "0" + ex))
                                {
                                    extension = Path.GetExtension(station3);
                                    System.IO.StreamReader file = new System.IO.StreamReader(userSelectedFilePath + "\\" + tbMO.Text + Day + "0" + ex);

                                    while ((line = file.ReadLine()) != null)
                                    {
                                        if (line.Contains(RN))
                                        {
                                            Rn = Convert.ToString(line.Remove(6, line.Length - 6));
                                            Ligne[0] = Rn;
                                        }

                                        else if (line.Contains(MO))
                                        {
                                            Mo = Convert.ToString(line.Remove(4, line.Length - 4));
                                            Ligne[1] = Mo;
                                        }

                                        else if (line.Contains(MN))
                                        {
                                            Mn = Convert.ToString(line.Remove(4, line.Length - 4));
                                            Ligne[2] = Mn;
                                        }

                                        else if (line.Contains(AT_AN))
                                        {
                                            An = Convert.ToString(line.Remove(8, line.Length - 8));// MessageBox.Show("An = " + An3);
                                            At = Convert.ToString(line.Remove(0, 20)); //MessageBox.Show("At = |" + At3 + "|");
                                            At = At.Remove(20, At.Length - 20); //MessageBox.Show("At = |" + At3 + "|");
                                            Ligne[3] = At;
                                            Ligne[4] = An;

                                        }

                                        else if (line.Contains(AH))
                                        {
                                            Ah = Convert.ToString(line.Remove(0, 8)); //MessageBox.Show("Ah = |" + Ah3 + "|");
                                            Ah = Ah.Remove(6, Ah.Length - 6); //MessageBox.Show("Ah = |" + Ah3 + "|");
                                            Ligne[5] = Ah;
                                        }

                                        else if (line.Contains(Logg))
                                        {
                                            logg = Convert.ToString(line.Remove(0, 4));
                                            logg = logg.Remove(2, logg.Length - 2);
                                            Ligne[6] = logg;
                                        }
                                    }

                                    string AntNum = tbAnNum.Text;
                                    if (AntNum.Length < 8)
                                    {
                                        for (int a = AntNum.Length; a < 8; a++)
                                        {
                                            //MessageBox.Show(AntNum.Length.ToString());
                                            AntNum = AntNum + " ";
                                            //MessageBox.Show(AntNum);
                                        }
                                    }

                                    string[] row1 = new string[] { Day, Ligne[0], Ligne[1], Ligne[2], Ligne[3], Ligne[4], Ligne[5], Ligne[6] };
                                    string[] row2 = new string[] { Day, tbRn3.Text, tbMO.Text, tbMN.Text, cbAnType.Text, AntNum, tbAnH.Text, cbRate.Text };

                                    if (!row1.SequenceEqual(row2))
                                    {
                                        dataGridView.Rows.Add(row1);

                                        // cell in red color :
                                        //--------------------
                                        for (int c = 0; c < row1.Length; c++)
                                        {
                                            if (row1[c] != row2[c])
                                            {
                                                int cont = dataGridView.RowCount;
                                                dataGridView.Rows[cont - 1].Cells[c].Style.BackColor = Color.Red;
                                                dataGridView.Rows[cont - 1].Cells[c].Style.ForeColor = Color.White;
                                            }
                                        }

                                        //// cell in red color :
                                        ////===================
                                        //for (int c = 1; c < row1.Length; c++)
                                        //{
                                        //    if (row1[c] != row2[c])
                                        //    {
                                        //        int a = dataGridView.Row[e.RowIndex];
                                        //        //Cells[c].Style.ForeColor = Color.Red;
                                        //        //dataGridView.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
                                        //    }
                                        //}
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Aucun fichier lu " + userSelectedFilePath + "\\" + station3 + extension);
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
        }
        //§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
        // Clear datagridview :
        //---------------------
        private void btn_clear_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
        }

        //§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
        // Open file on mouse double click :
        //---------------------------------
        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string day = dataGridView.CurrentRow.Cells[0].Value.ToString();

            ProcessStartInfo psi = new ProcessStartInfo();
            string[] files = Directory.GetFiles(tbSource.Text, tbMO.Text + day + "0" + ".*");
            psi.FileName = files[0];
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
        //§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
        // Modify errors in files :
        //--------------------------------
        private void btnModify_Click(object sender, EventArgs e)
        {
            // Créer sous-dossier "Ok" :
            //-------------------------
            if (!Directory.Exists(userSelectedFilePath + "\\Modified"))
            {
                System.IO.Directory.CreateDirectory(userSelectedFilePath + "\\Modified");
            }

            // Copier TEQC sur répertoire des données :
            //-----------------------------------------
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

            // Rinexage :
            //-----------
            string Instruction;
            string AnType = '"' + cbAnType.Text + '"';
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                string day = dataGridView.Rows[i].Cells[0].Value.ToString();

                string searchPattern = tbMO.Text + day + "0.***";
                DirectoryInfo di = new DirectoryInfo(userSelectedFilePath);
                p.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(userSelectedFilePath + "\\");
                FileInfo[] files = di.GetFiles(searchPattern);
                //string fichier = files[0].ToString();
                string fileExtension = System.IO.Path.GetExtension(files[0].ToString());
                //MessageBox.Show(fileExtension);

                Instruction = "/C teqc -O.mo " + tbMO.Text + " -O.mn " + tbMN.Text + " -O.rn " + tbRn3.Text + " -O.at " + AnType + " -O.an " + tbAnNum.Text + " -O.pe " + tbAnH.Text + " 0.0000 0.0000 +obs + -tbin 1d Modified\\" + tbMO.Text + " " + tbMO.Text + day + "0" + fileExtension;

                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = Instruction;
                p.Start();
            }
            MessageBox.Show("Modifications done !");
        }
    }
}
