using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class BestellingLogica
    {
        BestelitemDAO BestelitemDAO = new BestelitemDAO();

        public List<Bestelitem> GetBarOrdersForStatus(int Status)
        {
            List<Bestelitem> BestelItems = new List<Bestelitem>();
            BestelItems = BestelitemDAO.GetBarBestellingenForStatus(Status);

            return BestelItems;
        }

        public List<Bestelitem> GetKokOrdersForStatus(int Status)
        {
            List<Bestelitem> BestelItems = new List<Bestelitem>();
            BestelItems = BestelitemDAO.GetKokBestellingenForStatus(Status);

            return BestelItems;
        }

        public bool BestellingGereed(List<Bestelitem> Object, int Id)
        {
            try
            {
                foreach (var item in Object)
                {
                    if (item.Bestelling.Id == Id)
                    {
                        BestelitemDAO.orderGereed(item);
                    }
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
