using System;
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
            new BedieningForm().Show();
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            new OrderLoginForm("Bar", this).Show();
            Hide();
        }

        private void KeukenButton_Click(object sender, EventArgs e)
        {
            new OrderLoginForm("Keuken", this).Show();
            Hide();
        }
    }
}
