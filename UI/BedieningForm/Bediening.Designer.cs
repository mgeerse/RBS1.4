﻿namespace UI
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
            this.btn_Hoofdmenu = new System.Windows.Forms.Button();
            this.btn_VerzendLunch = new System.Windows.Forms.Button();
            this.btn_BekijkOrder = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Lijst_Lunch = new System.Windows.Forms.ListBox();
            this.btn_NotifLunch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_NotifDiner = new System.Windows.Forms.Button();
            this.btn_VerzendDiner = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_NotifDrank = new System.Windows.Forms.Button();
            this.btn_VerzendDrank = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_NotifNonAlcohol = new System.Windows.Forms.Button();
            this.btn_Verzend_nonAlcohol = new System.Windows.Forms.Button();
            this.btn_Verberg = new System.Windows.Forms.Button();
            this.Lijst_Diner = new System.Windows.Forms.ListBox();
            this.Lijst_Drank = new System.Windows.Forms.ListBox();
            this.Lijst_NonAlcholol = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Hoofdmenu
            // 
            this.btn_Hoofdmenu.Location = new System.Drawing.Point(12, 482);
            this.btn_Hoofdmenu.Name = "btn_Hoofdmenu";
            this.btn_Hoofdmenu.Size = new System.Drawing.Size(159, 47);
            this.btn_Hoofdmenu.TabIndex = 0;
            this.btn_Hoofdmenu.Text = "Hoofdmenu";
            this.btn_Hoofdmenu.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendLunch
            // 
            this.btn_VerzendLunch.Location = new System.Drawing.Point(6, 380);
            this.btn_VerzendLunch.Name = "btn_VerzendLunch";
            this.btn_VerzendLunch.Size = new System.Drawing.Size(149, 34);
            this.btn_VerzendLunch.TabIndex = 1;
            this.btn_VerzendLunch.Text = "Verzend Order";
            this.btn_VerzendLunch.UseVisualStyleBackColor = true;
            // 
            // btn_BekijkOrder
            // 
            this.btn_BekijkOrder.Location = new System.Drawing.Point(177, 482);
            this.btn_BekijkOrder.Name = "btn_BekijkOrder";
            this.btn_BekijkOrder.Size = new System.Drawing.Size(155, 47);
            this.btn_BekijkOrder.TabIndex = 2;
            this.btn_BekijkOrder.Text = "Bekijk Order";
            this.btn_BekijkOrder.UseVisualStyleBackColor = true;
            this.btn_BekijkOrder.Click += new System.EventHandler(this.btn_BekijkOrder_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 446);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lijst_Lunch);
            this.tabPage1.Controls.Add(this.btn_NotifLunch);
            this.tabPage1.Controls.Add(this.btn_VerzendLunch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(312, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lunch";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Lijst_Lunch
            // 
            this.Lijst_Lunch.FormattingEnabled = true;
            this.Lijst_Lunch.Location = new System.Drawing.Point(6, 149);
            this.Lijst_Lunch.Name = "Lijst_Lunch";
            this.Lijst_Lunch.Size = new System.Drawing.Size(300, 225);
            this.Lijst_Lunch.TabIndex = 3;
            this.Lijst_Lunch.SelectedIndexChanged += new System.EventHandler(this.Lijst_Lunch_SelectedIndexChanged);
            // 
            // btn_NotifLunch
            // 
            this.btn_NotifLunch.Location = new System.Drawing.Point(161, 380);
            this.btn_NotifLunch.Name = "btn_NotifLunch";
            this.btn_NotifLunch.Size = new System.Drawing.Size(145, 34);
            this.btn_NotifLunch.TabIndex = 2;
            this.btn_NotifLunch.Text = "Notificatie";
            this.btn_NotifLunch.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Lijst_Diner);
            this.tabPage2.Controls.Add(this.btn_NotifDiner);
            this.tabPage2.Controls.Add(this.btn_VerzendDiner);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(312, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_NotifDiner
            // 
            this.btn_NotifDiner.Location = new System.Drawing.Point(161, 380);
            this.btn_NotifDiner.Name = "btn_NotifDiner";
            this.btn_NotifDiner.Size = new System.Drawing.Size(145, 34);
            this.btn_NotifDiner.TabIndex = 3;
            this.btn_NotifDiner.Text = "Notificatie";
            this.btn_NotifDiner.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendDiner
            // 
            this.btn_VerzendDiner.Location = new System.Drawing.Point(6, 380);
            this.btn_VerzendDiner.Name = "btn_VerzendDiner";
            this.btn_VerzendDiner.Size = new System.Drawing.Size(149, 34);
            this.btn_VerzendDiner.TabIndex = 2;
            this.btn_VerzendDiner.Text = "Verzend Order";
            this.btn_VerzendDiner.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Lijst_Drank);
            this.tabPage3.Controls.Add(this.btn_NotifDrank);
            this.tabPage3.Controls.Add(this.btn_VerzendDrank);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(312, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drank";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_NotifDrank
            // 
            this.btn_NotifDrank.Location = new System.Drawing.Point(161, 380);
            this.btn_NotifDrank.Name = "btn_NotifDrank";
            this.btn_NotifDrank.Size = new System.Drawing.Size(145, 34);
            this.btn_NotifDrank.TabIndex = 3;
            this.btn_NotifDrank.Text = "Notificatie";
            this.btn_NotifDrank.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendDrank
            // 
            this.btn_VerzendDrank.Location = new System.Drawing.Point(6, 380);
            this.btn_VerzendDrank.Name = "btn_VerzendDrank";
            this.btn_VerzendDrank.Size = new System.Drawing.Size(149, 34);
            this.btn_VerzendDrank.TabIndex = 2;
            this.btn_VerzendDrank.Text = "Verzend Order";
            this.btn_VerzendDrank.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Lijst_NonAlcholol);
            this.tabPage4.Controls.Add(this.btn_NotifNonAlcohol);
            this.tabPage4.Controls.Add(this.btn_Verzend_nonAlcohol);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(312, 420);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Non-alcohol Drank";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_NotifNonAlcohol
            // 
            this.btn_NotifNonAlcohol.Location = new System.Drawing.Point(161, 380);
            this.btn_NotifNonAlcohol.Name = "btn_NotifNonAlcohol";
            this.btn_NotifNonAlcohol.Size = new System.Drawing.Size(145, 34);
            this.btn_NotifNonAlcohol.TabIndex = 3;
            this.btn_NotifNonAlcohol.Text = "Notificatie";
            this.btn_NotifNonAlcohol.UseVisualStyleBackColor = true;
            // 
            // btn_Verzend_nonAlcohol
            // 
            this.btn_Verzend_nonAlcohol.Location = new System.Drawing.Point(6, 380);
            this.btn_Verzend_nonAlcohol.Name = "btn_Verzend_nonAlcohol";
            this.btn_Verzend_nonAlcohol.Size = new System.Drawing.Size(149, 34);
            this.btn_Verzend_nonAlcohol.TabIndex = 2;
            this.btn_Verzend_nonAlcohol.Text = "Verzend Order";
            this.btn_Verzend_nonAlcohol.UseVisualStyleBackColor = true;
            // 
            // btn_Verberg
            // 
            this.btn_Verberg.Location = new System.Drawing.Point(177, 482);
            this.btn_Verberg.Name = "btn_Verberg";
            this.btn_Verberg.Size = new System.Drawing.Size(155, 47);
            this.btn_Verberg.TabIndex = 4;
            this.btn_Verberg.Text = "Verberg Order";
            this.btn_Verberg.UseVisualStyleBackColor = true;
            this.btn_Verberg.Click += new System.EventHandler(this.btn_Verberg_Click);
            // 
            // Lijst_Diner
            // 
            this.Lijst_Diner.FormattingEnabled = true;
            this.Lijst_Diner.Location = new System.Drawing.Point(6, 149);
            this.Lijst_Diner.Name = "Lijst_Diner";
            this.Lijst_Diner.Size = new System.Drawing.Size(300, 225);
            this.Lijst_Diner.TabIndex = 4;
            // 
            // Lijst_Drank
            // 
            this.Lijst_Drank.FormattingEnabled = true;
            this.Lijst_Drank.Location = new System.Drawing.Point(6, 149);
            this.Lijst_Drank.Name = "Lijst_Drank";
            this.Lijst_Drank.Size = new System.Drawing.Size(300, 225);
            this.Lijst_Drank.TabIndex = 4;
            // 
            // Lijst_NonAlcholol
            // 
            this.Lijst_NonAlcholol.FormattingEnabled = true;
            this.Lijst_NonAlcholol.Location = new System.Drawing.Point(6, 149);
            this.Lijst_NonAlcholol.Name = "Lijst_NonAlcholol";
            this.Lijst_NonAlcholol.Size = new System.Drawing.Size(300, 225);
            this.Lijst_NonAlcholol.TabIndex = 4;
            // 
            // Bediening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 541);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Hoofdmenu);
            this.Controls.Add(this.btn_BekijkOrder);
            this.Controls.Add(this.btn_Verberg);
            this.Name = "Bediening";
            this.Text = "Bediening";
            this.Load += new System.EventHandler(this.Bediening_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hoofdmenu;
        private System.Windows.Forms.Button btn_VerzendLunch;
        private System.Windows.Forms.Button btn_BekijkOrder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_NotifLunch;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_NotifDiner;
        private System.Windows.Forms.Button btn_VerzendDiner;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_NotifDrank;
        private System.Windows.Forms.Button btn_VerzendDrank;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_NotifNonAlcohol;
        private System.Windows.Forms.Button btn_Verzend_nonAlcohol;
        private System.Windows.Forms.ListBox Lijst_Lunch;
        private System.Windows.Forms.Button btn_Verberg;
        private System.Windows.Forms.ListBox Lijst_Diner;
        private System.Windows.Forms.ListBox Lijst_Drank;
        private System.Windows.Forms.ListBox Lijst_NonAlcholol;
    }
}