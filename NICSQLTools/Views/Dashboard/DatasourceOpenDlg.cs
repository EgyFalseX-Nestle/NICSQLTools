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
    public partial class DatasourceOpenDlg : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DashboardOpenDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        public NICSQLTools.Data.Linq.AppDatasource DataSourceRow;
        private NICSQLTools.Uti.Types.AppDatasourceTypeIdEnum DatasourceType = Uti.Types.AppDatasourceTypeIdEnum.SPQry;

        #endregion
        #region -   Functions   -
        public DatasourceOpenDlg(NICSQLTools.Uti.Types.AppDatasourceTypeIdEnum Type)
        {
            InitializeComponent();
            DatasourceType = Type;
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    LSMSDS.QueryableSource = from q in dsLinq.AppDatasources where q.AppDatasourceTypeId == (int)DatasourceType select q;
                    LSMSUser.QueryableSource = from q in dsLinq.AppUsers select q;
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
            DataSourceRow = (NICSQLTools.Data.Linq.AppDatasource)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            Close();
            
        }
        
        #endregion

    }
}