using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class BestellingOverzicht
    {
        BestelitemDAO bestelitemDAO = new BestelitemDAO();


        public List<Bestelitem> GetBestelitems()
        {
            return bestelitemDAO.GetAll();
        }


        public List<Bestelitem> GetGeredeBestelitems()
        {
            List<Bestelitem> bestelitems = GetBestelitems();
            List<Bestelitem> geredeBestelitems = new List<Bestelitem>();

            foreach (Bestelitem item in bestelitems)
            {
                if (item.Status == Status.Klaar)
                {
                    geredeBestelitems.Add(item);
                }
            }

            return geredeBestelitems;
        }


        public List<Bestelitem> GetGeredeBestelitems(int Tafelnummer)
        {
            List<Bestelitem> bestelitems = GetGeredeBestelitems();
            List<Bestelitem> bestelitemsVoorTafel = new List<Bestelitem>();

            foreach (Bestelitem item in bestelitems)
            {
                if (item.Bestelling.Tafel.Id == Tafelnummer)
                {
                    bestelitemsVoorTafel.Add(item);
                }
            }

            return bestelitemsVoorTafel;
        }


        public List<Bestelitem> GetNietGeredeBestelitems()
        {
            List<Bestelitem> bestelitems = GetBestelitems();
            List<Bestelitem> nietGeredeBestelItems = new List<Bestelitem>();

            foreach (Bestelitem item in bestelitems)
            {
                if (item.Status == Status.Bezig || item.Status == Status.Ingevoerd)
                {
                    nietGeredeBestelItems.Add(item);
                }
            }

            return nietGeredeBestelItems;

        }


        public List<Bestelitem> GetNietGeredeBestelitems(int Tafelnummer)
        {
            List<Bestelitem> bestelitems = GetNietGeredeBestelitems();
            List<Bestelitem> bestelitemsVoorTafel = new List<Bestelitem>();

            foreach (Bestelitem item in bestelitems)
            {
                if (item.Bestelling.Tafel.Id == Tafelnummer)
                {
                    bestelitemsVoorTafel.Add(item);
                }
            }

            return bestelitemsVoorTafel;
        }

        
        public void VoegItemsToe(List<Bestelitem> items)
        {
            foreach (Bestelitem item in items)
            {
                bestelitemDAO.Create(item);
            }
        }


        public void MeldBediend(Bestelitem Bestelitem)
        {
            Bestelitem.Status = Status.Klaar;
            bestelitemDAO.Update(Bestelitem);
        }

        public void Verwijder(Bestelitem Bestelitem)
        {
            bestelitemDAO.Delete(Bestelitem);
        }
    }
}
