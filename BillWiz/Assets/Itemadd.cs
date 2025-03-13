using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillWiz.UI
{
    public partial class Itemadd : Form
    {
        public Itemadd()
        {
            InitializeComponent();
        }

        SQL.SQL eps = new SQL.SQL();

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Item_name.Text))
            {
                if (!string.IsNullOrEmpty(hsnsac.Text))
                {
                    if (!string.IsNullOrEmpty(Ret_rate.Text))
                    {
                        if (!string.IsNullOrEmpty(rate.Text))
                        {
                            if (!string.IsNullOrEmpty(mrp.Text))
                            {
                                if (!string.IsNullOrEmpty(qty.Text))
                                {
                                    if (!string.IsNullOrEmpty(uom.Text))
                                    {
                                        if (!string.IsNullOrEmpty(cgst.Text))
                                        {
                                            if (!string.IsNullOrEmpty(sgst.Text))
                                            {
                                                if (!string.IsNullOrEmpty(igst.Text))
                                                {
                                                    if (!string.IsNullOrEmpty(Rate_Purchased.Text))
                                                    {
                                                        DataTable dt = eps.GetDataTable($"SELECT * from Items_DB WHERE Product_Name = '{Item_name.Text}' COLLATE Latin1_General_CI_AI");
                                                        if (dt.Rows.Count > 0)
                                                        {
                                                            MessageBox.Show("Item allready Exist");
                                                        }
                                                        else
                                                        {
                                                            BigInteger barcode = 0;
                                                            DateTime date_to = DateTime.Now.Date;
                                                            string? date_today = date_to.ToString("dd-MMM-yyyy");
                                                            DataTable dataTable = eps.GetDataTable("SELECT NEXT VALUE FOR Items_seq AS BARCODE");
                                                            if (dataTable.Rows.Count > 0)
                                                            {
                                                                barcode = BigInteger.Parse(dataTable.Rows[0]["BARCODE"].ToString());
                                                                // Use the `barcode` as needed
                                                            }
                                                            else
                                                            {
                                                                // Handle case where no rows are returned
                                                                throw new Exception("No data returned from query.");
                                                            }
                                                            eps.SetDataTable($"INSERT INTO Items_DB values('{Item_name.Text}',{hsnsac.Text},{qty.Text},'{uom.Text}',{rate.Text},{barcode},{mrp.Text},{Convert.ToDouble(cgst.Text) / 100},{Convert.ToDouble(sgst.Text) / 100},{Convert.ToDouble(igst.Text) / 100},{Ret_rate.Text})");
                                                            eps.SetDataTable($"INSERT INTO Import_data VALUES ({barcode}, '{date_today}', 'Items_DB', '{Item_name.Text.Replace("'", "''")}', {Convert.ToDouble(Rate_Purchased.Text)}, {Convert.ToInt32(qty.Text)}, {Convert.ToDouble(Rate_Purchased.Text) * Convert.ToDouble(qty.Text)})");
                                                            MessageBox.Show(Rate_Purchased.Text);
                                                            MessageBox.Show("Item added Successfully");
                                                            this.Hide();
                                                            DialogResult = DialogResult.OK;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && cgst.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void sgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && sgst.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void igst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && igst.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void Rate_Purchased_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && igst.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
