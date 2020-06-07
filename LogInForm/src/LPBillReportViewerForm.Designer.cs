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
            this.m_pBillReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // m_pBillReportViewer
            // 
            this.m_pBillReportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_pBillReportViewer.Location = new System.Drawing.Point(12, 85);
            this.m_pBillReportViewer.Name = "m_pBillReportViewer";
            this.m_pBillReportViewer.ServerReport.BearerToken = null;
            this.m_pBillReportViewer.Size = new System.Drawing.Size(1176, 718);
            this.m_pBillReportViewer.TabIndex = 0;
            // 
            // LPBillReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 815);
            this.Controls.Add(this.m_pBillReportViewer);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LPBillReportViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPBillReportViewerForm";
            this.Load += new System.EventHandler(this.LPBillReportViewerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer m_pBillReportViewer;
    }
}