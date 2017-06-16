using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class BerekenRekening
    {
        RekeningDAO RekeningDAO = new RekeningDAO();
        BestelitemDAO BestelitemDAO = new BestelitemDAO();


        public Rekening Berekenen(Bestelling Bestelling)
        {
            List<Bestelitem> BestelItems = BestelitemDAO.GetForBestellingId(Bestelling.Id);

            decimal totaalprijs = 0;
            decimal BtwBetaald = 0;

            foreach (Bestelitem item in BestelItems)
            {
                totaalprijs += item.Aantal * item.Menuitem.Prijs;
                BtwBetaald += item.Aantal * item.Menuitem.Prijs * (item.Menuitem.Categorie.BtwPercentage / 100);
            }

            decimal TotaalExclusief = 0;

            TotaalExclusief = totaalprijs - BtwBetaald;
            Rekening Result = new Rekening(0, DateTime.Now, TotaalExclusief, BtwBetaald);

            Bestelling.Rekening = Result;
            RekeningDAO.Create(ref Result);

            return Result;
        }

        public List<Bestelitem> GetForBestelling(int BestellingId)
        {
            return BestelitemDAO.GetForBestellingId(BestellingId);
        }
    }
}
