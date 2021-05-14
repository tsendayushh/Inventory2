using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treasurer2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            LoginForm loginForm = new LoginForm();

            
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                loginForm.Close();
                mainForm.accUser.Text = loginForm.sendUsername();
                Application.Run(mainForm);
            }
            

        }
    }
}
