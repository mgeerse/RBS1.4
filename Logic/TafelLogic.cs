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
        TafelDAO tafel = new TafelDAO();

        public bool BezetTafel(int nummer)
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

        public bool TafelAfgerekend(int nummer)
        {
            TafelDAO tafel = new TafelDAO();
            int Nummer = 20;
            try
            {
                tafel.Update(Nummer);
            }
            catch (Exception e)
            {
                return true;
            }
            return false;
        }
    }
}
