using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BillWiz.UI
{
    public partial class Return_Overview : Form
    {
        BigInteger inv_num;
        double grossamt;
        double gst;
        double totalamt;
        int usertype;
        public double amtgiven;
        public double fluc;
        public double newinward;
        public double newamttake;
        public double newamtremgiven;
        public double oldremamt;
        public double totalamtrem;
        public double newbillremamt;
        public double amtgivennew;
        public double newbill;

        SQL.SQL eps = new SQL.SQL();
        public Return_Overview(BigInteger inv, double grossa, double gst1, double totala, int user)
        {
            InitializeComponent();
            inv_num = inv;
            grossamt = grossa;
            gst = gst1;
            totalamt = totala;
            usertype = user;
        }

        private void Return_Overview_Load(object sender, EventArgs e)
        {
            amtgiven = 0;
            fluc = 0;
            newinward = 0;
            newamttake = 0;
            newamtremgiven = 0;
            oldremamt = 0;
            totalamtrem = 0;
            newbillremamt = 0;
            amtgivennew = 0;
            newbill = 0;
            if (usertype == 0)
            {
                Inv_txt.Text = inv_num.ToString();
                amtgiven_txt.Enabled = false;

                if (inv_num >= 0)
                {
                    DataTable dt1 = eps.GetDataTable($"SELECT * from Cust_Invoices_items_DB WHERE Invoice_num = {inv_num}");
                    foreach (DataRow dr in dt1.Rows)
                    {
                        Shp_name_txt.Text = dr[1].ToString();
                        City_txt.Text = dr[9].ToString();
                        Rec_txt.Text = dr[7].ToString();
                        Curr_txt.Text = totalamt.ToString();
                        Ret_txt.Text = Math.Round((Convert.ToDouble(dr[8].ToString()) - totalamt), 3).ToString();
                        amtgivenrec_txt.Text = Math.Round(Convert.ToDouble(dr[8].ToString()), 3).ToString();
                        amttake_txt.Text = Math.Round(totalamt - (Convert.ToDouble(dr[8].ToString())), 3).ToString();
                        newbill = Convert.ToDouble(Curr_txt.Text);
                    }
                    amtgiven = Convert.ToDouble(Curr_txt.Text);
                }
            }

            if (usertype == 1)
            {
                Inv_txt.Text = inv_num.ToString();
                amtgiven_txt.Enabled = false;

                if (inv_num >= 0)
                {
                    DataTable dt1 = eps.GetDataTable($"SELECT * from Retailers_Invoice_items_DB WHERE Invoice_id = {inv_num}");
                    foreach (DataRow dr in dt1.Rows)
                    {
                        Shp_name_txt.Text = dr[1].ToString();
                        Rec_txt.Text = dr[7].ToString();
                        Curr_txt.Text = totalamt.ToString();
                        Ret_txt.Text = Math.Round((Convert.ToDouble(dr[8].ToString()) - totalamt), 3).ToString();
                        amtgivenrec_txt.Text = Math.Round(Convert.ToDouble(dr[8].ToString()), 3).ToString();
                        amttake_txt.Text = Math.Round(totalamt - (Convert.ToDouble(dr[8].ToString())), 3).ToString();
                        oldremamt = Convert.ToDouble(Rec_txt.Text) - Convert.ToDouble(amtgivenrec_txt.Text);
                        newbill = Convert.ToDouble(Curr_txt.Text);
                    }

                    if (Convert.ToDouble(amttake_txt.Text) > 0.0)
                    {
                        amtgiven_txt.ReadOnly = false;
                        amtgiven_txt.Enabled = true;
                        amtgiven_txt.Text = "0";
                    }
                    else
                    {
                        amtgiven_txt.Text = Curr_txt.Text;
                    }

                    DataTable dt2 = eps.GetDataTable($"SELECT city from Retailers_Database WHERE Shop_name = '{Shp_name_txt.Text}'");
                    foreach (DataRow dr in dt2.Rows)
                    {
                        City_txt.Text = dr[0].ToString();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usertype == 1)
            {
                if (Convert.ToDouble(amttake_txt.Text) > 0.0)
                {
                    if (Convert.ToDouble(amttake_txt.Text) >= Convert.ToDouble(amtgiven_txt.Text))
                    {
                        amtgiven = Math.Round(Convert.ToDouble(amtgivenrec_txt.Text) + Convert.ToDouble(amtgiven_txt.Text), 3);
                        fluc = Convert.ToDouble(Rec_txt.Text) - totalamt;
                        newinward = totalamt - amtgiven;
                        newamttake = Convert.ToDouble(amttake_txt.Text);
                        newamtremgiven = Convert.ToDouble(amtgiven_txt.Text);
                        newbillremamt = Convert.ToDouble(amttake_txt.Text);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Please Check the amt to take and enter amt");
                    }
                }
                else
                {
                    amtgiven = Math.Round(totalamt, 3);
                    fluc = Convert.ToDouble(Rec_txt.Text) - totalamt;
                    newinward = totalamt - amtgiven;
                    DialogResult = DialogResult.OK;
                }
            }
            if (usertype == 0)
            {
                if (Convert.ToDouble(amttake_txt.Text) > 0.0)
                {
                    if (Convert.ToDouble(amttake_txt.Text) >= Convert.ToDouble(amtgiven_txt.Text))
                    {
                        amtgiven = Math.Round(Convert.ToDouble(amtgivenrec_txt.Text) + Convert.ToDouble(amtgiven_txt.Text), 3);
                        fluc = Convert.ToDouble(Rec_txt.Text) - totalamt;
                        newinward = totalamt - amtgiven;
                        newamttake = Convert.ToDouble(amttake_txt.Text);
                        newamtremgiven = Convert.ToDouble(amtgiven_txt.Text);
                        newbillremamt = Convert.ToDouble(amttake_txt.Text);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Please Check the amt to take and enter amt");
                    }
                }
                else
                {
                    amtgiven = Math.Round(totalamt, 3);
                    fluc = Convert.ToDouble(Rec_txt.Text) - totalamt;
                    newinward = totalamt - amtgiven;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void amtgiven_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && amtgiven_txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void amtgiven_txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amtgiven_txt.Text))
            {
                amtgiven_txt.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
