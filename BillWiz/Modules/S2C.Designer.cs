namespace BillWiz.UI
{
    partial class S2C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S2C));
            panel8 = new Panel();
            Items_Grid = new DataGridView();
            panel9 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            lbl_gross_amt = new Label();
            label30 = new Label();
            gst_lbl = new Label();
            lbl_discount = new Label();
            label17 = new Label();
            label22 = new Label();
            lbl_total_amt = new Label();
            label36 = new Label();
            discount_txt = new TextBox();
            label28 = new Label();
            button2 = new Button();
            panel12 = new Panel();
            label7 = new Label();
            panel6 = new Panel();
            label16 = new Label();
            label15 = new Label();
            lbl_mrp = new Label();
            REM_QTY = new Label();
            label25 = new Label();
            Pr_name = new Label();
            remainingqty = new Label();
            items_by_category = new ComboBox();
            label19 = new Label();
            label23 = new Label();
            Add_Btn = new Button();
            HS_code = new Label();
            QTY_TXT = new TextBox();
            amt_TXT = new TextBox();
            label26 = new Label();
            label27 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            City_txt = new TextBox();
            mail_txt = new TextBox();
            phno_txt = new TextBox();
            Name_txt = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button6 = new Button();
            CLR_Btn = new Button();
            DSBD_Btn = new Button();
            label2 = new Label();
            panel2 = new Panel();
            gstn_lbl = new Label();
            label14 = new Label();
            DAY_LBL = new Label();
            DT_LBL = new Label();
            Shpnm_lbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            S_NO = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            igst_c = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            DeleteButtonColumn = new DataGridViewButtonColumn();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Items_Grid).BeginInit();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(Items_Grid);
            panel8.Controls.Add(panel9);
            panel8.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel8.Location = new Point(8, 456);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(1920, 393);
            panel8.TabIndex = 28;
            // 
            // Items_Grid
            // 
            Items_Grid.AllowUserToAddRows = false;
            Items_Grid.AllowUserToDeleteRows = false;
            Items_Grid.AllowUserToOrderColumns = true;
            Items_Grid.AllowUserToResizeColumns = false;
            Items_Grid.AllowUserToResizeRows = false;
            Items_Grid.BackgroundColor = Color.White;
            Items_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items_Grid.Columns.AddRange(new DataGridViewColumn[] { S_NO, Column7, Column8, Column9, Column10, Column11, Column12, Column2, Column1, Column13, Column14, igst_c, Column16, Column3, Column4, Column5, Column6, Column15, DeleteButtonColumn });
            Items_Grid.Location = new Point(0, 55);
            Items_Grid.Name = "Items_Grid";
            Items_Grid.RowHeadersWidth = 51;
            Items_Grid.RowTemplate.Height = 29;
            Items_Grid.Size = new Size(1912, 333);
            Items_Grid.TabIndex = 22;
            Items_Grid.CellContentClick += Items_Grid_CellContentClick;
            Items_Grid.CellValidating += Items_Grid_CellValidating;
            Items_Grid.CellValueChanged += Items_Grid_CellValueChanged;
            Items_Grid.RowsAdded += Items_Grid_RowsAdded;
            Items_Grid.RowsRemoved += Items_Grid_RowsRemoved;
            Items_Grid.KeyDown += Items_Grid_KeyDown;
            // 
            // panel9
            // 
            panel9.BackColor = Color.SkyBlue;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label6);
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(8, 2, 8, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(1920, 55);
            panel9.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 16);
            label6.Margin = new Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 22);
            label6.TabIndex = 0;
            label6.Text = "Added Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 11);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 0;
            label3.Text = "Sale";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SkyBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(242, 70);
            panel5.Margin = new Padding(8, 2, 8, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1678, 50);
            panel5.TabIndex = 33;
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
            panel11.TabIndex = 22;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(lbl_gross_amt);
            panel10.Controls.Add(label30);
            panel10.Controls.Add(gst_lbl);
            panel10.Controls.Add(lbl_discount);
            panel10.Controls.Add(label17);
            panel10.Controls.Add(label22);
            panel10.Controls.Add(lbl_total_amt);
            panel10.Controls.Add(label36);
            panel10.Controls.Add(discount_txt);
            panel10.Controls.Add(label28);
            panel10.Controls.Add(button2);
            panel10.Controls.Add(panel12);
            panel10.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel10.Location = new Point(8, 864);
            panel10.Name = "panel10";
            panel10.Size = new Size(1912, 113);
            panel10.TabIndex = 37;
            // 
            // lbl_gross_amt
            // 
            lbl_gross_amt.AutoSize = true;
            lbl_gross_amt.Location = new Point(433, 68);
            lbl_gross_amt.Name = "lbl_gross_amt";
            lbl_gross_amt.Size = new Size(121, 22);
            lbl_gross_amt.TabIndex = 53;
            lbl_gross_amt.Text = "Tax_amount";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(918, 68);
            label30.Name = "label30";
            label30.Size = new Size(123, 22);
            label30.TabIndex = 42;
            label30.Text = "GST Tax[+]:";
            // 
            // gst_lbl
            // 
            gst_lbl.AutoSize = true;
            gst_lbl.Location = new Point(1047, 68);
            gst_lbl.Name = "gst_lbl";
            gst_lbl.Size = new Size(121, 22);
            gst_lbl.TabIndex = 43;
            gst_lbl.Text = "Tax_amount";
            // 
            // lbl_discount
            // 
            lbl_discount.AutoSize = true;
            lbl_discount.Location = new Point(752, 68);
            lbl_discount.Name = "lbl_discount";
            lbl_discount.Size = new Size(134, 22);
            lbl_discount.TabIndex = 51;
            lbl_discount.Text = "Total_Amount";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(578, 68);
            label17.Name = "label17";
            label17.Size = new Size(168, 22);
            label17.TabIndex = 50;
            label17.Text = "Discount Total[-]:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(315, 68);
            label22.Name = "label22";
            label22.Size = new Size(112, 22);
            label22.TabIndex = 52;
            label22.Text = "Gross Amt:";
            // 
            // lbl_total_amt
            // 
            lbl_total_amt.AutoSize = true;
            lbl_total_amt.Location = new Point(1336, 68);
            lbl_total_amt.Name = "lbl_total_amt";
            lbl_total_amt.Size = new Size(134, 22);
            lbl_total_amt.TabIndex = 49;
            lbl_total_amt.Text = "Total_Amount";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(1208, 68);
            label36.Name = "label36";
            label36.Size = new Size(122, 22);
            label36.TabIndex = 48;
            label36.Text = "Grand Total:";
            // 
            // discount_txt
            // 
            discount_txt.BorderStyle = BorderStyle.FixedSingle;
            discount_txt.Location = new Point(96, 66);
            discount_txt.Name = "discount_txt";
            discount_txt.Size = new Size(177, 29);
            discount_txt.TabIndex = 41;
            discount_txt.TextChanged += discount_txt_TextChanged;
            discount_txt.KeyPress += discount_txt_KeyPress;
            discount_txt.Leave += discount_txt_Leave;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(3, 68);
            label28.Name = "label28";
            label28.Size = new Size(95, 22);
            label28.TabIndex = 40;
            label28.Text = "Discount:";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.CornflowerBlue;
            button2.Location = new Point(1720, 62);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(152, 41);
            button2.TabIndex = 20;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(lbl_mrp);
            panel6.Controls.Add(REM_QTY);
            panel6.Controls.Add(label25);
            panel6.Controls.Add(Pr_name);
            panel6.Controls.Add(remainingqty);
            panel6.Controls.Add(items_by_category);
            panel6.Controls.Add(label19);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(Add_Btn);
            panel6.Controls.Add(HS_code);
            panel6.Controls.Add(QTY_TXT);
            panel6.Controls.Add(amt_TXT);
            panel6.Controls.Add(label26);
            panel6.Controls.Add(label27);
            panel6.Controls.Add(panel7);
            panel6.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(242, 297);
            panel6.Name = "panel6";
            panel6.Size = new Size(1679, 144);
            panel6.TabIndex = 38;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(81, 64);
            label16.Name = "label16";
            label16.Size = new Size(95, 22);
            label16.TabIndex = 47;
            label16.Text = "Products:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(790, 112);
            label15.Name = "label15";
            label15.Size = new Size(57, 22);
            label15.TabIndex = 45;
            label15.Text = "MRP:";
            // 
            // lbl_mrp
            // 
            lbl_mrp.AutoSize = true;
            lbl_mrp.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mrp.Location = new Point(853, 112);
            lbl_mrp.Name = "lbl_mrp";
            lbl_mrp.Size = new Size(56, 22);
            lbl_mrp.TabIndex = 46;
            lbl_mrp.Text = "NULL";
            // 
            // REM_QTY
            // 
            REM_QTY.AutoSize = true;
            REM_QTY.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            REM_QTY.Location = new Point(1077, 112);
            REM_QTY.Name = "REM_QTY";
            REM_QTY.Size = new Size(56, 22);
            REM_QTY.TabIndex = 44;
            REM_QTY.Text = "NULL";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(87, 111);
            label25.Name = "label25";
            label25.Size = new Size(71, 22);
            label25.TabIndex = 33;
            label25.Text = "Name:";
            // 
            // Pr_name
            // 
            Pr_name.AutoSize = true;
            Pr_name.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Pr_name.Location = new Point(164, 112);
            Pr_name.Name = "Pr_name";
            Pr_name.Size = new Size(56, 22);
            Pr_name.TabIndex = 34;
            Pr_name.Text = "NULL";
            // 
            // remainingqty
            // 
            remainingqty.AutoSize = true;
            remainingqty.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            remainingqty.Location = new Point(959, 112);
            remainingqty.Name = "remainingqty";
            remainingqty.Size = new Size(107, 22);
            remainingqty.TabIndex = 43;
            remainingqty.Text = "Rem. QTY:";
            // 
            // items_by_category
            // 
            items_by_category.Cursor = Cursors.Hand;
            items_by_category.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            items_by_category.FormattingEnabled = true;
            items_by_category.Location = new Point(182, 61);
            items_by_category.Name = "items_by_category";
            items_by_category.Size = new Size(752, 30);
            items_by_category.TabIndex = 42;
            items_by_category.SelectedIndexChanged += items_by_category_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(3, 64);
            label19.Name = "label19";
            label19.Size = new Size(80, 22);
            label19.TabIndex = 22;
            label19.Text = "Search:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(959, 67);
            label23.Name = "label23";
            label23.Size = new Size(102, 22);
            label23.TabIndex = 35;
            label23.Text = "HSN/SAC:";
            // 
            // Add_Btn
            // 
            Add_Btn.Cursor = Cursors.Hand;
            Add_Btn.FlatAppearance.BorderColor = Color.CornflowerBlue;
            Add_Btn.FlatStyle = FlatStyle.Flat;
            Add_Btn.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Add_Btn.ForeColor = Color.CornflowerBlue;
            Add_Btn.Location = new Point(1500, 77);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.RightToLeft = RightToLeft.No;
            Add_Btn.Size = new Size(138, 41);
            Add_Btn.TabIndex = 41;
            Add_Btn.Text = "Add";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // HS_code
            // 
            HS_code.AutoSize = true;
            HS_code.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            HS_code.Location = new Point(1067, 66);
            HS_code.Name = "HS_code";
            HS_code.Size = new Size(56, 22);
            HS_code.TabIndex = 36;
            HS_code.Text = "NULL";
            // 
            // QTY_TXT
            // 
            QTY_TXT.BorderStyle = BorderStyle.FixedSingle;
            QTY_TXT.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            QTY_TXT.Location = new Point(1273, 109);
            QTY_TXT.Name = "QTY_TXT";
            QTY_TXT.Size = new Size(177, 29);
            QTY_TXT.TabIndex = 40;
            QTY_TXT.KeyPress += QTY_TXT_KeyPress;
            // 
            // amt_TXT
            // 
            amt_TXT.BorderStyle = BorderStyle.FixedSingle;
            amt_TXT.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            amt_TXT.Location = new Point(1273, 62);
            amt_TXT.Name = "amt_TXT";
            amt_TXT.Size = new Size(177, 29);
            amt_TXT.TabIndex = 39;
            amt_TXT.KeyPress += amt_TXT_KeyPress;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(1215, 111);
            label26.Name = "label26";
            label26.Size = new Size(52, 22);
            label26.TabIndex = 38;
            label26.Text = "QTY:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(1207, 64);
            label27.Name = "label27";
            label27.Size = new Size(54, 22);
            label27.TabIndex = 37;
            label27.Text = "AMT:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SkyBlue;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label5);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(6, 2, 6, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(1677, 54);
            panel7.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 16);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 22);
            label5.TabIndex = 0;
            label5.Text = "Add Product";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(City_txt);
            panel4.Controls.Add(mail_txt);
            panel4.Controls.Add(phno_txt);
            panel4.Controls.Add(Name_txt);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(panel3);
            panel4.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(242, 135);
            panel4.Name = "panel4";
            panel4.Size = new Size(1678, 144);
            panel4.TabIndex = 39;
            // 
            // City_txt
            // 
            City_txt.BorderStyle = BorderStyle.FixedSingle;
            City_txt.Location = new Point(853, 109);
            City_txt.Name = "City_txt";
            City_txt.Size = new Size(568, 29);
            City_txt.TabIndex = 45;
            // 
            // mail_txt
            // 
            mail_txt.BorderStyle = BorderStyle.FixedSingle;
            mail_txt.Location = new Point(853, 63);
            mail_txt.Name = "mail_txt";
            mail_txt.Size = new Size(568, 29);
            mail_txt.TabIndex = 44;
            // 
            // phno_txt
            // 
            phno_txt.BorderStyle = BorderStyle.FixedSingle;
            phno_txt.Location = new Point(100, 109);
            phno_txt.Name = "phno_txt";
            phno_txt.Size = new Size(552, 29);
            phno_txt.TabIndex = 43;
            // 
            // Name_txt
            // 
            Name_txt.BorderStyle = BorderStyle.FixedSingle;
            Name_txt.Location = new Point(84, 63);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(568, 29);
            Name_txt.TabIndex = 42;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(793, 111);
            label13.Name = "label13";
            label13.Size = new Size(54, 22);
            label13.TabIndex = 26;
            label13.Text = "City:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(774, 65);
            label12.Name = "label12";
            label12.Size = new Size(73, 22);
            label12.TabIndex = 25;
            label12.Text = "E-Mail:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(7, 111);
            label11.Name = "label11";
            label11.Size = new Size(87, 22);
            label11.TabIndex = 24;
            label11.Text = "Contact:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 65);
            label9.Name = "label9";
            label9.Size = new Size(71, 22);
            label9.TabIndex = 22;
            label9.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(6, 2, 6, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1678, 54);
            panel3.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 16);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 22);
            label1.TabIndex = 0;
            label1.Text = "Customer Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(CLR_Btn);
            panel1.Controls.Add(DSBD_Btn);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(8, 70);
            panel1.Margin = new Padding(6, 2, 6, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 371);
            panel1.TabIndex = 37;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(30, 291);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(152, 41);
            button1.TabIndex = 20;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.CornflowerBlue;
            button6.Location = new Point(30, 142);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(152, 56);
            button6.TabIndex = 19;
            button6.Text = "View Customers";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // CLR_Btn
            // 
            CLR_Btn.Cursor = Cursors.Hand;
            CLR_Btn.FlatAppearance.BorderColor = Color.CornflowerBlue;
            CLR_Btn.FlatStyle = FlatStyle.Flat;
            CLR_Btn.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CLR_Btn.ForeColor = Color.CornflowerBlue;
            CLR_Btn.Location = new Point(30, 225);
            CLR_Btn.Name = "CLR_Btn";
            CLR_Btn.RightToLeft = RightToLeft.No;
            CLR_Btn.Size = new Size(152, 41);
            CLR_Btn.TabIndex = 18;
            CLR_Btn.Text = "Clear";
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
            DSBD_Btn.Location = new Point(30, 73);
            DSBD_Btn.Name = "DSBD_Btn";
            DSBD_Btn.RightToLeft = RightToLeft.No;
            DSBD_Btn.Size = new Size(152, 41);
            DSBD_Btn.TabIndex = 16;
            DSBD_Btn.Text = "Dashboard";
            DSBD_Btn.UseVisualStyleBackColor = true;
            DSBD_Btn.Click += DSBD_Btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(60, 11);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 15;
            label2.Text = "Options";
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
            panel2.Location = new Point(228, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1692, 65);
            panel2.TabIndex = 40;
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
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // S_NO
            // 
            S_NO.FillWeight = 30F;
            S_NO.HeaderText = "S. No";
            S_NO.MinimumWidth = 6;
            S_NO.Name = "S_NO";
            S_NO.ReadOnly = true;
            S_NO.Width = 45;
            // 
            // Column7
            // 
            Column7.HeaderText = "HSN/SAC";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 110;
            // 
            // Column8
            // 
            Column8.HeaderText = "Product Name";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 500;
            // 
            // Column9
            // 
            Column9.HeaderText = "QTY";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "UOM";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 80;
            // 
            // Column11
            // 
            Column11.HeaderText = "MRP";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 115;
            // 
            // Column12
            // 
            Column12.HeaderText = "Rate";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 110;
            // 
            // Column2
            // 
            Column2.HeaderText = "Amount";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column1
            // 
            Column1.HeaderText = "Disc Amt";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 120;
            // 
            // Column13
            // 
            Column13.HeaderText = "CGST";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 110;
            // 
            // Column14
            // 
            Column14.HeaderText = "SGST";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 110;
            // 
            // igst_c
            // 
            igst_c.HeaderText = "IGST";
            igst_c.MinimumWidth = 6;
            igst_c.Name = "igst_c";
            igst_c.Width = 110;
            // 
            // Column16
            // 
            Column16.HeaderText = "Total";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            Column16.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Barcode";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dbo";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "cgstv";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "sgstv";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            Column6.Width = 125;
            // 
            // Column15
            // 
            Column15.HeaderText = "igstv";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Visible = false;
            Column15.Width = 125;
            // 
            // DeleteButtonColumn
            // 
            DeleteButtonColumn.HeaderText = "Delete";
            DeleteButtonColumn.MinimumWidth = 6;
            DeleteButtonColumn.Name = "DeleteButtonColumn";
            DeleteButtonColumn.ReadOnly = true;
            DeleteButtonColumn.Text = "Del";
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            DeleteButtonColumn.Width = 125;
            // 
            // S2C
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1033);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(panel11);
            DoubleBuffered = true;
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "S2C";
            Text = "Export_pgn";
            WindowState = FormWindowState.Maximized;
            FormClosing += Export_pgn_FormClosing;
            Load += Export_pgn_Load;
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Items_Grid).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel8;
        private Panel panel9;
        private Label label6;
        private Label label3;
        private Panel panel5;
        private Panel panel11;
        private Panel panel10;
        private Label label36;
        private Label label30;
        private TextBox discount_txt;
        private Label label28;
        private Button button2;
        private Panel panel12;
        private Label label7;
        private Panel panel6;
        private Button Add_Btn;
        private TextBox QTY_TXT;
        private TextBox amt_TXT;
        private Label label26;
        private Label label27;
        private Label HS_code;
        private Label label23;
        private Label Pr_name;
        private Label label25;
        private Label label19;
        private Panel panel7;
        private Label label5;
        private Panel panel4;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private Panel panel3;
        private Label label1;
        private Panel panel1;
        private Button CLR_Btn;
        private Button DSBD_Btn;
        private Label label2;
        private Panel panel2;
        private Label DAY_LBL;
        private Label DT_LBL;
        private Label Shpnm_lbl;
        private System.Windows.Forms.Timer timer1;
        private Label gstn_lbl;
        private Label label14;
        private ComboBox items_by_category;
        private Label REM_QTY;
        private Label remainingqty;
        private Label label15;
        private Label lbl_mrp;
        private Label label17;
        private Label label22;
        private Label label16;
        public Label lbl_total_amt;
        public Label gst_lbl;
        public Label lbl_discount;
        public Label lbl_gross_amt;
        private TextBox City_txt;
        private TextBox mail_txt;
        private TextBox phno_txt;
        private TextBox Name_txt;
        private Button button1;
        private Button button6;
        private DataGridView Items_Grid;
        private DataGridViewTextBoxColumn S_NO;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn igst_c;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewButtonColumn DeleteButtonColumn;
    }
}