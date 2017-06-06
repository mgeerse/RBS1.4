using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Tester
{
    /// Applicatie bestaat puur om functionaliteit uit te proberen.
    class Program
    {
        static void Main(string[] args)
        {
            TestConnectionString();

            Console.WriteLine("Druk op een knop om door te gaan...");
            Console.ReadKey();
        }

        static void TestConnectionString()
        {
            Console.Write("Verbinding maken met DB... ");
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connector"].ConnectionString;

                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("OK");
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERR");
                Console.WriteLine("\tKan geen verbinding maken met de database.");
            }

            Console.ResetColor();
            conn.Close();
        }


    }
}