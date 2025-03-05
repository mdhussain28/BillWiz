namespace BillWiz.UI
{
    partial class BillWiz_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillWiz_Info));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            Shpnm_lbl = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Made By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 77);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(273, 22);
            label2.TabIndex = 1;
            label2.Text = "Name: Aditya Vaibhav Pawar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 182);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 22);
            label3.TabIndex = 2;
            label3.Text = "+91 9000000000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 129);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 22);
            label4.TabIndex = 3;
            label4.Text = "Contact Detailes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 236);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 22);
            label5.TabIndex = 4;
            label5.Text = "NA@NA.COM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 53);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 268);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 53);
            panel2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 18);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 0;
            label6.Text = "Sponsered By:";
            // 
            // Shpnm_lbl
            // 
            Shpnm_lbl.AutoSize = true;
            Shpnm_lbl.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Shpnm_lbl.Location = new Point(14, 345);
            Shpnm_lbl.Margin = new Padding(5, 0, 5, 0);
            Shpnm_lbl.Name = "Shpnm_lbl";
            Shpnm_lbl.Size = new Size(0, 22);
            Shpnm_lbl.TabIndex = 6;
            // 
            // BillWiz_Info
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(444, 378);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Shpnm_lbl);
            Controls.Add(label2);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BillWiz_Info";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BillWiz_Info";
            Load += BillWiz_Info_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private Label Shpnm_lbl;
    }
}