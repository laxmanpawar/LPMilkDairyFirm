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
using LogInForm.Utils;

namespace LogInForm.src
{
    public partial class LPEditMilkCollectionCustListForm : LPForm
    {
        List<int> m_pActiveCustList = new List<int>();
        List<int> m_pOrigActiveCustList = new List<int>();
        DataTable m_pTotalCustListTable = new DataTable();
        DataTable m_pActiveCustListTable = new DataTable();

        public LPEditMilkCollectionCustListForm()
        {
            InitializeComponent();
        }

        private void LPEditMilkCollectionCustListForm_Load(object sender, EventArgs e)
        {
            // Update Total List Cust DataGridView
            SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
            string query = "SELECT * FROM " + LPGlobalVariables.m_sTotalCustomerDataTable;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(m_pTotalCustListTable);
            m_pTotalCustListDGV.DataSource = m_pTotalCustListTable;

            this.m_pTotalCustListDGV.Columns["CUST_CODE"].Width = 60;
            this.m_pTotalCustListDGV.Columns["CUST_CODE"].HeaderText = "Code";
            this.m_pTotalCustListDGV.Columns["CUST_NAME"].HeaderText = "Name";
            this.m_pTotalCustListDGV.Columns["CUST_NAME"].DefaultCellStyle.Font = new System.Drawing.Font("Shivaji01", 18F, FontStyle.Bold);

            // Remove Unnecessary Columns from DataGridView
            this.m_pTotalCustListDGV.Columns.Remove("MILK_TYPE");
            this.m_pTotalCustListDGV.Columns.Remove("CUST_MOB");
            this.m_pTotalCustListDGV.Columns.Remove("CUST_ACC_NO");

            cmd.CommandText = "SELECT * FROM " + LPGlobalVariables.m_sCollectionCustomerDataTable;
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            sda.Fill(m_pActiveCustListTable);
            m_pActiveCustListDGV.DataSource = m_pActiveCustListTable;

            // Fill Active Cust List.
            m_pActiveCustList = m_pActiveCustListTable.AsEnumerable().Select(r => r.Field<int>(0)).ToList();
            
            m_pOrigActiveCustList.AddRange(m_pActiveCustList);

            this.m_pActiveCustListDGV.Columns["CUST_CODE"].Width = 60;
            this.m_pActiveCustListDGV.Columns["CUST_CODE"].HeaderText = "Code";
            this.m_pActiveCustListDGV.Columns["CUST_NAME"].HeaderText = "Name";
            this.m_pActiveCustListDGV.Columns["CUST_NAME"].DefaultCellStyle.Font = new System.Drawing.Font("Shivaji01", 18F, FontStyle.Bold);

            // Remove Unnecessary Columns from DataGridView
            this.m_pActiveCustListDGV.Columns.Remove("MILK_TYPE");
            this.m_pActiveCustListDGV.Columns.Remove("CUST_MOB");
            this.m_pActiveCustListDGV.Columns.Remove("CUST_ACC_NO");
        }

