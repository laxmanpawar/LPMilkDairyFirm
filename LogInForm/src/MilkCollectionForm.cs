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

using System.Diagnostics;
using System.Security.Cryptography;

namespace LogInForm
{
    public partial class MilkCollectionForm : Form
    {
        string m_sMilkCollTime = "सकाळ";
        string m_sEngMilkCollTime = "Morning";
        string m_sCustMilkDataTableName = "";
        public MilkCollectionForm()
        {
            InitializeComponent();
        }

        public MilkCollectionForm(string sMilkCollectionTime)
        {
            m_sMilkCollTime = sMilkCollectionTime;
            InitializeComponent();
        }

        private void CustCodeTextBox_Leave(object sender, EventArgs e)
        {
            if (LPSQLTableUtils.IsTableExists(this.m_sCustMilkDataTableName) == 1 && LPSQLTableUtils.IsColumnPresent(this.m_sCustMilkDataTableName, "CUST_CODE", this.CustCodeTextBox.Text) == 1)
            {
                DialogResult res = MessageBox.Show("ग्राहक डेटा आधीच अस्तित्त्वात आहे. आपण सुधारित करू इच्छिता?", "LPInfo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes) ShowSelectedUserData(CustCodeTextBox.Text);
                else if (res == DialogResult.No)
                {
                    CustCodeTextBox.Focus();
                    return;
                }
            }
            SqlConnection sqlCon = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);

            string isCustExistsQuery = "Select * from CUSTOMER_DATA_TABLE Where CUST_ID = @custid";
            SqlCommand isCustExistsCmd = new SqlCommand(isCustExistsQuery, sqlCon);
            isCustExistsCmd.Parameters.AddWithValue("@custid", CustCodeTextBox.Text);

            try
            {
                sqlCon.Open();
                SqlDataReader sqlDataReader = isCustExistsCmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    CustNameTextBox.Text = (string)sqlDataReader["CUST_NAME"];
                    MilkTypeComboBox.SelectedItem = (string)sqlDataReader["MILK_TYPE"];

                }
                else
                {
                    this.CustCodeTextBox.Focus();
                    //MessageBox.Show("No data found for Customer code : " + CustCodeTextBox.Text, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sqlDataReader.Close();
            }
            finally
            {
                // close the connection
                if (sqlCon != null)
                {
                    sqlCon.Close();
                }
            }
        }

        private void CustCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowNumbersInTextBox(sender, e);
        }

        private void MilkCollectionForm_Load(object sender, EventArgs e)
        {
            BranchNamesComboBox.SelectedIndex = 0;

            if (m_sMilkCollTime == "सकाळ")
            {
                m_sEngMilkCollTime = "Morning";
            }
            else if (m_sMilkCollTime == "सायंकाळ")
            {
                m_sEngMilkCollTime = "Evening";
            }

            m_sCustMilkDataTableName = m_sEngMilkCollTime + "_" + DateTimePicker.Value.ToString("dd_MM_yyyy");
            MainLabel.Text = m_sMilkCollTime + " दूध संकलन";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);

                int isTableExists = LPSQLTableUtils.IsTableExists(m_sCustMilkDataTableName);

