using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class ToolStripOnder
    {
        Barman Barman;
        Panel Panel;
        ToolStripButton TSB2;
        OrderPanel OP = new OrderPanel();

        public ToolStripOnder(Barman Barman, Panel Panel)
        {
            this.Barman = Barman;
            this.Panel = Panel;
        }

        public Control maakToolStrip(Model.Medewerker Object)
        {
            //Toolstrip
            ToolStrip ToolStrip = new ToolStrip();
            ToolStrip.Dock = DockStyle.Bottom;
            ToolStrip.GripStyle = ToolStripGripStyle.Hidden;


            //ToolStripButton1
            ToolStripButton TSB1 = new ToolStripButton();
            TSB1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSB1.Text = "Uitloggen";
            TSB1.Alignment = ToolStripItemAlignment.Left;

            //ToolStripButton2
            TSB2 = new ToolStripButton();
            TSB2.Text = "Bestel geschiedenis";
            TSB2.Click += TSB2_Click;
            TSB2.Alignment = ToolStripItemAlignment.Right;

            //ToolStripLabel
            ToolStripLabel TSL1 = new ToolStripLabel();
            TSL1.Text = "Ingelogd als: " + Object.Naam;
            TSL1.Alignment = ToolStripItemAlignment.Left;

            //ToolStripSeperators
            ToolStripSeparator TSP = new ToolStripSeparator();
            ToolStripSeparator TSP2 = new ToolStripSeparator();
            TSP2.Alignment = ToolStripItemAlignment.Right;

            ToolStrip.Items.Add(TSL1);
            ToolStrip.Items.Add(TSP);
            ToolStrip.Items.Add(TSB1);
            ToolStrip.Items.Add(TSB2);
            ToolStrip.Items.Add(TSP2);

            TSB1.Click += delegate (object sender, EventArgs e)
            {
                TSB1_Click(sender, e, Object);
            };

            TSB2.Click += TSB2_Click;
            return ToolStrip;
        }

        private void TSB2_Click(object sender, EventArgs e)
        {
            OP = new OrderPanel();

            //Hier de code om de geschiedenis te weergeven.

            //Eerst de huidige control leegmaken.

            foreach (Control item in Panel.Controls)
            {
                Panel.Controls.Remove(item);
                Barman.Controls.Remove(Panel);
            }

            //Hierna zetten we TSB2 op zijn text "Terug naar bestellingen"
            TSB2.Text = "Terug naar bestellingen";
            
            //De panel vullen met nieuwe bestellingen
            Barman.Controls.Add(OP.MaakGeschiedenis(Panel));
            TSB2.Click += TSB2_ClickTerug;
        }

        private void TSB2_ClickTerug(object sender, EventArgs e)
        {
            TSB2.Text = "Bestel geschiedenis";
            OP = new OrderPanel();

            foreach (Control item in Panel.Controls)
            {
                Panel.Controls.Remove(item);
                Barman.Controls.Remove(Panel);
            }

            Barman.Controls.Add(OP.MaakTabControl(Panel));

            TSB2.Click += TSB2_Click;
        }

        private void TSB1_Click(object sender, EventArgs e, Model.Medewerker Object)
        {
            Object = null;
            Barman.Close();
        }
    }
}