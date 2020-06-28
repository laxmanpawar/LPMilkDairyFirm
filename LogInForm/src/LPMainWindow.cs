using LogInForm.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class LPMainWindow : LPForm
    {
        public LPMainWindow()
        {
            InitializeComponent();
        }

        private void MorningCollectionButton_Click(object sender, EventArgs e)
        {
            MilkCollectionForm milkCollectWin = new MilkCollectionForm("सकाळ");
            milkCollectWin.ShowDialog();
        }

        private void NightCollectionButton_Click(object sender, EventArgs e)
        {
            MilkCollectionForm milkCollectWin = new MilkCollectionForm("सायंकाळ");
            milkCollectWin.ShowDialog();
        }

        private void AddCustDataButton_Click(object sender, EventArgs e)
        {
            AddCustDataForm custDataForm = new AddCustDataForm();
            custDataForm.Show();
        }

        private void RateChartFeedButton_Click(object sender, EventArgs e)
        {
            // TODO : Pass Branch list to this constructor and add them to the rate chart form
            RateChartForm rateChartForm = new RateChartForm();
            rateChartForm.Show();
        }

        private void LPMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.m_pLogInForm.Close();
        }

        private void m_pBillReportButton_Click(object sender, EventArgs e)
        {
            BillReportForm billReport = new BillReportForm();
            billReport.Show();
        }
    }
}
