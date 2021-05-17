
namespace Treasurer2
{
    partial class TakePictureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakePictureForm));
            this.labelCamera = new System.Windows.Forms.Label();
            this.simpleButtonTake = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.comboBoxCamera = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCamera
            // 
            this.labelCamera.AutoSize = true;
            this.labelCamera.Location = new System.Drawing.Point(32, 24);
            this.labelCamera.Name = "labelCamera";
            this.labelCamera.Size = new System.Drawing.Size(47, 14);
            this.labelCamera.TabIndex = 1;
            this.labelCamera.Text = "Camera";
            // 
            // simpleButtonTake
            // 
            this.simpleButtonTake.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonTake.ImageOptions.SvgImage")));
            this.simpleButtonTake.Location = new System.Drawing.Point(314, 307);
            this.simpleButtonTake.Name = "simpleButtonTake";
            this.simpleButtonTake.Size = new System.Drawing.Size(78, 40);
            this.simpleButtonTake.TabIndex = 2;
            this.simpleButtonTake.Text = "Take";
            this.simpleButtonTake.Click += new System.EventHandler(this.simpleButtonTake_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(18, 56);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(383, 245);
            this.pictureEdit1.TabIndex = 3;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Location = new System.Drawing.Point(403, 56);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(338, 245);
            this.pictureEdit2.TabIndex = 4;
            // 
            // comboBoxCamera
            // 
            this.comboBoxCamera.FormattingEnabled = true;
            this.comboBoxCamera.Location = new System.Drawing.Point(123, 21);
            this.comboBoxCamera.Name = "comboBoxCamera";
            this.comboBoxCamera.Size = new System.Drawing.Size(236, 22);
            this.comboBoxCamera.TabIndex = 5;
            // 
            // TakePictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 370);
            this.Controls.Add(this.comboBoxCamera);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButtonTake);
            this.Controls.Add(this.labelCamera);
            this.Name = "TakePictureForm";
            this.Text = "TakePictureForm";
            this.Load += new System.EventHandler(this.TakePictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCamera;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTake;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.ComboBox comboBoxCamera;
    }
}