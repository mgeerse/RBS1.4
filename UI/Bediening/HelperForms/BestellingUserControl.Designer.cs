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
            this.label3 = new System.Windows.Forms.Label();
            this.LabelTijdIngevoerd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelTafelNummer = new System.Windows.Forms.Label();
            this.VerwijderenButton = new System.Windows.Forms.Button();
            this.BezorgdMeldenButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(110, 77);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(20, 20);
            this.LabelStatus.TabIndex = 11;
            this.LabelStatus.Text = "X";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(16, 77);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(64, 20);
            this.label75.TabIndex = 10;
            this.label75.Text = "Status: ";
            // 
            // LabelGerechtNaam
            // 
            this.LabelGerechtNaam.AutoSize = true;
            this.LabelGerechtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGerechtNaam.Location = new System.Drawing.Point(110, 38);
            this.LabelGerechtNaam.Name = "LabelGerechtNaam";
            this.LabelGerechtNaam.Size = new System.Drawing.Size(20, 20);
            this.LabelGerechtNaam.TabIndex = 9;
            this.LabelGerechtNaam.Text = "X";
            // 
            // LabelAantal
            // 
            this.LabelAantal.AutoSize = true;
            this.LabelAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAantal.Location = new System.Drawing.Point(16, 38);
            this.LabelAantal.Name = "LabelAantal";
            this.LabelAantal.Size = new System.Drawing.Size(18, 20);
            this.LabelAantal.TabIndex = 8;
            this.LabelAantal.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 16);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingevoerd: ";
            // 
            // LabelTijdIngevoerd
            // 
            this.LabelTijdIngevoerd.AutoSize = true;
            this.LabelTijdIngevoerd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTijdIngevoerd.Location = new System.Drawing.Point(110, 117);
            this.LabelTijdIngevoerd.Name = "LabelTijdIngevoerd";
            this.LabelTijdIngevoerd.Size = new System.Drawing.Size(20, 20);
            this.LabelTijdIngevoerd.TabIndex = 13;
            this.LabelTijdIngevoerd.Text = "X";
            this.LabelTijdIngevoerd.Click += new System.EventHandler(this.LabelTijdIngevoerd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tafel:";
            // 
            // LabelTafelNummer
            // 
            this.LabelTafelNummer.AutoSize = true;
            this.LabelTafelNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTafelNummer.Location = new System.Drawing.Point(110, 97);
            this.LabelTafelNummer.Name = "LabelTafelNummer";
            this.LabelTafelNummer.Size = new System.Drawing.Size(20, 20);
            this.LabelTafelNummer.TabIndex = 15;
            this.LabelTafelNummer.Text = "X";
            // 
            // VerwijderenButton
            // 
            this.VerwijderenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VerwijderenButton.Location = new System.Drawing.Point(6, 82);
            this.VerwijderenButton.Name = "VerwijderenButton";
            this.VerwijderenButton.Size = new System.Drawing.Size(102, 52);
            this.VerwijderenButton.TabIndex = 18;
            this.VerwijderenButton.Text = "Verwijderen";
            this.VerwijderenButton.UseVisualStyleBackColor = true;
            this.VerwijderenButton.Click += new System.EventHandler(this.VerwijderenButton_Click);
            // 
            // BezorgdMeldenButton
            // 
            this.BezorgdMeldenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BezorgdMeldenButton.Location = new System.Drawing.Point(6, 16);
            this.BezorgdMeldenButton.Name = "BezorgdMeldenButton";
            this.BezorgdMeldenButton.Size = new System.Drawing.Size(102, 52);
            this.BezorgdMeldenButton.TabIndex = 19;
            this.BezorgdMeldenButton.Text = "Bezorgd melden";
            this.BezorgdMeldenButton.UseVisualStyleBackColor = true;
            this.BezorgdMeldenButton.Click += new System.EventHandler(this.BezorgdMeldenButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VerwijderenButton);
            this.panel1.Controls.Add(this.BezorgdMeldenButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(482, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 150);
            this.panel1.TabIndex = 20;
            // 
            // BestellingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelTafelNummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelTijdIngevoerd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.LabelGerechtNaam);
            this.Controls.Add(this.LabelAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(0, 160);
            this.Name = "BestellingUserControl";
            this.Size = new System.Drawing.Size(596, 150);
            this.Load += new System.EventHandler(this.BestellingUserControl_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelTijdIngevoerd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelTafelNummer;
        private System.Windows.Forms.Button VerwijderenButton;
        private System.Windows.Forms.Button BezorgdMeldenButton;
        private System.Windows.Forms.Panel panel1;
    }
}
