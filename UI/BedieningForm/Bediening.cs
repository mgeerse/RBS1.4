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
    public partial class Bediening : Form
    {
        public Bediening()
        {
            InitializeComponent();
        }

        private void Bediening_Load(object sender, EventArgs e)
        {
            Lijst_Lunch.Visible = false;
        }

        private void btn_BekijkOrder_Click(object sender, EventArgs e)
        {
            Lijst_Lunch.Visible = true;
            Lijst_Lunch.Show();
            btn_Verberg.Visible = true;
            btn_BekijkOrder.Visible = false;
            Lijst_Diner.Visible = true;
            Lijst_Drank.Visible = true;
            Lijst_NonAlcholol.Visible = true;
        }

        private void btn_Verberg_Click(object sender, EventArgs e)
        {
            Lijst_Lunch.Visible = false;
            btn_Verberg.Visible = false;
            btn_BekijkOrder.Visible = true;
            Lijst_NonAlcholol.Visible = false;
            Lijst_Diner.Visible = false;
            Lijst_Drank.Visible = false;
        }

        private void Lijst_Lunch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