                if (isTableExists == 0)
                {
                    MessageBox.Show("LPInfo : Table is not present in dataBase.", "LPINFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Create new table 
                    List<string> columnNames = new List<string>() { "CUST_CODE", "CUST_NAME", "MILK_DATE", "MILK_TYPE", "MILK_WEIGHT", "MILK_FAT", "MILK_SNF", "MILK_DEGREE", "MILK_RATE", "MILK_AMOUNT" };
                    List<string> columnTypes = new List<string>() { "INT primary key", "NVARCHAR(MAX) NOT NULL", "DATE NOT NULL", "int NOT NULL", "FLOAT(10) NOT NULL", "FLOAT(5) NOT NULL", "FLOAT(5) NOT NULL", "FLOAT(5) NOT NULL", "FLOAT(5) NOT NULL", "FLOAT(10) NOT NULL" };
                    LPSQLTableUtils.CreateSQLTableInDB(m_sCustMilkDataTableName, columnNames, columnTypes);
                }


                string isCustExistsQuery = "select * from " + m_sCustMilkDataTableName + " where CUST_CODE = @custcode";
                SqlCommand isCustExistsCmd = new SqlCommand(isCustExistsQuery, sqlCon);
                isCustExistsCmd.Parameters.AddWithValue("@custcode", CustCodeTextBox.Text);

                sqlCon.Open();
                SqlDataReader sqlDataReader = isCustExistsCmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    SaveDailyCustMilkDataButton.Focus();
                    DialogResult result = MessageBox.Show("LPInfo : Customer id already present.\nDo you want to still continue?", "LPInfo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    sqlCon.Close();
                }
                else
                {
                    sqlCon.Close();

                    int code = int.Parse(CustCodeTextBox.Text);
                    string name = CustNameTextBox.Text;
                    int iMilkType = MilkTypeComboBox.SelectedIndex;
                    DateTime dateTime = DateTimePicker.Value;

                    double weight = 0, fat = 0, SNF = 0, degree = 0, milkRate = 0, amount = 0;
                    if (iMilkType == 0)
                    {
                        weight = double.Parse(CowWeightTextBox.Text);
                        fat = double.Parse(CowFatTextBox.Text);
                        SNF = double.Parse(CowSNFTextBox.Text);
                        degree = double.Parse(CowDegreeTextBox.Text);
                        milkRate = double.Parse(CowMilkRateTextBox.Text);
                        amount = double.Parse(CowAmountTextBox.Text);
                    }
                    else if (iMilkType == 1)
                    {
                        weight = double.Parse(CowWeightTextBox.Text);
                        fat = double.Parse(CowFatTextBox.Text);
                        SNF = double.Parse(CowSNFTextBox.Text);
                        degree = double.Parse(CowDegreeTextBox.Text);
                        milkRate = double.Parse(CowMilkRateTextBox.Text);
                        amount = double.Parse(CowAmountTextBox.Text);
                    }

                    // Save data to sql Server.
                    SqlConnection sqlConnection = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                    string query = "Insert into " + m_sCustMilkDataTableName + " values(@ccode, @cname, @datetime, @milkType, @weight, @fat, @SNF, @degree, @milkRate, @amount)";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);

                    // Add data
                    cmd.Parameters.AddWithValue("@ccode", code);
                    cmd.Parameters.AddWithValue("@cname", name);
                    cmd.Parameters.AddWithValue("@datetime", dateTime);
                    cmd.Parameters.AddWithValue("@milkType", iMilkType);
                    cmd.Parameters.AddWithValue("@fat", fat);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@SNF", SNF);
                    cmd.Parameters.AddWithValue("@degree", degree);
                    cmd.Parameters.AddWithValue("@milkRate", milkRate);
                    cmd.Parameters.AddWithValue("@amount", amount);

                    // Open Connection 
                    sqlConnection.Open();

                    // Execute query
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        BindDataGridView();
                        ResetAllCustMilkDataFields();
                        MessageBox.Show("Milk added successfully.", "LPSUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Customer Milk data.", "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPERROR : " + exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ShowSelectedUserData(string custCode)
        {
            try
            {
                int iCustCode = int.Parse(custCode);
                SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                string query = "SELECT * FROM " + this.m_sCustMilkDataTableName + " WHERE CUST_CODE = " + custCode;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CustNameTextBox.Text = dr.GetValue(dr.GetOrdinal("CUST_NAME")).ToString();
                    int milkType = int.Parse(dr.GetValue(dr.GetOrdinal("MILK_TYPE")).ToString());
                    MilkTypeComboBox.SelectedIndex = milkType;
                    if (milkType == 0)
                    {
                        this.CowWeightTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_WEIGHT")).ToString();
                        this.CowFatTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_FAT")).ToString();
                        this.CowSNFTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_SNF")).ToString();
                        this.CowDegreeTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_DEGREE")).ToString();
                        this.CowMilkRateTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_RATE")).ToString();
                        this.CowAmountTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_AMOUNT")).ToString();
                    }
                    else if (milkType == 1)
                    {
                        this.BuffWeightTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_WEIGHT")).ToString();
                        this.BuffFatTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_FAT")).ToString();
                        this.BuffSNFTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_SNF")).ToString();
                        this.BuffDegreeTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_DEGREE")).ToString();
                        this.BuffMilkRateTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_RATE")).ToString();
                        this.BuffAmountTextBox.Text = dr.GetValue(dr.GetOrdinal("MILK_AMOUNT")).ToString();
                    }
                    con.Close();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        void BindDataGridView()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                string query = "Select CUST_CODE, CUST_NAME, MILK_TYPE, MILK_WEIGHT, MILK_FAT, MILK_SNF, MILK_DEGREE, MILK_RATE, MILK_AMOUNT from " + m_sCustMilkDataTableName + "";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                CustMilkDataGridView.DataSource = dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPERROR : " + exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ResetAllCustMilkDataFields()
        {
            try
            {
                this.CustCodeTextBox.Clear();
                this.CustNameTextBox.Clear();
                this.MilkTypeComboBox.SelectedItem = null;

                // Cow TextBoxes
                this.CowWeightTextBox.Clear();
                this.CowFatTextBox.Clear();
                this.CowSNFTextBox.Clear();
                this.CowDegreeTextBox.Clear();
                this.CowMilkRateTextBox.Clear();
                this.CowAmountTextBox.Clear();

                // Buffalo TextBoxes
                this.BuffWeightTextBox.Clear();
                this.BuffFatTextBox.Clear();
                this.BuffSNFTextBox.Clear();
                this.BuffDegreeTextBox.Clear();
                this.BuffMilkRateTextBox.Clear();
                this.BuffAmountTextBox.Clear();

                this.CustCodeTextBox.Focus();

            }
            catch (Exception exc)
            {
                MessageBox.Show("LPERROR : " + exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        

        private void ViewButton_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void UpdateDailyCustMilkDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                string query = "Update " + m_sCustMilkDataTableName + " set CUST_CODE = @ccode, CUST_NAME = @cname, DATE = @datetime, MILK_TYPE = @milkType, MILK_WEIGHT = @weight, MILK_FAT = @fat, MILK_SNF = @SNF, MILK_DEGREE = @degree, MILK_RATE = @milkRate, MILK_AMOUNT =  @amount Where CUST_CODE = @ccode";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);

                // Add data
                cmd.Parameters.AddWithValue("@ccode", int.Parse(CustCodeTextBox.Text));
                cmd.Parameters.AddWithValue("@cname", CustNameTextBox.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTimePicker.Value);
                cmd.Parameters.AddWithValue("@milkType", MilkTypeComboBox.SelectedIndex);
                cmd.Parameters.AddWithValue("@weight", double.Parse(CowWeightTextBox.Text));
                cmd.Parameters.AddWithValue("@fat", double.Parse(CowFatTextBox.Text));
                cmd.Parameters.AddWithValue("@SNF", double.Parse(CowSNFTextBox.Text));
                cmd.Parameters.AddWithValue("@degree", double.Parse(CowDegreeTextBox.Text));
                cmd.Parameters.AddWithValue("@milkRate", double.Parse(CowMilkRateTextBox.Text));
                cmd.Parameters.AddWithValue("@amount", double.Parse(CowAmountTextBox.Text));

                // Open Connection 
                sqlConnection.Open();
                // Execute query
                if (cmd.ExecuteNonQuery() > 0)
                {
                    BindDataGridView();
                    ResetAllCustMilkDataFields();
                    MessageBox.Show("Customer Milk Data Updated Successfully.", "LPSUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update Customer Milk data.", "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustMilkDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ShowSelectedUserData(CustCodeTextBox.Text);
                /*CustCodeTextBox.Text = CustMilkDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                CustNameTextBox.Text = CustMilkDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                // TODO : Laxman Update Milk type
                //MilkTypeComboBox.Text = MilkTypeComboBox.;
                CowWeightTextBox.Text = CustMilkDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                CowFatTextBox.Text = CustMilkDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                CowSNFTextBox.Text = CustMilkDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                CowDegreeTextBox.Text = CustMilkDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                CowMilkRateTextBox.Text = CustMilkDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                CowAmountTextBox.Text = CustMilkDataGridView.SelectedRows[0].Cells[7].Value.ToString();*/
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPERROR : " + exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteDailyCustMilkDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                string query = "DELETE FROM " + m_sCustMilkDataTableName + " WHERE CUST_CODE = @ccode";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@ccode", int.Parse(CustCodeTextBox.Text));
                // Open Connection 
                sqlConnection.Open();
                // Execute query
                if (cmd.ExecuteNonQuery() > 0)
                {
                    BindDataGridView();
                    ResetAllCustMilkDataFields();
                    MessageBox.Show("Customer Milk data deleted successfully.", "LPSUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete Customer Milk data.", "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPERROR : " + exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int CalculateSNFMilkRate()
        {
            //
            // For Cow
            //
            if (MilkTypeComboBox.SelectedIndex == 0 && !string.IsNullOrEmpty(CowFatTextBox.Text) && !string.IsNullOrEmpty(CowDegreeTextBox.Text))
            {
                double cowFat = double.Parse(CowFatTextBox.Text);
                double cowDegree = double.Parse(CowDegreeTextBox.Text);

                /* ******************** SNF Formula *******************/
                /*         SNF% = CLR/4 + 0.21*(FAT%) + 0.36          */
                /* ******************** SNF Formula *******************/

                double cowSNF = cowDegree * 0.25 + 0.21 * cowFat + 0.36;
                CowSNFTextBox.Text = Math.Round(cowSNF, 1).ToString();
            }

            //
            // For Buffalo
            //
            /*! TODO : Change formula if needed */
            if (MilkTypeComboBox.SelectedIndex == 1 && !string.IsNullOrEmpty(BuffFatTextBox.Text) && !string.IsNullOrEmpty(BuffDegreeTextBox.Text))
            {
                double BuffFat = double.Parse(BuffFatTextBox.Text);
                double BuffDegree = double.Parse(BuffDegreeTextBox.Text);

                /* ******************** SNF Formula *******************/
                /*         SNF% = CLR/4 + 0.21*(FAT%) + 0.36          */
                /* ******************** SNF Formula *******************/

                double BuffSNF = BuffDegree * 0.25 + 0.21 * BuffFat + 0.36;
                BuffSNFTextBox.Text = Math.Round(BuffSNF, 1).ToString();
            }
            return 0;
        }

        private int CalculateMilkRateAndAmount(string snfVal, string fatVal)
        {
            try
            {
                SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                string query = "SELECT [" + snfVal + "] FROM MILK_RATE_CHART WHERE [FAT] = @cfat";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cfat", fatVal);

                float milkRate = 0;
                float milkAmount = 0;

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    object pMilkRate = dr.GetValue(0);
                    milkRate = float.Parse(pMilkRate.ToString());

                }
                con.Close();

                // Set Values 
                if (this.MilkTypeComboBox.SelectedIndex == 0)
                {
                    CowMilkRateTextBox.Text = milkRate.ToString();
                    milkAmount = float.Parse(CowWeightTextBox.Text) * float.Parse(milkRate.ToString());
                    CowAmountTextBox.Text = milkAmount.ToString();
                }
                else if (this.MilkTypeComboBox.SelectedIndex == 1)
                {
                    BuffMilkRateTextBox.Text = milkRate.ToString();
                    milkAmount = float.Parse(BuffWeightTextBox.Text) * float.Parse(milkRate.ToString());
                    BuffAmountTextBox.Text = milkAmount.ToString();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            m_sCustMilkDataTableName = m_sEngMilkCollTime + "_" + DateTimePicker.Value.ToString("dd_MM_yyyy");
            MessageBox.Show("Date is : " + m_sCustMilkDataTableName);
        }

        private void MilkTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            int iMilkType = MilkTypeComboBox.SelectedIndex;
            if(iMilkType == 0)
            {
                CowWeightTextBox.Focus();
                CowWeightTextBox.TabIndex = 0;
                CowFatTextBox.TabIndex = 1;
                CowDegreeTextBox.TabIndex = 2;

                CowWeightTextBox.TabStop = true;
                CowFatTextBox.TabStop = true;
                CowDegreeTextBox.TabStop = true;

                BuffWeightTextBox.TabStop = false;
                BuffFatTextBox.TabStop = false;
                BuffDegreeTextBox.TabStop = false;
            }
            else if (iMilkType == 1)
            {
                BuffWeightTextBox.TabStop = true;
                BuffFatTextBox.TabStop = true;
                BuffDegreeTextBox.TabStop = true;

                CowWeightTextBox.TabStop = false;
                CowFatTextBox.TabStop = false;
                CowDegreeTextBox.TabStop = false;
                BuffWeightTextBox.Focus();
                BuffWeightTextBox.TabIndex = 0;
                BuffFatTextBox.TabIndex = 1;
                BuffDegreeTextBox.TabIndex = 2;
            }
        }

        private void BuffWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void BuffFatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void BuffDegreeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void CowWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void CowFatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void CowDegreeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void CowWeightTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.CowFatTextBox.Text) && !string.IsNullOrEmpty(this.CowDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(CowWeightTextBox.Text)) CalculateMilkRateAndAmount(this.CowSNFTextBox.Text, this.CowFatTextBox.Text);
            }
        }

        private void CowFatTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.CowFatTextBox.Text) && !string.IsNullOrEmpty(this.CowDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(CowWeightTextBox.Text)) CalculateMilkRateAndAmount(this.CowSNFTextBox.Text, this.CowFatTextBox.Text);
            }
        }

        private void CowDegreeTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.CowFatTextBox.Text) && !string.IsNullOrEmpty(this.CowDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(CowWeightTextBox.Text)) CalculateMilkRateAndAmount(this.CowSNFTextBox.Text, this.CowFatTextBox.Text);
            }
        }

        private void BuffWeightTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.BuffFatTextBox.Text) && !string.IsNullOrEmpty(this.BuffDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(BuffWeightTextBox.Text)) CalculateMilkRateAndAmount(this.BuffSNFTextBox.Text, this.BuffFatTextBox.Text);
            }
        }

        private void BuffFatTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.BuffFatTextBox.Text) && !string.IsNullOrEmpty(this.BuffDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(BuffWeightTextBox.Text)) CalculateMilkRateAndAmount(this.BuffSNFTextBox.Text, this.BuffFatTextBox.Text);
            }
        }

        private void BuffDegreeTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.BuffFatTextBox.Text) && !string.IsNullOrEmpty(this.BuffDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(BuffWeightTextBox.Text)) CalculateMilkRateAndAmount(this.BuffSNFTextBox.Text, this.BuffFatTextBox.Text);
            }
        }

        private void CustCodeTextBox_Enter(object sender, EventArgs e)
        {
            ResetAllCustMilkDataFields();
        }

    }
}
