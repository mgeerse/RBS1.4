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
            BedieningTafelOverzichtForm form = new BedieningTafelOverzichtForm(parent);
        }
    }
}
