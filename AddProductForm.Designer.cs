
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
            this.comboBoxOwner = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditManufactured = new DevExpress.XtraEditors.DateEdit();
            this.uploadPictureButton = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxProductCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditExpire = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditManufactured.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditManufactured.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProductCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpire.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpire.Properties)).BeginInit();
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
            this.pictureEdit.Location = new System.Drawing.Point(151, 210);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchVertical;
            this.pictureEdit.Size = new System.Drawing.Size(231, 124);
            this.pictureEdit.TabIndex = 4;
            this.pictureEdit.TabStop = true;
            // 
            // comboBoxOwner
            // 
            this.comboBoxOwner.Location = new System.Drawing.Point(151, 175);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxOwner.Properties.Items.AddRange(new object[] {
            "tsendayush",
            "uuganzaya",
            "byagi"});
            this.comboBoxOwner.Size = new System.Drawing.Size(231, 20);
            this.comboBoxOwner.TabIndex = 7;
            this.comboBoxOwner.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxOwner_MouseClick);
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
            this.uploadPictureButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("uploadPictureButton.ImageOptions.Image")));
            this.uploadPictureButton.Location = new System.Drawing.Point(151, 340);
            this.uploadPictureButton.Name = "uploadPictureButton";
            this.uploadPictureButton.Size = new System.Drawing.Size(230, 27);
            this.uploadPictureButton.TabIndex = 9;
            this.uploadPictureButton.Text = "Upload image";
            this.uploadPictureButton.Click += new System.EventHandler(this.uploadPictureButton_Click);
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.Location = new System.Drawing.Point(151, 50);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxProductCategory.Properties.Items.AddRange(new object[] {
            "Furniture",
            "Electronics",
            "Food"});
            this.comboBoxProductCategory.Size = new System.Drawing.Size(231, 20);
            this.comboBoxProductCategory.TabIndex = 10;
            this.comboBoxProductCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxProductCategory_MouseClick);
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
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(39, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 14);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Эд хөрөнгийн нэр:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(25, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 14);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Эд хөрөнгийн төрөл:";
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(12, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 14);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Үйлдвэрлэгдсэн огноо:";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.Location = new System.Drawing.Point(51, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Хүчинтэй огноо:";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(61, 178);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 14);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Хариуцах эзэн:";
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.Location = new System.Drawing.Point(111, 251);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 14);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Зураг:";
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(39, 373);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(131, 34);
            this.simpleButtonAdd.TabIndex = 18;
            this.simpleButtonAdd.Text = "Бүртгэх";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Location = new System.Drawing.Point(226, 373);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(131, 34);
            this.simpleButtonCancel.TabIndex = 19;
            this.simpleButtonCancel.Text = "Цуцлах";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 418);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonAdd);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateEditExpire);
            this.Controls.Add(this.comboBoxProductCategory);
            this.Controls.Add(this.uploadPictureButton);
            this.Controls.Add(this.dateEditManufactured);
            this.Controls.Add(this.comboBoxOwner);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.pictureEdit);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("AddProductForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "Эд хогшил бүртгэх";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditManufactured.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditManufactured.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProductCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpire.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpire.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textBoxProductName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxOwner;
        private DevExpress.XtraEditors.DateEdit dateEditManufactured;
        private DevExpress.XtraEditors.SimpleButton uploadPictureButton;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxProductCategory;
        private DevExpress.XtraEditors.DateEdit dateEditExpire;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
    }
}