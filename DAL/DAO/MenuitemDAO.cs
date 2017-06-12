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
        private SqlConnection conn;

        public List<Menuitem> GetAll()
        {
            conn.Open();

            string SQL = "SELECT *" +
                         "FROM dbo.Menuitem";

            SqlCommand command = new SqlCommand(SQL, conn);
            command.Prepare();
            SqlDataReader Reader = command.ExecuteReader();
            return null;
        }

        public Menuitem GetForId(int Id)
        {
            conn.Open();
            return null;
        }

        public bool Create(Menuitem Object)
        {
            conn.Open();
            return false;
        }

        public bool Update(Menuitem Object)
        {
            conn.Open();
            return false;
        }

        public bool Delete(Menuitem Object)
        {
            conn.Open();
            return false;
        }

    }
}
