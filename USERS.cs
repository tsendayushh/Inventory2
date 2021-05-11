using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        public bool addUser(string firstname, string lastname, string email, string username, string password, MemoryStream image)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`insert_user`(@fname, @lname, @email, @uname, @pass, @pic);", db.getConnection());

            //@pn, @pt, @dm, @de, @prf, @img
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = image.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() != 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool usernameCheck(string username)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`select_user_by_username`(@uname);", db.getConnection());
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count == 0)
            {
                db.closeConnection();
                return true;
            }
            {
                db.closeConnection();
                return false;
            }
        }

        public bool updateProduct(int ID, string pName, string pType, DateTime mDate, DateTime eDate, string owner, MemoryStream image)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("CALL `usersdb`.`update_product`(@ID,@pn, @pt, @dm, @de, @prf, @img);", db.getConnection());

                //@ID,@pn, @pt, @dm, @de, @prf, @img
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;
                command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pName;
                command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = pType;
                command.Parameters.Add("@dm", MySqlDbType.Timestamp).Value = mDate;
                command.Parameters.Add("@de", MySqlDbType.Timestamp).Value = eDate;
                command.Parameters.Add("@prf", MySqlDbType.VarChar).Value = owner;
                command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = image.ToArray();

                db.openConnection();

                if (command.ExecuteNonQuery() != 0)
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool deleteProduct(int id)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`delete_product`(@ID);;", db.getConnection());

            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() != 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

    }
}
