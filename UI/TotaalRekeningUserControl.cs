using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace UI
{
    public partial class TotaalRekeningUserControl : UserControl
    {
        Rekening rekening;

        RekeningUserControl BerekeningPrijs;

        public TotaalRekeningUserControl(Bestelling bestelling, RekeningUserControl BerekeningPrijs)
        {
            InitializeComponent();
            
            this.BerekeningPrijs = BerekeningPrijs;

            rekening = new BerekenRekening().Berekenen(bestelling);
        }

        public void GetLabels()
        {
            LabelBTW.Text = rekening.BtwBedrag.ToString();
            LabelPrijsExclBTW.Text = rekening.TotaalExclusief.ToString();
            LabelPrijsInclBTW.Text = rekening.TotaalExclusief.ToString() + rekening.BtwBedrag.ToString();
        }
    }
}
