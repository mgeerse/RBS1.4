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
    public partial class MainForm : Form
    {
        public MainForm()
        {
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
            btn_Uitloggen.Visible = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            Bediening tafel1 = new Bediening();
            tafel1.Show();
            Tafel Isbezet = true;
            
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

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            Bediening tafel3 = new Bediening();
            tafel3.Show();
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            Bediening tafel4 = new Bediening();
            tafel4.Show();
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            Bediening tafel5 = new Bediening();
            tafel5.Show();
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            Bediening tafel6 = new Bediening();
            tafel6.Show();
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            Bediening tafel7 = new Bediening();
            tafel7.Show();
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            Bediening tafel8 = new Bediening();
            tafel8.Show();
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            Bediening tafel9 = new Bediening();
            tafel9.Show();
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            Bediening tafel10 = new Bediening();
            tafel10.Show();
        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            Bediening tafel2 = new Bediening();
            tafel2.Show();
        }
    }
}
