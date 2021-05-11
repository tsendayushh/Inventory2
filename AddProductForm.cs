using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treasurer2
{
    public partial class AddProductForm : DevExpress.XtraEditors.XtraForm
    {
        MyDatabase db = new MyDatabase();
        PRODUCTS product = new PRODUCTS();

        public AddProductForm()
        {
            InitializeComponent();        
        }
                
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT `product_type` FROM `usersdb`.`product_category`;", db.getConnection());
            db.closeConnection();
            MySqlCommand command1 = new MySqlCommand("SELECT `username` FROM `usersdb`.`users_of_treasurer`;", db.getConnection());
            db.closeConnection();

            glueCategory.Properties.DataSource = product.getDataTable(command);
            glueOwner.Properties.DataSource = product.getDataTable(command1);
        }


        private void uploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureEdit.Image = Image.FromFile(opf.FileName);
            }
        }

        bool verif()
        {
            if ((textBoxProductName.Text.Trim() == "") ||
                (glueCategory.Text == "") ||
                (string.IsNullOrEmpty(dateEditManufactured.SelectedText)) ||
                (string.IsNullOrEmpty(dateEditExpire.SelectedText)) ||
                (glueOwner.Text == "") ||
                (pictureEdit.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                string pName = textBoxProductName.Text;
                string pType = glueCategory.Text;
                DateTime mDate = (DateTime)dateEditManufactured.DateTime;
                DateTime eDate = (DateTime)dateEditExpire.DateTime;
                string owner = glueOwner.Text;
                MemoryStream image = new MemoryStream();

                pictureEdit.Image.Save(image, pictureEdit.Image.RawFormat);

                if (product.addProduct(pName, pType, mDate, eDate, owner, image))
                {
                    MessageBox.Show("Эд хөрөнгийн бүртгэл амжилттай боллоо.", "Амжилттай", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("something went wrong dude", "Алдаа гарлаа!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Мэдээлэл дутуу оруулсан байна.\nМэдээллээ шалгаад дахиг оруулна уу!", "Мэдээлэл дутуу байна", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}            