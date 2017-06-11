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

        private MedewerkerDAO MedewerkerDAO = new MedewerkerDAO();
        private TafelDAO TafelDAO = new TafelDAO();
        private RekeningDAO RekeningDAO = new RekeningDAO();

        public List<Bestelling> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Bestelling GetForId(int Id)
        {
            Bestelling result = null;

            conn.Open();
            string query = "SELECT BestellingId, Opmerking, Medewerker, Tafel, Rekening" +
                " FROM Bestelling" +
                " WHERE BestellingId = " + Id;
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                result = new Bestelling(Id, reader.GetString(1), MedewerkerDAO.GetForId(reader.GetInt32(2)), TafelDAO.GetForId(reader.GetInt32(3)), RekeningDAO.GetForId(reader.GetInt32(4)));
            }
            conn.Close();
            return result;
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
