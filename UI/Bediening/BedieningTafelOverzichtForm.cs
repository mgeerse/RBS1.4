using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;
namespace UI
{
    /// <summary>
    /// Basisform voor het gebruik van de Chapoo-applicatie.
    /// Vanuit hier worden de applicaties voor mobiele en desktop devices geopend.
    /// </summary>l
    public partial class BedieningTafelOverzichtForm : Form
    {
        BedieningForm parent;

        TafelLogic TafelLogic;

        public BedieningTafelOverzichtForm(BedieningForm parent)
        {
            InitializeComponent();

            this.parent = parent;
            TafelLogic = new TafelLogic();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btn_Bezet.Enabled = false;
            button1.Enabled = false;
            
            List<Tafel> tafels = TafelLogic.BeginKleur();

            if (tafels[0].IsBezet == true)
            {
                Btn_Tafel1.BackColor = Color.Red;
            }
            if (tafels[1].IsBezet == true)
            {
                btn_Tafel2.BackColor = Color.Red;
            }
            if (tafels[2].IsBezet == true)
            {
                btn_Tafel3.BackColor = Color.Red;
            }
            if (tafels[3].IsBezet == true)
            {
                btn_Tafel4.BackColor = Color.Red;
            }
            if (tafels[4].IsBezet == true)
            {
                btn_Tafel5.BackColor = Color.Red;
            }
            if (tafels[5].IsBezet == true)
            {
                btn_Tafel6.BackColor = Color.Red;
            }
            if (tafels[6].IsBezet == true)
            {
                btn_Tafel7.BackColor = Color.Red;
            }
            if (tafels[7].IsBezet == true)
            {
                btn_Tafel8.BackColor = Color.Red;
            }
            if (tafels[8].IsBezet == true)
            {
                btn_Tafel9.BackColor = Color.Red;
            }
            if (tafels[9].IsBezet == true)
            {
                btn_Tafel10.BackColor = Color.Red;
            }
        }


        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            int nummer = 1;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                Btn_Tafel1.BackColor = Color.Red;
            }
            else
            {
                Btn_Tafel1.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }
        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            int nummer = 2;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                btn_Tafel2.BackColor = Color.Red;
            }
            else
            {
                btn_Tafel2.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            int nummer = 3;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                btn_Tafel3.BackColor = Color.Red;
            }
            else
            {
                btn_Tafel3.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            int nummer = 4;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                btn_Tafel4.BackColor = Color.Red;
            }
            else
            {
                btn_Tafel4.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            int nummer = 5;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                btn_Tafel5.BackColor = Color.Red;
            }
            else
            {
                btn_Tafel5.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            int nummer = 6;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                btn_Tafel6.BackColor = Color.Red;
            }
            else
            {
                btn_Tafel6.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            int nummer = 7;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                btn_Tafel7.BackColor = Color.Red;
            }
            else
            {
                btn_Tafel7.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            int nummer = 8;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                btn_Tafel8.BackColor = Color.Red;
            }
            else
            {
                btn_Tafel8.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            int nummer = 9;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                btn_Tafel9.BackColor = Color.Red;
            }
            else
            {
                btn_Tafel9.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            int nummer = 10;
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);

            if (TafelLogic.TafelBezet(nummer))
            {
                btn_Tafel10.BackColor = Color.Red;
            }
            else
            {
                btn_Tafel10.BackColor = Color.Lime;
            }

            ShowTafelBestellingOverzicht(nummer);
        }


        void btn_Loguit_Click(object sender, EventArgs e) { }

        public void ShowTafelBestellingOverzicht(int nummer)
        {
            BedieningBestellingOverzichtForm tafel = new BedieningBestellingOverzichtForm(parent, nummer);
            tafel.TopLevel = false;
            tafel.FormBorderStyle = FormBorderStyle.None;
            parent.Controls["ContentPanel"].Controls.Clear();
            parent.Controls["ContentPanel"].Controls.Add(tafel);
            tafel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
