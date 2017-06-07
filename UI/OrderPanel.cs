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
        public Logic.BestellingObject BestelObject;

        /**
        protected Button Button;
        protected Panel Panel;
        protected Label Label;
        protected TreeView TreeView;
        **/

        protected int tafelnummer { get; set; }
        protected DateTime bestelTijd { get; set; }
        protected List<Menuitem> menuItems { get; set; }

        public OrderPanel()
        {

        }

        public List<List<Control>> MaakPanelen(int[] idFrequentie)
        {
            List<Control> LabelList = new List<Control>();
            List<Control> PanelList = new List<Control>();
            List<Control> ButtonList = new List<Control>();
            List<Control> TreeViewList = new List<Control>();
            List<Control> RichTextBoxList = new List<Control>();

            List<Control> Controls = new List<Control>();

            List<List<Control>> AlleControls = new List<List<Control>>();

            Label Label = new Label();
            TreeView TreeView = new TreeView();
            Panel Panel = new Panel();
            Button Button = new Button();
            RichTextBox RichTextBox = new RichTextBox();

            int HoogsteVerschilStandaard = 12;
            int VerschilLabel = 0;

            List<BarBestelling> BestelLijst = new List<BarBestelling>();
            BestelLijst = BestelObject.GetOrders();

            for (int i = 0; i < BestelObject.GetOrders().Count; i++)
            //Itereer door aantal orders om de ID Frequentie te helpen
            //i is nodig om de Ids te kunnen itereren
            //Hier kunnen we de volgende dingen doen: Medewerker
            {
                TreeView.Nodes.Add("Bestelling");
                for (int j = 0; j < idFrequentie[i]; j++)
                {
                    int k = 0;
                    if (k < 1)
                    {
                        //Voor Controls die 1 keer moeten worden aangemaakt.
                        //this.label2.Location = new System.Drawing.Point(151, 120);

                        Label.Text = "Bestelling ogenomen door: \r\n" + BestelLijst[i].MedewerkerNaam;
                        Label.ForeColor = System.Drawing.Color.Red;
                        //TODO: Posities Instellen

                        Label.Height = 50 + VerschilLabel;
                        Label.Left = 30;
                        Button.Text = "Gereed melden";

                        k++;
                    }
                    //Hierbinnen komen de verschillende controls terug
                    //Hier kunnen we de volgende dingen doen:
                    //Labels, Treeview

                    Panel.Height = HoogsteVerschilStandaard + 12;
                    Panel.AutoSize = true;



                    RichTextBox.Text += BestelLijst[i].Opmerking + "\n";
                    TreeView.Nodes[j].Nodes.Add(BestelLijst[i].ItemNaam.ToString());

                    Panel.Controls.Add(Label);
                    Panel.Controls.Add(TreeView);
                    Panel.Controls.Add(Button);
                    Panel.Controls.Add(RichTextBox);

                    /**
                    LabelList.Add(Label);
                    ButtonList.Add(Button);
                    PanelList.Add(Panel);
                    TreeViewList.Add(TreeView);
                    RichTextBoxList.Add(RichTextBox);
                    **/                

                    Controls.Add(Label);
                    Controls.Add(Button);
                    Controls.Add(Panel);
                    Controls.Add(TreeView);
                    Controls.Add(RichTextBox);

                    AlleControls.Add(Controls);

                    HoogsteVerschilStandaard = Panel.Height;
                    //Einde eerste FOR
                }
            }

            return AlleControls;
        }

        //public List<Control> MaakPaneel(int aantalOrders)
        //{



        //    return new List<Control>();
        //}

        private void Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
