using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treasurer2
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDatabase db = new MyDatabase();

            
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users_of_treasurer` WHERE `username` = @usn and `password` = SHA1(@pass)", db.getConnection());
            db.closeConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //hiisen user baigaa esehiig shalgaj bn
            if (table.Rows.Count > 0)
            {
                //herew username iin ilerts 0 oos ih bwl oruulsn user exist bn
                //MessageBox.Show("Yes your account is existing bro");
                //end login amjilttai bolsn tul Main_Form iig ajillulna
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Your account does't exist or wrong password");

            }
        }
    }
    
}