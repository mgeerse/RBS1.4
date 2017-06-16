using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    class tafelLogica  
    {
        TafelDAO TafelDAO = new TafelDAO();

        public Tafel GetForTafelId(int Id,bool Isbezet)
        {
            return TafelDAO.GetForId(Id, Isbezet);
        }
    }
}
