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
using System.Data.Entity.Migrations;
using LogInForm.src;

namespace LogInForm
{
    public partial class MilkCollectionForm : LPForm
    {

        Model.CUSTOMER_MILK_DATA model = new Model.CUSTOMER_MILK_DATA();
        Model.CustomerMilkDataEntities db = new Model.CustomerMilkDataEntities();

        string m_sMilkCollTime = "सकाळ";
        int m_iMilkTime = 0;
        //string m_sEngMilkCollTime = "Morning";
        string m_sCustMilkDataTableName = LPGlobalVariables.m_sCustDailyMilkDataTable;
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
            if (string.IsNullOrEmpty(CustCodeTextBox.Text))
            {
                CustCodeTextBox.Focus();
                return;
            }
            if (db.CUSTOMER_MILK_DATA.Find(Convert.ToInt32(CustCodeTextBox.Text), m_pMilkDate.Value.Date, m_iMilkTime)  != null)
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

            string isCustExistsQuery = "Select * from " + LPGlobalVariables.m_sCustomerDataTable + " Where CUST_CODE = @custid";
            SqlCommand isCustExistsCmd = new SqlCommand(isCustExistsQuery, sqlCon);
            isCustExistsCmd.Parameters.AddWithValue("@custid", CustCodeTextBox.Text);

            try
            {
                sqlCon.Open();
                SqlDataReader sqlDataReader = isCustExistsCmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    CustNameTextBox.Text = (string)sqlDataReader["CUST_NAME"];
                    MilkTypeComboBox.SelectedIndex = Convert.ToInt32(sqlDataReader["MILK_TYPE"]);

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
                m_iMilkTime = 0;
            }
            else if (m_sMilkCollTime == "सायंकाळ")
            {
                m_iMilkTime = 1;
            }

            //m_sCustMilkDataTableName = m_sEngMilkCollTime + "_" + m_pMilkDate.Value.ToString("dd_MM_yyyy");
            MainLabel.Text = m_sMilkCollTime + " दूध संकलन";

            // Update Total MilkData
            UpdateTotalMilkDetailsTable();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                model.CUST_CODE = Convert.ToInt32(CustCodeTextBox.Text);
                model.CUST_NAME = CustNameTextBox.Text;
                model.MILK_DATE = m_pMilkDate.Value.Date;
                model.MILK_TIME = m_iMilkTime;

                bool isExists = db.CUSTOMER_MILK_DATA.Any(x => x.CUST_CODE == model.CUST_CODE && x.MILK_DATE == model.MILK_DATE && x.MILK_TIME == m_iMilkTime);

