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
    public partial class AfrekenenForm : Form
    {
        private BedieningForm parent;
        
        public AfrekenenForm(BedieningForm parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        private void AfrekenenForm_Load(object sender, EventArgs e)
        {
            textBoxOpmerkingen.Visible = false;

            this.Close();
        }

        private void BetalenButton_Click(object sender, EventArgs e)
        {
            ConfirmBetaalmethodeForm form = new ConfirmBetaalmethodeForm(parent);
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog();

            if(result == DialogResult.Yes)
            {
                ConfirmCashBetaaldForm CashBetaaldForm = new ConfirmCashBetaaldForm(parent);
                CashBetaaldForm.ShowDialog();
            }
            else if(result == DialogResult.OK)
            {
                TipForm TipForm = new TipForm(parent);
                TipForm.ShowDialog();
            }

            this.Close();
        }

        private void ButtonOpmerkingen_Click(object sender, EventArgs e)
        {
            textBoxOpmerkingen.Visible = true;

        }
    }
}
