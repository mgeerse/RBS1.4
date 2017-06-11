using System;
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
    public partial class Barman : Form
    {
        public Barman()
        {
            InitializeComponent();
            OrderPanel OP = new OrderPanel();

            foreach (var item in OP.MaakTabControl())
            {
                foreach (var ControlItem in item)
                {
                    Controls.Add(ControlItem);
                }
            }
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
