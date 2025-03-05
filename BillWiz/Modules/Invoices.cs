using System.Data;
using System.Drawing.Printing;
using System.Numerics;
using ZXing.Common;
using ZXing;

namespace BillWiz.UI
{
    public partial class Invoices : Form
    {
        SQL.SQL eps = new SQL.SQL();
        DataTable dt, dt1, dt2;
        static string InvType = "";
        double amtrem = 0;
        static int user;
        string mailid;
        double amtgiven;
        int headerprinted = 0;
        string? shpnm = null;
        string? ownernm = null;
        string? Phnoshp = null;
        string? emailshp = null;
        string? addr1 = null;
        string? addr2 = null;
        string? gstn = null;
        double t_cgst=0, t_sgst=0, t_igst =0;
        DateTime? dategen = null;
        BigInteger inv_num;
        double cgst = 0;
        double sgst = 0;
        double igst = 0;
        string cust_gstn = "";

        PrintDocument printDocument1;
        private DataGridView dataGridView;
        private int rowIndex;

        public Invoices()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < Invoice_Data.Rows.Count; i++)
            {
                int rowNumberColumnIndex = 0;

                Invoice_Data.Rows[i].Cells[rowNumberColumnIndex].Value = (i + 1).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Invoice_Data.Rows.Clear();
            if (!string.IsNullOrEmpty(Inv_Num.Text))
            {
                dt = eps.GetDataTable($"SELECT Type from All_Sale_Invoices where Invoice_num = {Inv_Num.Text}");
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "Registered")
                    {
                        InvType = "Registered";
                    }
                    if (dr[0].ToString() == "UnRegistered")
                    {
                        InvType = "UnRegistered";
                    }
                }

