namespace UI
{
    partial class BedieningForm
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
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngelogdeMedewerkerToolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1020);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(702, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // IngelogdeMedewerkerToolStripLabel
            // 
            this.IngelogdeMedewerkerToolStripLabel.Name = "IngelogdeMedewerkerToolStripLabel";
            this.IngelogdeMedewerkerToolStripLabel.Size = new System.Drawing.Size(190, 20);
            this.IngelogdeMedewerkerToolStripLabel.Text = "Ingelogd als: Niet ingelogd";
            // 
            // LoguitButton
            // 
            this.LoguitButton.Location = new System.Drawing.Point(508, 1020);
            this.LoguitButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoguitButton.Name = "LoguitButton";
            this.LoguitButton.Size = new System.Drawing.Size(194, 27);
            this.LoguitButton.TabIndex = 1;
            this.LoguitButton.Text = "Uitloggen";
            this.LoguitButton.UseVisualStyleBackColor = true;
            this.LoguitButton.Click += new System.EventHandler(this.LoguitButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(702, 1020);
            this.ContentPanel.TabIndex = 2;
            // 
            // BedieningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 1045);
            this.Controls.Add(this.LoguitButton);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BedieningForm";
            this.Text = "BedieningForm";
            this.Load += new System.EventHandler(this.BedieningForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel IngelogdeMedewerkerToolStripLabel;
        private System.Windows.Forms.Button LoguitButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}