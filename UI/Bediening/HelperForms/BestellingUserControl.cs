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
            BorderStyle = BorderStyle.Fixed3D;
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            LabelAantal.Text = item.Aantal.ToString();
            LabelGerechtNaam.Text = item.Menuitem.Naam;

            LabelStatus.Text = item.Status.ToString();
            LabelTafelNummer.Text = item.Bestelling.Tafel.Id.ToString();
            UpdateTijdLabel();

        }

        public void UpdateTijdLabel()
        {
            LabelTijdIngevoerd.ForeColor = Color.Black;

            int WachtUur = DateTime.Now.Hour - item.Tijdingevoerd.Hour;
            int WachtMinuten = DateTime.Now.Minute - item.Tijdingevoerd.Minute;

            if (WachtMinuten > 30)
            {
                LabelTijdIngevoerd.ForeColor = Color.Red;
            }

            string resultaat = "";
            if (WachtUur > 1)
            {
                // Nodig, als een bestelling om 9:55 wordt gedaan en het nu 10:05 is, dan zou het verschil in minuten -50
                // zijn, en het verschil in uren 1. Dus, als het verschil in minuten negatief is, dan trekken we een uur
                // eraf om dit te voorkomen.
                if (WachtMinuten < 0)
                {
                    WachtUur -= 1;
                    WachtMinuten += 60;
                }
                LabelTijdIngevoerd.ForeColor = Color.Red;
                resultaat += WachtUur + " Uur ";
            }
            if (WachtMinuten > 1 || WachtUur > 1)
            {
                resultaat += WachtMinuten + " Minuten";
            }

            LabelTijdIngevoerd.Text = resultaat;
        }

        private void LabelTijdIngevoerd_Click(object sender, EventArgs e)
        {

        }
    }
}
