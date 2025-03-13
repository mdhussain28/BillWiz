using BillWiz.SQL;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Numerics;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;


namespace BillWiz.UI
{
    public partial class S2C : Form
    {
        #region global declarations

        string? product_nm = null;
        string? uom = null;
        double? qty = null;
        double? amt = null;
        string? mrp = null;
        double sgst = 0;
        double cgst = 0;
        double igst = 0;
        double hsn_sac = 0;
        double gst = 0;
        double t_cgst = 0;
        double t_sgst = 0;
        double t_igst = 0;
        double total_amt = 0;
        double discount_amt = 0;
        double cgst_init = 0;
        double sgst_init = 0;
        double igst_init = 0;
        double rate = 0;
        double gross_amt = 0;
        double t_discount_amt = 0;
        double barcode = 0;
        string? dbo = null;
        double amtgiven = 0;
        static BigInteger inv_num;
        string? shpnm = null;
        string? ownernm = null;
        string? Phnoshp = null;
        string? emailshp = null;
        string? addr1 = null;
        string? addr2 = null;
        string? gstn = null;
        static int headerprinted = 0;

        PrintDocument printDocument1;
        private DataGridView dataGridView;
        private int rowIndex;

        SQL.SQL eps = new SQL.SQL();

        #endregion

        #region form events

        public S2C()
        {
            InitializeComponent();
        }

        private void Export_pgn_Load(object sender, EventArgs e)
        {
            this.loadings();
        }

