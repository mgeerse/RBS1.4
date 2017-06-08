using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL.DAO
{
    class BezoekDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Bezoek> GetAll()
        {
            return null;
        }

        public Bezoek GetForId(int Id)
        {
            return null;
        }

        public bool Create(Bezoek Object)
        {
            return false;
        }

        public bool Update(Bezoek Object)
        {
            return false;
        }

        public bool Delete(Bezoek Object)
        {
            return false;
        }

    }
}
