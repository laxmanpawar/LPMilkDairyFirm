using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm.src
{
    public partial class LPBillReportViewerForm : LPForm
    {
        List<int> m_lCustIdList;
        DateTime m_pReportStartDate;
        DateTime m_pReportEndDate;

        public LPBillReportViewerForm()
        {
            InitializeComponent();
        }

        public LPBillReportViewerForm(List<int> custCodeList, DateTime startDate, DateTime endDate)
        {
            m_lCustIdList = custCodeList;
            m_pReportStartDate = startDate;
            m_pReportEndDate = endDate;

            InitializeComponent();
        }

        private void LPBillReportViewerForm_Load(object sender, EventArgs e)
        {
            string[] values = String.Join(",", this.m_lCustIdList).Split(',');
            ReportParameter reportParameter = new ReportParameter("custIdList", values);
            
            m_pBillReportViewer.LocalReport.SetParameters(reportParameter);

            // TODO: This line of code loads data into the 'cUSTOMER_MILK_DataSet.CUSTOMER_MILK_DATA' table. You can move, or remove it, as needed.
            this.cUSTOMER_MILK_DATATableAdapter.Fill(this.cUSTOMER_MILK_DataSet.CUSTOMER_MILK_DATA);
            // TODO: This line of code loads data into the 'cUSTOMER_MILK_DataSet.CUSTOMER_MILK_DATA' table. You can move, or remove it, as needed.
            //this.cUSTOMER_MILK_DATATableAdapter.Fill(this.cUSTOMER_MILK_DataSet.CUSTOMER_MILK_DATA);
            this.cUSTOMER_MILK_DATATableAdapter.FillByStartAndEndDate(this.cUSTOMER_MILK_DataSet.CUSTOMER_MILK_DATA, m_pReportStartDate.ToString("yyyy-MM-dd"), m_pReportEndDate.ToString("yyyy-MM-dd"));

            this.m_pBillReportViewer.RefreshReport();
        }

        private void m_pBillReportViewer_Load(object sender, EventArgs e)
        {
            int k = 0;
        }
    }
}
