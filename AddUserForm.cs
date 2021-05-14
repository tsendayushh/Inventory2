using DevExpress.XtraEditors;
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
    public partial class AddUserForm : DevExpress.XtraEditors.XtraForm
    {
        public AddUserForm()
        {
            InitializeComponent();
        }


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
            if ((textBoxFirstname.Text.Trim() == "") ||
                (textBoxLastname.Text.Trim() == "") ||
                (textBoxEmail.Text.Trim() == "") ||
                (textBoxUsername.Text.Trim() == "") ||
                (textBoxPassword.Text.Trim() == "") ||
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


        #region simpleButtonAdd_Click
        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            USERS uSERS = new USERS();

            if (verif())
            {
                string firstname = textBoxFirstname.Text;
                string lastname = textBoxLastname.Text;
                string sex = getSex();
                string email = textBoxEmail.Text;
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                MemoryStream image = new MemoryStream();
                pictureEdit.Image.Save(image, pictureEdit.Image.RawFormat);

                if (uSERS.usernameCheck(username) == true )
                {
                    if (uSERS.addUser(firstname, lastname, email, username, password, image, sex))
                    {
                        MessageBox.Show("Хэрэглэгчийн бүртгэл амжилттай боллоо.", "Бүртгэл", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Алдаа гарлаа", "Бүртгэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Хэрэглэгчийн нэр бүртгэлтэй байгаа тул хэрэглэгчийн нэрээ солиод дахин оролдно уу!", "Бүртгэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                MessageBox.Show("Мэдээлэл дутуу оруулсан байна.\nМэдээллээ шалгаад дахиг оруулна уу!", "Мэдээлэл дутуу байна", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public string getSex()
        {
            int sexIndex = radioGroup1.SelectedIndex;
            string sex = "";
            if (sexIndex == 0) sex = "M";
            else if (sexIndex == 1) sex = "F";
            else sex = "O";
            return sex;
        }
        #endregion
    }
}