                if (InvType == "Registered")
                {
                    user = 1;
                    dt.Clear();
                    dt = eps.GetDataTable($"SELECT * from Retailers_Invoice_items_DB WHERE Invoice_id = {Inv_Num.Text}");
                    inv_num = Convert.ToInt64(Inv_Num.Text);
                    double custid = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataTable dtgst = eps.GetDataTable($"SELECT CGST,SGST,IGST FROM Items_DB WHERE Barcode_num = {dr[13].ToString()}");
                        foreach (DataRow dr2 in dtgst.Rows)
                        {
                            cgst = Convert.ToDouble(dr2[0].ToString());
                            sgst = Convert.ToDouble(dr2[1].ToString());
                            igst = Convert.ToDouble(dr2[2].ToString());

                        }
                        Invoice_Data.Rows.Add("", dr[9].ToString(), dr[2].ToString(), dr[3].ToString(), dr[11].ToString(), dr[12].ToString(), (Convert.ToDouble(dr[4].ToString())) / (Convert.ToDouble(dr[3].ToString())), dr[4].ToString(), dr[10].ToString(), (Convert.ToDouble(dr[10].ToString())) * cgst, (Convert.ToDouble(dr[10].ToString())) * sgst, (Convert.ToDouble(dr[10].ToString())) * igst, (Convert.ToDouble(dr[10].ToString()) + (Convert.ToDouble(dr[10].ToString()) * cgst) + (Convert.ToDouble(dr[10].ToString()) * sgst) + (Convert.ToDouble(dr[10].ToString()) * igst)));
                        final_lbl.Text = dr[7].ToString();
                        amtrem = (Convert.ToDouble(dr[7].ToString())) - Convert.ToDouble(dr[8].ToString());
                        Cust_name_lbl.Text = dr[1].ToString();
                        dategen = Convert.ToDateTime(dr[6].ToString());
                        custid = Convert.ToDouble(dr[15].ToString());
                    }
                    DataTable dtgstn = eps.GetDataTable($"SELECT GSTN FROM Retailers_Database WHERE Cust_id = {custid}");
                    foreach (DataRow dr in dtgstn.Rows)
                    {
                        cust_gstn = dr[0].ToString();
                    }
                    dt1 = eps.GetDataTable($"SELECT SUM(AMT),SUM(gst),SUM(Discounted_amt) from Retailers_Invoice_items_DB WHERE Invoice_id = {Inv_Num.Text}");
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        Ttlamt_lbl.Text = dr1[0].ToString();
                        disamt_lbl.Text = (Convert.ToDouble(dr1[0].ToString()) - Convert.ToDouble(dr1[2].ToString())).ToString();
                        gst_lbl.Text = dr1[1].ToString();
                    }

                    dt2 = eps.GetDataTable($"SELECT Ph_no,mail_id,city FROM Retailers_Database WHERE Shop_name = '{Cust_name_lbl.Text}'");
                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        Phno_lbl.Text = dr2[0].ToString();
                        mailid = dr2[1].ToString();
                        City_label.Text = dr2[2].ToString();
                    }
                    UpdateRowNumbers();
                    get_sum();
                }

                if (InvType == "UnRegistered")
                {
                    user = 0;
                    dt.Clear();
                    dt = eps.GetDataTable($"SELECT * from Cust_Invoices_items_DB WHERE Invoice_num = {Inv_Num.Text}");
                    inv_num = Convert.ToInt64(Inv_Num.Text);
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataTable dtgst = eps.GetDataTable($"SELECT CGST,SGST,IGST FROM Items_DB WHERE Barcode_num = {dr[16].ToString()}");
                        foreach (DataRow dr2 in dtgst.Rows)
                        {
                            cgst = Convert.ToDouble(dr2[0].ToString());
                            sgst = Convert.ToDouble(dr2[1].ToString());
                            igst = Convert.ToDouble(dr2[2].ToString());

                        }
                        Invoice_Data.Rows.Add("", dr[12].ToString(), dr[2].ToString(), dr[3].ToString(), dr[14].ToString(), dr[15].ToString(), (Convert.ToDouble(dr[4].ToString())) / (Convert.ToDouble(dr[3].ToString())), dr[4].ToString(), dr[13].ToString(), (Convert.ToDouble(dr[13].ToString())) * cgst, (Convert.ToDouble(dr[13].ToString())) *  sgst, (Convert.ToDouble(dr[13].ToString())) * igst,(Convert.ToDouble(dr[13].ToString()) + (Convert.ToDouble(dr[13].ToString()) * cgst) + (Convert.ToDouble(dr[13].ToString()) * sgst) + (Convert.ToDouble(dr[13].ToString()) * igst)));
                        final_lbl.Text = dr[7].ToString();
                        amtrem = (Convert.ToDouble(dr[7].ToString())) - Convert.ToDouble(dr[8].ToString());
                        Cust_name_lbl.Text = dr[1].ToString();
                        dategen = Convert.ToDateTime(dr[6].ToString());
                        cust_gstn = "NA";
                    }
                    dt1 = eps.GetDataTable($"SELECT SUM(AMT),SUM(gst),SUM(Discounted_amt) from Cust_Invoices_items_DB WHERE Invoice_num = {Inv_Num.Text}");
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        Ttlamt_lbl.Text = dr1[0].ToString();
                        disamt_lbl.Text = (Convert.ToDouble(dr1[0].ToString()) - Convert.ToDouble(dr1[2].ToString())).ToString();
                        gst_lbl.Text = dr1[1].ToString();
                    }
                    UpdateRowNumbers();
                    get_sum();
                }
            }
        }

        private void Inv_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                DataTable dt2 = new DataTable();
                Sale_Overview expn = new Sale_Overview(Cust_name_lbl.Text, Ttlamt_lbl.Text, gst_lbl.Text, disamt_lbl.Text, final_lbl.Text, 1, amtrem.ToString(), Convert.ToInt64(Inv_Num.Text));
                DialogResult res = expn.ShowDialog();
                if (res == DialogResult.OK)
                {
                    amtgiven = expn.amtgiven();
                    expn.Hide();
                    printDocument1 = new PrintDocument();


                    printDocument1.PrintPage += printDocument1_PrintPage;

                    // Attach the PrintDocument to a PrintDialog for user configuration
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument1;

                    // Initialize the DataGridViewPrinter
                    DataGridViewPrinter(Invoice_Data);
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                    this.Controls.Clear();
                    this.InitializeComponent();
                    this.Hide();
                    Dashboard dsh = new Dashboard();
                    dsh.Show();
                }
            }
            if (user == 0)
            {
                DataTable dt2 = new DataTable();
                Sale_Overview expn = new Sale_Overview(Cust_name_lbl.Text, Ttlamt_lbl.Text, gst_lbl.Text, disamt_lbl.Text, final_lbl.Text, 0, "NA", Convert.ToInt64(Inv_Num.Text));
                DialogResult res = expn.ShowDialog();
                if (res == DialogResult.OK)
                {
                    amtgiven = expn.amtgiven();
                    expn.Hide();
                    printDocument1 = new PrintDocument();


                    printDocument1.PrintPage += printDocument1_PrintPage;

                    // Attach the PrintDocument to a PrintDialog for user configuration
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument1;

                    // Initialize the DataGridViewPrinter
                    DataGridViewPrinter(Invoice_Data);
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                    this.Controls.Clear();
                    this.InitializeComponent();
                    this.Hide();
                    Dashboard dsh = new Dashboard();
                    dsh.Show();
                }
            }
        }
        private void get_sum()
        {
            t_cgst = 0;
            t_sgst = 0;
            t_igst = 0;

            foreach (DataGridViewRow row in Invoice_Data.Rows)
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

            foreach (DataGridViewRow row in Invoice_Data.Rows)
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

            foreach (DataGridViewRow row in Invoice_Data.Rows)
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

        }

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
                    printArea.Y += 140;

                    // Draw Date and Invoice Number
                    string dateAndInvoiceNumber = $"Bill Date: {dategen.Value.ToString("dd-MMM-yyyy")}\nPrinted On: {DateTime.Now.ToShortDateString()}\nInvoice Number: {inv_num}";
                    graphics.DrawString(dateAndInvoiceNumber, contentFont, Brushes.Black, new PointF(600, 50));

                    // Adjust Y for the next section
                    //printArea.Y += 50;

                    string billToInfo = $"Bill To:\nCustomer Name: {Cust_name_lbl.Text}\nCity: {City_label.Text}\nPhone No. : {Phno_lbl.Text}\nEmail I'd: {mailid}\nGSTN No.:{cust_gstn}";
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
            int[] columnsToPrint = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12 };
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

                float[] manualColumnWidths = { 30, 68, 180, 40, 40, 50, 50, 50, 50, 40, 40, 40, 50 };

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
            string amttopay = "";
            string summaryInfo = "";
            if (user == 0)
            {
                summaryInfo = $"Summary\n\nSubtotal                      {Math.Round(Convert.ToDouble(Ttlamt_lbl.Text), 3)}\nDiscount                     -{Math.Round(Convert.ToDouble(disamt_lbl.Text), 3)}\nGST                         +{Math.Round(Convert.ToDouble(gst_lbl.Text), 3)}\nTotal                           {Math.Round(Convert.ToDouble(final_lbl.Text), 3)}\nReveived                     {((Convert.ToDouble(final_lbl.Text)))}\nRemaining                    0                            Reveivers Signature                            Authorised Signatory";
                amttopay = "0";
            }
            if (user == 1)
            {
                summaryInfo = $"Summary\n\nSubtotal                      {Math.Round(Convert.ToDouble(Ttlamt_lbl.Text), 3)}\nDiscount                     -{Math.Round(Convert.ToDouble(disamt_lbl.Text), 3)}\nGST                      +{Math.Round(Convert.ToDouble(gst_lbl.Text), 3)}\nTotal                           {Math.Round(Convert.ToDouble(final_lbl.Text), 3)}\nReveived                     {((Convert.ToDouble(final_lbl.Text)) - Convert.ToDouble(amtrem - amtgiven))}\nRemaining                   {Math.Round(Convert.ToDouble(amtrem - amtgiven), 3)}                            Reveivers Signature                            Authorised Signatory";
                amttopay = Math.Round(Convert.ToDouble(amtrem - amtgiven), 3).ToString();
            }

            graphics.DrawLine(Pens.Black, 35, printArea.Y - 5, 773, printArea.Y - 5);
            // Draw the summary section
            string greating = "Thank you for your business!";
            string inend = "Customer Copy";
            DataTable dtbk = eps.GetDataTable("SELECT * from bk_details");
            string bk = "";
            string vpa = "";
            string accname = "";
            string gstbreakdown = $"GST Breakdown :\nCGST                     {Math.Round(t_cgst, 3)}\nSGST                     {Math.Round(t_sgst, 3)}\nIGST                      {Math.Round(t_igst, 3)}";
            foreach (DataRow row in dtbk.Rows)
            {
                bk = $"Bank Details:\n\nBank Name:{row[0].ToString()}\nAccount Number:{row[1].ToString()}\nIFSC Code:{row[2].ToString()}\nAcc. Holder Name:{row[3].ToString()}";
                vpa = row[4].ToString();
                accname = row[3].ToString();
            }


            Bitmap qrCodeImage = null; // Declaring qrCodeImage at the class level

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
            graphics.DrawLine(Pens.Black, 35, printArea.Y - 3, 773, printArea.Y - 3);
            graphics.DrawString(greating, contentFont, Brushes.Black, new PointF(330, printArea.Y));
            printArea.Y += 30;
            graphics.DrawString(inend, contentFont, Brushes.Black, new PointF(375, printArea.Y));
            printArea.X -= 30;

            RectangleF invoiceRect = new RectangleF(35, 20, printArea.X, printArea.Y); // Adjust the height as needed
            graphics.DrawRectangle(Pens.Black, invoiceRect.Left, invoiceRect.Top, invoiceRect.Width, invoiceRect.Height);
        }
        #endregion

        private void Invoices_Load(object sender, EventArgs e)
        {
            InvType = "";
             amtrem = 0;
              user=0;
             mailid="";
             amtgiven=0;
             headerprinted = 0;
             shpnm = null;
             ownernm = null;
             Phnoshp = null;
             emailshp = null;
             addr1 = null;
             addr2 = null;
             gstn = null;
             dategen = null;
            inv_num=0;
            cgst = 0;
            sgst = 0;
            igst = 0;
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
            timer1.Start();
            DAY_LBL.Text = DateTime.Today.DayOfWeek.ToString();
            Shpnm_lbl.Text = shpnm;
            gstn_lbl.Text = gstn;
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            S2B s2B = new S2B();
            s2B.Show();
            this.Hide();
        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            import.Show();
            this.Hide();
        }

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            S2C s2C = new S2C();
            s2C.Show();
            this.Hide();
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void Retailers_btn_Click(object sender, EventArgs e)
        {
            View_Retailers view_Retailers = new View_Retailers();
            view_Retailers.Show();
            this.Hide();
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            Reporting reporting = new Reporting();
            reporting.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invoices invoices = new Invoices();
            invoices.Show();
            this.Hide();
        }

        private void Invoices_FormClosing(object sender, FormClosingEventArgs e)
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

        private void History_btn_Click(object sender, EventArgs e)
        {
            Return returnpg = new Return();
            returnpg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quotation quotation = new Quotation();
            quotation.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DT_LBL.Text = datetime.ToString();
        }
    }
}
