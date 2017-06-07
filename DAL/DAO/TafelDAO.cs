using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class TafelDAO
    {
        private SqlConnection conn;

        public List<Tafel> GetAll()
        {
            conn = DbConnection.GetSqlConnection();
            List<Tafel> TafelLijst = new List<Tafel>();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM [dbo].[Tafel]");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Tafel Tafel = new Tafel(reader.GetInt32(0), reader.GetBoolean(2));

                TafelLijst.Add(Tafel);
            }

            return TafelLijst;
        }

        public Tafel GetForId(int Id)
        {
            //Maarten Geerse
            conn = DbConnection.GetSqlConnection();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT [IsBezet] FROM [dbo].[Tafel] WHERE TafelId = @Id");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;
            cmd.Prepare();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Tafel Tafel = new Tafel(Id, reader.GetBoolean(0));

                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                return Tafel;
            }
            return null;
        }

        public bool Create(Tafel Object)
        {
            return false;
        }

        public bool Update(Tafel Object)
        {
            return false;
        }

        public bool Delete(Tafel Object)
        {
            return false;
        }

    }
}
