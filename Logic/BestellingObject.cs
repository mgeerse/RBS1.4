using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BestellingObject
    {
        public BestellingObject() { }
        //Onderstaande opzich niet nodig.
        public int GetAantalOrders()
        {
            DAL.BestellingDAO BestellingDAO = new DAL.BestellingDAO();
            List<Model.BarBestelling> BarBestelling = new List<Model.BarBestelling>();
            BarBestelling = BestellingDAO.GetBarBestellingen();

            int aantal = 0;
            int[] Ids = null;

            foreach (var item in BarBestelling)
            {
                if (!Ids.Contains(item.BestelId))
                {
                    aantal++;
                }
            }

            return aantal;
        }

        public int[] GetIdFrequentie()
        {
            DAL.BestellingDAO BestellingDAO = new DAL.BestellingDAO();
            List<Model.BarBestelling> BarBestelling = new List<Model.BarBestelling>();
            BarBestelling = BestellingDAO.GetBarBestellingen();

            int[] frequentie = null;

            for (int i = 0; i < BarBestelling.Count; i++)
            {
                frequentie[BarBestelling[i].BestelId]++;
            }

            return frequentie;
        }

        public List<Model.BarBestelling> GetOrders()
        {
            DAL.BestellingDAO BestellingDAO = new DAL.BestellingDAO();
            List<Model.BarBestelling> BarBestelling = new List<Model.BarBestelling>();
            BarBestelling = BestellingDAO.GetBarBestellingen();
            return BestellingDAO.GetBarBestellingen();
        }
    }
}
