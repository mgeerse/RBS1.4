using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class GetBestelling
    {
        public List<Bestelling> GetAll()
        {
            return new BestellingDAO().GetAll();
        }

        public Bestelling GetForId(int id)
        {
            return new BestellingDAO().GetForId(id);
        }
    }
}
