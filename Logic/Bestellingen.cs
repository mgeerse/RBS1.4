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
            // TODO
            return null;
        }

        public List<Bestelitem> GetNietGeredeBestelitems()
        {
            // TODO
            return null;
        }
    }
}
