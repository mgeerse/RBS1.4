using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class App
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Char[] x = new char[4];
            x[0] = Convert.ToChar(2);
            x[1] = Convert.ToChar(0);
            x[2] = Convert.ToChar(1);
            x[3] = Convert.ToChar(7);


            Model.Medewerker Medewerker = new Model.Medewerker(0100, "Maarten Geerse", (Model.MedewerkerType)2, x);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
