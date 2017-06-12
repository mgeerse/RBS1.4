using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL.DAO
{
    class TafelDAO
    {
        private SqlConnection conn;

        public List<Tafel> GetAll()
        {
            return null;
        }

        public Tafel GetForId(int Id)
        {
            conn = DbConnection.GetSqlConnection();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT isbezet FROM dbo.Tafel WHERE TafelId = @id");

            SqlCommand command = new SqlCommand(sb.ToString(), conn);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);

            SqlDataReader Reader = (SqlDataReader)command.ExecuteScalar();
            Id = Reader.GetInt32(0);
            conn.Close();
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
