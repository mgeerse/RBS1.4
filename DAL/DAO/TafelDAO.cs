using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class TafelDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Tafel> GetAll()
        {
            return null;
        }

        public Tafel GetForId(int Id)
        {
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
