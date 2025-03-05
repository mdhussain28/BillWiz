namespace BillWiz
{
    partial class Login_frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_frm));
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            Login_Btn = new Button();
            PSWD_TXT = new TextBox();
            Shpnm_txt = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 629);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(Login_Btn);
            panel2.Controls.Add(PSWD_TXT);
            panel2.Controls.Add(Shpnm_txt);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(663, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 629);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(184, 507);
            button1.Name = "button1";
            button1.Size = new Size(158, 38);
            button1.TabIndex = 1;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(242, 566);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Login_Btn
            // 
            Login_Btn.FlatAppearance.BorderColor = Color.CornflowerBlue;
            Login_Btn.FlatStyle = FlatStyle.Flat;
            Login_Btn.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Login_Btn.Location = new Point(184, 451);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(158, 38);
            Login_Btn.TabIndex = 0;
            Login_Btn.Text = "Login";
            Login_Btn.UseVisualStyleBackColor = true;
            Login_Btn.Click += Login_Btn_Click;
            // 
            // PSWD_TXT
            // 
            PSWD_TXT.BackColor = Color.LightSkyBlue;
            PSWD_TXT.BorderStyle = BorderStyle.FixedSingle;
            PSWD_TXT.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            PSWD_TXT.Location = new Point(27, 396);
            PSWD_TXT.Name = "PSWD_TXT";
            PSWD_TXT.Size = new Size(472, 29);
            PSWD_TXT.TabIndex = 7;
            PSWD_TXT.UseSystemPasswordChar = true;
            // 
            // Shpnm_txt
            // 
            Shpnm_txt.BackColor = Color.LightSkyBlue;
            Shpnm_txt.BorderStyle = BorderStyle.FixedSingle;
            Shpnm_txt.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Shpnm_txt.Location = new Point(27, 299);
            Shpnm_txt.Name = "Shpnm_txt";
            Shpnm_txt.ReadOnly = true;
            Shpnm_txt.Size = new Size(472, 29);
            Shpnm_txt.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(205, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 360);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 22);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 263);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(236, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // Login_frm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 628);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_frm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PSWD_TXT;
        private TextBox Shpnm_txt;
        private PictureBox pictureBox1;
        private Button Login_Btn;
        private PictureBox pictureBox2;
        private Button button1;
    }
}
