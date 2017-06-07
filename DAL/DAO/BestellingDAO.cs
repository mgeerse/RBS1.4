using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BestellingDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Bestelling> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Bestelling GetForId(int Id)
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public bool Create(Bestelling Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Bestelling Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Bestelling Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
