using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Logic
{
    public class BarBestellingLogica
    {
        DAL.BestelitemDAO BestelitemDAO;
        public BarBestellingLogica() { }

        // Maak een methode die een bestelling opvraagd, en hierna de bestelitems die daar in zitten.
        // Moet een nieuwe bestelling zijn. Moeten op "ingevoerd = 0" staan

        // Maak een methode die teruggestuurde bestelling ophaalt.
        // Moet een teruggestuurde bestelling zijn. Moeten op "ingevoerd = 3" staan

        // Maak een methode die alle bestellingen binnen krijgt, met daarna alle items die er in zitten.
        // Dit moet aangeroepen worden zodra de gescheidenis wordt opgehaald. Moeten op klaar staan.

        // Maak een methode die een bestellig op gereed zet. Gebruik update binnen de BestellingItemDAO
        // Gereed = 3
        // Nodig

        // Maak een methode die een bestellig op in de maak zet. Gebruik update binnen de BestellingItemDAO.
        // Nodig: Bestellingitem Object met de aangepaste waardes. Misschien een extra methode maken om deze aan te passen?
        // De knop moet dan zowel dit object meegeven.

        // Maak een methode die alle bar bestellingen (BestellingDAO.GetAlleBarBestellingen()) koppelt aan een 'bestelling'.
        // Deze bestelling kunnen we dan in de UI zetten.
        // Kijk uit met NULL returnen
        // Herziening: één methode voor zowel nieuw, in de maak, en oud. Ook teruggestuurd.
        // Methode: BestelIdItemFrequenite


        public List<Bestelitem> GetOrdersForStatus(int Status)
        {
            BestelitemDAO = new DAL.BestelitemDAO();
            List<Bestelitem> BestelItems = new List<Bestelitem>();
            BestelItems = BestelitemDAO.GetBarBestellingenForStatus(Status);

            return BestelItems;
        }

        public bool BestellingGereed(List<Bestelitem> Object)
        {
            //DAO update/gereed.
            //Huidige status wordt meegegeven voor extra zekerheid binnen het systeem. 
            BestelitemDAO = new DAL.BestelitemDAO();

            try
            {
                foreach (var item in Object)
                {
                    BestelitemDAO.orderGereed(item);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
