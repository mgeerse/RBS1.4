namespace UI
{
    partial class RekeningUserControl
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
            this.LabelGerecht = new System.Windows.Forms.Label();
            this.LabelPrijs = new System.Windows.Forms.Label();
            this.LabelAantal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelGerecht
            // 
            this.LabelGerecht.AutoSize = true;
            this.LabelGerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelGerecht.Location = new System.Drawing.Point(12, 44);
            this.LabelGerecht.Name = "LabelGerecht";
            this.LabelGerecht.Size = new System.Drawing.Size(20, 20);
            this.LabelGerecht.TabIndex = 2;
            this.LabelGerecht.Text = "X";
            // 
            // LabelPrijs
            // 
            this.LabelPrijs.AutoSize = true;
            this.LabelPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelPrijs.Location = new System.Drawing.Point(374, 44);
            this.LabelPrijs.Name = "LabelPrijs";
            this.LabelPrijs.Size = new System.Drawing.Size(18, 20);
            this.LabelPrijs.TabIndex = 3;
            this.LabelPrijs.Text = "#";
            // 
            // LabelAantal
            // 
            this.LabelAantal.AutoSize = true;
            this.LabelAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelAantal.Location = new System.Drawing.Point(246, 44);
            this.LabelAantal.Name = "LabelAantal";
            this.LabelAantal.Size = new System.Drawing.Size(18, 20);
            this.LabelAantal.TabIndex = 5;
            this.LabelAantal.Text = "#";
            // 
            // RekeningUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelAantal);
            this.Controls.Add(this.LabelPrijs);
            this.Controls.Add(this.LabelGerecht);
            this.Name = "RekeningUserControl";
            this.Size = new System.Drawing.Size(445, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelGerecht;
        private System.Windows.Forms.Label LabelPrijs;
        private System.Windows.Forms.Label LabelAantal;
    }
}
