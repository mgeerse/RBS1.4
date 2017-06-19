using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class Kok : Form
    {
        KokOrderScherm OP = new KokOrderScherm();
        Panel Panel = new PanelProperties.StandaardPanel();
        MainForm MainForm;
        public Kok(Medewerker Medewerker, MainForm MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            Panel = OP.MaakControls(Panel);
            KokToolStrip KSO = new KokToolStrip(this, Panel, timer1, Medewerker, MainForm);

            Controls.Add(KSO.maakToolStrip());
            Controls.Add(Panel);

            timer1.Interval = 10000;
            timer1.Start();

            FormClosed += Kok_FormClosed;
        }

        private void Kok_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
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
