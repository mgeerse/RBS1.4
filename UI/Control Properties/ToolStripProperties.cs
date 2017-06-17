using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace UI
{
    public class ToolStripProperties
    {
        public partial class ToolStripItem : ToolStrip
        {
            public ToolStripItem()
            {
                Dock = DockStyle.Bottom;
                GripStyle = ToolStripGripStyle.Hidden;
                BackColor = Color.LightSteelBlue;
                ShowItemToolTips = false;
            }
        }

        public partial class ToolStripStandaardButton : ToolStripButton
        {
            public ToolStripStandaardButton(string Text)
            {
                this.Text = Text;
                DisplayStyle = ToolStripItemDisplayStyle.Text;
                Text = "Uitloggen";
                Alignment = ToolStripItemAlignment.Left;
                BackColor = Color.DodgerBlue;
                Font = new Font("Trebuchet MS", 11);
                ForeColor = Color.White;
            }
        }

        public partial class ToolStripOverzichtKnop : ToolStripButton
        {
            public ToolStripOverzichtKnop(string Text)
            {
                this.Text = Text;
                Alignment = ToolStripItemAlignment.Right;
                Width = 75;
                Font = new Font("Trebuchet MS", 11);
                ForeColor = Color.White;
                BackColor = Color.DodgerBlue;
            }
        }

        public partial class ToolStripStandaardLabel : ToolStripLabel
        {
            public ToolStripStandaardLabel(string Text, Model.Medewerker Medewerker)
            {
                this.Text = Text + " " + Medewerker.Naam;
                Alignment = ToolStripItemAlignment.Left;
                Font = new Font("Trebuchet MS", 12);
            }
        }

        public partial class ToolStripStandaardSeperator : ToolStripSeparator
        {
            public ToolStripStandaardSeperator()
            {
                Alignment = ToolStripItemAlignment.Right;
                BackColor = Color.LightSlateGray;
            }
        }
    }
}
