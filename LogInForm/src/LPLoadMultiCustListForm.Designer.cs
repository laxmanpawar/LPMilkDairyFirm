namespace LogInForm.src
{
    partial class LPLoadMultiCustListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_pCustListDataGridView = new System.Windows.Forms.DataGridView();
            this.CUST_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MILK_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_MOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_ACC_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_pLoadButton = new System.Windows.Forms.Button();
            this.m_pAddButton = new System.Windows.Forms.Button();
            this.m_pResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_pCustListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pCustListDataGridView
            // 
            this.m_pCustListDataGridView.AllowUserToAddRows = false;
            this.m_pCustListDataGridView.AllowUserToDeleteRows = false;
            this.m_pCustListDataGridView.AllowUserToResizeRows = false;
            this.m_pCustListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pCustListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_pCustListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_pCustListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUST_CODE,
            this.CUST_NAME,
            this.MILK_TYPE,
            this.CUST_MOB,
            this.CUST_ACC_NO});
            this.m_pCustListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.m_pCustListDataGridView.Name = "m_pCustListDataGridView";
            this.m_pCustListDataGridView.ReadOnly = true;
            this.m_pCustListDataGridView.RowHeadersWidth = 51;
            this.m_pCustListDataGridView.RowTemplate.Height = 24;
            this.m_pCustListDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_pCustListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_pCustListDataGridView.Size = new System.Drawing.Size(862, 465);
            this.m_pCustListDataGridView.TabIndex = 0;
            // 
            // CUST_CODE
            // 
            this.CUST_CODE.FillWeight = 79.47924F;
            this.CUST_CODE.HeaderText = "CUST_CODE";
            this.CUST_CODE.MinimumWidth = 6;
            this.CUST_CODE.Name = "CUST_CODE";
            this.CUST_CODE.ReadOnly = true;
            // 
            // CUST_NAME
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Shivaji01", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUST_NAME.DefaultCellStyle = dataGridViewCellStyle1;
            this.CUST_NAME.FillWeight = 160.069F;
            this.CUST_NAME.HeaderText = "CUST_NAME";
            this.CUST_NAME.MinimumWidth = 6;
            this.CUST_NAME.Name = "CUST_NAME";
            this.CUST_NAME.ReadOnly = true;
            // 
            // MILK_TYPE
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Shivaji01", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MILK_TYPE.DefaultCellStyle = dataGridViewCellStyle2;
            this.MILK_TYPE.FillWeight = 77.06489F;
            this.MILK_TYPE.HeaderText = "MILK_TYPE";
            this.MILK_TYPE.MinimumWidth = 6;
            this.MILK_TYPE.Name = "MILK_TYPE";
            this.MILK_TYPE.ReadOnly = true;
            // 
            // CUST_MOB
            // 
            this.CUST_MOB.FillWeight = 97.82523F;
            this.CUST_MOB.HeaderText = "CUST_MOB";
            this.CUST_MOB.MinimumWidth = 6;
            this.CUST_MOB.Name = "CUST_MOB";
            this.CUST_MOB.ReadOnly = true;
            // 
            // CUST_ACC_NO
            // 
            this.CUST_ACC_NO.FillWeight = 85.56148F;
            this.CUST_ACC_NO.HeaderText = "ACC_No";
            this.CUST_ACC_NO.MinimumWidth = 6;
            this.CUST_ACC_NO.Name = "CUST_ACC_NO";
            this.CUST_ACC_NO.ReadOnly = true;
            // 
            // m_pLoadButton
            // 
            this.m_pLoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pLoadButton.Location = new System.Drawing.Point(203, 493);
            this.m_pLoadButton.Name = "m_pLoadButton";
            this.m_pLoadButton.Size = new System.Drawing.Size(97, 53);
            this.m_pLoadButton.TabIndex = 1;
            this.m_pLoadButton.Text = "Paste";
            this.m_pLoadButton.UseVisualStyleBackColor = true;
            this.m_pLoadButton.Click += new System.EventHandler(this.m_pLoadButton_Click);
            // 
            // m_pAddButton
            // 
            this.m_pAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pAddButton.Location = new System.Drawing.Point(306, 493);
            this.m_pAddButton.Name = "m_pAddButton";
            this.m_pAddButton.Size = new System.Drawing.Size(97, 53);
            this.m_pAddButton.TabIndex = 1;
            this.m_pAddButton.Text = "Add";
            this.m_pAddButton.UseVisualStyleBackColor = true;
            this.m_pAddButton.Click += new System.EventHandler(this.m_pAddButton_Click);
            // 
            // m_pResetButton
            // 
            this.m_pResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pResetButton.Location = new System.Drawing.Point(409, 493);
            this.m_pResetButton.Name = "m_pResetButton";
            this.m_pResetButton.Size = new System.Drawing.Size(97, 53);
            this.m_pResetButton.TabIndex = 1;
            this.m_pResetButton.Text = "Reset";
            this.m_pResetButton.UseVisualStyleBackColor = true;
            this.m_pResetButton.Click += new System.EventHandler(this.m_pResetButton_Click);
            // 
            // LPLoadMultiCustListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 558);
            this.Controls.Add(this.m_pResetButton);
            this.Controls.Add(this.m_pAddButton);
            this.Controls.Add(this.m_pLoadButton);
            this.Controls.Add(this.m_pCustListDataGridView);
            this.Name = "LPLoadMultiCustListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPLoadMultiCustListForm";
            this.Load += new System.EventHandler(this.LPLoadMultiCustListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_pCustListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_pCustListDataGridView;
        private System.Windows.Forms.Button m_pLoadButton;
        private System.Windows.Forms.Button m_pAddButton;
        private System.Windows.Forms.Button m_pResetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MILK_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_MOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_ACC_NO;
    }
}