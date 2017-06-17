using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class OrderLoginForm : Form
    {
        private string StartForm;
        MainForm MainForm;


        public OrderLoginForm(string StartForm, MainForm MainForm)
        {
            InitializeComponent();
            this.FormClosed += OrderLoginForm_FormClosed;

            this.MainForm = MainForm;
            this.StartForm = StartForm;
        }

        private void OrderLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            char[] logincode = LoginCodeTextBox.Text.ToCharArray();
            Medewerker Medewerker = new LoginHandler().GetForLoginCode(logincode);

            // Als de medewerker voorkomt in de database
            if (Medewerker != null)
            {
                if (Medewerker.Type == MedewerkerType.Bar && StartForm == "Bar")
                {
                    new Barman(Medewerker, MainForm).Show();
                    this.Close();
                    MainForm.Hide();
                }
                else if (Medewerker.Type == MedewerkerType.Keuken && StartForm == "Keuken")
                {
                    new Kok(Medewerker, MainForm).Show();
                    this.Close();
                    MainForm.Hide();
                }
                else
                {
                    MessageBox.Show("U bent niet geautoriseerd om deze module uit te voeren.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    MainForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Logincode verkeerd!", "Probeer het opnieuw.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
