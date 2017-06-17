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
        decimal fooi;

        public TotaalRekeningUserControl(Bestelling bestelling, decimal fooi = 0M)
        {
            InitializeComponent();
            this.fooi = fooi;
            rekening = new BerekenRekening().Berekenen(bestelling);

            GetLabels();
        }

        public void GetLabels()
        {
            decimal TotaalIncl = rekening.TotaalExclusief / 1.21M;
            
            LabelPrijsInclBTW.Text = rekening.TotaalExclusief.ToString();
            rekening.BtwBedrag = rekening.TotaalExclusief - TotaalIncl;
            rekening.BtwBedrag = decimal.Round(rekening.BtwBedrag, 2);
            LabelBTW.Text = rekening.BtwBedrag.ToString();
            TotaalIncl = decimal.Round(TotaalIncl, 2);

            LabelPrijsExclBTW.Text = TotaalIncl.ToString();

            LabelTip.Text = fooi.ToString();

            LabelTotaalprijs.Text = (TotaalIncl + fooi).ToString();
        }

        public void VoegTipToe(decimal TipToevoegen)
        {
            fooi += TipToevoegen;
            GetLabels();
        }
    }
}
