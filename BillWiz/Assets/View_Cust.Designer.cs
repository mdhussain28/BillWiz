namespace BillWiz.UI
{
    partial class View_Cust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Cust));
            panel11 = new Panel();
            panel10 = new Panel();
            lbl_gross_amt = new Label();
            label22 = new Label();
            panel12 = new Panel();
            label7 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            CLR_Btn = new Button();
            DSBD_Btn = new Button();
            panel1 = new Panel();
            Retailers_Grid = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label10 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            DAY_LBL = new Label();
            DT_LBL = new Label();
            label4 = new Label();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Retailers_Grid).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightSkyBlue;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel11.Location = new Point(6, 0);
            panel11.Margin = new Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(221, 65);
            panel11.TabIndex = 53;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(lbl_gross_amt);
            panel10.Controls.Add(label22);
            panel10.Controls.Add(panel12);
            panel10.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel10.Location = new Point(6, 856);
            panel10.Name = "panel10";
            panel10.Size = new Size(1912, 113);
            panel10.TabIndex = 57;
            // 
            // lbl_gross_amt
            // 
            lbl_gross_amt.AutoSize = true;
            lbl_gross_amt.Location = new Point(119, 71);
            lbl_gross_amt.Name = "lbl_gross_amt";
            lbl_gross_amt.Size = new Size(121, 22);
            lbl_gross_amt.TabIndex = 53;
            lbl_gross_amt.Text = "Tax_amount";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(7, 71);
            label22.Name = "label22";
            label22.Size = new Size(106, 22);
            label22.TabIndex = 52;
            label22.Text = "Total Sale:";
            // 
            // panel12
            // 
            panel12.BackColor = Color.SkyBlue;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(label7);
            panel12.Location = new Point(0, 0);
            panel12.Margin = new Padding(6, 2, 6, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(1920, 54);
            panel12.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 16);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 22);
            label7.TabIndex = 0;
            label7.Text = "Overview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 11);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 22);
            label3.TabIndex = 0;
            label3.Text = "All Customer Data";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SkyBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(235, 70);
            panel5.Margin = new Padding(8, 2, 8, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1675, 50);
            panel5.TabIndex = 54;
            // 
            // CLR_Btn
            // 
            CLR_Btn.Cursor = Cursors.Hand;
            CLR_Btn.FlatAppearance.BorderColor = Color.CornflowerBlue;
            CLR_Btn.FlatStyle = FlatStyle.Flat;
            CLR_Btn.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CLR_Btn.ForeColor = Color.CornflowerBlue;
            CLR_Btn.Location = new Point(26, 73);
            CLR_Btn.Name = "CLR_Btn";
            CLR_Btn.RightToLeft = RightToLeft.No;
            CLR_Btn.Size = new Size(152, 41);
            CLR_Btn.TabIndex = 18;
            CLR_Btn.Text = "Sell Page";
            CLR_Btn.UseVisualStyleBackColor = true;
            CLR_Btn.Click += CLR_Btn_Click;
            // 
            // DSBD_Btn
            // 
            DSBD_Btn.Cursor = Cursors.Hand;
            DSBD_Btn.FlatAppearance.BorderColor = Color.CornflowerBlue;
            DSBD_Btn.FlatStyle = FlatStyle.Flat;
            DSBD_Btn.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            DSBD_Btn.ForeColor = Color.CornflowerBlue;
            DSBD_Btn.Location = new Point(26, 15);
            DSBD_Btn.Name = "DSBD_Btn";
            DSBD_Btn.RightToLeft = RightToLeft.No;
            DSBD_Btn.Size = new Size(152, 41);
            DSBD_Btn.TabIndex = 16;
            DSBD_Btn.Text = "Dashboard";
            DSBD_Btn.UseVisualStyleBackColor = true;
            DSBD_Btn.Click += DSBD_Btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Retailers_Grid);
            panel1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(6, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 645);
            panel1.TabIndex = 52;
            // 
            // Retailers_Grid
            // 
            Retailers_Grid.BackgroundColor = Color.White;
            Retailers_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Retailers_Grid.Columns.AddRange(new DataGridViewColumn[] { Column2, Column4, Column5, Column6, Column8, Column1, Column11 });
            Retailers_Grid.GridColor = Color.Black;
            Retailers_Grid.Location = new Point(0, 0);
            Retailers_Grid.Name = "Retailers_Grid";
            Retailers_Grid.RowHeadersWidth = 51;
            Retailers_Grid.RowTemplate.Height = 29;
            Retailers_Grid.Size = new Size(1904, 645);
            Retailers_Grid.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 600;
            // 
            // Column4
            // 
            Column4.HeaderText = "Pnone No.";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mail I'd";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 250;
            // 
            // Column6
            // 
            Column6.HeaderText = "City";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 250;
            // 
            // Column8
            // 
            Column8.HeaderText = "Total Items Purchased Amt";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 180;
            // 
            // Column1
            // 
            Column1.HeaderText = "Total GST";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "Acc. Create Date";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 150;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(CLR_Btn);
            panel3.Controls.Add(DSBD_Btn);
            panel3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(6, 70);
            panel3.Margin = new Padding(6, 2, 6, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 130);
            panel3.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(746, 20);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(214, 25);
            label10.TabIndex = 17;
            label10.Text = "11AAAAA2222A1Z5";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(627, 20);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(111, 25);
            label14.TabIndex = 16;
            label14.Text = "GST No. :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(DAY_LBL);
            panel2.Controls.Add(DT_LBL);
            panel2.Controls.Add(label4);
            panel2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(227, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1683, 65);
            panel2.TabIndex = 56;
            // 
            // DAY_LBL
            // 
            DAY_LBL.AutoSize = true;
            DAY_LBL.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            DAY_LBL.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            DAY_LBL.Location = new Point(1493, 31);
            DAY_LBL.Margin = new Padding(4, 0, 4, 0);
            DAY_LBL.Name = "DAY_LBL";
            DAY_LBL.Size = new Size(114, 22);
            DAY_LBL.TabIndex = 15;
            DAY_LBL.Text = "Todays Day";
            // 
            // DT_LBL
            // 
            DT_LBL.AutoSize = true;
            DT_LBL.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            DT_LBL.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            DT_LBL.Location = new Point(1422, 8);
            DT_LBL.Margin = new Padding(4, 0, 4, 0);
            DT_LBL.Name = "DT_LBL";
            DT_LBL.Size = new Size(222, 22);
            DT_LBL.TabIndex = 14;
            DT_LBL.Text = " DD/MM/YY  HH:MM:SS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 20);
            label4.Name = "label4";
            label4.Size = new Size(307, 25);
            label4.TabIndex = 0;
            label4.Text = "Enterprize Name, City_Name";
            // 
            // View_Cust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "View_Cust";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Cust";
            WindowState = FormWindowState.Maximized;
            FormClosing += View_Cust_FormClosing;
            Load += View_Cust_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Retailers_Grid).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel11;
        private Panel panel10;
        private Label lbl_gross_amt;
        private Label label22;
        private Panel panel12;
        private Label label7;
        private Label label3;
        private Panel panel5;
        private Button CLR_Btn;
        private Button DSBD_Btn;
        private Panel panel1;
        private DataGridView Retailers_Grid;
        private Panel panel3;
        private Label label10;
        private Label label14;
        private Panel panel2;
        private Label DAY_LBL;
        private Label DT_LBL;
        private Label label4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column11;
    }
}