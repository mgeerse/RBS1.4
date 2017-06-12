using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class GetMenuitem
    {
        public List<Menuitem> GetAll()
        {
            return new MenuitemDAO().GetAll();
        }

        public Menuitem GetForId(int id)
        {
            return new MenuitemDAO().GetForId(id);
        }
    }
}
