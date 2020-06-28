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
    public partial class LPLoadMultiCustListForm : LPForm
    {
        public LPLoadMultiCustListForm()
        {
            InitializeComponent();
        }

        private void m_pLoadButton_Click(object sender, EventArgs e)
        {
            string copiedText = Clipboard.GetText();
            string[] lines = copiedText.Replace("\n", "").Split('\r');
            string[] fields;
            foreach (string line in lines)
            {
                fields = line.Split('\t');
                m_pCustListDataGridView.Rows.Add(fields);
            }
        }

        private void LPLoadMultiCustListForm_Load(object sender, EventArgs e)
        {

        }

        private void m_pAddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
            try
            {
                // Add Rows to SQL Table\
                List<string> columnNames = new List<string>();
                columnNames.Add("CUST_CODE");
                columnNames.Add("CUST_NAME");
                columnNames.Add("MILK_TYPE");
                columnNames.Add("CUST_MOB");
                columnNames.Add("CUST_ACC_NO");

                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO " + LPGlobalVariables.m_sCustomerDataTable + " VALUES");

                int rowCounter = 0;
                foreach (DataGridViewRow dgvr in m_pCustListDataGridView.Rows)
                {
                    if (rowCounter == m_pCustListDataGridView.Rows.Count - 1) continue;
                    for (int i = 0; i < columnNames.Count; ++i)
                    {
                        string value = dgvr.Cells[i].Value.ToString();
                        if (i % columnNames.Count == 0) query.Append("(" + value);
                        else if(columnNames[i] == "CUST_NAME") query.Append(", '" + value + "'");
                        else if(columnNames[i] == "MILK_TYPE" && value == "gaaya") query.Append(", " + 0.ToString());
                        else if (columnNames[i] == "MILK_TYPE" && value == "mhOsa") query.Append(", " + 1.ToString());
                        else query.Append(", " + value.ToString());
                    }
                    ++rowCounter;
                    if (rowCounter == m_pCustListDataGridView.Rows.Count - 1) query.Append(")");
                    else query.Append("),");
                }

                SqlCommand cmd = new SqlCommand(query.ToString(), con);

                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("LPInfo : New Rate chart is updated Successfully.", "LPINFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("LPInfo : New Rate chart is upadatoin failed.", "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void m_pResetButton_Click(object sender, EventArgs e)
        {
            m_pCustListDataGridView.Rows.Clear();
        }
    }
}
