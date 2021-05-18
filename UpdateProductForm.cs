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
using System.IO;

namespace Treasurer2
{
    public partial class UpdateProductForm : DevExpress.XtraEditors.XtraForm
    {
        MyDatabase db = new MyDatabase();
        PRODUCTS product = new PRODUCTS();
        //MyDatabase db = new MyDatabase();
        // ProductsOfTreasurer productsOfTreasurer = new ProductsOfTreasurer();

        #region UpdateProductForm
        public UpdateProductForm()
        {
            InitializeComponent();
            MySqlCommand command = new MySqlCommand("SELECT `product_type` FROM `usersdb`.`product_category`;", db.getConnection());
            MySqlCommand command1 = new MySqlCommand("SELECT `username` FROM `usersdb`.`users_of_treasurer`;");

            glueCategory.Properties.DataSource = db.getDataTable(command);
            glueOwner.Properties.DataSource = db.getDataTable(command1);
        }
        #endregion


        #region verif
        bool verif()
        {
            if ((textBoxProductName.Text.Trim() == "") ||
                (glueCategory.Text.Trim() == "") ||
                ((DateTime)dateEditManufactured.DateTime == null) ||
                ((DateTime)dateEditExpire.DateTime == null) ||
                (glueOwner.Text.Trim() == "") ||
                (pictureEdit.Image == null) ||
                (textEditQuantity.Text == "") ||
                (textEditPrice.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion


        #region simpleButtonUpdate_Click
        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textEditID.Text);
            string pName = textBoxProductName.Text;
            string pType = glueCategory.Text;
            DateTime mDate = dateEditManufactured.DateTime;
            DateTime eDate = dateEditExpire.DateTime;
            string owner = glueOwner.Text;

            MemoryStream image = new MemoryStream();


            int quantity = Convert.ToInt32(textEditQuantity.Text);
            int price = Convert.ToInt32(textEditPrice.Text);


            if (verif())
            {
                pictureEdit.Image.Save(image, pictureEdit.Image.RawFormat);

                if (product.updateProduct(id, pName, pType, mDate, eDate, owner, image, quantity, price))
                {
                    MessageBox.Show("Мэдээлэл засварлалт амжилттай боллоо.", "Засварлах", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Алдаа гарлаа", "Засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Мэдээлэл дутуу оруулсан байна.\nМэдээллээ шалгаад дахиг оруулна уу!", "Хоосон нүд", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion


        #region simpleButtonDelete_Click
        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textEditID.Text);

            if(MessageBox.Show("Та "+id+" бүртгэлийн дугаартай эд хөрөнгийг бүртгэлээс устгахдаа итгэлтэй байна уу?","Устгах", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                product.deleteProduct(id);
                textEditID.Text = "";
                glueCategory.Text = "";
                dateEditManufactured.DateTime = DateTime.Now;
                dateEditExpire.DateTime = DateTime.Now;
                glueOwner.Text = "";
                pictureEdit.Image = null;

                MessageBox.Show("Эд хөрөнгө бүртгэлээс устлаа", "Устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Эд хөрөнгө бүртгэлээс устсангүй", "Устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion


        #region simpleButtonCancel_Click
        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


        #region uploadPictureButton_Click
        private void uploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureEdit.Image = Image.FromFile(opf.FileName);
            }
        }
        #endregion


        #region simpleButtonSearchByID_Click
        private void simpleButtonSearchByID_Click(object sender, EventArgs e)
        {
            // id gaar ni product haih uildel
            int  id = Convert.ToInt32( textEditID.Text);

            DataTable table = product.getProductByID(id);
            if(table.Rows.Count > 0)
            {
                textBoxProductName.Text = table.Rows[0]["pname"].ToString();
                glueCategory.Text = table.Rows[0]["ptype"].ToString();

                dateEditManufactured.DateTime = (DateTime)table.Rows[0]["date_manufactured"];
                dateEditExpire.DateTime = (DateTime)table.Rows[0]["date_expire"];

                glueOwner.Text = table.Rows[0]["person_responsible_for"].ToString();

                byte[] img = (byte[])table.Rows[0]["image"];
                MemoryStream image = new MemoryStream(img);
                pictureEdit.Image = Image.FromStream(image);
            }
            else
            {
                MessageBox.Show("product_id: " + id + " дугаартай эд хөрөнгө олдсонгүй", "Илэрц олдсонгүй", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        #endregion

    }
}