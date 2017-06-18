﻿using System;
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
    public partial class BedieningForm : Form
    {
        public Medewerker IngelogdeMedewerker { get; private set; }

        public BedieningForm()
        {
            InitializeComponent();
            IngelogdeMedewerker = null;
        }

        private void BedieningForm_Load(object sender, EventArgs e)
        {
            BedieningLoginForm loginForm = new BedieningLoginForm(this);
            loginForm.TopLevel = false;
            ContentPanel.Controls.Add(loginForm);
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;
            loginForm.Show();
        }

        private void LoguitButton_Click(object sender, EventArgs e)
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
                    ContentPanel.Controls.Clear();
                    BedieningForm_Load(sender, e);
                    SetIngelogdeMedewerker(IngelogdeMedewerker);
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

        public void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            Controls["ContentPanel"].Controls.Clear();
            Controls["ContentPanel"].Controls.Add(form);
            form.Show();
        }
    }
}
