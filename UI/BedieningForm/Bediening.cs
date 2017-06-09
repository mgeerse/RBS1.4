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
        }

        private void btn_Verberg_Click(object sender, EventArgs e)
        {
            Lijst_Lunch.Visible = false;
            Lijst_Lunch.Hide();
            btn_Verberg.Visible = false;
        }
    }
}
