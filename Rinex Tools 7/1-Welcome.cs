using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rinex_Tools_7;

namespace Rinex_Tools_6
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_rinex_Click(object sender, EventArgs e)
        {
            Form newRinex = new Rinex();
            newRinex.Show();
        }

        private void btn_merge_Click(object sender, EventArgs e)
        {
            Form newMerge = new Merge();
            newMerge.Show();
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            Form newCompare = new Compare();
            newCompare.Show();
        }

        private void btn_decimate_Click(object sender, EventArgs e)
        {
            Form newDecimate = new Decimate();
            newDecimate.Show();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            Form newSort = new SortData();
            newSort.Show();
        }
        

        private void btn_Crinex_Click(object sender, EventArgs e)
        {
            Form newCrinex = new Crinex();
            newCrinex.Show();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            Form newAbout = new About();
            newAbout.Show();
        }

        private void btn_rinex_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Convertir les données\ndu format MDB en d'autres\nformats (Obs, Nav, ...)", btn_rinex, 80, -40, 5000);
            //toolTip.Show("Using TEQC software to convert\ndata from MDB format\nto Rinex format (Obs, Nav ...)", btn_rinex, 50, -50, 5000);
        }

        private void btn_merge_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Concaténer différents types\nde données (MDB, Obs and Nav)", btn_merge, 80, -10, 5000);
            //toolTip.Show("Merging different types\nof data (MDB, Obs and Nav)",btn_merge, 50, 0, 5000);
        }

        private void btn_decimate_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Modifier fréquence\nd'échantillonage (logging)\ndes fichiers d'observation", btn_decimate, 80, -40, 5000);
        }

        private void btn_compare_MouseHover_1(object sender, EventArgs e)
        {
            toolTip.Show("Chercher les erreurs dans\nles en-têtes des fichiers\nd'observation en présentant\nune en-tête modèle", btn_compare, 80, -40, 5000);
            //toolTip.Show("Seeking for errors in Rinex headers ...", btn_compare, 50, 0, 5000);
        }

        private void btn_sort_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Trier les fichiers MDB se trouvant\ndans un même répertoire dans des\nsous-répertoires selon leurs dates\n(jours de l'années)", btn_sort, 80, -40, 5000);
            //toolTip.Show("", btn_sort, 50, 0, 5000);
        }

        private void btn_about_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("A propos", btn_about, 45, -10, 5000);
            //toolTip.Show("About", btn_about, 50, 0, 5000);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }        
    }
}
