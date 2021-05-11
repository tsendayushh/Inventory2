
namespace Treasurer2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.containerMainform = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accAddProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accEditProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.aceUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accAddUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accEditUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // containerMainform
            // 
            this.containerMainform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMainform.Location = new System.Drawing.Point(237, 31);
            this.containerMainform.Name = "containerMainform";
            this.containerMainform.Size = new System.Drawing.Size(561, 495);
            this.containerMainform.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlSeparator5});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(237, 495);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceProducts,
            this.accordionControlSeparator1,
            this.aceUsers,
            this.accordionControlSeparator4,
            this.accUser});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Ерөнхий цэс";
            // 
            // aceProducts
            // 
            this.aceProducts.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accAddProduct,
            this.accEditProduct});
            this.aceProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceProducts.ImageOptions.SvgImage")));
            this.aceProducts.Name = "aceProducts";
            this.aceProducts.Text = "Эд хогшилууд";
            this.aceProducts.Click += new System.EventHandler(this.aceProducts_Click);
            // 
            // accAddProduct
            // 
            this.accAddProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accAddProduct.ImageOptions.SvgImage")));
            this.accAddProduct.Name = "accAddProduct";
            this.accAddProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accAddProduct.Text = "Нэмж бүртгэх";
            this.accAddProduct.Click += new System.EventHandler(this.accAddProduct_Click);
            // 
            // accEditProduct
            // 
            this.accEditProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accEditProduct.ImageOptions.SvgImage")));
            this.accEditProduct.Name = "accEditProduct";
            this.accEditProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accEditProduct.Text = "Засварлах";
            this.accEditProduct.Click += new System.EventHandler(this.accEditProduct_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // aceUsers
            // 
            this.aceUsers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accAddUser,
            this.accEditUser});
            this.aceUsers.Expanded = true;
            this.aceUsers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceUsers.ImageOptions.SvgImage")));
            this.aceUsers.Name = "aceUsers";
            this.aceUsers.Text = "Хэрэглэгчид";
            this.aceUsers.Click += new System.EventHandler(this.aceUsers_Click);
            // 
            // accAddUser
            // 
            this.accAddUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accAddUser.ImageOptions.SvgImage")));
            this.accAddUser.Name = "accAddUser";
            this.accAddUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accAddUser.Text = "Хэрэглэгч бүртгэх";
            this.accAddUser.Click += new System.EventHandler(this.accAddUser_Click);
            // 
            // accEditUser
            // 
            this.accEditUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accEditUser.ImageOptions.SvgImage")));
            this.accEditUser.Name = "accEditUser";
            this.accEditUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accEditUser.Text = "Засварлах";
            this.accEditUser.Click += new System.EventHandler(this.accEditUser_Click);
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // accUser
            // 
            this.accUser.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accExit});
            this.accUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accUser.ImageOptions.SvgImage")));
            this.accUser.Name = "accUser";
            this.accUser.Text = "Element3";
            // 
            // accExit
            // 
            this.accExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accExit.ImageOptions.SvgImage")));
            this.accExit.Name = "accExit";
            this.accExit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accExit.Text = "Гарах";
            this.accExit.Click += new System.EventHandler(this.accExit_Click);
            // 
            // accordionControlSeparator5
            // 
            this.accordionControlSeparator5.Name = "accordionControlSeparator5";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(798, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement2.ImageOptions.SvgImage")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Element4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 526);
            this.ControlContainer = this.containerMainform;
            this.Controls.Add(this.containerMainform);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainForm.IconOptions.SvgImage")));
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эд хөрөнгө бүртгэл";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer containerMainform;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceProducts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceUsers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accAddProduct;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accEditProduct;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accAddUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accEditUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accExit;
        internal DevExpress.XtraBars.Navigation.AccordionControlElement accUser;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
    }
}