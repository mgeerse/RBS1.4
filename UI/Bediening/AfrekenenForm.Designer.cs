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
            this.SuspendLayout();
            // 
            // ButtonOpmerkingen
            // 
            this.ButtonOpmerkingen.Location = new System.Drawing.Point(54, 869);
            this.ButtonOpmerkingen.Name = "ButtonOpmerkingen";
            this.ButtonOpmerkingen.Size = new System.Drawing.Size(203, 95);
            this.ButtonOpmerkingen.TabIndex = 0;
            this.ButtonOpmerkingen.Text = "Opmerkingen toevoegen";
            this.ButtonOpmerkingen.UseVisualStyleBackColor = true;
            this.ButtonOpmerkingen.Click += new System.EventHandler(this.ButtonOpmerkingen_Click);
            // 
            // BetalenButton
            // 
            this.BetalenButton.Location = new System.Drawing.Point(445, 869);
            this.BetalenButton.Name = "BetalenButton";
            this.BetalenButton.Size = new System.Drawing.Size(203, 95);
            this.BetalenButton.TabIndex = 1;
            this.BetalenButton.Text = "Betalen";
            this.BetalenButton.UseVisualStyleBackColor = true;
            this.BetalenButton.Click += new System.EventHandler(this.BetalenButton_Click);
            // 
            // textBoxOpmerkingen
            // 
            this.textBoxOpmerkingen.Location = new System.Drawing.Point(12, 777);
            this.textBoxOpmerkingen.Multiline = true;
            this.textBoxOpmerkingen.Name = "textBoxOpmerkingen";
            this.textBoxOpmerkingen.Size = new System.Drawing.Size(292, 86);
            this.textBoxOpmerkingen.TabIndex = 2;
            // 
            // AfrekenenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 1045);
            this.Controls.Add(this.textBoxOpmerkingen);
            this.Controls.Add(this.BetalenButton);
            this.Controls.Add(this.ButtonOpmerkingen);
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
    }
}