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
        RekeningDAO Rekening;
        TafelDAO Tafel;
        MedewerkerDAO Medewerker;

        public List<Bestelling> GetAll()
        {
            return null;
        }

        public Bestelling GetForId(int Id)
        {
            conn = DbConnection.GetSqlConnection();
            conn.Open();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT [Opmerking], [Medewerker], [Tafelnummer], [Rekening] FROM [dbo].[Bestelling] WHERE BestellingsId = @BestelId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.Parameters.Add("@BestelId", System.Data.SqlDbType.Int).Value = Id;
            cmd.Prepare();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Bestelling Bestelling = new Bestelling(
                    Id, Rekening.GetForId(reader.GetInt32(4)),
                    reader.GetString(1), Medewerker.GetForId(reader.GetInt32(2)),
                    Tafel.GetForId(reader.GetInt32(3))
                    );

                return Bestelling;
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return null;
        }

        public List<BarBestelling> GetAllNewBarBestelling()
        {
            List<BarBestelling> BarBestelList = new List<BarBestelling>();

            conn = DbConnection.GetSqlConnection();
            BarBestelling BarBestelling = new BarBestelling();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT M.Naam, B.Aantal, B.Opmerking, B.TijdIngevoerd, D.Naam, C.BestellingId, T.TafelId, B.Menuitem ");
            sb.Append("FROM MenuItem as M ");
            sb.Append("JOIN BestelItem as B ON M.MenuItemId = B.MenuItem ");
            sb.Append("JOIN Bestelling as C ON B.Bestelling = C.BestellingId ");
            sb.Append("JOIN Medewerker as D ON C.Medewerker = D.MedewerkerId ");
            sb.Append("JOIN Tafel as T ON C.Tafel = T.TafelId ");
            sb.Append("WHERE (M.Categorie BETWEEN 8 AND 12) AND B.Status = 1 ");

            conn.Open();

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BarBestelling.ItemNaam = reader.GetString(0);
                BarBestelling.Aantal = reader.GetInt32(1);
                BarBestelling.Opmerking = reader.GetString(2);
                BarBestelling.Invoertijd = reader.GetDateTime(3);
                BarBestelling.MedewerkerNaam = reader.GetString(4);
                BarBestelling.BestelId = reader.GetInt32(5);
                BarBestelling.TafelNummer = reader.GetInt32(6);
                BarBestelling.Menuitem = reader.GetInt32(7);

                BarBestelList.Add(BarBestelling);
            }
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            return BarBestelList;
        }

        public List<BarBestelling> GetAllBarBestellingen()
        {
            List<BarBestelling> BarBestelList = new List<BarBestelling>();

            conn = DbConnection.GetSqlConnection();
            BarBestelling BarBestelling = new BarBestelling();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT M.Naam, B.Aantal, B.Opmerking, B.TijdIngevoerd, D.Naam, C.BestellingId, C.Tafel, B.Menuitem ");
            sb.Append("FROM MenuItem as M ");
            sb.Append("JOIN BestelItem as B ON M.MenuItemId = B.MenuItem ");
            sb.Append("JOIN Bestelling as C ON B.Bestelling = C.BestellingId ");
            sb.Append("JOIN Medewerker as D ON C.Medewerker = D.MedewerkerId ");
            sb.Append("JOIN Tafel as T ON C.Tafel = T.TafelId ");
            sb.Append("WHERE (M.Categorie BETWEEN 8 AND 12) ");

            conn.Open();

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BarBestelling.ItemNaam = reader.GetString(0);
                BarBestelling.Aantal = reader.GetInt32(1);
                BarBestelling.Opmerking = reader.GetString(2);
                BarBestelling.Invoertijd = reader.GetDateTime(3);
                BarBestelling.MedewerkerNaam = reader.GetString(4);
                BarBestelling.BestelId = reader.GetInt32(5);
                BarBestelling.TafelNummer = reader.GetInt32(6);
                BarBestelling.Menuitem = reader.GetInt32(7);

                BarBestelList.Add(BarBestelling);
            }
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            return BarBestelList;
        }

        public List<BarBestelling> GetAllOldBarBestellingen()
        {
            List<BarBestelling> BarBestelList = new List<BarBestelling>();

            conn = DbConnection.GetSqlConnection();
            BarBestelling BarBestelling = new BarBestelling();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT M.Naam, B.Aantal, B.Opmerking, B.TijdIngevoerd, D.Naam, C.BestellingId, T.TafelId, B.Menuitem ");
            sb.Append("FROM MenuItem as M ");
            sb.Append("JOIN BestelItem as B ON M.MenuItemId = B.MenuItem ");
            sb.Append("JOIN Bestelling as C ON B.Bestelling = C.BestellingId ");
            sb.Append("JOIN Medewerker as D ON C.Medewerker = D.MedewerkerId ");
            sb.Append("JOIN Tafel as T ON C.Tafel = T.TafelId ");
            sb.Append("WHERE (M.Categorie BETWEEN 8 AND 12) AND B.Status = 3 ");

            conn.Open();

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BarBestelling.ItemNaam = reader.GetString(0);
                BarBestelling.Aantal = reader.GetInt32(1);
                BarBestelling.Opmerking = reader.GetString(2);
                BarBestelling.Invoertijd = reader.GetDateTime(3);
                BarBestelling.MedewerkerNaam = reader.GetString(4);
                BarBestelling.BestelId = reader.GetInt32(5);
                BarBestelling.TafelNummer = reader.GetInt32(6);
                BarBestelling.Menuitem = reader.GetInt32(7);

                BarBestelList.Add(BarBestelling);
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            return BarBestelList;
        }

        public bool Create(Bestelling Object)
        {
            return false;
        }

        public bool Update(Bestelling Object)
        {
            conn = DbConnection.GetSqlConnection();

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE [dbo].[Bestelling] ");
            sb.Append("SET [Opmerking] = @Opmerking, [Medewerker] = @Medewerker, [Tafelnummer] = @TafelNummer, [Rekening] = @Rekening ");
            sb.Append("WHERE [BestellingId] = @BestellingId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            cmd.Parameters.Add("@BestellingId", System.Data.SqlDbType.Int).Value = Object.Id;
            cmd.Parameters.Add("@Opmerking", System.Data.SqlDbType.NVarChar).Value = Object.Opmerking;
            cmd.Parameters.Add("@Medewerker", System.Data.SqlDbType.Int).Value = Object.Medewerker.Id;
            cmd.Parameters.Add("@TafelNummer", System.Data.SqlDbType.Int).Value = Object.Tafel.Id;
            cmd.Parameters.Add("@Rekening", System.Data.SqlDbType.Int).Value = Object.Rekening.Id;

            try
            {
                cmd.Prepare();
                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool orderGereed(BarBestelling Object)
        {
            conn = DbConnection.GetSqlConnection();

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE [dbo].[BestelItem] ");
            sb.Append("SET [Status] = @Status ");
            sb.Append("WHERE [Bestelling] = @BestellingId AND [Menuitem] = @MenuId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            cmd.Parameters.Add("@BestelId", System.Data.SqlDbType.Int).Value = Object.BestelId;
            cmd.Parameters.Add("@MenuId", System.Data.SqlDbType.Int).Value = Object.Menuitem;
            cmd.Parameters.Add("@Status", System.Data.SqlDbType.Int).Value = 2;
            try
            {
                cmd.Prepare();
                conn.Open();

                cmd.ExecuteScalar();

                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Delete(Bestelling Object)
        {
            return false;
        }

    }
}
