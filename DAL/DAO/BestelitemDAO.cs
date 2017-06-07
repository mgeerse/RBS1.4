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
        private SqlConnection conn;
        private Bestelitem Bestelitem;
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
                Bestelitem.Aantal = reader.GetInt32(0);
                Bestelitem.Opmerking = reader.GetString(1);
                Bestelitem.Status = (Status)reader.GetInt32(2);
                Bestelitem.Tijdingevoerd = reader.GetDateTime(3);

                BestelItemLijst.Add(Bestelitem);
            }

            return BestelItemLijst;
        }

        public Bestelitem GetForId(int Id)
        {
            conn = DbConnection.GetSqlConnection();


            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT[Aantal], [Opmerking], [Status], [TijdIngevoerd] FROM[dbo].[Bestelitem] WHERE BestellingId = @Id");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;
            cmd.Prepare();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
            }
            
            return null;
        }

        public List<Bestelitem> GetBarBestelling()
        {



            return null;
        }

        public bool Create(Bestelitem Object)
        {
            return false;
        }

        public bool Update(Bestelitem Object)
        {
            return false;
        }

        public bool Delete(Bestelitem Object)
        {
            return false;
        }

    }
}
