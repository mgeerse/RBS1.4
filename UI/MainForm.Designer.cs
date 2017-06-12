namespace UI
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AdministratieButton = new System.Windows.Forms.Button();
            this.BedieningButton = new System.Windows.Forms.Button();
            this.BarButton = new System.Windows.Forms.Button();
            this.KeukenButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dit scherm dient als het beginscherm voor de applicatie. Normaal gesproken zou el" +
    "k device een eigen scherm krijgen. In dit geval gebruiken wij pop-ups om dit te " +
    "emuleren.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.AdministratieButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BedieningButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BarButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.KeukenButton, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 394);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 226);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // AdministratieButton
            // 
            this.AdministratieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdministratieButton.Location = new System.Drawing.Point(4, 4);
            this.AdministratieButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdministratieButton.Name = "AdministratieButton";
            this.AdministratieButton.Size = new System.Drawing.Size(156, 218);
            this.AdministratieButton.TabIndex = 0;
            this.AdministratieButton.Text = "Administratie Computerscherm";
            this.AdministratieButton.UseVisualStyleBackColor = true;
            this.AdministratieButton.Click += new System.EventHandler(this.AdministratieButton_Click);
            // 
            // BedieningButton
            // 
            this.BedieningButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BedieningButton.Location = new System.Drawing.Point(168, 4);
            this.BedieningButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BedieningButton.Name = "BedieningButton";
            this.BedieningButton.Size = new System.Drawing.Size(156, 218);
            this.BedieningButton.TabIndex = 1;
            this.BedieningButton.Text = "Bediening\r\nMobiel scherm";
            this.BedieningButton.UseVisualStyleBackColor = true;
            this.BedieningButton.Click += new System.EventHandler(this.BedieningButton_Click);
            // 
            // BarButton
            // 
            this.BarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarButton.Location = new System.Drawing.Point(332, 4);
            this.BarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarButton.Name = "BarButton";
            this.BarButton.Size = new System.Drawing.Size(156, 218);
            this.BarButton.TabIndex = 2;
            this.BarButton.Text = "Bar";
            this.BarButton.UseVisualStyleBackColor = true;
            // 
            // KeukenButton
            // 
            this.KeukenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeukenButton.Location = new System.Drawing.Point(496, 4);
            this.KeukenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KeukenButton.Name = "KeukenButton";
            this.KeukenButton.Size = new System.Drawing.Size(159, 218);
            this.KeukenButton.TabIndex = 3;
            this.KeukenButton.Text = "Keuken";
            this.KeukenButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.chrome_2017_06_06_13_52_20;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 334);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Chapoo Bestelsysteem";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AdministratieButton;
        private System.Windows.Forms.Button BedieningButton;
        private System.Windows.Forms.Button BarButton;
        private System.Windows.Forms.Button KeukenButton;
    }
}

