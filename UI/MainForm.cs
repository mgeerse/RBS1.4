using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
