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
        public bool addProduct(string pName, string pType, DateTime mDate, DateTime eDate, string owner, MemoryStream image, int quantity, int price)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`insert_product`(@pn, @pt, @dm, @de, @prf, @img, @qt, @pr);", db.getConnection());

            //@pn, @pt, @dm, @de, @prf, @img
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pName;
            command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = pType;
            command.Parameters.Add("@dm", MySqlDbType.Date).Value = mDate;
            command.Parameters.Add("@de", MySqlDbType.Date).Value = eDate;
            command.Parameters.Add("@prf", MySqlDbType.VarChar).Value = owner;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = image.ToArray();
            command.Parameters.Add("@qt", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("@pr", MySqlDbType.Int32).Value = price;

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
        public bool updateProduct(int ID ,string pName, string pType, DateTime mDate, DateTime eDate, string owner, MemoryStream image, int quantity, int price)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("CALL `usersdb`.`update_product`(@ID,@pn, @pt, @dm, @de, @prf, @img, @qt, @pr);", db.getConnection());

                //@ID,@pn, @pt, @dm, @de, @prf, @img
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;
                command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pName;
                command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = pType;
                command.Parameters.Add("@dm", MySqlDbType.Timestamp).Value = mDate;
                command.Parameters.Add("@de", MySqlDbType.Timestamp).Value = eDate;
                command.Parameters.Add("@prf", MySqlDbType.VarChar).Value = owner;
                command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = image.ToArray();
                command.Parameters.Add("@qt", MySqlDbType.Int32).Value = quantity;
                command.Parameters.Add("@pr", MySqlDbType.Int32).Value = price;

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
        public DataTable getProductByID(int pid)
        {
            int ID = Convert.ToInt32(pid);
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`select_product_by_id`(@pid)", db.getConnection());
            command.Parameters.Add("@pid", MySqlDbType.Int32).Value = pid;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            db.closeConnection();
            return table;
            
        }
        #endregion


        #region updateProductQuantity
        public void updateProductQuantity(int storageQuantity, int pid)
        {
            MySqlCommand commandUpdatePTable = new MySqlCommand("UPDATE `usersdb`.`product` SET `stock_quantity` = @sqt WHERE product_id = @ID; ", db.getConnection());
            commandUpdatePTable.Parameters.Add("@sqt", MySqlDbType.Int32).Value = storageQuantity;
            commandUpdatePTable.Parameters.Add("@ID", MySqlDbType.Int32).Value = pid;
            db.openConnection();
            commandUpdatePTable.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion
    }
}