        private void m_pMoveAllToRightButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgvRow in this.m_pTotalCustListDGV.Rows)
                {
                    if (!m_pActiveCustList.Contains(Convert.ToInt32(dgvRow.Cells[0].Value)))
                    {
                        // Add Row 
                        DataRow dataRow = m_pActiveCustListTable.NewRow(); //.Rows.Add(dgvRow.Cells[0].Value, dgvRow.Cells[1].Value);
                        dataRow["CUST_CODE"] = dgvRow.Cells[0].Value;
                        dataRow["CUST_NAME"] = dgvRow.Cells[1].Value;
                        m_pActiveCustListTable.Rows.Add(dataRow);
                        m_pActiveCustListTable.AcceptChanges();

                        m_pActiveCustList.Add(Convert.ToInt32(dgvRow.Cells[0].Value));
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_pMoveAllToLeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_pActiveCustListTable.Rows.Clear();
                m_pActiveCustList.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_pMoveSelectedToRightButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgvRow in this.m_pTotalCustListDGV.SelectedRows)
                {
                    if (!m_pActiveCustList.Contains(Convert.ToInt32(dgvRow.Cells[0].Value)))
                    {
                        // Add Row 
                        DataRow dataRow = m_pActiveCustListTable.NewRow(); //.Rows.Add(dgvRow.Cells[0].Value, dgvRow.Cells[1].Value);
                        dataRow["CUST_CODE"] = dgvRow.Cells[0].Value;
                        dataRow["CUST_NAME"] = dgvRow.Cells[1].Value;
                        DataRow totCustDataRow = m_pTotalCustListTable.Select("CUST_CODE = " + dgvRow.Cells[0].Value).First();
                        dataRow["MILK_TYPE"] = totCustDataRow.Field<int>("MILK_TYPE");
                        dataRow["CUST_MOB"] = totCustDataRow.Field<Int64>("CUST_MOB");
                        dataRow["CUST_ACC_NO"] = totCustDataRow.Field<Int64>("CUST_ACC_NO");

                        m_pActiveCustListTable.Rows.Add(dataRow);
                        m_pActiveCustListTable.AcceptChanges();

                        m_pActiveCustList.Add(Convert.ToInt32(dgvRow.Cells[0].Value));
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void m_pMoveSelectedToLeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgvRow in this.m_pActiveCustListDGV.SelectedRows)
                {
                    m_pActiveCustList.Remove(Convert.ToInt32(dgvRow.Cells[0].Value));
                    this.m_pActiveCustListDGV.Rows.Remove(dgvRow);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_pSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Add Rows to SQL Table\
                List<string> columnNames = new List<string>();
                columnNames.Add("CUST_CODE");
                columnNames.Add("CUST_NAME");
                columnNames.Add("MILK_TYPE");
                columnNames.Add("CUST_MOB");
                columnNames.Add("CUST_ACC_NO");

                SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);

                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO " + LPGlobalVariables.m_sCollectionCustomerDataTable + " VALUES");

                List<int> newActiveCustList = new List<int>();

                int rowCounter = 0;
                foreach (DataRow dr in m_pActiveCustListTable.Rows)
                {
                    ++rowCounter;
                    Object[] values = dr.ItemArray;

                    if (m_pOrigActiveCustList.Contains(Convert.ToInt32(values[0]))) continue;

                    newActiveCustList.Add(Convert.ToInt32(values[0]));

                    query.Append("(" + values[0]);
                    query.Append(", '" + values[1] + "'");
                    query.Append(", " + values[2].ToString());
                    query.Append(", " + values[3].ToString());
                    query.Append(", " + values[4].ToString());

                    if (rowCounter == m_pActiveCustListTable.Rows.Count)
                    {
                        query.Append(")");
                    }
                    else
                    {
                        query.Append("),");
                    }
                }

                /*int rowCounter = 0;
                foreach (DataGridViewRow dgvr in m_pActiveCustListTable.Rows)
                {
                    if (rowCounter == m_pActiveCustListTable.Rows.Count) continue;
                    for (int i = 0; i < columnNames.Count; ++i)
                    {
                        string value = dgvr.Cells[i].Value.ToString();
                        if (i % columnNames.Count == 0) query.Append("(" + value);
                        else if (columnNames[i] == "CUST_NAME") query.Append(", '" + value + "'");
                        else if (columnNames[i] == "MILK_TYPE" && value == "gaaya") query.Append(", " + 0.ToString());
                        else if (columnNames[i] == "MILK_TYPE" && value == "mhOsa") query.Append(", " + 1.ToString());
                        else query.Append(", " + value.ToString());
                    }
                    ++rowCounter;
                    if (rowCounter == m_pActiveCustListTable.Rows.Count) query.Append(")");
                    else query.Append("),");
                }*/

                SqlCommand cmd = new SqlCommand(query.ToString(), con);

                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    m_pOrigActiveCustList.AddRange(newActiveCustList);
                    MessageBox.Show("LPInfo : Active Customer List  is updated Successfully.", "LPINFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("LPInfo : Active Customer List is upadation failed.", "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);

                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("LPInfo : Active Customer List is upadation failed.", "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_pResetButton_Click(object sender, EventArgs e)
        {
            m_pActiveCustListDGV.Rows.Clear();
        }

        private void m_pCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
