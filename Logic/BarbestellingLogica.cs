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
        BarBestelling BarBestelling;
        //DAL.BestellingDAO BestellingDAO;
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

        // Ik moet hier nog leesbare data geven voor de UI...
        // Het makkelijkste is om 

        public List<List<BarBestelling>> GetAllOldOrders()
        {
            DAL.BestellingDAO BestellingDAO = new DAL.BestellingDAO();
            List<BarBestelling> BarBestelling = new List<BarBestelling>();
            BarBestelling = BestellingDAO.GetAllOldBarBestellingen();

            List<List<BarBestelling>> GesorteerdeLijst = SorteerBarItemsAanBestelling(BarBestelling);

            return GesorteerdeLijst;
        }

        public List<List<BarBestelling>> GetAllOrders()
        {
            DAL.BestellingDAO BestellingDAO = new DAL.BestellingDAO();
            List<BarBestelling> BarBestelling = new List<BarBestelling>();
            BarBestelling = BestellingDAO.GetAllBarBestellingen();

            List<List<BarBestelling>> GesorteerdeLijst = SorteerBarItemsAanBestelling(BarBestelling);

            return GesorteerdeLijst;
        }

        public List<List<BarBestelling>> GetAllNewOrders()
        {
            DAL.BestellingDAO BestellingDAO = new DAL.BestellingDAO();
            List<BarBestelling> BarBestelling = new List<BarBestelling>();
            BarBestelling = BestellingDAO.GetAllNewBarBestelling();

            List<List<BarBestelling>> GesorteerdeLijst = SorteerBarItemsAanBestelling(BarBestelling);

            return GesorteerdeLijst;
        }

        public List<List<BarBestelling>> SorteerBarItemsAanBestelling(List<BarBestelling> Object)
        {
            List<int> Frequentie = BestelIdItemFrequentie(Object);
            List<List<BarBestelling>> TotaalBestellingen = new List<List<BarBestelling>>();

            //Items omzetten naar een list, wat wordt gereturned. Wat ik return is een lijst met daarin lijsten van één bestelling. 
            //De laatste staat gelijk aan één bestelling.

            BarBestelling = new BarBestelling();

            if (Frequentie == null)
            {
                //throw new NotImplementedException();
            }

            for (int i = 0; i < Object.Count; i++)
            {
                List<BarBestelling> Bestellingen = new List<BarBestelling>();

                foreach (int index in Frequentie)
                {
                    //Pak het aantal items in een bestelling via de index.

                    for (int j = 0; j < index; j++)
                    {

                        //Nu we de index hebben kunnen we zeggen hoeveel items er in een bestelling zitten.
                        BarBestelling.BestelId = Object[i].BestelId;
                        BarBestelling.Aantal = Object[i].Aantal;
                        BarBestelling.Invoertijd = Object[i].Invoertijd;
                        BarBestelling.ItemNaam = Object[i].ItemNaam;
                        BarBestelling.MedewerkerNaam = Object[i].MedewerkerNaam;
                        BarBestelling.Opmerking = Object[i].Opmerking;
                        BarBestelling.TafelNummer = Object[i].TafelNummer;
                        BarBestelling.Menuitem = Object[i].Menuitem;

                        Bestellingen.Add(BarBestelling);
                    }
                }
                TotaalBestellingen.Add(Bestellingen);
            }
            return TotaalBestellingen;
        }

        public List<int> BestelIdItemFrequentie(List<BarBestelling> Object)
        {
            //Dit geeft de frequentie terug van alle bestelIds die in de 'BarBestelling' zitten
            //int[] BestelIdItemFrequentie = null;

            List<int> AantalArray = new List<int>();
            int aantal = 0;
            int CheckId = 0;
            //We krijgen een bestellingId mee. Hiermee kunnen we zien bij welke bestelling deze hoort.
            //Hier moeten we op sorteren.
            //Beste in een lijst, of geef een int array mee per bestelling met daarin de indexes van de items per bestelling. 
            //We willen iets terug waarmee we het aantal achtereenvolgende bestelitems kunnen sorteren op bestelling.
            //Zeg dat bestelling 5 items heeft, moet de 'return' bij 0 op 5 staan. Als de volgende twee items heeft, moet 1 op 2 staan.

            //Eerst kijken hoeveel bestellingen er zijn.



            for (int i = 0; i < Object.Count; i++)
            {
  

                //Eerst kijken of de bestelId bekend is.
                //Checken of het BestelId bekend is:

                if (CheckId != Object[i].BestelId)
                {
                    //Het is niet bekend bij ons
                    //Maak de nieuwe checkId de nieuwe bestelId
                    CheckId = Object[i].BestelId;

                    aantal = 1;
                    //Dit hoeft niet de eerste iteratie te gebeuren.
                    AantalArray.Add(aantal);

                }

                else if (CheckId == Object[i].BestelId)
                {
                    //Het is bekend;
                    aantal++;
                }
            }
            return AantalArray;
        }

        public bool BestellingGereed(Model.BarBestelling Object)
        {
            //DAO update/gereed.
            //Huidige status wordt meegegeven voor extra zekerheid binnen het systeem. 
            DAL.BestellingDAO BDAO = new DAL.BestellingDAO();

            try
            {
                BDAO.orderGereed(Object);
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
    }
}
