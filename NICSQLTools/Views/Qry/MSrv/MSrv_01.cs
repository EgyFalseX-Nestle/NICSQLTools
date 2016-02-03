using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace NICSQLTools.Views.Qry.MSrv
{
    public partial class MSrv_01 : DevExpress.XtraEditors.XtraUserControl
    {
        public MSrv_01()
        {
            InitializeComponent();
            //XPSCSMain.FixedFilterString = "[VisibleToUserId] = " + Classes.Managers.UserManager.defaultInstance.User.UserId;
        }
        void LoadData()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    XPSCSMain.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
                    gridControlMain.DataSource = XPSCSMain;

                    gridViewMain.BestFitColumns();
                }));
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            });
        }
        private void MSrv_01_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XPSCSMain.Session.DropIdentityMap();
            XPSCSMain.Session.DropChanges();
            XPSCSMain.Reload();
            gridViewMain.RefreshData();
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        
    }
}
