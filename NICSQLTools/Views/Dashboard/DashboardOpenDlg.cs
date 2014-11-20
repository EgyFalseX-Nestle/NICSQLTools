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
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
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
                    LSMSDS.QueryableSource = from q in dsLinq.AppDashboardDs select q;
                    LSMSUser.QueryableSource = from q in dsLinq.Users select q;

                    XPSCS.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
                    gridControlMain.DataSource = XPSCS;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        #endregion
        #region -   EventWhnd   -
        private void DashboardOpenDlg_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void repositoryItemButtonEditSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            DevExpress.Xpo.Metadata.XPDataTableObject obj = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            DashboardSchemaId = Convert.ToInt32(obj.GetMemberValue("DashboardSchemaId"));
            Close();
        }
        #endregion


    }
}