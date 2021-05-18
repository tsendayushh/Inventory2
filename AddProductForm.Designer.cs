
namespace Treasurer2
{
    partial class AddProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.textBoxProductName = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.dateEditManufactured = new DevExpress.XtraEditors.DateEdit();
            this.uploadPictureButton = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditExpire = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.glueOwner = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glueCategory = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEditQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPrice = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditManufactured.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditManufactured.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpire.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(151, 11);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(231, 20);
            this.textBoxProductName.TabIndex = 0;
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(151, 295);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchVertical;
            this.pictureEdit.Size = new System.Drawing.Size(231, 124);
            this.pictureEdit.TabIndex = 4;
            this.pictureEdit.TabStop = true;
            // 
            // dateEditManufactured
            // 
            this.dateEditManufactured.EditValue = null;
            this.dateEditManufactured.Location = new System.Drawing.Point(151, 90);
            this.dateEditManufactured.Name = "dateEditManufactured";
            this.dateEditManufactured.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditManufactured.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditManufactured.Properties.DisplayFormat.FormatString = "";
            this.dateEditManufactured.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditManufactured.Properties.EditFormat.FormatString = "";
            this.dateEditManufactured.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditManufactured.Properties.MaskSettings.Set("mask", "");
            this.dateEditManufactured.Size = new System.Drawing.Size(231, 20);
            this.dateEditManufactured.TabIndex = 8;
            // 
            // uploadPictureButton
            // 
            this.uploadPictureButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("uploadPictureButton.ImageOptions.SvgImage")));
            this.uploadPictureButton.Location = new System.Drawing.Point(151, 425);
            this.uploadPictureButton.Name = "uploadPictureButton";
            this.uploadPictureButton.Size = new System.Drawing.Size(230, 27);
            this.uploadPictureButton.TabIndex = 9;
            this.uploadPictureButton.Text = "Upload image";
            this.uploadPictureButton.Click += new System.EventHandler(this.uploadPictureButton_Click);
            // 
            // dateEditExpire
            // 
            this.dateEditExpire.EditValue = null;
            this.dateEditExpire.Location = new System.Drawing.Point(151, 134);
            this.dateEditExpire.Name = "dateEditExpire";
            this.dateEditExpire.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditExpire.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditExpire.Properties.DisplayFormat.FormatString = "";
            this.dateEditExpire.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditExpire.Properties.EditFormat.FormatString = "";
            this.dateEditExpire.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditExpire.Properties.MaskSettings.Set("mask", "");
            this.dateEditExpire.Size = new System.Drawing.Size(231, 20);
            this.dateEditExpire.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(39, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 14);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Эд хөрөнгийн нэр:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(25, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 14);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Эд хөрөнгийн төрөл:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(12, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 14);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Үйлдвэрлэгдсэн огноо:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.Location = new System.Drawing.Point(51, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Хүчинтэй огноо:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(61, 178);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 14);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Хариуцах эзэн:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.Location = new System.Drawing.Point(111, 336);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 14);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Зураг:";
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(39, 472);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(131, 34);
            this.simpleButtonAdd.TabIndex = 18;
            this.simpleButtonAdd.Text = "Бүртгэх";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Location = new System.Drawing.Point(226, 472);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(131, 34);
            this.simpleButtonCancel.TabIndex = 19;
            this.simpleButtonCancel.Text = "Цуцлах";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // glueOwner
            // 
            this.glueOwner.Location = new System.Drawing.Point(151, 175);
            this.glueOwner.Name = "glueOwner";
            this.glueOwner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueOwner.Properties.DisplayMember = "username";
            this.glueOwner.Properties.PopupView = this.gridLookUpEdit1View;
            this.glueOwner.Properties.ValueMember = "username";
            this.glueOwner.Size = new System.Drawing.Size(231, 20);
            this.glueOwner.TabIndex = 21;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // glueCategory
            // 
            this.glueCategory.Location = new System.Drawing.Point(151, 50);
            this.glueCategory.Name = "glueCategory";
            this.glueCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueCategory.Properties.DisplayMember = "product_type";
            this.glueCategory.Properties.PopupView = this.gridView1;
            this.glueCategory.Properties.ValueMember = "product_type";
            this.glueCategory.Size = new System.Drawing.Size(231, 20);
            this.glueCategory.TabIndex = 22;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.Location = new System.Drawing.Point(76, 218);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 14);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Тоо ширхэг:";
            // 
            // textEditQuantity
            // 
            this.textEditQuantity.Location = new System.Drawing.Point(151, 215);
            this.textEditQuantity.Name = "textEditQuantity";
            this.textEditQuantity.Size = new System.Drawing.Size(231, 20);
            this.textEditQuantity.TabIndex = 23;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl8.Location = new System.Drawing.Point(56, 259);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 14);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "Ширхэгийн үнэ:";
            // 
            // textEditPrice
            // 
            this.textEditPrice.Location = new System.Drawing.Point(151, 253);
            this.textEditPrice.Name = "textEditPrice";
            this.textEditPrice.Size = new System.Drawing.Size(231, 20);
            this.textEditPrice.TabIndex = 25;
            // 
            // AddProductForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 515);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.textEditPrice);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.textEditQuantity);
            this.Controls.Add(this.glueCategory);
            this.Controls.Add(this.glueOwner);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonAdd);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateEditExpire);
            this.Controls.Add(this.uploadPictureButton);
            this.Controls.Add(this.dateEditManufactured);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.pictureEdit);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AddProductForm.IconOptions.SvgImage")));
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "Эд хогшил бүртгэх";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditManufactured.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditManufactured.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpire.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textBoxProductName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.DateEdit dateEditManufactured;
        private DevExpress.XtraEditors.SimpleButton uploadPictureButton;
        private DevExpress.XtraEditors.DateEdit dateEditExpire;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.GridLookUpEdit glueOwner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit glueCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEditQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEditPrice;
    }
}