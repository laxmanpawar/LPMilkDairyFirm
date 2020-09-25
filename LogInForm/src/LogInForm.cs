/*
 Author : Laxman P.
 
 
 */

using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using LogInForm.Utils;

namespace LogInForm
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserNameTextBox.Text != "" && PasswordTextBox.Text != "")
                {
                    SqlConnection sqlCon = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
                    // Check if dataBase is exists or not 
                    bool isDataBaseExists = LPSQLTableUtils.CheckDatabaseExists(LPSQLTableUtils.m_sDataBaseName);

                    if(!isDataBaseExists)
                    {
                        int res = LPSQLTableUtils.CreateDataBase(LPSQLTableUtils.m_sDataBaseName);
                        if (res <= 0) return;
                    }

                    string query = "Select * from LOGIN_TABLE where username = @user and pass = @pass";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@user", UserNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@pass", PasswordTextBox.Text);

                    // Open SqlConnection
                    sqlCon.Open();

                    // Execute sql command
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        SaveCredentials();
                        this.Hide();
                        LPMainWindow mainWindow = new LPMainWindow();
                        mainWindow.ShowDialog();
                    }
                    else
                    {
                        this.UserNameTextBox.Focus();
                        MessageBox.Show("ERROR : LogIn failed !!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    sqlCon.Close();

                    this.UserNameTextBox.Clear();
                    this.PasswordTextBox.Clear();
                    this.UserNameTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("INFO : Please fill both the fields.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.UserNameTextBox.Focus();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.UserNameTextBox.Clear();
            this.PasswordTextBox.Clear();

            Application.Exit();
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPassCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void UserNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameTextBox.Text))
            {
                UserNameTextBox.Focus();
                UserNameErrorProvider.SetError(this.UserNameTextBox, "Please specify User Name.");
            }
            else UserNameErrorProvider.Clear();
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                PasswordTextBox.Focus();
                PasswordErrorProvider.SetError(this.PasswordTextBox, "Please specify Password.");
            }
            else PasswordErrorProvider.Clear();
        }

        private int SaveCredentials()
        {
            if (m_pRememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.UserName = UserNameTextBox.Text;
                Properties.Settings.Default.Password = PasswordTextBox.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            return 0;
        }

        private int LoadCredentials()
        {
            if(!string.IsNullOrEmpty(Properties.Settings.Default.UserName) && !string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                UserNameTextBox.Text = Properties.Settings.Default.UserName;
                PasswordTextBox.Text = Properties.Settings.Default.Password;
                this.m_pRememberMeCheckBox.Checked = true;
            }
            return 0;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            LoadCredentials();
        }
    }
}
