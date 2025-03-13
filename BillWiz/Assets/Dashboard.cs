using System.Data;
using System.Diagnostics;

namespace BillWiz.UI
{
    public partial class Dashboard : Form
    {
        SQL.SQL eps = new SQL.SQL();
        string? shpnm = null;
        string? ownernm = null;
        string? Phnoshp = null;
        string? emailshp = null;
        string? addr1 = null;
        string? addr2 = null;
        string? gstn = null;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DT_LBL.Text = datetime.ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
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
            DataTable dt1 = eps.GetDataTable("SELECT SUM(Bill_amt) FROM All_Sale_Invoices");
            foreach (DataRow dr in dt1.Rows)
            {
                lbl_Sale.Text = dr[0].ToString();
            }
            DataTable dt2 = eps.GetDataTable("select SUM(price * qty) from Import_data");
            foreach (DataRow dr in dt2.Rows)
            {
                lbl_puramt.Text = dr[0].ToString();
            }
            DataTable dt3 = eps.GetDataTable("select SUM(Bill_amt - amt_given) from All_Sale_Invoices");
            foreach (DataRow dr in dt3.Rows)
            {
                lbl_inward.Text = dr[0].ToString();
            }
            if (!string.IsNullOrEmpty(lbl_puramt.Text))
            {
                if (!string.IsNullOrEmpty(lbl_Sale.Text))
                {
                    double reven = Math.Round(Convert.ToDouble(lbl_Sale.Text) - Convert.ToDouble(lbl_puramt.Text), 3);
                    if (reven > 0)
                    {
                        lbl_reven.Text = reven.ToString();
                    }
                    else
                    {
                        lbl_reven.Text = "NA";
                    }
                }
                else
                {
                    lbl_Sale.Text = "0";
                }

            }
            else
            {
                lbl_puramt.Text = "0";
                lbl_reven.Text = "NA";
            }


            int date2 = DateTime.Today.Month;

            DataTable dt4 = eps.GetDataTable($"SELECT SUM(Bill_amt) FROM All_Sale_Invoices WHERE datepart(month,date_pur) = {date2} ");
            foreach (DataRow dr in dt4.Rows)
            {
                lbl_Sale2.Text = dr[0].ToString();
            }

            DataTable dt5 = eps.GetDataTable($"select SUM(price * qty) from Import_data WHERE datepart(month,date_of_import) = {date2}");
            foreach (DataRow dr in dt5.Rows)
            {
                lbl_pur2.Text = dr[0].ToString();
            }

            DataTable dt6 = eps.GetDataTable($"select SUM(Bill_amt - amt_given) from All_Sale_Invoices WHERE datepart(month,date_pur) = {date2}");
            foreach (DataRow dr in dt6.Rows)
            {
                lbl_inward2.Text = dr[0].ToString();
            }
            if (!string.IsNullOrEmpty(lbl_pur2.Text))
            {
                if (!string.IsNullOrEmpty(lbl_Sale2.Text))
                {
                    double reven2 = Math.Round(Convert.ToDouble(lbl_Sale2.Text) - Convert.ToDouble(lbl_pur2.Text), 3);
                    if (reven2 > 0)
                    {
                        lbl_reven2.Text = reven2.ToString();
                    }
                    else
                    {
                        lbl_reven2.Text = "NA";
                    }
                }
                else
                {
                    lbl_Sale2.Text = "0";
                }

            }
            else
            {
                lbl_pur2.Text = "0";
                lbl_reven2.Text = "NA";
            }
            Invoices_Data.Rows.Clear();
            DataTable dt7 = eps.GetDataTable($"SELECT * from All_Sale_Invoices WHERE date_pur = '{DateTime.Today.ToString("dd-MMM-yyyy")}'");
            foreach (DataRow dr in dt7.Rows)
            {
                Invoices_Data.Rows.Add("", dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString());
            }

            DataTable dt8 = eps.GetDataTable($"SELECT SUM(Bill_amt) FROM All_Sale_Invoices WHERE date_pur = '{DateTime.Today.ToString("dd-MMM-yyyy")}' ");
            foreach (DataRow dr in dt8.Rows)
            {
                lbl_sltd.Text = dr[0].ToString();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Export_btn_Click(object sender, EventArgs e)
        {
            S2B exp = new S2B();
            exp.Show();
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

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            Reporting reporting = new Reporting();
            reporting.Show();
            this.Hide();
        }

        private void Retailers_btn_Click(object sender, EventArgs e)
        {
            View_Retailers view_Retailers = new View_Retailers();
            view_Retailers.Show();
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

        private void Return_btn_Click(object sender, EventArgs e)
        {
            Return returnpg = new Return();
            returnpg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = null;
                if (p == null)
                {
                    p = new Process();
                    p.StartInfo.FileName = "Calc.exe";
                    p.Start();
                }
                else
                {
                    p.Close();
                    p.Dispose();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Excepton" + ee.Message);
            }
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BillWiz_Info info = new BillWiz_Info();
            info.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bk_Detailes bk_Detailes = new Bk_Detailes();
            bk_Detailes.ShowDialog();
        }
    }
}
