namespace BillWiz.UI
{
    partial class Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            Exit_btn = new Button();
            Reports_btn = new Button();
            Retailers_btn = new Button();
            Inventory_btn = new Button();
            History_btn = new Button();
            label2 = new Label();
            Sell_btn = new Button();
            label1 = new Label();
            Import_btn = new Button();
            Dashboard_btn = new Button();
            Export_btn = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            DAY_LBL = new Label();
            DT_LBL = new Label();
            panel1 = new Panel();
            gstn_lbl = new Label();
            label7 = new Label();
            Shpnm_lbl = new Label();
            label5 = new Label();
            panel4 = new Panel();
            Confirm_import = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            Import_grid = new DataGridView();
            SNO = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            HSN_SAC = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            add_btn = new Button();
            Sim_btn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Confirm_import).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Import_grid).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Exit_btn);
            panel2.Controls.Add(Reports_btn);
            panel2.Controls.Add(Retailers_btn);
            panel2.Controls.Add(Inventory_btn);
            panel2.Controls.Add(History_btn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Sell_btn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Import_btn);
            panel2.Controls.Add(Dashboard_btn);
            panel2.Controls.Add(Export_btn);
            panel2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 75);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 911);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.CornflowerBlue;
            button2.Image = Properties.Resources.business_report;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(50, 739);
            button2.Name = "button2";
            button2.Size = new Size(165, 40);
            button2.TabIndex = 11;
            button2.Text = "     Quotation";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.CornflowerBlue;
            button1.Image = Properties.Resources.business_report;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(50, 677);
            button1.Name = "button1";
            button1.Size = new Size(165, 40);
            button1.TabIndex = 10;
            button1.Text = "   Invoices";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 368);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 3;
            label3.Text = "Options";
            // 
            // Exit_btn
            // 
            Exit_btn.Cursor = Cursors.Hand;
            Exit_btn.FlatAppearance.BorderSize = 0;
            Exit_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Exit_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Exit_btn.FlatStyle = FlatStyle.Flat;
            Exit_btn.ForeColor = Color.CornflowerBlue;
            Exit_btn.Image = Properties.Resources.logout;
            Exit_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Exit_btn.Location = new Point(50, 852);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(165, 40);
            Exit_btn.TabIndex = 9;
            Exit_btn.Text = "        Exit App";
            Exit_btn.TextAlign = ContentAlignment.MiddleLeft;
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // Reports_btn
            // 
            Reports_btn.Cursor = Cursors.Hand;
            Reports_btn.FlatAppearance.BorderSize = 0;
            Reports_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Reports_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Reports_btn.FlatStyle = FlatStyle.Flat;
            Reports_btn.ForeColor = Color.CornflowerBlue;
            Reports_btn.Image = Properties.Resources.business_report;
            Reports_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Reports_btn.Location = new Point(50, 611);
            Reports_btn.Name = "Reports_btn";
            Reports_btn.Size = new Size(165, 40);
            Reports_btn.TabIndex = 8;
            Reports_btn.Text = "  Reports";
            Reports_btn.UseVisualStyleBackColor = true;
            Reports_btn.Click += Reports_btn_Click;
            // 
            // Retailers_btn
            // 
            Retailers_btn.Cursor = Cursors.Hand;
            Retailers_btn.FlatAppearance.BorderSize = 0;
            Retailers_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Retailers_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Retailers_btn.FlatStyle = FlatStyle.Flat;
            Retailers_btn.ForeColor = Color.CornflowerBlue;
            Retailers_btn.Image = Properties.Resources.supply_chain;
            Retailers_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Retailers_btn.Location = new Point(50, 545);
            Retailers_btn.Name = "Retailers_btn";
            Retailers_btn.Size = new Size(165, 40);
            Retailers_btn.TabIndex = 7;
            Retailers_btn.Text = "   Retailers";
            Retailers_btn.UseVisualStyleBackColor = true;
            Retailers_btn.Click += Retailers_btn_Click;
            // 
            // Inventory_btn
            // 
            Inventory_btn.Cursor = Cursors.Hand;
            Inventory_btn.FlatAppearance.BorderSize = 0;
            Inventory_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Inventory_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Inventory_btn.FlatStyle = FlatStyle.Flat;
            Inventory_btn.ForeColor = Color.CornflowerBlue;
            Inventory_btn.Image = Properties.Resources.warehouse;
            Inventory_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Inventory_btn.Location = new Point(50, 478);
            Inventory_btn.Name = "Inventory_btn";
            Inventory_btn.Size = new Size(165, 40);
            Inventory_btn.TabIndex = 6;
            Inventory_btn.Text = "    Inventory";
            Inventory_btn.UseVisualStyleBackColor = true;
            Inventory_btn.Click += Inventory_btn_Click;
            // 
            // History_btn
            // 
            History_btn.Cursor = Cursors.Hand;
            History_btn.FlatAppearance.BorderSize = 0;
            History_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            History_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            History_btn.FlatStyle = FlatStyle.Flat;
            History_btn.ForeColor = Color.CornflowerBlue;
            History_btn.Image = Properties.Resources.history;
            History_btn.ImageAlign = ContentAlignment.MiddleLeft;
            History_btn.Location = new Point(50, 414);
            History_btn.Name = "History_btn";
            History_btn.Size = new Size(165, 40);
            History_btn.TabIndex = 5;
            History_btn.Text = "Return";
            History_btn.UseVisualStyleBackColor = true;
            History_btn.Click += History_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 2;
            label2.Text = "Options";
            // 
            // Sell_btn
            // 
            Sell_btn.Cursor = Cursors.Hand;
            Sell_btn.FlatAppearance.BorderSize = 0;
            Sell_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Sell_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Sell_btn.FlatStyle = FlatStyle.Flat;
            Sell_btn.ForeColor = Color.CornflowerBlue;
            Sell_btn.Image = Properties.Resources.cart;
            Sell_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Sell_btn.Location = new Point(50, 309);
            Sell_btn.Name = "Sell_btn";
            Sell_btn.Size = new Size(165, 40);
            Sell_btn.TabIndex = 4;
            Sell_btn.Text = "        Sell";
            Sell_btn.TextAlign = ContentAlignment.MiddleLeft;
            Sell_btn.UseVisualStyleBackColor = true;
            Sell_btn.Click += Sell_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(95, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Import_btn
            // 
            Import_btn.Cursor = Cursors.Hand;
            Import_btn.FlatAppearance.BorderSize = 0;
            Import_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Import_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Import_btn.FlatStyle = FlatStyle.Flat;
            Import_btn.ForeColor = Color.CornflowerBlue;
            Import_btn.Image = Properties.Resources.import;
            Import_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Import_btn.Location = new Point(50, 242);
            Import_btn.Name = "Import_btn";
            Import_btn.Size = new Size(165, 40);
            Import_btn.TabIndex = 3;
            Import_btn.Text = "Import";
            Import_btn.UseVisualStyleBackColor = true;
            Import_btn.Click += Import_btn_Click;
            // 
            // Dashboard_btn
            // 
            Dashboard_btn.Cursor = Cursors.Hand;
            Dashboard_btn.FlatAppearance.BorderSize = 0;
            Dashboard_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Dashboard_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Dashboard_btn.FlatStyle = FlatStyle.Flat;
            Dashboard_btn.ForeColor = Color.CornflowerBlue;
            Dashboard_btn.Image = Properties.Resources.home;
            Dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard_btn.Location = new Point(50, 76);
            Dashboard_btn.Name = "Dashboard_btn";
            Dashboard_btn.Size = new Size(165, 40);
            Dashboard_btn.TabIndex = 1;
            Dashboard_btn.Text = "     Dashboard";
            Dashboard_btn.UseVisualStyleBackColor = true;
            Dashboard_btn.Click += Dashboard_btn_Click;
            // 
            // Export_btn
            // 
            Export_btn.Cursor = Cursors.Hand;
            Export_btn.FlatAppearance.BorderSize = 0;
            Export_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Export_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Export_btn.FlatStyle = FlatStyle.Flat;
            Export_btn.ForeColor = Color.CornflowerBlue;
            Export_btn.Image = Properties.Resources.export;
            Export_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Export_btn.Location = new Point(50, 181);
            Export_btn.Name = "Export_btn";
            Export_btn.Size = new Size(165, 40);
            Export_btn.TabIndex = 2;
            Export_btn.Text = "Export";
            Export_btn.UseVisualStyleBackColor = true;
            Export_btn.Click += Export_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2023_12_31_134027;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 75);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(DAY_LBL);
            panel3.Controls.Add(DT_LBL);
            panel3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(276, 905);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1644, 81);
            panel3.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 34);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(860, 22);
            label9.TabIndex = 44;
            label9.Text = "Note: Hit Add button after completion of the import of each category, Don't Override the Grid.";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1116, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // DAY_LBL
            // 
            DAY_LBL.AutoSize = true;
            DAY_LBL.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            DAY_LBL.Location = new Point(1217, 31);
            DAY_LBL.Margin = new Padding(4, 0, 4, 0);
            DAY_LBL.Name = "DAY_LBL";
            DAY_LBL.Size = new Size(114, 22);
            DAY_LBL.TabIndex = 17;
            DAY_LBL.Text = "Todays Day";
            // 
            // DT_LBL
            // 
            DT_LBL.AutoSize = true;
            DT_LBL.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            DT_LBL.Location = new Point(1372, 31);
            DT_LBL.Margin = new Padding(4, 0, 4, 0);
            DT_LBL.Name = "DT_LBL";
            DT_LBL.Size = new Size(222, 22);
            DT_LBL.TabIndex = 16;
            DT_LBL.Text = " DD/MM/YY  HH:MM:SS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(gstn_lbl);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Shpnm_lbl);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1917, 75);
            panel1.TabIndex = 3;
            // 
            // gstn_lbl
            // 
            gstn_lbl.AutoSize = true;
            gstn_lbl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gstn_lbl.Location = new Point(1683, 28);
            gstn_lbl.Margin = new Padding(4, 0, 4, 0);
            gstn_lbl.Name = "gstn_lbl";
            gstn_lbl.Size = new Size(214, 25);
            gstn_lbl.TabIndex = 4;
            gstn_lbl.Text = "11AAAAA2222A1Z5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1564, 28);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 3;
            label7.Text = "GST No. :";
            // 
            // Shpnm_lbl
            // 
            Shpnm_lbl.AutoSize = true;
            Shpnm_lbl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Shpnm_lbl.Location = new Point(291, 28);
            Shpnm_lbl.Margin = new Padding(4, 0, 4, 0);
            Shpnm_lbl.Name = "Shpnm_lbl";
            Shpnm_lbl.Size = new Size(400, 25);
            Shpnm_lbl.TabIndex = 2;
            Shpnm_lbl.Text = "Welcome, Aditya Software Devs, Palus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(292, 100);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 22);
            label5.TabIndex = 7;
            label5.Text = "Import";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(Confirm_import);
            panel4.Controls.Add(Import_grid);
            panel4.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(292, 152);
            panel4.Name = "panel4";
            panel4.Size = new Size(1625, 678);
            panel4.TabIndex = 8;
            // 
            // Confirm_import
            // 
            Confirm_import.AllowUserToAddRows = false;
            Confirm_import.AllowUserToDeleteRows = false;
            Confirm_import.AllowUserToResizeColumns = false;
            Confirm_import.AllowUserToResizeRows = false;
            Confirm_import.BackgroundColor = Color.White;
            Confirm_import.BorderStyle = BorderStyle.None;
            Confirm_import.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            Confirm_import.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Confirm_import.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            Confirm_import.GridColor = Color.White;
            Confirm_import.Location = new Point(0, 0);
            Confirm_import.Name = "Confirm_import";
            Confirm_import.ReadOnly = true;
            Confirm_import.RowHeadersWidth = 51;
            Confirm_import.RowTemplate.Height = 29;
            Confirm_import.Size = new Size(1625, 675);
            Confirm_import.TabIndex = 10;
            Confirm_import.Visible = false;
            Confirm_import.CellContentClick += Confirm_import_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "S. No.";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Barcode";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "HSN/SAC";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Category";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Item";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 585;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Price";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Qty";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // Import_grid
            // 
            Import_grid.AllowUserToAddRows = false;
            Import_grid.AllowUserToDeleteRows = false;
            Import_grid.AllowUserToResizeColumns = false;
            Import_grid.AllowUserToResizeRows = false;
            Import_grid.BackgroundColor = Color.White;
            Import_grid.BorderStyle = BorderStyle.None;
            Import_grid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            Import_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Import_grid.Columns.AddRange(new DataGridViewColumn[] { SNO, Barcode, HSN_SAC, Category, Item, Price, Qty });
            Import_grid.GridColor = Color.White;
            Import_grid.Location = new Point(0, 0);
            Import_grid.Name = "Import_grid";
            Import_grid.RowHeadersWidth = 51;
            Import_grid.RowTemplate.Height = 29;
            Import_grid.Size = new Size(1625, 678);
            Import_grid.TabIndex = 9;
            Import_grid.CellValidating += Import_grid_CellValidating;
            Import_grid.EditingControlShowing += Import_grid_EditingControlShowing;
            Import_grid.KeyPress += Import_grid_KeyPress;
            // 
            // SNO
            // 
            SNO.HeaderText = "S. No.";
            SNO.MinimumWidth = 6;
            SNO.Name = "SNO";
            SNO.ReadOnly = true;
            SNO.Width = 125;
            // 
            // Barcode
            // 
            Barcode.HeaderText = "Barcode";
            Barcode.MinimumWidth = 6;
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            Barcode.Width = 150;
            // 
            // HSN_SAC
            // 
            HSN_SAC.HeaderText = "HSN/SAC";
            HSN_SAC.MinimumWidth = 6;
            HSN_SAC.Name = "HSN_SAC";
            HSN_SAC.ReadOnly = true;
            HSN_SAC.Width = 160;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 260;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.ReadOnly = true;
            Item.Width = 600;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.Width = 150;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(add_btn);
            panel5.Controls.Add(Sim_btn);
            panel5.Location = new Point(292, 836);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1628, 63);
            panel5.TabIndex = 18;
            // 
            // add_btn
            // 
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatAppearance.BorderColor = Color.CornflowerBlue;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            add_btn.ForeColor = Color.CornflowerBlue;
            add_btn.Location = new Point(1481, 9);
            add_btn.Name = "add_btn";
            add_btn.RightToLeft = RightToLeft.No;
            add_btn.Size = new Size(138, 41);
            add_btn.TabIndex = 44;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Visible = false;
            add_btn.Click += add_btn_Click_1;
            // 
            // Sim_btn
            // 
            Sim_btn.Cursor = Cursors.Hand;
            Sim_btn.FlatAppearance.BorderColor = Color.CornflowerBlue;
            Sim_btn.FlatStyle = FlatStyle.Flat;
            Sim_btn.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Sim_btn.ForeColor = Color.CornflowerBlue;
            Sim_btn.Location = new Point(1319, 9);
            Sim_btn.Name = "Sim_btn";
            Sim_btn.RightToLeft = RightToLeft.No;
            Sim_btn.Size = new Size(138, 41);
            Sim_btn.TabIndex = 42;
            Sim_btn.Text = "Simplyify";
            Sim_btn.UseVisualStyleBackColor = true;
            Sim_btn.Click += Add_Btn_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.CornflowerBlue;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(466, 89);
            button3.Name = "button3";
            button3.Size = new Size(328, 40);
            button3.TabIndex = 19;
            button3.Text = "Particular Item Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Import
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "Import";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import";
            WindowState = FormWindowState.Maximized;
            FormClosing += Import_FormClosing;
            Load += Import_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Confirm_import).EndInit();
            ((System.ComponentModel.ISupportInitialize)Import_grid).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Button button1;
        private Label label3;
        private Button Exit_btn;
        private Button Reports_btn;
        private Button Retailers_btn;
        private Button Inventory_btn;
        private Button History_btn;
        private Label label2;
        private Button Sell_btn;
        private Label label1;
        private Button Import_btn;
        private Button Dashboard_btn;
        private Button Export_btn;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label DAY_LBL;
        private Label DT_LBL;
        private Panel panel1;
        private Label gstn_lbl;
        private Label label7;
        private Label Shpnm_lbl;
        private Label label5;
        private Panel panel4;
        private DataGridView Import_grid;
        private DataGridViewTextBoxColumn SNO;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn HSN_SAC;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qty;
        private Panel panel5;
        private Button Sim_btn;
        private DataGridView Confirm_import;
        private Button add_btn;
        private Label label9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
    }
}