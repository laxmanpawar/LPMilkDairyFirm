using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace LogInForm
{
    public partial class RateChartForm : Form
    {
        public RateChartForm()
        {
            InitializeComponent();
        }

        private void RateChartForm_Load(object sender, EventArgs e)
        {
            try
            {
                FatFromTextBox.Focus();
            }
            catch(Exception exc)
            {
                MessageBox.Show("LPERROR : " + exc.Message, "LPERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(FatFromTextBox.Text) && !string.IsNullOrEmpty(FatToTextBox.Text) && !string.IsNullOrEmpty(SNFFromTextBox.Text) && !string.IsNullOrEmpty(SNFToTextBox.Text))
                {
                    RateChartDataGridView.Rows.Clear();
                    RateChartDataGridView.Columns.Clear();

                    float startFat = float.Parse(FatFromTextBox.Text);
                    float endFat = float.Parse(FatToTextBox.Text);
                    float startSNF = float.Parse(SNFFromTextBox.Text);
                    float endSNF = float.Parse(SNFToTextBox.Text);

                    int rows = (int)((endFat - startFat) / 0.1);

                    int counter = 1;
                    RateChartDataGridView.AutoGenerateColumns = false;
                    for (float i = startSNF; i <= endSNF; i += (float)0.1)
                    {
                        i = (float)Math.Round(i, 1);
                        RateChartDataGridView.Columns.Add("Column" + counter, i.ToString());
                        RateChartDataGridView.Columns[counter - 1].FillWeight = 1;
                        ++counter;
                    }

                    counter = 0;
                    for (float i = startFat; i <= endFat; i += (float)0.1)
                    {
                        i = (float)Math.Round(i, 1);
                        this.RateChartDataGridView.Rows.Add();
                        this.RateChartDataGridView.Rows[counter].HeaderCell.Value = i.ToString();
                        ++counter;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FatFromTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void FatToTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void SNFFromTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void SNFToTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LPUtils.AllowDecimalValuesInTextBox(sender, e);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (LPSQLTableUtils.IsTableExists("MILK_RATE_CHART") == 1)
            {
                // TODO : Laxman 
                DialogResult res = MessageBox.Show("LPInfo : जुना दर पत्रक उपस्थित आहे. आपण ते हटवू इच्छिता?", "LPInfo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.No) return;
                LPSQLTableUtils.DeleteSQLTableFromDB("MILK_RATE_CHART");
            }

            List<string> columnTypes = new List<string>();
            List<string> columnNames = new List<string>();

            for (int i = 0; i < this.RateChartDataGridView.Columns.Count; ++i)
            {
                if (i == 0)
                {
                    columnNames.Add("FAT");
                    columnTypes.Add("FLOAT");
                    continue;
                }
                columnNames.Add(RateChartDataGridView.Columns[i].HeaderText);
                columnTypes.Add("FLOAT");
            }

            // Create new SQL Table for RateChart
            LPSQLTableUtils.CreateSQLTableInDB("MILK_RATE_CHART", columnNames, columnTypes);

            // Add Rows to SQL Table
            SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);

            StringBuilder query = new StringBuilder();
            query.Append("Insert into ");
            query.Append("MILK_RATE_CHART values");

            int rowCounter = 0;
            foreach(DataGridViewRow dgvr in RateChartDataGridView.Rows)
            {
                for (int i = 0; i < columnNames.Count; ++i)
                {
                    if (i%columnNames.Count == 0) query.Append("(" + this.RateChartDataGridView.Rows[rowCounter].HeaderCell.Value.ToString());
                    else query.Append(", " + dgvr.Cells[i].Value.ToString());
                }
                ++rowCounter; 
                if (rowCounter == RateChartDataGridView.Rows.Count) query.Append(")");
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

        private void m_pLoadExistingButton_Click(object sender, EventArgs e)
        {
            if (LPSQLTableUtils.IsTableExists("MILK_RATE_CHART") == 1)
                {
                    SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                    string query = "SELECT * FROM MILK_RATE_CHART";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    this.RateChartDataGridView.DataSource = dt;
                }
        }

        private void m_pResetButton_Click(object sender, EventArgs e)
        {
            this.RateChartDataGridView.Rows.Clear();
            this.RateChartDataGridView.Columns.Clear();
            
        }

        private void m_pPasteButton_Click(object sender, EventArgs e)
        {
            try
            {
                RateChartDataGridView.Focus();
                RateChartDataGridView.CurrentCell = RateChartDataGridView[1, 1];
                string copiedText = Clipboard.GetText();
                string[] lines = copiedText.Replace("\n", "").Split('\r');
                string[] fields;
                int row = 0;
                int column = 0;
                foreach (string line in lines)
                {
                    fields = line.Split('\t');
                    foreach (string f in fields)
                        RateChartDataGridView[column++, row].Value = f;
                    row++;
                    column = 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
