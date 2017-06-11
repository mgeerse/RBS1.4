using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class BestellingUserControl : UserControl
    {
        Bestelitem item;

        public BestellingUserControl(Bestelitem item)
        {
            InitializeComponent();
            this.item = item;
        }
    }
}
