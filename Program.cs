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
<<<<<<< HEAD
            Application.Run(new MainForm());
=======
            MainForm mainForm = new MainForm();
            LoginForm loginForm = new LoginForm();

            
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                loginForm.Close();
                mainForm.accUser.Text = loginForm.sendUsername();
                Application.Run(mainForm);
            }
            

>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
        }
    }
}
