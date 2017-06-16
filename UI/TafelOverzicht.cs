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
    public partial class TafelOverzicht : Form
    {
        public TafelOverzicht()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btn_Bezet.Enabled = false;
            button1.Enabled = false;
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
