using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL.DAO
{
    class CategorieDAO
    {
        private SqlConnection conn;

        public List<Categorie> GetAll()
        {
            return null;
        }

        public Categorie GetForId(int Id)
        {
            return null;
        }

        public bool Create(Categorie Object)
        {
            return false;
        }

        public bool Update(Categorie Object)
        {
            return false;
        }

        public bool Delete(Categorie Object)
        {
            return false;
        }

    }
}
