namespace LogInForm
{
    partial class AddCustDataForm
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
            this.CustDataGroupBox = new System.Windows.Forms.GroupBox();
            this.ViewEditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustMobTextBox = new System.Windows.Forms.TextBox();
            this.CustMilkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CustIdTextBox = new System.Windows.Forms.TextBox();
            this.CustIdLabel = new System.Windows.Forms.Label();
            this.MilkTypeLabel = new System.Windows.Forms.Label();
            this.CustMobLabel = new System.Windows.Forms.Label();
            this.CustNameTextBox = new System.Windows.Forms.TextBox();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.CustNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CustIdErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CustMilkTypeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CustMobErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CustDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustIdErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustMilkTypeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustMobErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CustDataGroupBox
            // 
            this.CustDataGroupBox.Controls.Add(this.ViewEditButton);
            this.CustDataGroupBox.Controls.Add(this.CancelButton);
            this.CustDataGroupBox.Controls.Add(this.ResetButton);
            this.CustDataGroupBox.Controls.Add(this.AddButton);
            this.CustDataGroupBox.Controls.Add(this.CustMobTextBox);
            this.CustDataGroupBox.Controls.Add(this.CustMilkTypeComboBox);
            this.CustDataGroupBox.Controls.Add(this.CustIdTextBox);
            this.CustDataGroupBox.Controls.Add(this.CustIdLabel);
            this.CustDataGroupBox.Controls.Add(this.MilkTypeLabel);
            this.CustDataGroupBox.Controls.Add(this.CustMobLabel);
            this.CustDataGroupBox.Controls.Add(this.CustNameTextBox);
            this.CustDataGroupBox.Controls.Add(this.CustNameLabel);
            this.CustDataGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CustDataGroupBox.Location = new System.Drawing.Point(60, 75);
            this.CustDataGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustDataGroupBox.Name = "CustDataGroupBox";
            this.CustDataGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustDataGroupBox.Size = new System.Drawing.Size(646, 302);
            this.CustDataGroupBox.TabIndex = 2;
            this.CustDataGroupBox.TabStop = false;
            this.CustDataGroupBox.Text = "ग्राहक माहिती";
            // 
            // ViewEditButton
            // 
            this.ViewEditButton.Location = new System.Drawing.Point(315, 249);
            this.ViewEditButton.Name = "ViewEditButton";
            this.ViewEditButton.Size = new System.Drawing.Size(85, 44);
            this.ViewEditButton.TabIndex = 14;
            this.ViewEditButton.Text = "View/Edit";
            this.ViewEditButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(406, 249);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(85, 44);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(224, 249);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(85, 44);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(125, 249);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 44);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustMobTextBox
            // 
            this.CustMobTextBox.Location = new System.Drawing.Point(199, 178);
            this.CustMobTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustMobTextBox.Name = "CustMobTextBox";
            this.CustMobTextBox.Size = new System.Drawing.Size(412, 35);
            this.CustMobTextBox.TabIndex = 10;
            this.CustMobTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustMobTextBox_KeyPress);
            this.CustMobTextBox.Leave += new System.EventHandler(this.CustMobTextBox_Leave);
            // 
            // CustMilkTypeComboBox
            // 
            this.CustMilkTypeComboBox.FormattingEnabled = true;
            this.CustMilkTypeComboBox.Items.AddRange(new object[] {
            "गाय",
            "म्हैस"});
            this.CustMilkTypeComboBox.Location = new System.Drawing.Point(199, 129);
            this.CustMilkTypeComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustMilkTypeComboBox.Name = "CustMilkTypeComboBox";
            this.CustMilkTypeComboBox.Size = new System.Drawing.Size(179, 37);
            this.CustMilkTypeComboBox.TabIndex = 9;
            this.CustMilkTypeComboBox.Leave += new System.EventHandler(this.MilkTypeComboBox_Leave);
            // 
            // CustIdTextBox
            // 
            this.CustIdTextBox.Location = new System.Drawing.Point(199, 36);
            this.CustIdTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustIdTextBox.Name = "CustIdTextBox";
            this.CustIdTextBox.Size = new System.Drawing.Size(412, 35);
            this.CustIdTextBox.TabIndex = 0;
            this.CustIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustIdTextBox_KeyPress);
            this.CustIdTextBox.Leave += new System.EventHandler(this.CustIdTextBox_Leave);
            // 
            // CustIdLabel
            // 
            this.CustIdLabel.AutoSize = true;
            this.CustIdLabel.ForeColor = System.Drawing.Color.Maroon;
            this.CustIdLabel.Location = new System.Drawing.Point(23, 42);
            this.CustIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustIdLabel.Name = "CustIdLabel";
            this.CustIdLabel.Size = new System.Drawing.Size(52, 29);
            this.CustIdLabel.TabIndex = 6;
            this.CustIdLabel.Text = "कोड";
            // 
            // MilkTypeLabel
            // 
            this.MilkTypeLabel.AutoSize = true;
            this.MilkTypeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.MilkTypeLabel.Location = new System.Drawing.Point(23, 132);
            this.MilkTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MilkTypeLabel.Name = "MilkTypeLabel";
            this.MilkTypeLabel.Size = new System.Drawing.Size(94, 29);
            this.MilkTypeLabel.TabIndex = 4;
            this.MilkTypeLabel.Text = "दुध प्रकार";
            // 
            // CustMobLabel
            // 
            this.CustMobLabel.AutoSize = true;
            this.CustMobLabel.ForeColor = System.Drawing.Color.Maroon;
            this.CustMobLabel.Location = new System.Drawing.Point(23, 184);
            this.CustMobLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustMobLabel.Name = "CustMobLabel";
            this.CustMobLabel.Size = new System.Drawing.Size(141, 29);
            this.CustMobLabel.TabIndex = 2;
            this.CustMobLabel.Text = "मोबाईल क्रमांक";
            // 
            // CustNameTextBox
            // 
            this.CustNameTextBox.Location = new System.Drawing.Point(199, 82);
            this.CustNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustNameTextBox.Name = "CustNameTextBox";
            this.CustNameTextBox.Size = new System.Drawing.Size(412, 35);
            this.CustNameTextBox.TabIndex = 1;
            this.CustNameTextBox.Leave += new System.EventHandler(this.CustNameTextBox_Leave);
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.CustNameLabel.Location = new System.Drawing.Point(23, 82);
            this.CustNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(46, 29);
            this.CustNameLabel.TabIndex = 0;
            this.CustNameLabel.Text = "नाव";
            // 
            // CustNameErrorProvider
            // 
            this.CustNameErrorProvider.ContainerControl = this;
            // 
            // CustIdErrorProvider
            // 
            this.CustIdErrorProvider.ContainerControl = this;
            // 
            // CustMilkTypeErrorProvider
            // 
            this.CustMilkTypeErrorProvider.ContainerControl = this;
            // 
            // CustMobErrorProvider
            // 
            this.CustMobErrorProvider.ContainerControl = this;
            // 
            // AddCustDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 409);
            this.Controls.Add(this.CustDataGroupBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddCustDataForm";
            this.Text = "AddCustDataForm";
            this.Load += new System.EventHandler(this.AddCustDataForm_Load);
            this.CustDataGroupBox.ResumeLayout(false);
            this.CustDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustIdErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustMilkTypeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustMobErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustDataGroupBox;
        private System.Windows.Forms.TextBox CustMobTextBox;
        private System.Windows.Forms.ComboBox CustMilkTypeComboBox;
        private System.Windows.Forms.TextBox CustIdTextBox;
        private System.Windows.Forms.Label CustIdLabel;
        private System.Windows.Forms.Label MilkTypeLabel;
        private System.Windows.Forms.Label CustMobLabel;
        private System.Windows.Forms.TextBox CustNameTextBox;
        private System.Windows.Forms.Label CustNameLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ErrorProvider CustNameErrorProvider;
        private System.Windows.Forms.ErrorProvider CustIdErrorProvider;
        private System.Windows.Forms.ErrorProvider CustMilkTypeErrorProvider;
        private System.Windows.Forms.ErrorProvider CustMobErrorProvider;
        private System.Windows.Forms.Button ViewEditButton;
    }
}