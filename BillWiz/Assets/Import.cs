using BillWiz.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillWiz.UI
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        SQL.SQL eps = new SQL.SQL();
        static DataTable dt = new DataTable();
        string? shpnm = null;
        string? ownernm = null;
        string? Phnoshp = null;
        string? emailshp = null;
        string? addr1 = null;
        string? addr2 = null;
        string? gstn = null;

        private void Import_Load(object sender, EventArgs e)
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
            dt.Clear();
            Import_grid.Rows.Clear();
            dt = eps.GetDataTable("select Product_Name,HSN_SAC,Barcode_num from Items_DB");
            foreach (DataRow dr in dt.Rows)
            {
                Import_grid.Rows.Add("", dr[2].ToString(), dr[1].ToString(), "Items_DB", dr[0].ToString(), 0, 0);
            }
            UpdateRowNumbers();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            int columnIndexprice = 5; // replace with the actual column index
            int columnIndexqty = 6; // replace with the actual column index
            int i = 0;

            foreach (DataGridViewRow row in Import_grid.Rows)
            {
                if (!row.IsNewRow) // Skip the new row if your DataGridView allows new rows
                {
                    object priceCellValue = row.Cells[columnIndexprice].Value;
                    object qtyCellValue = row.Cells[columnIndexqty].Value;

                    if ((priceCellValue != null && Convert.ToDouble(priceCellValue) > 0) && (qtyCellValue != null && Convert.ToDouble(qtyCellValue) > 0))
                    {
                        string? cellValue = row.Cells[columnIndexprice].Value.ToString();
                        Confirm_import.Rows.Add("", Import_grid.Rows[i].Cells[1].Value, Import_grid.Rows[i].Cells[2].Value, Import_grid.Rows[i].Cells[3].Value, Import_grid.Rows[i].Cells[4].Value, Import_grid.Rows[i].Cells[5].Value, Import_grid.Rows[i].Cells[6].Value);
                        i = i + 1;
                    }
                    else
                    {
                        Console.WriteLine("Row " + row.Index + ", Cell " + columnIndexprice + " is empty");
                        i = i + 1;
                    }
                }
            }
            UpdateRowNumbers();
            Import_grid.Visible = false;
            Confirm_import.Visible = true;
            Sim_btn.Visible = false;
            add_btn.Visible = true;
        }

        private void Import_grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            if (columnIndex == 5 || columnIndex == 6)
            {
                string? inputValue = e.FormattedValue.ToString();

                if (!IsNumeric(inputValue))
                {
                    MessageBox.Show("Please enter a numeric value in this column.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            UpdateRowNumbers();
            DateTime date_to = DateTime.Now.Date;
            string? date_today = date_to.ToString("dd-MMM-yyyy");

            if (Confirm_import.RowCount >= 1)
            {
                for (int rowIndex = 0; rowIndex < Confirm_import.Rows.Count; rowIndex++)
                {

                    DataGridViewRow row = Confirm_import.Rows[rowIndex];
                    string? sql = $"UPDATE Items_DB SET Qty = Qty + {Convert.ToDouble(Confirm_import.Rows[rowIndex].Cells[6].Value)} where Barcode_num = '{Confirm_import.Rows[rowIndex].Cells[1].Value}'";
                    eps.SetDataTable(sql);
                    sql = $"INSERT INTO Import_data values({Confirm_import.Rows[rowIndex].Cells[1].Value},'{date_today}','Items_DB','{Convert.ToString(Confirm_import.Rows[rowIndex].Cells[4].Value)}',{Confirm_import.Rows[rowIndex].Cells[5].Value},{Confirm_import.Rows[rowIndex].Cells[6].Value},{(Convert.ToDouble(Confirm_import.Rows[rowIndex].Cells[5].Value) * Convert.ToDouble(Confirm_import.Rows[rowIndex].Cells[6].Value))})";
                    eps.SetDataTable(sql);
                }
                MessageBox.Show("Stock Imported Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Confirm_import.Rows.Clear();
            Import_grid.Rows.Clear();
            Confirm_import.Visible = false;
            Import_grid.Visible = true;
            Sim_btn.Visible = true;
            add_btn.Visible = false;
        }

        private void Import_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            S2B exp = new S2B();
            exp.Show();
            this.Hide();
        }

        private void Confirm_import_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateRowNumbers()
        {
            // Iteamt through rows and update row numbers
            for (int i = 0; i < Import_grid.Rows.Count; i++)
            {
                // DataGridView column index for "Row Number" column
                int rowNumberColumnIndex = 0;

                // Update the "Row Number" column value
                Import_grid.Rows[i].Cells[rowNumberColumnIndex].Value = (i + 1).ToString();
            }

            for (int i = 0; i < Confirm_import.Rows.Count; i++)
            {
                // DataGridView column index for "Row Number" column
                int rowNumberColumnIndex = 0;

                // Update the "Row Number" column value
                Confirm_import.Rows[i].Cells[rowNumberColumnIndex].Value = (i + 1).ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DT_LBL.Text = datetime.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            S2C s2C = new S2C();
            s2C.Show();
            this.Hide();
        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            import.Show();
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

        private void Import_grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, decimal point, and control keys (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // Suppress the key press if it's not a valid character
                e.Handled = true;
            }

            // Allow only one decimal point
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void Import_grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox textBox = (TextBox)e.Control;
                textBox.KeyPress += Import_grid_KeyPress;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Itemadd itemadd = new Itemadd();
            itemadd.ShowDialog();
            if (itemadd.DialogResult == DialogResult.OK)
            {
                this.Hide();
                Import import = new Import();
                import.Show();
            }
        }
    }
}
