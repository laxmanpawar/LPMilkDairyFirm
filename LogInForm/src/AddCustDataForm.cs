using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class AddCustDataForm : Form
    {
        public AddCustDataForm()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.CustNameTextBox.Clear();
            this.CustIdTextBox.Clear();
            this.CustMilkTypeComboBox.SelectedItem = null;
            this.CustMobTextBox.Clear();
            this.CustNameTextBox.Focus();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustMobTextBox.Text))
            {
                CustNameErrorProvider.SetError(CustMobTextBox, "Please provide Customer Mob number");
            }
            else if (string.IsNullOrEmpty(CustIdTextBox.Text))
            {
                CustIdTextBox.Focus();
                CustIdErrorProvider.SetError(CustIdTextBox, "Please provide Customer Id");
            }
            else if (CustMilkTypeComboBox.SelectedItem == null)
            {
                CustMilkTypeComboBox.Focus();
                CustMilkTypeErrorProvider.SetError(CustMilkTypeComboBox, "Please provide Customer Name");
            }
            else if (string.IsNullOrEmpty(CustMobTextBox.Text))
            {
                CustMobErrorProvider.SetError(CustMobTextBox, "Please provide Customer Mob number");
            }
            else
            {
                string strConnectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

                SqlConnection sqlCon = new SqlConnection(strConnectionString);

                string isCustExistsQuery = "select * from CUSTOMER_DATA_TABLE where CUST_ID = @custid";
                SqlCommand isCustExistsCmd = new SqlCommand(isCustExistsQuery, sqlCon);
                isCustExistsCmd.Parameters.AddWithValue("@custid", CustIdTextBox.Text);

                sqlCon.Open();
                SqlDataReader sqlDataReader = isCustExistsCmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    CustIdTextBox.Focus();
                    MessageBox.Show("Customer id already present.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sqlCon.Close();
                }
                else
                {
                    sqlCon.Close();
                    string query = "insert into CUSTOMER_DATA_TABLE values(@custid, @custname, @custmilktype, @custmob)";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@custid", CustIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@custname", CustNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@custmilktype", CustMilkTypeComboBox.SelectedItem);
                    cmd.Parameters.AddWithValue("@custmob", CustMobTextBox.Text);

                    // Open Sql Connection
                    sqlCon.Open();

                    // ExecuteNonQuery() method is used for three casee
                    //  1) Insert
                    //  2) Update
                    //  3) Delete
                    int isSuccess = cmd.ExecuteNonQuery();
                    if (isSuccess > 0)
                    {
                        MessageBox.Show("Customer Data has been added.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CustIdTextBox.Focus();
                        CustIdTextBox.Clear();
                        CustNameTextBox.Clear();
                        CustMilkTypeComboBox.SelectedText = "";
                        CustMobTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Customer Data insertion is failed.", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlCon.Close();

                }
            }
        }

        private void CustNameTextBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(CustNameTextBox.Text))
            {
                CustNameTextBox.Focus();
                CustNameErrorProvider.SetError(CustNameTextBox, "Please provide Customer Name");
            }
            else
            {
                CustNameErrorProvider.Clear();
            }
        }

        private void CustIdTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustIdTextBox.Text))
            {
                CustIdTextBox.Focus();
                CustIdErrorProvider.SetError(CustIdTextBox, "Please provide Customer Id");
            }
            else
            {
                CustIdErrorProvider.Clear();
            }
        }

        private void MilkTypeComboBox_Leave(object sender, EventArgs e)
        {
            if (CustMilkTypeComboBox.SelectedItem == null)
            {
                CustMilkTypeComboBox.Focus();
                CustMilkTypeErrorProvider.SetError(CustMilkTypeComboBox, "Please provide Customer Name");
            }
            else
            {
                CustMilkTypeErrorProvider.Clear();
            }
        }

        private void CustMobTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustMobTextBox.Text))
            {
                CustMobErrorProvider.SetError(CustMobTextBox, "Please provide Customer Mob number");
            }
            else
            {
                CustMobErrorProvider.Clear();
            }
        }

        private void CustIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustMobTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddCustDataForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
