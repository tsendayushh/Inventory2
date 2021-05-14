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
    class PRODUCTS
    {
        MyDatabase db = new MyDatabase();


        #region addProduct
        public bool addProduct(string pName, string pType, DateTime mDate, DateTime eDate, string owner, MemoryStream image)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`insert_product`(@pn, @pt, @dm, @de, @prf, @img);", db.getConnection());

            //@pn, @pt, @dm, @de, @prf, @img
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pName;
            command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = pType;
            command.Parameters.Add("@dm", MySqlDbType.Date).Value = mDate;
            command.Parameters.Add("@de", MySqlDbType.Date).Value = eDate;
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
        #endregion


        #region updateProduct
        public bool updateProduct(int ID ,string pName, string pType, DateTime mDate, DateTime eDate, string owner, MemoryStream image)
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
        #endregion


        #region deleteProduct
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
        #endregion


        #region getProductByID
        public DataTable getProductByID(string pid)
        {
            int ID = Convert.ToInt32(pid);
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`select_product_by_id`(" + ID + ")", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            db.closeConnection();
            return table;
            
        }
        #endregion
    }
}
