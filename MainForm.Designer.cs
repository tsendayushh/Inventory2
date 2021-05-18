
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
            this.containerMainform = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accAddProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accEditProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
<<<<<<< HEAD
            this.aceUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
=======
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.aceUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accAddUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accEditUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // containerMainform
            // 
            this.containerMainform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMainform.Location = new System.Drawing.Point(227, 31);
            this.containerMainform.Name = "containerMainform";
<<<<<<< HEAD
            this.containerMainform.Size = new System.Drawing.Size(571, 437);
=======
            this.containerMainform.Size = new System.Drawing.Size(563, 497);
>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
            this.containerMainform.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
<<<<<<< HEAD
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(227, 437);
=======
            this.accordionControlElement1,
            this.accordionControlSeparator5});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(237, 497);
>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceProducts,
            this.aceUsers});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Ерөнхий цэс";
            // 
            // aceProducts
            // 
            this.aceProducts.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accAddProduct,
            this.accEditProduct});
<<<<<<< HEAD
=======
            this.aceProducts.Expanded = true;
            this.aceProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceProducts.ImageOptions.SvgImage")));
>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
            this.aceProducts.Name = "aceProducts";
            this.aceProducts.Text = "Эд хогшилууд";
            this.aceProducts.Click += new System.EventHandler(this.aceProducts_Click);
            // 
            // accAddProduct
            // 
            this.accAddProduct.Name = "accAddProduct";
            this.accAddProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accAddProduct.Text = "Нэмж бүртгэх";
            this.accAddProduct.Click += new System.EventHandler(this.accAddProduct_Click);
            // 
            // accEditProduct
            // 
            this.accEditProduct.Name = "accEditProduct";
            this.accEditProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accEditProduct.Text = "Засварлах";
            this.accEditProduct.Click += new System.EventHandler(this.accEditProduct_Click);
            // 
<<<<<<< HEAD
=======
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
            // aceUsers
            // 
            this.aceUsers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement4,
            this.accordionControlElement5});
            this.aceUsers.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.aceUsers.Name = "aceUsers";
            this.aceUsers.Text = "Хэрэглэгчид";
            this.aceUsers.Click += new System.EventHandler(this.aceUsers_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Element4";
            // 
            // accordionControlElement5
            // 
<<<<<<< HEAD
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Element5";
=======
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
>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
<<<<<<< HEAD
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(798, 31);
=======
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(800, 30);
>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(798, 468);
=======
            this.ClientSize = new System.Drawing.Size(800, 527);
>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
            this.ControlContainer = this.containerMainform;
            this.Controls.Add(this.containerMainform);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эд хөрөнгө бүртгэх апп";
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
<<<<<<< HEAD
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
=======
        private DevExpress.XtraBars.Navigation.AccordionControlElement accAddUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accEditUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accExit;
        internal DevExpress.XtraBars.Navigation.AccordionControlElement accUser;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
>>>>>>> parent of 16dc791 (product iig awah bolon butsaah log toi table uusgej zeeleh bolon butsaah uildeltei mun tvvniig bvrtgedg form hiisn)
    }
}