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
        OrderPanel OP = new OrderPanel();
        ToolStripButton TSB1 = new ToolStripButton();
        ToolStripButton TSB2 = new ToolStripButton();
        ToolStripButton TSB3 = new ToolStripButton();
        ToolStripLabel TSL1 = new ToolStripLabel();
        ToolStripSeparator TSP = new ToolStripSeparator();
        ToolStripSeparator TSP2 = new ToolStripSeparator();
        ToolStrip ToolStrip = new ToolStrip();

        public ToolStripOnder(Barman Barman, Panel Panel)
        {
            this.Barman = Barman;
            this.Panel = Panel;
        }

        public Control maakToolStrip(Model.Medewerker Object)
        {
            //Toolstrip
            ToolStrip.Dock = DockStyle.Bottom;
            ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            ToolStrip.ShowItemToolTips = false;
            
            //ToolStripButton1
            TSB1 = new ToolStripButton();
            TSB1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSB1.Text = "Uitloggen";
            TSB1.Alignment = ToolStripItemAlignment.Left;
            TSB1.BackColor = System.Drawing.Color.DodgerBlue;
            TSB1.Font = new System.Drawing.Font("Trebuchet MS", 11);
            TSB1.ForeColor = System.Drawing.Color.White;

            //ToolStripButton2
            TSB2.Text = "Bestel geschiedenis";
            TSB2.Click += TSB2_Click;
            TSB2.Alignment = ToolStripItemAlignment.Right;
            TSB2.Width = 75;
            TSB2.Font = new System.Drawing.Font("Trebuchet MS", 11);
            TSB2.ForeColor = System.Drawing.Color.White;
            TSB2.BackColor = System.Drawing.Color.DodgerBlue;
            
            //ToolStripButton3
            TSB3.Text = "Terug naar bestellijst";
            TSB3.Click += TSB3_Click;
            TSB3.Alignment = ToolStripItemAlignment.Right;
            TSB3.Visible = false;
            TSB3.Enabled = false;
            TSB3.Width = 75;
            TSB3.BackColor = System.Drawing.Color.DodgerBlue;
            TSB3.Font = new System.Drawing.Font("Trebuchet MS", 11);
            TSB3.ForeColor = System.Drawing.Color.White;

            //ToolStripLabel
            TSL1.Text = "Ingelogd als: " + Object.Naam;
            TSL1.Alignment = ToolStripItemAlignment.Left;
            TSL1.Font = new System.Drawing.Font("Trebuchet MS", 12);

            //ToolStripSeperator van de 
            TSP2.Alignment = ToolStripItemAlignment.Right;

            ToolStrip.Items.Add(TSL1);
            ToolStrip.Items.Add(TSP);
            ToolStrip.Items.Add(TSB1);
            ToolStrip.Items.Add(TSB2);
            ToolStrip.Items.Add(TSB3);
            ToolStrip.Items.Add(TSP2);

            TSB1.Click += delegate (object sender, EventArgs e)
            {
                TSB1_Click(sender, e, Object);
            };

            
            return ToolStrip;
        }

        private void TSB3_Click(object sender, EventArgs e)
        {
            TSB2.Text = "Bestel geschiedenis";

            foreach (Control item in Panel.Controls)
            {
                item.Dispose();
            }
            Panel.Controls.Clear();

            Barman.Controls.Add(OP.MaakTabControl(Panel));

            TSB3.Visible = false;
            TSB3.Enabled = false;
            TSB2.Visible = true;
            TSB2.Enabled = true;

            ToolStrip.Refresh();
            ToolStrip.Update();
        }

        void TSB2_Click(object sender, EventArgs e)
        {
            //Hier de code om de geschiedenis te weergeven.
            
            foreach (Control item in Panel.Controls)
            {
                item.Dispose();
            }

            //Eerst de huidige control leegmaken.
            Panel.Controls.Clear();

            //Hierna zetten we TSB2 op zijn text "Terug naar bestellingen"
            //TSB2.Text = "Terug naar bestellingen";

            //De panel vullen met nieuwe bestellingen
            Barman.Controls.Add(OP.MaakGeschiedenis(Panel));

            TSB2.Visible = false;
            TSB2.Enabled = false;
            TSB3.Visible = true;
            TSB3.Enabled = true;

            ToolStrip.Refresh();
            ToolStrip.Update();
        }

        void TSB2_ClickTerug(object sender, EventArgs e)
        {
            TSB2.Text = "Bestel geschiedenis";

            foreach (Control item in Panel.Controls)
            {
                item.Dispose();
            }
            Panel.Controls.Clear();

            Barman.Controls.Add(OP.MaakTabControl(Panel));
            //Weer de juiste EventHandler aanroepen de volgende keer
            TSB2.Click += TSB2_Click;
        }

        private void TSB1_Click(object sender, EventArgs e, Model.Medewerker Object)
        {
            Object = null;
            Barman.Close();
        }
    }
}