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
            List<Menuitem> result = new List<Menuitem>();
            conn.Open();

            string query = "SELECT MenuitemId, Naam, Prijs, Voorraad, Categorie" +
                         " FROM Menuitem";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int MenuitemId = reader.GetInt32(0);
                string Naam = reader.GetString(1);
                decimal Prijs = reader.GetDecimal(2);
                int Voorraad = reader.GetInt32(3);
                Categorie Categorie = CategorieDAO.GetForId(reader.GetInt32(4));

                result.Add(new Menuitem(MenuitemId, Naam, Prijs, Categorie, Voorraad));
            }

            conn.Close();

            return result;
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

        public List<Menuitem> GetForMenukaart(int Menukaart)
        {
            List<Menuitem> result = new List<Menuitem>();

            conn.Open();

            string query = "SELECT MenuitemId, Menuitem.Naam, Prijs, Voorraad, Categorie" +
                " FROM Menuitem" +
                " JOIN Categorie ON Menuitem.Categorie = Categorie.CategorieId" +
                " JOIN Menukaart ON Categorie.Menukaart = Menukaart.MenukaartId" +
                " WHERE MenukaartId = " + Menukaart;

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int MenuitemId = reader.GetInt32(0);
                string Naam = reader.GetString(1);
                decimal Prijs = reader.GetDecimal(2);
                int Voorraad = reader.GetInt32(3);
                Categorie Categorie = CategorieDAO.GetForId(reader.GetInt32(4));
                result.Add(new Menuitem(MenuitemId, Naam, Prijs, Categorie, Voorraad));
            }
            conn.Close();

            return result;
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
