namespace LogInForm.src
{
    partial class LPBillReportViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.m_pBillReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cUSTOMERMILKDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMER_MILK_DataSet = new CUSTOMER_MILK_DataSet();
            this.cUSTOMER_MILK_DATATableAdapter = new CUSTOMER_MILK_DataSetTableAdapters.CUSTOMER_MILK_DATATableAdapter();
            this.CUSTOMER_MILK_DATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERMILKDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMER_MILK_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_MILK_DATABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pBillReportViewer
            // 
            this.m_pBillReportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_pBillReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LPDailyMilkDataSet";
            reportDataSource1.Value = this.CUSTOMER_MILK_DATABindingSource;
            this.m_pBillReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.m_pBillReportViewer.LocalReport.ReportEmbeddedResource = "LogInForm.Reports.LPDailyMilkBillReport.rdlc";
            this.m_pBillReportViewer.Location = new System.Drawing.Point(0, 0);
            this.m_pBillReportViewer.Name = "m_pBillReportViewer";
            this.m_pBillReportViewer.ServerReport.BearerToken = null;
            this.m_pBillReportViewer.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.m_pBillReportViewer.Size = new System.Drawing.Size(912, 653);
            this.m_pBillReportViewer.TabIndex = 0;
            this.m_pBillReportViewer.Load += new System.EventHandler(this.m_pBillReportViewer_Load);
            // 
            // cUSTOMERMILKDATABindingSource
            // 
            this.cUSTOMERMILKDATABindingSource.DataMember = "CUSTOMER_MILK_DATA";
            this.cUSTOMERMILKDATABindingSource.DataSource = this.cUSTOMER_MILK_DataSet;
            // 
            // cUSTOMER_MILK_DataSet
            // 
            this.cUSTOMER_MILK_DataSet.DataSetName = "CUSTOMER_MILK_DataSet";
            this.cUSTOMER_MILK_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMER_MILK_DATATableAdapter
            // 
            this.cUSTOMER_MILK_DATATableAdapter.ClearBeforeFill = true;
            // 
            // CUSTOMER_MILK_DATABindingSource
            // 
            this.CUSTOMER_MILK_DATABindingSource.DataMember = "CUSTOMER_MILK_DATA";
            this.CUSTOMER_MILK_DATABindingSource.DataSource = this.cUSTOMER_MILK_DataSet;
            // 
            // LPBillReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 653);
            this.Controls.Add(this.m_pBillReportViewer);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LPBillReportViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPBillReportViewerForm";
            this.Load += new System.EventHandler(this.LPBillReportViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERMILKDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMER_MILK_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_MILK_DATABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private Microsoft.Reporting.WinForms.ReportViewer m_pBillReportViewer;
        private CUSTOMER_MILK_DataSet cUSTOMER_MILK_DataSet;
        private System.Windows.Forms.BindingSource cUSTOMERMILKDATABindingSource;
        private CUSTOMER_MILK_DataSetTableAdapters.CUSTOMER_MILK_DATATableAdapter cUSTOMER_MILK_DATATableAdapter;
        private System.Windows.Forms.BindingSource CUSTOMER_MILK_DATABindingSource;
    }
}