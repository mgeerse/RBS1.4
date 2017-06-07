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
           
        }

        private void Barman_Load(object sender, EventArgs e)
        {
            //als ik een list terugkrijg hierzo kan ik een iteration doen 
            //dan elke control makkelijk toevoegen
            Logic.BestellingObject BO = new Logic.BestellingObject();
            List<List<Control>> Controls = new List<List<Control>>();

            Logic.InitializeData ID = new Logic.InitializeData();

            ID.Start();

            //Logic laag

            //Orders bij de juiste bestelling
            int[] IdFrequentie = BO.GetIdFrequentie();

            //Kijken naar aantal bestellingen
            int aantal_Bestellingen = IdFrequentie.Length;

            OrderPanel OP = new OrderPanel();

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
    }
}
