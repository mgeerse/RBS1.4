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
    public partial class BedieningBestellingOverzichtForm : Form
    {
        
        public BedieningBestellingOverzichtForm()
        {
            InitializeComponent();

            //BestellingenPanel.Controls.Add(new BestellingForm())
        }

        private void buttonAfrekenen_Click(object sender, EventArgs e)
        {
            ConfirmAfrekenenForm form = new ConfirmAfrekenenForm();
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.Yes)
            {
                // Neem de rekening form aan
                ContentPanel.Controls.Add(new ());
                ContentPanel.Controls.Clear();


            }
            
        }
    }
}
