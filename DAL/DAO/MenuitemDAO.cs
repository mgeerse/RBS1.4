using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL.DAO
{
    public class MenuitemDAO
    {
        private SqlConnection conn;

        public List<Menuitem> GetAll()
        {
            conn = DbConnection.GetSqlConnection();

            string SQL = "SELECT Naam" + 
                         "FROM dbo.Menuitem" +
                         "WHERE Categorie <= 3";

            SqlCommand command = new SqlCommand(SQL, conn);
            command.Prepare();
            SqlDataReader Reader = command.ExecuteReader();

            conn.Close();
            
            return null;
        }

        public Menuitem GetForId(int Id)
        {
            conn = DbConnection.GetSqlConnection();
            return null;
        }

        public bool Create(Menuitem Object)
        {
            conn = DbConnection.GetSqlConnection();
            return false;
        }

        public bool Update(Menuitem Object)
        {
            conn = DbConnection.GetSqlConnection();
            return false;
        }

        public bool Delete(Menuitem Object)
        {
            conn = DbConnection.GetSqlConnection();
            return false;
        }

    }
}
