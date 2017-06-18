namespace UI
{
    partial class BedieningMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLunch = new System.Windows.Forms.TabPage();
            this.tabDiner = new System.Windows.Forms.TabPage();
            this.tabDrank = new System.Windows.Forms.TabPage();
            this.tabNonAlcohol = new System.Windows.Forms.TabPage();
            this.VerzendenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ToegevoegdeItemsGridView = new System.Windows.Forms.DataGridView();
            this.Menuitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToegevoegdeItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLunch);
            this.tabControl1.Controls.Add(this.tabDiner);
            this.tabControl1.Controls.Add(this.tabDrank);
            this.tabControl1.Controls.Add(this.tabNonAlcohol);
            this.tabControl1.ItemSize = new System.Drawing.Size(126, 48);
            this.tabControl1.Location = new System.Drawing.Point(10, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 388);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabLunch
            // 
            this.tabLunch.Location = new System.Drawing.Point(4, 52);
            this.tabLunch.Margin = new System.Windows.Forms.Padding(2);
            this.tabLunch.Name = "tabLunch";
            this.tabLunch.Padding = new System.Windows.Forms.Padding(2);
            this.tabLunch.Size = new System.Drawing.Size(500, 332);
            this.tabLunch.TabIndex = 0;
            this.tabLunch.Text = "Lunch";
            this.tabLunch.UseVisualStyleBackColor = true;
            // 
            // tabDiner
            // 
            this.tabDiner.Location = new System.Drawing.Point(4, 52);
            this.tabDiner.Margin = new System.Windows.Forms.Padding(2);
            this.tabDiner.Name = "tabDiner";
            this.tabDiner.Padding = new System.Windows.Forms.Padding(2);
            this.tabDiner.Size = new System.Drawing.Size(500, 332);
            this.tabDiner.TabIndex = 1;
            this.tabDiner.Text = "Diner";
            this.tabDiner.UseVisualStyleBackColor = true;
            // 
            // tabDrank
            // 
            this.tabDrank.Location = new System.Drawing.Point(4, 52);
            this.tabDrank.Margin = new System.Windows.Forms.Padding(2);
            this.tabDrank.Name = "tabDrank";
            this.tabDrank.Padding = new System.Windows.Forms.Padding(2);
            this.tabDrank.Size = new System.Drawing.Size(500, 332);
            this.tabDrank.TabIndex = 2;
            this.tabDrank.Text = "Drank";
            this.tabDrank.UseVisualStyleBackColor = true;
            this.tabDrank.Click += new System.EventHandler(this.tabDrank_Click);
            // 
            // tabNonAlcohol
            // 
            this.tabNonAlcohol.Location = new System.Drawing.Point(4, 52);
            this.tabNonAlcohol.Margin = new System.Windows.Forms.Padding(2);
            this.tabNonAlcohol.Name = "tabNonAlcohol";
            this.tabNonAlcohol.Padding = new System.Windows.Forms.Padding(2);
            this.tabNonAlcohol.Size = new System.Drawing.Size(500, 332);
            this.tabNonAlcohol.TabIndex = 3;
            this.tabNonAlcohol.Text = "Non-Alcohol";
            this.tabNonAlcohol.UseVisualStyleBackColor = true;
            // 
            // VerzendenButton
            // 
            this.VerzendenButton.Location = new System.Drawing.Point(317, 686);
            this.VerzendenButton.Margin = new System.Windows.Forms.Padding(2);
            this.VerzendenButton.Name = "VerzendenButton";
            this.VerzendenButton.Size = new System.Drawing.Size(152, 77);
            this.VerzendenButton.TabIndex = 1;
            this.VerzendenButton.Text = "Verzenden";
            this.VerzendenButton.UseVisualStyleBackColor = true;
            this.VerzendenButton.Click += new System.EventHandler(this.VerzendenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "De volgende items worden ingevoerd:";
            // 
            // ToegevoegdeItemsGridView
            // 
            this.ToegevoegdeItemsGridView.AllowUserToAddRows = false;
            this.ToegevoegdeItemsGridView.AllowUserToDeleteRows = false;
            this.ToegevoegdeItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToegevoegdeItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menuitem,
            this.Aantal});
            this.ToegevoegdeItemsGridView.Location = new System.Drawing.Point(14, 444);
            this.ToegevoegdeItemsGridView.Name = "ToegevoegdeItemsGridView";
            this.ToegevoegdeItemsGridView.ReadOnly = true;
            this.ToegevoegdeItemsGridView.RowHeadersVisible = false;
            this.ToegevoegdeItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ToegevoegdeItemsGridView.Size = new System.Drawing.Size(500, 223);
            this.ToegevoegdeItemsGridView.TabIndex = 3;
            // 
            // Menuitem
            // 
            this.Menuitem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Menuitem.HeaderText = "Menuitem";
            this.Menuitem.Name = "Menuitem";
            this.Menuitem.ReadOnly = true;
            // 
            // Aantal
            // 
            this.Aantal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Aantal.HeaderText = "Aantal";
            this.Aantal.Name = "Aantal";
            this.Aantal.ReadOnly = true;
            this.Aantal.Width = 62;
            // 
            // BedieningMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 849);
            this.Controls.Add(this.ToegevoegdeItemsGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerzendenButton);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BedieningMenuForm";
            this.Text = "BedieningMenuForm";
            this.Load += new System.EventHandler(this.BedieningMenuForm_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToegevoegdeItemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLunch;
        private System.Windows.Forms.TabPage tabDiner;
        private System.Windows.Forms.TabPage tabDrank;
        private System.Windows.Forms.TabPage tabNonAlcohol;
        private System.Windows.Forms.Button VerzendenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ToegevoegdeItemsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menuitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aantal;
    }
}