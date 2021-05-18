using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treasurer2
{
    class ProductLog
    {

        MyDatabase db = new MyDatabase();


        #region insertProductLog
        public bool insertProductLog(int productID, DateTime logDate, string inOrOut, int quantity, string borrower)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`insert_product_log`(@pid, @ld, @io, @qt, @br);", db.getConnection());

            command.Parameters.Add("@pid", MySqlDbType.Int32).Value = productID;
            command.Parameters.Add("@ld", MySqlDbType.DateTime).Value = logDate;
            command.Parameters.Add("@io", MySqlDbType.VarChar).Value = inOrOut;
            command.Parameters.Add("@qt", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("@br", MySqlDbType.VarChar).Value = borrower;

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


        #region insertProductOwning
        public void insertProductOwning(int pID, string productName, int borrowQuantity, string username)
        {
            MySqlCommand commandAddOwning = new MySqlCommand("CALL `usersdb`.`insert_product_ownning`(@pid, @pn, @qt, @usn);", db.getConnection());
            commandAddOwning.Parameters.Add("@pid", MySqlDbType.Int32).Value = pID;
            commandAddOwning.Parameters.Add("@pn", MySqlDbType.VarChar).Value = productName;
            commandAddOwning.Parameters.Add("@qt", MySqlDbType.Int32).Value = borrowQuantity;
            commandAddOwning.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            db.openConnection();
            commandAddOwning.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion


        #region updateProductOwning
        public void updateProductOwning(int quantity, int oID)
        {
            MySqlCommand commandAddOwning = new MySqlCommand("CALL `usersdb`.`update_product_owning`(@qt, @oid);", db.getConnection());
            commandAddOwning.Parameters.Add("@qt", MySqlDbType.Int32).Value = quantity;
            commandAddOwning.Parameters.Add("@oid", MySqlDbType.VarChar).Value = oID;
            db.openConnection();
            commandAddOwning.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion


        #region deleteProductOwning
        public void deleteProductOwning(int oID)
        {
            MySqlCommand commandAddOwning = new MySqlCommand("CALL `usersdb`.`delete_product_owning`(@oid);", db.getConnection());
            commandAddOwning.Parameters.Add("@oid", MySqlDbType.Int32).Value = oID;
            db.openConnection();
            commandAddOwning.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion
    }
}
