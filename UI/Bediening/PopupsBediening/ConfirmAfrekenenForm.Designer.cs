namespace UI
{
    partial class ConfirmAfrekenenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AfrekenenButton = new System.Windows.Forms.Button();
            this.CancelAfrekenenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weet u zeker dat  u wilt afrekenen?";
            // 
            // AfrekenenButton
            // 
            this.AfrekenenButton.Location = new System.Drawing.Point(12, 71);
            this.AfrekenenButton.Name = "AfrekenenButton";
            this.AfrekenenButton.Size = new System.Drawing.Size(97, 40);
            this.AfrekenenButton.TabIndex = 1;
            this.AfrekenenButton.Text = "Ja";
            this.AfrekenenButton.UseVisualStyleBackColor = true;
            this.AfrekenenButton.Click += new System.EventHandler(this.AfrekenenButton_Click);
            // 
            // CancelAfrekenenButton
            // 
            this.CancelAfrekenenButton.Location = new System.Drawing.Point(146, 71);
            this.CancelAfrekenenButton.Name = "CancelAfrekenenButton";
            this.CancelAfrekenenButton.Size = new System.Drawing.Size(97, 40);
            this.CancelAfrekenenButton.TabIndex = 2;
            this.CancelAfrekenenButton.Text = "Nee";
            this.CancelAfrekenenButton.UseVisualStyleBackColor = true;
            this.CancelAfrekenenButton.Click += new System.EventHandler(this.CancelAfrekenenButton_Click);
            // 
            // ConfirmAfrekenenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 123);
            this.Controls.Add(this.CancelAfrekenenButton);
            this.Controls.Add(this.AfrekenenButton);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmAfrekenenForm";
            this.Text = "ConfirmAfrekenenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AfrekenenButton;
        private System.Windows.Forms.Button CancelAfrekenenButton;
    }
}