        private void Export_pgn_FormClosing(object sender, FormClosingEventArgs e)
        {
            LOC_box lcb = new LOC_box();
            DialogResult result = lcb.ShowDialog();
            if (result == DialogResult.OK)
            {
                lcb.Close();
            }

            if (LOC_box.confirmation == false)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region functions

        private void loadings()
        {
            DataTable dt = eps.GetDataTable("Select * from Owner_DB");
            foreach (DataRow dr in dt.Rows)
            {
                shpnm = dr[0].ToString();
                ownernm = dr[1].ToString();
                Phnoshp = dr[2].ToString();
                emailshp = dr[3].ToString();
                addr1 = dr[4].ToString();
                addr2 = dr[5].ToString();
                gstn = dr[6].ToString();
            }

            Shpnm_lbl.Text = shpnm;
            gstn_lbl.Text = gstn;
            timer1.Start();
            DAY_LBL.Text = DateTime.Today.DayOfWeek.ToString();

            discount_txt.Text = "0";
            items_by_category.DataSource = eps.GetDataTable("select Product_Name from Items_DB");
            items_by_category.DisplayMember = "Product_Name";
            items_by_category.ValueMember = "Product_Name";
        }

        private void clear_variable()
        {
            product_nm = null;
            uom = null;
            qty = null;
            amt = null;
            mrp = null;
            sgst = 0;
            cgst = 0;
            igst = 0;
            hsn_sac = 0;
            gst = 0;
            t_cgst = 0;
            t_sgst = 0;
            t_igst = 0;
            total_amt = 0;
            discount_amt = 0;
            cgst_init = 0;
            sgst_init = 0;
            igst_init = 0;
            rate = 0;
            gross_amt = 0;
            t_discount_amt = 0;
            barcode = 0;
            dbo = null;
            amtgiven = 0;
            shpnm = null;
            ownernm = null;
            Phnoshp = null;
            emailshp = null;
            addr1 = null;
            addr2 = null;
            gstn = null;
            headerprinted = 0;
        }

        private void get_sum()
        {
            t_cgst = 0;
            t_sgst = 0;
            t_igst = 0;
            gst = 0;
            total_amt = 0;
            gross_amt = 0;
            t_discount_amt = 0;

            foreach (DataGridViewRow row in Items_Grid.Rows)
            {
                // Check if the cell value is not null or empty
                if (row.Cells[9].Value != null && !string.IsNullOrEmpty(row.Cells[9].Value.ToString()))
                {
                    // Parse the cell value to a decimal and add to the total sum
                    if (double.TryParse(row.Cells[9].Value.ToString(), out double cellValue))
                    {
                        t_cgst = t_cgst + cellValue;
                    }
                }
            }

            foreach (DataGridViewRow row in Items_Grid.Rows)
            {
                // Check if the cell value is not null or empty
                if (row.Cells[10].Value != null && !string.IsNullOrEmpty(row.Cells[10].Value.ToString()))
                {
                    // Parse the cell value to a decimal and add to the total sum
                    if (double.TryParse(row.Cells[10].Value.ToString(), out double cellValue))
                    {
                        t_sgst = t_sgst + cellValue;
                    }
                }
            }

            foreach (DataGridViewRow row in Items_Grid.Rows)
            {
                // Check if the cell value is not null or empty
                if (row.Cells[8].Value != null && !string.IsNullOrEmpty(row.Cells[8].Value.ToString()))
                {
                    // Parse the cell value to a decimal and add to the total sum
                    if (double.TryParse(row.Cells[8].Value.ToString(), out double cellValue))
                    {
                        total_amt = total_amt + cellValue;
                    }
                }
            }

            foreach (DataGridViewRow row in Items_Grid.Rows)
            {
                // Check if the cell value is not null or empty
                if (row.Cells[7].Value != null && !string.IsNullOrEmpty(row.Cells[7].Value.ToString()))
                {
                    // Parse the cell value to a decimal and add to the total sum
                    if (double.TryParse(row.Cells[7].Value.ToString(), out double cellValue))
                    {
                        gross_amt = gross_amt + cellValue;
                    }
                }
            }
            foreach (DataGridViewRow row in Items_Grid.Rows)
            {
                // Check if the cell value is not null or empty
                if (row.Cells[11].Value != null && !string.IsNullOrEmpty(row.Cells[11].Value.ToString()))
                {
                    // Parse the cell value to a decimal and add to the total sum
                    if (double.TryParse(row.Cells[11].Value.ToString(), out double cellValue))
                    {
                        t_igst = t_igst + cellValue;
                    }
                }
            }

            t_discount_amt = gross_amt - total_amt;
            gst = t_cgst + t_sgst + t_igst;
            total_amt = total_amt + gst;
            total_amt = Math.Round(total_amt, 3);
            t_discount_amt = Math.Round(t_discount_amt, 3);
            lbl_discount.Text = t_discount_amt.ToString();
            lbl_gross_amt.Text = gross_amt.ToString();
            gst = Math.Round(gst, 3);
            gst_lbl.Text = gst.ToString();
            lbl_total_amt.Text = total_amt.ToString();
        }

        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        private void UpdateRowNumbers()
        {
            // Iteamt through rows and update row numbers
            for (int i = 0; i < Items_Grid.Rows.Count; i++)
            {
                // DataGridView column index for "Row Number" column
                int rowNumberColumnIndex = 0;

                // Update the "Row Number" column value
                Items_Grid.Rows[i].Cells[rowNumberColumnIndex].Value = (i + 1).ToString();
            }
        }

        #endregion

        #region button click events

        private void CLR_Btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.loadings();
        }

