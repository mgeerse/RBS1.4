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
            conn.Open();

            conn.Close();
            return null;
        }

        public Medewerker GetForId(int Id)
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Medewerker GetForLoginCode(char[] code)
        {
            if (code.Length != 4)
            {
                return null;
            }
            else
            {

                conn.Open();
                string query = "SELECT MedewerkerId, Naam, TypeMedewerker, Logincode" +
                               " FROM Medewerker" +
                               " WHERE Logincode = " + new string(code);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }

                int id = reader.GetInt32(0);
                string naam = reader.GetString(1);
                MedewerkerType type = (MedewerkerType)reader.GetInt32(2);
                char[] logincode = reader.GetString(3).ToCharArray();

                conn.Close();
                return new Medewerker(id, naam, type, logincode);
            }
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
