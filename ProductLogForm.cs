using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Treasurer2
{
    public partial class ProductLogForm : DevExpress.XtraEditors.XtraForm
    {
        MyDatabase db = new MyDatabase();
        PRODUCTS product = new PRODUCTS();
        public ProductLogForm()
        {
            InitializeComponent();
            MySqlCommand command = new MySqlCommand("SELECT `product`.`product_id`,`product`.`pname`,`product`.`ptype`,`product`.`person_responsible_for`,`product`.`image`,`product`.`stock_quantity`,`product`.`quantity`FROM `usersdb`.`product`;", db.getConnection());
            MySqlCommand command1 = new MySqlCommand("SELECT `users_of_treasurer`.`user_id`,`users_of_treasurer`.`firstname`,`users_of_treasurer`.`lastname`,`users_of_treasurer`.`username` FROM `usersdb`.`users_of_treasurer`; ", db.getConnection());

            glueProduct.Properties.DataSource = db.getDataTable(command);
            glueBorrowerUsername.Properties.DataSource = db.getDataTable(command1);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void ProductLogForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersdbDataSet2.product_log' table. You can move, or remove it, as needed.
            //this.product_logTableAdapter.Fill(this.usersdbDataSet2.product_log);
            MySqlCommand command = new MySqlCommand("SELECT * FROM usersdb.product_log;", db.getConnection());
            gridControl1.DataSource = db.getDataTable(command);

        }


        #region verif
        bool verif()
        {
            if ((glueProduct.Text == "") ||
                (string.IsNullOrEmpty(dateEditLog.SelectedText)) ||
                (comboboxInOrOut.Text == "") ||
                (textBoxQuantity.Text == "") ||
                (glueBorrowerUsername.Text == ""))
            {
                MessageBox.Show("Мэдээллээ дахин шалгаад бүрэн мэдээлэл оруулна уу", "Мэдээлэл дутуу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                int stockQuantity;
                int borrowQuantity = Convert.ToInt32(textBoxQuantity.Text);
                int pid = Convert.ToInt32(glueProduct.EditValue);

                // in or out iin switch
                if (comboboxInOrOut.SelectedIndex == 1)
                {
                    borrowQuantity = -borrowQuantity;                    
                }

                MySqlCommand command = new MySqlCommand("SELECT `stock_quantity` FROM `usersdb`.`product` WHERE `product_id`=@ID;", db.getConnection());
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = pid;

                DataTable table1 = db.getDataTable(command);
                stockQuantity = Convert.ToInt32(table1.Rows[0]["stock_quantity"].ToString());

                if (borrowQuantity <= stockQuantity)
                {
                    MySqlCommand command1 = new MySqlCommand("UPDATE `usersdb`.`product` SET `stock_quantity` = @sqt WHERE product_id = @ID; ", db.getConnection());
                    command1.Parameters.Add("@sqt", MySqlDbType.Int32).Value = stockQuantity - borrowQuantity;
                    command1.Parameters.Add("@ID", MySqlDbType.Int32).Value = pid;
                    db.openConnection();
                    command1.ExecuteNonQuery();
                    db.closeConnection();
                    return true;
                }
                else
                {
                    MessageBox.Show("Нөөцөнд байгаа тоо хүрэлцэхгүй байна.", "Нөөцийн дутагдал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }
        #endregion



        private void buttonAddLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    int productID = Convert.ToInt32(glueProduct.EditValue);
                    DateTime logDate = (DateTime)dateEditLog.DateTime;
                    string inOrOut = "OUT";
                    if (comboboxInOrOut.SelectedIndex == 1)
                        inOrOut = "IN";
                    int quantity = Convert.ToInt32(textBoxQuantity.Text);
                    string borrower = glueBorrowerUsername.Text;

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
                        if(comboboxInOrOut.SelectedIndex == 0)
                            MessageBox.Show("Зээлийн бүртгэл амжилттай боллоо.", "Зээлэх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        else
                        {
                            MessageBox.Show("Буцаалт амжилттай боллоо.", "Буцаах", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    else
                    {
                        db.closeConnection();
                        MessageBox.Show("Error", "Зээлэх/Буцаах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                refreshGridview();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshGridview();
        }

        public void refreshGridview()
        {
            barEditSearchText.EditValue = "";
            MySqlCommand command = new MySqlCommand("SELECT * FROM usersdb.product_log;", db.getConnection());
            DataTable table = db.getDataTable(command);

            gridControl1.DataSource = table;

        }
    }
}