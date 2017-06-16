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
        TafelDAO TafelDAO = new TafelDAO();
        RekeningDAO RekeningDAO = new RekeningDAO();
        BestellingDAO BestellingDAO = new BestellingDAO();

        #region wtf bram

        //public bool GetTafel(int nummer)
        //{
        //    TafelDAO tafel = new TafelDAO();

        //    try
        //    {
        //        tafel.Update(nummer);
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //public bool TafelAfgerekend(int nummer)
        //{
        //    TafelDAO tafel = new TafelDAO();
        //    int Nummer = 20;
        //    try
        //    {
        //        tafel.Update(Nummer);
        //    }
        //    catch (Exception e)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        #endregion

        public Tafel GetTafel(int Id)
        {
            return TafelDAO.GetForId(Id);
        }

        public bool TafelAfgerekend(int nummer)
        {
            //TODO Tafel echt afrekenen

            #region Opdrachtbeschrijving
            /// In deze methode moet iets van een bestelling opgehaald worden die hoort bij deze tafel. 
            /// Als de rekening is voldaan, dan wordt de tafel waarbij de bestelling hoort, vrijgegeven.
            #endregion

            return true;
        }
    }
}
