using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    /// <summary>
    /// Basisform voor het gebruik van de Chapoo-applicatie.
    /// Vanuit hier worden de applicaties voor mobiele en desktop devices geopend.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Hier roep je de logica laag aan.
        }

        private void AdministratieButton_Click(object sender, EventArgs e)
        {
            //TODO AdministratieForm terug stoppen
            //new AdministratieForm().Show();
        }

        private void BedieningButton_Click(object sender, EventArgs e)
        {
            new TafelOverzicht().Show();
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            new Barman(new Medewerker(6, "Maarten", MedewerkerType.Bar, "0100".ToCharArray())).Show();
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            new Barman(new Medewerker(1, "Maarten", MedewerkerType.Bar, "0100".ToCharArray())).Show();
        }
    }
}
