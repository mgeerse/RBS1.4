using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Logic
{
    public class BestellingLogica
    {
        DAL.BestelitemDAO BestelitemDAO;
        public BestellingLogica() { }

        public List<Bestelitem> GetBarOrdersForStatus(int Status)
        {
            BestelitemDAO = new DAL.BestelitemDAO();
            List<Bestelitem> BestelItems = new List<Bestelitem>();
            BestelItems = BestelitemDAO.GetBarBestellingenForStatus(Status);

            return BestelItems;
        }

        public List<Bestelitem> GetKokOrdersForStatus(int Status)
        {
            BestelitemDAO = new DAL.BestelitemDAO();
            List<Bestelitem> BestelItems = new List<Bestelitem>();
            BestelItems = BestelitemDAO.GetKokBestellingenForStatus(Status);

            return BestelItems;
        }

        public bool BestellingGereed(List<Bestelitem> Object, int Id)
        {
            //DAO update/gereed.
            //Huidige status wordt meegegeven voor extra zekerheid binnen het systeem. 
            BestelitemDAO = new DAL.BestelitemDAO();

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
