namespace UI
{
    partial class BestellingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_aantal = new System.Windows.Forms.Label();
            this.lbl_gerecht = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gerecht";
            // 
            // lbl_aantal
            // 
            this.lbl_aantal.AutoSize = true;
            this.lbl_aantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aantal.Location = new System.Drawing.Point(13, 54);
            this.lbl_aantal.Name = "lbl_aantal";
            this.lbl_aantal.Size = new System.Drawing.Size(18, 20);
            this.lbl_aantal.TabIndex = 2;
            this.lbl_aantal.Text = "#";
            // 
            // lbl_gerecht
            // 
            this.lbl_gerecht.AutoSize = true;
            this.lbl_gerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gerecht.Location = new System.Drawing.Point(74, 54);
            this.lbl_gerecht.Name = "lbl_gerecht";
            this.lbl_gerecht.Size = new System.Drawing.Size(20, 20);
            this.lbl_gerecht.TabIndex = 3;
            this.lbl_gerecht.Text = "X";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(13, 98);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(64, 20);
            this.label75.TabIndex = 4;
            this.label75.Text = "Status: ";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(74, 98);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(20, 20);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "X";
            // 
            // BestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 141);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.lbl_gerecht);
            this.Controls.Add(this.lbl_aantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BestellingForm";
            this.Text = "BestellingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_aantal;
        private System.Windows.Forms.Label lbl_gerecht;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label lbl_status;
    }
}