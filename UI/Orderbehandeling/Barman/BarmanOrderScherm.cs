using System;
using Model;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class BarmanOrderScherm
    {
        public Logic.BestellingLogica Bestelling = new Logic.BestellingLogica();
        public Bestelitem Bestelitem;
        public List<Bestelitem> BestelItems = new List<Bestelitem>();
        protected int LaatsGebruikteId;
        protected int GebruikteIndexes;
        protected int EersteBestelId;
        protected List<Bestelitem> AllNewOrders;
        protected List<Bestelitem> AllOldOrders;

        public BarmanOrderScherm()
        {

        }

        public Panel MaakControls(Panel Panel)
        {
            AllNewOrders = Bestelling.GetBarOrdersForStatus(0);


            //Begin het maken van de controls!
            MaakLinkerControl(Panel);
            MaakRechterControl(Panel);

            return Panel;
        }

        public Control MaakLinkerControl(Panel Panel)
        {
            #region TabControl aanmaken:
            TabControl TabControl = new BestelControlsProperties.LinkerTabControl();
            #endregion

            #region Eerst de TabControl en TabPage aanmaken:
            TabPage TabPage;
            TreeView TreeView = new BestelControlsProperties.TreeViewBestelling("Drankje:");
            RichTextBox RichTextBox = new BestelControlsProperties.OpmerkingTextBox();
            Button Button = new BestelControlsProperties.GereedButton();
            Label Label1;
            Label Label2;
            Label Label3;
            GroupBox GroupBox = new BestelControlsProperties.GroupBoxInformation("Extra informatie: ");
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
                        #region Controls aanmaken en de parent geven.
                        Button = new BestelControlsProperties.GereedButton();
                        Label1 = new BestelControlsProperties.InfoLabelDatum(BestelList.Tijdingevoerd);
                        DateTime TijdVerschil = (DateTime.Now - BestelList.Tijdingevoerd.TimeOfDay);
                        Label2 = new BestelControlsProperties.InfoLabelVerschil(BestelList.Tijdingevoerd);
                        Label3 = new BestelControlsProperties.InfoLabelMedewerker("Bestelling opgenomen door: " + BestelList.Bestelling.Medewerker.Naam);
                        TabPage = new BestelControlsProperties.OrderTabPage("Eerstvolgende bestelling: Tafel#" + BestelList.Bestelling.Tafel.Id + " | Besteld om " + BestelList.Tijdingevoerd.ToString("HH:mm"));


                        TabPage.Controls.Add(GroupBox);
                        TabPage.Controls.Add(TreeView);
                        TabPage.Controls.Add(RichTextBox);
                        TabPage.Controls.Add(Button);

                        GroupBox.Controls.Add(Label1);
                        GroupBox.Controls.Add(Label2);
                        GroupBox.Controls.Add(Label3);

                        TabControl.Controls.Add(TabPage);
                        #endregion
                        //De gebruikte indexes mag gelijk op 1 komen te staan (we zijn 1 keer door de List heen gelopen):
                        GebruikteIndexes++;
                         
                        //De BestelId gelijk vastzetten:
                        EersteBestelId = BestelList.Bestelling.Id;
                        LaatsGebruikteId = BestelList.Bestelling.Id;

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
                        else if (BestelList.Bestelling.Opmerking == "")
                        {
                            RichTextBox.Text = "Er zijn geen opmerkingen voor deze bestelling";
                        }

                        #endregion
                        BestelItems.Add(BestelList);
                    }
                    //Hier worden eventuele tweede dingen toegevoegd aan de eerste tabpage.
                    else if (BestelList.Bestelling.Id == LaatsGebruikteId)
                    {
                        //De gebruikte indexes moet omhoog gedaan worden:
                        GebruikteIndexes++;
                        BestelItems.Add(BestelList);

                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:

                        TreeView.Nodes[0].Text = "Drankjes:";

                        if (BestelList.Aantal > 1)
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuks");
                        }
                        else
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuk");
                        }
                        if (!RichTextBox.Text.Contains("Opmerkingen: ") && BestelList.Bestelling.Opmerking != "")
                        {
                            RichTextBox.Text = "Opmerkingen: ";
                            RichTextBox.Text += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Bestelling.Opmerking + "\n";
                        }

                        #endregion
                        BestelItems.Add(BestelList);
                    }

                    #region Properties voor de controls:
                    GroupBox.Update();
                    #endregion

                    Button.Click += delegate (object sender, EventArgs e)
                    {
                        Button_Click(sender, e, BestelItems, BestelList.Bestelling.Id);
                    };
                }
            }
            else if (AllNewOrders.Count == 0)
            {
                Label Label = new BestelControlsProperties.NoOrderLabel("Er zijn geen bestellingen.");
                TabPage = new BestelControlsProperties.OrderTabPage("Geen orders!");
                Label.Parent = TabPage;

                //De tabpage aan de tabcontrol toevoegen
                TabControl.Controls.Add(TabPage);
            }
            Panel.Controls.Add(TabControl);
            return Panel;
        }


        public Control MaakRechterControl(Panel Panel)
        {
            #region TabControl aanmaken:
            TabControl TabControl = new BestelControlsProperties.RechterTabControl();
            #endregion

            #region Eerst de TabControl en TabPage aanmaken:
            TabPage TabPage;
            TreeView TreeView = new BestelControlsProperties.TreeViewBestelling("Drankje: ");
            RichTextBox RichTextBox = new BestelControlsProperties.OpmerkingTextBox();
            Button Button = new BestelControlsProperties.GereedButton();
            Label Label1;
            Label Label2;
            Label Label3;
            GroupBox GroupBox = new BestelControlsProperties.GroupBoxInformation("Extra informatie: ");
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
                        TreeView = new BestelControlsProperties.TreeViewBestelling("Drankjes:");
                        Button = new BestelControlsProperties.GereedButton();
                        Label1 = new BestelControlsProperties.InfoLabelDatum(BestelList.Tijdingevoerd);
                        DateTime Verschil = (DateTime.Now - BestelList.Tijdingevoerd.TimeOfDay);
                        Label2 = new BestelControlsProperties.InfoLabelVerschil(BestelList.Tijdingevoerd);
                        Label3 = new BestelControlsProperties.InfoLabelMedewerker("Bestelling opgenomen door: " + BestelList.Bestelling.Medewerker.Naam);
                        RichTextBox = new BestelControlsProperties.OpmerkingTextBox();
                        GroupBox = new BestelControlsProperties.GroupBoxInformation("Extra informatie: ");
                        TabPage = new BestelControlsProperties.OrderTabPage("Tafel#" + BestelList.Bestelling.Tafel.Id + " | Besteld om " + BestelList.Tijdingevoerd.ToString("HH:mm"));

                        //Controls de juiste parent geven
                        TabPage.Controls.Add(GroupBox);
                        TabPage.Controls.Add(TreeView);
                        TabPage.Controls.Add(RichTextBox);
                        TabPage.Controls.Add(Button);

                        GroupBox.Controls.Add(Label1);
                        GroupBox.Controls.Add(Label2);
                        GroupBox.Controls.Add(Label3);

                        TabControl.Controls.Add(TabPage);
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

                        TreeView.Nodes[0].Text = "Drankjes:";

                        if (BestelList.Aantal > 1)
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuks");
                        }
                        else
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuk");
                        }


                        if (!RichTextBox.Text.Contains("Opmerkingen: ") && BestelList.Bestelling.Opmerking != "")
                        {
                            RichTextBox.Text = "Opmerkingen: ";
                            RichTextBox.Text += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Bestelling.Opmerking + "\n";
                        }
                        BestelItems.Add(BestelList);
                        #endregion
                    }

                    Button.Click += delegate (object sender, EventArgs e)
                    {
                        Button_Click(sender, e, BestelItems, BestelList.Bestelling.Id);
                    };

                    GroupBox.Update();
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

            AllOldOrders = Bestelling.GetBarOrdersForStatus(2);

            #region TabControl aanmaken:
            TabControl TabControl = new BestelControlsProperties.LinkerTabControl();
            #endregion

            #region Eerst de TabControl en TabPage aanmaken:
            TabPage TabPage;
            TreeView TreeView = new BestelControlsProperties.TreeViewBestelling("Drankjes:");
            RichTextBox RichTextBox = new BestelControlsProperties.OpmerkingTextBox();
            Label Label1;
            Label Label2;
            GroupBox GroupBox = new BestelControlsProperties.GroupBoxInformation("Extra informatie: ");
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
                        TreeView = new BestelControlsProperties.TreeViewBestelling("Drankje:");
                        Label1 = new BestelControlsProperties.InfoLabelDatum(BestelList.Tijdingevoerd);
                        Label2 = new BestelControlsProperties.InfoLabelMedewerkerGeschiedenis("Bestelling opgenomen door: " + BestelList.Bestelling.Medewerker.Naam);
                        RichTextBox = new BestelControlsProperties.OpmerkingTextBoxGeschiedenis();
                        GroupBox = new BestelControlsProperties.GroupBoxInformation("Extra informatie: ");
                        TabPage = new BestelControlsProperties.OrderTabPage("Tafel#" + BestelList.Bestelling.Tafel.Id + " | Besteld om " + BestelList.Tijdingevoerd.ToString("HH:mm"));

                        //Controls direct toevoegen aan TabPage
                        #region Controls aan de tabPage toevoegen:
                        TabPage.Controls.Add(GroupBox);
                        TabPage.Controls.Add(TreeView);
                        TabPage.Controls.Add(RichTextBox);

                        GroupBox.Controls.Add(Label1);
                        GroupBox.Controls.Add(Label2);

                        TabControl.Controls.Add(TabPage);
                        #endregion
                        #endregion

                        #region De labels de correcte text weergeven & de bestelId vastzetten & TreeView node toevoegen en één maal de tabpage text zetten: 
                        //De BestelId gelijk vastzetten:
                        EersteBestelId = BestelList.Bestelling.Id;
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
                            RichTextBox.Text += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Bestelling.Opmerking + "\n\n";
                        }
                        else
                        {
                            RichTextBox.Text = "Er waren geen opmerkingen voor deze bestelling.";
                        }
                        #endregion

                        #region De labels de correcte text weergeven & de bestelId vastzetten & TreeView node toevoegen en één maal de tabpage text zetten: 
                        //De BestelId gelijk vastzetten:
                        EersteBestelId = BestelList.Bestelling.Id;
                        #endregion
                    }
                    //Als het toch wel voor komt dat de bestellingsId zojuist is gebruikt dan willen we hier alleen de items van toevoegen aan de TreeView en RichTextBox
                    else if (BestelList.Bestelling.Id == LaatsGebruikteId)
                    {
                        //De gebruikte indexes moet omhoog gedaan worden:
                        GebruikteIndexes++;

                        TreeView.Nodes[0].Text = "Drankjes:";
                        #region Items toevoegen aan de treeview, en de opmerkingen hiervan meenemen:
                        if (BestelList.Aantal > 1)
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuks");
                        }
                        else
                        {
                            TreeView.Nodes[0].Nodes.Add(BestelList.Menuitem.Naam + "| " + BestelList.Aantal + " stuk");
                        }

                        if (!RichTextBox.Text.Contains("Opmerkingen: ") && BestelList.Bestelling.Opmerking != "")
                        {
                            RichTextBox.Text = "Opmerkingen: ";
                            RichTextBox.Text += "\n- " + BestelList.Menuitem.Naam + ": " + BestelList.Bestelling.Opmerking + "\n";
                        }
                        #endregion
                    }
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
                Label.Text = "Er staan op dit moment geen bestellingen in de geschiedenis.";
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
