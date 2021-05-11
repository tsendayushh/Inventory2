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
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

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

        private void comboBoxProductCategory_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBoxOwner_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            try
            {
                comboBoxOwner.DataBindings.Clear();
                MyDatabase db = new MyDatabase();
                db.openConnection();

                string query = "SELECT * FROM `usersdb`.`users_of_treasurer`;";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                //DataTable table = usersoftreasurer.getPerson(command);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //comboBoxOwner.EditValue.
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            */
        }
        bool verif()
        {
            if ((textBoxProductName.Text.Trim() == "") ||
                (comboBoxProductCategory.SelectedItem == null) ||
                (string.IsNullOrEmpty(dateEditManufactured.SelectedText)) ||
                (string.IsNullOrEmpty(dateEditExpire.SelectedText)) ||
                (comboBoxOwner.SelectedItem == null) ||
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
            PRODUCTS product = new PRODUCTS();

            if (verif())
            {
                string pName = textBoxProductName.Text;

                string pType = comboBoxProductCategory.SelectedItem.ToString();

                DateTime mDate = (DateTime)dateEditManufactured.DateTime;
                DateTime eDate = (DateTime)dateEditExpire.DateTime;


                //string owner = textBoxPeopleResp.Text;//ene ni textbox oos awdag bsn ued

                string owner = comboBoxOwner.Text;//ene ni combobox oos awah ued

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