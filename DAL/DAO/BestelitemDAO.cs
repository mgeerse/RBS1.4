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
        private BestellingDAO BestellingDAO = new BestellingDAO();
        private MenuitemDAO MenuitemDAO = new MenuitemDAO();

        public List<Bestelitem> GetAll()
        {
            List<Bestelitem> result = new List<Bestelitem>();

            conn.Open();

            string query = "SELECT Bestelling, Menuitem, Aantal, Opmerking, Status, TijdIngevoerd" +
                " FROM Bestelitem";

            SqlCommand command = new SqlCommand(query, conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Bestelling Bestelling = BestellingDAO.GetForId(reader.GetInt32(0));
                Menuitem Menuitem = MenuitemDAO.GetForId(reader.GetInt32(1));
                int Aantal = reader.GetInt32(2);
                string Opmerking = reader.GetString(3);
                Status Status = (Status) reader.GetInt32(4);
                DateTime TijdIngevoerd = reader.GetDateTime(5);

                // TODO result toevoegen
                // result.Add(new Bestelitem());
            }


            conn.Close();
            return null;
        }

        public Bestelitem GetForId(int Id)
        {
            conn.Open();

            conn.Close();
            return null;
        }

        public bool Create(Bestelitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Update(Bestelitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

        public bool Delete(Bestelitem Object)
        {
            conn.Open();

            conn.Close();
            return false;
        }

    }
}
