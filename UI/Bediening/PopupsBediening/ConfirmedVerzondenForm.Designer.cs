namespace UI
{
    partial class ConfirmedVerzondenForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.LabelVerzonden = new System.Windows.Forms.Label();
            this.LabelOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(77, 71);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(97, 40);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // LabelVerzonden
            // 
            this.LabelVerzonden.AutoSize = true;
            this.LabelVerzonden.Location = new System.Drawing.Point(37, 9);
            this.LabelVerzonden.Name = "LabelVerzonden";
            this.LabelVerzonden.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelVerzonden.Size = new System.Drawing.Size(179, 17);
            this.LabelVerzonden.TabIndex = 1;
            this.LabelVerzonden.Text = "De bestelling is verzonden.";
            // 
            // LabelOk
            // 
            this.LabelOk.AutoSize = true;
            this.LabelOk.Location = new System.Drawing.Point(12, 36);
            this.LabelOk.Name = "LabelOk";
            this.LabelOk.Size = new System.Drawing.Size(245, 17);
            this.LabelOk.TabIndex = 2;
            this.LabelOk.Text = "Klik op \'OK\' en ga naar tafeloverzicht.";
            // 
            // ConfirmedVerzondenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 123);
            this.Controls.Add(this.LabelOk);
            this.Controls.Add(this.LabelVerzonden);
            this.Controls.Add(this.OKButton);
            this.Name = "ConfirmedVerzondenForm";
            this.Text = "ConfirmedVerzondenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label LabelVerzonden;
        private System.Windows.Forms.Label LabelOk;
    }
}