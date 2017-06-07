using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BestelitemDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Bestelitem> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Bestelitem GetForId(int Id)
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public bool Create(Bestelitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Bestelitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Bestelitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
