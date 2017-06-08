using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class InitializeData
    {
        DAL.BestellingDAO BDAO;

        public InitializeData()
        {

        }

        public DAL.BestellingDAO GetData()
        {
            BDAO = new DAL.BestellingDAO();
            BDAO.GetBarBestellingen();

            return null; 
        }
    }
}
