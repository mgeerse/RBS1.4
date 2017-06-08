using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL.DAO
{
    class MenuitemDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Menuitem> GetAll()
        {
            return null;
        }

        public Menuitem GetForId(int Id)
        {
            return null;
        }

        public bool Create(Menuitem Object)
        {
            return false;
        }

        public bool Update(Menuitem Object)
        {
            return false;
        }

        public bool Delete(Menuitem Object)
        {
            return false;
        }

    }
}
