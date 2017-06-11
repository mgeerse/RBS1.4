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
using Logic;

namespace UI
{
    public partial class BedieningBestellingOverzichtForm : Form
    {
        
        public BedieningBestellingOverzichtForm()
        {
            InitializeComponent();

            //BestellingenPanel.Controls.Add(new BestellingForm())
        }

        private void BedieningBestellingOverzichtForm_Load(object sender, EventArgs e)
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

        private void InitBestellingOverzicht()
        {
            List<Bestelitem> bestelitems = new BestellingOverzicht().GetNietGeredeBestelitems();
            // Test data 
            bestelitems = new List<Bestelitem>()
            {
                new Bestelitem(new GetBestelling().GetForId(1), new GetMenuitem().GetForId(1), 1, Status.Bezig, "Aap", new DateTime(2017, 6, 10, 19, 50, 50)),
                new Bestelitem(new GetBestelling().GetForId(1), new GetMenuitem().GetForId(2), 3, Status.Bezig, "Aap", new DateTime(2017, 6, 10, 19, 50, 50)),

            };
            foreach (Bestelitem item in bestelitems)
            {
                BestellingForm form = new BestellingForm(item);
                form.TopLevel = false;
                BestellingenPanel.Controls.Add(form);
                form.Show();
            }
        }

        public void UpdateBestellingOverzicht()
        {
            BestellingenPanel.Controls.Clear();
            InitBestellingOverzicht();
        }
    }
}
