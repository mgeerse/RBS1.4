﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Bediening : Form
    {
        public Bediening()
        {
            InitializeComponent();
        }

        private void Bediening_Load(object sender, EventArgs e)
        {
            btn_Bekijk.Visible = true;
            btn_Hoofdstuk.Visible = true;
            btn_Notif_Nondalcohol.Visible = true;
            btn_VerzendNon_Aclohol.Visible = true;
        }

        private void btn_Bekijk_Click(object sender, EventArgs e)
        {

        }
    }
}
