using BillWiz.UI;
using System.Data;

namespace BillWiz
{
    public partial class Login_frm : Form
    {
        public Login_frm()
        {
            InitializeComponent();
        }
        SQL.SQL eps = new SQL.SQL();
        string? shpnm = null;

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if (PSWD_TXT.Text == "Temp")
            {
                Dashboard interface_pg = new Dashboard();
                interface_pg.Visible = false;
                interface_pg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Password");
            }
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {
            DataTable dt = eps.GetDataTable("Select Shop_Name from Owner_DB");
            foreach (DataRow dr in dt.Rows)
            {
                shpnm = dr[0].ToString();
            }

            Shpnm_txt.Text = shpnm;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BillWiz_Info billWiz_Info = new BillWiz_Info();
            billWiz_Info.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
