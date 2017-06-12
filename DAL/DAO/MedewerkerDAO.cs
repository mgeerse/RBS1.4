using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class MedewerkerDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Medewerker> GetAll()
        {
            List<Medewerker> result = new List<Medewerker>();
            conn.Open();
            string query = "SELECT *" +
                        "FROM dbo.Medewerker";

            SqlCommand command = new SqlCommand(query, conn);
            command.Prepare();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int MedewerkerId = reader.GetInt32(0);
                string Naam = reader.GetString(1);
                MedewerkerType Type = (MedewerkerType)reader.GetInt32(2);
                char[] Logincode = reader.GetString(2).ToCharArray();

                result.Add(new Medewerker(MedewerkerId, Naam, Type, Logincode));
            }
            return result;
        }

        public Medewerker GetForId(int Id)
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public bool Create(Medewerker Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Medewerker Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Medewerker Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
