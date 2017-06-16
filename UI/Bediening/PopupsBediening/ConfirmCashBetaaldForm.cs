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
    public partial class ConfirmCashBetaaldForm : Form
    {
        BedieningForm parent;

        public ConfirmCashBetaaldForm(BedieningForm parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            int nummer = 20;
            Logic.TafelLogic Tafel = new Logic.TafelLogic();
            Tafel.TafelAfgerekend(nummer);
            TafelOverzicht tafel = new TafelOverzicht();
            tafel.Show();
            this.Close();
            
        }
    }
}
