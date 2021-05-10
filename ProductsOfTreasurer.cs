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

namespace Treasurer2
{
    public partial class ProductsOfTreasurer : DevExpress.XtraEditors.XtraUserControl
    {
        private static ProductsOfTreasurer _instance;

        public static ProductsOfTreasurer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProductsOfTreasurer();
                return _instance;
            }
        }
        public ProductsOfTreasurer()
        {
            InitializeComponent();
        }

        MyDatabase db = new MyDatabase();
        PRODUCTS products = new PRODUCTS();
        

        private void ProductsOfTreasurer_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM usersdb.product;", db.getConnection());
            dataGridProduct.DataSource = products.getProductList(command);


        }

        

    }
}
