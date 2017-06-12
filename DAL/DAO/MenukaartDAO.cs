using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class MenukaartDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Menukaart> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Menukaart GetForId(int Id)
        {
            conn.Open();
            string query = "SELECT MenukaartId, Naam" +
                " FROM Menukaart" +
                " WHERE MenukaartId = " + Id;

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string Naam = reader.GetString(1);
                return new Menukaart(Naam, Id);
            }
            conn.Close();
            return null;
        }

        public bool Create(Menukaart Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Menukaart Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Menukaart Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
