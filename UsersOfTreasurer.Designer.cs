
namespace Treasurer2
{
    partial class UsersOfTreasurer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersOfTreasurer));
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.toggleSwitchDark = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.addButton = new DevExpress.XtraBars.BarButtonItem();
            this.editButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "localhost_usersdb_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery2.Name = "usersdb_select_users_of_treasurer";
            storedProcQuery2.StoredProcName = "usersdb.select_users_of_treasurer";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
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
            this.toolStripButtonSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(577, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "Хэрэглэгч нэмэх:";
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
            this.toolStripButtonDelete.Text = "Хэрэглэгчийг устгах";
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
            this.toolStripButtonRefresh.Text = "Хүснэгтийн мэдээлллийг шинэчлэх";
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
            this.toolStripButtonSearch.Text = "Хайх";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 25);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(577, 408);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.toggleSwitchDark,
            this.addButton,
            this.editButton,
            this.barButtonItem1,
            this.barCheckItem1,
            this.skinDropDownButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleSwitchDark)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // toggleSwitchDark
            // 
            this.toggleSwitchDark.Caption = "Table skin dark";
            this.toggleSwitchDark.Id = 0;
            this.toggleSwitchDark.Name = "toggleSwitchDark";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(577, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 433);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(577, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 433);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(577, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 433);
            // 
            // addButton
            // 
            this.addButton.Caption = "AddButton";
            this.addButton.Id = 1;
            this.addButton.Name = "addButton";
            // 
            // editButton
            // 
            this.editButton.Caption = "EditButton";
            this.editButton.Id = 2;
            this.editButton.Name = "editButton";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 5;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 6;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.DataMember = "usersdb_select_users_of_treasurer";
            this.gridControlUsers.DataSource = this.sqlDataSource2;
            this.gridControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUsers.Location = new System.Drawing.Point(0, 25);
            this.gridControlUsers.MainView = this.gridView1;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.Size = new System.Drawing.Size(577, 408);
            this.gridControlUsers.TabIndex = 10;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlUsers.DoubleClick += new System.EventHandler(this.gridControlUsers_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluser_id,
            this.colfirstname,
            this.collastname,
            this.colemail,
            this.colusername,
            this.colpassword,
            this.colpicture,
            this.colsex});
            this.gridView1.GridControl = this.gridControlUsers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 70;
            // 
            // coluser_id
            // 
            this.coluser_id.Caption = "User ID";
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            this.coluser_id.OptionsColumn.AllowEdit = false;
            this.coluser_id.OptionsColumn.ReadOnly = true;
            this.coluser_id.Visible = true;
            this.coluser_id.VisibleIndex = 0;
            this.coluser_id.Width = 86;
            // 
            // colfirstname
            // 
            this.colfirstname.Caption = "Firstname";
            this.colfirstname.FieldName = "firstname";
            this.colfirstname.Name = "colfirstname";
            this.colfirstname.OptionsColumn.AllowEdit = false;
            this.colfirstname.OptionsColumn.ReadOnly = true;
            this.colfirstname.Visible = true;
            this.colfirstname.VisibleIndex = 1;
            this.colfirstname.Width = 145;
            // 
            // collastname
            // 
            this.collastname.Caption = "Lastname";
            this.collastname.FieldName = "lastname";
            this.collastname.Name = "collastname";
            this.collastname.OptionsColumn.AllowEdit = false;
            this.collastname.OptionsColumn.ReadOnly = true;
            this.collastname.Visible = true;
            this.collastname.VisibleIndex = 2;
            this.collastname.Width = 158;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email Address";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.OptionsColumn.ReadOnly = true;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 4;
            this.colemail.Width = 223;
            // 
            // colusername
            // 
            this.colusername.Caption = "Username";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.AllowEdit = false;
            this.colusername.OptionsColumn.ReadOnly = true;
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 5;
            this.colusername.Width = 172;
            // 
            // colpassword
            // 
            this.colpassword.Caption = "Password";
            this.colpassword.FieldName = "password";
            this.colpassword.Name = "colpassword";
            this.colpassword.OptionsColumn.AllowEdit = false;
            this.colpassword.OptionsColumn.ReadOnly = true;
            this.colpassword.Width = 152;
            // 
            // colpicture
            // 
            this.colpicture.Caption = "Picture";
            this.colpicture.FieldName = "picture";
            this.colpicture.Name = "colpicture";
            this.colpicture.OptionsColumn.AllowEdit = false;
            this.colpicture.OptionsColumn.ReadOnly = true;
            this.colpicture.Visible = true;
            this.colpicture.VisibleIndex = 6;
            this.colpicture.Width = 165;
            // 
            // colsex
            // 
            this.colsex.Caption = "Sex";
            this.colsex.FieldName = "sex";
            this.colsex.Name = "colsex";
            this.colsex.Visible = true;
            this.colsex.VisibleIndex = 3;
            this.colsex.Width = 69;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 3";
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 4";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 1;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.Text = "Custom 4";
            // 
            // UsersOfTreasurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlUsers);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UsersOfTreasurer";
            this.Size = new System.Drawing.Size(577, 458);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
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
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colfirstname;
        private DevExpress.XtraGrid.Columns.GridColumn collastname;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraGrid.Columns.GridColumn colpicture;
        private DevExpress.XtraGrid.Columns.GridColumn colsex;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarToggleSwitchItem toggleSwitchDark;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem addButton;
        private DevExpress.XtraBars.BarButtonItem editButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
    }
}
