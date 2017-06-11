namespace UI
{
    partial class BestellingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelStatus = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.LabelGerechtNaam = new System.Windows.Forms.Label();
            this.LabelAantal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(77, 101);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(20, 20);
            this.LabelStatus.TabIndex = 11;
            this.LabelStatus.Text = "X";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(16, 101);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(64, 20);
            this.label75.TabIndex = 10;
            this.label75.Text = "Status: ";
            // 
            // LabelGerechtNaam
            // 
            this.LabelGerechtNaam.AutoSize = true;
            this.LabelGerechtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGerechtNaam.Location = new System.Drawing.Point(77, 57);
            this.LabelGerechtNaam.Name = "LabelGerechtNaam";
            this.LabelGerechtNaam.Size = new System.Drawing.Size(20, 20);
            this.LabelGerechtNaam.TabIndex = 9;
            this.LabelGerechtNaam.Text = "X";
            // 
            // LabelAantal
            // 
            this.LabelAantal.AutoSize = true;
            this.LabelAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAantal.Location = new System.Drawing.Point(16, 57);
            this.LabelAantal.Name = "LabelAantal";
            this.LabelAantal.Size = new System.Drawing.Size(18, 20);
            this.LabelAantal.TabIndex = 8;
            this.LabelAantal.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gerecht";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aantal";
            // 
            // BestellingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.LabelGerechtNaam);
            this.Controls.Add(this.LabelAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BestellingUserControl";
            this.Size = new System.Drawing.Size(450, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label LabelGerechtNaam;
        private System.Windows.Forms.Label LabelAantal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
