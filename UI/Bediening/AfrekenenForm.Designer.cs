namespace UI
{
    partial class AfrekenenForm
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
            this.ButtonOpmerkingen = new System.Windows.Forms.Button();
            this.BetalenButton = new System.Windows.Forms.Button();
            this.textBoxOpmerkingen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RekeningPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TotaalRekeningPanel = new System.Windows.Forms.Panel();
            this.TipToevoegenButton = new System.Windows.Forms.Button();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.TerugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonOpmerkingen
            // 
            this.ButtonOpmerkingen.Location = new System.Drawing.Point(50, 767);
            this.ButtonOpmerkingen.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonOpmerkingen.Name = "ButtonOpmerkingen";
            this.ButtonOpmerkingen.Size = new System.Drawing.Size(152, 77);
            this.ButtonOpmerkingen.TabIndex = 0;
            this.ButtonOpmerkingen.Text = "Opmerkingen toevoegen";
            this.ButtonOpmerkingen.UseVisualStyleBackColor = true;
            this.ButtonOpmerkingen.Click += new System.EventHandler(this.ButtonOpmerkingen_Click);
            // 
            // BetalenButton
            // 
            this.BetalenButton.Location = new System.Drawing.Point(319, 767);
            this.BetalenButton.Margin = new System.Windows.Forms.Padding(2);
            this.BetalenButton.Name = "BetalenButton";
            this.BetalenButton.Size = new System.Drawing.Size(152, 77);
            this.BetalenButton.TabIndex = 1;
            this.BetalenButton.Text = "Betalen";
            this.BetalenButton.UseVisualStyleBackColor = true;
            this.BetalenButton.Click += new System.EventHandler(this.BetalenButton_Click);
            // 
            // textBoxOpmerkingen
            // 
            this.textBoxOpmerkingen.Location = new System.Drawing.Point(17, 687);
            this.textBoxOpmerkingen.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOpmerkingen.Multiline = true;
            this.textBoxOpmerkingen.Name = "textBoxOpmerkingen";
            this.textBoxOpmerkingen.Size = new System.Drawing.Size(220, 76);
            this.textBoxOpmerkingen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerecht";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(267, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aantal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(430, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prijs";
            // 
            // RekeningPanel
            // 
            this.RekeningPanel.ColumnCount = 1;
            this.RekeningPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RekeningPanel.Location = new System.Drawing.Point(9, 75);
            this.RekeningPanel.Name = "RekeningPanel";
            this.RekeningPanel.RowCount = 1;
            this.RekeningPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RekeningPanel.Size = new System.Drawing.Size(505, 423);
            this.RekeningPanel.TabIndex = 6;
            // 
            // TotaalRekeningPanel
            // 
            this.TotaalRekeningPanel.Location = new System.Drawing.Point(9, 504);
            this.TotaalRekeningPanel.Name = "TotaalRekeningPanel";
            this.TotaalRekeningPanel.Size = new System.Drawing.Size(505, 154);
            this.TotaalRekeningPanel.TabIndex = 7;
            // 
            // TipToevoegenButton
            // 
            this.TipToevoegenButton.Location = new System.Drawing.Point(319, 717);
            this.TipToevoegenButton.Name = "TipToevoegenButton";
            this.TipToevoegenButton.Size = new System.Drawing.Size(152, 40);
            this.TipToevoegenButton.TabIndex = 8;
            this.TipToevoegenButton.Text = "Tip toevoegen";
            this.TipToevoegenButton.UseVisualStyleBackColor = true;
            this.TipToevoegenButton.Click += new System.EventHandler(this.TipToevoegenButton_Click);
            // 
            // textBoxTip
            // 
            this.textBoxTip.Location = new System.Drawing.Point(319, 687);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(152, 20);
            this.textBoxTip.TabIndex = 9;
            this.textBoxTip.Text = "Tip";
            // 
            // TerugButton
            // 
            this.TerugButton.Location = new System.Drawing.Point(9, 12);
            this.TerugButton.Name = "TerugButton";
            this.TerugButton.Size = new System.Drawing.Size(75, 23);
            this.TerugButton.TabIndex = 10;
            this.TerugButton.Text = "Terug";
            this.TerugButton.UseVisualStyleBackColor = true;
            this.TerugButton.Click += new System.EventHandler(this.TerugButton_Click);
            // 
            // AfrekenenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 849);
            this.Controls.Add(this.TerugButton);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.TipToevoegenButton);
            this.Controls.Add(this.TotaalRekeningPanel);
            this.Controls.Add(this.RekeningPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOpmerkingen);
            this.Controls.Add(this.BetalenButton);
            this.Controls.Add(this.ButtonOpmerkingen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AfrekenenForm";
            this.Text = "AfrekenenForm";
            this.Load += new System.EventHandler(this.AfrekenenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOpmerkingen;
        private System.Windows.Forms.Button BetalenButton;
        private System.Windows.Forms.TextBox textBoxOpmerkingen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel RekeningPanel;
        private System.Windows.Forms.Panel TotaalRekeningPanel;
        private System.Windows.Forms.Button TipToevoegenButton;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.Button TerugButton;
    }
}