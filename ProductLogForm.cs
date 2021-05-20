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
using System.Threading;

namespace Treasurer2
{
    public partial class ProductLogForm : DevExpress.XtraEditors.XtraForm
    {

        MyDatabase db = new MyDatabase();
        PRODUCTS product = new PRODUCTS();
        ProductLog productLog = new ProductLog();
        ProductsOfTreasurer productsOfTreasurer = new ProductsOfTreasurer();


        public ProductLogForm()
        {
            InitializeComponent();
            refreshForm();
        }


        #region ProductLogForm_Load
        private void ProductLogForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersdbDataSet6.product_log' table. You can move, or remove it, as needed.
            this.product_logTableAdapter.Fill(this.usersdbDataSet6.product_log);
            // TODO: This line of code loads data into the 'usersdbDataSet5.product_owning' table. You can move, or remove it, as needed.
            this.product_owningTableAdapter.Fill(this.usersdbDataSet5.product_owning);
            refreshForm();
        }
        #endregion


        #region verif
        bool verif()
        {
            // text box uud bvren buglugdsuniig shalgah
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
                splashScreenManager1.ShowWaitForm();

                //odoo uildej baigaa uildel ni owning listed bga esehig shalgah parametrvvd
                int oid;
                int pid = Convert.ToInt32(glueProduct.EditValue);
                string username = glueBorrowerUsername.Text;
                string productName = glueProduct.Text;
                bool owningExist = false;

                MySqlCommand commandCheckOwningExist = new MySqlCommand("CALL `usersdb`.`search_product_owning`(@pid, @username);", db.getConnection());
                commandCheckOwningExist.Parameters.Add("@pid", MySqlDbType.Int32).Value = pid;
                commandCheckOwningExist.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandCheckOwningExist);
                DataTable tableOwning = new DataTable();

                adapter.Fill(tableOwning);

                if (tableOwning.Rows.Count > 0)
                {
                    owningExist = true;
                }


                //Storaged baigaa toog awch hvreh esehiig shalgahiin tuluuh parameter
                int storageQuantity;
                int owningQuantity;
                int borrowQuantity = Convert.ToInt32(textBoxQuantity.Text);

                DataTable tableProduct = product.getProductByID(pid);
                storageQuantity = Convert.ToInt32(tableProduct.Rows[0]["stock_quantity"].ToString());

                // OUT bh ued storage quantityg borrow oos ih esehiig shalgah
                // IN bh ved owning quantity ni butsaah quantity ees ih esehiig shalgah
                //-------------------OUT---- storage oos awah ueiin uildel---------------------
                if (comboboxInOrOut.SelectedIndex == 0)
                {

                    if (borrowQuantity <= storageQuantity)
                    {
                        if(owningExist)
                        {
                            owningQuantity = Convert.ToInt32(tableOwning.Rows[0]["quantity"].ToString());
                            oid = Convert.ToInt32(tableOwning.Rows[0]["owning_id"].ToString());
                            //owning listed bgaa ued update hiih 
                            owningQuantity = owningQuantity + borrowQuantity;
                            oid = Convert.ToInt32(tableOwning.Rows[0]["owning_id"].ToString());
                            productLog.updateProductOwning(owningQuantity, oid);
                        }
                        else
                        {
                            //end owning listed bhgv tul shineeer bvrtgene
                            productLog.insertProductOwning(pid, productName, borrowQuantity, username);

                        }
                        storageQuantity = storageQuantity - borrowQuantity;
                        product.updateProductQuantity(storageQuantity, pid);
                        splashScreenManager1.CloseWaitForm();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Нөөцөнд байгаа тоо хүрэлцэхгүй байна.", "Нөөцийн дутагдал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        splashScreenManager1.CloseWaitForm();
                        return false;
                    }
                }
                //-------------------IN---storaged butsaah ueiin uildel---------------------
                else
                {
                    //owning listed bgaa ued update hiih 
                    if (owningExist)
                    {

                        owningQuantity = Convert.ToInt32(tableOwning.Rows[0]["quantity"].ToString());
                        oid = Convert.ToInt32(tableOwning.Rows[0]["owning_id"].ToString());
                        if (borrowQuantity < owningQuantity)
                        {
                            // awsan bvh item aa butsaahgvi hesgiig ni butsaah ued owning list table  bolon product table iin quantity-d edit oruulna
                            owningQuantity = owningQuantity - borrowQuantity;
                            productLog.updateProductOwning(owningQuantity, oid);

                            //product table iin storage quantityg uurchluh
                            storageQuantity = storageQuantity + borrowQuantity;
                            product.updateProductQuantity(storageQuantity, pid);



                            splashScreenManager1.CloseWaitForm();
                            return true;
                        }
                        else if(borrowQuantity == owningQuantity)
                        {
                            //bvgdeng ni butsaah ved owning list ees ustgah
                            productLog.deleteProductOwning(oid);

                            //product table iin storage quantityg uurchluh
                            storageQuantity = storageQuantity + borrowQuantity;
                            product.updateProductQuantity(storageQuantity, pid);

                            splashScreenManager1.CloseWaitForm();
                            return true;
                        }
                        else
                        {
                            //uurt baigaagaas ilvvg butsah gwl aldaa zaadg bh
                            MessageBox.Show("Таны оруулсан тоо хэмжээгээр буцаахад хэрэглэгчийн үзүэмшиж буй хэмжээ хүрэлцэхгүй байна.", "Буцаах", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            splashScreenManager1.CloseWaitForm();
                            return false;
                        }
                    }
                    //owning listed bhgv ued
                    else
                    {
                        MessageBox.Show("Таны оруулсан буцаалтын мэдээлэл гарсан бүртгэл хийгдээгүй байна. Та хэрэглэгчийн нэр болон бүтээгдэхүүний нэр ээ шалгаад дахин оролдно уу", "Буцаах", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        splashScreenManager1.CloseWaitForm();
                        return false;
                    }
                }
            }
        }
        #endregion


