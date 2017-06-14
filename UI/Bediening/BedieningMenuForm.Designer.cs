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
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLunch);
            this.tabControl1.Controls.Add(this.tabDiner);
            this.tabControl1.Controls.Add(this.tabDrank);
            this.tabControl1.Controls.Add(this.tabNonAlcohol);
            this.tabControl1.ItemSize = new System.Drawing.Size(126, 48);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 478);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabLunch
            // 
            this.tabLunch.Location = new System.Drawing.Point(4, 52);
            this.tabLunch.Name = "tabLunch";
            this.tabLunch.Padding = new System.Windows.Forms.Padding(3);
            this.tabLunch.Size = new System.Drawing.Size(669, 422);
            this.tabLunch.TabIndex = 0;
            this.tabLunch.Text = "Lunch";
            this.tabLunch.UseVisualStyleBackColor = true;
            // 
            // tabDiner
            // 
            this.tabDiner.Location = new System.Drawing.Point(4, 52);
            this.tabDiner.Name = "tabDiner";
            this.tabDiner.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiner.Size = new System.Drawing.Size(669, 422);
            this.tabDiner.TabIndex = 1;
            this.tabDiner.Text = "Diner";
            this.tabDiner.UseVisualStyleBackColor = true;
            // 
            // tabDrank
            // 
            this.tabDrank.Location = new System.Drawing.Point(4, 52);
            this.tabDrank.Name = "tabDrank";
            this.tabDrank.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrank.Size = new System.Drawing.Size(669, 422);
            this.tabDrank.TabIndex = 2;
            this.tabDrank.Text = "Drank";
            this.tabDrank.UseVisualStyleBackColor = true;
            this.tabDrank.Click += new System.EventHandler(this.tabDrank_Click);
            // 
            // tabNonAlcohol
            // 
            this.tabNonAlcohol.Location = new System.Drawing.Point(4, 52);
            this.tabNonAlcohol.Name = "tabNonAlcohol";
            this.tabNonAlcohol.Padding = new System.Windows.Forms.Padding(3);
            this.tabNonAlcohol.Size = new System.Drawing.Size(669, 422);
            this.tabNonAlcohol.TabIndex = 3;
            this.tabNonAlcohol.Text = "Non-Alcohol";
            this.tabNonAlcohol.UseVisualStyleBackColor = true;
            // 
            // VerzendenButton
            // 
            this.VerzendenButton.Location = new System.Drawing.Point(423, 844);
            this.VerzendenButton.Name = "VerzendenButton";
            this.VerzendenButton.Size = new System.Drawing.Size(203, 95);
            this.VerzendenButton.TabIndex = 1;
            this.VerzendenButton.Text = "Verzenden";
            this.VerzendenButton.UseVisualStyleBackColor = true;
            this.VerzendenButton.Click += new System.EventHandler(this.VerzendenButton_Click);
            // 
            // BedieningMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 1045);
            this.Controls.Add(this.VerzendenButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "BedieningMenuForm";
            this.Text = "BedieningMenuForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLunch;
        private System.Windows.Forms.TabPage tabDiner;
        private System.Windows.Forms.TabPage tabDrank;
        private System.Windows.Forms.TabPage tabNonAlcohol;
        private System.Windows.Forms.Button VerzendenButton;
    }
}