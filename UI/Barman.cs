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
            BestelPanel bp = new BestelPanel();

            //Controls.Add
            Controls.Add(bp.panel);
        }

        private void Barman_Load(object sender, EventArgs e)
        {
            //Logic laag


            
        }
    }
}
