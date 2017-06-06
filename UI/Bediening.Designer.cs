namespace UI
{
    partial class Bediening
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
            this.tab_Lunch = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Hoofdstuk = new System.Windows.Forms.Button();
            this.btn_Verzend = new System.Windows.Forms.Button();
            this.btn_Bekijk = new System.Windows.Forms.Button();
            this.btn_notificatie = new System.Windows.Forms.Button();
            this.tab_Lunch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Lunch
            // 
            this.tab_Lunch.Controls.Add(this.tabPage1);
            this.tab_Lunch.Controls.Add(this.tabPage2);
            this.tab_Lunch.Controls.Add(this.tabPage3);
            this.tab_Lunch.Controls.Add(this.tabPage4);
            this.tab_Lunch.Location = new System.Drawing.Point(12, 58);
            this.tab_Lunch.Name = "tab_Lunch";
            this.tab_Lunch.SelectedIndex = 0;
            this.tab_Lunch.Size = new System.Drawing.Size(268, 399);
            this.tab_Lunch.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(246, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lunch";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(246, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(246, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "drank-alcohol";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(260, 373);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "drank-nonalcohol";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_Hoofdstuk
            // 
            this.btn_Hoofdstuk.Location = new System.Drawing.Point(16, 516);
            this.btn_Hoofdstuk.Name = "btn_Hoofdstuk";
            this.btn_Hoofdstuk.Size = new System.Drawing.Size(86, 37);
            this.btn_Hoofdstuk.TabIndex = 1;
            this.btn_Hoofdstuk.Text = "Hoofdmenu";
            this.btn_Hoofdstuk.UseVisualStyleBackColor = true;
            // 
            // btn_Verzend
            // 
            this.btn_Verzend.Location = new System.Drawing.Point(16, 463);
            this.btn_Verzend.Name = "btn_Verzend";
            this.btn_Verzend.Size = new System.Drawing.Size(118, 47);
            this.btn_Verzend.TabIndex = 0;
            this.btn_Verzend.Text = "Verzend Bestelling";
            this.btn_Verzend.UseVisualStyleBackColor = true;
            // 
            // btn_Bekijk
            // 
            this.btn_Bekijk.Location = new System.Drawing.Point(140, 463);
            this.btn_Bekijk.Name = "btn_Bekijk";
            this.btn_Bekijk.Size = new System.Drawing.Size(136, 47);
            this.btn_Bekijk.TabIndex = 2;
            this.btn_Bekijk.Text = "Bekijk Bestelling";
            this.btn_Bekijk.UseVisualStyleBackColor = true;
            // 
            // btn_notificatie
            // 
            this.btn_notificatie.Location = new System.Drawing.Point(190, 516);
            this.btn_notificatie.Name = "btn_notificatie";
            this.btn_notificatie.Size = new System.Drawing.Size(86, 37);
            this.btn_notificatie.TabIndex = 3;
            this.btn_notificatie.Text = "Notificaties";
            this.btn_notificatie.UseVisualStyleBackColor = true;
            // 
            // Bediening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 565);
            this.Controls.Add(this.btn_notificatie);
            this.Controls.Add(this.btn_Bekijk);
            this.Controls.Add(this.btn_Verzend);
            this.Controls.Add(this.btn_Hoofdstuk);
            this.Controls.Add(this.tab_Lunch);
            this.Name = "Bediening";
            this.Text = "Bediening";
            this.Load += new System.EventHandler(this.Bediening_Load);
            this.tab_Lunch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Lunch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_Hoofdstuk;
        private System.Windows.Forms.Button btn_Verzend;
        private System.Windows.Forms.Button btn_Bekijk;
        private System.Windows.Forms.Button btn_notificatie;
    }
}