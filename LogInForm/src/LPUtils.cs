using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace LogInForm
{
    class LPUtils
    {
        public static int AllowNumbersInTextBox(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
            return 0;
        }
        public static int AllowDecimalValuesInTextBox(object sender, KeyPressEventArgs e)
        {
            TextBox txtDecimal = sender as TextBox;

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
            if(e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }

            return 0;
        }

        public static int AutoCompleteTextBox(TextBox textBox, AutoCompleteStringCollection autoCompleteStringList)
        {
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteCustomSource = autoCompleteStringList;

            return 0;
        }
    }
}
