using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
public class tafelLogica
    {
        TafelDAO tafel = new TafelDAO();

        public bool GetTafel(int nummer)
        {
            TafelDAO tafel = new TafelDAO();

            try
            {
                tafel.Update(nummer);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }
}
