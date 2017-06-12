using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class LoginHandler
    {
        MedewerkerDAO medewerkerDAO = new MedewerkerDAO();

        public Medewerker GetForLoginCode(char[] code)
        {
            return medewerkerDAO.GetForLoginCode(code);
        }
    }
}
