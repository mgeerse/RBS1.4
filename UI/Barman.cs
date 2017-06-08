using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Barman : Form
    {
        public Barman()
        {
            //als ik een list terugkrijg hierzo kan ik een iteration doen 
            //dan elke control makkelijk toevoegen
            Logic.BestellingObject BO = new Logic.BestellingObject();

            List<List<Control>> Controls = new List<List<Control>>();

            //Logic.InitializeData ID = new Logic.InitializeData();

            //Logic laag

            //Orders bij de juiste bestelling
            int[] IdFrequentie = null;

            try
            {
                if (BO.GetIdFrequentie() != null)
                {
                    OrderPanel OP = new OrderPanel();

                    IdFrequentie = BO.GetIdFrequentie();

                    Controls = OP.MaakPanelen(IdFrequentie);

                    foreach (var item in Controls)
                    {
                        foreach (var control in item)
                        {
                            this.Controls.Add(control);
                        }
                    }
                }

                else
                {
                    
                }
                IdFrequentie = BO.GetIdFrequentie();
                int aantal_Bestellingen = IdFrequentie.Length;
            }
            catch (Exception e)
            {

                MessageBox.Show("Er zijn geen bestellingen ingevoerd.");
            }

            //Kijken naar aantal bestellingen

            //Nu per bestelling een paneel aan maken, we moeten het aantal items
            //meegeven en hoeveel er voor zijn geweest. We moeten ook de beginhoogte meegeven.

            Controls = OP.MaakPanelen(IdFrequentie);

            foreach (var item in Controls)
            {
                foreach (var control in item)
                {
                    this.Controls.Add(control);
                }
            }
        }

        private void Barman_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10000;


        }
    }
}
