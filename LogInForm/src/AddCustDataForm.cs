using LogInForm.src;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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
    public partial class AddCustDataForm : LPForm
    {
        public AddCustDataForm()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetAllControls();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustNameTextBox.Text))
            {
                CustNameTextBox.Focus();
                CustNameErrorProvider.SetError(CustNameTextBox, "Please provide Customer Name");
            }
            else if (string.IsNullOrEmpty(CustIdTextBox.Text))
            {
                CustIdTextBox.Focus();
                CustIdErrorProvider.SetError(CustIdTextBox, "Please provide Customer Code");
            }
            else if (CustMilkTypeComboBox.SelectedItem == null)
            {
                CustMilkTypeComboBox.Focus();
                CustMilkTypeErrorProvider.SetError(CustMilkTypeComboBox, "Please provide Customer Name");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);

                string isCustExistsQuery = "SELECT * FROM " + LPGlobalVariables.m_sCustomerDataTable + " WHERE CUST_CODE = @custcode";
                SqlCommand isCustExistsCmd = new SqlCommand(isCustExistsQuery, sqlCon);
                isCustExistsCmd.Parameters.AddWithValue("@custcode", CustIdTextBox.Text);

                sqlCon.Open();
                SqlDataReader sqlDataReader = isCustExistsCmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    CustIdTextBox.Focus();
                    MessageBox.Show("Customer code already present.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sqlCon.Close();
                }
                else
                {
                    sqlCon.Close();
                    string query = "insert into " + LPGlobalVariables.m_sCustomerDataTable + " values(@custcode, @custname, @custmilktype, @custmob, @custaccno)";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@custcode", CustIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@custname", CustNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@custmilktype", CustMilkTypeComboBox.SelectedIndex);
                    cmd.Parameters.AddWithValue("@custmob", CustMobTextBox.Text);
                    cmd.Parameters.AddWithValue("@custaccno", CustAccNoTextBox.Text);

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
                        ResetAllControls();
                    }
                    else
                    {
                        MessageBox.Show("Customer Data insertion is failed.", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlCon.Close();

                }
            }
        }

        private int ResetAllControls()
        {
            this.CustNameTextBox.Clear();
            this.CustIdTextBox.Clear();
            this.CustMobTextBox.Clear();
            this.CustAccNoTextBox.Clear();
            this.CustIdTextBox.Focus();
            return 0;
        }

        private void CustNameTextBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void CustIdTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CustIdTextBox.Text))
                {
                    CustIdTextBox.Focus();
                    CustIdErrorProvider.SetError(CustIdTextBox, "Please provide Customer Id");
                }
                else
                {
                    CustIdErrorProvider.Clear();
                    CustNameErrorProvider.Clear();

                    SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                    string query = "SELECT * FROM " + LPGlobalVariables.m_sCustomerDataTable + " WHERE CUST_CODE = @custcode";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@custcode", CustIdTextBox.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        CustNameTextBox.Text = dr.GetFieldValue<string>(1);
                        CustMilkTypeComboBox.SelectedIndex = dr.GetFieldValue<int>(2);
                        CustMobTextBox.Text = dr.GetFieldValue<Int64>(3).ToString();
                        CustAccNoTextBox.Text = dr.GetFieldValue<Int64> (4).ToString();
                    }
                    con.Close();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CustIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowNumbersInTextBox(sender, e);
        }

        private void CustMobTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowNumbersInTextBox(sender, e);
        }

        private void AddCustDataForm_Load(object sender, EventArgs e)
        {
            CustMilkTypeComboBox.SelectedIndex = 0;
        }

        private void m_pLoadXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustIdErrorProvider.Clear();
                CustNameErrorProvider.Clear();
                LPLoadMultiCustListForm custListForm = new LPLoadMultiCustListForm();
                custListForm.Show();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_pUpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
            try 
            {
                string query = "UPDATE " + LPGlobalVariables.m_sCustomerDataTable + " SET CUST_NAME = @cname, MILK_TYPE = @milktype, CUST_MOB = @custmob, CUST_ACC_NO = @custaccno WHERE CUST_CODE = @custcode";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@custcode", CustIdTextBox.Text);
                cmd.Parameters.AddWithValue("@cname", CustNameTextBox.Text);
                cmd.Parameters.AddWithValue("@milktype", CustMilkTypeComboBox.SelectedIndex);
                cmd.Parameters.AddWithValue("@custmob", CustMobTextBox.Text);
                cmd.Parameters.AddWithValue("@custaccno", CustAccNoTextBox.Text);
                con.Open();
                int isUpdated = cmd.ExecuteNonQuery();
                if (isUpdated > 0)
                {
                    ResetAllControls();
                    MessageBox.Show("Custmer Data Updated Successfully", "LPInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
