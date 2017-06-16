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
using Logic;
namespace UI
{
    /// <summary>
    /// Basisform voor het gebruik van de Chapoo-applicatie.
    /// Vanuit hier worden de applicaties voor mobiele en desktop devices geopend.
    /// </summary>
    public partial class TafelOverzicht : Form
    {
        BedieningForm parent;
        private Medewerker IngelogdeMedewerker = null;
        public TafelOverzicht()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btn_Bezet.Enabled = false;
            button1.Enabled = false;
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent);
            tafel.Show();
        }

        private void btn_Loguit_Click(object sender, EventArgs e)
        {

            if (IngelogdeMedewerker == null)
            {
                ErrAlUitgelogdForm form = new ErrAlUitgelogdForm();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
            else
            {
                ConfirmLogUitForm form = new ConfirmLogUitForm();
                form.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    IngelogdeMedewerker = null;
                    SetIngelogdeMedewerker(IngelogdeMedewerker);
                }
                else if (result == DialogResult.OK)
                {

                }
            }
        }
        public void SetIngelogdeMedewerker(Medewerker medewerker)
        {
            if (medewerker == null)
            {
                IngelogdeMedewerkerToolStripLabel.Text = "Ingelogd als: Niet ingelogd";
            }
            else
            {
                IngelogdeMedewerker = medewerker;
                IngelogdeMedewerkerToolStripLabel.Text = "Ingelogd als: " + IngelogdeMedewerker.Naam;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_BarVoorraad_Click(object sender, EventArgs e)
        {

        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

    }
}
