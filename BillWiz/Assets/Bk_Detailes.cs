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
    public partial class Bk_Detailes : Form
    {
        public Bk_Detailes()
        {
            InitializeComponent();
        }
        SQL.SQL eps = new SQL.SQL();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Bank_Name.Text))
            {
                if (!string.IsNullOrEmpty(Acc_num.Text))
                {
                    if (!string.IsNullOrEmpty(IFSC.Text))
                    {
                        if (!string.IsNullOrEmpty(upiid.Text))
                        {
                            if (!string.IsNullOrEmpty(accholder.Text))
                            {
                                eps.SetDataTable($"UPDATE bk_details SET BK_NAME = '{Bank_Name.Text}', Account_num = '{Acc_num.Text}', IFSC_Code = '{IFSC.Text}',Account_holder = '{accholder.Text}',upi_id='{upiid.Text}'");
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }
    }
}
