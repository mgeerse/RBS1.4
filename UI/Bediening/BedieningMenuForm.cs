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
    public partial class BedieningMenuForm : Form
    {
        private Tafel tafel;

        public BedieningMenuForm(Tafel tafel)
        {
            InitializeComponent();
            this.tafel = tafel;
        }

        private void tabDrank_Click(object sender, EventArgs e)
        {

        }
    }
}
