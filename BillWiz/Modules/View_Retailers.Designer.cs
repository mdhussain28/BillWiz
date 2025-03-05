namespace BillWiz.UI
{
    partial class View_Retailers
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Retailers));
            lbl_gross_amt = new Label();
            label7 = new Label();
            Retailers_Grid = new DataGridView();
            Cust_id_column = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            EditButtonColumn = new DataGridViewButtonColumn();
            panel2 = new Panel();
            gstn_lbl = new Label();
            label14 = new Label();
            DAY_LBL = new Label();
            DT_LBL = new Label();
            Shpnm_lbl = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            Add_Retailer = new Button();
            DSBD_Btn = new Button();
            label22 = new Label();
            lbl_in = new Label();
            label36 = new Label();
            panel12 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            panel10 = new Panel();
            lbl_out = new Label();
            label2 = new Label();
            panel11 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Retailers_Grid).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
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
            // Retailers_Grid
            // 
            Retailers_Grid.BackgroundColor = Color.White;
            Retailers_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Retailers_Grid.Columns.AddRange(new DataGridViewColumn[] { Cust_id_column, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, EditButtonColumn });
            Retailers_Grid.GridColor = Color.Black;
            Retailers_Grid.Location = new Point(0, 0);
            Retailers_Grid.Name = "Retailers_Grid";
            Retailers_Grid.RowHeadersWidth = 51;
            Retailers_Grid.RowTemplate.Height = 29;
            Retailers_Grid.Size = new Size(1904, 645);
            Retailers_Grid.TabIndex = 0;
            Retailers_Grid.CellContentClick += Retailers_Grid_CellContentClick;
            // 
            // Cust_id_column
            // 
            Cust_id_column.HeaderText = "Cust I'd";
            Cust_id_column.MinimumWidth = 6;
            Cust_id_column.Name = "Cust_id_column";
            Cust_id_column.ReadOnly = true;
            Cust_id_column.Width = 70;
            // 
            // Column2
            // 
            Column2.HeaderText = "Shop Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 400;
            // 
            // Column3
            // 
            Column3.HeaderText = "Owner Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 300;
            // 
            // Column4
            // 
            Column4.HeaderText = "Pnone No.";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mail I'd";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "City";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 140;
            // 
            // Column7
            // 
            Column7.HeaderText = "Total Item Purchased";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            Column7.Width = 115;
            // 
            // Column8
            // 
            Column8.HeaderText = "Total Items Purchased Amt";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 160;
            // 
            // Column9
            // 
            Column9.HeaderText = "Inward Amt";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 150;
            // 
            // Column10
            // 
            Column10.HeaderText = "Outward Amt";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 120;
            // 
            // Column11
            // 
            Column11.HeaderText = "Acc. Create Date";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 150;
            // 
            // EditButtonColumn
            // 
            EditButtonColumn.HeaderText = "Edit";
            EditButtonColumn.MinimumWidth = 6;
            EditButtonColumn.Name = "EditButtonColumn";
            EditButtonColumn.ReadOnly = true;
            EditButtonColumn.Text = "Edit";
            EditButtonColumn.UseColumnTextForButtonValue = true;
            EditButtonColumn.Width = 50;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(gstn_lbl);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(DAY_LBL);
            panel2.Controls.Add(DT_LBL);
            panel2.Controls.Add(Shpnm_lbl);
            panel2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(229, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1683, 65);
            panel2.TabIndex = 50;
            // 
            // gstn_lbl
            // 
            gstn_lbl.AutoSize = true;
            gstn_lbl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gstn_lbl.Location = new Point(746, 20);
            gstn_lbl.Margin = new Padding(4, 0, 4, 0);
            gstn_lbl.Name = "gstn_lbl";
            gstn_lbl.Size = new Size(214, 25);
            gstn_lbl.TabIndex = 17;
            gstn_lbl.Text = "11AAAAA2222A1Z5";
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
            // Shpnm_lbl
            // 
            Shpnm_lbl.AutoSize = true;
            Shpnm_lbl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Shpnm_lbl.Location = new Point(7, 20);
            Shpnm_lbl.Name = "Shpnm_lbl";
            Shpnm_lbl.Size = new Size(307, 25);
            Shpnm_lbl.TabIndex = 0;
            Shpnm_lbl.Text = "Enterprize Name, City_Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Retailers_Grid);
            panel1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(8, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 645);
            panel1.TabIndex = 46;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(Add_Retailer);
            panel3.Controls.Add(DSBD_Btn);
            panel3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(8, 70);
            panel3.Margin = new Padding(6, 2, 6, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 130);
            panel3.TabIndex = 49;
            // 
            // Add_Retailer
            // 
            Add_Retailer.Cursor = Cursors.Hand;
            Add_Retailer.FlatAppearance.BorderColor = Color.CornflowerBlue;
            Add_Retailer.FlatStyle = FlatStyle.Flat;
            Add_Retailer.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Add_Retailer.ForeColor = Color.CornflowerBlue;
            Add_Retailer.Location = new Point(26, 73);
            Add_Retailer.Name = "Add_Retailer";
            Add_Retailer.RightToLeft = RightToLeft.No;
            Add_Retailer.Size = new Size(152, 41);
            Add_Retailer.TabIndex = 18;
            Add_Retailer.Text = "Add Retailer";
            Add_Retailer.UseVisualStyleBackColor = true;
            Add_Retailer.Click += Add_Retailer_Click;
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
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(7, 71);
            label22.Name = "label22";
            label22.Size = new Size(106, 22);
            label22.TabIndex = 52;
            label22.Text = "Total Sale:";
            // 
            // lbl_in
            // 
            lbl_in.AutoSize = true;
            lbl_in.Location = new Point(412, 71);
            lbl_in.Name = "lbl_in";
            lbl_in.Size = new Size(134, 22);
            lbl_in.TabIndex = 49;
            lbl_in.Text = "Total_Amount";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(284, 71);
            label36.Name = "label36";
            label36.Size = new Size(131, 22);
            label36.TabIndex = 48;
            label36.Text = "Total Inward:";
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
            // panel5
            // 
            panel5.BackColor = Color.SkyBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(237, 150);
            panel5.Margin = new Padding(8, 2, 8, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1675, 50);
            panel5.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 11);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(238, 22);
            label3.TabIndex = 0;
            label3.Text = "All Registered Customers";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(lbl_out);
            panel10.Controls.Add(label2);
            panel10.Controls.Add(lbl_gross_amt);
            panel10.Controls.Add(label22);
            panel10.Controls.Add(lbl_in);
            panel10.Controls.Add(label36);
            panel10.Controls.Add(panel12);
            panel10.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel10.Location = new Point(8, 864);
            panel10.Name = "panel10";
            panel10.Size = new Size(1912, 113);
            panel10.TabIndex = 51;
            // 
            // lbl_out
            // 
            lbl_out.AutoSize = true;
            lbl_out.Location = new Point(797, 71);
            lbl_out.Name = "lbl_out";
            lbl_out.Size = new Size(134, 22);
            lbl_out.TabIndex = 55;
            lbl_out.Text = "Total_Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(647, 71);
            label2.Name = "label2";
            label2.Size = new Size(144, 22);
            label2.TabIndex = 54;
            label2.Text = "Total Outward:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightSkyBlue;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel11.Location = new Point(8, 0);
            panel11.Margin = new Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(221, 65);
            panel11.TabIndex = 47;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // View_Retailers
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel10);
            Controls.Add(panel11);
            DoubleBuffered = true;
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "View_Retailers";
            Text = "View_Retailers";
            WindowState = FormWindowState.Maximized;
            FormClosing += View_Retailers_FormClosing;
            Load += View_Retailers_Load;
            ((System.ComponentModel.ISupportInitialize)Retailers_Grid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_gross_amt;
        private Label label7;
        private DataGridView Retailers_Grid;
        private Panel panel2;
        private Label gstn_lbl;
        private Label label14;
        private Label DAY_LBL;
        private Label DT_LBL;
        private Label Shpnm_lbl;
        private Panel panel1;
        private Panel panel3;
        private Button Add_Retailer;
        private Button DSBD_Btn;
        private Label label22;
        private Label lbl_in;
        private Label label36;
        private Panel panel12;
        private Panel panel5;
        private Label label3;
        private Panel panel10;
        private Panel panel11;
        private Label lbl_out;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Cust_id_column;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewButtonColumn EditButtonColumn;
    }
}