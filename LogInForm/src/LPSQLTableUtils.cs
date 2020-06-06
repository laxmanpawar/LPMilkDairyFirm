using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace LogInForm
{
    class LPSQLTableUtils
    {
        public static string m_sSqlConnectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public static int IsTableExists(string tableName)
        {
            SqlConnection sqlCon = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
            int isExists = 0;
            try
            {
                string isTablePresentQuery = "SELECT CASE WHEN OBJECT_ID('" + tableName + "', 'U') IS NOT NULL THEN 1 ELSE 0 END";
                SqlCommand isTableExistsCmd = new SqlCommand(isTablePresentQuery, sqlCon);
                sqlCon.Open();
                isExists = (int)isTableExistsCmd.ExecuteScalar();
                sqlCon.Close();
            }
            catch (Exception exc)
            {
                sqlCon.Close();
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return isExists;
        }

        public static int IsColumnPresent(string tableName, string columnName, string columnValue)
        {
            SqlConnection con = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
            string query = "SELECT * FROM " + tableName + " WHERE [" + columnName + "] = " + columnValue;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                con.Close();
                return 1;
            }
            con.Close();
            return 0;
        }

        public static int DeleteSQLTableFromDB(string tableName)
        {
            SqlConnection sqlCon = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);
            try
            {
                if (LPSQLTableUtils.IsTableExists(tableName) == 1)
                {
                    string query = "DROP TABLE " + tableName;
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    sqlCon.Open();
                    object isSuccess = cmd.ExecuteScalar();
                    sqlCon.Close();
                }
            }
            catch (Exception exc)
            {
                sqlCon.Close();
                MessageBox.Show("LPError : " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            return 0;
        }
        public static int CreateSQLTableInDB(string tableName, List<string> columnNames, List<string> columnTypes)
        {
            try
            {
                if (columnNames.Count == columnTypes.Count)
                {
                    SqlConnection sqlCon = new SqlConnection(LPSQLTableUtils.m_sSqlConnectionString);

                    StringBuilder query = new StringBuilder();
                    query.Append("CREATE TABLE ");
                    query.Append(tableName);
                    query.Append(" ( ");

                    for (int i = 0; i < columnNames.Count; ++i)
                    {
                        query.Append("[" + columnNames[i] + "]");
                        query.Append(" ");
                        query.Append(columnTypes[i]);
                        query.Append(", ");
                    }

                    if (columnNames.Count > 1) { query.Length -= 2; }  //Remove trailing ", "
                    query.Append(");");
                    SqlCommand cmd = new SqlCommand(query.ToString(), sqlCon);

                    sqlCon.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    sqlCon.Close();
                }
                else
                {
                    MessageBox.Show("LPWarning : Column names and column types count is not matching.", "LPWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("LPError: " + exc.Message, "LPError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            return 0;
        }

    }
}
