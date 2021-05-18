
namespace Treasurer2
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.uploadPictureButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.textBoxUsername = new DevExpress.XtraEditors.TextEdit();
            this.textBoxEmail = new DevExpress.XtraEditors.TextEdit();
            this.textBoxLastname = new DevExpress.XtraEditors.TextEdit();
            this.textBoxFirstname = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.textBoxPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Location = new System.Drawing.Point(227, 418);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(131, 34);
            this.simpleButtonCancel.TabIndex = 34;
            this.simpleButtonCancel.Text = "Цуцлах";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(40, 418);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(131, 34);
            this.simpleButtonAdd.TabIndex = 33;
            this.simpleButtonAdd.Text = "Бүртгэх";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.Location = new System.Drawing.Point(111, 283);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 14);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "Зураг:";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(76, 135);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 14);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Имейл хаяг:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(49, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 14);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Эцэг/Эх-ийн нэр:";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(74, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 14);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Өөрийн нэр:";
            // 
            // uploadPictureButton
            // 
            this.uploadPictureButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("uploadPictureButton.ImageOptions.SvgImage")));
            this.uploadPictureButton.Location = new System.Drawing.Point(151, 372);
            this.uploadPictureButton.Name = "uploadPictureButton";
            this.uploadPictureButton.Size = new System.Drawing.Size(230, 27);
            this.uploadPictureButton.TabIndex = 24;
            this.uploadPictureButton.Text = "Upload image";
            this.uploadPictureButton.Click += new System.EventHandler(this.uploadPictureButton_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(40, 170);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 14);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Хэрэглэгчийн нэр:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Treasurer2.Properties.Resources.iconfinder_edit2_11679841;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 242);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(93, 170);
            this.pictureEdit1.TabIndex = 39;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(151, 167);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(231, 20);
            this.textBoxUsername.TabIndex = 38;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(151, 132);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(231, 20);
            this.textBoxEmail.TabIndex = 36;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(151, 47);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(231, 20);
            this.textBoxLastname.TabIndex = 35;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(151, 8);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(231, 20);
            this.textBoxFirstname.TabIndex = 20;
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(151, 242);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit.Size = new System.Drawing.Size(231, 124);
            this.pictureEdit.TabIndex = 21;
            this.pictureEdit.TabStop = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(151, 203);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Properties.UseSystemPasswordChar = true;
            this.textBoxPassword.Size = new System.Drawing.Size(231, 20);
            this.textBoxPassword.TabIndex = 41;
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.Location = new System.Drawing.Point(99, 206);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 14);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Нууц үг:";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(151, 82);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 3;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Male", true, null, "M"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Female", true, null, "F"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Other", true, null, "O")});
            this.radioGroup1.Size = new System.Drawing.Size(230, 29);
            this.radioGroup1.TabIndex = 65;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.Location = new System.Drawing.Point(115, 89);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 14);
            this.labelControl7.TabIndex = 64;
            this.labelControl7.Text = "Хүйс:";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 466);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonAdd);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.uploadPictureButton);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.pictureEdit);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AddUserForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton uploadPictureButton;
        private DevExpress.XtraEditors.TextEdit textBoxFirstname;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.TextEdit textBoxLastname;
        private DevExpress.XtraEditors.TextEdit textBoxEmail;
        private DevExpress.XtraEditors.TextEdit textBoxUsername;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit textBoxPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        internal DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}