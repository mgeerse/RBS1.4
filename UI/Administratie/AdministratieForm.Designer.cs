namespace UI
{
    partial class AdministratieForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.IngelogdeMedewerkerToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoguitButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngelogdeMedewerkerToolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // IngelogdeMedewerkerToolStripLabel
            // 
            this.IngelogdeMedewerkerToolStripLabel.Name = "IngelogdeMedewerkerToolStripLabel";
            this.IngelogdeMedewerkerToolStripLabel.Size = new System.Drawing.Size(149, 17);
            this.IngelogdeMedewerkerToolStripLabel.Text = "Ingelogd als: Niet ingelogd";
            // 
            // LoguitButton
            // 
            this.LoguitButton.Location = new System.Drawing.Point(664, 539);
            this.LoguitButton.Name = "LoguitButton";
            this.LoguitButton.Size = new System.Drawing.Size(120, 22);
            this.LoguitButton.TabIndex = 1;
            this.LoguitButton.Text = "Uitloggen";
            this.LoguitButton.UseVisualStyleBackColor = true;
            this.LoguitButton.Click += new System.EventHandler(this.LoguitButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.pictureBox1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(784, 539);
            this.ContentPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UI.Properties.Resources.chrome_2017_06_06_13_52_20;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(609, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 82);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AdministratieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.LoguitButton);
            this.Controls.Add(this.statusStrip1);
            this.Name = "AdministratieForm";
            this.Text = "AdministratieForm";
            this.Load += new System.EventHandler(this.AdministratieForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel IngelogdeMedewerkerToolStripLabel;
        private System.Windows.Forms.Button LoguitButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}