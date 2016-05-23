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
using NICSQLTools.Classes.Managers;

namespace NICSQLTools.Views.Qry.MSrv
{
    public partial class MSrv_02 : DevExpress.XtraEditors.XtraUserControl
    {
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        public MSrv_02()
        {
            InitializeComponent();
            LSMSTechnicianId.QueryableSource = from q in dsLinq.vMSrv_Technician_ByUsers where q.UserId == Classes.Managers.UserManager.defaultInstance.User.UserId select q;
            //XPSCSMain.FixedFilterString = "[VisibleToUserId] = " + Classes.Managers.UserManager.defaultInstance.User.UserId;
        }
        void LoadData()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    //XPSCSMain.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
                    //gridControlMain.DataSource = XPSCSMain;
                    LSMSTechnicianId.Reload();
                    vMSrvTicketType_DetailsTableAdapter.Fill(dsMSrc.vMSrvTicketType_Details,
                        UserManager.defaultInstance.User.UserId,
                        (short) UserManager.defaultInstance.User.MSrvDepartmentId);
                    gridControlMain.DataSource = dsMSrc.vMSrvTicketType_Details;
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
            //XPSCSMain.Session.DropIdentityMap();
            //XPSCSMain.Session.DropChanges();
            //XPSCSMain.Reload();
            //gridViewMain.RefreshData();
            LoadData();
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
