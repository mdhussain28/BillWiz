using BillWiz.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;

namespace BillWiz
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        SQL.SQL eps = new SQL.SQL();
        DataTable dt, dt1, dt2;
        static string InvType = "";
        double amtrem = 0;
        static int user;
        string cust_nm = " ";
        string phno = "", mailid = "", city = "";
        double amtgiven;
        int headerprinted = 0;
        string? shpnm = null;
        string? ownernm = null;
        string? Phnoshp = null;
        string? emailshp = null;
        string? addr1 = null;
        string? addr2 = null;
        string? gstn = null;
        DateTime? dategen = null;
        BigInteger inv_num;
        double t_cgst = 0;
        double t_sgst = 0;
        double t_igst = 0;
        double gst = 0;
        double total_amt = 0;
        double gross_amt = 0;
        double t_discount_amt = 0;
        double discount_per = 0;
        double cgst_init = 0;
        double sgst_init = 0;
        double igst_init = 0;
        double cgst = 0;
        double sgst = 0;
        double igst = 0;
        string cust_gstn = "";
        bool programmaticRowAddition = false;
        double custid = 0;

        PrintDocument printDocument1;
        private DataGridView dataGridView;
        private int rowIndex;
        private void Return_Load(object sender, EventArgs e)
        {
            InvType = "";
            amtrem = 0;
            user = 0;
            cust_nm = " ";
            phno = ""; mailid = ""; city = "";
            amtgiven = 0;
            headerprinted = 0;
            shpnm = null;
            ownernm = null;
            Phnoshp = null;
            emailshp = null;
            addr1 = null;
            addr2 = null;
            gstn = null;
            dategen = null;
            inv_num = 0;
            t_cgst = 0;
            t_sgst = 0;
            t_igst = 0;
            gst = 0;
            total_amt = 0;
            gross_amt = 0;
            t_discount_amt = 0;
            discount_per = 0;
            cgst_init = 0;
            sgst_init = 0;
            igst_init = 0;
            cgst = 0;
            sgst = 0;
            igst = 0;
            bool programmaticRowAddition = false;
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
            Shpnm_lbl.Text = shpnm;
            gstn_lbl.Text = gstn;
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
                if (row.Cells[8].Value != null && !string.IsNullOrEmpty(row.Cells[8].Value.ToString()))
                {
                    // Parse the cell value to a decimal and add to the total sum
                    if (double.TryParse(row.Cells[8].Value.ToString(), out double cellValue))
                    {
                        total_amt = total_amt + cellValue;
                    }
                }
            }

            foreach (DataGridViewRow row in Invoice_Data.Rows)
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

            t_discount_amt = gross_amt - total_amt;
            gst = t_cgst + t_sgst + t_igst;
            Ttlamt_lbl.Text = total_amt.ToString();
            gst = Math.Round(gst, 3);
            total_amt = total_amt + gst;
            total_amt = Math.Round(total_amt, 3);
            t_discount_amt = Math.Round(t_discount_amt, 3);
            final_lbl.Text = total_amt.ToString();
            gst_lbl.Text = gst.ToString();
            disamt_lbl.Text = t_discount_amt.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Invoice_Data.Rows.Clear();
            Invoice_Data.AllowUserToAddRows = false;
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
                    Invoice_Data.Visible = true;
                    dt = eps.GetDataTable($"SELECT * from Retailers_Invoice_items_DB WHERE Invoice_id = {Inv_Num.Text}");
                    inv_num = Convert.ToInt64(Inv_Num.Text);
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataTable dtgst = eps.GetDataTable($"SELECT CGST,SGST,IGST FROM Items_DB WHERE Barcode_num = {dr[13].ToString()}");
                        foreach (DataRow dr2 in dtgst.Rows)
                        {
                            cgst = Convert.ToDouble(dr2[0].ToString());
                            sgst = Convert.ToDouble(dr2[1].ToString());
                            igst = Convert.ToDouble(dr2[2].ToString());

                        }
                        programmaticRowAddition = true;
                        Invoice_Data.Rows.Add("", dr[9].ToString(), dr[2].ToString(), dr[3].ToString(), dr[11].ToString(), dr[12].ToString(), dr[14].ToString(), dr[4].ToString(), dr[10].ToString(), (Convert.ToDouble(dr[10].ToString())) * cgst, (Convert.ToDouble(dr[10].ToString())) * sgst, (Convert.ToDouble(dr[10].ToString())) * igst, (Convert.ToDouble(dr[10].ToString()) + (Convert.ToDouble(dr[10].ToString()) * igst) + (Convert.ToDouble(dr[10].ToString()) * sgst) + (Convert.ToDouble(dr[10].ToString()) * cgst)), dr[3].ToString(), dr[13].ToString());
                        programmaticRowAddition = false;
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
                    dt1 = eps.GetDataTable($"SELECT SUM(rate),SUM(gst),SUM(Discounted_amt) from Retailers_Invoice_items_DB WHERE Invoice_id = {Inv_Num.Text}");
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

                    discount_per = ((Convert.ToDouble(Invoice_Data.Rows[0].Cells[7].Value) - Convert.ToDouble(Invoice_Data.Rows[0].Cells[8].Value)) / Convert.ToDouble(Invoice_Data.Rows[0].Cells[7].Value));
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
                        programmaticRowAddition = true;
                        Invoice_Data.Rows.Add("", dr[12].ToString(), dr[2].ToString(), dr[3].ToString(), dr[14].ToString(), dr[15].ToString(), dr[17].ToString(), dr[4].ToString(), dr[13].ToString(), (Convert.ToDouble(dr[13].ToString())) * cgst, (Convert.ToDouble(dr[13].ToString())) * sgst, (Convert.ToDouble(dr[13].ToString())) * igst, (Convert.ToDouble(dr[13].ToString()) + (Convert.ToDouble(dr[13].ToString()) * igst) + (Convert.ToDouble(dr[13].ToString()) * sgst) + (Convert.ToDouble(dr[13].ToString()) * cgst)), dr[3].ToString(), dr[16].ToString());
                        programmaticRowAddition = false;
                        final_lbl.Text = dr[7].ToString();
                        amtrem = (Convert.ToDouble(dr[7].ToString())) - Convert.ToDouble(dr[8].ToString());
                        Cust_name_lbl.Text = dr[1].ToString();
                        cust_gstn = "NA";
                    }
                    dt1 = eps.GetDataTable($"SELECT SUM(rate),SUM(gst),SUM(Discounted_amt) from Cust_Invoices_items_DB WHERE Invoice_num = {Inv_Num.Text}");
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        Ttlamt_lbl.Text = dr1[0].ToString();
                        disamt_lbl.Text = (Convert.ToDouble(dr1[0].ToString()) - Convert.ToDouble(dr1[2].ToString())).ToString();
                        gst_lbl.Text = dr1[1].ToString();
                    }
                    discount_per = ((Convert.ToDouble(Invoice_Data.Rows[0].Cells[7].Value) - Convert.ToDouble(Invoice_Data.Rows[0].Cells[8].Value)) / Convert.ToDouble(Invoice_Data.Rows[0].Cells[7].Value));
                    UpdateRowNumbers();
                    get_sum();
                }
            }
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < Invoice_Data.Rows.Count; i++)
            {
                int rowNumberColumnIndex = 0;

                Invoice_Data.Rows[i].Cells[rowNumberColumnIndex].Value = (i + 1).ToString();
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
                Return_Overview expn = new Return_Overview(Convert.ToInt64(Inv_Num.Text), Convert.ToDouble(Ttlamt_lbl.Text), Convert.ToDouble(gst_lbl.Text), Convert.ToDouble(final_lbl.Text), 1);
                DialogResult res = expn.ShowDialog();
                if (res == DialogResult.OK)
                {
                    amtgiven = expn.amtgiven;
                    double flucuation = expn.fluc;
                    double inwardnew = expn.newinward;
                    double newamtgiven = expn.newamtremgiven;
                    double oldremamt = expn.oldremamt;
                    double newbillremamt = expn.newbillremamt;
                    double amttotake = expn.newamttake;
                    double newbill = expn.newbill;
                    expn.Hide();
                    cust_nm = Cust_name_lbl.Text;
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

                    for (int row = 0; row < Invoice_Data.Rows.Count; row++)
                    {
                        double gstu = Math.Round(Convert.ToDouble(Invoice_Data.Rows[row].Cells[9].Value) + Convert.ToDouble(Invoice_Data.Rows[row].Cells[10].Value), 3);
                        eps.SetDataTable($"UPDATE Retailers_Invoice_items_DB SET  qty = {Invoice_Data.Rows[row].Cells[3].Value} , rate = {Invoice_Data.Rows[row].Cells[7].Value}, Discounted_amt = {Invoice_Data.Rows[row].Cells[8].Value} , gst = {gstu} WHERE Invoice_id = {Inv_Num.Text} AND item = '{Invoice_Data.Rows[row].Cells[2].Value}' ");
                        eps.SetDataTable($"UPDATE Items_DB SET qty = qty + {(Convert.ToDouble(Invoice_Data.Rows[row].Cells[13].Value.ToString())) - (Convert.ToDouble(Invoice_Data.Rows[row].Cells[3].Value.ToString()))} WHERE Barcode_num = {Invoice_Data.Rows[row].Cells[14].Value}");

                    }
                    eps.SetDataTable($"UPDATE All_Sale_Invoices SET Bill_amt = {final_lbl.Text} , amt_given = {amtgiven} WHERE Invoice_num = {Inv_Num.Text} ");
                    eps.SetDataTable($"UPDATE Retailers_Invoice_items_DB SET total_amt = {final_lbl.Text} , given_amt = {amtgiven} WHERE Invoice_id = {Inv_Num.Text} ");
                    MessageBox.Show(cust_nm);

                    eps.SetDataTable($"UPDATE Retailers_Database SET inward_amt = inward_amt - {oldremamt} WHERE Shop_name = '{cust_nm}' ");
                    eps.SetDataTable($"UPDATE Retailers_Database SET inward_amt = inward_amt + {newbillremamt} WHERE Shop_name = '{cust_nm}' ");
                    if (amttotake > 0)
                    {
                        eps.SetDataTable($"UPDATE Retailers_Database SET inward_amt = inward_amt - {newamtgiven} WHERE Shop_name = '{cust_nm}' ");

                    }
                    eps.SetDataTable($"UPDATE Retailers_Database SET total_item_purchased_amt = total_item_purchased_amt - {flucuation} WHERE Shop_name = '{cust_nm}' ");
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
                Return_Overview expn = new Return_Overview(Convert.ToInt64(Inv_Num.Text), Convert.ToDouble(Ttlamt_lbl.Text), Convert.ToDouble(gst_lbl.Text), Convert.ToDouble(final_lbl.Text), 0);
                DialogResult res = expn.ShowDialog();
                if (res == DialogResult.OK)
                {
                    amtgiven = expn.amtgiven;
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

                    for (int row = 0; row < Invoice_Data.Rows.Count; row++)
                    {
                        double gstu = Math.Round(Convert.ToDouble(Invoice_Data.Rows[row].Cells[9].Value) + Convert.ToDouble(Invoice_Data.Rows[row].Cells[10].Value), 3);
                        eps.SetDataTable($"UPDATE Cust_Invoices_items_DB SET qty = {Invoice_Data.Rows[row].Cells[3].Value}, rate = {Invoice_Data.Rows[row].Cells[7].Value} , Discounted_amt = {Invoice_Data.Rows[row].Cells[8].Value} , gst = {gstu} where Invoice_num = {Inv_Num.Text} AND item = '{Invoice_Data.Rows[row].Cells[2].Value}' ");

                        eps.SetDataTable($"UPDATE Items_DB SET qty = qty + {(Convert.ToDouble(Invoice_Data.Rows[row].Cells[13].Value.ToString())) - (Convert.ToDouble(Invoice_Data.Rows[row].Cells[3].Value.ToString()))} WHERE Barcode_num = {Invoice_Data.Rows[row].Cells[14].Value}");
                    }
                    eps.SetDataTable($"UPDATE Cust_Invoices_items_DB SET total = {final_lbl.Text}, given = {amtgiven} where Invoice_num = {Inv_Num.Text}");
                    this.Controls.Clear();
                    this.InitializeComponent();
                    this.Hide();
                    Dashboard dsh = new Dashboard();
                    dsh.Show();
                }
            }
        }

        private void Return_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Invoice_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            get_sum();
        }

        private bool IsNumeric(string value)
        {
            decimal result;
            return decimal.TryParse(value, out result);
        }

        private void Invoice_Data_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            // Check if the validation is required for column 5 or column 6
            if (columnIndex == 3)
            {
                string inputValue = e.FormattedValue.ToString();

                // Check if the entered value is numeric
                if (!IsNumeric(inputValue))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a numeric value in this column.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Invoice_Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                if (Convert.ToDouble(Invoice_Data.Rows[e.RowIndex].Cells[13].Value) >= Convert.ToDouble(Invoice_Data.Rows[e.RowIndex].Cells[3].Value))
                {
                    // Get the new amt value from the 7th column
                    double newrate = Convert.ToDouble(Invoice_Data.Rows[e.RowIndex].Cells[6].Value);
                    double qty_1 = Convert.ToDouble(Invoice_Data.Rows[e.RowIndex].Cells[3].Value);
                    double newamt = newrate * qty_1;
                    double discount_value = discount_per;
                    DataTable dtgst = eps.GetDataTable($"SELECT CGST,SGST,IGST FROM Items_DB WHERE Barcode_num = {Invoice_Data.Rows[rowIndex].Cells[14].Value}");
                    foreach (DataRow row in dtgst.Rows)
                    {
                        cgst_init = Convert.ToDouble(row[0].ToString());
                        sgst_init = Convert.ToDouble(row[1].ToString());
                        igst_init = Convert.ToDouble(row[2].ToString());
                    }
                    double newdiscountamt = newamt - (newamt * discount_value);
                    double cgst_1 = newdiscountamt * cgst_init;
                    double sgst_1 = newdiscountamt * sgst_init;
                    double igst_1 = newdiscountamt * igst_init;
                    Invoice_Data.Rows[e.RowIndex].Cells[7].Value = newamt;
                    Invoice_Data.Rows[e.RowIndex].Cells[8].Value = newdiscountamt;
                    Invoice_Data.Rows[e.RowIndex].Cells[9].Value = cgst_1;
                    Invoice_Data.Rows[e.RowIndex].Cells[10].Value = sgst_1;
                    Invoice_Data.Rows[e.RowIndex].Cells[11].Value = igst_1;
                    Invoice_Data.Rows[e.RowIndex].Cells[12].Value = newdiscountamt + cgst_1 + sgst_1 + igst_1;
                    get_sum();
                }
                else
                {
                    MessageBox.Show("Can't Increase the qty here");
                    Invoice_Data.Rows[e.RowIndex].Cells[3].Value = Invoice_Data.Rows[e.RowIndex].Cells[13].Value;
                }
            }
        }


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
                    string dateAndInvoiceNumber = $"Date: {DateTime.Now.ToShortDateString()}\nInvoice Number: {inv_num}";
                    graphics.DrawString(dateAndInvoiceNumber, contentFont, Brushes.Black, new PointF(600, 50));

                    // Adjust Y for the next section
                    //printArea.Y += 50;

                    string billToInfo = $"Bill To:\nCustomer Name: {cust_nm}\nCity: {city}\nPhone No. : {phno}\nEmail I'd: {mailid}\nGSTN No.: {cust_gstn}";
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
            int[] columnsToPrint = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
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
            graphics.DrawLine(Pens.Black, 35, printArea.Y - 5, 773, printArea.Y - 5);
            // Draw the summary section
            string summaryInfo = $"Summary\n\nSubtotal                      {Ttlamt_lbl.Text}\nDiscount                     -{disamt_lbl.Text}\nGST                          +{gst_lbl.Text}\nTotal                           {final_lbl.Text}\nReveived                     {amtgiven}\nRemaining                   {Math.Round(Convert.ToDouble(final_lbl.Text) - amtgiven, 3)}                            Reveivers Signature                            Authorised Signatory";
            string greating = "Thank you for your business!";
            string inend = "Customer Copy";
            DataTable dtbk = eps.GetDataTable("SELECT * from bk_details");
            string bk = "";
            string vpa = "";
            string accname = "";
            string amttopay = Math.Round(Convert.ToDouble(final_lbl.Text) - amtgiven, 3).ToString();
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
                            Width = 130,
                            Height = 130
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
            graphics.DrawImage(qrCodeImage, new Point(630, Convert.ToInt32(printArea.Y - 20)));
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

        private void Invoice_Data_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Invoice_Data_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!programmaticRowAddition && e.RowIndex == Invoice_Data.NewRowIndex)
            {
                e.Cancel = true;
            }
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

        private void History_btn_Click(object sender, EventArgs e)
        {
            Return returnpg = new Return();
            returnpg.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Quotation quotation = new Quotation();
            quotation.Show();
            this.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
        }
    }
}
