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
    public partial class BedieningMenuForm : Form
    {
        private Tafel tafel;

        BedieningForm parent;

        public BedieningMenuForm(Tafel tafel, BedieningForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.tafel = tafel;
        }

        private void tabDrank_Click(object sender, EventArgs e)
        {

        }

        private void VerzendenButton_Click(object sender, EventArgs e)
        {
            ConfirmVerzendenForm form = new ConfirmVerzendenForm(parent);
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Yes)
            {

                ConfirmedVerzondenForm ConfirmedVerzondenForm = new ConfirmedVerzondenForm(parent);
                ConfirmedVerzondenForm.ShowDialog();
            }


        }
    }
}
