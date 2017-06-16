namespace UI
{
    partial class ConfirmBetaalmethodeForm
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
            this.CashButton = new System.Windows.Forms.Button();
            this.PinButton = new System.Windows.Forms.Button();
            this.CreditcardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CashButton
            // 
            this.CashButton.Location = new System.Drawing.Point(15, 42);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(110, 64);
            this.CashButton.TabIndex = 0;
            this.CashButton.Text = "Cash";
            this.CashButton.UseVisualStyleBackColor = true;
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click);
            // 
            // PinButton
            // 
            this.PinButton.Location = new System.Drawing.Point(131, 42);
            this.PinButton.Name = "PinButton";
            this.PinButton.Size = new System.Drawing.Size(110, 64);
            this.PinButton.TabIndex = 1;
            this.PinButton.Text = "Pin";
            this.PinButton.UseVisualStyleBackColor = true;
            this.PinButton.Click += new System.EventHandler(this.PinButton_Click);
            // 
            // CreditcardButton
            // 
            this.CreditcardButton.Location = new System.Drawing.Point(247, 42);
            this.CreditcardButton.Name = "CreditcardButton";
            this.CreditcardButton.Size = new System.Drawing.Size(110, 64);
            this.CreditcardButton.TabIndex = 2;
            this.CreditcardButton.Text = "Creditcard";
            this.CreditcardButton.UseVisualStyleBackColor = true;
            this.CreditcardButton.Click += new System.EventHandler(this.CreditcardButton_Click);
            // 
            // ConfirmBetaalmethodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 151);
            this.Controls.Add(this.CreditcardButton);
            this.Controls.Add(this.PinButton);
            this.Controls.Add(this.CashButton);
            this.Name = "ConfirmBetaalmethodeForm";
            this.Text = "ConfirmBetaalmethodeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CashButton;
        private System.Windows.Forms.Button PinButton;
        private System.Windows.Forms.Button CreditcardButton;
    }
}