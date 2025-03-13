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
    public partial class View_Retailers : Form
    {
        SQL.SQL eps = new SQL.SQL();
        public View_Retailers()
        {
            InitializeComponent();
        }

        BigInteger cust_id = 0;
        string? shopname = null;
        string? ownername = null;
        string? phone_no = null;
        string? email = null;
        string? city = null;
        string? total_item_pur = null;
        string? total_item_amt = null;
        string? inward = null;
        string? outward = null;
        DateTime? date_1 = null;
        public long rowtoedit;
        double ttl = 0;
        double inward_1 = 0;
        double outward_1 = 0;
        string? shpnm = null;
        string? gstn = null;

        private void View_Retailers_Load(object sender, EventArgs e)
        {
            DataTable dt = eps.GetDataTable("Select Shop_Name,GSTN from Owner_DB");
            foreach (DataRow dr in dt.Rows)
            {
                shpnm = dr[0].ToString();
                gstn = dr[1].ToString();
            }

            Shpnm_lbl.Text = shpnm;
            gstn_lbl.Text = gstn;
            timer1.Start();
            DAY_LBL.Text = DateTime.Today.DayOfWeek.ToString();
            load_data();
        }

        private void DSBD_Btn_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void Retailers_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == Retailers_Grid.Columns["EditButtonColumn"].Index)
            {
                rowtoedit = Convert.ToInt64(Retailers_Grid.Rows[e.RowIndex].Cells["Cust_id_column"].Value.ToString());
                Edit_Retailers_data erd = new Edit_Retailers_data(rowtoedit);
                DialogResult res = erd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    erd.Hide();
                    Retailers_Grid.Rows.Clear();
                    ttl = 0;
                    inward_1 = 0;
                    outward_1 = 0;
                    load_data();
                }
            }
        }

        public void load_data()
        {
            DataTable dt = eps.GetDataTable("Select * from Retailers_Database");
            foreach (DataRow DR in dt.Rows)
            {
                cust_id = Convert.ToInt64(DR[0].ToString());
                shopname = DR[1].ToString();
                ownername = DR[2].ToString();
                phone_no = DR[3].ToString();
                email = DR[4].ToString();
                city = DR[5].ToString();
                total_item_pur = DR[6].ToString();
                total_item_amt = DR[7].ToString();
                inward = DR[8].ToString();
                outward = DR[9].ToString();
                date_1 = Convert.ToDateTime(DR[10].ToString());
                ttl += Math.Round(Convert.ToDouble(DR[7].ToString()), 2);
                inward_1 += Math.Round(Convert.ToDouble(DR[8].ToString()), 2);
                outward_1 += Math.Round(Convert.ToDouble(DR[9].ToString()), 2);
                Retailers_Grid.Rows.Add(cust_id, shopname, ownername, phone_no, email, city, total_item_pur, Math.Round(Convert.ToDouble(total_item_amt), 2), Math.Round(Convert.ToDouble(inward), 2), outward, date_1);
            }
            lbl_gross_amt.Text = Convert.ToString(Math.Round(Convert.ToDouble(ttl.ToString()), 2));
            lbl_in.Text = Convert.ToString(Math.Round(Convert.ToDouble(inward_1.ToString()), 2));
            lbl_out.Text = Convert.ToString(Math.Round(Convert.ToDouble(outward_1.ToString()), 2));
        }

        private void View_Retailers_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Add_Retailer_Click(object sender, EventArgs e)
        {
            Add_Retailer ef = new Add_Retailer();
            ef.ShowDialog();
        }
    }
}
