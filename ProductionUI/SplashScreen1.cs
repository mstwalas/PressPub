using DevExpress.XtraSplashScreen;
using System;

namespace ProductionUI
{
    public partial class SplashScreen1 : SplashScreen
    {
        public enum SplashScreenCommand
        {
        }

        public SplashScreen1()
        {
            InitializeComponent();
            //this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}