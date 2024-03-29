﻿using DevExpress.XtraBars;
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

<<<<<<< HEAD
        }
=======
        #region accExit_Click
        private void accExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Та гарахдаа итгэлтэй байна уу?", "Гарах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
    }
}
