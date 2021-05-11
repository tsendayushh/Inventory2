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
        PRODUCTS product = new PRODUCTS();
        ProductsOfTreasurer productsOfTreasurer = new ProductsOfTreasurer();

        public UpdateProductForm()
        {

            InitializeComponent();
        }
        bool verif()
        {
            if ((textBoxProductName.Text.Trim() == "") ||
                (comboBoxProductCategory.Text.Trim() == "") ||
                ((DateTime)dateEditManufactured.DateTime == null) ||
                ((DateTime)dateEditExpire.DateTime == null) ||
                (comboBoxOwner.Text.Trim() == "") ||
                (pictureEdit.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textEditID.Text);
            string pName = textBoxProductName.Text;
            string pType = comboBoxProductCategory.Text;
            DateTime mDate = dateEditManufactured.DateTime;
            DateTime eDate = dateEditExpire.DateTime;
            string owner = comboBoxOwner.Text;

            MemoryStream image = new MemoryStream();



            if (verif())
            {
                pictureEdit.Image.Save(image, pictureEdit.Image.RawFormat);

                if (product.updateProduct(id, pName, pType, mDate, eDate, owner, image))
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

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textEditID.Text);

            if(MessageBox.Show("Та "+id+" бүртгэлийн дугаартай эд хөрөнгийг бүртгэлээс устгахдаа итгэлтэй байна уу?","Устгах", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                product.deleteProduct(id);
                textEditID.Text = "";
                comboBoxProductCategory.Text = "";
                dateEditManufactured.DateTime = DateTime.Now;
                dateEditExpire.DateTime = DateTime.Now;
                comboBoxOwner.Text = "";
                pictureEdit.Image = null;

                MessageBox.Show("Эд хөрөнгө бүртгэлээс устлаа", "Устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Эд хөрөнгө бүртгэлээс устсангүй", "Устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
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

        private void simpleButtonSearchByID_Click(object sender, EventArgs e)
        {
            // id gaar ni product haih uildel
            string id = textEditID.Text;

            DataTable table = product.getProductByID(id);
            if(table.Rows.Count > 0)
            {
                textBoxProductName.Text = table.Rows[0]["pname"].ToString();
                comboBoxProductCategory.Text = table.Rows[0]["ptype"].ToString();


                dateEditManufactured.DateTime = (DateTime)table.Rows[0]["date_manufactured"];
                dateEditExpire.DateTime = (DateTime)table.Rows[0]["date_expire"];

                comboBoxOwner.Text = table.Rows[0]["person_responsible_for"].ToString();

                byte[] img = (byte[])table.Rows[0]["image"];
                MemoryStream image = new MemoryStream(img);
                pictureEdit.Image = Image.FromStream(image);
            }
            else
            {
                MessageBox.Show("product_id: " + id + " дугаартай эд хөрөнгө олдсонгүй", "Илэрц олдсонгүй", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}