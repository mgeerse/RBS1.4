﻿namespace UI
{
    partial class ConfirmVerzendenForm
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
            this.ConfirmVerzendenButton = new System.Windows.Forms.Button();
            this.CancelVerzendenButton = new System.Windows.Forms.Button();
            this.LabelVerzenden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmVerzendenButton
            // 
            this.ConfirmVerzendenButton.Location = new System.Drawing.Point(9, 58);
            this.ConfirmVerzendenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmVerzendenButton.Name = "ConfirmVerzendenButton";
            this.ConfirmVerzendenButton.Size = new System.Drawing.Size(73, 32);
            this.ConfirmVerzendenButton.TabIndex = 0;
            this.ConfirmVerzendenButton.Text = "Ja";
            this.ConfirmVerzendenButton.UseVisualStyleBackColor = true;
            this.ConfirmVerzendenButton.Click += new System.EventHandler(this.ConfirmVerzendenButton_Click);
            // 
            // CancelVerzendenButton
            // 
            this.CancelVerzendenButton.Location = new System.Drawing.Point(110, 58);
            this.CancelVerzendenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelVerzendenButton.Name = "CancelVerzendenButton";
            this.CancelVerzendenButton.Size = new System.Drawing.Size(73, 32);
            this.CancelVerzendenButton.TabIndex = 1;
            this.CancelVerzendenButton.Text = "Nee";
            this.CancelVerzendenButton.UseVisualStyleBackColor = true;
            this.CancelVerzendenButton.Click += new System.EventHandler(this.CancelVerzendenButton_Click);
            // 
            // LabelVerzenden
            // 
            this.LabelVerzenden.AutoSize = true;
            this.LabelVerzenden.Location = new System.Drawing.Point(20, 28);
            this.LabelVerzenden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelVerzenden.Name = "LabelVerzenden";
            this.LabelVerzenden.Size = new System.Drawing.Size(155, 13);
            this.LabelVerzenden.TabIndex = 2;
            this.LabelVerzenden.Text = "Wilt u de bestelling verzenden?";
            // 
            // ConfirmVerzendenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 100);
            this.Controls.Add(this.LabelVerzenden);
            this.Controls.Add(this.CancelVerzendenButton);
            this.Controls.Add(this.ConfirmVerzendenButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConfirmVerzendenForm";
            this.Text = "ConfirmVerzendenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmVerzendenButton;
        private System.Windows.Forms.Button CancelVerzendenButton;
        private System.Windows.Forms.Label LabelVerzenden;
    }
}