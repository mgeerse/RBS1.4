namespace UI
{
    partial class ConfirmLogUitForm
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
            this.ConfirmLogoutButton = new System.Windows.Forms.Button();
            this.CancelLogoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmLogoutButton
            // 
            this.ConfirmLogoutButton.Location = new System.Drawing.Point(17, 58);
            this.ConfirmLogoutButton.Name = "ConfirmLogoutButton";
            this.ConfirmLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmLogoutButton.TabIndex = 0;
            this.ConfirmLogoutButton.Text = "Ja";
            this.ConfirmLogoutButton.UseVisualStyleBackColor = true;
            this.ConfirmLogoutButton.Click += new System.EventHandler(this.ConfirmLogoutButton_Click);
            // 
            // CancelLogoutButton
            // 
            this.CancelLogoutButton.Location = new System.Drawing.Point(98, 58);
            this.CancelLogoutButton.Name = "CancelLogoutButton";
            this.CancelLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.CancelLogoutButton.TabIndex = 1;
            this.CancelLogoutButton.Text = "Nee";
            this.CancelLogoutButton.UseVisualStyleBackColor = true;
            this.CancelLogoutButton.Click += new System.EventHandler(this.CancelLogoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weet u zeker dat u uit wilt loggen?";
            // 
            // ConfirmLogUitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 100);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelLogoutButton);
            this.Controls.Add(this.ConfirmLogoutButton);
            this.Name = "ConfirmLogUitForm";
            this.Text = "ConfirmLogUit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmLogoutButton;
        private System.Windows.Forms.Button CancelLogoutButton;
        private System.Windows.Forms.Label label1;
    }
}