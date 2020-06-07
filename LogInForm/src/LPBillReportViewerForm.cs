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
    public partial class LPBillReportViewerForm : Form
    {
        public LPBillReportViewerForm()
        {
            InitializeComponent();
        }

        private void LPBillReportViewerForm_Load(object sender, EventArgs e)
        {
            this.m_pBillReportViewer.RefreshReport();
        }
    }
}
