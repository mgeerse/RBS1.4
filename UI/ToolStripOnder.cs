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

        public ToolStripOnder(Barman Barman) { this.Barman = Barman; }

        public Control maakToolStrip(Model.Medewerker Object)
        {
            //Toolstrip
            ToolStrip ToolStrip = new ToolStrip();
            ToolStrip.Dock = DockStyle.Bottom;

            //ToolStripButton1
            ToolStripButton TSB1 = new ToolStripButton();
            TSB1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSB1.Text = "UItloggen";
            TSB1.Alignment = ToolStripItemAlignment.Left;

            //ToolStripButton2
            ToolStripButton TSB2 = new ToolStripButton();
            TSB2.Text = "Bestel geschiedenis";
            TSB2.Click += TSB2_Click;
            TSB2.Alignment = ToolStripItemAlignment.Right;

            //ToolStripLabel
            ToolStripLabel TSL1 = new ToolStripLabel();
            TSL1.Text = "Ingelogd als: " + Object.Naam;
            TSL1.Alignment = ToolStripItemAlignment.Left;

            ToolStrip.Items.Add(TSB1);
            ToolStrip.Items.Add(TSB2);
            ToolStrip.Items.Add(TSL1);


            TSB1.Click += delegate (object sender, EventArgs e)
            {
                TSB1_Click(sender, e, Object);
            };

            return ToolStrip;
        }

        private void TSB2_Click(object sender, EventArgs e)
        {
            //Hier de code om de geschiedenis te weergeven.
        }

        private void TSB1_Click(object sender, EventArgs e, Model.Medewerker Object)
        {
            Object = null;
            Barman.Close();
        }
    }
}
