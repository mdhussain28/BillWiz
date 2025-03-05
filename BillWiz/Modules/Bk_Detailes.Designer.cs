namespace BillWiz.UI
{
    partial class Bk_Detailes
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
            upiid = new TextBox();
            label7 = new Label();
            button1 = new Button();
            accholder = new TextBox();
            label5 = new Label();
            IFSC = new TextBox();
            Acc_num = new TextBox();
            Bank_Name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // upiid
            // 
            upiid.Location = new Point(13, 461);
            upiid.Margin = new Padding(4, 3, 4, 3);
            upiid.Name = "upiid";
            upiid.Size = new Size(461, 29);
            upiid.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 414);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 22);
            label7.TabIndex = 26;
            label7.Text = "Upi ID:";
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(53, 521);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(361, 47);
            button1.TabIndex = 25;
            button1.Text = "Add New Bank Detailes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // accholder
            // 
            accholder.Location = new Point(13, 372);
            accholder.Margin = new Padding(4, 3, 4, 3);
            accholder.Name = "accholder";
            accholder.Size = new Size(461, 29);
            accholder.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 334);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 22);
            label5.TabIndex = 21;
            label5.Text = "Account Holder:";
            // 
            // IFSC
            // 
            IFSC.Location = new Point(13, 279);
            IFSC.Margin = new Padding(4, 3, 4, 3);
            IFSC.Name = "IFSC";
            IFSC.Size = new Size(461, 29);
            IFSC.TabIndex = 20;
            // 
            // Acc_num
            // 
            Acc_num.Location = new Point(13, 185);
            Acc_num.Margin = new Padding(4, 3, 4, 3);
            Acc_num.Name = "Acc_num";
            Acc_num.Size = new Size(461, 29);
            Acc_num.TabIndex = 19;
            // 
            // Bank_Name
            // 
            Bank_Name.Location = new Point(13, 94);
            Bank_Name.Margin = new Padding(4, 3, 4, 3);
            Bank_Name.Name = "Bank_Name";
            Bank_Name.Size = new Size(461, 29);
            Bank_Name.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 55);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 22);
            label4.TabIndex = 17;
            label4.Text = "Bank Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 22);
            label3.TabIndex = 16;
            label3.Text = "Account Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 232);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 22);
            label2.TabIndex = 15;
            label2.Text = "IFSC Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 14;
            label1.Text = "Add New Bank Details";
            // 
            // Bk_Detailes
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 596);
            Controls.Add(upiid);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(accholder);
            Controls.Add(label5);
            Controls.Add(IFSC);
            Controls.Add(Acc_num);
            Controls.Add(Bank_Name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bk_Detailes";
            Text = "Bk_Detailes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox upiid;
        private Label label7;
        private Button button1;
        private TextBox accholder;
        private Label label5;
        private TextBox IFSC;
        private TextBox Acc_num;
        private TextBox Bank_Name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}