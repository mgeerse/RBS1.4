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
using Logic;

namespace UI
{
    public partial class RekeningUserControl : UserControl
    {
        Bestelitem gerecht;

        public RekeningUserControl(Bestelitem gerecht)
        {
            InitializeComponent();
            this.gerecht = gerecht;
            Labels();
        }

        public void Labels()
        {
            LabelAantal.Text = gerecht.Aantal.ToString();
            LabelGerecht.Text = gerecht.Menuitem.Naam;

            decimal BerekendePrijs = gerecht.Aantal * gerecht.Menuitem.Prijs;

            LabelPrijs.Text = BerekendePrijs.ToString();
        }

    }
}