                if (!isExists)
                {
                    model.MILK_TYPE = MilkTypeComboBox.SelectedIndex;
                    if (MilkTypeComboBox.SelectedIndex == 0)
                    {
                        model.MILK_WEIGHT = float.Parse(CowWeightTextBox.Text);
                        model.MILK_FAT = float.Parse(CowFatTextBox.Text);
                        model.MILK_SNF = float.Parse(CowSNFTextBox.Text);
                        model.MILK_DEGREE = float.Parse(CowDegreeTextBox.Text);
                        model.MILK_RATE = float.Parse(CowMilkRateTextBox.Text);
                        model.MILK_AMOUNT = float.Parse(CowAmountTextBox.Text);
                    }
                    else if (MilkTypeComboBox.SelectedIndex == 1)
                    {
                        model.MILK_WEIGHT = float.Parse(BuffWeightTextBox.Text);
                        model.MILK_FAT = float.Parse(BuffFatTextBox.Text);
                        model.MILK_SNF = float.Parse(BuffSNFTextBox.Text);
                        model.MILK_DEGREE = float.Parse(BuffDegreeTextBox.Text);
                        model.MILK_RATE = float.Parse(BuffMilkRateTextBox.Text);
                        model.MILK_AMOUNT = float.Parse(BuffAmountTextBox.Text);
                    }

                    db.CUSTOMER_MILK_DATA.Add(model);
                    int isSuccess = db.SaveChanges();

                    if (isSuccess > 0)
                    {
                        BindDataGridView();
                        ResetAllCustMilkDataFields();
                        // Update Total MilkData
                        //UpdateTotalMilkDetailsTable();
                        MessageBox.Show("Milk added successfully.", "LPSUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    SaveDailyCustMilkDataButton.Focus();
                    UpdateDailyCustomerData();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(), "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Failed to add Customer Milk data.", "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            //
            // TODO : REMOVE Below code is commented bcz we implemented Entity framework
            //
            
            try
            {
                SqlConnection sqlCon = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);

                /*
                int isTableExists = LPSQLTableUtils.IsTableExists(m_sCustMilkDataTableName);
                if (isTableExists == 0)
                {
                    MessageBox.Show("LPInfo : Table is not present in dataBase.", "LPINFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Create new table 
                    List<string> columnNames = new List<string>() { "CUST_CODE", "CUST_NAME", "MILK_DATE", "MILK_TYPE", "MILK_WEIGHT", "MILK_FAT", "MILK_SNF", "MILK_DEGREE", "MILK_RATE", "MILK_AMOUNT" };
                    List<string> columnTypes = new List<string>() { "INT primary key", "NVARCHAR(MAX) NOT NULL", "DATE NOT NULL", "int NOT NULL", "FLOAT(10) NOT NULL", "FLOAT(5) NOT NULL", "FLOAT(5) NOT NULL", "FLOAT(5) NOT NULL", "FLOAT(5) NOT NULL", "FLOAT(10) NOT NULL" };
                    LPSQLTableUtils.CreateSQLTableInDB(m_sCustMilkDataTableName, columnNames, columnTypes);
                }
                */

                string isCustExistsQuery = "select * from " + m_sCustMilkDataTableName + " where CUST_CODE = @custcode AND MILK_DATE = @milkDate AND MILK_TIME = @milkTime";
                SqlCommand isCustExistsCmd = new SqlCommand(isCustExistsQuery, sqlCon);
                isCustExistsCmd.Parameters.AddWithValue("@custcode", CustCodeTextBox.Text);
                isCustExistsCmd.Parameters.AddWithValue("@milkDate", m_pMilkDate.Value.Date);
                isCustExistsCmd.Parameters.AddWithValue("@milkTime", m_iMilkTime);

                sqlCon.Open();
                SqlDataReader sqlDataReader = isCustExistsCmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    SaveDailyCustMilkDataButton.Focus();
                    DialogResult result = MessageBox.Show("LPInfo : Customer id already present.\nDo you want to still continue?", "LPInfo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) UpdateDailyCustomerData();
                    sqlCon.Close();
                }
                else
                {
                    sqlCon.Close();

                    int code = int.Parse(CustCodeTextBox.Text);
                    string name = CustNameTextBox.Text;
                    int iMilkType = MilkTypeComboBox.SelectedIndex;
                    DateTime dateTime = m_pMilkDate.Value.Date;

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
                        weight = double.Parse(BuffWeightTextBox.Text);
                        fat = double.Parse(BuffFatTextBox.Text);
                        SNF = double.Parse(BuffSNFTextBox.Text);
                        degree = double.Parse(BuffDegreeTextBox.Text);
                        milkRate = double.Parse(BuffMilkRateTextBox.Text);
                        amount = double.Parse(BuffAmountTextBox.Text);
                    }

                    // Save data to sql Server.
                    SqlConnection sqlConnection = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                    string query = "Insert into " + m_sCustMilkDataTableName + " values(@ccode, @cname, @datetime, @milkTime, @milkType, @weight, @fat, @SNF, @degree, @milkRate, @amount)";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);

                    // Add data
                    cmd.Parameters.AddWithValue("@ccode", code);
                    cmd.Parameters.AddWithValue("@cname", name);
                    cmd.Parameters.AddWithValue("@datetime", dateTime);
                    cmd.Parameters.AddWithValue("@milkTime", m_iMilkTime);
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
                        sqlConnection.Close();
                        // Update Total MilkData
                        UpdateTotalMilkDetailsTable();
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
                string query = "SELECT * FROM " + this.m_sCustMilkDataTableName + " WHERE CUST_CODE = @ccode AND MILK_DATE = @milkDate AND MILK_TIME = @milkTime";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ccode", iCustCode);
                cmd.Parameters.AddWithValue("@milkDate", m_pMilkDate.Value.Date);
                cmd.Parameters.AddWithValue("@milkTime", m_iMilkTime);

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
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            return 0;
        }

        public int BindDataGridView()
        {
            try
            {
                CustMilkDataGridView.DataSource = db.CUSTOMER_MILK_DATA.Where(x => x.MILK_DATE == this.m_pMilkDate.Value.Date && x.MILK_TIME == this.m_iMilkTime).ToList<Model.CUSTOMER_MILK_DATA>();

                CustMilkDataGridView.Columns.Remove("MILK_DATE");
                CustMilkDataGridView.Columns.Remove("MILK_TIME");
                CustMilkDataGridView.Columns.Remove("MILK_TYPE");
                CustMilkDataGridView.Columns["CUST_CODE"].Width = 100;
                CustMilkDataGridView.Columns["MILK_WEIGHT"].Width = 100;
                CustMilkDataGridView.Columns["MILK_FAT"].Width = 100;
                CustMilkDataGridView.Columns["MILK_SNF"].Width = 100;
                CustMilkDataGridView.Columns["MILK_DEGREE"].Width = 100;
                CustMilkDataGridView.Columns["MILK_RATE"].Width = 100;
                CustMilkDataGridView.Columns["MILK_AMOUNT"].Width = 100;

                CustMilkDataGridView.Columns["CUST_CODE"].HeaderText = "कोड";
                CustMilkDataGridView.Columns["CUST_NAME"].HeaderText = "नाव";
                CustMilkDataGridView.Columns["MILK_WEIGHT"].HeaderText = "दूध";
                CustMilkDataGridView.Columns["MILK_FAT"].HeaderText = "फॅट";
                CustMilkDataGridView.Columns["MILK_SNF"].HeaderText = "SNF";
                CustMilkDataGridView.Columns["MILK_DEGREE"].HeaderText = "डिग्री";
                CustMilkDataGridView.Columns["MILK_RATE"].HeaderText = "दर";
                CustMilkDataGridView.Columns["MILK_AMOUNT"].HeaderText = "रक्कम";

                // Show Cust Name in Marathi
                CustMilkDataGridView.Columns["CUST_NAME"].DefaultCellStyle.Font = new System.Drawing.Font("Shivaji01", 18F, FontStyle.Bold);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //CustMilkDataGridView.DataSource = db.CustomerMilkDatas.ToList<Model.CustomerMilkData>();

            // ***************************************************************************************
            // TODO : Below code is commented bcz we have used Entity framework to do the below work //
            // ***************************************************************************************
            /*if (LPSQLTableUtils.IsTableExists(m_sCustMilkDataTableName) == 0) return 0;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                string query = "Select CUST_CODE, CUST_NAME, MILK_WEIGHT, MILK_FAT, MILK_SNF, MILK_DEGREE, MILK_RATE, MILK_AMOUNT from " + m_sCustMilkDataTableName + "";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                CustMilkDataGridView.DataSource = dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPERROR : " + exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }*/
            return 0;
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
            UpdateDailyCustomerData();
        }

        private int UpdateDailyCustomerData()
        {
            try
            {
                Model.CUSTOMER_MILK_DATA _MILK_DATA = db.CUSTOMER_MILK_DATA.Find(Convert.ToInt32(CustCodeTextBox.Text), m_pMilkDate.Value.Date, m_iMilkTime);
                if (_MILK_DATA != null)
                {
                    _MILK_DATA.MILK_TYPE = MilkTypeComboBox.SelectedIndex;
                    if (MilkTypeComboBox.SelectedIndex == 0)
                    {
                        _MILK_DATA.MILK_WEIGHT = float.Parse(CowWeightTextBox.Text);
                        _MILK_DATA.MILK_FAT = float.Parse(CowFatTextBox.Text);
                        _MILK_DATA.MILK_SNF = float.Parse(CowSNFTextBox.Text);
                        _MILK_DATA.MILK_DEGREE = float.Parse(CowDegreeTextBox.Text);
                        _MILK_DATA.MILK_RATE = float.Parse(CowMilkRateTextBox.Text);
                        _MILK_DATA.MILK_AMOUNT = float.Parse(CowAmountTextBox.Text);
                    }
                    else if (MilkTypeComboBox.SelectedIndex == 1)
                    {
                        _MILK_DATA.MILK_WEIGHT = float.Parse(BuffWeightTextBox.Text);
                        _MILK_DATA.MILK_FAT = float.Parse(BuffFatTextBox.Text);
                        _MILK_DATA.MILK_SNF = float.Parse(BuffSNFTextBox.Text);
                        _MILK_DATA.MILK_DEGREE = float.Parse(BuffDegreeTextBox.Text);
                        _MILK_DATA.MILK_RATE = float.Parse(BuffMilkRateTextBox.Text);
                        _MILK_DATA.MILK_AMOUNT = float.Parse(BuffAmountTextBox.Text);
                    }
                    BindDataGridView();
                    ResetAllCustMilkDataFields();
                    MessageBox.Show("Customer Milk Data Updated Successfully.", "LPSUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            

            //
            // TODO : Implemented DataBase First Approach of Entity Framework
            //
            /*try
            {
                SqlConnection sqlConnection = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                string query = "Update " + m_sCustMilkDataTableName + " set CUST_CODE = @ccode, CUST_NAME = @cname, MILK_DATE = @datetime, MILK_TYPE = @milkType, MILK_WEIGHT = @weight, MILK_FAT = @fat, MILK_SNF = @SNF, MILK_DEGREE = @degree, MILK_RATE = @milkRate, MILK_AMOUNT =  @amount Where CUST_CODE = @ccode";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);

                // Add data
                cmd.Parameters.AddWithValue("@ccode", int.Parse(CustCodeTextBox.Text));
                cmd.Parameters.AddWithValue("@cname", CustNameTextBox.Text);
                cmd.Parameters.AddWithValue("@datetime", m_pMilkDate.Value);
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
                    return 1;
                }
                sqlConnection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }*/
            return 0;
        }

        private void CustMilkDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ShowSelectedUserData(CustCodeTextBox.Text);
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
            float milkRate = 0;
            float milkAmount = 0;

            SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
            try
            {
                string query = "SELECT [" + snfVal + "] FROM MILK_RATE_CHART WHERE [FAT] = @cfat";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cfat", fatVal);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    object pMilkRate = dr.GetValue(0);
                    milkRate = float.Parse(pMilkRate.ToString());
                    con.Close();
                }
                else 
                { 
                    con.Close();
                    query = "SELECT [" + snfVal + "] FROM DEFAULT_MILK_RATE_CHART WHERE [FAT] = @cfat";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@cfat", fatVal);

                    con.Open();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    if (dr1.Read())
                    {
                        object pMilkRate = dr1.GetValue(0);
                        milkRate = float.Parse(pMilkRate.ToString());
                    }
                    con.Close();
                }
            }
            catch(SqlException sqlExc)
            {
                con.Close();
                try
                {
                    string query = "SELECT [" + snfVal + "] FROM DEFAULT_MILK_RATE_CHART WHERE [FAT] = @cfat";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@cfat", fatVal);

                    con.Open();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    if (dr1.Read())
                    {
                        object pMilkRate = dr1.GetValue(0);
                        milkRate = float.Parse(pMilkRate.ToString());
                    }
                    con.Close();
                }
                catch(SqlException sqlEx)
                {
                    milkRate = 0;
                }
                return 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            finally
            {
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
            return 0;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //m_sCustMilkDataTableName = m_sEngMilkCollTime + "_" + m_pMilkDate.Value.ToString("dd_MM_yyyy");
            // TODO: Update Total MilkData
            BindDataGridView();
            UpdateTotalMilkDetailsTable();
        }

        private void MilkTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            int iMilkType = MilkTypeComboBox.SelectedIndex;
            if (iMilkType == 0)
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
                if (!string.IsNullOrEmpty(CowWeightTextBox.Text))
                {
                    int isSuccess = CalculateMilkRateAndAmount(this.CowSNFTextBox.Text, this.CowFatTextBox.Text);
                    if (isSuccess == 1) CowWeightTextBox.Focus();
                }
            }
        }

        private void CowFatTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.CowFatTextBox.Text) && !string.IsNullOrEmpty(this.CowDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(CowWeightTextBox.Text))
                {
                    int isSuccess = CalculateMilkRateAndAmount(this.CowSNFTextBox.Text, this.CowFatTextBox.Text);
                    if (isSuccess == 1) CowFatTextBox.Focus();
                }
            }
        }

