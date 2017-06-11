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

namespace UI
{
    public partial class BestellingUserControl : UserControl
    {
        Bestelitem item;

        public BestellingUserControl(Bestelitem item)
        {
            InitializeComponent();
            this.item = item;
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            LabelAantal.Text = item.Aantal.ToString();
            UpdateTijdLabel();
            LabelStatus.Text = item.Status.ToString();
            LabelGerechtNaam.Text = item.Menuitem.Naam;

        }

        public void UpdateTijdLabel()
        {
            LabelTijdIngevoerd.ForeColor = Color.Black;

            int WachtUur = item.Tijdingevoerd.Hour - DateTime.Now.Hour;
            int WachtMinuten = item.Tijdingevoerd.Minute - DateTime.Now.Minute;
            
            if (WachtMinuten > 30)
            {
                LabelTijdIngevoerd.ForeColor = Color.Red;
            }

            string resultaat = "";
            if (WachtUur > 1)
            {
                LabelTijdIngevoerd.ForeColor = Color.Red;
                resultaat += WachtUur + " Uur ";
            }
            if(WachtMinuten > 1)
            {
                resultaat += WachtMinuten + "Minuten";
            }

            LabelTijdIngevoerd.Text = resultaat;
        }
    }
}
