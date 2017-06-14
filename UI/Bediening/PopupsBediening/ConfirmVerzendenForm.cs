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
    public partial class ConfirmVerzendenForm : Form
    {
        BedieningForm parent;

        public ConfirmVerzendenForm(BedieningForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void CancelVerzendenButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void ConfirmVerzendenButton_Click(object sender, EventArgs e)
        {
            ConfirmedVerzondenForm form = new ConfirmedVerzondenForm(parent);
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
