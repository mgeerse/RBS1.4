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
    public partial class BestellingForm : Form
    {
        public Bestelitem Bestelitem
        {
            get; set;
        }

        public BestellingForm(Bestelitem Bestelitem)
        {
            this.Bestelitem = Bestelitem;
            InitializeComponent();
        }
    }
}