        #region buttonAddLog
        private void buttonAddLog_Click(object sender, EventArgs e)
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

                db.openConnection();

                if (productLog.insertProductLog(productID, logDate, inOrOut, quantity, borrower))
                {
                    if (comboboxInOrOut.SelectedIndex == 0)
                    {
                        MessageBox.Show("Зээлийн бүртгэл амжилттай боллоо.", "Зээлэх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                refreshForm();
                MySqlCommand commandRefreshProductTable = new MySqlCommand("SELECT * FROM usersdb.product;", db.getConnection());
                productsOfTreasurer.refreshGridview(commandRefreshProductTable);
            }
            

        }
        #endregion


        public void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshForm();
        }


        private void barButtonItemSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        #region barButtonItemAddproductLog
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(splitContainerControl1.PanelVisibility == SplitPanelVisibility.Both)
            {
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            }
            else
            {
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
            }
        }
        #endregion



        #region refreshForm
        public void refreshForm()
        {
            refreshGrid();

            MySqlCommand command1 = new MySqlCommand("SELECT `product`.`product_id`,`product`.`pname`,`product`.`ptype`,`product`.`person_responsible_for`,`product`.`image`,`product`.`stock_quantity` FROM `usersdb`.`product`;", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT `users_of_treasurer`.`user_id`,`users_of_treasurer`.`firstname`,`users_of_treasurer`.`lastname`,`users_of_treasurer`.`username` FROM `usersdb`.`users_of_treasurer`; ", db.getConnection());

            glueProduct.Properties.DataSource = db.getDataTable(command1);
            glueBorrowerUsername.Properties.DataSource = db.getDataTable(command2);
        }
        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            string searchInput = textEditSearch.Text;
            MySqlCommand commandSearch = new MySqlCommand("CALL `usersdb`.`search_product_owning_by_username`('%"+searchInput+"%')", db.getConnection());
            gridControlOwning.DataSource = db.getDataTable(commandSearch);
        }

        private void simpleButtonClearOwning_Click(object sender, EventArgs e)
        {
            textEditSearch.Text = "";
            refreshGrid();
        }

        public void refreshGrid()
        {
            MySqlCommand commandProductLog = new MySqlCommand("SELECT * FROM usersdb.product_log;", db.getConnection());
            DataTable tableProductLog = db.getDataTable(commandProductLog);
            MySqlCommand commandProductOwning = new MySqlCommand("SELECT * FROM usersdb.product_owning;", db.getConnection());
            DataTable tableProductOwning = db.getDataTable(commandProductOwning);

            gridControlLog.DataSource = tableProductLog;
            gridControlOwning.DataSource = tableProductOwning;
        }
    }
}