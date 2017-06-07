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
            this.btn_VerzendNon_Aclohol = new System.Windows.Forms.Button();
            this.btn_Bekijk = new System.Windows.Forms.Button();
            this.btn_Hoofdstuk = new System.Windows.Forms.Button();
            this.btn_Notif_Nondalcohol = new System.Windows.Forms.Button();
            this.btn_VerzendDrank = new System.Windows.Forms.Button();
            this.btn_VerzendDiner = new System.Windows.Forms.Button();
            this.btn_VerzendLunch = new System.Windows.Forms.Button();
            this.btn_Noctif_Drank = new System.Windows.Forms.Button();
            this.btn_Notif_Diner = new System.Windows.Forms.Button();
            this.btn_Notif_Lunch = new System.Windows.Forms.Button();
            this.List_NonAlcohol = new System.Windows.Forms.ListBox();
            this.List_Drank = new System.Windows.Forms.ListBox();
            this.List_Diner = new System.Windows.Forms.ListBox();
            this.List_Lunch = new System.Windows.Forms.ListBox();
            this.List_Bestelling = new System.Windows.Forms.ListBox();
            this.tab_Lunch.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.List_Lunch);
            this.tabPage1.Controls.Add(this.btn_Notif_Lunch);
            this.tabPage1.Controls.Add(this.btn_VerzendLunch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lunch";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.List_Diner);
            this.tabPage2.Controls.Add(this.btn_Notif_Diner);
            this.tabPage2.Controls.Add(this.btn_VerzendDiner);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(260, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.List_Drank);
            this.tabPage3.Controls.Add(this.btn_Noctif_Drank);
            this.tabPage3.Controls.Add(this.btn_VerzendDrank);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(260, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "drank-alcohol";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.List_NonAlcohol);
            this.tabPage4.Controls.Add(this.btn_Notif_Nondalcohol);
            this.tabPage4.Controls.Add(this.btn_VerzendNon_Aclohol);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(260, 373);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "drank-nonalcohol";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendNon_Aclohol
            // 
            this.btn_VerzendNon_Aclohol.Location = new System.Drawing.Point(3, 320);
            this.btn_VerzendNon_Aclohol.Name = "btn_VerzendNon_Aclohol";
            this.btn_VerzendNon_Aclohol.Size = new System.Drawing.Size(106, 47);
            this.btn_VerzendNon_Aclohol.TabIndex = 0;
            this.btn_VerzendNon_Aclohol.Text = "Verzend Bestelling";
            this.btn_VerzendNon_Aclohol.UseVisualStyleBackColor = true;
            // 
            // btn_Bekijk
            // 
            this.btn_Bekijk.Location = new System.Drawing.Point(146, 486);
            this.btn_Bekijk.Name = "btn_Bekijk";
            this.btn_Bekijk.Size = new System.Drawing.Size(130, 67);
            this.btn_Bekijk.TabIndex = 2;
            this.btn_Bekijk.Text = "Bekijk Bestelling";
            this.btn_Bekijk.UseVisualStyleBackColor = true;
            this.btn_Bekijk.Click += new System.EventHandler(this.btn_Bekijk_Click);
            // 
            // btn_Hoofdstuk
            // 
            this.btn_Hoofdstuk.Location = new System.Drawing.Point(16, 486);
            this.btn_Hoofdstuk.Name = "btn_Hoofdstuk";
            this.btn_Hoofdstuk.Size = new System.Drawing.Size(109, 67);
            this.btn_Hoofdstuk.TabIndex = 1;
            this.btn_Hoofdstuk.Text = "Hoofdmenu";
            this.btn_Hoofdstuk.UseVisualStyleBackColor = true;
            // 
            // btn_Notif_Nondalcohol
            // 
            this.btn_Notif_Nondalcohol.Location = new System.Drawing.Point(130, 320);
            this.btn_Notif_Nondalcohol.Name = "btn_Notif_Nondalcohol";
            this.btn_Notif_Nondalcohol.Size = new System.Drawing.Size(124, 47);
            this.btn_Notif_Nondalcohol.TabIndex = 3;
            this.btn_Notif_Nondalcohol.Text = "Notificaties";
            this.btn_Notif_Nondalcohol.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendDrank
            // 
            this.btn_VerzendDrank.Location = new System.Drawing.Point(6, 320);
            this.btn_VerzendDrank.Name = "btn_VerzendDrank";
            this.btn_VerzendDrank.Size = new System.Drawing.Size(106, 47);
            this.btn_VerzendDrank.TabIndex = 1;
            this.btn_VerzendDrank.Text = "Verzend Bestelling";
            this.btn_VerzendDrank.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendDiner
            // 
            this.btn_VerzendDiner.Location = new System.Drawing.Point(6, 320);
            this.btn_VerzendDiner.Name = "btn_VerzendDiner";
            this.btn_VerzendDiner.Size = new System.Drawing.Size(106, 47);
            this.btn_VerzendDiner.TabIndex = 1;
            this.btn_VerzendDiner.Text = "Verzend Bestelling";
            this.btn_VerzendDiner.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendLunch
            // 
            this.btn_VerzendLunch.Location = new System.Drawing.Point(6, 320);
            this.btn_VerzendLunch.Name = "btn_VerzendLunch";
            this.btn_VerzendLunch.Size = new System.Drawing.Size(106, 47);
            this.btn_VerzendLunch.TabIndex = 1;
            this.btn_VerzendLunch.Text = "Verzend Bestelling";
            this.btn_VerzendLunch.UseVisualStyleBackColor = true;
            // 
            // btn_Noctif_Drank
            // 
            this.btn_Noctif_Drank.Location = new System.Drawing.Point(130, 320);
            this.btn_Noctif_Drank.Name = "btn_Noctif_Drank";
            this.btn_Noctif_Drank.Size = new System.Drawing.Size(124, 47);
            this.btn_Noctif_Drank.TabIndex = 4;
            this.btn_Noctif_Drank.Text = "Notificaties";
            this.btn_Noctif_Drank.UseVisualStyleBackColor = true;
            // 
            // btn_Notif_Diner
            // 
            this.btn_Notif_Diner.Location = new System.Drawing.Point(130, 320);
            this.btn_Notif_Diner.Name = "btn_Notif_Diner";
            this.btn_Notif_Diner.Size = new System.Drawing.Size(124, 47);
            this.btn_Notif_Diner.TabIndex = 4;
            this.btn_Notif_Diner.Text = "Notificaties";
            this.btn_Notif_Diner.UseVisualStyleBackColor = true;
            // 
            // btn_Notif_Lunch
            // 
            this.btn_Notif_Lunch.Location = new System.Drawing.Point(130, 320);
            this.btn_Notif_Lunch.Name = "btn_Notif_Lunch";
            this.btn_Notif_Lunch.Size = new System.Drawing.Size(124, 47);
            this.btn_Notif_Lunch.TabIndex = 4;
            this.btn_Notif_Lunch.Text = "Notificaties";
            this.btn_Notif_Lunch.UseVisualStyleBackColor = true;
            // 
            // List_NonAlcohol
            // 
            this.List_NonAlcohol.FormattingEnabled = true;
            this.List_NonAlcohol.Location = new System.Drawing.Point(6, 18);
            this.List_NonAlcohol.Name = "List_NonAlcohol";
            this.List_NonAlcohol.Size = new System.Drawing.Size(248, 290);
            this.List_NonAlcohol.TabIndex = 4;
            // 
            // List_Drank
            // 
            this.List_Drank.FormattingEnabled = true;
            this.List_Drank.Location = new System.Drawing.Point(6, 15);
            this.List_Drank.Name = "List_Drank";
            this.List_Drank.Size = new System.Drawing.Size(248, 303);
            this.List_Drank.TabIndex = 5;
            // 
            // List_Diner
            // 
            this.List_Diner.FormattingEnabled = true;
            this.List_Diner.Location = new System.Drawing.Point(6, 15);
            this.List_Diner.Name = "List_Diner";
            this.List_Diner.Size = new System.Drawing.Size(248, 303);
            this.List_Diner.TabIndex = 5;
            // 
            // List_Lunch
            // 
            this.List_Lunch.FormattingEnabled = true;
            this.List_Lunch.Location = new System.Drawing.Point(6, 15);
            this.List_Lunch.Name = "List_Lunch";
            this.List_Lunch.Size = new System.Drawing.Size(248, 303);
            this.List_Lunch.TabIndex = 5;
            // 
            // List_Bestelling
            // 
            this.List_Bestelling.FormattingEnabled = true;
            this.List_Bestelling.Location = new System.Drawing.Point(16, 13);
            this.List_Bestelling.Name = "List_Bestelling";
            this.List_Bestelling.Size = new System.Drawing.Size(257, 446);
            this.List_Bestelling.TabIndex = 3;
            // 
            // Bediening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 565);
            this.Controls.Add(this.btn_Bekijk);
            this.Controls.Add(this.btn_Hoofdstuk);
            this.Controls.Add(this.tab_Lunch);
            this.Controls.Add(this.List_Bestelling);
            this.Name = "Bediening";
            this.Text = "Bediening";
            this.Load += new System.EventHandler(this.Bediening_Load);
            this.tab_Lunch.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Lunch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_Hoofdstuk;
        private System.Windows.Forms.Button btn_VerzendNon_Aclohol;
        private System.Windows.Forms.Button btn_Bekijk;
        private System.Windows.Forms.Button btn_Notif_Nondalcohol;
        private System.Windows.Forms.Button btn_VerzendLunch;
        private System.Windows.Forms.Button btn_VerzendDiner;
        private System.Windows.Forms.Button btn_VerzendDrank;
        private System.Windows.Forms.Button btn_Notif_Lunch;
        private System.Windows.Forms.Button btn_Notif_Diner;
        private System.Windows.Forms.Button btn_Noctif_Drank;
        private System.Windows.Forms.ListBox List_Lunch;
        private System.Windows.Forms.ListBox List_Diner;
        private System.Windows.Forms.ListBox List_Drank;
        private System.Windows.Forms.ListBox List_NonAlcohol;
        private System.Windows.Forms.ListBox List_Bestelling;
    }
}