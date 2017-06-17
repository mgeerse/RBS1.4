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
using Logic;

namespace UI
{
    public partial class BedieningMenuForm : Form
    {
        private Tafel tafel;

        BedieningForm parent;
        MenuLijst MenuLijst = new MenuLijst();

        public BedieningMenuForm(Tafel tafel, BedieningForm parent)
        {
            this.parent = parent;
            this.tafel = tafel;
            InitializeComponent();
        }

        private void tabDrank_Click(object sender, EventArgs e)
        {

        }

        private void VerzendenButton_Click(object sender, EventArgs e)
        {
            ConfirmVerzendenForm form = new ConfirmVerzendenForm(parent);
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Yes)
            {
                ConfirmedVerzondenForm ConfirmedVerzondenForm = new ConfirmedVerzondenForm(parent);
                ConfirmedVerzondenForm.StartPosition = FormStartPosition.CenterParent;
                ConfirmedVerzondenForm.ShowDialog();

                BedieningTafelOverzichtForm tafelForm = new BedieningTafelOverzichtForm(parent);
                tafelForm.TopLevel = false;
                tafelForm.FormBorderStyle = FormBorderStyle.None;
                parent.Controls["ContentPanel"].Controls.Clear();
                parent.Controls["ContentPanel"].Controls.Add(tafelForm);
                tafelForm.Show();
            }


        }

        private void BedieningMenuForm_Load(object sender, EventArgs e)
        {
            List<TableLayoutPanel> panels = new List<TableLayoutPanel> { LunchLayoutPanel, DinerLayoutPanel, DrankLayoutPanel, NonAlcoholLayoutPanel };
            /// Voor elke tab binnen de panelen wil ik de TableLayoutPanels aanroepen. 
            /// voor alle menuitems die in de tab thuis horen, wil ik 3 controls aanmaken
            /// 1. Label met ID
            /// 2. Label met gerechtnaam
            /// 3. Label met prijs

            for (int i = 0; i < panels.Count; i++)
            {
                List<Menuitem> menuitems = MenuLijst.GetMenukaart(i + 1);
                foreach (Menuitem item in menuitems)
                {
                    panels[i].Controls.Add(new Label() { Text = item.Id.ToString() }, i, 1);
                    panels[i].Controls.Add(new Label() { Text = item.Naam }, i, 2);
                    panels[i].Controls.Add(new Label() { Text = item.Prijs.ToString() }, i, 3);
                }
            }

        }

        private void menuitemBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lunchFillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dinerFillToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
