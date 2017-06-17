using System.Drawing;
using System.Windows.Forms;
using System;

namespace UI
{
    public class BestelControlsProperties
    {
        public partial class GereedButton : Button
        {
            public GereedButton()
            {
                Name = "ButtonLinks";
                Text = "Bestelling\nGereed Melden";
                Location = new Point(316, 6);
                Size = new Size(226, 130);
                BackColor = Color.LightGray;
                Font = new Font("Trebuchet MS", 16, FontStyle.Bold | FontStyle.Underline);
                ForeColor = Color.Green;
            }
        }
        public partial class TreeViewBestelling : TreeView
        {
            public string NodeText { get; }

            public TreeViewBestelling(string NodeText)
            {
                Nodes.Add(NodeText);

                ShowRootLines = false;
                ShowLines = false;
                CheckBoxes = false;
                ShowPlusMinus = false;
                HideSelection = true;
                Scrollable = true;
                ItemHeight = 35;
                BorderStyle = BorderStyle.None;
                Size = new Size(315, 400);
                Location = new Point(0, 0);
                Font = new Font("Trebuchet MS", 20, FontStyle.Bold);
                BackColor = Color.LightSlateGray;
                ForeColor = Color.White;
                Nodes[0].NodeFont = new Font("Trebuchet MS", 20, FontStyle.Bold | FontStyle.Underline);
                Nodes[0].ForeColor = Color.PaleGreen;

                ExpandAll();
            }
        }

        public partial class GroupBoxInformation : GroupBox
        {
            public GroupBoxInformation(string Titel)
            {
                Text = Titel;
                Location = new Point(6, 400);
                Size = new Size(536, 181);
                BackColor = Color.Transparent;
                FlatStyle = FlatStyle.Popup;
                Font = new Font("Trebuchet MS", 10);
                ForeColor = Color.Gold;
            }
        }

        public partial class OpmerkingTextBox : RichTextBox
        {
            public OpmerkingTextBox()
            {
                BorderStyle = BorderStyle.None;
                Location = new Point(316, 144);
                Size = new Size(226, 250);
            }
        }

        public partial class OpmerkingTextBoxGeschiedenis : RichTextBox
        {
            public OpmerkingTextBoxGeschiedenis()
            {
                BorderStyle = BorderStyle.None;
                Location = new Point(316, 6);
                Size = new Size(226, 400);
            }
        }

        public partial class InfoLabelDatum : Label
        {
            public InfoLabelDatum(DateTime DatumTijd)
            {
                Text = "Besteld om: " + DatumTijd.ToString("dd/MMM") + " om " + DatumTijd.ToString("HH:MM");
                Location = new Point(12, 20);
                Size = new Size(500, 30);
                Font = new Font("Trebuchet MS", 16);
                ForeColor = Color.White;
            }
        }

        public partial class InfoLabelMedewerker : Label
        {
            public InfoLabelMedewerker(string Text)
            {
                this.Text = Text;
                Location = new Point(12, 80);
                Size = new Size(500, 30);
                Font = new Font("Trebuchet MS", 16);
                ForeColor = Color.White;
            }
        }

        public partial class InfoLabelMedewerkerGeschiedenis : Label
        {
            public InfoLabelMedewerkerGeschiedenis(string Text)
            {
                this.Text = Text;
                Location = new Point(12, 50);
                Size = new Size(500, 30);
                Font = new Font("Trebuchet MS", 16);
                ForeColor = Color.White;
            }
        }

        public partial class InfoLabelVerschil : Label
        {
            public InfoLabelVerschil(DateTime DatumTijd)
            {
                ForeColor = Color.White;

                TimeSpan Verschil = new TimeSpan();
                Verschil = DateTime.Now - DatumTijd;

                if (Verschil.TotalMinutes >= 45)
                {
                    ForeColor = Color.Orange;
                }
                else if (Verschil.TotalMinutes >= 60)
                {
                    ForeColor = Color.Red;
                }

                Location = new Point(12, 50);
                Size = new Size(500, 30);
                Font = new Font("Trebuchet MS", 16);

                Text = DatumTijd.Hour + "h" + DatumTijd.Minute + "m" + " geleden.";

            }
        }
        public partial class NoOrderLabel : Label
        {
            public NoOrderLabel(string Text)
            {
                this.Text = Text;
                Text = "Er zijn op dit moment geen bestellingen.";
                ForeColor = Color.Red;
                Font = new Font("Trebuchet MS", 22, FontStyle.Bold);
                Location = new Point(12, 12);
                Size = new Size(500, 695);
            }
        }
        public partial class OrderTabPage : TabPage
        {
            public OrderTabPage(string Text)
            {
                this.Text = Text; 
                BackColor = Color.LightSlateGray;
            }
        }

        public partial class LinkerTabControl : TabControl
        {
            public LinkerTabControl()
            {
                Location = new Point(12, 12);
                Size = new Size(556, 630);
                ItemSize = new Size(150, 25);
            }
        }
        public partial class RechterTabControl : LinkerTabControl
        {
            public RechterTabControl()
            {
                Location = new Point(580, 12);
            }
        }
    }
}
