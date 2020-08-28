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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustDataForm));
            this.CustDataGroupBox = new System.Windows.Forms.GroupBox();
            this.m_pLoadXMLButton = new System.Windows.Forms.Button();
            this.m_pUpdateButton = new System.Windows.Forms.Button();
            this.m_pCancelButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustAccNoTextBox = new System.Windows.Forms.TextBox();
            this.CustMobTextBox = new System.Windows.Forms.TextBox();
            this.CustMilkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CustIdTextBox = new System.Windows.Forms.TextBox();
            this.CustIdLabel = new System.Windows.Forms.Label();
            this.CustAccNoLabel = new System.Windows.Forms.Label();
            this.MilkTypeLabel = new System.Windows.Forms.Label();
            this.CustMobLabel = new System.Windows.Forms.Label();
            this.CustNameTextBox = new System.Windows.Forms.TextBox();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.CustNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CustIdErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CustMilkTypeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CustDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustIdErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustMilkTypeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CustDataGroupBox
            // 
            this.CustDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustDataGroupBox.Controls.Add(this.m_pLoadXMLButton);
            this.CustDataGroupBox.Controls.Add(this.m_pUpdateButton);
            this.CustDataGroupBox.Controls.Add(this.m_pCancelButton);
            this.CustDataGroupBox.Controls.Add(this.ResetButton);
            this.CustDataGroupBox.Controls.Add(this.AddButton);
            this.CustDataGroupBox.Controls.Add(this.CustAccNoTextBox);
            this.CustDataGroupBox.Controls.Add(this.CustMobTextBox);
            this.CustDataGroupBox.Controls.Add(this.CustMilkTypeComboBox);
            this.CustDataGroupBox.Controls.Add(this.CustIdTextBox);
            this.CustDataGroupBox.Controls.Add(this.CustIdLabel);
            this.CustDataGroupBox.Controls.Add(this.CustAccNoLabel);
            this.CustDataGroupBox.Controls.Add(this.MilkTypeLabel);
            this.CustDataGroupBox.Controls.Add(this.CustMobLabel);
            this.CustDataGroupBox.Controls.Add(this.CustNameTextBox);
            this.CustDataGroupBox.Controls.Add(this.CustNameLabel);
            this.CustDataGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CustDataGroupBox.Location = new System.Drawing.Point(60, 75);
            this.CustDataGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustDataGroupBox.Name = "CustDataGroupBox";
            this.CustDataGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustDataGroupBox.Size = new System.Drawing.Size(858, 515);
            this.CustDataGroupBox.TabIndex = 2;
            this.CustDataGroupBox.TabStop = false;
            this.CustDataGroupBox.Text = "ग्राहक माहिती";
            // 
            // m_pLoadXMLButton
            // 
            this.m_pLoadXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pLoadXMLButton.Location = new System.Drawing.Point(83, 299);
            this.m_pLoadXMLButton.Name = "m_pLoadXMLButton";
            this.m_pLoadXMLButton.Size = new System.Drawing.Size(104, 54);
            this.m_pLoadXMLButton.TabIndex = 8;
            this.m_pLoadXMLButton.Text = "Load";
            this.m_pLoadXMLButton.UseVisualStyleBackColor = true;
            this.m_pLoadXMLButton.Click += new System.EventHandler(this.m_pLoadXMLButton_Click);
            // 
            // m_pUpdateButton
            // 
            this.m_pUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pUpdateButton.Location = new System.Drawing.Point(312, 299);
            this.m_pUpdateButton.Name = "m_pUpdateButton";
            this.m_pUpdateButton.Size = new System.Drawing.Size(98, 54);
            this.m_pUpdateButton.TabIndex = 5;
            this.m_pUpdateButton.Text = "Update";
            this.m_pUpdateButton.UseVisualStyleBackColor = true;
            this.m_pUpdateButton.Click += new System.EventHandler(this.m_pUpdateButton_Click);
            // 
            // m_pCancelButton
            // 
            this.m_pCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pCancelButton.Location = new System.Drawing.Point(526, 299);
            this.m_pCancelButton.Name = "m_pCancelButton";
            this.m_pCancelButton.Size = new System.Drawing.Size(98, 54);
            this.m_pCancelButton.TabIndex = 7;
            this.m_pCancelButton.Text = "Cancel";
            this.m_pCancelButton.UseVisualStyleBackColor = true;
            this.m_pCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(420, 299);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(98, 54);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(199, 299);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 54);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustAccNoTextBox
            // 
            this.CustAccNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustAccNoTextBox.Location = new System.Drawing.Point(199, 225);
            this.CustAccNoTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustAccNoTextBox.Name = "CustAccNoTextBox";
            this.CustAccNoTextBox.Size = new System.Drawing.Size(425, 35);
            this.CustAccNoTextBox.TabIndex = 3;
            this.CustAccNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustMobTextBox_KeyPress);
            // 
            // CustMobTextBox
            // 
            this.CustMobTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustMobTextBox.Location = new System.Drawing.Point(199, 178);
            this.CustMobTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustMobTextBox.Name = "CustMobTextBox";
            this.CustMobTextBox.Size = new System.Drawing.Size(425, 35);
            this.CustMobTextBox.TabIndex = 2;
            this.CustMobTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustMobTextBox_KeyPress);
            // 
            // CustMilkTypeComboBox
            // 
            this.CustMilkTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustMilkTypeComboBox.FormattingEnabled = true;
            this.CustMilkTypeComboBox.Items.AddRange(new object[] {
            "गाय",
            "म्हैस"});
            this.CustMilkTypeComboBox.Location = new System.Drawing.Point(199, 129);
            this.CustMilkTypeComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustMilkTypeComboBox.Name = "CustMilkTypeComboBox";
            this.CustMilkTypeComboBox.Size = new System.Drawing.Size(192, 37);
            this.CustMilkTypeComboBox.TabIndex = 9;
            this.CustMilkTypeComboBox.Leave += new System.EventHandler(this.MilkTypeComboBox_Leave);
            // 
            // CustIdTextBox
            // 
            this.CustIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustIdTextBox.Location = new System.Drawing.Point(199, 36);
            this.CustIdTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustIdTextBox.Name = "CustIdTextBox";
            this.CustIdTextBox.Size = new System.Drawing.Size(425, 35);
            this.CustIdTextBox.TabIndex = 0;
            this.CustIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustIdTextBox_KeyPress);
            this.CustIdTextBox.Leave += new System.EventHandler(this.CustIdTextBox_Leave);
            // 
            // CustIdLabel
            // 
            this.CustIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustIdLabel.AutoSize = true;
            this.CustIdLabel.ForeColor = System.Drawing.Color.Maroon;
            this.CustIdLabel.Location = new System.Drawing.Point(23, 42);
            this.CustIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustIdLabel.Name = "CustIdLabel";
            this.CustIdLabel.Size = new System.Drawing.Size(52, 29);
            this.CustIdLabel.TabIndex = 6;
            this.CustIdLabel.Text = "कोड";
            // 
            // CustAccNoLabel
            // 
            this.CustAccNoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustAccNoLabel.AutoSize = true;
            this.CustAccNoLabel.ForeColor = System.Drawing.Color.Maroon;
            this.CustAccNoLabel.Location = new System.Drawing.Point(23, 231);
            this.CustAccNoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustAccNoLabel.Name = "CustAccNoLabel";
            this.CustAccNoLabel.Size = new System.Drawing.Size(132, 29);
            this.CustAccNoLabel.TabIndex = 2;
            this.CustAccNoLabel.Text = "Acc Number";
            // 
            // MilkTypeLabel
            // 
            this.MilkTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CustMobLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CustNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustNameTextBox.Font = new System.Drawing.Font("Shivaji01", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTextBox.Location = new System.Drawing.Point(199, 82);
            this.CustNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CustNameTextBox.Name = "CustNameTextBox";
            this.CustNameTextBox.Size = new System.Drawing.Size(425, 41);
            this.CustNameTextBox.TabIndex = 1;
            this.CustNameTextBox.Leave += new System.EventHandler(this.CustNameTextBox_Leave);
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // AddCustDataForm
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 597);
            this.Controls.Add(this.CustDataGroupBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddCustDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustDataForm";
            this.Load += new System.EventHandler(this.AddCustDataForm_Load);
            this.CustDataGroupBox.ResumeLayout(false);
            this.CustDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustIdErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustMilkTypeErrorProvider)).EndInit();
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
        private System.Windows.Forms.Button m_pCancelButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ErrorProvider CustNameErrorProvider;
        private System.Windows.Forms.ErrorProvider CustIdErrorProvider;
        private System.Windows.Forms.ErrorProvider CustMilkTypeErrorProvider;
        private System.Windows.Forms.Button m_pUpdateButton;
        private System.Windows.Forms.TextBox CustAccNoTextBox;
        private System.Windows.Forms.Label CustAccNoLabel;
        private System.Windows.Forms.Button m_pLoadXMLButton;
    }
}