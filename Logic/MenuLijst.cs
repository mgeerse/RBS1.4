using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class MenuLijst
    {
        MenuitemDAO MenuitemDAO = new MenuitemDAO();

        public List<Menuitem> GetMenukaart(int menukaart)
        {
            return MenuitemDAO.GetForMenukaart(menukaart);
        }
    }
}
