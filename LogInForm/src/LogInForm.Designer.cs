namespace LogInForm
{
    partial class LogInForm
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
            this.UserDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowPassCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.m_pRememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.UserDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDetailsGroupBox
            // 
            this.UserDetailsGroupBox.Controls.Add(this.m_pRememberMeCheckBox);
            this.UserDetailsGroupBox.Controls.Add(this.ShowPassCheckBox);
            this.UserDetailsGroupBox.Controls.Add(this.CloseButton);
            this.UserDetailsGroupBox.Controls.Add(this.LogInButton);
            this.UserDetailsGroupBox.Controls.Add(this.PasswordTextBox);
            this.UserDetailsGroupBox.Controls.Add(this.UserNameTextBox);
            this.UserDetailsGroupBox.Controls.Add(this.PasswordLabel);
            this.UserDetailsGroupBox.Controls.Add(this.UserNameLabel);
            this.UserDetailsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDetailsGroupBox.Location = new System.Drawing.Point(179, 71);
            this.UserDetailsGroupBox.Name = "UserDetailsGroupBox";
            this.UserDetailsGroupBox.Size = new System.Drawing.Size(256, 222);
            this.UserDetailsGroupBox.TabIndex = 0;
            this.UserDetailsGroupBox.TabStop = false;
            this.UserDetailsGroupBox.Text = "User Details";
            // 
            // ShowPassCheckBox
            // 
            this.ShowPassCheckBox.AutoSize = true;
            this.ShowPassCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassCheckBox.Location = new System.Drawing.Point(47, 111);
            this.ShowPassCheckBox.Name = "ShowPassCheckBox";
            this.ShowPassCheckBox.Size = new System.Drawing.Size(157, 29);
            this.ShowPassCheckBox.TabIndex = 6;
            this.ShowPassCheckBox.Text = "Show Password";
            this.ShowPassCheckBox.UseVisualStyleBackColor = true;
            this.ShowPassCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassCheckBox_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.Location = new System.Drawing.Point(131, 174);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 32);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.DarkGreen;
            this.LogInButton.Location = new System.Drawing.Point(37, 174);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(88, 32);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "&LogIn";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(110, 70);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 35);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(110, 27);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(100, 35);
            this.UserNameTextBox.TabIndex = 2;
            this.UserNameTextBox.Leave += new System.EventHandler(this.UserNameTextBox_Leave);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(11, 68);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(102, 29);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(7, 30);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(122, 29);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User Name";
            // 
            // UserNameErrorProvider
            // 
            this.UserNameErrorProvider.ContainerControl = this;
            // 
            // PasswordErrorProvider
            // 
            this.PasswordErrorProvider.ContainerControl = this;
            // 
            // m_pRememberMeCheckBox
            // 
            this.m_pRememberMeCheckBox.AutoSize = true;
            this.m_pRememberMeCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_pRememberMeCheckBox.Location = new System.Drawing.Point(47, 139);
            this.m_pRememberMeCheckBox.Name = "m_pRememberMeCheckBox";
            this.m_pRememberMeCheckBox.Size = new System.Drawing.Size(149, 29);
            this.m_pRememberMeCheckBox.TabIndex = 6;
            this.m_pRememberMeCheckBox.Text = "Remember me";
            this.m_pRememberMeCheckBox.UseVisualStyleBackColor = true;
            this.m_pRememberMeCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassCheckBox_CheckedChanged);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.LogInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogInForm.Properties.Resources.nature;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 326);
            this.Controls.Add(this.UserDetailsGroupBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.UserDetailsGroupBox.ResumeLayout(false);
            this.UserDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserDetailsGroupBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.CheckBox ShowPassCheckBox;
        private System.Windows.Forms.ErrorProvider UserNameErrorProvider;
        private System.Windows.Forms.ErrorProvider PasswordErrorProvider;
        private System.Windows.Forms.CheckBox m_pRememberMeCheckBox;
    }
}

