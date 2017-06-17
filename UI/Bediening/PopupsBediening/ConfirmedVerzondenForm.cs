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
    public partial class ConfirmedVerzondenForm : Form
    {
        BedieningForm parent;

        public ConfirmedVerzondenForm(BedieningForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
            //BedieningTafelOverzichtForm form = new BedieningTafelOverzichtForm(parent);
            //form.StartPosition = FormStartPosition.CenterParent;
            //if(form.ShowDialog() == DialogResult.OK)
            //{
            //    parent.Controls["ContentPanel"].Controls.Clear();
            //    ConfirmVerzendenForm form1 = new ConfirmVerzendenForm(parent);
            //    form1.TopLevel = false;
            //    parent.Controls["ContentPanel"].Controls.Add(form1);
            //    form1.FormBorderStyle = FormBorderStyle.None;
            //    form1.Show();
            //}
            //Close();
        }
    }
}
