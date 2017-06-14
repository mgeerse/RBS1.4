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
        protected int GebruikteBestellingsId;
        protected int GebruikteIndexes;
        protected int EersteBestelId;
        protected List<BarBestelling> AllNewOrders;
        protected List<BarBestelling> AllOldOrders;

        public OrderPanel()
        {

        }

        public Panel MaakControls(Panel Panel)
        {
            AllNewOrders = Bestelling.GetAllNewOrders();
            AllOldOrders = Bestelling.GetAllOldOrders();

            //Begin het maken van de controls!
            MaakLinkerControl(Panel);
            //MaakRechterControl(Panel);

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
            TabPage TabPage = new TabPage();
            TreeView TreeView = new TreeView();

            #endregion

            #region Controls aanmaken:
            //Oude treeview stond hier
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

            TreeView.Nodes.Add("Drankjes:");

            string TabTafelNummer = "";
            string TabBestellingId = "";
            string BestelOpmerking = "Opmerkingen: \n\n";
            string Medewerker = "";
            DateTime TijdIngevoerd = new DateTime();

            #endregion

            if (AllNewOrders.Count != 0)
            {
                foreach (var BestelList in AllNewOrders)
                {
                    //De gebruikte indexes mag gelijk op 1 staan (we zijn 1 keer door de List heen gelopen):
                    GebruikteIndexes = 1;

                    if (BestelList.BestelId != GebruikteBestellingsId)
                    {
                        #region De labels de correcte text weergeven & de bestelId vastzetten & TreeView node toevoegen en één maal de tabpage text zetten: 
                        //De BestelId gelijk vastzetten:
                        EersteBestelId = BestelList.BestelId;
                        GebruikteBestellingsId = BestelList.BestelId;
                        //We moeten de Node gelijk toevoegen, anders mag er niet een child node worden toegevoegd
                        TabTafelNummer = BestelList.TafelNummer.ToString();
                        TabBestellingId = BestelList.BestelId.ToString();
                        Medewerker = BestelList.MedewerkerNaam;
                        TijdIngevoerd = BestelList.Invoertijd;

                        TabPage.Text = "Tafel#" + TabTafelNummer + " | Besteld om " + TijdIngevoerd.ToString("HH:mm");

                        #endregion

                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:
                        string TreeViewText = BestelList.ItemNaam + "| " + BestelList.Aantal;
                        TreeView.Nodes[0].Nodes.Add(TreeViewText);

                        if (BestelList.Opmerking != null)
                        {
                            BestelOpmerking += " -" + BestelList.ItemNaam + ": " + BestelList.Opmerking + "\n\n";
                        }
                        #endregion

                        //De TabControl aan de panel toevoegen.
                        //Panel.Controls.Add(TabControl);
                    }
                    //Hier worden eventuele tweede dingen toegevoegd aan de eerste tabpage.
                    else if (BestelList.BestelId == GebruikteBestellingsId)
                    {
                        //De gebruikte indexes moet omhoog gedaan worden:
                        GebruikteIndexes++;

                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:
                        string TreeViewText = BestelList.ItemNaam + "| " + BestelList.Aantal;
                        TreeView.Nodes[0].Nodes.Add(TreeViewText);

                        if (BestelList.Opmerking != null)
                        {
                            BestelOpmerking += " -" + BestelList.ItemNaam + ": " + BestelList.Opmerking + "\n\n";
                        }
                        #endregion
                    }

                    #region Eventhandler voor de 'gereed melden' knop:

                    #endregion

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
                    RichTextBox.Text = BestelOpmerking;
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
                    Panel.Controls.Add(TabControl);
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
                foreach (var BestelList in AllNewOrders)
                {                     
                    //Eerst er voor zorgen dat alleen de bestellingen die we niet hebben gehad gedetecteerd worden
                    if (BestelList.BestelId != EersteBestelId && BestelList.BestelId != GebruikteBestellingsId)
                    {
                        //Gelijk de GebruikteBestellingsId vast zetten
                        GebruikteBestellingsId = BestelList.BestelId;

                        #region De labels de correcte text weergeven & de bestelId vastzetten & TreeView node toevoegen en één maal de tabpage text zetten: 
                        //De BestelId gelijk vastzetten:
                        EersteBestelId = BestelList.BestelId;

                        //We moeten de Node gelijk toevoegen, anders mag er niet een child node worden toegevoegd
                        TreeView.Nodes.Add("Drankjes:");
                        TabTafelNummer = BestelList.TafelNummer.ToString();
                        TabBestellingId = BestelList.BestelId.ToString();
                        Medewerker = BestelList.MedewerkerNaam;
                        TijdIngevoerd = BestelList.Invoertijd;

                        TabPage.Text = "Tafel#" + TabTafelNummer + " | Besteld om " + TijdIngevoerd.ToString("HH:mm");

                        #endregion


                        #region Controls aanmaken:
                        TreeView = new TreeView();
                        Button = new Button();
                        Label1 = new Label();
                        Label2 = new Label();
                        Label3 = new Label();
                        RichTextBox = new RichTextBox();
                        GroupBox = new GroupBox();

                        //Controls direct toevoegen aan TabPage
                        TabPage.Controls.Add(GroupBox);
                        TabPage.Controls.Add(TreeView);
                        TabPage.Controls.Add(Label1);
                        TabPage.Controls.Add(Label2);
                        TabPage.Controls.Add(Label3);
                        TabPage.Controls.Add(RichTextBox);
                        TabPage.Controls.Add(Button);

                        #endregion

                        //BestelItemNaam toevoegen aan de TreeView
                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:

                        string TreeViewText = BestelList.ItemNaam + "|" + BestelList.Aantal;
                        TreeView.Nodes[0].Nodes.Add(TreeViewText);

                        if (BestelList.Opmerking != null)
                        {
                            BestelOpmerking += " -" + BestelList.ItemNaam + ": " + BestelList.Opmerking + "\n\n";
                        }
                        #endregion

                        #region De labels de correcte text weergeven & de bestelId vastzetten & TreeView node toevoegen en één maal de tabpage text zetten: 
                        //De BestelId gelijk vastzetten:
                        EersteBestelId = BestelList.BestelId;

                        //We moeten de Node gelijk toevoegen, anders mag er niet een child node worden toegevoegd
                        TreeView.Nodes.Add("Drankjes:");
                        TabTafelNummer = BestelList.TafelNummer.ToString();
                        TabBestellingId = BestelList.BestelId.ToString();
                        Medewerker = BestelList.MedewerkerNaam;
                        TijdIngevoerd = BestelList.Invoertijd;

                        TabPage.Text = "Tafel#" + TabTafelNummer + " | Besteld om " + TijdIngevoerd.ToString("HH:mm");

                        #endregion
                    }
                    //Als het toch wel voor komt dat de bestellingsId zojuist is gebruikt dan willen we hier alleen de items van toevoegen aan de TreeView en RichTextBox
                    else if (BestelList.BestelId == GebruikteBestellingsId)
                    {
                        //De gebruikte indexes moet omhoog gedaan worden:
                        GebruikteIndexes++;

                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:
                        string TreeViewText = BestelList.ItemNaam + "|" + BestelList.Aantal;
                        TreeView.Nodes[0].Nodes.Add(TreeViewText);

                        if (BestelList.Opmerking != null)
                        {
                            BestelOpmerking += " -" + BestelList.ItemNaam + ": " + BestelList.Opmerking + "\n\n";
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
                    RichTextBox.Location = new System.Drawing.Point(316, 144);
                    RichTextBox.Size = new System.Drawing.Size(226, 250);
                    RichTextBox.Text = BestelOpmerking;
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
            #region TabControl aanmaken:
            TabControl TabControl = new TabControl();
            TabControl.Location = new System.Drawing.Point(12, 12);
            TabControl.Size = new System.Drawing.Size(556, 630);
            //TabControl.Name = "TabControlLinks";
            TabControl.ItemSize = new System.Drawing.Size(150, 25);
            #endregion

            GebruikteBestellingsId = 0;
            GebruikteIndexes = 0;

            AllOldOrders = Bestelling.GetAllOldOrders();

            if (AllOldOrders.Count >= 1)
            {
                foreach (var BestelLijst in AllOldOrders)
                {

                }
            }
            else if (AllOldOrders.Count == 0)
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
            }

            return Panel;
        }

        private void Button_Click(object sender, EventArgs e, List<BarBestelling> Bestellingen)
        {
            //DialogResult DialogResult = MessageBox.Show("Weet u zeker dat de bestelling gereed is?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Ik moet een bestellingobject meegeven.
            //if (DialogResult == DialogResult.Yes)
            //{
            //Zet status van order gereed.
            foreach (var item in BarBestellingen)
            {
                //   Bestelling.BestellingGereed(item);
                DialogResult DialogResult2 = MessageBox.Show(item.ItemNaam, item.TafelNummer.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }


            //}
        }
    }
}
