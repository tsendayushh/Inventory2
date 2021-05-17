using System;
using System.Linq;
using System.Windows.Forms;

namespace Treasurer2
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();

        }
        #region aceProducts_Click
        private void aceProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (!containerMainform.Controls.Contains(ProductsOfTreasurer.Instance))
                {
                    containerMainform.Controls.Add(ProductsOfTreasurer.Instance);
                    ProductsOfTreasurer.Instance.Dock = DockStyle.Fill;
                    ProductsOfTreasurer.Instance.BringToFront();
                }
                ProductsOfTreasurer.Instance.BringToFront();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region aceUsers_Click
        private void aceUsers_Click(object sender, EventArgs e)
        {
            if (!containerMainform.Controls.Contains(UsersOfTreasurer.Instance))
            {
                containerMainform.Controls.Add(UsersOfTreasurer.Instance);
                UsersOfTreasurer.Instance.Dock = DockStyle.Fill;
                UsersOfTreasurer.Instance.BringToFront();
            }
            UsersOfTreasurer.Instance.BringToFront();
        }
        #endregion


        #region accAddProduct_Click
        private void accAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addPForm = new AddProductForm();
            addPForm.Show(this);
        }
        #endregion


        #region accEditProduct_Click
        private void accEditProduct_Click(object sender, EventArgs e)
        {
            UpdateProductForm updatePForm = new UpdateProductForm();
            updatePForm.Show(this);
        }
        #endregion


        #region accAddUser_Click
        private void accAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUForm = new AddUserForm();
            addUForm.Show(this);
        }
        #endregion


        #region accEditUser_Click
        private void accEditUser_Click(object sender, EventArgs e)
        {
            UsersOfTreasurer usersOfTreasurer = new UsersOfTreasurer();
            usersOfTreasurer.updateUserFormDataSet();
        }
        #endregion


        #region accExit_Click
        private void accExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Та гарахдаа итгэлтэй байна уу?", "Гарах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion


        #region accThemesAndSkins_Click
        private void accThemesAndSkins_Click(object sender, EventArgs e)
        {
            try
            {
                if (!containerMainform.Controls.Contains(ThemeAndSkin.Instance))
                {
                    containerMainform.Controls.Add(ThemeAndSkin.Instance);
                    ThemeAndSkin.Instance.Dock = DockStyle.Fill;
                    ThemeAndSkin.Instance.BringToFront();
                }
                ThemeAndSkin.Instance.BringToFront();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void accPrintProduct_Click(object sender, EventArgs e)
        {
            PrintProductForm printProductForm = new PrintProductForm();
            printProductForm.Show(this);
        }

        private void accProductLog_Click(object sender, EventArgs e)
        {
            ProductLogForm productLForm = new ProductLogForm();
            productLForm.Show(this);
        }
    }
}
