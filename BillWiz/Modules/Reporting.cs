using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BillWiz.UI
{
    public partial class Reporting : Form
    {
        public Reporting()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        SQL.SQL eps = new SQL.SQL();

        string? invoice_num = null;
        string? Custname = null;
        string? phone_no = null;
        string? shopnm = null;
        string? email = null;
        string? city = null;
        string? total_item_amt = null;
        DateTime date_1;
        string? ttlgst = null;
        string? ttlamtgiven = null;
        DataTable dt = new DataTable();
        private int rowIndex;
        private PrintDocument? printDocument;
        double totalamt = 0;
        double billamt = 0;
        double totalgst = 0;
        double remainamt = 0;
        double ttlgiven = 0;
        string? shpnm = null;
        string? ownernm = null;
        string? Phnoshp = null;
        string? emailshp = null;
        string? addr1 = null;
        string? addr2 = null;
        string? gstn = null;
        private int currentPageNumber = 1;
        static int headerprinted = 0;



        public void load_data()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd MMMM yyyy";

            if (Report_type.Text == "Particular Reg Cust's Report")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                Retailers_Report.Visible = true;
                Cust_report_grid.Visible = false;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = false;
                Inventory_Report.Visible = false;
                Item_Pur_Report.Visible = false;
                qty_txt.Enabled = false;
                if (!string.IsNullOrEmpty(Retailer_select.Text))
                {
                    Retailers_Report.Rows.Clear();
                    string sql = $"SELECT Invoice_id, MAX(Shop_name), SUM(Discounted_amt), SUM(gst), MAX(date_in),Max(given_amt),ROUND((SUM(Discounted_amt) + SUM(gst)) - max(given_amt), 2) FROM Retailers_Invoice_items_DB WHERE date_in BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}' AND Shop_name = '{Retailer_select.Text}' GROUP BY Invoice_id ";
                    dt = eps.GetDataTable(sql);
                    foreach (DataRow DR in dt.Rows)
                    {
                        invoice_num = DR[0].ToString();
                        shopnm = DR[1].ToString();
                        total_item_amt = DR[2].ToString();
                        ttlgst = DR[3].ToString();
                        date_1 = Convert.ToDateTime(DR[4].ToString());
                        ttlamtgiven = DR[5].ToString();
                        Retailers_Report.Rows.Add(invoice_num, shopnm, Math.Round(Convert.ToDouble(total_item_amt), 2), Math.Round(Convert.ToDouble(ttlgst), 2), Math.Round(Convert.ToDouble(ttlamtgiven), 2), DR[6].ToString(), date_1.Date.ToString("dd-MM-yyyy"));
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Customer");
                }
                sort_grids();
            }
            if (Report_type.Text == "All Customer Report")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                Retailers_Report.Visible = false;
                Cust_report_grid.Visible = true;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = false;
                Inventory_Report.Visible = false;
                Item_Pur_Report.Visible = false;
                qty_txt.Enabled = false;
                Cust_report_grid.Rows.Clear();
                string sql = $"SELECT Invoice_num,max(Cust_name),max(city), MAX(phone), MAX(mailid), SUM(Discounted_amt), SUM(gst), MAX(date_in) FROM Cust_Invoices_items_DB WHERE date_in BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}' GROUP BY Invoice_num";
                dt = eps.GetDataTable(sql);
                foreach (DataRow DR in dt.Rows)
                {
                    invoice_num = DR[0].ToString();
                    Custname = DR[1].ToString();
                    phone_no = DR[3].ToString();
                    email = DR[4].ToString();
                    city = DR[2].ToString();
                    total_item_amt = DR[5].ToString();
                    ttlgst = DR[6].ToString();
                    date_1 = Convert.ToDateTime(DR[7].ToString());
                    Cust_report_grid.Rows.Add(invoice_num, Custname, phone_no, email, city, Math.Round(Convert.ToDouble(total_item_amt), 2), Math.Round(Convert.ToDouble(ttlgst), 2), date_1.Date.ToString("dd-MM-yyyy"));
                }
                sort_grids();
            }
            if (Report_type.Text == "All Sale Report")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                Retailers_Report.Visible = false;
                Cust_report_grid.Visible = false;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = true;
                Inventory_Report.Visible = false;
                Item_Pur_Report.Visible = false;
                qty_txt.Enabled = false;
                All_Sales.Rows.Clear();
                string sql = $"SELECT Invoice_num,Cust_name,Bill_amt,gst,amt_given,date_pur,Type,ROUND(Bill_amt - amt_given, 2) FROM All_Sale_Invoices WHERE date_pur BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}'";
                dt = eps.GetDataTable(sql);
                foreach (DataRow DR in dt.Rows)
                {
                    date_1 = Convert.ToDateTime(DR[5].ToString());
                    All_Sales.Rows.Add(DR[0].ToString(), DR[1].ToString(), Math.Round(Convert.ToDouble(DR[2].ToString()), 2), Math.Round(Convert.ToDouble(DR[3].ToString()), 2), Math.Round(Convert.ToDouble(DR[4].ToString()), 2), DR[6].ToString(), DR[7].ToString(), date_1.Date.ToString("dd-MM-yyyy"));
                }
                sort_grids();
            }
            if (Report_type.Text == "Total Money Inwards Report")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                Retailers_Report.Visible = false;
                Cust_report_grid.Visible = false;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = true;
                Inventory_Report.Visible = false;
                Item_Pur_Report.Visible = false;
                qty_txt.Enabled = false;
                All_Sales.Rows.Clear();
                string sql = $"SELECT Invoice_num,Cust_name,Bill_amt,gst,amt_given,date_pur,Type,ROUND(Bill_amt - amt_given, 2) FROM All_Sale_Invoices WHERE date_pur BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}' AND Bill_amt > amt_given";
                dt = eps.GetDataTable(sql);
                foreach (DataRow DR in dt.Rows)
                {
                    date_1 = Convert.ToDateTime(DR[5].ToString());
                    All_Sales.Rows.Add(DR[0].ToString(), DR[1].ToString(), Math.Round(Convert.ToDouble(DR[2].ToString()), 2), Math.Round(Convert.ToDouble(DR[3].ToString()), 2), Math.Round(Convert.ToDouble(DR[4].ToString()), 2), DR[6].ToString(), DR[7].ToString(), date_1.Date.ToString("dd-MM-yyyy"));
                }
                sort_grids();
            }
            if (Report_type.Text == "Stock Import Report")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                Retailers_Report.Visible = false;
                Cust_report_grid.Visible = false;
                All_Stock_Report.Visible = true;
                All_Sales.Visible = false;
                Inventory_Report.Visible = false;
                Item_Pur_Report.Visible = false;
                qty_txt.Enabled = false;
                All_Stock_Report.Rows.Clear();
                string sql = $"SELECT * FROM Import_data WHERE date_of_import BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}'";
                dt = eps.GetDataTable(sql);
                foreach (DataRow DR in dt.Rows)
                {
                    date_1 = Convert.ToDateTime(DR[1].ToString());
                    All_Stock_Report.Rows.Add(DR[0].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString(), date_1.Date.ToString("dd-MM-yyyy"));
                }
                sort_grids();
            }
            if (Report_type.Text == "All Reg Custs Report")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                Retailers_Report.Visible = true;
                Cust_report_grid.Visible = false;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = false;
                Inventory_Report.Visible = false;
                Item_Pur_Report.Visible = false;
                qty_txt.Enabled = false;
                Retailers_Report.Rows.Clear();
                string sql = $"SELECT Invoice_id, MAX(Shop_name), SUM(Discounted_amt), SUM(gst), MAX(date_in),Max(given_amt),ROUND((SUM(Discounted_amt) + SUM(gst)) - Max(given_amt), 2) FROM Retailers_Invoice_items_DB WHERE date_in BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}' GROUP BY Invoice_id";
                dt = eps.GetDataTable(sql);
                foreach (DataRow DR in dt.Rows)
                {
                    invoice_num = DR[0].ToString();
                    shopnm = DR[1].ToString();
                    total_item_amt = DR[2].ToString();
                    ttlgst = DR[3].ToString();
                    date_1 = Convert.ToDateTime(DR[4].ToString());
                    ttlamtgiven = DR[5].ToString();
                    Retailers_Report.Rows.Add(invoice_num, shopnm, Math.Round(Convert.ToDouble(total_item_amt), 2), Math.Round(Convert.ToDouble(ttlgst), 2), Math.Round(Convert.ToDouble(ttlamtgiven), 2), DR[6].ToString(), date_1.Date.ToString("dd-MM-yyyy"));
                }
                sort_grids();
            }
            if (Report_type.Text == "Particular Customer Report")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                Retailers_Report.Visible = false;
                Cust_report_grid.Visible = true;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = false;
                Inventory_Report.Visible = false;
                Item_Pur_Report.Visible = false;
                qty_txt.Enabled = false;
                Cust_report_grid.Rows.Clear();
                if (!string.IsNullOrEmpty(Retailer_select.Text))
                {
                    string sql = $"SELECT Invoice_num,max(Cust_name),max (city), MAX(phone), MAX(mailid), SUM(Discounted_amt), SUM(gst), MAX(date_in) FROM Cust_Invoices_items_DB WHERE date_in BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}' AND Cust_name = '{Retailer_select.Text}' AND city = '{City_Select.Text}' GROUP BY Invoice_num";
                    dt = eps.GetDataTable(sql);
                    foreach (DataRow DR in dt.Rows)
                    {
                        invoice_num = DR[0].ToString();
                        Custname = DR[1].ToString();
                        phone_no = DR[3].ToString();
                        email = DR[4].ToString();
                        city = DR[2].ToString();
                        total_item_amt = DR[5].ToString();
                        ttlgst = DR[6].ToString();
                        date_1 = Convert.ToDateTime(DR[7].ToString());
                        Cust_report_grid.Rows.Add(invoice_num, Custname, phone_no, email, city, Math.Round(Convert.ToDouble(total_item_amt), 2), Math.Round(Convert.ToDouble(ttlgst), 2), date_1.Date.ToString("dd-MM-yyyy"));
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Customer");
                }
                sort_grids();
            }
            if (Report_type.Text == "Reg Cust Item Purchase Report")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                Retailers_Report.Visible = false;
                Cust_report_grid.Visible = false;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = false;
                Inventory_Report.Visible = false;
                Item_Pur_Report.Visible = true;
                qty_txt.Enabled = false;
                Item_Pur_Report.Rows.Clear();
                if (!string.IsNullOrEmpty(Retailer_select.Text))
                {
                    string sql = $"SELECT Invoice_id, Shop_name, item, qty, Discounted_amt, gst, Discounted_amt + gst, date_in FROM Retailers_Invoice_items_DB WHERE date_in BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}' AND Shop_name = '{Retailer_select.Text}' ";
                    dt = eps.GetDataTable(sql);
                    foreach (DataRow DR in dt.Rows)
                    {
                        date_1 = Convert.ToDateTime(DR[7].ToString());
                        Item_Pur_Report.Rows.Add(DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), Math.Round(Convert.ToDouble(DR[4].ToString()), 2), Math.Round(Convert.ToDouble(DR[5].ToString()), 2), Math.Round(Convert.ToDouble(DR[6].ToString()), 2), date_1.Date.ToString("dd-MM-yyyy"));
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Customer");
                }
                sort_grids();
            }
            if (Report_type.Text == "Customer Item Purchase Report")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                Retailers_Report.Visible = false;
                Cust_report_grid.Visible = false;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = false;
                Inventory_Report.Visible = false;
                Item_Pur_Report.Visible = true;
                qty_txt.Enabled = false;
                Item_Pur_Report.Rows.Clear();
                if (!string.IsNullOrEmpty(Retailer_select.Text))
                {
                    string sql = $"SELECT Invoice_num, Cust_name, item, qty, Discounted_amt, gst, Discounted_amt + gst, date_in FROM Cust_Invoices_items_DB WHERE date_in BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}' AND Cust_name = '{Retailer_select.Text}'";
                    dt = eps.GetDataTable(sql);
                    foreach (DataRow DR in dt.Rows)
                    {
                        date_1 = Convert.ToDateTime(DR[7].ToString());
                        Item_Pur_Report.Rows.Add(DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), Math.Round(Convert.ToDouble(DR[4].ToString()), 2), Math.Round(Convert.ToDouble(DR[5].ToString()), 2), Math.Round(Convert.ToDouble(DR[6].ToString()), 2), date_1.Date.ToString("dd-MM-yyyy"));
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Customer");
                }
                sort_grids();
            }
            if (Report_type.Text == "Inventory Report")
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                Retailers_Report.Visible = false;
                Cust_report_grid.Visible = false;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = false;
                Item_Pur_Report.Visible = false;
                Inventory_Report.Visible = true;
                qty_txt.Enabled = false;
                Inventory_Report.Rows.Clear();

                string sql1 = $"SELECT * FROM Items_DB";
                dt = eps.GetDataTable(sql1);
                foreach (DataRow DR in dt.Rows)
                {
                    Inventory_Report.Rows.Add(
                        DR[5].ToString(),
                        DR[1].ToString(),
                        DR[0].ToString(),
                        DR[2].ToString(),
                        DR[3].ToString(),
                        DR[6].ToString(),
                        DR[4].ToString(),
                        Math.Round(Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[7].ToString()) + Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[8].ToString()) + Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[9].ToString()), 3),
                        Math.Round(Math.Round(Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[7].ToString()) + Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[8].ToString()) + Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[9].ToString()), 3) + Convert.ToDouble(DR[4].ToString()), 2)
                    );
                }
                dt.Clear();

            }
            sort_grids();
            if (Report_type.Text == "Inventory Report Below Spe. Qty")
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                qty_txt.Enabled = true;
                Retailers_Report.Visible = false;
                Cust_report_grid.Visible = false;
                All_Stock_Report.Visible = false;
                All_Sales.Visible = false;
                Item_Pur_Report.Visible = false;
                Inventory_Report.Visible = true;
                Inventory_Report.Rows.Clear();
                if (!string.IsNullOrEmpty(qty_txt.Text))
                {
                    string sql1 = $"SELECT * FROM Items_DB WHERE qty <= {Convert.ToDouble(qty_txt.Text)}";
                    dt = eps.GetDataTable(sql1);
                    foreach (DataRow DR in dt.Rows)
                    {
                        Inventory_Report.Rows.Add(
                            DR[5].ToString(),
                            DR[1].ToString(),
                            DR[0].ToString(),
                            DR[2].ToString(),
                            DR[3].ToString(),
                            DR[6].ToString(),
                            DR[4].ToString(),
                            Math.Round(Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[7].ToString()) + Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[8].ToString()) + Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[9].ToString()), 3),
                            Math.Round(Math.Round(Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[7].ToString()) + Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[8].ToString()) + Convert.ToDouble(DR[4].ToString()) * Convert.ToDouble(DR[9].ToString()), 3) + Convert.ToDouble(DR[4].ToString()), 2)
                        );
                    }
                    dt.Clear();
                }
                sort_grids();
            }
        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DAY_LBL.Text = DateTime.Today.DayOfWeek.ToString();
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
            if (Report_type.Text != "Particular Customer Report" && Report_type.Text != "Particular Reg Cust's Report")
            {
                Retailer_select.Enabled = false;
                City_Select.Enabled = false;
                load_data();
            }
            if (Retailer_select.SelectedIndex >= 0)
            {
                load_data();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (Report_type.Text != "Particular Customer Report" && Report_type.Text != "Particular Reg Cust's Report")
            {
                Retailer_select.Enabled = false;
                City_Select.Enabled = false;
                load_data();
            }
            if (Retailer_select.SelectedIndex >= 0)
            {
                load_data();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (Report_type.Text != "Particular Customer Report" && Report_type.Text != "Particular Reg Cust's Report" && Report_type.Text != "Reg Cust Item Purchase Report" && Report_type.Text != "Customer Item Purchase Report")
            {
                Retailer_select.Enabled = false;
                City_Select.Enabled = false;

                load_data();
            }
            if (Retailer_select.SelectedIndex >= 0)
            {
                load_data();
            }
        }

        private void Report_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Report_type.Text == "Particular Reg Cust's Report" || Report_type.Text == "Reg Cust Item Purchase Report")
            {
                Retailer_select.Enabled = true;
                City_Select.Enabled = false;
                DataTable dt = eps.GetDataTable($"Select Shop_name from Retailers_Invoice_items_DB Group by Shop_name");
                Retailer_select.DataSource = dt;
                Retailer_select.ValueMember = "Shop_name";
                Retailer_select.DisplayMember = "Shop_name";
                Retailer_select.SelectedIndex = -1;
                Retailers_Report.Rows.Clear();
                Item_Pur_Report.Rows.Clear();
            }
            if (Report_type.Text == "Particular Customer Report" || Report_type.Text == "Customer Item Purchase Report")
            {
                Retailer_select.Enabled = true;
                City_Select.Enabled = true;
                DataTable dt = eps.GetDataTable($"Select Cust_name from Cust_Invoices_items_DB Group by Cust_name,city");
                DataTable dt1 = eps.GetDataTable($"Select city from Cust_Invoices_items_DB Group by Cust_name,city");
                City_Select.DataSource = dt1;
                City_Select.ValueMember = "city";
                City_Select.DisplayMember = "city";
                City_Select.SelectedIndex = -1;
                Retailer_select.DataSource = dt;
                Retailer_select.ValueMember = "Cust_name";
                Retailer_select.DisplayMember = "Cust_name";
                Retailer_select.SelectedIndex = -1;
                Cust_report_grid.Rows.Clear();
                Item_Pur_Report.Rows.Clear();
            }
            if (Report_type.Text != "Particular Customer Report" && Report_type.Text != "Particular Reg Cust's Report" && Report_type.Text != "Reg Cust Item Purchase Report" && Report_type.Text != "Customer Item Purchase Report")
            {
                Retailer_select.Enabled = false;
                City_Select.Enabled = false;
                load_data();
            }
        }

        private void Retailer_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Retailer_select.SelectedIndex >= 0)
            {
                load_data();
                DataTable dt1 = eps.GetDataTable($"Select city from Cust_Invoices_items_DB where Cust_name = '{Retailer_select.Text}' Group by Cust_name,city");
                City_Select.DataSource = dt1;
                City_Select.ValueMember = "city";
                City_Select.DisplayMember = "city";
                City_Select.SelectedIndex = -1;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DT_LBL.Text = datetime.ToString();
        }

        private void Reporting_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            S2C s2C = new S2C();
            s2C.Show();
            this.Hide();
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            Reporting reporting = new Reporting();
            reporting.Show();
            this.Hide();
        }


        private void PrintDataGridView(DataGridView dataGridViewToPrint, string reportTitle, float[] manualColumnWidths, PrintPageEventArgs e, int pageNumber)
        {
            float yPosition = 40;

            using (Font titleFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font contentFont = new Font("Verdana", 9))
            {
                // Draw Report Title
                if (headerprinted == 0)
                {
                    e.Graphics?.DrawString(reportTitle, titleFont, Brushes.Black, new PointF(40, yPosition));
                    headerprinted = 1;
                    yPosition += 60;
                    DrawContent(dataGridViewToPrint, manualColumnWidths, e, pageNumber, yPosition);
                }
                else
                {
                    yPosition = 40;
                    DrawContent(dataGridViewToPrint, manualColumnWidths, e, pageNumber, yPosition);
                }

            }

        }

        private void DrawContent(DataGridView dataGridViewToPrint, float[] manualColumnWidths, PrintPageEventArgs e, int pageNumber, float yPosition)
        {
            using (Font titleFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font contentFont = new Font("Verdana", 9))
            {
                using (Font pageNumberFont = new Font("Verdana", 8))
                {
                    string pageNumberText = "Page " + pageNumber;
                    e.Graphics?.DrawString(pageNumberText, pageNumberFont, Brushes.Black, new PointF(765, 1005));
                }
                currentPageNumber++;

                // Draw DataGridView Headers
                DrawTableHeader(dataGridViewToPrint, e, ref yPosition, manualColumnWidths);

                // Draw DataGridView Rows
                while (rowIndex < dataGridViewToPrint.Rows.Count)
                {
                    DataGridViewRow row = dataGridViewToPrint.Rows[rowIndex];

                    float xPosition = 40; // Initial X position

                    for (int columnIndex = 0; columnIndex < dataGridViewToPrint.Columns.Count; columnIndex++)
                    {
                        DataGridViewCell cell = row.Cells[columnIndex];
                        string? cellValue = cell.Value?.ToString();

                        float width = manualColumnWidths[columnIndex];
                        RectangleF cellRect = new RectangleF(xPosition, yPosition, width, 50);

                        StringFormat format = new StringFormat
                        {
                            Alignment = StringAlignment.Near,
                            LineAlignment = StringAlignment.Center
                        };

                        // Draw border
                        e.Graphics?.DrawRectangle(Pens.Black, cellRect.Left, cellRect.Top, cellRect.Width, cellRect.Height);

                        // Draw cell value
                        e.Graphics?.DrawString(cellValue, contentFont, Brushes.Black, cellRect, format);

                        xPosition += width; // Move to the next X position for the next column
                    }

                    rowIndex++;

                    if (yPosition + 70 > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    yPosition += 50;

                }

                DrawSummary(dataGridViewToPrint, e, ref yPosition, manualColumnWidths);
            }

            rowIndex = 0; // Reset rowIndex when all rows are printed
        }

        private void DrawSummary(DataGridView dataGridView, PrintPageEventArgs e, ref float yPosition, float[] manualColumnWidths)
        {
            using (Font contentFont = new Font("Arial", 9, FontStyle.Bold))
            {
                string summaryInfo = "";
                string endr = "End Of Report";
                string genon = $"Generated On {DateTime.Now.ToString("dd-MMM-yyyy")}";
                // Draw the summary section
                if (Report_type.Text == "Reg Cust Item Purchase Report" || Report_type.Text == "Customer Item Purchase Report")
                {
                    summaryInfo = $"\n\nSummary\n\nTotal Amount:       {totalamt}\nTotal Gst:              {totalgst}\nTotal Bill amt:       {billamt}\n";
                    e.Graphics?.DrawString(summaryInfo, contentFont, Brushes.Black, new PointF(40, yPosition));
                }
                if (Report_type.Text == "Inventory Report" || Report_type.Text == "Inventory Report Below Spe. Qty")
                {
                    yPosition += 40;
                    e.Graphics?.DrawString(genon, contentFont, Brushes.Black, new PointF(20, yPosition));
                    e.Graphics?.DrawString(endr, contentFont, Brushes.Black, new PointF(375, yPosition));
                }
                else
                {
                    summaryInfo = $"\n\nSummary\n\nTotal Amount:       {totalamt}\nTotal Gst:              {totalgst}\nTotal Bill amt:       {billamt}\nTotal Inward:        {remainamt}";
                    e.Graphics?.DrawString(summaryInfo, contentFont, Brushes.Black, new PointF(40, yPosition));
                    yPosition += 140;
                    e.Graphics?.DrawString(genon, contentFont, Brushes.Black, new PointF(40, yPosition));
                    e.Graphics?.DrawString(endr, contentFont, Brushes.Black, new PointF(375, yPosition));
                }

                yPosition += 120; // Adjust Y for the next section
            }
        }
        private void DrawTableHeader(DataGridView dataGridView, PrintPageEventArgs e, ref float yPosition, float[] manualColumnWidths)
        {
            using (Font contentFont = new Font("Arial", 9, FontStyle.Bold))
            {
                float xPosition = 40; // Initial X position

                for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                {
                    string columnName = dataGridView.Columns[columnIndex].HeaderText;
                    float width = manualColumnWidths[columnIndex];

                    RectangleF cellRect = new RectangleF(xPosition, yPosition, width, 50);
                    using (Brush brush = new SolidBrush(Color.LightGray))
                    {
                        e.Graphics?.FillRectangle(brush, cellRect);
                    }
                    StringFormat format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    // Draw border
                    e.Graphics?.DrawRectangle(Pens.Black, cellRect.Left, cellRect.Top, cellRect.Width, cellRect.Height);

                    // Draw column name
                    e.Graphics?.DrawString(columnName, contentFont, Brushes.Black, cellRect, format);

                    xPosition += width; // Move to the next X position for the next column
                }

                yPosition += 50; // Move to the next line after all column names are drawn
                //yPosition += 20; // Adjust Y for the next row
            }
        }

        private void sort_grids()
        {
            Retailers_Report.Sort(Retailers_Report.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            Cust_report_grid.Sort(Cust_report_grid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            All_Sales.Sort(All_Sales.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            All_Stock_Report.Sort(All_Stock_Report.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            Item_Pur_Report.Sort(Item_Pur_Report.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            Inventory_Report.Sort(Inventory_Report.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Print_Report_Click(object sender, EventArgs e)
        {

            if (Report_type.Text == "Particular Reg Cust's Report" || Report_type.Text == "All Reg Custs Report")
            {
                sort_grids();
                totalamt = 0;
                totalgst = 0;
                remainamt = 0;
                billamt = 0;
                foreach (DataGridViewRow row in Retailers_Report.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[2].Value.ToString(), out double cellValue))
                        {
                            totalamt += cellValue;
                        }
                    }
                    if (row.Cells[3].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[3].Value.ToString(), out double cellValue))
                        {
                            totalgst += cellValue;
                        }
                    }
                    if (row.Cells[4].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[4].Value.ToString(), out double cellValue))
                        {
                            ttlgiven += cellValue;
                        }
                    }
                    if (row.Cells[5].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[5].Value.ToString(), out double cellValue))
                        {
                            remainamt += cellValue;
                        }
                    }
                }
                billamt = totalamt + totalgst;
            }

            if (Report_type.Text == "All Customer Report" || Report_type.Text == "Particular Customer Report")
            {
                totalamt = 0;
                totalgst = 0;
                remainamt = 0;
                billamt = 0;
                foreach (DataGridViewRow row in Cust_report_grid.Rows)
                {
                    if (row.Cells[5].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[5].Value.ToString(), out double cellValue))
                        {
                            totalamt += cellValue;
                        }
                    }
                    if (row.Cells[6].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[6].Value.ToString(), out double cellValue))
                        {
                            totalgst += cellValue;
                        }
                    }
                    if (row.Cells[5].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[5].Value.ToString(), out double cellValue))
                        {
                            ttlgiven += cellValue;
                        }
                    }
                }
                billamt = totalamt + totalgst;
            }
            if (Report_type.Text == "All Sale Report" || Report_type.Text == "Total Money Inwards Report")
            {
                totalamt = 0;
                totalgst = 0;
                remainamt = 0;
                billamt = 0;
                foreach (DataGridViewRow row in All_Sales.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[2].Value.ToString(), out double cellValue))
                        {
                            billamt += cellValue;
                        }
                    }
                    if (row.Cells[3].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[3].Value.ToString(), out double cellValue))
                        {
                            totalgst += cellValue;
                        }
                    }
                    if (row.Cells[4].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[4].Value.ToString(), out double cellValue))
                        {
                            ttlgiven += cellValue;
                        }
                    }
                    if (row.Cells[6].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[6].Value.ToString(), out double cellValue))
                        {
                            remainamt += cellValue;
                        }
                    }
                }
                totalamt = billamt - totalgst;
            }
            if (Report_type.Text == "Stock Import Report")
            {
                totalamt = 0;
                totalgst = 0;
                remainamt = 0;
                billamt = 0;

                foreach (DataGridViewRow row in All_Stock_Report.Rows)
                {
                    if (row.Cells[5].Value != null) 
                    {
                        if (double.TryParse(row.Cells[5].Value.ToString(), out double cellValue))
                        {
                            billamt += cellValue;
                        }
                    }
                }
                totalamt = billamt; 
            }
            if (Report_type.Text == "Reg Cust Item Purchase Report" || Report_type.Text == "Customer Item Purchase Report")
            {
                totalamt = 0;
                totalgst = 0;
                remainamt = 0;
                billamt = 0;
                foreach (DataGridViewRow row in Item_Pur_Report.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[4].Value.ToString(), out double cellValue))
                        {
                            totalamt += cellValue;
                        }
                    }
                    if (row.Cells[5].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[5].Value.ToString(), out double cellValue))
                        {
                            totalgst += cellValue;
                        }
                    }
                    if (row.Cells[6].Value != null)
                    {
                        // Use Decimal.TryParse to handle potential non-numeric values
                        if (double.TryParse(row.Cells[6].Value.ToString(), out double cellValue))
                        {
                            billamt += cellValue;
                        }
                    }
                }
            }

            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            MessageBox.Show("Report Generated Successfully");
            headerprinted = 0;
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.Show();
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            printDocument.DefaultPageSettings.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters[0];
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Width and height are specified in hundredths of an inch
            printDocument.DefaultPageSettings.Margins = new Margins(35, 35, 20, 30);
            float[] manualColumnWidthsForGrid1 = { 70, 240, 120, 80, 80, 80, 80 };
            float[] manualColumnWidthsForGrid2 = { 60, 225, 85, 75, 75, 75, 75, 80 };
            float[] manualColumnWidthsForGrid3 = { 60, 175, 175, 70, 70, 70, 70, 70 };
            float[] manualColumnWidthsForGrid4 = { 60, 70, 230, 60, 60, 70, 65, 65, 70 };

            if (Report_type.Text == "Particular Reg Cust's Report")
            {
                PrintDataGridView(Retailers_Report, "Reg Cust's Purchace Report of " + Retailer_select.Text + "\nFrom " + dateTimePicker1.Text + " To " + dateTimePicker2.Text, manualColumnWidthsForGrid1, e, currentPageNumber);
            }
            if (Report_type.Text == "All Customer Report")
            {
                PrintDataGridView(Cust_report_grid, "All Customer's Report" + "\nFrom " + dateTimePicker1.Text + " To " + dateTimePicker2.Text, manualColumnWidthsForGrid2, e, currentPageNumber);

            }
            if (Report_type.Text == "All Sale Report")
            {
                PrintDataGridView(All_Sales, "All Reg. and UnReg. Cust/Customer Report" + "\nFrom " + dateTimePicker1.Text + " To " + dateTimePicker2.Text, manualColumnWidthsForGrid2, e, currentPageNumber);

            }
            if (Report_type.Text == "Stock Import Report")
            {
                PrintDataGridView(All_Stock_Report, "Stock Import Report" + "\nFrom " + dateTimePicker1.Text + " To " + dateTimePicker2.Text, manualColumnWidthsForGrid2, e, currentPageNumber);
            }
            if (Report_type.Text == "All Reg Custs Report")
            {
                PrintDataGridView(Retailers_Report, "All Reg Cust's Report" + "\nFrom " + dateTimePicker1.Text + " To " + dateTimePicker2.Text, manualColumnWidthsForGrid1, e, currentPageNumber);
            }
            if (Report_type.Text == "Particular Customer Report")
            {
                PrintDataGridView(Cust_report_grid, "Customer's Report of " + Retailer_select.Text + "\nFrom " + dateTimePicker1.Text + " To " + dateTimePicker2.Text, manualColumnWidthsForGrid2, e, currentPageNumber);
            }
            if (Report_type.Text == "Reg Cust Item Purchase Report")
            {
                PrintDataGridView(Item_Pur_Report, "Items Pur. Report of " + Retailer_select.Text + "\nFrom " + dateTimePicker1.Text + " To " + dateTimePicker2.Text, manualColumnWidthsForGrid3, e, currentPageNumber);
            }
            if (Report_type.Text == "Customer Item Purchase Report")
            {
                PrintDataGridView(Item_Pur_Report, "Items Pur. Report of " + Retailer_select.Text + "\nFrom " + dateTimePicker1.Text + " To " + dateTimePicker2.Text, manualColumnWidthsForGrid3, e, currentPageNumber);
            }
            if (Report_type.Text == "Inventory Report")
            {
                PrintDataGridView(Inventory_Report, "Inventory/Stock Report ", manualColumnWidthsForGrid4, e, currentPageNumber);
            }
            if (Report_type.Text == "Inventory Report Below Spe. Qty")
            {
                PrintDataGridView(Inventory_Report, "Inventory/Stock Report For Quantity Below " + qty_txt.Text, manualColumnWidthsForGrid4, e, currentPageNumber);
            }
            if (Report_type.Text == "Total Money Inwards Report")
            {
                PrintDataGridView(All_Sales, "Inventory/Stock Report ", manualColumnWidthsForGrid2, e, currentPageNumber);
            }

        }

        private void qty_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void qty_txt_TextChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            import.Show();
            this.Hide();
        }

        private void Retailers_btn_Click(object sender, EventArgs e)
        {
            View_Retailers View_Retailers = new View_Retailers();
            View_Retailers.Show();
            this.Hide();
        }

        private void City_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Retailer_select.SelectedIndex >= 0)
            {
                load_data();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quotation quotation = new Quotation();
            quotation.Show();
            this.Hide();
        }

        private void Return_btn_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Invoices invoices = new Invoices();
            invoices.Show();
            this.Hide();
        }
    }
}