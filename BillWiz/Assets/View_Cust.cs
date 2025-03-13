using BillWiz.SQL;
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
    public partial class View_Cust : Form
    {
        public View_Cust()
        {
            InitializeComponent();
        }

        SQL.SQL eps = new SQL.SQL();

        string? Custname = null;
        string? phone_no = null;
        string? email = null;
        string? city = null;
        string? total_item_amt = null;
        DateTime? date_1 = null;
        public long rowtoedit;
        string? ttlgst = null;
        double ttl = 0;

        DataTable dt;

        private void View_Cust_Load(object sender, EventArgs e)
        {
            load_data();
        }

        public void load_data()
        {
            string sql = "SELECT Cust_name COLLATE SQL_Latin1_General_CP1_CI_AS, city COLLATE SQL_Latin1_General_CP1_CI_AS, MAX(phone), MAX(mailid), sum(total), sum(gst), MIN(date_in) FROM Cust_Invoices_items_DB GROUP BY Cust_name COLLATE SQL_Latin1_General_CP1_CI_AS, city COLLATE SQL_Latin1_General_CP1_CI_AS";
            dt = eps.GetDataTable(sql);
            foreach (DataRow DR in dt.Rows)
            {
                Custname = DR[0].ToString();
                phone_no = DR[2].ToString();
                email = DR[3].ToString();
                city = DR[1].ToString();
                total_item_amt = DR[4].ToString();
                ttlgst = DR[5].ToString();
                date_1 = Convert.ToDateTime(DR[6].ToString());
                Retailers_Grid.Rows.Add(Custname, phone_no, email, city, total_item_amt, ttlgst, date_1);
            }
            dt = eps.GetDataTable("SELECT SUM(total_amt) as grand_total from (SELECT total as total_amt from Cust_Invoices_items_DB Group by Invoice_num,total) as subselectquery");
            foreach (DataRow DR in dt.Rows)
            {
                ttl = Convert.ToDouble(DR[0].ToString());
            }
            lbl_gross_amt.Text = ttl.ToString();
        }

        private void CLR_Btn_Click(object sender, EventArgs e)
        {
            S2C s2C = new S2C();
            s2C.Show();
            this.Hide();
        }

        private void View_Cust_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DSBD_Btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
