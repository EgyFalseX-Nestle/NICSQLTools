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
    public partial class DashboardDSOpenDlg : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DashboardOpenDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        public NICSQLTools.Data.Linq.AppDashboardD DataSourceRow;

        #endregion
        #region -   Functions   -
        public DashboardDSOpenDlg()
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
            Close();
        }
        private void repositoryItemButtonEditSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            //Get Selected Row
            DataSourceRow = (NICSQLTools.Data.Linq.AppDashboardD)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            Close();
            
        }
        
        #endregion

        


    }
}