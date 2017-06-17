using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class RekeningDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Rekening> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Rekening GetForId(int Id)
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public void Create()
        {
            conn.Open();

            string query = "INSERT INTO Rekening(DatumTijd)"
                + " VALUES (CURRENT_TIMESTAMP)";

            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public bool Create(ref Rekening Object)
        {
            conn.Open();


            conn.Close();
            return false;
        }

        public bool Update(Rekening Object)
        {
            conn.Open();
            string query = "UPDATE Rekening" +
                " SET PrijsExclusief = " + Object.TotaalExclusief + ", BtwBedrag = " + Object.BtwBedrag +
                " WHERE RekeningId = " + Object.Id;

            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();

            conn.Close();
            return false;
        }

        public bool Delete(Rekening Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public Rekening GetMax()
        {
            Rekening result = null;
            conn.Open();
            string query = "SELECT TOP 1 RekeningId"
                + " FROM Rekening"
                + " ORDER BY RekeningId DESC";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                result = new Rekening(reader.GetInt32(0), new DateTime(), 0.00M, 0.00M);
            }
            conn.Close();
            return result;
        }

    }
}
