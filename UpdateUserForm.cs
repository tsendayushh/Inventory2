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
    public partial class UpdateUserForm : DevExpress.XtraEditors.XtraForm
    {
        USERS uSERS = new USERS();
        MyDatabase db = new MyDatabase();

        #region UpdateUserForm
        public UpdateUserForm()
        {
            InitializeComponent();
            
            MySqlCommand command = new MySqlCommand("SELECT `username` FROM `usersdb`.`users_of_treasurer`;", db.getConnection());

            glueUsername.Properties.DataSource = db.getDataTable(command);
        }
        #endregion


        #region glueUsername_EditValueChanged
        private void glueUsername_EditValueChanged(object sender, EventArgs e)
        {
            string username = glueUsername.Text;
            updateUserFormDataSet(username);            
        }
        #endregion


        #region updateUserFormDataSet
        public void updateUserFormDataSet(string username)
        {
            MySqlCommand command = new MySqlCommand("CALL `usersdb`.`select_user_by_username`(@uname);", db.getConnection());
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
            DataTable table = db.getDataTable(command);
            textBoxID.Text = table.Rows[0]["user_id"].ToString();
            textBoxFirstname.Text = table.Rows[0]["firstname"].ToString();
            textBoxLastname.Text = table.Rows[0]["lastname"].ToString();
            textBoxEmail.Text = table.Rows[0]["email"].ToString();

            byte[] img = (byte[])table.Rows[0]["picture"];
            MemoryStream image = new MemoryStream(img);
            pictureEdit.Image = Image.FromStream(image);

            if(table.Rows[0]["sex"].ToString() == "M")
            {
                radioGroup1.SelectedIndex = 0;
            }
            else if(table.Rows[0]["sex"].ToString() == "F")
            {
                radioGroup1.SelectedIndex = 1;
            }
            else
            {
                radioGroup1.SelectedIndex = 2;
            }
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

        #region verif
        bool verif()
        {
            if ((textBoxID.Text == "") ||
            (textBoxFirstname.Text == "") ||
            (textBoxLastname.Text == "") ||
            (textBoxEmail.Text == "") ||
            (glueUsername.Text == "") ||
            (pictureEdit.Image == null))
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
            if (verif())
            {
                int ID = Convert.ToInt32(textBoxID.Text);
                string fname = textBoxFirstname.Text;
                string lname = textBoxLastname.Text;
                int sexIndex = radioGroup1.SelectedIndex;
                string sex = getSex(sexIndex);
                string email = textBoxEmail.Text;
                string uname = glueUsername.Text;
                MemoryStream image = new MemoryStream();
                pictureEdit.Image.Save(image, pictureEdit.Image.RawFormat);

                if (uSERS.updateUser(ID,fname, lname, email, uname, image, sex))
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
            if(verif())
            {
                int ID = Convert.ToInt32(textBoxID.Text);
                string username = glueUsername.Text;

                if (MessageBox.Show("Та " + username + " хэрэглэгчийг бүртгэлээс устгахдаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    uSERS.deleteUser(ID);
                    glueUsername.Text = "";
                    textBoxFirstname.Text = "";
                    textBoxLastname.Text = "";
                    textBoxEmail.Text = "";
                    pictureEdit.Image = null;

                    MessageBox.Show("Эд хөрөнгө бүртгэлээс устлаа", "Устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Эд хөрөнгө бүртгэлээс устсангүй", "Устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        #endregion


        #region simpleButtonCancel_Click
        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


        #region getSex
        public string getSex(int sexIndex)
        {
            string sex = "";
            if (sexIndex == 0) sex = "M";
            else if (sexIndex == 1) sex = "F";
            else sex = "O";
            return sex;
        }
        #endregion
    }
}