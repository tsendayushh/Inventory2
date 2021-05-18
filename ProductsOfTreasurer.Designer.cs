
namespace Treasurer2
{
    partial class ProductsOfTreasurer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsOfTreasurer));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            this.coldate_expire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstock_quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripPrintButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.seeLogToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersdbDataSet1 = new Treasurer2.usersdbDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproduct_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colptype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_manufactured = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperson_responsible_for = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productTableAdapter = new Treasurer2.usersdbDataSet1TableAdapters.productTableAdapter();
            this.usersdbDataSet3 = new Treasurer2.usersdbDataSet3();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter1 = new Treasurer2.usersdbDataSet3TableAdapters.productTableAdapter();
            this.coltotal_quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // coldate_expire
            // 
            this.coldate_expire.Caption = "Date expire";
            this.coldate_expire.FieldName = "date_expire";
            this.coldate_expire.Name = "coldate_expire";
            this.coldate_expire.OptionsColumn.AllowEdit = false;
            this.coldate_expire.OptionsColumn.ReadOnly = true;
            this.coldate_expire.Visible = true;
            this.coldate_expire.VisibleIndex = 6;
            this.coldate_expire.Width = 145;
            // 
            // colstock_quantity
            // 
            this.colstock_quantity.Caption = "In storage";
            this.colstock_quantity.FieldName = "stock_quantity";
            this.colstock_quantity.Name = "colstock_quantity";
            this.colstock_quantity.Visible = true;
            this.colstock_quantity.VisibleIndex = 3;
            this.colstock_quantity.Width = 91;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonDelete,
            this.toolStripSeparator3,
            this.toolStripButtonRefresh,
            this.toolStripSeparator4,
            this.toolStripTextBoxSearch,
            this.toolStripButtonSearch,
            this.toolStripSeparator5,
            this.toolstripPrintButton,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(581, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "Шинэ Эд хөрөнгө нэмэх";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "Засварлах";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "Устгах";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "toolStripButton4";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearch.Text = "Хайх (Эд хөрөнгийн нэр, эд хөрөнгийн төрөл, хариуцах эзэн)";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolstripPrintButton
            // 
            this.toolstripPrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripPrintButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripPrintButton.Image")));
            this.toolstripPrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripPrintButton.Name = "toolstripPrintButton";
            this.toolstripPrintButton.Size = new System.Drawing.Size(23, 22);
            this.toolstripPrintButton.Text = "toolStripButton1";
            this.toolstripPrintButton.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeLogToolStripItem,
            this.addLogToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // seeLogToolStripItem
            // 
            this.seeLogToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("seeLogToolStripItem.Image")));
            this.seeLogToolStripItem.Name = "seeLogToolStripItem";
            this.seeLogToolStripItem.Size = new System.Drawing.Size(154, 22);
            this.seeLogToolStripItem.Text = "Бүртгэл харах";
            this.seeLogToolStripItem.Click += new System.EventHandler(this.addLogToolStripMenuItem_Click);
            // 
            // addLogToolStripMenuItem
            // 
            this.addLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addLogToolStripMenuItem.Image")));
            this.addLogToolStripMenuItem.Name = "addLogToolStripMenuItem";
            this.addLogToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addLogToolStripMenuItem.Text = "Бүртгэл нэмэх";
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 25);
            this.standaloneBarDockControl1.Manager = null;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(581, 404);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(581, 404);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.usersdbDataSet1;
            // 
            // usersdbDataSet1
            // 
            this.usersdbDataSet1.DataSetName = "usersdbDataSet1";
            this.usersdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproduct_id,
            this.colpname,
            this.colptype,
            this.colquantity,
            this.colstock_quantity,
            this.coltotal_quantity,
            this.coldate_manufactured,
            this.coldate_expire,
            this.colimage,
            this.colprice,
            this.colperson_responsible_for});
            gridFormatRule1.Column = this.coldate_expire;
            gridFormatRule1.ColumnApplyTo = this.coldate_expire;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue1.PredefinedName = "Green Fill, Green Text";
            formatConditionRuleValue1.Value1 = true;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.Column = this.coldate_expire;
            gridFormatRule2.ColumnApplyTo = this.coldate_expire;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual;
            formatConditionRuleValue2.PredefinedName = "Red Fill, Red Text";
            formatConditionRuleValue2.Value1 = new System.DateTime(2021, 5, 14, 16, 11, 28, 0);
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.Column = this.colstock_quantity;
            gridFormatRule3.ColumnApplyTo = this.colstock_quantity;
            gridFormatRule3.Name = "In stock or not";
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.PredefinedName = "Red Fill";
            formatConditionRuleValue3.Value1 = "0";
            gridFormatRule3.Rule = formatConditionRuleValue3;
            gridFormatRule4.Name = "Format2";
            gridFormatRule4.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.FormatRules.Add(gridFormatRule4);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 70;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colproduct_id, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colproduct_id
            // 
            this.colproduct_id.Caption = "ID";
            this.colproduct_id.FieldName = "product_id";
            this.colproduct_id.Name = "colproduct_id";
            this.colproduct_id.OptionsColumn.AllowEdit = false;
            this.colproduct_id.OptionsColumn.ReadOnly = true;
            this.colproduct_id.Visible = true;
            this.colproduct_id.VisibleIndex = 0;
            this.colproduct_id.Width = 59;
            // 
            // colpname
            // 
            this.colpname.Caption = "Product name";
            this.colpname.FieldName = "pname";
            this.colpname.Name = "colpname";
            this.colpname.OptionsColumn.AllowEdit = false;
            this.colpname.OptionsColumn.ReadOnly = true;
            this.colpname.Visible = true;
            this.colpname.VisibleIndex = 1;
            this.colpname.Width = 136;
            // 
            // colptype
            // 
            this.colptype.Caption = "Category";
            this.colptype.FieldName = "ptype";
            this.colptype.Name = "colptype";
            this.colptype.OptionsColumn.AllowEdit = false;
            this.colptype.OptionsColumn.ReadOnly = true;
            this.colptype.Visible = true;
            this.colptype.VisibleIndex = 2;
            this.colptype.Width = 92;
            // 
            // colquantity
            // 
            this.colquantity.Caption = "Quantity";
            this.colquantity.FieldName = "quantity";
            this.colquantity.Name = "colquantity";
            this.colquantity.Width = 81;
            // 
            // coldate_manufactured
            // 
            this.coldate_manufactured.Caption = "Date manufactured";
            this.coldate_manufactured.FieldName = "date_manufactured";
            this.coldate_manufactured.Name = "coldate_manufactured";
            this.coldate_manufactured.OptionsColumn.AllowEdit = false;
            this.coldate_manufactured.OptionsColumn.ReadOnly = true;
            this.coldate_manufactured.Visible = true;
            this.coldate_manufactured.VisibleIndex = 5;
            this.coldate_manufactured.Width = 149;
            // 
            // colimage
            // 
            this.colimage.Caption = "Picture";
            this.colimage.FieldName = "image";
            this.colimage.Name = "colimage";
            this.colimage.OptionsColumn.AllowEdit = false;
            this.colimage.OptionsColumn.ReadOnly = true;
            this.colimage.Visible = true;
            this.colimage.VisibleIndex = 7;
            this.colimage.Width = 123;
            // 
            // colprice
            // 
            this.colprice.Caption = "Price";
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 8;
            this.colprice.Width = 138;
            // 
            // colperson_responsible_for
            // 
            this.colperson_responsible_for.Caption = "Owner";
            this.colperson_responsible_for.FieldName = "person_responsible_for";
            this.colperson_responsible_for.Name = "colperson_responsible_for";
            this.colperson_responsible_for.OptionsColumn.AllowEdit = false;
            this.colperson_responsible_for.OptionsColumn.ReadOnly = true;
            this.colperson_responsible_for.Width = 144;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // usersdbDataSet3
            // 
            this.usersdbDataSet3.DataSetName = "usersdbDataSet3";
            this.usersdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.usersdbDataSet3;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // coltotal_quantity
            // 
            this.coltotal_quantity.Caption = "Total";
            this.coltotal_quantity.FieldName = "total_quantity";
            this.coltotal_quantity.Name = "coltotal_quantity";
            this.coltotal_quantity.Visible = true;
            this.coltotal_quantity.VisibleIndex = 4;
            this.coltotal_quantity.Width = 83;
            // 
            // ProductsOfTreasurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ProductsOfTreasurer";
            this.Size = new System.Drawing.Size(581, 429);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpname;
        private DevExpress.XtraGrid.Columns.GridColumn colptype;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_manufactured;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_expire;
        private DevExpress.XtraGrid.Columns.GridColumn colperson_responsible_for;
        private DevExpress.XtraGrid.Columns.GridColumn colimage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolstripPrintButton;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colstock_quantity;
        private System.Windows.Forms.BindingSource productBindingSource;
        private usersdbDataSet1 usersdbDataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private usersdbDataSet1TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem seeLogToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem addLogToolStripMenuItem;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private usersdbDataSet3 usersdbDataSet3;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_quantity;
        private usersdbDataSet3TableAdapters.productTableAdapter productTableAdapter1;
    }
}
