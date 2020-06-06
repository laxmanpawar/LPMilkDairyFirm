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

namespace LogInForm
{
    public partial class BillReportForm : Form
    {
        public BillReportForm()
        {
            InitializeComponent();
        }

        private void BillReportForm_Load(object sender, EventArgs e)
        {
            this.m_pBranchComboBox.SelectedIndex = 0;

            this.m_pDairyNameLabel.Text = LPGlobalVariables.m_sDairyName;

            SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
            string query = "SELECT CUST_ID, CUST_NAME FROM " + LPGlobalVariables.m_sCustomerDataTable;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.m_pTotalCustDGV.Rows.Add(dr.GetValue(0), dr.GetValue(1));
            }
            con.Close();
        }

        private void m_pReportMoveAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgvRow in this.m_pTotalCustDGV.Rows)
                {
                    this.m_pReportCustDGV.Rows.Add(dgvRow.Cells[0].Value, dgvRow.Cells[1].Value);
                }
                this.m_pTotalCustDGV.Rows.Clear();
            }
            catch(Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_pSkipReportMoveAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgvRow in this.m_pReportCustDGV.Rows)
                {
                    this.m_pTotalCustDGV.Rows.Add(dgvRow.Cells[0].Value, dgvRow.Cells[1].Value);
                }
                this.m_pReportCustDGV.Rows.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_pReportMoveSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgvRow in this.m_pTotalCustDGV.SelectedRows)
                {
                    this.m_pReportCustDGV.Rows.Add(dgvRow.Cells[0].Value, dgvRow.Cells[1].Value);
                }
                foreach (DataGridViewRow dgvRow in this.m_pTotalCustDGV.SelectedRows)
                {
                    this.m_pTotalCustDGV.Rows.Remove(dgvRow);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_pSkipReportMoveSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgvRow in this.m_pReportCustDGV.SelectedRows)
                {
                    this.m_pTotalCustDGV.Rows.Add(dgvRow.Cells[0].Value, dgvRow.Cells[1].Value);
                }
                foreach (DataGridViewRow dgvRow in this.m_pReportCustDGV.SelectedRows)
                {
                    this.m_pReportCustDGV.Rows.Remove(dgvRow);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_pGenerateReportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
