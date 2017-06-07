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
    public partial class AdministratieForm : Form
    {
        private Medewerker IngelogdeMedewerker = null;

        public AdministratieForm()
        {
            InitializeComponent();
        }

        private void AdministratieForm_Load(object sender, EventArgs e)
        {
            AdministratieLoginForm loginForm = new AdministratieLoginForm(this);
            loginForm.TopLevel = false;
            ContentPanel.Controls.Add(loginForm);
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IngelogdeMedewerker == null)
            {
                ErrAlUitgelogdForm form = new ErrAlUitgelogdForm();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
            //TODO: Uitlogfunctionaliteit
        }

        public void SetIngelogdeMedewerker(Medewerker medewerker)
        {
            IngelogdeMedewerker = medewerker;
            IngelogdeMedewerkerToolStripLabel.Text = "Ingelogd als: " + IngelogdeMedewerker.Naam;
        }
    }
}
