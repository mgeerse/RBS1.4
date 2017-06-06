using System;
using Model;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class BestelPanel
    {
        public Button button = new Button();
        public Panel panel = new Panel();

        public int tafelnummer { get; set; }
        public DateTime bestelTijd { get; set; }
        public List<Menuitem> menuItems { get; set; }
        public bool Klaar { get; set; }

        public BestelPanel(int tafelnummer, DateTime bestelTijd, List<Menuitem> menuItems, bool Klaar)
        {
            button.Click += Button_Click;

            this.tafelnummer = tafelnummer;
            this.bestelTijd = bestelTijd;
            this.menuItems = menuItems;
            this.Klaar = Klaar;

            Label label = new Label();
            label.Text = "Haha";
            panel.Controls.Add(button);
            panel.Controls.Add(label);

            /**
            
            DateTime tijd = bestelTijd;
            List<MenuItem> mi = new List<MenuItem>();**/
        }

        public BestelPanel()
        {
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
