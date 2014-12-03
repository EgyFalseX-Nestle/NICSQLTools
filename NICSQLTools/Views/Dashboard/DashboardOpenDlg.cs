using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace NICSQLTools.Views.Dashboard
{
    public partial class DashboardOpenDlg : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DashboardOpenDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        public int DashboardSchemaId;
        #endregion
        #region -   Functions   -
        public DashboardOpenDlg()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    LSMSSchema.QueryableSource = from q in dsLinq.vAppDashboardSchema_LUEs select q;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        private void RefreshData()
        {
            LSMSSchema.Reload();
        }
        #endregion
        #region -   EventWhnd   -
        private void DashboardOpenDlg_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void repositoryItemButtonEditSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            NICSQLTools.Data.Linq.vAppDashboardSchema_LUE row = (NICSQLTools.Data.Linq.vAppDashboardSchema_LUE)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            DashboardSchemaId = row.DashboardSchemaId;
            Close();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                return;
            NICSQLTools.Data.Linq.vAppDashboardSchema_LUE row = (NICSQLTools.Data.Linq.vAppDashboardSchema_LUE)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            appDashboardSchemaTableAdapter.Delete(row.DashboardSchemaId);
            MsgDlg.Show("Schema Deleted ..", MsgDlg.MessageType.Success);
            Logger.Info("Schema Deleted ..");
            RefreshData();
        }

        #endregion


    }
}