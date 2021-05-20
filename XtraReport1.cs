using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Treasurer2
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        MyDatabase db = new MyDatabase();
        public XtraReport1()
        {
            InitializeComponent();
            //MySqlCommand command = new MySqlCommand("SELECT * FROM usersdb.product_owning;");

            //xrTable1.DataBindings = db.getDataTable(command);

            //xrTableCell1.Value = "product ID";
        }

    }
}
