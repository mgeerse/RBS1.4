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

        }

        private void BetalenButton_Click(object sender, EventArgs e)
        {
            ConfirmBetaalmethodeForm form = new ConfirmBetaalmethodeForm();
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog();

            if(result == DialogResult.Yes)
            {
                ConfirmCashBetaaldForm CashBetaaldForm = new ConfirmCashBetaaldForm();
                CashBetaaldForm.ShowDialog();
            }
            else if(result == DialogResult.OK)
            {
                TipForm TipForm = new TipForm();
                TipForm.ShowDialog();
            }
        }
    }
}
