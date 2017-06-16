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
        public Bestelitem Bestelitem;
        public List<Bestelitem> BestelItems = new List<Bestelitem>();
        protected int LaatsGebruikteId;
        protected int GebruikteIndexes;
        protected int EersteBestelId;
        protected List<Bestelitem> AllNewOrders;
        protected List<Bestelitem> AllOldOrders;

        public OrderPanel()
        {

        }

        public Panel MaakControls(Panel Panel)
        {
            AllNewOrders = Bestelling.GetOrdersForStatus(0);


            //Begin het maken van de controls!
            MaakLinkerControl(Panel);
            MaakRechterControl(Panel);

            return Panel;
        }

        public Control MaakLinkerControl(Panel Panel)
        {
            #region Eerst de TabControl en TabPage aanmaken:
            TabControl TabControl = new TabControl();
            TabControl.Size = new System.Drawing.Size(1160, 695);
            TabControl.Location = new System.Drawing.Point(12, 12);
            TabControl.Size = new System.Drawing.Size(556, 630);
            //TabControl.Name = "TabControlLinks";
            TabControl.ItemSize = new System.Drawing.Size(150, 25);


            #endregion

            #region Controls aanmaken:
            //Oude treeview stond hier
            Button Button = new Button();
            Label Label1 = new Label();
            Label Label2 = new Label();
            Label Label3 = new Label();
            RichTextBox RichTextBox = new RichTextBox();
            GroupBox GroupBox = new GroupBox();
            TabPage TabPage = new TabPage();
            TreeView TreeView = new TreeView();

            TabPage.Controls.Add(GroupBox);
            TabPage.Controls.Add(TreeView);
            TabPage.Controls.Add(Label1);
            TabPage.Controls.Add(Label2);
            TabPage.Controls.Add(Label3);
            TabPage.Controls.Add(RichTextBox);
            TabPage.Controls.Add(Button);

            string TabTafelNummer = "";
            string TabBestellingId = "";
            string Medewerker = "";
            DateTime TijdIngevoerd = new DateTime();
            #endregion

            foreach (var item in AllNewOrders.Take(1))
            {
                EersteBestelId = item.Bestelling.Id;
            }

            GebruikteIndexes = 0;
            LaatsGebruikteId = 0;

            if (AllNewOrders.Count != 0)
            {
                foreach (var BestelList in AllNewOrders)
                {
                    

                    if (BestelList.Bestelling.Id != EersteBestelId)
                    {
                        break;
                    }
                    else if (BestelList.Bestelling.Id == EersteBestelId)
                    {
                        //De gebruikte indexes mag gelijk op 1 komen te staan (we zijn 1 keer door de List heen gelopen):
                        GebruikteIndexes++;
                        #region De labels de correcte text weergeven & de bestelId vastzetten & TreeView node toevoegen en één maal de tabpage text zetten: 
                        //De BestelId gelijk vastzetten:
                        EersteBestelId = BestelList.Bestelling.Id;
                        LaatsGebruikteId = BestelList.Bestelling.Id;

                        TreeView.Nodes.Add("Drankjes:");

                        //We moeten de Node gelijk toevoegen, anders mag er niet een child node worden toegevoegd
                        TabTafelNummer = BestelList.Bestelling.Tafel.Id.ToString();
                        TabBestellingId = BestelList.Bestelling.Id.ToString();
                        Medewerker = BestelList.Bestelling.Medewerker.Naam;
                        TijdIngevoerd = BestelList.Tijdingevoerd;
                        
                        TabPage.Text = "Eerstvolgende bestelling: Tafel#" + TabTafelNummer + " | Besteld om " + TijdIngevoerd.ToString("HH:mm");

                        #endregion

                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:
                        if (BestelList.Aantal > 1)
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuks");
                        }
                        else
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuk");
                        }

                        if (BestelList.Bestelling.Opmerking != "")
                        {
                            RichTextBox.Text = "Opmerkingen: ";
                            RichTextBox.Text += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Bestelling.Opmerking + "\n";
                        }

                        #endregion
                        BestelItems.Add(BestelList);

                        //De TabControl aan de panel toevoegen.
                        //Panel.Controls.Add(TabControl);
                    }
                    //Hier worden eventuele tweede dingen toegevoegd aan de eerste tabpage.
                    else if (BestelList.Bestelling.Id == LaatsGebruikteId)
                    {
                        //De gebruikte indexes moet omhoog gedaan worden:
                        GebruikteIndexes++;
                        BestelItems.Add(BestelList);

                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:
                        string TreeViewText = BestelList.Menuitem.Naam + "| " + BestelList.Aantal;

                        if (BestelList.Aantal > 1)
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuks");
                        }
                        else
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuk");
                        }

                        if (BestelList.Bestelling.Opmerking != "")
                        {
                            RichTextBox.Text += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Bestelling.Opmerking + "\n";
                        }

                        #endregion
                        BestelItems.Add(BestelList);
                    }

                    #region Properties voor de controls:

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
                    GroupBox.Update();
                    #endregion

                    Button.Click += delegate (object sender, EventArgs e)
                    {
                        Button_Click(sender, e, BestelItems, BestelList.Bestelling.Id);
                    };
                    //Panel.Controls.Add(TabControl);
                }
            }
            else if (AllNewOrders.Count == 0)
            {
                Label Label = new Label();
                TabPage = new TabPage();

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
            Panel.Controls.Add(TabControl);
            return Panel;
        }


        public Control MaakRechterControl(Panel Panel)
        {
            #region TabControl aanmaken:
            TabControl TabControl = new TabControl();
            TabControl.Location = new System.Drawing.Point(580, 12);
            TabControl.Size = new System.Drawing.Size(556, 630);
            //TabControl.Name = "TabControlLinks";
            TabControl.ItemSize = new System.Drawing.Size(150, 25);
            #endregion

            #region Eerst de TabControl en TabPage aanmaken:
            TabPage TabPage = new TabPage();
            TreeView TreeView = new TreeView();
            RichTextBox RichTextBox = new RichTextBox();
            Button Button = new Button();
            Label Label1 = new Label();
            Label Label2 = new Label();
            Label Label3 = new Label();
            GroupBox GroupBox = new GroupBox();

            string TabTafelNummer = "";
            string TabBestellingId = "";
            string BestelOpmerking = "Opmerkingen: \n\n";
            string Medewerker = "";
            DateTime TijdIngevoerd = new DateTime();
            #endregion

            if (AllNewOrders.Count > GebruikteIndexes)
            {
                foreach (var BestelList in AllNewOrders.Skip(GebruikteIndexes))
                {
                    //Eerst er voor zorgen dat alleen de bestellingen die we niet hebben gehad gedetecteerd worden
                    if (BestelList.Bestelling.Id != LaatsGebruikteId)
                    {
                        //Gelijk de GebruikteBestellingsId vast zetten
                        LaatsGebruikteId = BestelList.Bestelling.Id;

                        //Hetgeen hieronder moet aan de knop 'gereed melden' worden gegeven.
                        BestelItems.Add(BestelList);

                        #region Controls aanmaken:
                        TreeView = new TreeView();
                        Button = new Button();
                        Label1 = new Label();
                        Label2 = new Label();
                        Label3 = new Label();
                        RichTextBox = new RichTextBox();
                        GroupBox = new GroupBox();
                        TabPage = new TabPage();

                        //Controls direct toevoegen aan TabPage
                        TabPage.Controls.Add(GroupBox);
                        TabPage.Controls.Add(TreeView);
                        TabPage.Controls.Add(Label1);
                        TabPage.Controls.Add(Label2);
                        TabPage.Controls.Add(Label3);
                        TabPage.Controls.Add(RichTextBox);
                        TabPage.Controls.Add(Button);

                        TabControl.Controls.Add(TabPage);
                        #endregion

                        #region De labels de correcte text weergeven & de bestelId vastzetten & TreeView node toevoegen en één maal de tabpage text zetten: 
                        //We moeten de Node gelijk toevoegen, anders mag er niet een child node worden toegevoegd
                        TreeView.Nodes.Add("Drankjes:");

                        TabTafelNummer = BestelList.Bestelling.Tafel.Id.ToString();
                        TabBestellingId = BestelList.Bestelling.Id.ToString();
                        Medewerker = BestelList.Bestelling.Medewerker.Naam;
                        TijdIngevoerd = BestelList.Tijdingevoerd;

                        TabPage.Text = "Tafel#" + TabTafelNummer + " | Besteld om " + TijdIngevoerd.ToString("HH:mm");

                        #endregion

                        //BestelItemNaam toevoegen aan de TreeView
                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:

                        if (BestelList.Aantal > 1)
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuks");
                        }
                        else
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuk");
                        }

                        if (BestelList.Bestelling.Opmerking != "")
                        {
                            RichTextBox.Text = "Opmerkingen: ";
                            RichTextBox.Text += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Bestelling.Opmerking + "\n";
                        }
                        else
                        {
                            RichTextBox.Text = "Er zijn is geen opmerkingen voor deze bestelling.";
                        }
                         
                        #endregion

                    }
                    else if (BestelList.Bestelling.Id == LaatsGebruikteId)
                    {
                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:

                        if (BestelList.Aantal > 1)
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuks");
                        }
                        else
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuk");
                        }
                        

                        if (BestelList.Bestelling.Opmerking != "")
                        {
                            RichTextBox.Text = "Opmerkingen: ";
                            RichTextBox.Text += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Bestelling.Opmerking + "\n";
                        }
                        else
                        {
                            RichTextBox.Text = "Er zijn geen opmerkingen voor deze bestelling.";
                        }

                        BestelItems.Add(BestelList);
                        TabControl.Controls.Add(TabPage);
                        #endregion
                    }

                    Button.Click += delegate (object sender, EventArgs e)
                    {
                        Button_Click(sender, e, BestelItems, BestelList.Bestelling.Id);
                    };

                    #region Properties voor de controls:

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
                    GroupBox.Update();
                    #endregion
                }
                Panel.Controls.Add(TabControl);
            }
            else if (AllNewOrders.Count == GebruikteIndexes)
            {
                #region controls en properties:

                Label Label = new Label();
                TabPage = new TabPage();

                TabPage.BackColor = System.Drawing.Color.LightSlateGray;

                Label.Parent = TabPage;
                Label.Name = "LabelNoOrder";
                Label.Text = "Er zijn op dit moment geen verdere bestellingen.";
                Label.ForeColor = System.Drawing.Color.Red;
                Label.Font = new System.Drawing.Font("Trebuchet MS", 22, System.Drawing.FontStyle.Bold);
                Label.Location = new System.Drawing.Point(12, 12);
                Label.Size = new System.Drawing.Size(500, 695);
                TabPage.Controls.Add(Label);
                TabPage.Text = "Geen bestellingen.";

                #endregion

                //De tabpage aan de tabcontrol toevoegen
                TabControl.Controls.Add(TabPage);


                //De Panel de tabcontrol laten opnemen, of het nou wel of niet een bestelling heeft.
                Panel.Controls.Add(TabControl);
            }
            return Panel;
        }

        public Control MaakGeschiedenis(Panel Panel)
        {
            GebruikteIndexes = 0;
            LaatsGebruikteId = 0;
            AllOldOrders = Bestelling.GetOrdersForStatus(2);

            #region TabControl aanmaken:
            TabControl TabControl = new TabControl();
            TabControl.Location = new System.Drawing.Point(12, 12);
            TabControl.Size = new System.Drawing.Size(556, 630);
            //TabControl.Name = "TabControlLinks";
            TabControl.ItemSize = new System.Drawing.Size(150, 25);
            #endregion

            #region Eerst de TabControl en TabPage aanmaken:
            TabPage TabPage = new TabPage();
            TreeView TreeView = new TreeView();
            RichTextBox RichTextBox = new RichTextBox();
            Label Label1 = new Label();
            Label Label2 = new Label();
            Label Label3 = new Label();
            GroupBox GroupBox = new GroupBox();

            string TabTafelNummer = "";
            string TabBestellingId = "";
            string BestelOpmerking = "Opmerkingen: \n\n";
            string Medewerker = "";
            DateTime TijdIngevoerd = new DateTime();
            #endregion

            if (AllOldOrders.Count != 0)
            {
                foreach (var BestelList in AllOldOrders)
                {
                    //Eerst er voor zorgen dat alleen de bestellingen die we niet hebben gehad gedetecteerd worden
                    if (BestelList.Bestelling.Id != LaatsGebruikteId)
                    {
                        LaatsGebruikteId = BestelList.Bestelling.Id;

                        //Gelijk de GebruikteBestellingsId vast zetten
                        LaatsGebruikteId = BestelList.Bestelling.Id;

                        #region Controls aanmaken:
                        TreeView = new TreeView();
                        Label1 = new Label();
                        Label2 = new Label();
                        Label3 = new Label();
                        RichTextBox = new RichTextBox();
                        GroupBox = new GroupBox();
                        TabPage = new TabPage();

                        //Controls direct toevoegen aan TabPage
                        TabPage.Controls.Add(GroupBox);
                        TabPage.Controls.Add(TreeView);
                        TabPage.Controls.Add(Label1);
                        TabPage.Controls.Add(Label2);
                        TabPage.Controls.Add(Label3);
                        TabPage.Controls.Add(RichTextBox);
                        #endregion

                        #region De labels de correcte text weergeven & de bestelId vastzetten & TreeView node toevoegen en één maal de tabpage text zetten: 
                        //De BestelId gelijk vastzetten:
                        EersteBestelId = BestelList.Bestelling.Id;

                        //We moeten de Node gelijk toevoegen, anders mag er niet een child node worden toegevoegd
                        TreeView.Nodes.Add("Drankjes:");
                        TabTafelNummer = BestelList.Bestelling.Id.ToString();
                        TabBestellingId = BestelList.Bestelling.Id.ToString();
                        Medewerker = BestelList.Bestelling.Medewerker.Naam;
                        TijdIngevoerd = BestelList.Tijdingevoerd;
                        BestelOpmerking = "Opmerkingen: \n\n";

                        TabPage.Text = "Besteld op " + TijdIngevoerd.ToString("dd/MMM HH:mm");

                        #endregion

                        //BestelItemNaam toevoegen aan de TreeView
                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:

                        if (BestelList.Aantal > 1)
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuks");
                        }
                        else
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuk");
                        }

                        if (BestelList.Bestelling.Opmerking != "")
                        {
                            RichTextBox.Text = "Opmerkingen: ";
                            RichTextBox.Text += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Opmerking + "\n\n";
                        }
                        else
                        {
                            RichTextBox.Text = "Er waren geen opmerkingen voor deze bestelling.";
                        }
                        #endregion

                        #region De labels de correcte text weergeven & de bestelId vastzetten & TreeView node toevoegen en één maal de tabpage text zetten: 
                        //De BestelId gelijk vastzetten:
                        EersteBestelId = BestelList.Bestelling.Id;

                        //We moeten de Node gelijk toevoegen, anders mag er niet een child node worden toegevoegd
                        TabTafelNummer = BestelList.Bestelling.Tafel.Id.ToString();
                        TabBestellingId = BestelList.Bestelling.Id.ToString();
                        Medewerker = BestelList.Bestelling.Medewerker.Naam;
                        TijdIngevoerd = BestelList.Tijdingevoerd;

                        #endregion
                    }
                    //Als het toch wel voor komt dat de bestellingsId zojuist is gebruikt dan willen we hier alleen de items van toevoegen aan de TreeView en RichTextBox
                    else if (BestelList.Bestelling.Id == LaatsGebruikteId)
                    {
                        //De gebruikte indexes moet omhoog gedaan worden:
                        GebruikteIndexes++;

                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:
                        if (BestelList.Aantal > 1)
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuks");
                        }
                        else
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuk");
                        }

                        if (BestelList.Bestelling.Opmerking != "")
                        {
                            BestelOpmerking += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Opmerking + "\n\n";
                        }
                        #endregion
                    }
                    #region Properties voor de controls:

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
                    TreeView.BackColor = System.Drawing.Color.LightSlateGray;
                    TreeView.ForeColor = System.Drawing.Color.White;
                    TreeView.Nodes[0].NodeFont = new System.Drawing.Font("Trebuchet MS", 20, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                    TreeView.Nodes[0].ForeColor = System.Drawing.Color.PaleGreen;

                    //RichtextBox Properties
                    RichTextBox.Name = "RichTextBoxLinks";
                    RichTextBox.BorderStyle = BorderStyle.None;
                    RichTextBox.Location = new System.Drawing.Point(316, 6);
                    RichTextBox.Size = new System.Drawing.Size(226, 400);

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
                    GroupBox.Update();
                    #endregion
                }
                Panel.Controls.Add(TabControl);
            }
            else if (AllOldOrders.Count == GebruikteIndexes)
            {
                #region controls en properties:

                Label Label = new Label();
                TabPage = new TabPage();

                TabPage.BackColor = System.Drawing.Color.LightSlateGray;

                Label.Parent = TabPage;
                Label.Name = "LabelNoOrder";
                Label.Text = "Er zijn op dit moment geen verdere bestellingen.";
                Label.ForeColor = System.Drawing.Color.Red;
                Label.Font = new System.Drawing.Font("Trebuchet MS", 22, System.Drawing.FontStyle.Bold);
                Label.Location = new System.Drawing.Point(12, 12);
                Label.Size = new System.Drawing.Size(500, 695);
                TabPage.Controls.Add(Label);
                TabPage.Text = "Geen bestellingen.";

                #endregion

                //De tabpage aan de tabcontrol toevoegen
                TabControl.Controls.Add(TabPage);


                //De Panel de tabcontrol laten opnemen, of het nou wel of niet een bestelling heeft.
                Panel.Controls.Add(TabControl);
            }
            return Panel;
        }

        private void Button_Click(object sender, EventArgs e, List<Bestelitem> BestelItems, int Id)
        {
            

            DialogResult DialogResult = MessageBox.Show("Weet u zeker dat de bestelling gereed is?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                try
                {
                    Bestelling.BestellingGereed(BestelItems, Id);
                }
                catch(Exception x)
                {
                    MessageBox.Show("Er is iets misgegaan met het gereed maken van de bestelling! Excuses.", x.ToString());
                }
            }
            else
            {
                MessageBox.Show("De bestelling is niet gereed gemeld!");
            }
        }
    }
}
