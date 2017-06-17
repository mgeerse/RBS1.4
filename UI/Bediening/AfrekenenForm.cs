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
    public partial class AfrekenenForm : Form
    {
        private BedieningForm parent;
        private Tafel tafel;

        Bestelling bestelling;

        TotaalRekeningUserControl field;

        public AfrekenenForm(BedieningForm parent, Tafel tafel)
        {
            InitializeComponent();

            this.tafel = tafel;
            this.parent = parent;

            bestelling = new BerekenRekening().GetLaatsteForTafel(tafel.Id);
        }

        private void AfrekenenForm_Load(object sender, EventArgs e)
        {
            InitRekening();

            field = new TotaalRekeningUserControl(bestelling);

            TotaalRekeningPanel.Controls.Add(field);

            bestelling.Rekening = new BerekenRekening().CreateRekening();

            new BerekenRekening().UpdateRekening(bestelling.Rekening);
        }

        private void BetalenButton_Click(object sender, EventArgs e)
        {
            ConfirmBetaaldForm form = new ConfirmBetaaldForm(parent);
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog();

            bestelling.Rekening.BtwBedrag = decimal.Parse(field.Controls["LabelBTW"].Text);
            bestelling.Rekening.TotaalExclusief = decimal.Parse(field.Controls["LabelPrijsExclBTW"].Text);

            new BerekenRekening().GetOpmerkingVanUI(bestelling);

            new BerekenRekening().UpdateRekening(bestelling.Rekening);
        }

        private void ButtonOpmerkingen_Click(object sender, EventArgs e)
        {
            bestelling.Opmerking = textBoxOpmerkingen.Text;
            new BerekenRekening().GetOpmerkingVanUI(bestelling);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitRekening()
        {
            List<Bestelitem> items = new BerekenRekening().GetForBestelling(bestelling.Id);

            RekeningPanel.RowCount = 0;

            RekeningPanel.RowStyles.Add(new RowStyle());

            foreach (Bestelitem item in items)
            {
                RekeningUserControl form = new RekeningUserControl(item);
                RekeningPanel.RowCount = RekeningPanel.RowCount + 1;
                RekeningPanel.Controls.Add(form, 0, RekeningPanel.RowCount - 1);
            }
        }

        private void TipToevoegenButton_Click(object sender, EventArgs e)
        {
            decimal fooi = decimal.Parse(textBoxTip.Text);

            field.VoegTipToe(fooi);
        }

        private void TerugButton_Click(object sender, EventArgs e)
        {
            // Faal: BedieningBestellingOverzichtForm form1 = new BedieningBestellingOverzichtForm(Tafelnummer, parent);

        }
    }
}
