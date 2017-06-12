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
        public Logic.BarBestellingLogica Bestelling;
        public BarBestelling BarBestelling;
        public List<BarBestelling> BarBestellingen;

        protected int MenuId { get; set; }
        protected int BestelId { get; set; }


        public OrderPanel() { }

        public List<List<Control>> MaakTabControl()
        {
            //Begin het maken van de controls!
            List<List<Control>> ControlLijst = new List<List<Control>>();
            ControlLijst.Add(MaakLinkerTabControl());

            int testAantal = Bestelling.GetAllOrders().Count;

            if (Bestelling.GetAllOrders().Count == 1)
            {
                ControlLijst.Add(MaakRechterTabControl(false));
            }
            else
            {
                ControlLijst.Add(MaakRechterTabControl(true));
            }
            return ControlLijst;
        }

        public List<Control> MaakLinkerTabControl()
        {
            BarBestellingen = new List<BarBestelling>();
            Bestelling = new Logic.BarBestellingLogica();
            BarBestelling = new BarBestelling();

            //Code voor de linker tabcontrol.
            //Het verschil is 'TabControlLinks' v.g.m. 'TabControlRechts'
            //En is de positie van de TabControl anders.

            TabControl TabControl = new TabControl();
            List<Control> allControls = new List<Control>();
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
            //TabControl.DefaultBackColor =  

            //TabPage Properties
            TabPage.Parent = TabControl;
            //TabPage.BackColor = System.Drawing.Color.Red;


            //Controls direct toevoegen aan TabPage
            TabPage.Controls.Add(GroupBox);
            TabPage.Controls.Add(TreeView);
            TabPage.Controls.Add(Label1);
            TabPage.Controls.Add(Label2);
            TabPage.Controls.Add(Label3);
            TabPage.Controls.Add(RichTextBox);
            TabPage.Controls.Add(Button);

            //GroupBox Properties
            GroupBox.Text = "Extra informatie";
            //GroupBox.Parent = TabPage;
            GroupBox.Location = new System.Drawing.Point(6, 400);
            GroupBox.Size = new System.Drawing.Size(536, 181);

            //TabControl Properties
            TabControl.Location = new System.Drawing.Point(12, 12);
            TabControl.Size = new System.Drawing.Size(556, 630);
            TabControl.Name = "TabControlLinks";

            //TreeView Properties
            TreeView.Name = "TreeViewLinks";
            //TreeView.Parent = TabPage;
            TreeView.ShowRootLines = false;
            TreeView.ShowLines = true;
            TreeView.CheckBoxes = false;
            TreeView.ShowPlusMinus = false;
            TreeView.HideSelection = false;
            TreeView.ItemHeight = 35;
            TreeView.BorderStyle = BorderStyle.None;
            TreeView.Size = new System.Drawing.Size(315, 400);
            TreeView.Location = new System.Drawing.Point(0, 0);
            TreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, System.Drawing.FontStyle.Bold);
            TreeView.Nodes.Add("Drankjes: ");

            //RichtextBox Properties
            RichTextBox.Name = "RichTextBoxLinks";
            //RichTextBox.Parent = TabPage;
            RichTextBox.Location = new System.Drawing.Point(316, 144);
            RichTextBox.Size = new System.Drawing.Size(226, 250);
            RichTextBox.BorderStyle = BorderStyle.FixedSingle;

            //Button properties
            //Button.Click += Button_Click;
            Button.Name = "ButtonLinks";
            //Button.Parent = TabPage;
            Button.Text = "Gereed Melden";
            Button.Location = new System.Drawing.Point(316, 6);
            Button.Size = new System.Drawing.Size(226, 130);

            //Deze forloop gaat langs elk item in de bestelling.
            //Nu elke item doorlopen en toevoegen aan de TabControl.
            string TabTafelNummer = "";
            string TabBestellingId = "";
            string BestelOpmerking = "Opmerking: \n";
            string Medewerker = "";
            DateTime TijdIngevoerd = new DateTime();

            for (int i = 0; i < 1; i++)
            {
                foreach (var item in Bestelling.GetAllOrders()[i])
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
                    TreeView.Nodes[0].Nodes.Add(new TreeNode(item.ItemNaam));
                }
            }

            //We willen wél graag het goede object (bestelitem) meegeven. 
            //Hierdoor moeten we een eigen/aangepaste eventhandler maken
            Button.Click += delegate (object sender, EventArgs e)
            {
                Button_Click(sender, e, BarBestellingen);
            };

            //Label1 Properties BestelTijd (BestelTijd)
            Label1.Text = "Geplaatst om: " + TijdIngevoerd.TimeOfDay;
            Label1.Parent = GroupBox;
            Label1.Location = new System.Drawing.Point(12, 32);
            Label1.Size = new System.Drawing.Size(233, 20);
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            Label1.Name = "BesteltijdLinks";

            //Label2 Properties (tijdverschil met nu en besteltijd)
            DateTime Verschil = (DateTime.Now - TijdIngevoerd.TimeOfDay);

            Label2.Text = Verschil.Hour + "h" + Verschil.Minute + "m geleden.";
            Label2.Parent = GroupBox;
            Label2.Location = new System.Drawing.Point(12, 52);
            Label2.Size = new System.Drawing.Size(173, 20);
            Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            Label2.Name = "VerschilLinks";

            //Label3 Properties (Naam medewerker)
            Label3.Text = "Bestelling opgenomen door: " + Medewerker;
            Label3.Parent = GroupBox;
            Label3.Location = new System.Drawing.Point(12, 72);
            Label3.Size = new System.Drawing.Size(329, 20);
            Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            Label3.Name = "NaamMedewerkerLinks";

            TreeView.ExpandAll();
            GroupBox.Update();
            GroupBox.Refresh();


            TabPage.Text = "Tafel #" + TabTafelNummer + " | BestellingId #" + TabBestellingId;

            if (BestelOpmerking == "Opmerking: ")
            {
                RichTextBox.Text = "Er zijn geen opmerkingen voor deze bestelling!";
            }
            else
            {
                RichTextBox.Text = BestelOpmerking;
            }

            allControls.Add(TabControl);
            return allControls;
        }


        public List<Control> MaakRechterTabControl(bool bestellingAanwezig)
        {
            
            TabControl TabControl = new TabControl();
            List<Control> allControls = new List<Control>();
            allControls.Add(TabControl);

            //TabControl Properties
            TabControl.Location = new System.Drawing.Point(580, 12);
            TabControl.Size = new System.Drawing.Size(556, 630);
            TabControl.Name = "TabControlRechts";

            //TabControlRechts Wordt hier gemaakt.
            if (bestellingAanwezig)
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
                    //Enige verschil is 'TabControlLinks' v.g.m. 'TabControlRechts'
                    //Ook zijn natuurlijk de posities anders.
                    TreeView TreeView = new TreeView();
                    Button Button = new Button();
                    Label Label1 = new Label();
                    Label Label2 = new Label();
                    Label Label3 = new Label();
                    RichTextBox RichTextBox = new RichTextBox();
                    TabPage TabPage = new TabPage();

                    //TreeView Properties
                    TreeView.Name = "TreeViewRechts" + i.ToString();
                    TreeView.Parent = TabPage;
                    TreeView.ShowRootLines = false;
                    TreeView.ShowLines = true;
                    TreeView.CheckBoxes = false;
                    TreeView.ShowPlusMinus = false;
                    TreeView.HideSelection = false;
                    TreeView.ItemHeight = 35;
                    TreeView.BorderStyle = BorderStyle.None;
                    TreeView.Size = new System.Drawing.Size(315, 400);
                    TreeView.Location = new System.Drawing.Point(0, 0);
                    TreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, System.Drawing.FontStyle.Bold);
                    TreeView.Nodes.Add("Drankjes: ");

                    //RichtextBox Properties
                    RichTextBox.Name = "RichTextBoxRechts" + i.ToString();
                    RichTextBox.Parent = TabPage;
                    RichTextBox.Location = new System.Drawing.Point(316, 144);
                    RichTextBox.Size = new System.Drawing.Size(226, 250);
                    RichTextBox.BorderStyle = BorderStyle.FixedSingle;

                    //Button properties
                    //Button.Click += Button_Click;
                    Button.Name = "ButtonRechts" + i.ToString();
                    Button.Parent = TabPage;
                    Button.Text = "Gereed Melden";
                    Button.Location = new System.Drawing.Point(316, 6);
                    Button.Size = new System.Drawing.Size(226, 130);

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
                        TreeView.Nodes[0].Nodes.Add(new TreeNode(item.ItemNaam));
                    }
                    //Maak hier nieuwe controls aan per bestelling.
                    
                    TabPage.Text = "Tafel #" + TabTafelNummer + " | Besteld om: #" + TijdIngevoerd;
                    TabControl.Controls.Add(TabPage);

                    // We willen wél graag het goede object (bestelitem)meegeven.
                    //Hierdoor moeten we een eigen/aangepaste eventhandler maken
                    Button.Click += delegate (object sender, EventArgs e)
                    {
                        Button_Click(sender, e, BarBestellingen);
                    };

                    //Label1 Properties BestelTijd (BestelTijd)
                    Label1.Parent = TabPage;
                    Label1.Text = "Geplaatst om: " + TijdIngevoerd.TimeOfDay;
                    Label1.Location = new System.Drawing.Point(6, 400);
                    Label1.Size = new System.Drawing.Size(233, 20);
                    Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                    Label1.Name = "BesteltijdRechts";
                    DateTime VerschilRechts = (DateTime.Now - TijdIngevoerd.TimeOfDay);

                    //Label2 Properties (tijdverschil met nu en besteltijd)
                    Label2.Parent = TabPage;
                    Label2.Text = VerschilRechts.Hour + "h" + VerschilRechts.Minute + "m geleden.";
                    Label2.Location = new System.Drawing.Point(6, 420);
                    Label2.Size = new System.Drawing.Size(173, 20);
                    Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                    Label2.Name = "VerschilRechts";
                    //Label3 Properties (Naam medewerker)
                    Label3.Parent = TabPage;
                    Label3.Text = "Bestelling opgenomen door: " + Medewerker;
                    Label3.Location = new System.Drawing.Point(6, 440);
                    Label3.Size = new System.Drawing.Size(329, 20);
                    Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                    Label3.Name = "NaamMedewerkerRechts";

                    TreeView.ExpandAll();


                    if (BestelOpmerking == "Opmerking: ")
                    {
                        RichTextBox.Text = "Er zijn geen opmerkingen voor deze bestelling!";
                    }
                    else
                    {
                        RichTextBox.Text = BestelOpmerking;
                    }
                }
                return allControls;
            }
            else if (!bestellingAanwezig)
            {
                Label Label = new Label();
                TabPage TabPage = new TabPage();

                Label.Parent = TabPage;
                Label.Name = "LabelNoOrder";
                Label.Text = "Geen andere bestelling aanwezig!";
                Label.ForeColor = System.Drawing.Color.Red;
                Label.Font = new System.Drawing.Font("Trebuchet MS", 22, System.Drawing.FontStyle.Bold);
                Label.Location = new System.Drawing.Point(12, 12);
                Label.Size = new System.Drawing.Size(500, 50);
                TabPage.Controls.Add(Label);
                TabPage.Text = "Geen andere bestellingen.";
                TabControl.Controls.Add(TabPage);

                allControls.Add(TabControl);
                return allControls;
            }
            return new List<Control>();
        }

        public List<Control> NotMoreThanOneOrder()
        {

            return new List<Control>();
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
            else
            {
                //Hoeft niks te gebeuren.
            }

        }
    }
}
