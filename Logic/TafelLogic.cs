using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class TafelLogic
    {
        private TafelDAO TafelDAO = new TafelDAO();

        public Tafel GetTafel(int Tafelnummer)
        {
            return TafelDAO.GetForId(Tafelnummer);
        }
    }
}
