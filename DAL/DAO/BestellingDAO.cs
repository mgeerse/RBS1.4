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
        //private SqlConnection conn = DbConnection.GetSqlConnection();
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
            conn = DbConnection.GetSqlConnection();
            conn.Open();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT [Opmerking], [Medewerker], [Tafel], [Rekening] FROM [dbo].[Bestelling] WHERE BestellingId = @BestelId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.Parameters.Add("@BestelId", System.Data.SqlDbType.Int).Value = Id;
            cmd.Prepare();

            SqlDataReader reader = cmd.ExecuteReader();
            Bestelling Bestelling = null;
            while (reader.Read())
            {
                string opmerking = "";
                if (reader.IsDBNull(0))
                {
                    opmerking = "";
                }
                else
                {
                    opmerking = reader.GetString(0);
                }

                Medewerker Medewerker = MedewerkerDAO.GetForId(reader.GetInt32(1));
                Tafel Tafel = TafelDAO.GetForId(reader.GetInt32(2));
                Rekening Rekening = RekeningDAO.GetForId(reader.GetInt32(3));
                Bestelling = new Bestelling(Id, opmerking, Medewerker, Tafel, Rekening);
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return Bestelling;
        }

        public bool Create(Bestelling Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Bestelling Object)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE [dbo].[Bestelling] ");
            sb.Append("SET [Opmerking] = @Opmerking, [Medewerker] = @Medewerker, [Tafel] = @TafelNummer, [Rekening] = @Rekening ");
            sb.Append("WHERE [BestellingId] = @BestellingId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            cmd.Parameters.Add("@BestellingId", System.Data.SqlDbType.Int).Value = Object.Id;
            cmd.Parameters.Add("@Opmerking", System.Data.SqlDbType.NVarChar, 2048).Value = Object.Opmerking;
            cmd.Parameters.Add("@Medewerker", System.Data.SqlDbType.Int).Value = Object.Medewerker.Id;
            cmd.Parameters.Add("@TafelNummer", System.Data.SqlDbType.Int).Value = Object.Tafel.Id;
            cmd.Parameters.Add("@Rekening", System.Data.SqlDbType.Int).Value = Object.Rekening.Id;

            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(Bestelling Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public Bestelling GetLaatsteForTafel(int tafelnummer)
        {
            conn.Open();
            Bestelling result = null;
            string query = "SELECT BestellingId, Opmerking, Medewerker, Tafel, Rekening" +
                " FROM Bestelling" +
                " WHERE Tafel = " + tafelnummer +
                " ORDER BY BestellingId DESC";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int BestellingId = reader.GetInt32(0);
                string Opmerking = reader.IsDBNull(1) ? "" : reader.GetString(1);
                int Medewerker = reader.GetInt32(2);
                int Tafel = reader.GetInt32(3);
                int Rekening = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                result = new Bestelling(BestellingId, Opmerking, MedewerkerDAO.GetForId(Medewerker), TafelDAO.GetForId(Tafel), RekeningDAO.GetForId(Rekening));
            }

            conn.Close();
            return result;

        }

    }
}
