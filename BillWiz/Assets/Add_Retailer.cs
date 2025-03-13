using BillWiz.SQL;
using System.Numerics;
using System.Text.RegularExpressions;


namespace BillWiz.UI
{
    public partial class Add_Retailer : Form
    {
        SQL.SQL eps = new SQL.SQL();

        public Add_Retailer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Shop_Name.Text))
            {
                MessageBox.Show("Please Enter Shop Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Owner_Name.Text))
                {
                    MessageBox.Show("Please Enter Owner Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(Ph_No.Text))
                    {
                        MessageBox.Show("Please Enter Shop Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Regex.IsMatch(Ph_No.Text, @"^[6-9]\d{9}$"))
                        {
                            if (string.IsNullOrWhiteSpace(City.Text))
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
                                    BigInteger phno = Convert.ToInt64(Ph_No.Text);

                                    string sql = $"INSERT INTO Retailers_Database VALUES (NEXT VALUE FOR retailer_ids, '{Shop_Name.Text}', '{Owner_Name.Text}', '{phno}', '{Email_id.Text}', '{City.Text}', 0, 0, 0, 0, '{date_today}','{gstn.Text}')";
                                    eps.SetDataTable(sql);
                                    MessageBox.Show("Retailer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    DialogResult = DialogResult.OK;
                                }
                                else
                                {
                                    DateTime date_to = DateTime.Now.Date;
                                    string date_today = date_to.ToString("dd-MMM-yyyy");
                                    //insert query
                                    BigInteger phno = Convert.ToInt64(Ph_No.Text);

                                    string sql = $"INSERT INTO Retailers_Database VALUES (NEXT VALUE FOR retailer_ids, '{Shop_Name.Text}', '{Owner_Name.Text}', '{phno}', '{Email_id.Text}', '{City.Text}', 0, 0, 0, 0, '{date_today}','NA')";
                                    eps.SetDataTable(sql);
                                    MessageBox.Show("Retailer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Add_Retailer_Load(object sender, EventArgs e)
        {

        }
    }
}
