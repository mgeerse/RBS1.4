using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class Barman : Form
    {
        BarmanOrderScherm OP = new BarmanOrderScherm();
        Panel Panel = new Panel();

        public Barman(Medewerker Medewerker)
        {
            InitializeComponent();

            Panel.Size = new Size(1160, 695);
            Panel.Location = new Point(0, 0);
            Panel.BackColor = Color.LightSteelBlue;

            Panel = OP.MaakControls(Panel);
            BarToolStrip BOS = new BarToolStrip(this, Panel, timer1, Medewerker);

            Controls.Add(BOS.maakToolStrip());
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

            Panel.Controls.Clear();


            OP.MaakControls(Panel);
        }
    }
}
