namespace LogInForm
{
    partial class BillReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillReportForm));
            this.m_pBranchComboBox = new System.Windows.Forms.ComboBox();
            this.m_pBranchLabel = new System.Windows.Forms.Label();
            this.m_pBillRoprtFromLabel = new System.Windows.Forms.Label();
            this.m_pBillReportFromDate = new System.Windows.Forms.DateTimePicker();
            this.m_pToLabel = new System.Windows.Forms.Label();
            this.m_pBillReportToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.m_pBillReportDateLabel = new System.Windows.Forms.Label();
            this.m_pReportCustDGV = new System.Windows.Forms.DataGridView();
            this.BillReportCustCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillReportCustNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_pReportMoveAllButton = new System.Windows.Forms.Button();
            this.m_pSkipReportMoveAllButton = new System.Windows.Forms.Button();
            this.m_pReportMoveSelectedButton = new System.Windows.Forms.Button();
            this.m_pSkipReportMoveSelectedButton = new System.Windows.Forms.Button();
            this.m_pTotalCustDGV = new System.Windows.Forms.DataGridView();
            this.CustCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_pDairyNameLabel = new System.Windows.Forms.Label();
            this.m_pGenerateReportButton = new System.Windows.Forms.Button();
            this.m_pResetCustDataButton = new System.Windows.Forms.Button();
            this.m_pCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_pReportCustDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pTotalCustDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pBranchComboBox
            // 
            this.m_pBranchComboBox.FormattingEnabled = true;
            this.m_pBranchComboBox.Items.AddRange(new object[] {
            "वाल्हा"});
            this.m_pBranchComboBox.Location = new System.Drawing.Point(108, 71);
            this.m_pBranchComboBox.Name = "m_pBranchComboBox";
            this.m_pBranchComboBox.Size = new System.Drawing.Size(129, 37);
            this.m_pBranchComboBox.TabIndex = 1;
            // 
            // m_pBranchLabel
            // 
            this.m_pBranchLabel.AutoSize = true;
            this.m_pBranchLabel.Location = new System.Drawing.Point(23, 74);
            this.m_pBranchLabel.Name = "m_pBranchLabel";
            this.m_pBranchLabel.Size = new System.Drawing.Size(79, 29);
            this.m_pBranchLabel.TabIndex = 2;
            this.m_pBranchLabel.Text = "Branch";
            // 
            // m_pBillRoprtFromLabel
            // 
            this.m_pBillRoprtFromLabel.AutoSize = true;
            this.m_pBillRoprtFromLabel.Location = new System.Drawing.Point(243, 75);
            this.m_pBillRoprtFromLabel.Name = "m_pBillRoprtFromLabel";
            this.m_pBillRoprtFromLabel.Size = new System.Drawing.Size(62, 29);
            this.m_pBillRoprtFromLabel.TabIndex = 3;
            this.m_pBillRoprtFromLabel.Text = "From";
            // 
            // m_pBillReportFromDate
            // 
            this.m_pBillReportFromDate.CustomFormat = "dd-MM-yyyy";
            this.m_pBillReportFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_pBillReportFromDate.Location = new System.Drawing.Point(311, 74);
            this.m_pBillReportFromDate.Name = "m_pBillReportFromDate";
            this.m_pBillReportFromDate.Size = new System.Drawing.Size(145, 35);
            this.m_pBillReportFromDate.TabIndex = 4;
            // 
            // m_pToLabel
            // 
            this.m_pToLabel.AutoSize = true;
            this.m_pToLabel.Location = new System.Drawing.Point(462, 79);
            this.m_pToLabel.Name = "m_pToLabel";
            this.m_pToLabel.Size = new System.Drawing.Size(38, 29);
            this.m_pToLabel.TabIndex = 3;
            this.m_pToLabel.Text = "To";
            // 
            // m_pBillReportToDate
            // 
            this.m_pBillReportToDate.CustomFormat = "dd-MM-yyyy";
            this.m_pBillReportToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_pBillReportToDate.Location = new System.Drawing.Point(506, 75);
            this.m_pBillReportToDate.Name = "m_pBillReportToDate";
            this.m_pBillReportToDate.Size = new System.Drawing.Size(146, 35);
            this.m_pBillReportToDate.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(990, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 35);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // m_pBillReportDateLabel
            // 
            this.m_pBillReportDateLabel.AutoSize = true;
            this.m_pBillReportDateLabel.Location = new System.Drawing.Point(852, 75);
            this.m_pBillReportDateLabel.Name = "m_pBillReportDateLabel";
            this.m_pBillReportDateLabel.Size = new System.Drawing.Size(132, 29);
            this.m_pBillReportDateLabel.TabIndex = 2;
            this.m_pBillReportDateLabel.Text = "Report Date";
            // 
            // m_pReportCustDGV
            // 
            this.m_pReportCustDGV.AllowUserToAddRows = false;
            this.m_pReportCustDGV.AllowUserToDeleteRows = false;
            this.m_pReportCustDGV.AllowUserToResizeRows = false;
            this.m_pReportCustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_pReportCustDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillReportCustCodeColumn,
            this.BillReportCustNameColumn});
            this.m_pReportCustDGV.Location = new System.Drawing.Point(660, 142);
            this.m_pReportCustDGV.Name = "m_pReportCustDGV";
            this.m_pReportCustDGV.ReadOnly = true;
            this.m_pReportCustDGV.RowHeadersWidth = 51;
            this.m_pReportCustDGV.RowTemplate.Height = 24;
            this.m_pReportCustDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_pReportCustDGV.Size = new System.Drawing.Size(530, 580);
            this.m_pReportCustDGV.TabIndex = 7;
            // 
            // BillReportCustCodeColumn
            // 
            this.BillReportCustCodeColumn.HeaderText = "कोड";
            this.BillReportCustCodeColumn.MinimumWidth = 6;
            this.BillReportCustCodeColumn.Name = "BillReportCustCodeColumn";
            this.BillReportCustCodeColumn.ReadOnly = true;
            this.BillReportCustCodeColumn.Width = 60;
            // 
            // BillReportCustNameColumn
            // 
            this.BillReportCustNameColumn.HeaderText = "नाव";
            this.BillReportCustNameColumn.MinimumWidth = 6;
            this.BillReportCustNameColumn.Name = "BillReportCustNameColumn";
            this.BillReportCustNameColumn.ReadOnly = true;
            this.BillReportCustNameColumn.Width = 450;
            // 
            // m_pReportMoveAllButton
            // 
            this.m_pReportMoveAllButton.Location = new System.Drawing.Point(548, 299);
            this.m_pReportMoveAllButton.Name = "m_pReportMoveAllButton";
            this.m_pReportMoveAllButton.Size = new System.Drawing.Size(106, 39);
            this.m_pReportMoveAllButton.TabIndex = 8;
            this.m_pReportMoveAllButton.Text = "All ->";
            this.m_pReportMoveAllButton.UseVisualStyleBackColor = true;
            this.m_pReportMoveAllButton.Click += new System.EventHandler(this.m_pReportMoveAllButton_Click);
            // 
            // m_pSkipReportMoveAllButton
            // 
            this.m_pSkipReportMoveAllButton.Location = new System.Drawing.Point(549, 345);
            this.m_pSkipReportMoveAllButton.Name = "m_pSkipReportMoveAllButton";
            this.m_pSkipReportMoveAllButton.Size = new System.Drawing.Size(105, 40);
            this.m_pSkipReportMoveAllButton.TabIndex = 9;
            this.m_pSkipReportMoveAllButton.Text = "<- All";
            this.m_pSkipReportMoveAllButton.UseVisualStyleBackColor = true;
            this.m_pSkipReportMoveAllButton.Click += new System.EventHandler(this.m_pSkipReportMoveAllButton_Click);
            // 
            // m_pReportMoveSelectedButton
            // 
            this.m_pReportMoveSelectedButton.Location = new System.Drawing.Point(549, 392);
            this.m_pReportMoveSelectedButton.Name = "m_pReportMoveSelectedButton";
            this.m_pReportMoveSelectedButton.Size = new System.Drawing.Size(105, 37);
            this.m_pReportMoveSelectedButton.TabIndex = 10;
            this.m_pReportMoveSelectedButton.Text = "Selected->";
            this.m_pReportMoveSelectedButton.UseVisualStyleBackColor = true;
            this.m_pReportMoveSelectedButton.Click += new System.EventHandler(this.m_pReportMoveSelectedButton_Click);
            // 
            // m_pSkipReportMoveSelectedButton
            // 
            this.m_pSkipReportMoveSelectedButton.Location = new System.Drawing.Point(549, 436);
            this.m_pSkipReportMoveSelectedButton.Name = "m_pSkipReportMoveSelectedButton";
            this.m_pSkipReportMoveSelectedButton.Size = new System.Drawing.Size(105, 35);
            this.m_pSkipReportMoveSelectedButton.TabIndex = 11;
            this.m_pSkipReportMoveSelectedButton.Text = "<-Selected";
            this.m_pSkipReportMoveSelectedButton.UseVisualStyleBackColor = true;
            this.m_pSkipReportMoveSelectedButton.Click += new System.EventHandler(this.m_pSkipReportMoveSelectedButton_Click);
            // 
            // m_pTotalCustDGV
            // 
            this.m_pTotalCustDGV.AllowUserToAddRows = false;
            this.m_pTotalCustDGV.AllowUserToDeleteRows = false;
            this.m_pTotalCustDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_pTotalCustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_pTotalCustDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustCodeColumn,
            this.CustNameColumn});
            this.m_pTotalCustDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.m_pTotalCustDGV.Location = new System.Drawing.Point(13, 142);
            this.m_pTotalCustDGV.Name = "m_pTotalCustDGV";
            this.m_pTotalCustDGV.ReadOnly = true;
            this.m_pTotalCustDGV.RowHeadersWidth = 51;
            this.m_pTotalCustDGV.RowTemplate.Height = 24;
            this.m_pTotalCustDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_pTotalCustDGV.Size = new System.Drawing.Size(529, 580);
            this.m_pTotalCustDGV.TabIndex = 12;
            // 
            // CustCodeColumn
            // 
            this.CustCodeColumn.HeaderText = "कोड";
            this.CustCodeColumn.MinimumWidth = 6;
            this.CustCodeColumn.Name = "CustCodeColumn";
            this.CustCodeColumn.ReadOnly = true;
            // 
            // CustNameColumn
            // 
            this.CustNameColumn.HeaderText = "नाव";
            this.CustNameColumn.MinimumWidth = 6;
            this.CustNameColumn.Name = "CustNameColumn";
            this.CustNameColumn.ReadOnly = true;
            // 
            // m_pDairyNameLabel
            // 
            this.m_pDairyNameLabel.AutoSize = true;
            this.m_pDairyNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_pDairyNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.m_pDairyNameLabel.Location = new System.Drawing.Point(388, 9);
            this.m_pDairyNameLabel.Name = "m_pDairyNameLabel";
            this.m_pDairyNameLabel.Size = new System.Drawing.Size(105, 45);
            this.m_pDairyNameLabel.TabIndex = 13;
            this.m_pDairyNameLabel.Text = "Dairy";
            // 
            // m_pGenerateReportButton
            // 
            this.m_pGenerateReportButton.Location = new System.Drawing.Point(426, 764);
            this.m_pGenerateReportButton.Name = "m_pGenerateReportButton";
            this.m_pGenerateReportButton.Size = new System.Drawing.Size(106, 45);
            this.m_pGenerateReportButton.TabIndex = 14;
            this.m_pGenerateReportButton.Text = "&Generate";
            this.m_pGenerateReportButton.UseVisualStyleBackColor = true;
            this.m_pGenerateReportButton.Click += new System.EventHandler(this.m_pGenerateReportButton_Click);
            // 
            // m_pResetCustDataButton
            // 
            this.m_pResetCustDataButton.Location = new System.Drawing.Point(558, 764);
            this.m_pResetCustDataButton.Name = "m_pResetCustDataButton";
            this.m_pResetCustDataButton.Size = new System.Drawing.Size(106, 45);
            this.m_pResetCustDataButton.TabIndex = 14;
            this.m_pResetCustDataButton.Text = "Reset";
            this.m_pResetCustDataButton.UseVisualStyleBackColor = true;
            // 
            // m_pCloseButton
            // 
            this.m_pCloseButton.Location = new System.Drawing.Point(690, 764);
            this.m_pCloseButton.Name = "m_pCloseButton";
            this.m_pCloseButton.Size = new System.Drawing.Size(106, 45);
            this.m_pCloseButton.TabIndex = 14;
            this.m_pCloseButton.Text = "Close";
            this.m_pCloseButton.UseVisualStyleBackColor = true;
            this.m_pCloseButton.Click += new System.EventHandler(this.m_pCloseButton_Click);
            // 
            // BillReportForm
            // 
            this.AcceptButton = this.m_pGenerateReportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 821);
            this.Controls.Add(this.m_pCloseButton);
            this.Controls.Add(this.m_pResetCustDataButton);
            this.Controls.Add(this.m_pGenerateReportButton);
            this.Controls.Add(this.m_pDairyNameLabel);
            this.Controls.Add(this.m_pTotalCustDGV);
            this.Controls.Add(this.m_pSkipReportMoveSelectedButton);
            this.Controls.Add(this.m_pReportMoveSelectedButton);
            this.Controls.Add(this.m_pSkipReportMoveAllButton);
            this.Controls.Add(this.m_pReportMoveAllButton);
            this.Controls.Add(this.m_pReportCustDGV);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.m_pBillReportToDate);
            this.Controls.Add(this.m_pBillReportFromDate);
            this.Controls.Add(this.m_pToLabel);
            this.Controls.Add(this.m_pBillRoprtFromLabel);
            this.Controls.Add(this.m_pBillReportDateLabel);
            this.Controls.Add(this.m_pBranchLabel);
            this.Controls.Add(this.m_pBranchComboBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BillReportForm";
            this.Text = "BillReportForm";
            this.Load += new System.EventHandler(this.BillReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_pReportCustDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pTotalCustDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox m_pBranchComboBox;
        private System.Windows.Forms.Label m_pBranchLabel;
        private System.Windows.Forms.Label m_pBillRoprtFromLabel;
        private System.Windows.Forms.DateTimePicker m_pBillReportFromDate;
        private System.Windows.Forms.Label m_pToLabel;
        private System.Windows.Forms.DateTimePicker m_pBillReportToDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label m_pBillReportDateLabel;
        private System.Windows.Forms.DataGridView m_pReportCustDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillReportCustCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillReportCustNameColumn;
        private System.Windows.Forms.Button m_pReportMoveAllButton;
        private System.Windows.Forms.Button m_pSkipReportMoveAllButton;
        private System.Windows.Forms.Button m_pReportMoveSelectedButton;
        private System.Windows.Forms.Button m_pSkipReportMoveSelectedButton;
        private System.Windows.Forms.DataGridView m_pTotalCustDGV;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label m_pDairyNameLabel;
        private System.Windows.Forms.Button m_pGenerateReportButton;
        private System.Windows.Forms.Button m_pResetCustDataButton;
        private System.Windows.Forms.Button m_pCloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNameColumn;
    }
}