namespace UI
{
    partial class BedieningBestellingOverzichtForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBestellingToevoegen = new System.Windows.Forms.Button();
            this.buttonAfrekenen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 756);
            this.panel1.TabIndex = 0;
            // 
            // buttonBestellingToevoegen
            // 
            this.buttonBestellingToevoegen.Location = new System.Drawing.Point(70, 844);
            this.buttonBestellingToevoegen.Name = "buttonBestellingToevoegen";
            this.buttonBestellingToevoegen.Size = new System.Drawing.Size(203, 95);
            this.buttonBestellingToevoegen.TabIndex = 1;
            this.buttonBestellingToevoegen.Text = "Bestelling toevoegen";
            this.buttonBestellingToevoegen.UseVisualStyleBackColor = true;
            // 
            // buttonAfrekenen
            // 
            this.buttonAfrekenen.Location = new System.Drawing.Point(423, 844);
            this.buttonAfrekenen.Name = "buttonAfrekenen";
            this.buttonAfrekenen.Size = new System.Drawing.Size(203, 95);
            this.buttonAfrekenen.TabIndex = 2;
            this.buttonAfrekenen.Text = "Afrekenen";
            this.buttonAfrekenen.UseVisualStyleBackColor = true;
            // 
            // BedieningBestellingOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 1045);
            this.Controls.Add(this.buttonAfrekenen);
            this.Controls.Add(this.buttonBestellingToevoegen);
            this.Controls.Add(this.panel1);
            this.Name = "BedieningBestellingOverzichtForm";
            this.Text = "BedieningBestellingOverzichtForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBestellingToevoegen;
        private System.Windows.Forms.Button buttonAfrekenen;
    }
}