using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treasurer2
{
    public partial class ThemeAndSkin : DevExpress.XtraEditors.XtraUserControl
    {
        private static ThemeAndSkin _instance;

        public static ThemeAndSkin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ThemeAndSkin();
                return _instance;
            }
        }

        public ThemeAndSkin()
        {
            InitializeComponent();
        }

        private void ThemeAndSkin_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(SkinsLink);
        }

        private void splashScreenButton_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, true);
            SplashScreenManager.Default.SetWaitFormCaption("Та жоохон хүлээчихгүйюудоо ");
            for(int i = 1; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();
        }
    }
}
