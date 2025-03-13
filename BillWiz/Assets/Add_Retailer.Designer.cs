namespace BillWiz.UI
{
    partial class Add_Retailer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Retailer));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Shop_Name = new TextBox();
            Owner_Name = new TextBox();
            Ph_No = new TextBox();
            label5 = new Label();
            Email_id = new TextBox();
            label6 = new Label();
            City = new TextBox();
            button1 = new Button();
            gstn = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 0;
            label1.Text = "Add New Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 274);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 1;
            label2.Text = "Phone no. :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 174);
            label3.Name = "label3";
            label3.Size = new Size(136, 22);
            label3.TabIndex = 2;
            label3.Text = "Owner Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 79);
            label4.Name = "label4";
            label4.Size = new Size(122, 22);
            label4.TabIndex = 3;
            label4.Text = "Shop Name:";
            // 
            // Shop_Name
            // 
            Shop_Name.Location = new Point(22, 113);
            Shop_Name.Name = "Shop_Name";
            Shop_Name.Size = new Size(524, 32);
            Shop_Name.TabIndex = 4;
            // 
            // Owner_Name
            // 
            Owner_Name.Location = new Point(22, 209);
            Owner_Name.Name = "Owner_Name";
            Owner_Name.Size = new Size(524, 32);
            Owner_Name.TabIndex = 5;
            // 
            // Ph_No
            // 
            Ph_No.Location = new Point(22, 321);
            Ph_No.Name = "Ph_No";
            Ph_No.Size = new Size(231, 32);
            Ph_No.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 408);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 7;
            label5.Text = "Email I'd :";
            // 
            // Email_id
            // 
            Email_id.Location = new Point(132, 402);
            Email_id.Name = "Email_id";
            Email_id.Size = new Size(414, 32);
            Email_id.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(315, 274);
            label6.Name = "label6";
            label6.Size = new Size(60, 22);
            label6.TabIndex = 9;
            label6.Text = "City :";
            // 
            // City
            // 
            City.Location = new Point(315, 321);
            City.Name = "City";
            City.Size = new Size(231, 32);
            City.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(22, 531);
            button1.Name = "button1";
            button1.Size = new Size(524, 43);
            button1.TabIndex = 11;
            button1.Text = "Add New Customer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gstn
            // 
            gstn.Location = new Point(132, 462);
            gstn.Name = "gstn";
            gstn.Size = new Size(414, 32);
            gstn.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 468);
            label7.Name = "label7";
            label7.Size = new Size(111, 22);
            label7.TabIndex = 12;
            label7.Text = "GSTN No. :";
            // 
            // Add_Retailer
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(573, 640);
            Controls.Add(gstn);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(City);
            Controls.Add(label6);
            Controls.Add(Email_id);
            Controls.Add(label5);
            Controls.Add(Ph_No);
            Controls.Add(Owner_Name);
            Controls.Add(Shop_Name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_Retailer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Retailer";
            Load += Add_Retailer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Shop_Name;
        private TextBox Owner_Name;
        private TextBox Ph_No;
        private Label label5;
        private TextBox Email_id;
        private Label label6;
        private TextBox City;
        private Button button1;
        private TextBox gstn;
        private Label label7;
    }
}