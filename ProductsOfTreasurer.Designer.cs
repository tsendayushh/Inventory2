
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsOfTreasurer));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproduct_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colptype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_manufactured = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_expire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperson_responsible_for = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_usersdb_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "usersdb_select_product";
            storedProcQuery2.StoredProcName = "usersdb.select_product";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "usersdb_select_product";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(581, 401);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproduct_id,
            this.colpname,
            this.colptype,
            this.coldate_manufactured,
            this.coldate_expire,
            this.colperson_responsible_for,
            this.colimage});
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
            this.colproduct_id.FieldName = "product_id";
            this.colproduct_id.Name = "colproduct_id";
            this.colproduct_id.OptionsColumn.AllowEdit = false;
            this.colproduct_id.OptionsColumn.ReadOnly = true;
            this.colproduct_id.Visible = true;
            this.colproduct_id.VisibleIndex = 0;
            this.colproduct_id.Width = 101;
            // 
            // colpname
            // 
            this.colpname.FieldName = "pname";
            this.colpname.Name = "colpname";
            this.colpname.OptionsColumn.AllowEdit = false;
            this.colpname.OptionsColumn.ReadOnly = true;
            this.colpname.Visible = true;
            this.colpname.VisibleIndex = 1;
            this.colpname.Width = 125;
            // 
            // colptype
            // 
            this.colptype.FieldName = "ptype";
            this.colptype.Name = "colptype";
            this.colptype.OptionsColumn.AllowEdit = false;
            this.colptype.OptionsColumn.ReadOnly = true;
            this.colptype.Visible = true;
            this.colptype.VisibleIndex = 2;
            this.colptype.Width = 125;
            // 
            // coldate_manufactured
            // 
            this.coldate_manufactured.FieldName = "date_manufactured";
            this.coldate_manufactured.Name = "coldate_manufactured";
            this.coldate_manufactured.OptionsColumn.AllowEdit = false;
            this.coldate_manufactured.OptionsColumn.ReadOnly = true;
            this.coldate_manufactured.Visible = true;
            this.coldate_manufactured.VisibleIndex = 3;
            this.coldate_manufactured.Width = 163;
            // 
            // coldate_expire
            // 
            this.coldate_expire.FieldName = "date_expire";
            this.coldate_expire.Name = "coldate_expire";
            this.coldate_expire.OptionsColumn.AllowEdit = false;
            this.coldate_expire.OptionsColumn.ReadOnly = true;
            this.coldate_expire.Visible = true;
            this.coldate_expire.VisibleIndex = 5;
            this.coldate_expire.Width = 159;
            // 
            // colperson_responsible_for
            // 
            this.colperson_responsible_for.FieldName = "person_responsible_for";
            this.colperson_responsible_for.Name = "colperson_responsible_for";
            this.colperson_responsible_for.OptionsColumn.AllowEdit = false;
            this.colperson_responsible_for.OptionsColumn.ReadOnly = true;
            this.colperson_responsible_for.Visible = true;
            this.colperson_responsible_for.VisibleIndex = 4;
            this.colperson_responsible_for.Width = 156;
            // 
            // colimage
            // 
            this.colimage.FieldName = "image";
            this.colimage.Name = "colimage";
            this.colimage.OptionsColumn.AllowEdit = false;
            this.colimage.OptionsColumn.ReadOnly = true;
            this.colimage.Visible = true;
            this.colimage.VisibleIndex = 6;
            this.colimage.Width = 189;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(581, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // ProductsOfTreasurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ProductsOfTreasurer";
            this.Size = new System.Drawing.Size(581, 429);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpname;
        private DevExpress.XtraGrid.Columns.GridColumn colptype;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_manufactured;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_expire;
        private DevExpress.XtraGrid.Columns.GridColumn colperson_responsible_for;
        private DevExpress.XtraGrid.Columns.GridColumn colimage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}
