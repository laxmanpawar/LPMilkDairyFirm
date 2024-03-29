﻿using LogInForm.src;
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
    public partial class LPMainWindow : Form
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
            //Application.Exit();
        }

        private void m_pBillReportButton_Click(object sender, EventArgs e)
        {
            BillReportForm billReport = new BillReportForm();
            billReport.Show();
        }

        private void m_pEditCustList_Click(object sender, EventArgs e)
        {
            LPEditMilkCollectionCustListForm collectionCustListForm = new LPEditMilkCollectionCustListForm();
            collectionCustListForm.Show();
        }

        private void LPMainWindow_Load(object sender, EventArgs e)
        {
            /*
              ******************** TODO : SUPPORT ACTIVE CUSTOMER LIST BUTTON. *****************
              ******************** TIll HIDE EDIT ACTIVE CUSTOMER LIST BUTTON. *****************
             */
            m_pEditCustListButton.Hide();

        }
    }
}
