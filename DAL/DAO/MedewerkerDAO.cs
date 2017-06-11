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
        private SqlConnection conn;
        Medewerker Medewerker;

        public List<Medewerker> GetAll()
        {
            return null;
        }

        public Medewerker GetForId(int Id)
        {
            conn = DbConnection.GetSqlConnection();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT [Naam], [TypeMedewerker] FROM [dbo].[Medewerker] WHERE MedewerkerId = @Id");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.Parameters.Add("@MedewerkerId", System.Data.SqlDbType.Int).Value = Id;
            cmd.Prepare();
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Medewerker.Naam = reader.GetString(0);
                Medewerker.Type = (MedewerkerType)reader.GetInt32(1);
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            
            return Medewerker;
        }

        public bool Create(Medewerker Object)
        {
            return false;
        }

        public bool Update(Medewerker Object)
        {
            return false;
        }

        public bool Delete(Medewerker Object)
        {
            return false;
        }

    }
}
