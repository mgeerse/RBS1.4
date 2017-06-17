namespace UI
{
    partial class TipForm
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
            this.TipBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TipOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipBox
            // 
            this.TipBox.Location = new System.Drawing.Point(64, 34);
            this.TipBox.Margin = new System.Windows.Forms.Padding(2);
            this.TipBox.Name = "TipBox";
            this.TipBox.Size = new System.Drawing.Size(94, 20);
            this.TipBox.TabIndex = 0;
            this.TipBox.Text = "Fooi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klik op \'OK\' om bestelling af te ronden.";
            // 
            // TipOKButton
            // 
            this.TipOKButton.Location = new System.Drawing.Point(41, 106);
            this.TipOKButton.Margin = new System.Windows.Forms.Padding(2);
            this.TipOKButton.Name = "TipOKButton";
            this.TipOKButton.Size = new System.Drawing.Size(141, 65);
            this.TipOKButton.TabIndex = 3;
            this.TipOKButton.Text = "OK";
            this.TipOKButton.UseVisualStyleBackColor = true;
            this.TipOKButton.Click += new System.EventHandler(this.TipOKButton_Click);
            // 
            // TipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 193);
            this.Controls.Add(this.TipOKButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TipForm";
            this.Text = "TipForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TipBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TipOKButton;
    }
}