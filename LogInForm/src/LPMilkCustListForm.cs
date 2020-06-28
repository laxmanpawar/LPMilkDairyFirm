using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogInForm.src
{
    public partial class LPMilkCustListForm : Form
    {
        String m_sListType = "RemainingCustList";
        DateTime m_pDateTime = DateTime.Now;
        int m_iMilkTime = 0;

        public LPMilkCustListForm()
        {
            InitializeComponent();
        }
        public LPMilkCustListForm(string listType, DateTime dateTime, int milkTime)
        {
            m_sListType = listType;
            m_pDateTime = dateTime;
            m_iMilkTime = milkTime;
            InitializeComponent();
        }

        private void LPMilkCustListForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                string remaingCustListQuery = "SELECT CUST_CODE, CUST_NAME FROM " + LPGlobalVariables.m_sCustomerDataTable + " EXCEPT SELECT CUST_CODE, CUST_NAME FROM " + LPGlobalVariables.m_sCustDailyMilkDataTable + " WHERE MILK_TIME = @milktime AND MILK_DATE = @milkdate";
                SqlCommand cmd = new SqlCommand(remaingCustListQuery, con);
                if (m_sListType == "RemainingCustList")
                {
                    cmd.CommandText = remaingCustListQuery;
                }
                else if (m_sListType == "MilkCollectedCustList")
                {
                    cmd.CommandText = "SELECT CUST_CODE, CUST_NAME FROM " + LPGlobalVariables.m_sCustDailyMilkDataTable + " WHERE MILK_TIME = @milktime AND MILK_DATE = @milkdate";
                }
                else if (m_sListType == "MilkProducerList")
                {
                    cmd.CommandText = "SELECT CUST_CODE, CUST_NAME, CUST_MOB FROM " + LPGlobalVariables.m_sCustomerDataTable;
                }
                cmd.Parameters.AddWithValue("@milktime", m_iMilkTime);
                cmd.Parameters.AddWithValue("@milkdate", m_pDateTime.Date);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                m_pMilkCustListDataGridView.DataSource = dataTable;
                m_pMilkCustListDataGridView.Columns["CUST_CODE"].Width = 100;
                m_pMilkCustListDataGridView.Columns["CUST_CODE"].HeaderText = "कोड";
                m_pMilkCustListDataGridView.Columns["CUST_NAME"].HeaderText = "नाव";
                if (m_sListType == "MilkProducerList") m_pMilkCustListDataGridView.Columns["CUST_MOB"].HeaderText = "Mob. Number";

                // Show Cust Name in Marathi
                m_pMilkCustListDataGridView.Columns["CUST_NAME"].DefaultCellStyle.Font = new System.Drawing.Font("Shivaji01", 18F, FontStyle.Bold);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
