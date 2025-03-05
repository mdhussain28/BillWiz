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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        SQL.SQL eps = new SQL.SQL();
        DataTable dt = new DataTable();
        string? category = null;
        string? shpnm = null;
        string? ownernm = null;
        string? Phnoshp = null;
        string? emailshp = null;
        string? addr1 = null;
        string? addr2 = null;
        string? gstn = null;

        private void Inventory_Load(object sender, EventArgs e)
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
            SWR_Inventory.Rows.Clear();
            SWR_Inventory.Visible = true;
            Dup_Grid.Rows.Clear();
            dt = eps.GetDataTable("select * from Items_DB");
            foreach (DataRow dr in dt.Rows)
            {
                SWR_Inventory.Rows.Add("", dr[5].ToString(), dr[1].ToString(), "NULL", dr[0].ToString(), dr[6].ToString(), dr[4].ToString(), Math.Round(Math.Round(Convert.ToDouble(dr[4].ToString()) * Convert.ToDouble(dr[7].ToString())) + (Convert.ToDouble(dr[4].ToString()) * Convert.ToDouble(dr[8].ToString())) + (Convert.ToDouble(dr[4].ToString()) * Convert.ToDouble(dr[9].ToString())), 3), dr[2].ToString(), dr[10].ToString());
                Dup_Grid.Rows.Add("", dr[5].ToString(), dr[1].ToString(), "NULL", dr[0].ToString(), dr[6].ToString(), dr[4].ToString(), Math.Round(Math.Round(Convert.ToDouble(dr[4].ToString()) * Convert.ToDouble(dr[7].ToString())) + (Convert.ToDouble(dr[4].ToString()) * Convert.ToDouble(dr[8].ToString())) + (Convert.ToDouble(dr[4].ToString()) * Convert.ToDouble(dr[9].ToString())), 3), dr[2].ToString(), dr[10].ToString());
            }
            category = "NULL";
            UpdateRowNumbers();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void UpdateRowNumbers()
        {
            // Iteamt through rows and update row numbers
            for (int i = 0; i < SWR_Inventory.Rows.Count; i++)
            {
                // DataGridView column index for "Row Number" column
                int rowNumberColumnIndex = 0;

                // Update the "Row Number" column value
                SWR_Inventory.Rows[i].Cells[rowNumberColumnIndex].Value = (i + 1).ToString();
            }
            for (int i = 0; i < Dup_Grid.Rows.Count; i++)
            {
                // DataGridView column index for "Row Number" column
                int rowNumberColumnIndex = 0;

                // Update the "Row Number" column value
                Dup_Grid.Rows[i].Cells[rowNumberColumnIndex].Value = (i + 1).ToString();
            }
        }

        private void SWR_Inventory_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            int columnIndex = e.ColumnIndex;

            // Check if the validation is required for column 5 or column 6
            if (columnIndex == 5 || columnIndex == 6)
            {
                string? inputValue = e.FormattedValue.ToString();

                // Check if the entered value is numeric
#pragma warning disable CS8604 // Possible null reference argument.
                if (!IsNumeric(inputValue))
                {
                    MessageBox.Show("Please enter a numeric value in this column.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
#pragma warning restore CS8604 // Possible null reference argument.
            }
        }

        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        private void Sim_btn_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row1 in SWR_Inventory.Rows)
            {
                // Check if the row is not a new row and if the index i is within the range of Dup_Grid rows
                if (!row1.IsNewRow && i < Dup_Grid.Rows.Count)
                {
                    DataGridViewRow row2 = Dup_Grid.Rows[i];

                    object mrpcellvalue1 = row1.Cells[5].Value;
                    object ratecellvalue1 = row1.Cells[6].Value;

                    object mrpcellvalue2 = row2.Cells[5].Value;
                    object ratecellvalue2 = row2.Cells[6].Value;

                    if (((mrpcellvalue1 != null && Convert.ToDouble(mrpcellvalue1) > Convert.ToDouble(mrpcellvalue2)) || (mrpcellvalue1 != null && Convert.ToDouble(mrpcellvalue1) < Convert.ToDouble(mrpcellvalue2))) || ((ratecellvalue1 != null && Convert.ToDouble(ratecellvalue1) > Convert.ToDouble(ratecellvalue2)) || (ratecellvalue1 != null && Convert.ToDouble(ratecellvalue1) < Convert.ToDouble(ratecellvalue2))))
                    {
                        Confirm_rates_grid.Rows.Add("", row1.Cells[1].Value, row1.Cells[2].Value, row1.Cells[3].Value, row1.Cells[4].Value, row1.Cells[5].Value, row1.Cells[6].Value, row1.Cells[7].Value, row1.Cells[8].Value, row1.Cells[9].Value);
                    }
                }

                i++;
            }

            Confirm_rates_grid.Visible = true;
            SWR_Inventory.Visible = false;
            add_btn.Visible = true;
        }

        private void SWR_Inventory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                if (Convert.ToDouble(SWR_Inventory.Rows[e.RowIndex].Cells[5].Value) >= Convert.ToDouble(SWR_Inventory.Rows[e.RowIndex].Cells[6].Value))
                {
                    // Get the new amt value from the 7th column
                    double newrate = Convert.ToDouble(SWR_Inventory.Rows[e.RowIndex].Cells[6].Value);
                    double gst = newrate * 0.18;
                    SWR_Inventory.Rows[e.RowIndex].Cells[7].Value = gst;
                }
                else
                {
                    MessageBox.Show("Entered amount is greater than MRP");
                    SWR_Inventory.Rows[e.RowIndex].Cells[6].Value = Dup_Grid.Rows[e.RowIndex].Cells[6].Value;
                }
            }

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            UpdateRowNumbers();
            DateTime date_to = DateTime.Now.Date;
            string? date_today = date_to.ToString("dd-MMM-yyyy");

            if (Confirm_rates_grid.RowCount >= 1)
            {
                for (int rowIndex = 0; rowIndex < Confirm_rates_grid.Rows.Count; rowIndex++)
                {

                    DataGridViewRow row = Confirm_rates_grid.Rows[rowIndex];
                    string? sql = $"UPDATE Items_DB SET MRP = {Convert.ToDouble(Confirm_rates_grid.Rows[rowIndex].Cells[5].Value)} , Item_Rate = {Convert.ToDouble(Confirm_rates_grid.Rows[rowIndex].Cells[6].Value)},Ret_Rate = {Convert.ToDouble(Confirm_rates_grid.Rows[rowIndex].Cells[9].Value)} where Barcode_num = '{Confirm_rates_grid.Rows[rowIndex].Cells[1].Value}'";
                    eps.SetDataTable(sql);

                }
                MessageBox.Show("Prices Manipulated Succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Confirm_rates_grid.Rows.Clear();
            SWR_Inventory.Rows.Clear();
            Dup_Grid.Rows.Clear();
            Confirm_rates_grid.Visible = false;
            SWR_Inventory.Visible = true;
            category = "";
            Sim_btn.Visible = true;
            add_btn.Visible = false;
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DT_LBL.Text = datetime.ToString();
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            import.Show();
            this.Hide();
        }

        private void SWR_Inventory_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SWR_Inventory_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox textBox = (TextBox)e.Control;

                textBox.KeyPress += SWR_Inventory_KeyPress;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itemdelete lcb = new itemdelete();
            DialogResult result = lcb.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Hide();
                Inventory inventory = new Inventory();
                inventory.Show();
            }
        }
    }
}
