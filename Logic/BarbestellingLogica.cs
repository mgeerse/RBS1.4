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
        DAL.BestellingDAO BestellingDAO;
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


        public List<BarBestelling> GetAllOldOrders()
        {
            BestellingDAO = new DAL.BestellingDAO();
            List<BarBestelling> BarBestelling = new List<BarBestelling>();
            BarBestelling = BestellingDAO.GetAllOldBarBestellingen();

            return BarBestelling;
        }

        public List<BarBestelling> GetAllNewOrders()
        {
            BestellingDAO = new DAL.BestellingDAO();
            List<BarBestelling> BarBestelling = new List<BarBestelling>();
            BarBestelling = BestellingDAO.GetAllNewBarBestelling();

            return BarBestelling;
        }

        //public List<List<BarBestelling>> SorteerBarItemsAanBestelling(List<BarBestelling> Object)
        //{
        //    #region Poging 1
        //    //List<int> Frequentie = BestelIdItemFrequentie(Object);
        //    //List<List<BarBestelling>> TotaalBestellingen = new List<List<BarBestelling>>();

        //    ////Items omzetten naar een list, wat wordt gereturned. Wat ik return is een lijst met daarin lijsten van één bestelling. 
        //    ////De laatste staat gelijk aan één bestelling.

        //    //BarBestelling = new BarBestelling();

        //    //if (Frequentie == null)
        //    //{
        //    //    //throw new NotImplementedException();
        //    //}

        //    //for (int i = 0; i < Object.Count; i++)
        //    //{
        //    //    List<BarBestelling> Bestellingen = new List<BarBestelling>();

        //    //    foreach (int index in Frequentie)
        //    //    {
        //    //        //Pak het aantal items in een bestelling via de index.

        //    //        for (int j = 0; j < index; j++)
        //    //        {
        //    //            //Nu we de index hebben kunnen we zeggen hoeveel items er in een bestelling zitten.
        //    //            BarBestelling.BestelId = Object[i].BestelId;
        //    //            BarBestelling.Aantal = Object[i].Aantal;
        //    //            BarBestelling.Invoertijd = Object[i].Invoertijd;
        //    //            BarBestelling.ItemNaam = Object[i].ItemNaam;
        //    //            BarBestelling.MedewerkerNaam = Object[i].MedewerkerNaam;
        //    //            BarBestelling.Opmerking = Object[i].Opmerking;
        //    //            BarBestelling.TafelNummer = Object[i].TafelNummer;
        //    //            BarBestelling.Menuitem = Object[i].Menuitem;

        //    //            Bestellingen.Add(BarBestelling);
        //    //        }
        //    //    }
        //    //    TotaalBestellingen.Add(Bestellingen);
        //    //}
        //    #endregion

        //    List<List<BarBestelling>> BarBestelling = new List<List<Model.BarBestelling>>();
        //    List<BarBestelling> BarObject = new List<BarBestelling>();

        //    int CheckId = 0;
        //    foreach (var item in Object)
        //    {
        //        if (CheckId != item.BestelId)
        //        {
        //            BarObject = new List<BarBestelling>();

        //            CheckId = item.BestelId;
        //            BarObject.Add(item);
        //        }
        //        else if (CheckId == item.BestelId)
        //        {
        //            BarObject.Add(item);
        //        }
        //        BarBestelling.Add(BarObject);
        //    }
        //    return BarBestelling;
        //}

        //public int[] BestelIdItemFrequentie(List<BarBestelling> Object)
        //{
        //    return new int[10];
        //}


        public bool BestellingGereed(BarBestelling Object)
        {
            //DAO update/gereed.
            //Huidige status wordt meegegeven voor extra zekerheid binnen het systeem. 
            BestellingDAO = new DAL.BestellingDAO();

            try
            {
                BestellingDAO.orderGereed(Object);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
