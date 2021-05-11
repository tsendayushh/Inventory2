using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Treasurer2
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
            if (!containerMainform.Controls.Contains(ProductsOfTreasurer.Instance))
            {
                containerMainform.Controls.Add(ProductsOfTreasurer.Instance);
                ProductsOfTreasurer.Instance.Dock = DockStyle.Fill;
                ProductsOfTreasurer.Instance.BringToFront();
            }
            ProductsOfTreasurer.Instance.BringToFront();
            
        }

        private void aceProducts_Click(object sender, EventArgs e)
        {
            if (!containerMainform.Controls.Contains(ProductsOfTreasurer.Instance))
            {
                containerMainform.Controls.Add(ProductsOfTreasurer.Instance);
                ProductsOfTreasurer.Instance.Dock = DockStyle.Fill;
                ProductsOfTreasurer.Instance.BringToFront();
            }
            ProductsOfTreasurer.Instance.BringToFront();

        }

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

        private void accAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addPForm = new AddProductForm();
            addPForm.Show(this);
        }

        private void accEditProduct_Click(object sender, EventArgs e)
        {
            UpdateProductForm updatePForm = new UpdateProductForm();
            updatePForm.Show(this);
        }

        private void accAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUForm = new AddUserForm();
            addUForm.Show(this);
        }

        private void accEditUser_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUForm = new UpdateUserForm();
            updateUForm.Show(this);
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void accExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Та гарахдаа итгэлтэй байна уу?","Гарах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
