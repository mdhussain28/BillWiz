using BillWiz.SQL;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Numerics;

namespace BillWiz.UI
{
    public partial class Quotation : Form
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
        double igst_init =0;
        double rate = 0;
        double gross_amt = 0;
        double t_discount_amt = 0;
        double barcode = 0;
        string? dbo = null;
        string? shpnm = null;
        string? ownernm = null;
        string? Phnoshp = null;
        string? emailshp = null;
        string? addr1 = null;
        string? addr2 = null;
        string? gstn = null;
        BigInteger headerprinted = 0;

        PrintDocument printDocument1;
        private DataGridView dataGridView;
        private int rowIndex;


        SQL.SQL eps = new SQL.SQL();

        #endregion

        #region form events

        public Quotation()
        {
            InitializeComponent();
        }

        private void Quotation_Load(object sender, EventArgs e)
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
             shpnm = null;
             ownernm = null;
             Phnoshp = null;
             emailshp = null;
             addr1 = null;
             addr2 = null;
             gstn = null;
            headerprinted = 0;
            this.loadings();
            timer1.Start();
            DAY_LBL.Text = DateTime.Today.DayOfWeek.ToString();
            items_by_category.DataSource = eps.GetDataTable("select Product_Name from Items_DB");
            items_by_category.DisplayMember = "Product_Name";
            items_by_category.ValueMember = "Product_Name";
        }

        private void Quotation_FormClosing(object sender, FormClosingEventArgs e)
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
                if (row.Cells[8].Value != null && !string.IsNullOrEmpty(row.Cells[8].Value.ToString()))
                {
                    // Parse the cell value to a decimal and add to the total sum
                    if (double.TryParse(row.Cells[8].Value.ToString(), out double cellValue))
                    {
                        t_cgst = t_cgst + cellValue;
                    }
                }
            }

            foreach (DataGridViewRow row in Items_Grid.Rows)
            {
                // Check if the cell value is not null or empty
                if (row.Cells[9].Value != null && !string.IsNullOrEmpty(row.Cells[9].Value.ToString()))
                {
                    // Parse the cell value to a decimal and add to the total sum
                    if (double.TryParse(row.Cells[9].Value.ToString(), out double cellValue))
                    {
                        t_sgst = t_sgst + cellValue;
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
                if (row.Cells[10].Value != null && !string.IsNullOrEmpty(row.Cells[10].Value.ToString()))
                {
                    // Parse the cell value to a decimal and add to the total sum
                    if (double.TryParse(row.Cells[10].Value.ToString(), out double cellValue))
                    {
                        t_igst = t_igst + cellValue;
                    }
                }
            }

            t_discount_amt = gross_amt - total_amt;
            gst = t_cgst + t_sgst +t_igst;
            total_amt = total_amt + gst;
            total_amt = Math.Round(total_amt, 3);
            t_discount_amt = Math.Round(t_discount_amt, 3);
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
                        if ((double.TryParse(amt_TXT.Text, out double amt) && int.TryParse(QTY_TXT.Text, out _)) && Convert.ToDouble(mrp) >= Convert.ToDouble(amt_TXT.Text))
                        {
                            qty = Convert.ToInt32(QTY_TXT.Text);
                            amt = double.Parse(amt_TXT.Text) * Convert.ToInt32(QTY_TXT.Text);
                            discount_amt = amt;

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
                                DataTable dtgst = eps.GetDataTable($"SELECT CGST,SGST,IGST FROM Items_DB WHERE Barcode_num = {barcode}");
                                foreach (DataRow row in dtgst.Rows)
                                {
                                    cgst_init = Convert.ToDouble(row[0].ToString());
                                    sgst_init = Convert.ToDouble(row[1].ToString());
                                    igst_init = Convert.ToDouble(row[2].ToString());
                                }
                                cgst = Math.Round(cgst_init * discount_amt, 3);
                                sgst = Math.Round(sgst_init * discount_amt, 3);
                                igst = Math.Round(igst_init * discount_amt, 3);

                                // Add the row to the DataGridView
                                this.Items_Grid.Rows.Add("", hsn_sac, product_nm, qty, uom, mrp, rate, amt, cgst, sgst,igst,Math.Round(amt+cgst+sgst+igst,3), barcode, dbo);
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


        private void button2_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(Name_txt.Text)) && (!string.IsNullOrEmpty(City_txt.Text)))
            {
                if (Items_Grid.Rows.Count >= 1)
                {
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
                    this.Controls.Clear();
                    this.InitializeComponent();
                    this.loadings();
                    this.clear_variable();
                    this.Hide();
                    Dashboard dsh = new Dashboard();
                    dsh.Show();
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

                    //string item_name = Search_by_category.SelectedItem.ToString() + " " + items_by_category.Text;
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
                        dbo = "Items_DB";
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
                if (Convert.ToDouble(Items_Grid.Rows[e.RowIndex].Cells[5].Value) >= Convert.ToDouble(Items_Grid.Rows[e.RowIndex].Cells[6].Value))
                {
                    // Get the new amt value from the 7th column
                    double newrate = Convert.ToDouble(Items_Grid.Rows[e.RowIndex].Cells[6].Value);
                    double qty_1 = Convert.ToDouble(Items_Grid.Rows[e.RowIndex].Cells[3].Value);
                    double newamt = newrate * qty_1;
                    double discount_value = 0;
                    double newdiscountamt = newamt - discount_value;
                    double cgst_1 = newdiscountamt * cgst_init;
                    double sgst_1 = newdiscountamt * sgst_init;
                    double igst_1 = newdiscountamt * igst_init;

                    Items_Grid.Rows[e.RowIndex].Cells[7].Value = newamt;
                    Items_Grid.Rows[e.RowIndex].Cells[7].Value = newdiscountamt; // DISCOUNT column
                    Items_Grid.Rows[e.RowIndex].Cells[8].Value = Math.Round(cgst_1, 3); // CGST column
                    Items_Grid.Rows[e.RowIndex].Cells[9].Value =Math.Round(sgst_1,3); // SGST column
                    Items_Grid.Rows[e.RowIndex].Cells[10].Value = Math.Round(igst_1, 3); // IGST column
                    Items_Grid.Rows[e.RowIndex].Cells[11].Value =Math.Round(newdiscountamt + cgst_1 + sgst_1 + igst_1,3); // Total column

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

            if (columnIndex == 6)
            {
                string inputValue = e.FormattedValue.ToString();

                if (!IsNumeric(inputValue))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a numeric value in this column.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region TextBox events


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
                    string heading = "Quotation";
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
                    string dateAndInvoiceNumber = $"Date: {DateTime.Now.ToShortDateString()}";
                    graphics.DrawString(dateAndInvoiceNumber, contentFont, Brushes.Black, new PointF(650, 50));

                    // Adjust Y for the next section
                    //printArea.Y += 50;

                    string billToInfo = $"Quo. To:\nCustomer Name: {Name_txt.Text}\nCity: {City_txt.Text}\nPhone No. : {phno_txt.Text}\nEmail I'd: {mail_txt.Text}";
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
            int[] columnsToPrint = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11 };
            float[] manualColumnWidths = { 30, 70, 190, 40, 40, 50, 50, 55, 55, 50,50,60 };
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

                float[] manualColumnWidths = { 30, 70, 190, 40, 40, 50, 50, 55, 55, 50, 50, 60 };

                while (rowIndex < dataGridView.Rows.Count)
                {
                    DataGridViewRow row = dataGridView.Rows[rowIndex];

                    // Reset X position for each new row
                    printArea.X = 40;

                    for (int columnIndex = 0; columnIndex <= 11; columnIndex++)
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
                if (printArea.Bottom + 150 > e.MarginBounds.Bottom)
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
            // Draw the summary section
            string summaryInfo = $"Summary\n\nSubtotal                      {lbl_gross_amt.Text}\nDiscount                     -NA\nGST(18%)                 +{gst_lbl.Text}\nTotal                           {lbl_total_amt.Text}                            Reveivers Signature                            Authorised Signatory";
            //string greating = "Thank you for your business!";
            graphics.DrawString(summaryInfo, contentFont, Brushes.Black, new PointF(40, printArea.Y));

            // Adjust Y for the next page if needed
            printArea.Y += 100;
            //graphics.DrawString(greating, contentFont, Brushes.Black, new PointF(330, printArea.Y+15));
            //printArea.Y += 30;

            printArea.X -= 30;

            RectangleF invoiceRect = new RectangleF(35, 20, printArea.X, printArea.Y); // Adjust the height as needed
            graphics.DrawRectangle(Pens.Black, invoiceRect.Left, invoiceRect.Top, invoiceRect.Width, invoiceRect.Height);

        }

        #endregion

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DT_LBL.Text = datetime.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}