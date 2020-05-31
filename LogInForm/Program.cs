using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    static class Program
    {

        // Static Member Variable for Starting Form.
        public static LogInForm m_pLogInForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Main Function 
            m_pLogInForm = new LogInForm();
            //Application.Run(Program.m_pLogInForm);
            
            // Temp Function.
            Application.Run(new LPMainWindow());
        }
    }
}
