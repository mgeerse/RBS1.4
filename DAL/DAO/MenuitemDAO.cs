using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class MenuitemDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();
        private CategorieDAO CategorieDAO = new CategorieDAO();

        public List<Menuitem> GetAll()
        {
            conn.Open();

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
            conn.Open();
            string query = "SELECT MenuitemId, Naam, Prijs, Voorraad, Categorie" +
                " FROM Menuitem" +
                " WHERE MenuitemId = " + Id;

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string Naam = reader.GetString(1);
                decimal Prijs = reader.GetDecimal(2);
                int Voorraad = reader.GetInt32(3);
                Categorie Categorie = CategorieDAO.GetForId(reader.GetInt32(4));

                conn.Close();
                return new Menuitem(Id, Naam, Prijs, Categorie, Voorraad);
            }
            conn.Close();
            return null;
        }

        public bool Create(Menuitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Menuitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Menuitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
