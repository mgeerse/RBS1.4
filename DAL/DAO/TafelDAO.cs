using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class TafelDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Tafel> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Tafel GetForId(int Id)
        {
            conn.Open();
            string query = "SELECT TafelId, IsBezet" +
                " FROM Tafel";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                //Id is bekend
                bool IsBezet = reader.GetBoolean(1);
                return new Tafel(Id, IsBezet);
            }
            conn.Close();
            return null;
        }

        public bool Create(Tafel Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Tafel Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Tafel Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
