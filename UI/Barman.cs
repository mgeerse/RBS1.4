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
    public partial class Barman : Form
    {
        public Barman(Medewerker Medewerker)
        {
            InitializeComponent();

            OrderPanel OP = new OrderPanel();
            Panel Panel = OP.MaakTabControl();
            Panel.Name = "BestelPanel";
            ToolStripOnder TSO = new ToolStripOnder(this, Panel);

            

            //Controls.Add(OP.MaakTabControl());

            Controls.Add(TSO.maakToolStrip(Medewerker));

            Controls.Add(Panel);
        }

        private void Barman_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10000;


        }
    }
}
