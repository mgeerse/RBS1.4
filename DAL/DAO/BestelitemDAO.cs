using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BestelitemDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Bestelitem> GetAll()
        {
            return null;
        }

        public Bestelitem GetForId(int Id)
        {
            return null;
        }

        public bool Create(Bestelitem Object)
        {
            return false;
        }

        public bool Update(Bestelitem Object)
        {
            return false;
        }

        public bool Delete(Bestelitem Object)
        {
            return false;
        }

    }
}
