using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class TafelLogic
    {
        TafelDAO tafel = new TafelDAO();

        public bool GetTafel(Tafel Object)
        {
            TafelDAO tafel = new TafelDAO();

            try
            {
                tafel.Update(Object);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
