using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL.DAO
{
    class BestellingDAO
    {
        private SqlConnection conn;

        public List<Bestelling> GetAll()
        {
            return null;
        }

        public Bestelling GetForId(int Id)
        {
            return null;
        }

        public bool Create(Bestelling Object)
        {
            return false;
        }

        public bool Update(Bestelling Object)
        {
            return false;
        }

        public bool Delete(Bestelling Object)
        {
            return false;
        }

    }
}
