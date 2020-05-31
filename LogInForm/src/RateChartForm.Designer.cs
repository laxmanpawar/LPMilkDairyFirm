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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BranchGroupBox.SuspendLayout();
            this.MilkTypeGroupBox.SuspendLayout();
            this.FatGroupBox.SuspendLayout();
            this.SNFGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RateChartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BranchGroupBox
            // 
            this.BranchGroupBox.Controls.Add(this.BranchCheckBox1);
            this.BranchGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.BranchGroupBox.Location = new System.Drawing.Point(12, 12);
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
            this.MilkTypeGroupBox.Controls.Add(this.checkBox2);
            this.MilkTypeGroupBox.Controls.Add(this.checkBox1);
            this.MilkTypeGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.MilkTypeGroupBox.Location = new System.Drawing.Point(317, 12);
            this.MilkTypeGroupBox.Name = "MilkTypeGroupBox";
            this.MilkTypeGroupBox.Size = new System.Drawing.Size(168, 76);
            this.MilkTypeGroupBox.TabIndex = 3;
            this.MilkTypeGroupBox.TabStop = false;
            this.MilkTypeGroupBox.Text = "दुध प्रकार";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(92, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 33);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "म्हैस";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 33);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "गाय";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FatGroupBox
            // 
            this.FatGroupBox.Controls.Add(this.ToLabel);
            this.FatGroupBox.Controls.Add(this.FatToTextBox);
            this.FatGroupBox.Controls.Add(this.FatFromTextBox);
            this.FatGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.FatGroupBox.Location = new System.Drawing.Point(507, 13);
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
            this.SNFGroupBox.Controls.Add(this.label1);
            this.SNFGroupBox.Controls.Add(this.SNFToTextBox);
            this.SNFGroupBox.Controls.Add(this.SNFFromTextBox);
            this.SNFGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.SNFGroupBox.Location = new System.Drawing.Point(718, 13);
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
            this.GenerateButton.Location = new System.Drawing.Point(911, 49);
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
            this.RateChartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RateChartDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.RateChartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RateChartDataGridView.Location = new System.Drawing.Point(12, 107);
            this.RateChartDataGridView.Name = "RateChartDataGridView";
            this.RateChartDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RateChartDataGridView.RowTemplate.Height = 24;
            this.RateChartDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RateChartDataGridView.Size = new System.Drawing.Size(1176, 625);
            this.RateChartDataGridView.TabIndex = 8;
            this.RateChartDataGridView.Tag = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(434, 758);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(102, 45);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "जतन करा";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetButton.Location = new System.Drawing.Point(578, 758);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 45);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "रीसेट";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelButton.Location = new System.Drawing.Point(713, 758);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 45);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "रद्द करा";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // RateChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 815);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
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
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
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
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}