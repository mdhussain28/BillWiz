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
    public partial class LOC_box : Form
    {
        public static Boolean confirmation;

        public LOC_box()
        {
            InitializeComponent();
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            confirmation = false;
        }
    }
}
