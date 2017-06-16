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
        private SqlConnection conn = DbConnection.GetSqlConnection();

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
            conn = DbConnection.GetSqlConnection();
            conn.Open();

            string query = "SELECT TafelId, IsBezet" +
                " FROM Tafel";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                //Id is bekend
                bool IsBezet = reader.GetBoolean(1);
                return new Tafel(Id, IsBezet);
            }
            conn.Close();
            return null;
        }

        public bool Create(Tafel Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(int nummer)
        {
            conn.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE dbo.Tafel ");
            sb.Append("SET IsBezet = @IsBezet");
            sb.Append("WHERE TafelId = @TafelId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            cmd.Parameters.Add("@BIsBezet", System.Data.SqlDbType.Bit).Value = 1;
            
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

        public bool Delete(Tafel Object)
        {
            conn.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE");
            sb.Append("FROM dbo.Tafel");
            sb.Append("WHERE TafelId = @TafelId");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            cmd.Parameters.Add("@BIsBezet", System.Data.SqlDbType.Bit).Value = 1;

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

    }
}
