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
        Tafel tafel;
        AfrekenenForm form1;


        public BedieningBestellingOverzichtForm(BedieningForm parent, int Tafelnummer)
        {
            this.tafel = new TafelLogic().GetTafel(Tafelnummer);
            this.parent = parent;
            form1 = new AfrekenenForm(parent);
            InitializeComponent();
        }

        private void BedieningBestellingOverzichtForm_Load(object sender, EventArgs e)
        {
            BestellingenPanel.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            InitBestellingOverzicht();
        }

        private void InitBestellingOverzicht()
        {
            List<Bestelitem> bestelitems = new BestellingOverzicht().GetNietGeredeBestelitems(tafel.Id);
            BestellingenPanel.RowCount = 0;

            //#region Testdata: Verwijder dit wanneer we met de database werken

            //DateTime minuten = DateTime.Now.AddMinutes(-25);
            //DateTime uur = DateTime.Now.AddHours(-2);
            //bestelitems = new List<Bestelitem>()
            //{
            //    new Bestelitem(new GetBestelling().GetForId(8), new GetMenuitem().GetForId(1), 1, "Aap", Status.Bezig, minuten),
            //    new Bestelitem(new GetBestelling().GetForId(8), new GetMenuitem().GetForId(2), 3, "Aap", Status.Bezig, uur),

            //};
            //#endregion

            BestellingenPanel.RowStyles.Add(new RowStyle());

            foreach (Bestelitem item in bestelitems)
            {
                BestellingUserControl form = new BestellingUserControl(item);
                BestellingenPanel.RowCount = BestellingenPanel.RowCount + 1;
                BestellingenPanel.Controls.Add(form, 0, BestellingenPanel.RowCount - 1);
            }
        }

        public void UpdateBestellingOverzicht()
        {
            BestellingenPanel.Controls.Clear();
            InitBestellingOverzicht();
        }

        private void buttonAfrekenen_Click(object sender, EventArgs e)
        {
            ConfirmAfrekenenForm form = new ConfirmAfrekenenForm(parent);
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.Yes)
            {
                parent.Controls["ContentPanel"].Controls.Clear();
                form1.TopLevel = false;
                parent.Controls["ContentPanel"].Controls.Add(form1);
                form1.Show();
                form1.FormBorderStyle = FormBorderStyle.None;
            }

        }

        private void buttonBestellingToevoegen_Click(object sender, EventArgs e)
        {
            BedieningMenuForm form = new BedieningMenuForm(tafel, parent);
            form.ShowDialog();
            
        }
    }
}

