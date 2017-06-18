using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class ConfirmBetaaldForm : Form
    {
        BedieningForm parent;
        Tafel Tafel;

        public ConfirmBetaaldForm(BedieningForm parent, Tafel Tafel)
        {
            this.parent = parent;
            this.Tafel = Tafel;
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            new TafelLogic().TafelVrijgeven(Tafel.Id);
            BedieningTafelOverzichtForm form = new BedieningTafelOverzichtForm(parent);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            parent.Controls["ContentPanel"].Controls.Clear();
            parent.Controls["ContentPanel"].Controls.Add(form);
            form.Show();

            this.Close();
        }
    }
}
