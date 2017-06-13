using System;
using Model;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class OrderPanel
    {
        public Logic.BarBestellingLogica Bestelling = new Logic.BarBestellingLogica();
        public BarBestelling BarBestelling;
        public List<BarBestelling> BarBestellingen;

        public OrderPanel()
        {

        }

        public Panel MaakTabControl(Panel Panel)
        {
            Panel.Controls.Clear();
            foreach (Control item in Panel.Controls)
            {
                item.Dispose();
            }

            List<List<BarBestelling>> AllNewOrders = Bestelling.GetAllNewOrders();
            List<List<BarBestelling>> AllOldOrders = Bestelling.GetAllOldOrders();

            //Begin het maken van de controls!
            //Properties instellen van de panel

            Panel.Size = new System.Drawing.Size(1160, 695);
            Panel.Location = new System.Drawing.Point(0, 0);
            Panel.BackColor = System.Drawing.Color.LightSteelBlue;

            //Bestelling.Count controleren om zo alleen de gewenste panelen te maken
            if (AllNewOrders.Count == 0)
            {
                MaakLinkerTabControl(Panel, false);
            }
            else if (AllNewOrders.Count == 1)
            {
                MaakLinkerTabControl(Panel, true);
                MaakRechterTabControl(Panel, false);
            }
            else if (AllNewOrders.Count > 1)
            {
                MaakLinkerTabControl(Panel, true);
                MaakRechterTabControl(Panel, true);
            }
            return Panel;
        }

        public Control MaakLinkerTabControl(Panel Panel, bool BestellingAanwezig)
        {
            BarBestellingen = new List<BarBestelling>();
            Bestelling = new Logic.BarBestellingLogica();
            BarBestelling = new BarBestelling();
            
            //Code voor de linker tabcontrol.
            //Het verschil is 'TabControlLinks' v.g.m. 'TabControlRechts'
            //En is de positie van de TabControl anders.

            TabControl TabControl = new TabControl();
            TabControl.Size = new System.Drawing.Size(1160, 695);
            TabControl.Location = new System.Drawing.Point(12, 12);
            TabControl.Size = new System.Drawing.Size(556, 630);
            TabControl.Name = "TabControlLinks";
            TabControl.ItemSize = new System.Drawing.Size(150, 25);

            if (BestellingAanwezig)
            {
                TabPage TabPage = new TabPage();
                TreeView TreeView = new TreeView();
                Button Button = new Button();
                Label Label1 = new Label();
                Label Label2 = new Label();
                Label Label3 = new Label();
                RichTextBox RichTextBox = new RichTextBox();
                GroupBox GroupBox = new GroupBox();

                //Controls direct toevoegen aan TabPage
                TabPage.Controls.Add(GroupBox);
                TabPage.Controls.Add(TreeView);
                TabPage.Controls.Add(Label1);
                TabPage.Controls.Add(Label2);
                TabPage.Controls.Add(Label3);
                TabPage.Controls.Add(RichTextBox);
                TabPage.Controls.Add(Button);

                //TabPage Properties
                TabPage.Parent = TabControl;
                TabPage.BackColor = System.Drawing.Color.LightSlateGray;

                //GroupBox Properties
                GroupBox.Text = "Extra informatie:";
                GroupBox.Location = new System.Drawing.Point(6, 400);
                GroupBox.Size = new System.Drawing.Size(536, 181);
                GroupBox.BackColor = System.Drawing.Color.Transparent;
                GroupBox.FlatStyle = FlatStyle.Popup;
                GroupBox.Font = new System.Drawing.Font("Trebuchet MS", 10);
                GroupBox.ForeColor = System.Drawing.Color.Gold;

                //TreeView Properties
                TreeView.Name = "TreeViewLinks";
                //TreeView.Parent = TabPage;
                TreeView.ShowRootLines = false;
                TreeView.ShowLines = false;
                TreeView.CheckBoxes = false;
                TreeView.ShowPlusMinus = false;
                TreeView.HideSelection = false;
                TreeView.Scrollable = true;
                TreeView.ItemHeight = 35;
                TreeView.BorderStyle = BorderStyle.None;
                TreeView.Size = new System.Drawing.Size(315, 400);
                TreeView.Location = new System.Drawing.Point(0, 0);
                TreeView.Font = new System.Drawing.Font("Trebuchet MS", 20, System.Drawing.FontStyle.Bold);
                TreeView.Nodes.Add("Drankjes:");
                TreeView.BackColor = System.Drawing.Color.LightSlateGray;
                TreeView.ForeColor = System.Drawing.Color.White;
                TreeView.Nodes[0].NodeFont = new System.Drawing.Font("Trebuchet MS", 20, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                TreeView.Nodes[0].ForeColor = System.Drawing.Color.PaleGreen;

                //RichtextBox Properties
                RichTextBox.Name = "RichTextBoxLinks";
                RichTextBox.BorderStyle = BorderStyle.None;
                RichTextBox.Location = new System.Drawing.Point(316, 144);
                RichTextBox.Size = new System.Drawing.Size(226, 250);

                //Button properties
                Button.Name = "ButtonLinks";
                Button.Text = "Bestelling\nGereed Melden";
                Button.Location = new System.Drawing.Point(316, 6);
                Button.Size = new System.Drawing.Size(226, 130);
                Button.BackColor = System.Drawing.Color.LightGray;
                Button.Font = new System.Drawing.Font("Trebuchet MS", 16, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                Button.ForeColor = System.Drawing.Color.Green;

                //Deze forloop gaat langs elk item in de bestelling.
                //Nu elke item doorlopen en toevoegen aan de TabControl.
                string TabTafelNummer = "";
                string TabBestellingId = "";
                string BestelOpmerking = "Opmerking: \n";
                string Medewerker = "";
                DateTime TijdIngevoerd = new DateTime();

                for (int i = 0; i < 1; i++)
                {
                    foreach (var item in Bestelling.GetAllNewOrders()[i])
                    {
                        //Nodig voor de UI om de data te weergeven.
                        if (i == 0)
                        {
                            TabTafelNummer = item.TafelNummer.ToString();
                            TabBestellingId = item.BestelId.ToString();
                            TijdIngevoerd = item.Invoertijd;
                            Medewerker = item.MedewerkerNaam;
                        }
                        //Nodig voor de knop "gereed maken"
                        BarBestellingen.Add(item);

                        if (item.Opmerking != "" || item.Opmerking != null)
                        {
                            BestelOpmerking += "- " + item.Opmerking + "\n";
                        }
                        TreeView.Nodes[0].Nodes.Add(new TreeNode(item.ItemNaam + "|Aantal: " + item.Aantal));
                    }
                }

                //We willen wél graag het goede object (bestelitem) meegeven. 
                //Hierdoor moeten we een eigen/aangepaste eventhandler maken
                Button.Click += delegate (object sender, EventArgs e)
                {
                    Button_Click(sender, e, BarBestellingen);
                };

                //Label1 Properties BestelTijd (BestelTijd)
                Label1.Text = "Geplaatst op: " + TijdIngevoerd.Year + "-" + TijdIngevoerd.Month + "-" + TijdIngevoerd.Day + " om " + TijdIngevoerd.TimeOfDay;
                Label1.Parent = GroupBox;
                Label1.Location = new System.Drawing.Point(12, 20);
                Label1.Size = new System.Drawing.Size(500, 30);
                Label1.Font = new System.Drawing.Font("Trebuchet MS", 16);
                Label1.ForeColor = System.Drawing.Color.White;
                Label1.Name = "BesteltijdLinks";

                //Label2 Properties (tijdverschil met nu en besteltijd)
                DateTime Verschil = (DateTime.Now - TijdIngevoerd.TimeOfDay);

                Label2.Text = "(" + Verschil.Hour + "h " + Verschil.Minute + "m) geleden.";
                Label2.Parent = GroupBox;
                Label2.Location = new System.Drawing.Point(12, 50);
                Label2.Size = new System.Drawing.Size(500, 30);
                Label2.Font = new System.Drawing.Font("Trebuchet MS", 16);
                Label2.ForeColor = System.Drawing.Color.White;
                Label2.Name = "VerschilLinks";

                //Label3 Properties (Naam medewerker)
                Label3.Text = "Bestelling opgenomen door: " + Medewerker;
                Label3.Parent = GroupBox;
                Label3.Location = new System.Drawing.Point(12, 80);
                Label3.Size = new System.Drawing.Size(500, 30);
                Label3.Font = new System.Drawing.Font("Trebuchet MS", 16);
                Label3.ForeColor = System.Drawing.Color.White;
                Label3.Name = "NaamMedewerkerLinks";

                TreeView.ExpandAll();
                GroupBox.Refresh();

                TabPage.Text = "Eerstvolgende bestelling: Tafel #" + TabTafelNummer;

                if (BestelOpmerking == "Opmerking: ")
                {
                    RichTextBox.Text = "Er zijn geen opmerkingen voor deze bestelling!";
                }
                else
                {
                    RichTextBox.Text = BestelOpmerking;
                }
            }

            else if (!BestellingAanwezig)
            {
                Label Label = new Label();
                TabPage TabPage = new TabPage();

                
                TabPage.BackColor = System.Drawing.Color.LightSlateGray;

                Label.Parent = TabPage;
                Label.Name = "LabelNoOrder";
                Label.Text = "Er zijn op dit moment geen bestellingen.";
                Label.ForeColor = System.Drawing.Color.Red;
                Label.Font = new System.Drawing.Font("Trebuchet MS", 22, System.Drawing.FontStyle.Bold);
                Label.Location = new System.Drawing.Point(12, 12);
                Label.Size = new System.Drawing.Size(500, 695);
                TabPage.Controls.Add(Label);
                TabPage.Text = "Geen bestellingen.";

                //De tabpage aan de tabcontrol toevoegen
                TabControl.Controls.Add(TabPage);
            }

            //De Panel de tabcontrol laten opnemen, of het nou wel of niet een bestelling heeft.
            Panel.Controls.Add(TabControl);
            return Panel;
        }

        public Control MaakRechterTabControl(Panel Panel, bool BestellingAanwezig)
        {
            TabControl TabControl = new TabControl();
            Control returnControls = new Control();
            returnControls.Controls.Add(TabControl);

            //TabControl Properties
            TabControl.Location = new System.Drawing.Point(580, 12);
            TabControl.Size = new System.Drawing.Size(556, 630);
            TabControl.Name = "TabControlRechts";

            //TabControlRechts Wordt hier gemaakt.
            if (BestellingAanwezig)
            {
                //Deze forloop gaat langs elk item in de bestelling.
                //Nu elke item doorlopen en toevoegen aan de TabControl.
                string TabTafelNummer = "";
                string TabBestellingId = "";
                string BestelOpmerking = "Opmerking: \n";
                string Medewerker = "";
                DateTime TijdIngevoerd = new DateTime();

                for (int i = 1; i < Bestelling.GetAllNewOrders()[i].Count; i++)
                {
                    BarBestellingen = new List<BarBestelling>();
                    Bestelling = new Logic.BarBestellingLogica();
                    BarBestelling = new BarBestelling();

                    //Code voor de linker tabcontrol.
                    //Enige verschil is 'TabControlRechts' v.g.m. 'TabControlRechts'
                    //Ook zijn natuurlijk de posities anders.
                    TreeView TreeView = new TreeView();
                    Button Button = new Button();
                    Label Label1 = new Label();
                    Label Label2 = new Label();
                    Label Label3 = new Label();
                    RichTextBox RichTextBox = new RichTextBox();
                    TabPage TabPage = new TabPage();
                    GroupBox GroupBox = new GroupBox();

                    //TabControl properties
                    TabControl.ItemSize = new System.Drawing.Size(150, 25);
                    //TabPage Properties
                    TabPage.Parent = TabControl;
                    TabPage.BackColor = System.Drawing.Color.LightSlateGray;

                    //Controls direct toevoegen aan TabPage
                    TabPage.Controls.Add(GroupBox);
                    TabPage.Controls.Add(TreeView);
                    TabPage.Controls.Add(Label1);
                    TabPage.Controls.Add(Label2);
                    TabPage.Controls.Add(Label3);
                    TabPage.Controls.Add(RichTextBox);
                    TabPage.Controls.Add(Button);

                    //GroupBox Properties
                    GroupBox.Text = "Extra informatie:";
                    GroupBox.Location = new System.Drawing.Point(6, 400);
                    GroupBox.Size = new System.Drawing.Size(536, 181);
                    GroupBox.BackColor = System.Drawing.Color.Transparent;
                    GroupBox.FlatStyle = FlatStyle.Popup;
                    GroupBox.Font = new System.Drawing.Font("Trebuchet MS", 10);
                    GroupBox.ForeColor = System.Drawing.Color.Gold;

                    //TreeView Properties
                    TreeView.Name = "TreeViewLinks";
                    //TreeView.Parent = TabPage;
                    TreeView.ShowRootLines = false;
                    TreeView.ShowLines = false;
                    TreeView.CheckBoxes = false;
                    TreeView.ShowPlusMinus = false;
                    TreeView.HideSelection = false;
                    TreeView.Scrollable = true;
                    TreeView.ItemHeight = 35;
                    TreeView.BorderStyle = BorderStyle.None;
                    TreeView.Size = new System.Drawing.Size(315, 400);
                    TreeView.Location = new System.Drawing.Point(0, 0);
                    TreeView.Font = new System.Drawing.Font("Trebuchet MS", 20, System.Drawing.FontStyle.Bold);
                    TreeView.Nodes.Add("Drankjes:");
                    TreeView.BackColor = System.Drawing.Color.LightSlateGray;
                    TreeView.ForeColor = System.Drawing.Color.White;
                    TreeView.Nodes[0].NodeFont = new System.Drawing.Font("Trebuchet MS", 20, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                    TreeView.Nodes[0].ForeColor = System.Drawing.Color.PaleGreen;

                    //RichtextBox Properties
                    RichTextBox.Name = "RichTextBoxLinks";
                    RichTextBox.BorderStyle = BorderStyle.None;
                    RichTextBox.Location = new System.Drawing.Point(316, 144);
                    RichTextBox.Size = new System.Drawing.Size(226, 250);

                    //Button properties
                    Button.Name = "ButtonLinks";
                    Button.Text = "Bestelling\nGereed Melden";
                    Button.Location = new System.Drawing.Point(316, 6);
                    Button.Size = new System.Drawing.Size(226, 130);
                    Button.BackColor = System.Drawing.Color.LightGray;
                    Button.Font = new System.Drawing.Font("Trebuchet MS", 16, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                    Button.ForeColor = System.Drawing.Color.Green;

                    foreach (var item in Bestelling.GetAllNewOrders()[i])
                    {
                        //Nodig voor de UI om de data te weergeven.
                        TabTafelNummer = item.TafelNummer.ToString();
                        TabBestellingId = item.BestelId.ToString();
                        TijdIngevoerd = item.Invoertijd;
                        Medewerker = item.MedewerkerNaam;

                        //Nodig voor de knop "gereed maken"
                        BarBestellingen.Add(item);

                        if (item.Opmerking != "" || item.Opmerking != null)
                        {
                            BestelOpmerking += "- " + item.Opmerking + "\n";
                        }
                        TreeView.Nodes[0].Nodes.Add(new TreeNode(item.ItemNaam + "|Aantal: " + item.Aantal));
                    }

                    //We willen wél graag het goede object (bestelitem) meegeven. 
                    //Hierdoor moeten we een eigen/aangepaste eventhandler maken
                    Button.Click += delegate (object sender, EventArgs e)
                    {
                        Button_Click(sender, e, BarBestellingen);
                    };

                    //Label1 Properties BestelTijd (BestelTijd)
                    Label1.Text = "Geplaatst op: " + TijdIngevoerd.Year + "-" + TijdIngevoerd.Month + "-" + TijdIngevoerd.Day + " om " + TijdIngevoerd.TimeOfDay;
                    Label1.Parent = GroupBox;
                    Label1.Location = new System.Drawing.Point(12, 20);
                    Label1.Size = new System.Drawing.Size(500, 30);
                    Label1.Font = new System.Drawing.Font("Trebuchet MS", 16);
                    Label1.ForeColor = System.Drawing.Color.White;
                    Label1.Name = "BesteltijdLinks";

                    
                    DateTime Verschil = (DateTime.Now - TijdIngevoerd.TimeOfDay);


                    //Label2 Properties (tijdverschil met nu en besteltijd)
                    Label2.Text = "(" + Verschil.Hour + "h " + Verschil.Minute + "m) geleden.";
                    Label2.Parent = GroupBox;
                    Label2.Location = new System.Drawing.Point(12, 50);
                    Label2.Size = new System.Drawing.Size(500, 30);
                    Label2.Font = new System.Drawing.Font("Trebuchet MS", 16);
                    Label2.ForeColor = System.Drawing.Color.White;
                    Label2.Name = "VerschilLinks";

                    //Label3 Properties (Naam medewerker)
                    Label3.Text = "Bestelling opgenomen door: " + Medewerker;
                    Label3.Parent = GroupBox;
                    Label3.Location = new System.Drawing.Point(12, 80);
                    Label3.Size = new System.Drawing.Size(500, 30);
                    Label3.Font = new System.Drawing.Font("Trebuchet MS", 16);
                    Label3.ForeColor = System.Drawing.Color.White;
                    Label3.Name = "NaamMedewerkerLinks";

                    TreeView.ExpandAll();
                    GroupBox.Refresh();

                    TabPage.Text = "Eerstvolgende bestelling: Tafel #" + TabTafelNummer;

                    if (BestelOpmerking == "Opmerking: ")
                    {
                        RichTextBox.Text = "Er zijn geen opmerkingen voor deze bestelling!";
                    }
                    else
                    {
                        RichTextBox.Text = BestelOpmerking;
                    }
                }
            }
            else if (!BestellingAanwezig)
            {
                Label Label = new Label();
                TabPage TabPage = new TabPage();

                TabPage.BackColor = System.Drawing.Color.LightSlateGray;

                Label.Parent = TabPage;
                Label.Name = "LabelNoOrder";
                Label.Text = "Er zijn geen andere bestellingen.";
                Label.ForeColor = System.Drawing.Color.Red;
                Label.Font = new System.Drawing.Font("Trebuchet MS", 22, System.Drawing.FontStyle.Bold);
                Label.Location = new System.Drawing.Point(12, 12);
                Label.Size = new System.Drawing.Size(500, 695);
                TabPage.Controls.Add(Label);
                TabPage.Text = "Geen bestellingen.";

                //De tabpage aan de tabcontrol toevoegen
                TabControl.Controls.Add(TabPage);
            }

            //De Panel de tabcontrol laten opnemen, of het nou wel of niet een bestelling heeft.
            Panel.Controls.Add(TabControl);
            return Panel;
        }

        public Control MaakGeschiedenis(Panel Panel)
        {

            BarBestellingen = new List<BarBestelling>();
            Bestelling = new Logic.BarBestellingLogica();
            BarBestelling = new BarBestelling();

            TabControl TabControl = new TabControl();
            Control returnControls = new Control();

            //TabControl Properties
            TabControl.Location = new System.Drawing.Point(12, 12);
            TabControl.Size = new System.Drawing.Size(556, 630);
            TabControl.Name = "TabControl";

            //TabControlRechts Wordt hier gemaakt.
            //Deze forloop gaat langs elk item in de bestelling.
            //Nu elke item doorlopen en toevoegen aan de TabControl.
            string TabTafelNummer = "";
            string TabBestellingId = "";
            string BestelOpmerking = "Opmerking: \n";
            string Medewerker = "";
            DateTime TijdIngevoerd = new DateTime();

            if (Bestelling.GetAllOldOrders().Count >= 1)
            {
                foreach (var HeleBestelling in Bestelling.GetAllOldOrders())
                {
                    BarBestellingen = new List<BarBestelling>();
                    Bestelling = new Logic.BarBestellingLogica();
                    BarBestelling = new BarBestelling();

                    //Code voor de linker tabcontrol.
                    //Enige verschil is 'TabControlLinks' v.g.m. 'TabControlRechts'
                    //Ook zijn natuurlijk de posities anders.
                    TreeView TreeView = new TreeView();
                    Button Button = new Button();
                    Label Label1 = new Label();
                    Label Label2 = new Label();
                    Label Label3 = new Label();
                    RichTextBox RichTextBox = new RichTextBox();
                    TabPage TabPage = new TabPage();
                    GroupBox GroupBox = new GroupBox();

                    //GroupBox Properties
                    GroupBox.Text = "Extra informatie:";
                    GroupBox.Location = new System.Drawing.Point(6, 400);
                    GroupBox.Size = new System.Drawing.Size(536, 181);
                    GroupBox.BackColor = System.Drawing.Color.Transparent;
                    GroupBox.FlatStyle = FlatStyle.Popup;
                    GroupBox.Font = new System.Drawing.Font("Trebuchet MS", 10);
                    GroupBox.ForeColor = System.Drawing.Color.Gold;

                    //TabControl Properties
                    TabControl.Size = new System.Drawing.Size(556, 630);
                    TabControl.Name = "TabControlLinks";
                    TabControl.ItemSize = new System.Drawing.Size(150, 25);

                    //TreeView Properties
                    TreeView.Name = "TreeViewLinks";
                    //TreeView.Parent = TabPage;
                    TreeView.ShowRootLines = false;
                    TreeView.ShowLines = false;
                    TreeView.CheckBoxes = false;
                    TreeView.ShowPlusMinus = false;
                    TreeView.HideSelection = false;
                    TreeView.Scrollable = true;
                    TreeView.ItemHeight = 35;
                    TreeView.BorderStyle = BorderStyle.None;
                    TreeView.Size = new System.Drawing.Size(315, 400);
                    TreeView.Location = new System.Drawing.Point(0, 0);
                    TreeView.Font = new System.Drawing.Font("Trebuchet MS", 20, System.Drawing.FontStyle.Bold);
                    TreeView.Nodes.Add("Drankjes:");
                    TreeView.BackColor = System.Drawing.Color.LightSlateGray;
                    TreeView.ForeColor = System.Drawing.Color.White;
                    TreeView.Nodes[0].NodeFont = new System.Drawing.Font("Trebuchet MS", 20, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                    TreeView.Nodes[0].ForeColor = System.Drawing.Color.PaleGreen;

                    //RichtextBox Properties
                    RichTextBox.Name = "RichTextBoxLinks";
                    RichTextBox.BorderStyle = BorderStyle.None;
                    RichTextBox.Location = new System.Drawing.Point(316, 144);
                    RichTextBox.Size = new System.Drawing.Size(226, 250);

                    //Button properties
                    Button.Name = "ButtonLinks";
                    Button.Text = "Bestelling\nGereed Melden";
                    Button.Location = new System.Drawing.Point(316, 6);
                    Button.Size = new System.Drawing.Size(226, 130);
                    Button.BackColor = System.Drawing.Color.LightGray;
                    Button.Font = new System.Drawing.Font("Trebuchet MS", 16, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                    Button.ForeColor = System.Drawing.Color.Green;

                    foreach (var BestellingItem in HeleBestelling)
                    {
                        //Nodig voor de UI om de data te weergeven.
                        TabTafelNummer = BestellingItem.TafelNummer.ToString();
                        TabBestellingId = BestellingItem.BestelId.ToString();
                        TijdIngevoerd = BestellingItem.Invoertijd;
                        Medewerker = BestellingItem.MedewerkerNaam;

                        //Nodig voor de knop "gereed maken"
                        BarBestellingen.Add(BestellingItem);

                        if (BestellingItem.Opmerking != "" || BestellingItem.Opmerking != null)
                        {
                            BestelOpmerking += "- " + BestellingItem.Opmerking + "\n";
                        }
                        TreeView.Nodes[0].Nodes.Add(new TreeNode(BestellingItem.ItemNaam));
                    }

                    TabPage.Text = "Tafel #" + TabTafelNummer + " | Besteld om: #" + TijdIngevoerd;
                    TabControl.Controls.Add(TabPage);

                    // We willen wél graag het goede object (bestelitem)meegeven.
                    //Hierdoor moeten we een eigen/aangepaste eventhandler maken
                    Button.Click += delegate (object sender, EventArgs e)
                    {
                        Button_Click(sender, e, BarBestellingen);
                    };

                    //Label1 Properties BestelTijd (BestelTijd)
                    Label1.Text = "Geplaatst op: " + TijdIngevoerd.Year + "-" + TijdIngevoerd.Month + "-" + TijdIngevoerd.Day + " om " + TijdIngevoerd.TimeOfDay;
                    Label1.Parent = GroupBox;
                    Label1.Location = new System.Drawing.Point(12, 20);
                    Label1.Size = new System.Drawing.Size(500, 30);
                    Label1.Font = new System.Drawing.Font("Trebuchet MS", 16);
                    Label1.ForeColor = System.Drawing.Color.White;
                    Label1.Name = "BesteltijdLinks";

                    //Label2 Properties (tijdverschil met nu en besteltijd)
                    DateTime Verschil = (DateTime.Now - TijdIngevoerd.TimeOfDay);

                    Label2.Text = "(" + Verschil.Hour + "h " + Verschil.Minute + "m) geleden.";
                    Label2.Parent = GroupBox;
                    Label2.Location = new System.Drawing.Point(12, 50);
                    Label2.Size = new System.Drawing.Size(500, 30);
                    Label2.Font = new System.Drawing.Font("Trebuchet MS", 16);
                    Label2.ForeColor = System.Drawing.Color.White;
                    Label2.Name = "VerschilLinks";

                    //Label3 Properties (Naam medewerker)
                    Label3.Text = "Bestelling opgenomen door: " + Medewerker;
                    Label3.Parent = GroupBox;
                    Label3.Location = new System.Drawing.Point(12, 80);
                    Label3.Size = new System.Drawing.Size(500, 30);
                    Label3.Font = new System.Drawing.Font("Trebuchet MS", 16);
                    Label3.ForeColor = System.Drawing.Color.White;
                    Label3.Name = "NaamMedewerkerLinks";

                    TreeView.ExpandAll();

                    Panel.Controls.Add(TabControl);

                    if (BestelOpmerking == "Opmerking: ")
                    {
                        RichTextBox.Text = "Er zijn geen opmerkingen voor deze bestelling!";
                    }
                    else
                    {
                        RichTextBox.Text = BestelOpmerking;
                    }
                }
            }
            else if (Bestelling.GetAllOldOrders().Count == 0)
            {
                Label Label = new Label();
                TabPage TabPage = new TabPage();

                Label.Parent = TabPage;
                Label.Name = "LabelNoOrder";
                Label.Text = "Geen bestellingen in de geschiedenis.";
                Label.ForeColor = System.Drawing.Color.Red;
                Label.Font = new System.Drawing.Font("Trebuchet MS", 22, System.Drawing.FontStyle.Bold);
                Label.Location = new System.Drawing.Point(12, 12);
                Label.Size = new System.Drawing.Size(500, 50);
                TabPage.Controls.Add(Label);
                TabPage.Text = "Geen bestellingen in de geschiedenis.";
                TabControl.Controls.Add(TabPage);

                Panel.Controls.Add(TabControl);

                //returnControls.Controls.Add(TabControl);
                return Panel;
            }
            return Panel;
        }

        private void Button_Click(object sender, EventArgs e, List<BarBestelling> Bestellingen)
        {
            DialogResult DialogResult = MessageBox.Show("Weet u zeker dat de bestelling gereed is?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Ik moet een bestellingobject meegeven.
            if (DialogResult == DialogResult.Yes)
            {
                //Zet status van order gereed.
                foreach (var item in BarBestellingen)
                {
                    Bestelling.BestellingGereed(item);
                }
            }
        }
    }
}
