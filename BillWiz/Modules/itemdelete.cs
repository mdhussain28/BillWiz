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
    public partial class itemdelete : Form
    {
        public itemdelete()
        {
            InitializeComponent();
        }

        SQL.SQL eps = new SQL.SQL();
        private void itemdelete_Load(object sender, EventArgs e)
        {
            items_by_category.DataSource = eps.GetDataTable("select Product_Name from Items_DB");
            items_by_category.DisplayMember = "Product_Name";
            items_by_category.ValueMember = "Product_Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Items_DB WHERE Product_Name = '{items_by_category.Text}'";

            // Execute the query
            eps.SetDataTable(sql);

            MessageBox.Show("Item deleted successfully!");
            this.Hide();

            DialogResult = DialogResult.OK;
        }
    }
}
