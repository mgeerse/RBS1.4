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
        private Tafel Tafel;
        private Bestelling Bestelling;
        private List<Menuitem> allMenuitems = new GetMenuitem().GetAll();


        BedieningForm parent;
        MenuLijst MenuLijst = new MenuLijst();

        // De lijst onder de tabbladen wordt met deze list gevuld.
        List<Bestelitem> pendingBestelitems = new List<Bestelitem>();

        public BedieningMenuForm(Tafel Tafel, BedieningForm parent)
        {
            this.parent = parent;
            this.Tafel = Tafel;
            this.Bestelling = new BerekenRekening().GetLaatsteForTafel(Tafel.Id);

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

            // Vier tables, eentje voor elke menukaart
            DataGridView[] tables = new DataGridView[4];
            for (int i = 0; i < tables.Length; i++)
            {
                tables[i] = new DataGridView();
                SetTableInformation(tables[i]);

                // Menukaarten gaan van 1 tot 4, niet 0 tot 3
                List<Menuitem> menuitems = MenuLijst.GetMenukaart(i + 1);

                for (int j = 0; j < menuitems.Count; j++)
                {
                    tables[i].Rows.Add(menuitems[j].Id, menuitems[j].Naam, menuitems[j].Prijs);
                }

                tables[i].ClearSelection();
            }

            ToegevoegdeItemsGridView.CellMouseDoubleClick += (s, a) =>
            {

                /// index = hoeveelste rij
                int index = a.RowIndex;

                if (pendingBestelitems[index].Aantal == 1)
                {
                    pendingBestelitems.RemoveAt(index);
                }
                else
                {
                    pendingBestelitems[index].Aantal -= 1;
                }

                UpdatePendingBestelitems();
                return;
            };

            tabLunch.Controls.Add(tables[0]);
            tabDiner.Controls.Add(tables[1]);
            tabDrank.Controls.Add(tables[2]);
            tabNonAlcohol.Controls.Add(tables[3]);
        }


        private void SetTableInformation(DataGridView Table)
        {

            Table.ReadOnly = true;
            Table.RowHeadersVisible = false;
            Table.Dock = DockStyle.Fill;
            Table.ColumnCount = 3;
            Table.AllowUserToAddRows = false;
            Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Table.Columns[0].HeaderText = "Id";
            Table.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Table.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Table.Columns[1].HeaderText = "Naam";
            Table.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Table.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Table.Columns[2].HeaderText = "Prijs";
            Table.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Table.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Table.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 12);
            Table.DefaultCellStyle.Padding = new Padding(Padding.Left, 5, Padding.Right, 5);
            Table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Table.ColumnHeadersHeight += 10;

            // Event handler voor dubbelklikken op een rij
            Table.CellMouseDoubleClick += (sender, args) =>
            {
                int gekozenMenuitem = int.Parse(Table.SelectedRows[0].Cells[0].Value.ToString());
                Menuitem menuitem = allMenuitems.Single(i => i.Id == gekozenMenuitem);

                /// LINQ om te bepalen of een item in de lijst van pending staat
                /// Zo ja, voeg 1 toe aan aantal
                /// Zo nee, voeg item toe aan list
                int index = pendingBestelitems.FindIndex(i => i.Menuitem.Id == menuitem.Id);
                if (index >= 0)
                {
                    pendingBestelitems[index].Aantal += 1;
                }
                else
                {
                    pendingBestelitems.Add(new Bestelitem(Bestelling, menuitem, 1, "", Status.Ingevoerd, DateTime.Now));
                }

                UpdatePendingBestelitems();
            };

            InitPendingBestelitems();

        }

        private void InitPendingBestelitems()
        {
            ToegevoegdeItemsGridView.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 12);
            ToegevoegdeItemsGridView.DefaultCellStyle.Padding = new Padding(Padding.Left, 5, Padding.Right, 5);
            ToegevoegdeItemsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ToegevoegdeItemsGridView.ColumnHeadersHeight += 10;
        }


        private void UpdatePendingBestelitems()
        {
            ToegevoegdeItemsGridView.Rows.Clear();
            foreach (Bestelitem item in pendingBestelitems)
            {
                ToegevoegdeItemsGridView.Rows.Add(item.Menuitem.Naam, item.Aantal);
            }
        }


        #region Geen idee waar deze events worden aangeroepen ¯\_(ツ)_/¯
        private void menuitemBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lunchFillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dinerFillToolStripButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
