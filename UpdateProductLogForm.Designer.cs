
namespace Treasurer2
{
    partial class UpdateProductLogForm
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
            this.buttonAddLog = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.glueBorrowerUsername = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textBoxQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboboxInOrOut = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditLog = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.glueProduct = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.glueBorrowerUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxInOrOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLog.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddLog
            // 
            this.buttonAddLog.Location = new System.Drawing.Point(83, 273);
            this.buttonAddLog.Name = "buttonAddLog";
            this.buttonAddLog.Size = new System.Drawing.Size(158, 29);
            this.buttonAddLog.TabIndex = 35;
            this.buttonAddLog.Text = "simpleButton1";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(77, 239);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 14);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Зээлэгч:";
            // 
            // glueBorrowerUsername
            // 
            this.glueBorrowerUsername.Location = new System.Drawing.Point(129, 236);
            this.glueBorrowerUsername.Name = "glueBorrowerUsername";
            this.glueBorrowerUsername.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueBorrowerUsername.Properties.DisplayMember = "username";
            this.glueBorrowerUsername.Properties.PopupView = this.gridView2;
            this.glueBorrowerUsername.Properties.ValueMember = "user_id";
            this.glueBorrowerUsername.Size = new System.Drawing.Size(157, 20);
            this.glueBorrowerUsername.TabIndex = 33;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(129, 191);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(156, 20);
            this.textBoxQuantity.TabIndex = 32;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.Location = new System.Drawing.Point(51, 194);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 14);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Тоо хэмжээ:";
            // 
            // comboboxInOrOut
            // 
            this.comboboxInOrOut.Location = new System.Drawing.Point(129, 151);
            this.comboboxInOrOut.Name = "comboboxInOrOut";
            this.comboboxInOrOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboboxInOrOut.Properties.DropDownRows = 2;
            this.comboboxInOrOut.Properties.Items.AddRange(new object[] {
            "Зээлэх",
            "Буцаах"});
            this.comboboxInOrOut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboboxInOrOut.Size = new System.Drawing.Size(156, 20);
            this.comboboxInOrOut.TabIndex = 30;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(39, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 14);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Зээлэх/Буцаах:";
            // 
            // dateEditLog
            // 
            this.dateEditLog.EditValue = null;
            this.dateEditLog.Location = new System.Drawing.Point(128, 111);
            this.dateEditLog.Name = "dateEditLog";
            this.dateEditLog.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditLog.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditLog.Properties.DisplayFormat.FormatString = "";
            this.dateEditLog.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditLog.Properties.EditFormat.FormatString = "";
            this.dateEditLog.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditLog.Properties.MaskSettings.Set("mask", "");
            this.dateEditLog.Size = new System.Drawing.Size(157, 20);
            this.dateEditLog.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(83, 114);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 14);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Огноо:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(54, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 14);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Эд хөрөнгө:";
            // 
            // glueProduct
            // 
            this.glueProduct.Location = new System.Drawing.Point(128, 71);
            this.glueProduct.Name = "glueProduct";
            this.glueProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueProduct.Properties.DisplayMember = "pname";
            this.glueProduct.Properties.PopupView = this.gridLookUpEdit1View;
            this.glueProduct.Properties.ValueMember = "product_id";
            this.glueProduct.Size = new System.Drawing.Size(157, 20);
            this.glueProduct.TabIndex = 25;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.Location = new System.Drawing.Point(54, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(160, 14);
            this.labelControl6.TabIndex = 37;
            this.labelControl6.Text = "Зээлийн бүртгэлийн дугаар:";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(128, 32);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DisplayMember = "pname";
            this.gridLookUpEdit1.Properties.PopupView = this.gridView1;
            this.gridLookUpEdit1.Properties.ValueMember = "product_id";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(157, 20);
            this.gridLookUpEdit1.TabIndex = 36;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // UpdateProductLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 355);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.buttonAddLog);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.glueBorrowerUsername);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.comboboxInOrOut);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dateEditLog);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.glueProduct);
            this.Name = "UpdateProductLogForm";
            this.Text = "UpdateProductLogForm";
            ((System.ComponentModel.ISupportInitialize)(this.glueBorrowerUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxInOrOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLog.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonAddLog;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit glueBorrowerUsername;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit textBoxQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboboxInOrOut;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateEditLog;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit glueProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}