using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    /// <summary>
    /// Deze klasse dient alleen voor het geven van een SqlConnection object 
    /// aan de klasse die het aanroept binnen de DAL-laag.
    /// </summary>
    public static class DbConnection
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Connector"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
