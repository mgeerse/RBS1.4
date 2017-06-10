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
            this.BestellingenPanel = new System.Windows.Forms.Panel();
            this.buttonBestellingToevoegen = new System.Windows.Forms.Button();
            this.buttonAfrekenen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BestellingenPanel
            // 
            this.BestellingenPanel.Location = new System.Drawing.Point(9, 10);
            this.BestellingenPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestellingenPanel.Name = "BestellingenPanel";
            this.BestellingenPanel.Size = new System.Drawing.Size(508, 614);
            this.BestellingenPanel.TabIndex = 0;
            // 
            // buttonBestellingToevoegen
            // 
            this.buttonBestellingToevoegen.Location = new System.Drawing.Point(52, 686);
            this.buttonBestellingToevoegen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBestellingToevoegen.Name = "buttonBestellingToevoegen";
            this.buttonBestellingToevoegen.Size = new System.Drawing.Size(152, 77);
            this.buttonBestellingToevoegen.TabIndex = 1;
            this.buttonBestellingToevoegen.Text = "Bestelling toevoegen";
            this.buttonBestellingToevoegen.UseVisualStyleBackColor = true;
            // 
            // buttonAfrekenen
            // 
            this.buttonAfrekenen.Location = new System.Drawing.Point(317, 686);
            this.buttonAfrekenen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAfrekenen.Name = "buttonAfrekenen";
            this.buttonAfrekenen.Size = new System.Drawing.Size(152, 77);
            this.buttonAfrekenen.TabIndex = 2;
            this.buttonAfrekenen.Text = "Afrekenen";
            this.buttonAfrekenen.UseVisualStyleBackColor = true;
            this.buttonAfrekenen.Click += new System.EventHandler(this.buttonAfrekenen_Click);
            // 
            // BedieningBestellingOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 849);
            this.Controls.Add(this.buttonAfrekenen);
            this.Controls.Add(this.buttonBestellingToevoegen);
            this.Controls.Add(this.BestellingenPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BedieningBestellingOverzichtForm";
            this.Text = "BedieningBestellingOverzichtForm";
            this.Load += new System.EventHandler(this.BedieningBestellingOverzichtForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BestellingenPanel;
        private System.Windows.Forms.Button buttonBestellingToevoegen;
        private System.Windows.Forms.Button buttonAfrekenen;
    }
}