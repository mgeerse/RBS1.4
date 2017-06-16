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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_NotifLunch = new System.Windows.Forms.Button();
            this.btn_VerzendLunch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_NotifDiner = new System.Windows.Forms.Button();
            this.btn_VerzendDiner = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_NotifDrank = new System.Windows.Forms.Button();
            this.btn_VerzendDrank = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Notif_Nonalc = new System.Windows.Forms.Button();
            this.btn_NonOrder = new System.Windows.Forms.Button();
            this.btn_TafelOverzicht = new System.Windows.Forms.Button();
            this.btn_BekijkOrder = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(273, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_NotifLunch);
            this.tabPage1.Controls.Add(this.btn_VerzendLunch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(265, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lunch";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_NotifLunch
            // 
            this.btn_NotifLunch.Location = new System.Drawing.Point(135, 323);
            this.btn_NotifLunch.Name = "btn_NotifLunch";
            this.btn_NotifLunch.Size = new System.Drawing.Size(124, 31);
            this.btn_NotifLunch.TabIndex = 4;
            this.btn_NotifLunch.Text = "Notificatie";
            this.btn_NotifLunch.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendLunch
            // 
            this.btn_VerzendLunch.Location = new System.Drawing.Point(6, 323);
            this.btn_VerzendLunch.Name = "btn_VerzendLunch";
            this.btn_VerzendLunch.Size = new System.Drawing.Size(124, 31);
            this.btn_VerzendLunch.TabIndex = 3;
            this.btn_VerzendLunch.Text = "verzend order";
            this.btn_VerzendLunch.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_NotifDiner);
            this.tabPage2.Controls.Add(this.btn_VerzendDiner);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(265, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_NotifDiner
            // 
            this.btn_NotifDiner.Location = new System.Drawing.Point(135, 323);
            this.btn_NotifDiner.Name = "btn_NotifDiner";
            this.btn_NotifDiner.Size = new System.Drawing.Size(124, 31);
            this.btn_NotifDiner.TabIndex = 3;
            this.btn_NotifDiner.Text = "Notificatie";
            this.btn_NotifDiner.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendDiner
            // 
            this.btn_VerzendDiner.Location = new System.Drawing.Point(6, 323);
            this.btn_VerzendDiner.Name = "btn_VerzendDiner";
            this.btn_VerzendDiner.Size = new System.Drawing.Size(124, 31);
            this.btn_VerzendDiner.TabIndex = 2;
            this.btn_VerzendDiner.Text = "verzend order";
            this.btn_VerzendDiner.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_NotifDrank);
            this.tabPage3.Controls.Add(this.btn_VerzendDrank);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(265, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drank";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_NotifDrank
            // 
            this.btn_NotifDrank.Location = new System.Drawing.Point(135, 323);
            this.btn_NotifDrank.Name = "btn_NotifDrank";
            this.btn_NotifDrank.Size = new System.Drawing.Size(124, 31);
            this.btn_NotifDrank.TabIndex = 2;
            this.btn_NotifDrank.Text = "Notificatie";
            this.btn_NotifDrank.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendDrank
            // 
            this.btn_VerzendDrank.Location = new System.Drawing.Point(6, 323);
            this.btn_VerzendDrank.Name = "btn_VerzendDrank";
            this.btn_VerzendDrank.Size = new System.Drawing.Size(124, 31);
            this.btn_VerzendDrank.TabIndex = 1;
            this.btn_VerzendDrank.Text = "verzend order";
            this.btn_VerzendDrank.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_Notif_Nonalc);
            this.tabPage4.Controls.Add(this.btn_NonOrder);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(265, 360);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Non-alcholol Drank";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_Notif_Nonalc
            // 
            this.btn_Notif_Nonalc.Location = new System.Drawing.Point(135, 323);
            this.btn_Notif_Nonalc.Name = "btn_Notif_Nonalc";
            this.btn_Notif_Nonalc.Size = new System.Drawing.Size(124, 31);
            this.btn_Notif_Nonalc.TabIndex = 1;
            this.btn_Notif_Nonalc.Text = "Notificatie";
            this.btn_Notif_Nonalc.UseVisualStyleBackColor = true;
            // 
            // btn_NonOrder
            // 
            this.btn_NonOrder.Location = new System.Drawing.Point(6, 323);
            this.btn_NonOrder.Name = "btn_NonOrder";
            this.btn_NonOrder.Size = new System.Drawing.Size(110, 31);
            this.btn_NonOrder.TabIndex = 0;
            this.btn_NonOrder.Text = "verzend order";
            this.btn_NonOrder.UseVisualStyleBackColor = true;
            // 
            // btn_TafelOverzicht
            // 
            this.btn_TafelOverzicht.Location = new System.Drawing.Point(13, 404);
            this.btn_TafelOverzicht.Name = "btn_TafelOverzicht";
            this.btn_TafelOverzicht.Size = new System.Drawing.Size(121, 25);
            this.btn_TafelOverzicht.TabIndex = 0;
            this.btn_TafelOverzicht.Text = "TafelOverzicht";
            this.btn_TafelOverzicht.UseVisualStyleBackColor = true;
            this.btn_TafelOverzicht.Click += new System.EventHandler(this.btn_Hoofdmenu_Click);
            // 
            // btn_BekijkOrder
            // 
            this.btn_BekijkOrder.Location = new System.Drawing.Point(165, 404);
            this.btn_BekijkOrder.Name = "btn_BekijkOrder";
            this.btn_BekijkOrder.Size = new System.Drawing.Size(121, 25);
            this.btn_BekijkOrder.TabIndex = 1;
            this.btn_BekijkOrder.Text = "Bekijk";
            this.btn_BekijkOrder.UseVisualStyleBackColor = true;
            // 
            // Bediening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.btn_BekijkOrder);
            this.Controls.Add(this.btn_TafelOverzicht);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bediening";
            this.Text = "Bediening";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_NonOrder;
        private System.Windows.Forms.Button btn_TafelOverzicht;
        private System.Windows.Forms.Button btn_NotifLunch;
        private System.Windows.Forms.Button btn_VerzendLunch;
        private System.Windows.Forms.Button btn_NotifDiner;
        private System.Windows.Forms.Button btn_VerzendDiner;
        private System.Windows.Forms.Button btn_NotifDrank;
        private System.Windows.Forms.Button btn_VerzendDrank;
        private System.Windows.Forms.Button btn_Notif_Nonalc;
        private System.Windows.Forms.Button btn_BekijkOrder;
    }
}