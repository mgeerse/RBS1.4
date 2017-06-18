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


        public BedieningBestellingOverzichtForm(BedieningForm parent, int Tafelnummer)
        {
            this.tafel = new TafelLogic().GetTafel(Tafelnummer);
            this.parent = parent;


            InitializeComponent();
        }

        private void BedieningBestellingOverzichtForm_Load(object sender, EventArgs e)
        {
            BestellingenPanel.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            BestellingenPanel.RowStyles.Add(new RowStyle());

            InitBestellingOverzicht();
        }

        private void InitBestellingOverzicht()
        {

            List<Bestelitem> bestelitems = new BestellingOverzicht().GetNietGeredeBestelitems(tafel.Id);
            BestellingenPanel.RowCount = 0;


            foreach (Bestelitem item in bestelitems)
            {
                BestellingUserControl form = new BestellingUserControl(item, this);
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
                //form1 = new AfrekenenForm(parent);
                //form1.TopLevel = false;
                //form1.FormBorderStyle = FormBorderStyle.None;
                //parent.Controls["ContentPanel"].Controls.Clear();
                //parent.Controls["ContentPanel"].Controls.Add(form1);
                //form1.Show();
                parent.ShowForm(new AfrekenenForm(parent, tafel));
            }

        }

        private void buttonBestellingToevoegen_Click(object sender, EventArgs e)
        {
            BedieningMenuForm form = new BedieningMenuForm(tafel, parent);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            parent.Controls["ContentPanel"].Controls.Clear();
            parent.Controls["ContentPanel"].Controls.Add(form);
            form.Show();
        }
    }
}

