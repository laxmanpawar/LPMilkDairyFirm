namespace LogInForm
{
    partial class RateChartForm
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
            this.BranchGroupBox = new System.Windows.Forms.GroupBox();
            this.BranchCheckBox1 = new System.Windows.Forms.CheckBox();
            this.MilkTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.BuffMilkTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.m_pCowMilkTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.FatGroupBox = new System.Windows.Forms.GroupBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FatToTextBox = new System.Windows.Forms.TextBox();
            this.FatFromTextBox = new System.Windows.Forms.TextBox();
            this.SNFGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SNFToTextBox = new System.Windows.Forms.TextBox();
            this.SNFFromTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.RateChartDataGridView = new System.Windows.Forms.DataGridView();
            this.m_pSaveButton = new System.Windows.Forms.Button();
            this.m_pResetButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.m_pLoadExistingButton = new System.Windows.Forms.Button();
            this.m_pPasteButton = new System.Windows.Forms.Button();
            this.BranchGroupBox.SuspendLayout();
            this.MilkTypeGroupBox.SuspendLayout();
            this.FatGroupBox.SuspendLayout();
            this.SNFGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RateChartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BranchGroupBox
            // 
            this.BranchGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BranchGroupBox.Controls.Add(this.BranchCheckBox1);
            this.BranchGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.BranchGroupBox.Location = new System.Drawing.Point(3, 12);
            this.BranchGroupBox.Name = "BranchGroupBox";
            this.BranchGroupBox.Size = new System.Drawing.Size(298, 76);
            this.BranchGroupBox.TabIndex = 1;
            this.BranchGroupBox.TabStop = false;
            this.BranchGroupBox.Text = "शाखा निवडा";
            // 
            // BranchCheckBox1
            // 
            this.BranchCheckBox1.AutoSize = true;
            this.BranchCheckBox1.Location = new System.Drawing.Point(7, 35);
            this.BranchCheckBox1.Name = "BranchCheckBox1";
            this.BranchCheckBox1.Size = new System.Drawing.Size(82, 33);
            this.BranchCheckBox1.TabIndex = 0;
            this.BranchCheckBox1.Text = "वाल्हा";
            this.BranchCheckBox1.UseVisualStyleBackColor = true;
            // 
            // MilkTypeGroupBox
            // 
            this.MilkTypeGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MilkTypeGroupBox.Controls.Add(this.BuffMilkTypeCheckBox);
            this.MilkTypeGroupBox.Controls.Add(this.m_pCowMilkTypeCheckBox);
            this.MilkTypeGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.MilkTypeGroupBox.Location = new System.Drawing.Point(308, 12);
            this.MilkTypeGroupBox.Name = "MilkTypeGroupBox";
            this.MilkTypeGroupBox.Size = new System.Drawing.Size(168, 76);
            this.MilkTypeGroupBox.TabIndex = 3;
            this.MilkTypeGroupBox.TabStop = false;
            this.MilkTypeGroupBox.Text = "दुध प्रकार";
            // 
            // BuffMilkTypeCheckBox
            // 
            this.BuffMilkTypeCheckBox.AutoSize = true;
            this.BuffMilkTypeCheckBox.Location = new System.Drawing.Point(92, 29);
            this.BuffMilkTypeCheckBox.Name = "BuffMilkTypeCheckBox";
            this.BuffMilkTypeCheckBox.Size = new System.Drawing.Size(71, 33);
            this.BuffMilkTypeCheckBox.TabIndex = 1;
            this.BuffMilkTypeCheckBox.Text = "म्हैस";
            this.BuffMilkTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_pCowMilkTypeCheckBox
            // 
            this.m_pCowMilkTypeCheckBox.AutoSize = true;
            this.m_pCowMilkTypeCheckBox.Location = new System.Drawing.Point(18, 29);
            this.m_pCowMilkTypeCheckBox.Name = "m_pCowMilkTypeCheckBox";
            this.m_pCowMilkTypeCheckBox.Size = new System.Drawing.Size(68, 33);
            this.m_pCowMilkTypeCheckBox.TabIndex = 0;
            this.m_pCowMilkTypeCheckBox.Text = "गाय";
            this.m_pCowMilkTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // FatGroupBox
            // 
            this.FatGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FatGroupBox.Controls.Add(this.ToLabel);
            this.FatGroupBox.Controls.Add(this.FatToTextBox);
            this.FatGroupBox.Controls.Add(this.FatFromTextBox);
            this.FatGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.FatGroupBox.Location = new System.Drawing.Point(498, 13);
            this.FatGroupBox.Name = "FatGroupBox";
            this.FatGroupBox.Size = new System.Drawing.Size(186, 75);
            this.FatGroupBox.TabIndex = 4;
            this.FatGroupBox.TabStop = false;
            this.FatGroupBox.Text = "फॅट";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(80, 31);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(26, 29);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "ते";
            // 
            // FatToTextBox
            // 
            this.FatToTextBox.Location = new System.Drawing.Point(112, 26);
            this.FatToTextBox.Name = "FatToTextBox";
            this.FatToTextBox.Size = new System.Drawing.Size(68, 35);
            this.FatToTextBox.TabIndex = 1;
            this.FatToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FatToTextBox_KeyPress);
            // 
            // FatFromTextBox
            // 
            this.FatFromTextBox.Location = new System.Drawing.Point(6, 26);
            this.FatFromTextBox.Name = "FatFromTextBox";
            this.FatFromTextBox.Size = new System.Drawing.Size(68, 35);
            this.FatFromTextBox.TabIndex = 0;
            this.FatFromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FatFromTextBox_KeyPress);
            // 
            // SNFGroupBox
            // 
            this.SNFGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SNFGroupBox.Controls.Add(this.label1);
            this.SNFGroupBox.Controls.Add(this.SNFToTextBox);
            this.SNFGroupBox.Controls.Add(this.SNFFromTextBox);
            this.SNFGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.SNFGroupBox.Location = new System.Drawing.Point(709, 13);
            this.SNFGroupBox.Name = "SNFGroupBox";
            this.SNFGroupBox.Size = new System.Drawing.Size(186, 75);
            this.SNFGroupBox.TabIndex = 5;
            this.SNFGroupBox.TabStop = false;
            this.SNFGroupBox.Text = "SNF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ते";
            // 
            // SNFToTextBox
            // 
            this.SNFToTextBox.Location = new System.Drawing.Point(112, 26);
            this.SNFToTextBox.Name = "SNFToTextBox";
            this.SNFToTextBox.Size = new System.Drawing.Size(68, 35);
            this.SNFToTextBox.TabIndex = 1;
            this.SNFToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SNFToTextBox_KeyPress);
            // 
            // SNFFromTextBox
            // 
            this.SNFFromTextBox.Location = new System.Drawing.Point(6, 26);
            this.SNFFromTextBox.Name = "SNFFromTextBox";
            this.SNFFromTextBox.Size = new System.Drawing.Size(68, 35);
            this.SNFFromTextBox.TabIndex = 0;
            this.SNFFromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SNFFromTextBox_KeyPress);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenerateButton.Location = new System.Drawing.Point(902, 49);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(133, 39);
            this.GenerateButton.TabIndex = 7;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // RateChartDataGridView
            // 
            this.RateChartDataGridView.AllowUserToAddRows = false;
            this.RateChartDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RateChartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RateChartDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.RateChartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RateChartDataGridView.Location = new System.Drawing.Point(49, 159);
            this.RateChartDataGridView.Name = "RateChartDataGridView";
            this.RateChartDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RateChartDataGridView.RowTemplate.Height = 24;
            this.RateChartDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RateChartDataGridView.Size = new System.Drawing.Size(1085, 531);
            this.RateChartDataGridView.TabIndex = 8;
            this.RateChartDataGridView.Tag = "";
            // 
            // m_pSaveButton
            // 
            this.m_pSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_pSaveButton.Location = new System.Drawing.Point(326, 696);
            this.m_pSaveButton.Name = "m_pSaveButton";
            this.m_pSaveButton.Size = new System.Drawing.Size(102, 45);
            this.m_pSaveButton.TabIndex = 9;
            this.m_pSaveButton.Text = "जतन करा";
            this.m_pSaveButton.UseVisualStyleBackColor = true;
            this.m_pSaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // m_pResetButton
            // 
            this.m_pResetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_pResetButton.Location = new System.Drawing.Point(557, 696);
            this.m_pResetButton.Name = "m_pResetButton";
            this.m_pResetButton.Size = new System.Drawing.Size(102, 45);
            this.m_pResetButton.TabIndex = 10;
            this.m_pResetButton.Text = "रीसेट";
            this.m_pResetButton.UseVisualStyleBackColor = true;
            this.m_pResetButton.Click += new System.EventHandler(this.m_pResetButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelButton.Location = new System.Drawing.Point(665, 696);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 45);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "रद्द करा";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // m_pLoadExistingButton
            // 
            this.m_pLoadExistingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_pLoadExistingButton.Location = new System.Drawing.Point(434, 696);
            this.m_pLoadExistingButton.Name = "m_pLoadExistingButton";
            this.m_pLoadExistingButton.Size = new System.Drawing.Size(117, 45);
            this.m_pLoadExistingButton.TabIndex = 11;
            this.m_pLoadExistingButton.Text = "Load Existing";
            this.m_pLoadExistingButton.UseVisualStyleBackColor = true;
            this.m_pLoadExistingButton.Click += new System.EventHandler(this.m_pLoadExistingButton_Click);
            // 
            // m_pPasteButton
            // 
            this.m_pPasteButton.Location = new System.Drawing.Point(1042, 50);
            this.m_pPasteButton.Name = "m_pPasteButton";
            this.m_pPasteButton.Size = new System.Drawing.Size(92, 38);
            this.m_pPasteButton.TabIndex = 12;
            this.m_pPasteButton.Text = "Paste";
            this.m_pPasteButton.UseVisualStyleBackColor = true;
            this.m_pPasteButton.Click += new System.EventHandler(this.m_pPasteButton_Click);
            // 
            // RateChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.m_pPasteButton);
            this.Controls.Add(this.m_pLoadExistingButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.m_pResetButton);
            this.Controls.Add(this.m_pSaveButton);
            this.Controls.Add(this.RateChartDataGridView);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.SNFGroupBox);
            this.Controls.Add(this.FatGroupBox);
            this.Controls.Add(this.MilkTypeGroupBox);
            this.Controls.Add(this.BranchGroupBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RateChartForm";
            this.Text = "RateChartForm";
            this.Load += new System.EventHandler(this.RateChartForm_Load);
            this.BranchGroupBox.ResumeLayout(false);
            this.BranchGroupBox.PerformLayout();
            this.MilkTypeGroupBox.ResumeLayout(false);
            this.MilkTypeGroupBox.PerformLayout();
            this.FatGroupBox.ResumeLayout(false);
            this.FatGroupBox.PerformLayout();
            this.SNFGroupBox.ResumeLayout(false);
            this.SNFGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RateChartDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox BranchGroupBox;
        private System.Windows.Forms.CheckBox BranchCheckBox1;
        private System.Windows.Forms.GroupBox MilkTypeGroupBox;
        private System.Windows.Forms.CheckBox BuffMilkTypeCheckBox;
        private System.Windows.Forms.CheckBox m_pCowMilkTypeCheckBox;
        private System.Windows.Forms.GroupBox FatGroupBox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.TextBox FatToTextBox;
        private System.Windows.Forms.TextBox FatFromTextBox;
        private System.Windows.Forms.GroupBox SNFGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SNFToTextBox;
        private System.Windows.Forms.TextBox SNFFromTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.DataGridView RateChartDataGridView;
        private System.Windows.Forms.Button m_pSaveButton;
        private System.Windows.Forms.Button m_pResetButton;
        private System.Windows.Forms.Button CancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button m_pLoadExistingButton;
        private System.Windows.Forms.Button m_pPasteButton;
    }
}