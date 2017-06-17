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
    public partial class ConfirmAfrekenenForm : Form
    {
        BedieningForm parent;

        public ConfirmAfrekenenForm(BedieningForm parent)
        {
            this.parent = parent;
            InitializeComponent();

            //this.Close();
        }

        private void AfrekenenButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();

        }

        private void CancelAfrekenenButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmAfrekenenForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
