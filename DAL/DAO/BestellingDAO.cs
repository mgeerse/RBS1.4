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
        private SqlConnection conn;
        private List<Bestelling> BestelList;
        private Bestelling Bestelling;
        private Medewerker Medewerker;
        private Tafel Tafel;
        private Rekening Rekening;

        public List<Bestelling> GetAll()
        {
            
            return null;
        }

        public List<BarBestelling> GetBarBestellingen()
        {
            conn = DbConnection.GetSqlConnection();
            BarBestelling BarBestelling = new BarBestelling();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT [MenuItem].[Naam], [Aantal], [Opmerking], [TijdIngevoerd], [Medewerker.Naam]");
            sb.Append("FROM MenuItem as M");
            sb.Append("JOIN BestelItem as B ON M.MenuItemId = B.MenuItem");
            sb.Append("JOIN Bestelling as C ON B.Bestelling = C.Bestelling");
            sb.Append("JOIN Medewerker as D ON C.Medewerker = D.MedewerkerId");
            sb.Append("WHERE M.Categorie BETWEEN 8 AND 12");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                BarBestelling.ItemNaam = reader.GetString(0);
                BarBestelling.Aantal = reader.GetInt32(1);
                BarBestelling.Opmerking = reader.GetString(2);
                BarBestelling.Invoertijd = reader.GetDateTime(3);
                BarBestelling.MedewerkerNaam = reader.GetString(4);

                BarBestelList.Add(BarBestelling);
            }

            return BarBestelList;
        }

        public Bestelling GetForId(int Id)
        {

            TafelDAO TafelDAO = new TafelDAO();
            MedewerkerDAO MedewerkerDAO = new MedewerkerDAO();
            RekeningDAO RekeningDAO = new RekeningDAO();

            conn = DbConnection.GetSqlConnection();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT [Opmerking], [Medewerker], [Tafelnummer], [Rekening] FROM [dbo].[Bestelling] WHERE BestellingsId = @BestelId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.Parameters.Add("@BestelId", System.Data.SqlDbType.Int).Value = Id;
            cmd.Prepare();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Bestelling.Opmerking = reader.GetString(0);
                //Bestelling.Medewerker = MedewerkerDAO.GetForId(reader.GetInt32(2));
                Bestelling.Medewerker = null;
                Bestelling.Tafel = TafelDAO.GetForId(reader.GetInt32(3));
                //Bestelling.Rekening = RekeningDAO.GetForId(reader.GetInt32(4));
                Bestelling.Rekening = null;


                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                return Bestelling;
            }

            return null;
        }

        public bool Create(Bestelling Object)
        {
            return false;
        }

        public bool Update(Bestelling Object)
        {
            return false;
        }

        public bool Delete(Bestelling Object)
        {
            return false;
        }

    }
}
