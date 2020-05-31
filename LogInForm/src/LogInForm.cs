using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

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
            if (UserNameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                SqlConnection sqlCon = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
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
    }
}
