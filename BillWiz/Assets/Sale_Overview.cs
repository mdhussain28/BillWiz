using System.Data;
using System.Numerics;

namespace BillWiz.UI
{
    public partial class Sale_Overview : Form
    {
        static int txt;
        static BigInteger invnum;
        public Sale_Overview(string shp, string lga, string gst, string damt, string ttl,int txt1,string amtrem,BigInteger inv)
        {
            InitializeComponent();
            lbl_shp.Text = shp;
            lbl_tga.Text = lga;
            lbl_gst.Text = gst;
            lbl_damt.Text = damt;
            lbl_total.Text = ttl;
            txt_amtg.Text = ttl;
            txt = txt1;
            amtrem_txt.Text = amtrem;
            invnum = inv;
        }
        SQL.SQL eps = new SQL.SQL();

        private void Export_Next_Load(object sender, EventArgs e)
        {
            if (txt == 0)
            {
                txt_amtg.Enabled = false;
                if (invnum > 0)
                {
                    DataTable dt1 = eps.GetDataTable($"SELECT * from Cust_Invoices_items_DB WHERE Invoice_num = {invnum}");
                    foreach (DataRow dr in dt1.Rows)
                    {
                        lbl_shp.Text = " ";
                        lbl_own.Text = dr[1].ToString();
                        lbl_phno.Text = dr[10].ToString();
                        city_lbl.Text = dr[9].ToString();
                        lbl_in.Text = "NA";
                        lbl_out.Text = "NA";
                    }
                }
            }
            else
            {
                txt_amtg.Enabled = true;
            }
            DataTable dt = eps.GetDataTable("Select * from Retailers_Database where Shop_name = @shp", "@shp", lbl_shp.Text);
            foreach (DataRow dr in dt.Rows)
            {
                city_lbl.Text = dr[5].ToString();
                lbl_own.Text = dr[2].ToString();
                lbl_phno.Text = dr[3].ToString();
                double inamt = Convert.ToDouble(dr[8].ToString());
                lbl_in.Text =Math.Round(inamt,2).ToString();
                lbl_out.Text = dr[9].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (amtrem_txt.Text=="NA")
            {
                if (Convert.ToDouble(txt_amtg.Text) <= Convert.ToDouble(lbl_total.Text))
                {
                    DialogResult = DialogResult.OK;
                    if (txt == 1)
                    {
                        eps.SetDataTable($"UPDATE Retailers_Database set total_item_purchased_amt = total_item_purchased_amt + {Convert.ToDouble(lbl_total.Text)},inward_amt = inward_amt + ({(Convert.ToDouble(lbl_total.Text)) - (Convert.ToDouble(txt_amtg.Text))}) where Shop_name = '{lbl_shp.Text}'");

                    }
                }
                else
                {
                    MessageBox.Show("Entered Amount is greater than bill amount");
                }
            } 
            else
            {
                if (Convert.ToDouble(txt_amtg.Text) <= Convert.ToDouble(amtrem_txt.Text))
                {
                    DialogResult = DialogResult.OK;
                    if (txt == 1)
                    {
                        eps.SetDataTable($"UPDATE Retailers_Database set inward_amt = inward_amt - ({(Convert.ToDouble(txt_amtg.Text))}) where Shop_name = '{lbl_shp.Text}'");
                        eps.SetDataTable($"UPDATE Retailers_Invoice_items_DB set given_amt = given_amt + {(Convert.ToDouble(txt_amtg.Text))} where Shop_name = '{lbl_shp.Text}' AND Invoice_id = {invnum}");
                        eps.SetDataTable($"UPDATE All_Sale_Invoices set amt_given = amt_given + {(Convert.ToDouble(txt_amtg.Text))} where Cust_name = '{lbl_shp.Text}' AND Invoice_num = {invnum}");

                    }
                }
                else
                {
                    MessageBox.Show("Entered Amount is greater than reamining amount");
                }
            }
        }

        public double amtgiven()
        {
            return Convert.ToDouble(txt_amtg.Text);
        }

        private void CLR_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txt_amtg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && txt_amtg.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txt_amtg_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_amtg.Text))
            {
                txt_amtg.Text = "0";
            }
        }
    }
}
