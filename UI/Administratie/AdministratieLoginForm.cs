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
    public partial class AdministratieLoginForm : Form
    {
        private AdministratieForm parent;

        public AdministratieLoginForm(AdministratieForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            char[] logincode = LoginCodeTextBox.Text.ToCharArray();
            Medewerker medewerker = LoginHandler.GetForLoginCode(logincode);
            parent.SetIngelogdeMedewerker(medewerker);
            if (medewerker != null)
            {
                parent.Controls["ContentPanel"].Controls.Clear();
                AdministratieHomeForm form = new AdministratieHomeForm();
                form.TopLevel = false;
                parent.Controls["ContentPanel"].Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Show();
            }
        }
    }
}
