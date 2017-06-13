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
    public partial class Barman : Form
    {
        OrderPanel OP = new OrderPanel();
        Panel Panel;

        public Barman(Medewerker Medewerker)
        {
            InitializeComponent();
            

            Panel = OP.MaakTabControl(new Panel());
            Panel.Name = "BestelPanel";
            ToolStripOnder TSO = new ToolStripOnder(this, Panel);

            Controls.Add(TSO.maakToolStrip(Medewerker));
            Controls.Add(Panel);

            timer1.Interval = 10000;
            timer1.Start();

        }

        private void Barman_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hier de automatische updates uitvoeren.
            //Deze gaat om de 10000 miliseconden (10 seconden)
            OP.MaakTabControl(Panel);
        }
    }
}
