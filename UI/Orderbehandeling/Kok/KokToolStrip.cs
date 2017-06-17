using System;
using System.Windows.Forms;
using Model;

namespace UI
{
    public class KokToolStrip
    {
        Kok Kok;
        Panel Panel;
        Timer Timer1;
        MainForm MainForm;

        Medewerker Medewerker = null;
        ToolStrip ToolStrip = new ToolStripProperties.ToolStripItem();


        public KokToolStrip(Kok Kok, Panel Panel, Timer Timer1, Medewerker Medewerker, MainForm MainForm)
        {
            this.MainForm = MainForm;
            this.Kok = Kok;
            this.Panel = Panel;
            this.Timer1 = Timer1;
            this.Medewerker = Medewerker;
        }

        public Control maakToolStrip()
        {

            ToolStripButton TSB1 = new ToolStripProperties.ToolStripStandaardButton("Uitloggen");
            ToolStripButton TSB2 = new ToolStripProperties.ToolStripOverzichtKnop("Bestelgeschiedenis inzien");
            ToolStripButton TSB3 = new ToolStripProperties.ToolStripOverzichtKnop("Terug naar orderoverzicht");
            ToolStripLabel TSL1 = new ToolStripProperties.ToolStripStandaardLabel("Ingelogd als:", Medewerker);
            ToolStripSeparator TSP = new ToolStripProperties.ToolStripStandaardSeperator();
            ToolStripSeparator TSP2 = new ToolStripProperties.ToolStripStandaardSeperator();

            TSB3.Visible = false;
            TSB3.Enabled = false;

            ToolStrip.Items.Add(TSL1);
            ToolStrip.Items.Add(TSP2);
            ToolStrip.Items.Add(TSB1);
            ToolStrip.Items.Add(TSP2);
            ToolStrip.Items.Add(TSB2);
            ToolStrip.Items.Add(TSB3);

            TSB1.Click += delegate (object s, EventArgs e) {
                TSB1_Click(s, e);
            };

            TSB2.Click += delegate (object s, EventArgs e) {
                TSB2_Click(s, e, TSB2, TSB3);
            };

            TSB3.Click += delegate (object s, EventArgs e) {
                TSB3_Click(s, e, TSB2, TSB3);
            };

            return ToolStrip;
        }

        private void TSB3_Click(object sender, EventArgs e, ToolStripButton TSB2, ToolStripButton TSB3)
        {
            KokOrderScherm BOS = new KokOrderScherm();

            foreach (Control item in Panel.Controls)
            {
                item.Dispose();
            }

            Panel.Controls.Clear();

            Kok.Controls.Add(BOS.MaakControls(Panel));
            Timer1.Start();

            TSB3.Visible = false;
            TSB3.Enabled = false;
            TSB2.Visible = true;
            TSB2.Enabled = true;

            ToolStrip.Refresh();
            ToolStrip.Update();
        }

        void TSB2_Click(object sender, EventArgs e, ToolStripButton TSB2, ToolStripButton TSB3)
        {
            //Hier de code om de geschiedenis te weergeven.

            KokOrderScherm BOS = new KokOrderScherm();

            foreach (Control item in Panel.Controls)
            {
                item.Dispose();
            }

            //Eerst de huidige control leegmaken.
            Panel.Controls.Clear();

            //Stoppen met updaten
            Timer1.Stop();

            //De panel vullen met nieuwe bestellingen
            Kok.Controls.Add(BOS.MaakGeschiedenis(Panel));

            TSB2.Visible = false;
            TSB2.Enabled = false;
            TSB3.Visible = true;
            TSB3.Enabled = true;

            ToolStrip.Refresh();
            ToolStrip.Update();
        }

        private void TSB1_Click(object sender, EventArgs e)
        {
            Kok.Close();
            MainForm.Show();
        }
    }
}