        private void DSBD_Btn_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(Name_txt.Text)) && (!string.IsNullOrEmpty(City_txt.Text)))
            {
                if (items_by_category.SelectedIndex != -1 && items_by_category.SelectedIndex != -1)
                {
                    if (string.IsNullOrWhiteSpace(QTY_TXT.Text))
                    {
                        MessageBox.Show("Enter The Quantity");
                    }
                    else
                    {
                        if (Convert.ToDouble(REM_QTY.Text) >= Convert.ToDouble(QTY_TXT.Text))
                        {
                            if ((double.TryParse(amt_TXT.Text, out double amt) && int.TryParse(QTY_TXT.Text, out _)) && Convert.ToDouble(mrp) >= Convert.ToDouble(amt_TXT.Text))
                            {
                                double discount_value = (Convert.ToDouble(discount_txt.Text) / 100);
                                qty = Convert.ToInt32(QTY_TXT.Text);
                                amt = double.Parse(amt_TXT.Text) * Convert.ToInt32(QTY_TXT.Text);
                                discount_amt = amt - (amt * discount_value);

                                // Check if the item already exists in the DataGridView
                                bool isDuplicate = false;
                                foreach (DataGridViewRow row in Items_Grid.Rows)
                                {
                                    // Assuming the first cell in each row contains a unique identifier (e.g., product name)
                                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == product_nm)
                                    {
                                        isDuplicate = true;
                                        break;
                                    }
                                }

                                if (!isDuplicate)
                                {

                                    rate = Convert.ToDouble(amt_TXT.Text);
                                    DataTable dt = eps.GetDataTable($"SELECT CGST,SGST,IGST FROM ITEMS_DB WHERE Barcode_num = {barcode}");
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        cgst_init = Convert.ToDouble(dr[0].ToString());
                                        sgst_init = Convert.ToDouble(dr[1].ToString());
                                        igst_init = Convert.ToDouble(dr[2].ToString());
                                    }
                                    cgst = Math.Round(cgst_init * discount_amt, 3);
                                    sgst = Math.Round(sgst_init * discount_amt, 3);
                                    igst = Math.Round(igst_init * discount_amt, 3);

                                    // Add the row to the DataGridView
                                    this.Items_Grid.Rows.Add("", hsn_sac, product_nm, qty, uom, mrp, rate, amt, discount_amt, cgst, sgst, igst,Math.Round(discount_amt+cgst+sgst+igst,3), barcode, dbo, cgst_init, sgst_init, igst_init);
                                    UpdateRowNumbers();
                                }
                                else
                                {
                                    MessageBox.Show("Duplicate item. This item already exists in the Table.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter correct amt and quantity");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Entered Quantity is Greater than Remaining quantity");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item");
                }
            }
            else
            {
                MessageBox.Show("Enter Customer Name and City");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Retailer ar = new Add_Retailer();
            DialogResult res = ar.ShowDialog();
            if (res == DialogResult.OK)
            {
                ar.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Import import = new Import();
            import.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            View_Cust vc = new View_Cust();
            vc.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(Name_txt.Text)) && (!string.IsNullOrEmpty(City_txt.Text)))
            {
                if (Items_Grid.Rows.Count >= 1)
                {
                    Sale_Overview expn = new Sale_Overview(Name_txt.Text, lbl_gross_amt.Text, gst_lbl.Text, lbl_discount.Text, lbl_total_amt.Text, 0, "NA", 0);
                    DialogResult res = expn.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        amtgiven = expn.amtgiven();
                        GetNextInvoiceNumber();
                        expn.Hide();
                        printDocument1 = new PrintDocument();
                        printDocument1.PrintPage += printDocument1_PrintPage;

                        // Attach the PrintDocument to a PrintDialog for user configuration
                        PrintDialog printDialog = new PrintDialog();
                        printDialog.Document = printDocument1;

                        // Initialize the DataGridViewPrinter
                        DataGridViewPrinter(Items_Grid);

                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            printDocument1.Print();
                        }
                        DateTime date_to = DateTime.Now.Date;
                        string date_today = date_to.ToString("dd-MMM-yyyy");
                        for (int rowIndex = 0; rowIndex < Items_Grid.Rows.Count; rowIndex++)
                        {
                            DataGridViewRow row = Items_Grid.Rows[rowIndex];
                            string sql = $"UPDATE Items_DB SET Qty = Qty - {Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[3].Value)} where Barcode_num = {Items_Grid.Rows[rowIndex].Cells[13].Value}";
                            eps.SetDataTable(sql);
                            eps.SetDataTable($"INSERT INTO Cust_Invoices_items_DB values({inv_num},'{Name_txt.Text}','{Convert.ToString(Items_Grid.Rows[rowIndex].Cells[2].Value)}',{Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[3].Value)},{Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[7].Value)},{Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[9].Value) + Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[10].Value) + Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[11].Value)},'{date_today}',{total_amt},{amtgiven},'{City_txt.Text}','{phno_txt.Text}','{mail_txt.Text}','{Items_Grid.Rows[rowIndex].Cells[1].Value}',{Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[8].Value)},'{Items_Grid.Rows[rowIndex].Cells[4].Value}',{Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[5].Value)},{Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[13].Value)},{Convert.ToDouble(Items_Grid.Rows[rowIndex].Cells[6].Value)})");
                        }
                        eps.SetDataTable($"INSERT INTO All_Sale_Invoices values({inv_num},'{Name_txt.Text}',{total_amt},{gst},{amtgiven},'{date_today}','UnRegistered')");
                        this.Controls.Clear();
                        this.InitializeComponent();
                        this.loadings();
                        this.clear_variable();
                        this.Hide();
                        Dashboard dsh = new Dashboard();
                        dsh.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please add items");
                }
            }
            else
            {
                MessageBox.Show("Enter Customer Name and City");
            }
        }
        #endregion

        #region combox events


        private void items_by_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = eps.GetDataTable("select * from Items_DB where Product_Name=@name", "@name", items_by_category.Text);
            foreach (DataRow DR in dt.Rows)
            {
                Pr_name.Text = DR[0].ToString();
                HS_code.Text = DR[1].ToString();
                REM_QTY.Text = DR[2].ToString();
                amt_TXT.Text = DR[4].ToString();
                lbl_mrp.Text = DR[6].ToString();

                product_nm = Pr_name.Text;
                hsn_sac = Convert.ToDouble(DR[1].ToString());
                uom = DR[3].ToString();
                amt = Convert.ToDouble(DR[4].ToString());
                barcode = Convert.ToDouble(DR[5].ToString());
                mrp = DR[6].ToString();
                dbo = "Jindal_SWR_Database";

            }
        }

        #endregion

        #region datagridviewlayout events

        private void Items_Grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            items_by_category.SelectedIndex = -1;
            Pr_name.Text = null;
            lbl_mrp.Text = null;
            HS_code.Text = null;
            REM_QTY.Text = null;
            amt_TXT.Clear();
            QTY_TXT.Clear();
            UpdateRowNumbers();
            get_sum();
        }

        private void Items_Grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateRowNumbers();
            get_sum();
        }

        private void Items_Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                if(Convert.ToDouble(Items_Grid.Rows[e.RowIndex].Cells[5].Value) >= Convert.ToDouble(Items_Grid.Rows[e.RowIndex].Cells[6].Value))
                {
                    // Get the new amt value from the 7th column
                    double newrate = Convert.ToDouble(Items_Grid.Rows[e.RowIndex].Cells[6].Value);
                    double qty_1 = Convert.ToDouble(Items_Grid.Rows[e.RowIndex].Cells[3].Value);
                    DataTable dt = eps.GetDataTable($"SELECT CGST,SGST,IGST FROM ITEMS_DB WHERE Barcode_num = {Items_Grid.Rows[e.RowIndex].Cells[13].Value}");
                    foreach (DataRow dr in dt.Rows)
                    {
                        cgst_init = Convert.ToDouble(dr[0].ToString());
                        sgst_init = Convert.ToDouble(dr[1].ToString());
                        igst_init = Convert.ToDouble(dr[2].ToString());
                    }
                    double newamt = newrate * qty_1;
                    double discount_value = (Convert.ToDouble(discount_txt.Text) / 100);
                    double newdiscountamt = newamt - (newamt * discount_value);
                    double cgst_1 = newdiscountamt * cgst_init;
                    double sgst_1 = newdiscountamt * sgst_init;
                    double igst_1 = newdiscountamt * igst_init;
                    Items_Grid.Rows[e.RowIndex].Cells[7].Value = newamt;
                    Items_Grid.Rows[e.RowIndex].Cells[8].Value = newdiscountamt; // DISCOUNT column
                    Items_Grid.Rows[e.RowIndex].Cells[9].Value = Math.Round(cgst_1, 3); // CGST column
                    Items_Grid.Rows[e.RowIndex].Cells[10].Value = Math.Round(sgst_1, 3); // SGST column
                    Items_Grid.Rows[e.RowIndex].Cells[11].Value = Math.Round(igst_1, 3); // IGST column
                    Items_Grid.Rows[e.RowIndex].Cells[12].Value = Math.Round(newdiscountamt + cgst_1 + sgst_1 + igst_1, 3); // Total column
                    get_sum();
                }
                else
                {
                    MessageBox.Show("Entered amount is greater than MRP");
                    Items_Grid.Rows[e.RowIndex].Cells[6].Value = rate;
                }
            }
        }

        private void Items_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == Items_Grid.Columns["DeleteButtonColumn"].Index)
            {
                // Check if the row is a new row being added
                if (Items_Grid.Rows[e.RowIndex].IsNewRow)
                {
                    // If it's a new row, cancel the deletion
                    return;
                }

                // Assuming you have a primary key column named "ID" - adjust as needed
                int rowToDeleteID = Convert.ToInt32(Items_Grid.Rows[e.RowIndex].Cells["S_NO"].Value);

                // Perform the deletion logic
                Items_Grid.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Items_Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Items_Grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            // Check if the validation is required for column 5 or column 6
            if (columnIndex == 6)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string inputValue = e.FormattedValue.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                // Check if the entered value is numeric
#pragma warning disable CS8604 // Possible null reference argument.
                if (!IsNumeric(inputValue))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a numeric value in this column.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
#pragma warning restore CS8604 // Possible null reference argument.
            }
        }

        #endregion

        #region TextBox events

        private void discount_txt_TextChanged(object sender, EventArgs e)
        {
            bool applyDiscount = !string.IsNullOrWhiteSpace(discount_txt.Text);
            double discountValue = applyDiscount ? Convert.ToDouble(discount_txt.Text) : 0;

            foreach (DataGridViewRow row in Items_Grid.Rows)
            {
                if (row.Cells.Count > 10 && row.Cells[7].Value != null)
                {
                    if (double.TryParse(row.Cells[7].Value.ToString(), out double amtValue))
                    {
                        if (applyDiscount)
                        {
                            if (Convert.ToDouble(discount_txt.Text) >= 0 && Convert.ToDouble(discount_txt.Text) <= 100)
                            {
                                double newDiscountamt = (discountValue / 100);
                                row.Cells[8].Value = newDiscountamt;

                                double discountedAmount = amtValue - (amtValue * newDiscountamt);
                                double cgst = Math.Round(discountedAmount * Convert.ToDouble(row.Cells[15].Value), 3);
                                double sgst = Math.Round(discountedAmount * Convert.ToDouble(row.Cells[16].Value), 3);
                                double igst = Math.Round(discountedAmount * Convert.ToDouble(row.Cells[17].Value), 3);
                                row.Cells[9].Value = cgst;
                                row.Cells[10].Value = sgst;
                                row.Cells[11].Value = igst;
                                row.Cells[8].Value = discountedAmount;
                                row.Cells[12].Value = discountedAmount + sgst + cgst + igst;

                            }
                            else
                            {
                                MessageBox.Show("Discount Should Range between 0-100");
                                discount_txt.Text = "0";
                            }
                        }
                        else
                        {
                            row.Cells[8].Value = amtValue;
                            row.Cells[9].Value = Math.Round(amtValue * Convert.ToDouble(row.Cells[15].Value), 2);
                            row.Cells[10].Value = Math.Round(amtValue * Convert.ToDouble(row.Cells[16].Value), 2);
                            row.Cells[11].Value = Math.Round(amtValue * Convert.ToDouble(row.Cells[17].Value), 2);
                            row.Cells[12].Value = Math.Round(amtValue + Convert.ToDouble(row.Cells[9].Value) + Convert.ToDouble(row.Cells[10].Value) + Convert.ToDouble(row.Cells[11].Value), 3);
                        }
                    }
                }
            }
            get_sum();
        }

        private void discount_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && discount_txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DT_LBL.Text = datetime.ToString();
        }

        private void amt_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && amt_TXT.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void QTY_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void discount_txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(discount_txt.Text))
            {
                discount_txt.Text = "0";
            }
        }

        #endregion

        #region Printing Module

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters[0];
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Width and height are specified in hundredths of an inch
            printDocument1.DefaultPageSettings.Margins = new Margins(35, 35, 20, 20);
            DrawDataGridView(e.Graphics, e);
        }

        public void DataGridViewPrinter(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            this.rowIndex = 0;
        }

        public void DrawDataGridView(Graphics graphics, PrintPageEventArgs e)
        {
            // Calculate the total width of the columns
            float totalWidth = 0;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                totalWidth += column.Width;
            }

            // Set the printing area rectangle
            RectangleF printArea = new RectangleF(20, 20, totalWidth, 0);

            // Draw the content
            DrawContent(graphics, ref printArea, e);
        }

        private void DrawContent(Graphics graphics, ref RectangleF printArea, PrintPageEventArgs e)
        {
            if (headerprinted == 0)
            {
                float thinLineWidth = 0.1f; // Set the desired width for the thin lines
                Pen thinPen = new Pen(Color.Black, thinLineWidth);
                using (Font contentFont = new Font("Verdana", 9))
                {
                    string heading = "GST INVOICE";
                    //Font headf = new Font("Verdana", 18);
                    SizeF headingSize = graphics.MeasureString(heading, contentFont);
                    graphics.DrawString(heading, contentFont, Brushes.Black, new PointF(375, 30));
                    printArea.Y += 30;

                    // Print your address
                    string yourCompanyInfo = $"{shpnm}\n{ownernm}\n{addr1}\n{addr2}\nPhone: {Phnoshp}\nEmail: {emailshp}\nGSTN: {gstn}";
                    graphics.DrawString(yourCompanyInfo, contentFont, Brushes.Black, new PointF(40, printArea.Y));

                    // Adjust Y for the next section
                    printArea.Y += 120;

                    // Draw Date and Invoice Number
                    string dateAndInvoiceNumber = $"Date: {DateTime.Now.ToShortDateString()}\nInvoice Number: {inv_num}";
                    graphics.DrawString(dateAndInvoiceNumber, contentFont, Brushes.Black, new PointF(630, 50));

                    // Adjust Y for the next section
                    //printArea.Y += 50;

                    string billToInfo = $"Bill To:\nCustomer Name: {Name_txt.Text}\nCity: {City_txt.Text}\nPhone No. : {phno_txt.Text}\nEmail I'd: {mail_txt.Text}";
                    graphics.DrawString(billToInfo, contentFont, Brushes.Black, new PointF(40, printArea.Y));

                    printArea.Y += 120;
                    printArea.X += 20;
                }
                headerprinted = 1;
                DrawContent1(graphics, ref printArea, e);
            }
            else
            {
                printArea.Y = 40;
                DrawContent1(graphics, ref printArea, e);
            }

        }

        private void DrawTableHeader(Graphics graphics, Font contentFont, ref RectangleF printArea, PrintPageEventArgs e)
        {

            float thinLineWidth = 0.1f; // Set the desired width for the thin lines
            Pen thinPen = new Pen(Color.Black, thinLineWidth);
            // Define the columns you want to print (1 to 5)
            int[] columnsToPrint = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12};
            float[] manualColumnWidths = { 30, 68, 180, 40, 40, 50, 50, 50, 50, 40, 40, 40, 50 };
            printArea.X = 40;
            // Draw column names
            for (int columnIndex = 0; columnIndex < columnsToPrint.Length; columnIndex++)
            {
                int actualColumnIndex = columnsToPrint[columnIndex];

                if (actualColumnIndex < dataGridView.Columns.Count)
                {
                    string columnName = dataGridView.Columns[actualColumnIndex].HeaderText;
                    float width = manualColumnWidths[columnIndex];

                    // Draw column name with right alignment and borders
                    RectangleF cellRect = new RectangleF(printArea.X, printArea.Y, width, 50);
                    using (Brush brush = new SolidBrush(Color.LightGray))
                    {
                        e.Graphics.FillRectangle(brush, cellRect);
                    }
                    StringFormat format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    // Draw border
                    graphics.DrawRectangle(thinPen, cellRect.Left, cellRect.Top, cellRect.Width, cellRect.Height);

                    // Draw column name
                    graphics.DrawString(columnName, contentFont, Brushes.Black, cellRect, format);

                    printArea.X += width;
                }
            }
        }

        private void DrawContent1(Graphics graphics, ref RectangleF printArea, PrintPageEventArgs e)
        {

            float thinLineWidth = 0.1f; // Set the desired width for the thin lines
            Pen thinPen = new Pen(Color.Black, thinLineWidth);
            using (Font contentFont = new Font("Verdana", 9))
            {
                DrawTableHeader(graphics, contentFont, ref printArea, e);

                printArea.Y += 50;

                float[] manualColumnWidths = { 30, 68, 180, 40, 40, 50, 50, 50, 50, 40, 40, 40,50 };

                while (rowIndex < dataGridView.Rows.Count)
                {
                    DataGridViewRow row = dataGridView.Rows[rowIndex];

                    // Reset X position for each new row
                    printArea.X = 40;

                    for (int columnIndex = 0; columnIndex <= 12; columnIndex++)
                    {
                        DataGridViewCell cell = row.Cells[columnIndex];
                        string? cellValue = cell.Value?.ToString();
                        float width = manualColumnWidths[columnIndex];

                        // Draw cell value with right alignment and borders
                        RectangleF cellRect = new RectangleF(printArea.X, printArea.Y, width, 50);

                        StringFormat format = new StringFormat
                        {
                            Alignment = StringAlignment.Near,
                            LineAlignment = StringAlignment.Center
                        };

                        // Draw border
                        graphics.DrawRectangle(thinPen, cellRect.Left, cellRect.Top, cellRect.Width, cellRect.Height);

                        // Draw cell value
                        graphics.DrawString(cellValue, contentFont, Brushes.Black, cellRect, format);

                        printArea.X += width;
                    }

                    rowIndex++;

                    if (printArea.Y + 110 > e.MarginBounds.Bottom)
                    {
                        printArea.X -= 30;
                        RectangleF invoiceRect = new RectangleF(35, 20, printArea.X, printArea.Y + 40); // Adjust the height as needed
                        graphics.DrawRectangle(Pens.Black, invoiceRect.Left, invoiceRect.Top, invoiceRect.Width, invoiceRect.Height);
                        printArea.X += 30;
                        e.HasMorePages = true;
                        return;
                    }

                    printArea.Y += 50; // Increment Y for the next row
                }

                // Adjust Y for the next section
                printArea.Y += 20;
                if (printArea.Bottom + 260 > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
                // Draw the summary section
                DrawSummary(graphics, contentFont, ref printArea);

                // Adjust Y for the next page if needed
                printArea.Y += 120;

            }

            // Reset rowIndex when all rows are printed
            rowIndex = 0;
        }

        private void DrawSummary(Graphics graphics, Font contentFont, ref RectangleF printArea)
        {
            graphics.DrawLine(Pens.Black, 35, printArea.Y -5 ,773,printArea.Y-5);
            // Draw the summary section
            string summaryInfo = $"Summary\n\nSubtotal                      {lbl_gross_amt.Text}\nDiscount                     -{lbl_discount.Text}\nGST                         +{gst_lbl.Text}\nTotal                           {lbl_total_amt.Text}\nReveived                     {amtgiven}\nRemaining                   {Convert.ToDouble(lbl_total_amt.Text) - amtgiven}                            Reveivers Signature                            Authorised Signatory";
            string greating = "Thank you for your business!";
            string inend = "Customer Copy";
            DataTable dtbk = eps.GetDataTable("SELECT * from bk_details");
            string bk = "";
            string vpa = "";
            string accname = "";
            string amttopay = lbl_total_amt.Text;
            string gstbreakdown = $"GST Breakdown :\nCGST                     {Math.Round(t_cgst,3)}\nSGST                     {Math.Round(t_sgst,3)}\nIGST                      {Math.Round(t_igst, 3)}";
            foreach (DataRow row in dtbk.Rows)
            {
                bk = $"Bank Details:\n\nBank Name:{row[0].ToString()}\nAccount Number:{row[1].ToString()}\nIFSC Code:{row[2].ToString()}\nAcc. Holder Name:{row[3].ToString()}";
                vpa = row[4].ToString();
                accname = row[3].ToString();
            }
            
            
            Bitmap qrCodeImage=null; // Declaring qrCodeImage at the class level

            if (!string.IsNullOrWhiteSpace(vpa) && !string.IsNullOrWhiteSpace(accname))
            {
                try
                {
                    string data = $"upi://pay?pa={vpa}&pn={accname}&am={amttopay}&cu=INR&tn={"Paying For Invoice No." + inv_num}";

                    BarcodeWriter barcodeWriter = new BarcodeWriter
                    {
                        Format = BarcodeFormat.QR_CODE,
                        Options = new EncodingOptions
                        {
                            Width = 150,
                            Height = 150
                        }
                    };

                    qrCodeImage = barcodeWriter.Write(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error generating QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter both account number and IFSC code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            graphics.DrawString(summaryInfo, contentFont, Brushes.Black, new PointF(50, printArea.Y));

            // Adjust Y for the next page if needed
            printArea.Y += 150;
            graphics.DrawString(gstbreakdown, contentFont, Brushes.Black, new PointF(50, printArea.Y));
            graphics.DrawLine(Pens.Black, 295, printArea.Y - 155, 295, printArea.Y + 97);
            graphics.DrawString(bk, contentFont, Brushes.Black, new PointF(300, printArea.Y));
            graphics.DrawImage(qrCodeImage, new Point(650, Convert.ToInt32(printArea.Y - 20)));
            graphics.DrawLine(Pens.Black, 295, printArea.Y - 15, 773, printArea.Y - 15);
            // Draw additional content
            printArea.Y += 100;
            graphics.DrawLine(Pens.Black, 35, printArea.Y-3 , 773, printArea.Y -3);
            graphics.DrawString(greating, contentFont, Brushes.Black, new PointF(330, printArea.Y));
            printArea.Y += 30;
            graphics.DrawString(inend, contentFont, Brushes.Black, new PointF(375, printArea.Y));
            printArea.X -= 30;

            RectangleF invoiceRect = new RectangleF(35, 20, printArea.X, printArea.Y); // Adjust the height as needed
            graphics.DrawRectangle(Pens.Black, invoiceRect.Left, invoiceRect.Top, invoiceRect.Width, invoiceRect.Height);

        }
        

        private void GetNextInvoiceNumber()
        {
            string sql = "SELECT NEXT VALUE FOR invoice_seq AS NextSequenceValue";
            DataTable dt = eps.GetDataTable(sql);
            string invoice_num = " Not Generated";

            foreach (DataRow dr in dt.Rows)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                invoice_num = dr[0].ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            }

            inv_num = Convert.ToInt64(invoice_num);
        }

        #endregion

    }
}