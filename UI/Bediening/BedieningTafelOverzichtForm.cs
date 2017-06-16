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
    /// <summary>
    /// Basisform voor het gebruik van de Chapoo-applicatie.
    /// Vanuit hier worden de applicaties voor mobiele en desktop devices geopend.
    /// </summary>
    public partial class BedieningTafelOverzichtForm : Form
    {
        BedieningForm parent;

        public BedieningTafelOverzichtForm(BedieningForm parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Btn_Tafel1.Visible = true;
            btn_Tafel2.Visible = true;
            btn_Tafel3.Visible = true;
            btn_Tafel4.Visible = true;
            btn_Bezet.Visible = true;
            btn_Bezet.Enabled = false;
            button1.Visible = true;
            button1.Enabled = false;
            btn_Tafel5.Visible = true;
            btn_Tafel6.Visible = true;
            btn_Tafel7.Visible = true;
            btn_Tafel8.Visible = true;
            btn_Tafel9.Visible = true;
            btn_Tafel10.Visible = true;
            btn_BarVoorraad.Visible = true;
            btn_KeukenVoorraad.Visible = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nummer = 1;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                Btn_Tafel1.BackColor = Color.Red;
            }
            if (kleur.TafelAfgerekend(nummer))
            {
                Btn_Tafel1.BackColor = Color.Lime;
            }
        }

        private void btn_BarVoorraad_Click(object sender, EventArgs e)
        {
            int nummer = 2;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                btn_Tafel2.BackColor = Color.Red;
            }
            else if(kleur.TafelAfgerekend(nummer))
            {
                btn_Tafel2.BackColor = Color.Lime;
            }
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            int nummer = 3;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                btn_Tafel3.BackColor = Color.Red;
            }
           if (kleur.TafelAfgerekend(nummer))
            {
                btn_Tafel3.BackColor = Color.Lime;
            }
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            int nummer = 4;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                btn_Tafel4.BackColor = Color.Red;
            }
            if (kleur.TafelAfgerekend(nummer))
            {
                btn_Tafel4.BackColor = Color.Lime;
            }
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            int nummer = 5;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                btn_Tafel5.BackColor = Color.Red;
            }
            if (kleur.TafelAfgerekend(nummer))
            {
                btn_Tafel5.BackColor = Color.Lime;
            }
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            int nummer = 6;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                btn_Tafel6.BackColor = Color.Red;
            }
            if (kleur.TafelAfgerekend(nummer))
            {
                btn_Tafel6.BackColor = Color.Lime;
            }
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            int nummer = 7;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                btn_Tafel7.BackColor = Color.Red;
            }
            if (kleur.TafelAfgerekend(nummer))
            {
                btn_Tafel7.BackColor = Color.Lime;
            }
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            int nummer = 8;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                btn_Tafel8.BackColor = Color.Red;
            }
            if (kleur.TafelAfgerekend(nummer))
            {
                btn_Tafel8.BackColor = Color.Lime;
            }
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            int nummer = 9;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                btn_Tafel9.BackColor = Color.Red;
            }
            if (kleur.TafelAfgerekend(nummer))
            {
                btn_Tafel9.BackColor = Color.Lime;
            }
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            int nummer = 10;
            BedieningForm tafel = new BedieningForm();
            tafel.Show();
            TafelLogic kleur = new TafelLogic();
            if (kleur.BezetTafel(nummer))
            {
                btn_Tafel10.BackColor = Color.Red;
            }
            if (kleur.TafelAfgerekend(nummer))
            {
                btn_Tafel10.BackColor = Color.Lime;
            }
        }

        void btn_Loguit_Click(object sender, EventArgs e) { }

        public void ShowTafelBestellingOverzicht(int nummer)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);
            tafel.TopLevel = false;
            parent.Controls["ContentPanel"].Controls.Clear();
            parent.Controls["ContentPanel"].Controls.Add(tafel);
            tafel.Show();
        }


    }
}
