using BillWiz.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillWiz.UI
{
    public partial class Edit_Retailers_data : Form
    {
        SQL.SQL eps = new SQL.SQL();
        long rowtoedit;

        public Edit_Retailers_data(long rowtoedit_vr)
        {
            InitializeComponent();
            rowtoedit = rowtoedit_vr;
        }

        private void Edit_Retailers_data_Load(object sender, EventArgs e)
        {
            View_Retailers vr = new View_Retailers();
            DataTable dt = new DataTable();
            dt = eps.GetDataTable("Select * from Retailers_Database where Cust_id = @id", "@id", rowtoedit);
            foreach (DataRow DR in dt.Rows)
            {
                lblCust_id.Text = DR[0].ToString();
                SHPNM_TXT.Text = DR[1].ToString();
                OWNNM_TXT.Text = DR[2].ToString();
                INAMT_TXT.Text = DR[8].ToString();
                OUTAMT_TXT.Text = DR[9].ToString();
                PHNO_TXT.Text = DR[3].ToString();
                CITY_TXT.Text = DR[5].ToString();
                Email_TXT.Text = DR[4].ToString();
                gstn.Text = DR[11].ToString();
            }
        }

        private void Save_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SHPNM_TXT.Text))
            {
                MessageBox.Show("Please Enter Shop Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(OWNNM_TXT.Text))
                {
                    MessageBox.Show("Please Enter Owner Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(PHNO_TXT.Text))
                    {
                        MessageBox.Show("Please Enter Shop Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Regex.IsMatch(PHNO_TXT.Text, @"^[6-9]\d{9}$"))
                        {
                            if (string.IsNullOrWhiteSpace(CITY_TXT.Text))
                            {
                                MessageBox.Show("Please Enter City Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(gstn.Text))
                                {
                                    DateTime date_to = DateTime.Now.Date;
                                    string date_today = date_to.ToString("dd-MMM-yyyy");
                                    //insert query
                                    BigInteger phno = Convert.ToInt64(PHNO_TXT.Text);

                                    string sql = $" Update Retailers_Database set Shop_name='{SHPNM_TXT.Text}', Owner_name='{OWNNM_TXT.Text}', Ph_no='{PHNO_TXT.Text}',city='{CITY_TXT.Text}', mail_id='{Email_TXT.Text}',GSTN = '{gstn.Text}' where Cust_id = '{lblCust_id.Text}'";
                                    eps.SetDataTable(sql);
                                    MessageBox.Show("Retailer Data Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    DialogResult = DialogResult.OK;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Phone number in correct format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
