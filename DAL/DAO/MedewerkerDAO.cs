using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL.DAO
{
    class MedewerkerDAO
    {
        private SqlConnection conn;

        public List<Medewerker> GetAll()
        {
            string SQL = "SELECT *" +
                        "FROM dbo.Medewerker";

            SqlCommand command = new SqlCommand(SQL, conn);
            command.Prepare();
            SqlDataReader Reader = command.ExecuteReader();
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
