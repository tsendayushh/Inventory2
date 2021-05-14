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

        #region addUser
        public bool addUser(string firstname, string lastname, string email, string username, string password, MemoryStream image, string sex)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`insert_user`(@fname, @lname, @email, @uname, @pass, @pic, @sex);", db.getConnection());

            //@pn, @pt, @dm, @de, @prf, @img
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = image.ToArray();
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;

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
        #endregion


        #region usernameCheck
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
        #endregion


        #region updateUser
        public bool updateUser(int ID, string firstname, string lastname, string email, string username, MemoryStream image, string sex)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("CALL `usersdb`.`update_user`(@ID, @fname, @lname, @email, @uname, @pic, @sex); ", db.getConnection());

                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = ID;
                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstname;
                command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastname;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = image.ToArray();
                command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;

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
        #endregion


        #region deleteUser
        public bool deleteUser(int ID)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`delete_user`(@ID);", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = ID;

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
        #endregion

    }
}
