using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rinex_Tools_6
{
    public partial class SortData : Form
    {
        public SortData()
        {
            InitializeComponent();
        }

        //====================================================================================================================
        // ouvrir :
        //========
        private void btn_Source_Click(object sender, EventArgs e)
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
        //====================================================================================================================
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            progress.Value = 0;
            int From; int Frombis;
            int To; int Tobis;

            if (tbSource.Text == "")
            {
                MessageBox.Show("entrer répertoire des données");
            }
            else if (tbCode.Text == "")
            {
                MessageBox.Show("entrer code de la station");
            }
            else if (tbFrom.Text == "")
            {
                MessageBox.Show("entrer");
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
                progress.Maximum = To - From+ 1;

                CalculateAsync();
            }
        }
        //====================================================================================================================
        public async void CalculateAsync()
        {
            for (int i = Convert.ToInt32(tbFrom.Text); i <= Convert.ToInt32(tbTo.Text); i++)
            {
                progress.Value++;
                await Sorting(i);
            }
            btn_Sort.Enabled = true;
            btn_Source.Enabled = true;
            MessageBox.Show("Done !");
        }//public async void CalculateAsync()
        //====================================================================================================================
        private async Task Sorting(int i)
        {
            string Day5;
            string Path = tbSource.Text;
            string MyFile_mxx = tbCode.Text + "001a.m00";
            string extension_i = ".i00";
            string extension_m = ".m00";
            string sourceDir = tbSource.Text; ;
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
                    string MyFile_i00 = tbCode.Text + Day5 + Alpha + extension_i;
                    string MyFile_m00 = tbCode.Text + Day5 + Alpha + extension_m;

                    string sourceFile_i00 = System.IO.Path.Combine(sourceDir, MyFile_i00);
                    string sourceFile_m00 = System.IO.Path.Combine(sourceDir, MyFile_m00);

                    string DestinationDir = System.IO.Path.Combine(sourceDir, Day5);

                    string DestinationFile_i00 = System.IO.Path.Combine(sourceDir, Day5, MyFile_i00);
                    string DestinationFile_m00 = System.IO.Path.Combine(sourceDir, Day5, MyFile_m00);

                    tbStatus.Text = "     " + MyFile_m00;

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
            if (System.IO.Directory.GetFiles(tbSource.Text + "\\" + Day5).Length == 0 && System.IO.Directory.GetDirectories(tbSource.Text + "\\" + Day5).Length == 0)
            {
                System.IO.Directory.Delete(tbSource.Text + "\\" + Day5);
            }
        }
    }
}

