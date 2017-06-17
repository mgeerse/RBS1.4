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
            this.LunchLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DinerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DrankLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NonAlcoholLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabLunch.SuspendLayout();
            this.tabDiner.SuspendLayout();
            this.tabDrank.SuspendLayout();
            this.tabNonAlcohol.SuspendLayout();
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
            this.tabLunch.Controls.Add(this.LunchLayoutPanel);
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
            this.tabDiner.Controls.Add(this.DinerLayoutPanel);
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
            this.tabDrank.Controls.Add(this.DrankLayoutPanel);
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
            this.tabNonAlcohol.Controls.Add(this.NonAlcoholLayoutPanel);
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
            // LunchLayoutPanel
            // 
            this.LunchLayoutPanel.ColumnCount = 5;
            this.LunchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LunchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LunchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LunchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LunchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LunchLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LunchLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.LunchLayoutPanel.Name = "LunchLayoutPanel";
            this.LunchLayoutPanel.RowCount = 1;
            this.LunchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LunchLayoutPanel.Size = new System.Drawing.Size(496, 328);
            this.LunchLayoutPanel.TabIndex = 0;
            // 
            // DinerLayoutPanel
            // 
            this.DinerLayoutPanel.ColumnCount = 5;
            this.DinerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DinerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DinerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DinerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DinerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DinerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DinerLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.DinerLayoutPanel.Name = "DinerLayoutPanel";
            this.DinerLayoutPanel.RowCount = 1;
            this.DinerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DinerLayoutPanel.Size = new System.Drawing.Size(496, 328);
            this.DinerLayoutPanel.TabIndex = 0;
            // 
            // DrankLayoutPanel
            // 
            this.DrankLayoutPanel.ColumnCount = 5;
            this.DrankLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DrankLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DrankLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrankLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrankLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrankLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrankLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.DrankLayoutPanel.Name = "DrankLayoutPanel";
            this.DrankLayoutPanel.RowCount = 1;
            this.DrankLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DrankLayoutPanel.Size = new System.Drawing.Size(496, 328);
            this.DrankLayoutPanel.TabIndex = 0;
            // 
            // NonAlcoholLayoutPanel
            // 
            this.NonAlcoholLayoutPanel.ColumnCount = 5;
            this.NonAlcoholLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NonAlcoholLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NonAlcoholLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NonAlcoholLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NonAlcoholLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NonAlcoholLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NonAlcoholLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.NonAlcoholLayoutPanel.Name = "NonAlcoholLayoutPanel";
            this.NonAlcoholLayoutPanel.RowCount = 1;
            this.NonAlcoholLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.NonAlcoholLayoutPanel.Size = new System.Drawing.Size(496, 328);
            this.NonAlcoholLayoutPanel.TabIndex = 0;
            // 
            // BedieningMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 849);
            this.Controls.Add(this.VerzendenButton);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BedieningMenuForm";
            this.Text = "BedieningMenuForm";
            this.Load += new System.EventHandler(this.BedieningMenuForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLunch.ResumeLayout(false);
            this.tabDiner.ResumeLayout(false);
            this.tabDrank.ResumeLayout(false);
            this.tabNonAlcohol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLunch;
        private System.Windows.Forms.TabPage tabDiner;
        private System.Windows.Forms.TabPage tabDrank;
        private System.Windows.Forms.TabPage tabNonAlcohol;
        private System.Windows.Forms.Button VerzendenButton;
        private System.Windows.Forms.TableLayoutPanel LunchLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel DinerLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel DrankLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel NonAlcoholLayoutPanel;
    }
}