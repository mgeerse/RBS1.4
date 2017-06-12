using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class CategorieDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();
        private MenukaartDAO MenukaartDAO = new MenukaartDAO();

        public List<Categorie> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Categorie GetForId(int Id)
        {
            conn.Open();
            string query = "SELECT CategorieId, Naam, BtwPercentage, Menukaart" +
                " FROM Categorie" +
                " WHERE CategorieId = " + Id;

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string Naam = reader.GetString(1);
                int BtwPercentage = reader.GetInt32(2);
                Menukaart Menukaart = MenukaartDAO.GetForId(reader.GetInt32(3));

                conn.Close();
                return new Categorie(Id, Naam, BtwPercentage, Menukaart);
            }
            conn.Close();
            return null;
        }

        public bool Create(Categorie Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Categorie Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Categorie Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
