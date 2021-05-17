using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treasurer2
{
    public partial class RibbonMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonMainForm()
        {
            InitializeComponent();
        }

        private void barButtonProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ribbonFormContainer.Contains(ProductsOfTreasurer.Instance))
            {
                ribbonFormContainer.Contains(ProductsOfTreasurer.Instance);

                ProductsOfTreasurer.Instance.Dock = DockStyle.Fill;
                ProductsOfTreasurer.Instance.BringToFront();
            }
            ProductsOfTreasurer.Instance.BringToFront();
        }
    }
}