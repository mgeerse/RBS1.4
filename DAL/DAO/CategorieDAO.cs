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

        public List<Categorie> GetAll()
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public Categorie GetForId(int Id)
        {
            conn.Open();

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
