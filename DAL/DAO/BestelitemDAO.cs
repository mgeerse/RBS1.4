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
        private Menuitem mi;
        private BestellingDAO BestellingDAO;
        private MenuitemDAO MenuitemDAO;
        private SqlConnection conn;

        public List<Bestelitem> GetAll()
        {
            conn = DbConnection.GetSqlConnection();
            List<Bestelitem> BestelItemLijst = new List<Bestelitem>();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM [dbo].[Bestelitem]");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Bestelitem Bestelitem = new Bestelitem(BestellingDAO.GetForId(reader.GetInt32(0)),
                    MenuitemDAO.GetForId(reader.GetInt32(1)), reader.GetInt32(2), (Status)reader.GetInt32(4), reader.GetString(3),
                    reader.GetDateTime(5));

                BestelItemLijst.Add(Bestelitem);
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return BestelItemLijst;
        }

        public Bestelitem GetForId(int Id)
        {


            conn = DbConnection.GetSqlConnection();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT [Menuitem], [Aantal], [Opmerking], [Status], [TijdIngevoerd] FROM [dbo].[Bestelitem] WHERE BestellingId = @Id");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;
            cmd.Prepare();
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Bestelitem Bestelitem = new Bestelitem(BestellingDAO.GetForId(Id), 
                    MenuitemDAO.GetForId(reader.GetInt32(0)), 
                    reader.GetInt32(1), (Status)reader.GetInt32(2), reader.GetString(3), 
                    reader.GetDateTime(4));

                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                return Bestelitem;
            }
            return null;
        }

        public bool Create(Bestelitem Object)
        {
            return false;
        }

        public bool Update(Bestelitem Object)
        {
            //Dit zet de status van een item.
            //De status wordt meegegeven in het object.

            //Dit deel is incompleet en dus incorrect. 
            conn = DbConnection.GetSqlConnection();

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE [dbo].[Bestelitem] ");
            sb.Append("SET [Status] = @Status ");
            sb.Append("WHERE [BestellingId] = @BestellingId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            cmd.Parameters.Add("@BestellingId", System.Data.SqlDbType.Int).Value = Object.Bestelling.Id;
            cmd.Parameters.Add("@Status", System.Data.SqlDbType.NVarChar).Value = Object.Status;
            
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

        public bool Delete(Bestelitem Object)
        {
            return false;
        }

    }
}
