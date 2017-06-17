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

        public Tafel GetTafel(int Id)
        {
            return TafelDAO.GetForId(Id);
        }

        public List<Tafel> BeginKleur()
        {
            List<Tafel> Tafel = new List<Tafel>();
            Tafel = TafelDAO.GetAll();
            return Tafel;
        }

        public bool TafelBezet(int nummer)
        {
            try
            {
                TafelDAO.UpdateOmhoog(nummer);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool TafelVrijgeven(int nummer)
        {
            try
            {
                TafelDAO.UpdateOmLaag(nummer);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
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
