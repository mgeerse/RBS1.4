using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace UI
{
    /// <summary>
    /// Basisform voor het gebruik van de Chapoo-applicatie.
    /// Vanuit hier worden de applicaties voor mobiele en desktop devices geopend.
    /// </summary>
    public partial class BedieningTafelOverzichtForm : Form
    {
        BedieningForm parent;

        public BedieningTafelOverzichtForm(BedieningForm parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Btn_Tafel1.Visible = true;
            btn_Tafel2.Visible = true;
            btn_Tafel3.Visible = true;
            btn_Tafel4.Visible = true;
            btn_Bezet.Visible = true;
            btn_Bezet.Enabled = false;
            button1.Visible = true;
            button1.Enabled = false;
            btn_Tafel5.Visible = true;
            btn_Tafel6.Visible = true;
            btn_Tafel7.Visible = true;
            btn_Tafel8.Visible = true;
            btn_Tafel9.Visible = true;
            btn_Tafel10.Visible = true;
            btn_BarVoorraad.Visible = true;
            btn_KeukenVoorraad.Visible = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {

        }

        private void btn_BarVoorraad_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel1 = new BedieningBestellingOverzichtForm(parent, 1);
            tafel1.Show();
        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel2 = new BedieningBestellingOverzichtForm(parent, 2);
            tafel2.Show();
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel3 = new BedieningBestellingOverzichtForm(parent, 3);
            tafel3.Show();
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel4 = new BedieningBestellingOverzichtForm(parent, 4);
            tafel4.Show();
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel5 = new BedieningBestellingOverzichtForm(parent, 5);
            tafel5.Show();
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel6 = new BedieningBestellingOverzichtForm(parent, 6);
            tafel6.Show();
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel7 = new BedieningBestellingOverzichtForm(parent, 7);
            tafel7.Show();
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel8 = new BedieningBestellingOverzichtForm(parent, 8);
            tafel8.Show();
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel9 = new BedieningBestellingOverzichtForm(parent, 9);
            tafel9.Show();
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel10 = new BedieningBestellingOverzichtForm(parent, 10);
            tafel10.Show();
        }

        void btn_Loguit_Click(object sender, EventArgs e) { }

        public void ShowTafelBestellingOverzicht(int nummer)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);
            tafel.TopLevel = false;
            parent.Controls["ContentPanel"].Controls.Clear();
            parent.Controls["ContentPanel"].Controls.Add(tafel);
            tafel.Show();
        }


    }
}
