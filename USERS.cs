using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Treasurer2
{
    class USERS
    {
        MyDatabase db = new MyDatabase();

        public DataTable getUserByUsername(string username)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`select_user_by_username`(@uname);", db.getConnection());
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            db.openConnection();
            return table;

        }
    }
}
