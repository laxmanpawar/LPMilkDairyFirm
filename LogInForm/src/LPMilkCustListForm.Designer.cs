namespace LogInForm.src
{
    partial class LPMilkCustListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LPMilkCustListForm));
            this.m_pMilkCustListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.m_pMilkCustListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pMilkCustListDataGridView
            // 
            this.m_pMilkCustListDataGridView.AllowUserToAddRows = false;
            this.m_pMilkCustListDataGridView.AllowUserToDeleteRows = false;
            this.m_pMilkCustListDataGridView.AllowUserToResizeRows = false;
            this.m_pMilkCustListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pMilkCustListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_pMilkCustListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.m_pMilkCustListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_pMilkCustListDataGridView.Location = new System.Drawing.Point(14, 54);
            this.m_pMilkCustListDataGridView.Name = "m_pMilkCustListDataGridView";
            this.m_pMilkCustListDataGridView.RowHeadersWidth = 51;
            this.m_pMilkCustListDataGridView.RowTemplate.Height = 24;
            this.m_pMilkCustListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_pMilkCustListDataGridView.Size = new System.Drawing.Size(846, 350);
            this.m_pMilkCustListDataGridView.TabIndex = 0;
            // 
            // LPMilkCustListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 521);
            this.Controls.Add(this.m_pMilkCustListDataGridView);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "LPMilkCustListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPMilkCustListForm";
            this.Load += new System.EventHandler(this.LPMilkCustListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_pMilkCustListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_pMilkCustListDataGridView;
    }
}