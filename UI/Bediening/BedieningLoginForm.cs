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
    public partial class BedieningLoginForm : Form
    {
        private BedieningForm parent;

        public BedieningLoginForm(BedieningForm parent)
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
                Bediening.BedieningMenuForm form = new Bediening.BedieningMenuForm();
                form.TopLevel = false;
                parent.Controls["ContentPanel"].Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
