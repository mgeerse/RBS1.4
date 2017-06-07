using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class MenuitemDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Menuitem> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Menuitem GetForId(int Id)
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public bool Create(Menuitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Menuitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Menuitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
