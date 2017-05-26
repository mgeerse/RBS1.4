using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL.DAO
{
    class RekeningDAO
    {
        private SqlConnection conn;

        public List<Rekening> GetAll()
        {
            return null;
        }

        public Rekening GetForId(int Id)
        {
            return null;
        }

        public bool Create(Rekening Object)
        {
            return false;
        }

        public bool Update(Rekening Object)
        {
            return false;
        }

        public bool Delete(Rekening Object)
        {
            return false;
        }

    }
}
