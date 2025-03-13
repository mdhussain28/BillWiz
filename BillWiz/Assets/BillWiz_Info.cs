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
    public partial class BillWiz_Info : Form
    {
        public BillWiz_Info()
        {
            InitializeComponent();
        }
        string shpnm;
        SQL.SQL eps = new SQL.SQL();
        private void BillWiz_Info_Load(object sender, EventArgs e)
        {
            DataTable dt = eps.GetDataTable("Select * from Owner_DB");
            foreach (DataRow dr in dt.Rows)
            {
                shpnm = dr[0].ToString();
            }

            Shpnm_lbl.Text = shpnm;
        }
    }
}