        private void CowDegreeTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.CowFatTextBox.Text) && !string.IsNullOrEmpty(this.CowDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(CowWeightTextBox.Text))
                {
                    int isSuccess = CalculateMilkRateAndAmount(this.CowSNFTextBox.Text, this.CowFatTextBox.Text);
                    if (isSuccess == 1) CowDegreeTextBox.Focus();
                }
            }
        }

        private void BuffWeightTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.BuffFatTextBox.Text) && !string.IsNullOrEmpty(this.BuffDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(BuffWeightTextBox.Text))
                {
                    int isSuccess = CalculateMilkRateAndAmount(this.BuffSNFTextBox.Text, this.BuffFatTextBox.Text);
                }
            }
        }

        private void BuffFatTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.BuffFatTextBox.Text) && !string.IsNullOrEmpty(this.BuffDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(BuffWeightTextBox.Text))
                {
                    int isSuccess = CalculateMilkRateAndAmount(this.BuffSNFTextBox.Text, this.BuffFatTextBox.Text);
                }
            }
        }

        private void BuffDegreeTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.BuffFatTextBox.Text) && !string.IsNullOrEmpty(this.BuffDegreeTextBox.Text))
            {
                CalculateSNFMilkRate();
                if (!string.IsNullOrEmpty(BuffWeightTextBox.Text))
                {
                    int isSuccess = CalculateMilkRateAndAmount(this.BuffSNFTextBox.Text, this.BuffFatTextBox.Text);
                }
            }
        }

        private void CustCodeTextBox_Enter(object sender, EventArgs e)
        {
            ResetAllCustMilkDataFields();
        }

        private int UpdateTotalMilkDetailsTable()
        {
            if (LPSQLTableUtils.IsTableExists(this.m_sCustMilkDataTableName) == 0) return 0;
            // For Cow
            int iCowMilkCount = 0;
            float fCowTotalMilkWeight = 0;
            float fCowAvgMilkFat = 0;
            float fCowAvgMilkSNF = 0;
            float fCowAvgMilkDegree = 0;
            float fCowAvgMilkRate = 0;
            float fCowTotalMilkAmount = 0;

            // For Buffalo
            int iBuffMilkCount = 0;
            float fBuffTotalMilkWeight = 0;
            float fBuffAvgMilkFat = 0;
            float fBuffAvgMilkSNF = 0;
            float fBuffAvgMilkDegree = 0;
            float fBuffAvgMilkRate = 0;
            float fBuffTotalMilkAmount = 0;


            SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);

            string cowNumCustQuery = "SELECT COUNT(CUST_CODE) as CowNumCusts FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 0";
            string cowTotWeightQuery = "SELECT SUM(MILK_WEIGHT) as CowMilkWeight FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 0";
            string cowAvgFatQuery = "SELECT AVG(MILK_FAT) as CowMilkFat FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 0";
            string cowAvgSNFQuery = "SELECT AVG(MILK_SNF) as CowMilkSNF FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 0";
            string cowAvgDegreeQuery = "SELECT AVG(MILK_DEGREE) as CowMilkDegree FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 0";
            string cowAvgRateQuery = "SELECT AVG(MILK_RATE) as CowMilkRate FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 0";
            string cowTotAmountQuery = "SELECT SUM(MILK_AMOUNT) as CowTotalAmount FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 0";

            string buffNumCustQuery = "SELECT COUNT(CUST_CODE) as BuffNumCusts FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 1";
            string buffTotWeightQuery = "SELECT SUM(MILK_WEIGHT) as BuffMilkWeight FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 1";
            string buffAvgFatQuery = "SELECT AVG(MILK_FAT) as BuffMilkFat FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 1";
            string buffAvgSNFQuery = "SELECT AVG(MILK_SNF) as BuffMilkSNF FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 1";
            string buffAvgDegreeQuery = "SELECT AVG(MILK_DEGREE) as BuffMilkDegree FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 1";
            string buffAvgRateQuery = "SELECT AVG(MILK_RATE) as BuffMilkRate FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 1";
            string buffTotAmountQuery = "SELECT SUM(MILK_AMOUNT) as BuffTotalAmount FROM " + this.m_sCustMilkDataTableName + " WHERE MILK_DATE = @milkDate AND MILK_TIME = @milkTime AND MILK_TYPE = 1";
            SqlCommand cmd = new SqlCommand(cowTotAmountQuery, con);
            cmd.Parameters.AddWithValue("@milkDate", this.m_pMilkDate.Value.Date);
            cmd.Parameters.AddWithValue("@milkTime", this.m_iMilkTime);
            con.Open();

            // Cow Number of Customers milk TextBox
            cmd.CommandText = cowNumCustQuery;
            var res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) iCowMilkCount = int.Parse(res);
            this.CowNumCustTextBox.Text = iCowMilkCount.ToString();

            // Cow Total Milk TextBox
            cmd.CommandText = cowTotWeightQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fCowTotalMilkWeight = float.Parse(res);
            this.CowTotMilkTextBox.Text = Math.Round(fCowTotalMilkWeight, 2).ToString();

            // Cow Average FAT TextBox
            cmd.CommandText = cowAvgFatQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fCowAvgMilkFat = float.Parse(res);
            this.CowAverageFatTextBox.Text = Math.Round(fCowAvgMilkFat, 2).ToString();

            // Cow Average SNF TextBox
            cmd.CommandText = cowAvgSNFQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fCowAvgMilkSNF = float.Parse(res);
            this.CowAverageSNFTextBox.Text = Math.Round(fCowAvgMilkSNF, 2).ToString();

            // Cow Average Degree TextBox
            cmd.CommandText = cowAvgDegreeQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fCowAvgMilkDegree = float.Parse(res);
            this.CowAverageDegreeTextBox.Text = Math.Round(fCowAvgMilkDegree, 2).ToString();

            // Cow Average Milk Rate TextBox
            cmd.CommandText = cowAvgRateQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fCowAvgMilkRate = float.Parse(res);
            this.m_pCowAvgMilkRate.Text = Math.Round(fCowAvgMilkRate, 2).ToString();

            // Cow Total milk TextBox
            cmd.CommandText = cowTotAmountQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fCowTotalMilkAmount = float.Parse(res);
            this.m_pCowTotAmountTextBox.Text = Math.Round(fCowTotalMilkAmount, 2).ToString();

            //
            // Buffalo
            //
            // Buffalo Number of Customers milk TextBox
            cmd.CommandText = buffNumCustQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) iBuffMilkCount = int.Parse(res);
            this.BuffNumCustTextBox.Text = iBuffMilkCount.ToString();

            // Buffalo Total Milk TextBox
            cmd.CommandText = buffTotWeightQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fBuffTotalMilkWeight = float.Parse(res);
            this.BuffTotMilkTextBox.Text = Math.Round(fBuffTotalMilkWeight, 2).ToString();

            // Buffalo Average FAT TextBox
            cmd.CommandText = buffAvgFatQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fBuffAvgMilkFat = float.Parse(res);
            this.BuffAverageFatTextBox.Text = Math.Round(fBuffAvgMilkFat, 2).ToString();

            // Buffalo Average SNF TextBox
            cmd.CommandText = buffAvgSNFQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fBuffAvgMilkSNF = float.Parse(res);
            this.BuffAverageSNFTextBox.Text = Math.Round(fBuffAvgMilkSNF, 2).ToString();

            // Buffalo Average Degree TextBox
            cmd.CommandText = buffAvgDegreeQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fBuffAvgMilkDegree = float.Parse(res);
            this.BuffAverageDegreeTextBox.Text = Math.Round(fBuffAvgMilkDegree, 2).ToString();

            // Buffalo Average Milk Rate TextBox
            cmd.CommandText = buffAvgRateQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fBuffAvgMilkRate = float.Parse(res);
            this.m_pBuffAvgMilkRate.Text = Math.Round(fBuffAvgMilkRate, 2).ToString();

            // Buffalo Total milk
            cmd.CommandText = buffTotAmountQuery;
            res = cmd.ExecuteScalar().ToString();
            if (!String.IsNullOrEmpty(res)) fBuffTotalMilkAmount = float.Parse(res);
            this.m_pBuffTotAmountTextBox.Text = Math.Round(fBuffTotalMilkAmount, 2).ToString();
            con.Close();

            this.m_pTotalMilkTB.Text = (fCowTotalMilkWeight + fBuffTotalMilkWeight).ToString();
            this.m_pTotalMilkAmountTB.Text = (fCowTotalMilkAmount + fBuffTotalMilkAmount).ToString();

            return 0;
        }

        private void m_pMilkRemainingCustListButton_Click(object sender, EventArgs e)
        {
            LPMilkCustListForm remainingCustListForm = new LPMilkCustListForm("RemainingCustList", m_pMilkDate.Value.Date, m_iMilkTime);
            remainingCustListForm.Show();
        }

        private void m_pMilkCollectedCustListButton_Click(object sender, EventArgs e)
        {
            LPMilkCustListForm remainingCustListForm = new LPMilkCustListForm("MilkCollectedCustList", m_pMilkDate.Value.Date, m_iMilkTime);
            remainingCustListForm.Show();
        }

        private void m_pProducerList_Click_1(object sender, EventArgs e)
        {
            LPMilkCustListForm remainingCustListForm = new LPMilkCustListForm("MilkProducerList", m_pMilkDate.Value.Date, m_iMilkTime);
            remainingCustListForm.Show();
        }
    }
}
