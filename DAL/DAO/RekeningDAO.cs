using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class RekeningDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Rekening> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Rekening GetForId(int Id)
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public bool Create(Rekening Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Rekening Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Rekening Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
