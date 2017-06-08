using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class MedewerkerDAO
    {
        private SqlConnection conn = DbConnection.GetSqlConnection();

        public List<Medewerker> GetAll()
        {
            return null;
        }

        public Medewerker GetForId(int Id)
        {
            return null;
        }

        public bool Create(Medewerker Object)
        {
            return false;
        }

        public bool Update(Medewerker Object)
        {
            return false;
        }

        public bool Delete(Medewerker Object)
        {
            return false;
        }

    }
}
