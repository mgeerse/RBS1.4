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
        //Meenemen om ContentPanel aan te roepen
        BedieningForm parent;

        public BedieningBestellingOverzichtForm(BedieningForm parent)
        {
            this.parent = parent;

            InitializeComponent();

            //BestellingenPanel.Controls.Add(new BestellingForm())
        }

        private void BedieningBestellingOverzichtForm_Load(object sender, EventArgs e)
        {
            
        }

        private void InitBestellingOverzicht()
        {
            List<Bestelitem> bestelitems = new BestellingOverzicht().GetNietGeredeBestelitems();

            //#region Testdata: Verwijder dit wanneer we met de database werken

            //DateTime minuten = DateTime.Now.AddMinutes(-25);
            //DateTime uur = DateTime.Now.AddHours(-2);
            //bestelitems = new List<Bestelitem>()
            //{
            //    new Bestelitem(new GetBestelling().GetForId(8), new GetMenuitem().GetForId(1), 1, "Aap", Status.Bezig, minuten),
            //    new Bestelitem(new GetBestelling().GetForId(8), new GetMenuitem().GetForId(2), 3, "Aap", Status.Bezig, uur),

            //};
            //#endregion

            foreach (Bestelitem item in bestelitems)
            {
                BestellingUserControl form = new BestellingUserControl(item);
                BestellingenPanel.Controls.Add(form);
            }
        }

        public void UpdateBestellingOverzicht()
        {
            BestellingenPanel.Controls.Clear();
            InitBestellingOverzicht();
        }

        private void buttonAfrekenen_Click(object sender, EventArgs e)
        {
            ConfirmAfrekenenForm form = new ConfirmAfrekenenForm();
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.Yes)
            {
                parent.Controls["ContentPanel"].Controls.Clear();
                AfrekenenForm form1 = new AfrekenenForm(parent);
                form1.TopLevel = false;
                parent.Controls["ContentPanel"].Controls.Add(form1);
                form1.FormBorderStyle = FormBorderStyle.None;
                form1.Show();
            }
        }
    }
}
