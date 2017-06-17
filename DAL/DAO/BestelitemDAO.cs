using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BestelitemDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();
        private BestellingDAO BestellingDAO = new BestellingDAO();
        private MenuitemDAO MenuitemDAO = new MenuitemDAO();

        public List<Bestelitem> GetAll()
        {
            List<Bestelitem> result = new List<Bestelitem>();

            conn.Open();

            string query = "SELECT Bestelling, Menuitem, Aantal, Opmerking, Status, TijdIngevoerd" +
                " FROM Bestelitem";

            SqlCommand command = new SqlCommand(query, conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Bestelling Bestelling = BestellingDAO.GetForId(reader.GetInt32(0));
                Menuitem Menuitem = MenuitemDAO.GetForId(reader.GetInt32(1));
                int Aantal = reader.GetInt32(2);
                string Opmerking = reader.IsDBNull(3) ? "" : reader.GetString(3);
                Status Status = (Status) reader.GetInt32(4);
                DateTime TijdIngevoerd = reader.GetDateTime(5);

                result.Add(new Bestelitem(Bestelling, Menuitem, Aantal, Opmerking, Status, TijdIngevoerd));
            }

            conn.Close();
            return result;
        }

        public List<Bestelitem> GetForId(int Id)
        {
            List<Bestelitem> result = new List<Bestelitem>();

            conn = DbConnection.GetSqlConnection();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT [Menuitem], [Aantal], [Opmerking], [Status], [TijdIngevoerd] FROM [dbo].[Bestelitem] WHERE BestellingId = @Id");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;
            cmd.Prepare();
            conn.Open();
            string query = "SELECT Bestelling, Menuitem, Aantal, Opmerking, Status, TijdIngevoerd" +
                " FROM Bestelitem" +
                " WHERE Bestelling = " + Id;
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Bestelitem Bestelitem = new Bestelitem(
                    BestellingDAO.GetForId(Id),
                    MenuitemDAO.GetForId(reader.GetInt32(0)),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    (Status)reader.GetInt32(3),
                    reader.GetDateTime(4)
                    );

                result.Add(Bestelitem);
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            
            return result;
        }

        public List<Bestelitem> GetBarBestellingenForStatus(int status)
        {
            List<Bestelitem> result = new List<Bestelitem>();

            conn.Open();

            string query = "SELECT Bestelling, Menuitem, Aantal, Opmerking, Status, TijdIngevoerd" +
                " FROM Bestelitem" +
                " JOIN MenuItem AS M on Bestelitem.Menuitem = M.MenuitemId" +
                " WHERE (M.Categorie BETWEEN 8 AND 12) AND Status = @Status" +
                " ORDER BY Bestelling";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@Status", System.Data.SqlDbType.Int).Value = status;
            command.Prepare();

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                //Bestelling gaat bij de tweede keer fout?
                Bestelling Bestelling = BestellingDAO.GetForId(reader.GetInt32(0));
                Menuitem Menuitem = MenuitemDAO.GetForId(reader.GetInt32(1));
                int Aantal = reader.GetInt32(2);

                string Opmerking;
                if (reader.IsDBNull(3))
                {
                     Opmerking = "";
                }
                else
                {
                    Opmerking = reader.GetString(3);
                }
                Status Status = (Status)reader.GetInt32(4);
                DateTime TijdIngevoerd = reader.GetDateTime(5);

                result.Add(new Bestelitem(Bestelling, Menuitem, Aantal, Opmerking, Status, TijdIngevoerd));
            }

            conn.Close();
            return result;

        }

        public bool orderGereed(Bestelitem Object)
        {
            conn = DbConnection.GetSqlConnection();

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE [dbo].[BestelItem] ");
            sb.Append("SET [Status] = @Status ");
            sb.Append("WHERE [Bestelling] = @BestellingId AND [Menuitem] = @MenuId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            cmd.Parameters.Add("@BestellingId", System.Data.SqlDbType.Int).Value = Object.Bestelling.Id;
            cmd.Parameters.Add("@MenuId", System.Data.SqlDbType.Int).Value = Object.Menuitem.Id;
            cmd.Parameters.Add("@Status", System.Data.SqlDbType.Int).Value = Status.Klaar;

            try
            {
                conn.Open();
                cmd.Prepare();

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

        public List<Bestelitem> GetForBestellingId(int BestellingId)
        {
            List<Bestelitem> result = new List<Bestelitem>();

            conn.Open();
            string query = "SELECT Bestelling, Menuitem, Aantal, Opmerking, Status, TijdIngevoerd" +
                " FROM Bestelitem" +
                " WHERE Bestelling = " + BestellingId;
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int Menuitem = reader.GetInt32(1);
                int Aantal = reader.GetInt32(2);
                string Opmerking = reader.IsDBNull(3) ? "" : reader.GetString(3);
                Status Status = (Status)reader.GetInt32(4);
                DateTime TijdIngevoerd = reader.GetDateTime(5);
                Bestelitem Bestelitem = new Bestelitem(BestellingDAO.GetForId(BestellingId), MenuitemDAO.GetForId(Menuitem), Aantal, Opmerking, Status, TijdIngevoerd);

                result.Add(Bestelitem);
            }
            conn.Close();
            return result;
        }

        public bool Create(Bestelitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Bestelitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Bestelitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
