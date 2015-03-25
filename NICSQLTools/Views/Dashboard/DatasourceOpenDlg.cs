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
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        public NICSQLTools.Data.Linq.vAppDatasource_LUE DataSourceRow;
        private NICSQLTools.Uti.Types.AppDatasourceTypeIdEnum DatasourceType = Uti.Types.AppDatasourceTypeIdEnum.SPQry;
        NICSQLTools.Views.Main.rtfTextViewerFrm FrmViewer;
        NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter adp = new NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter();


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
                    LSMSCategory.QueryableSource = from q in dsLinq.vAppDSCategories select q;
                    treeListMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        private void ShowInfo()
        {
            FrmViewer = new Main.rtfTextViewerFrm(string.Empty);
            FrmViewer.WindowState = FormWindowState.Maximized;
            
            object obj = adp.GetDesc(DataSourceRow.DatasourceID);
            if (obj == null || obj.ToString() == string.Empty)
            {
                MsgDlg.Show("No Help Found  ...", MsgDlg.MessageType.Info);
                FrmViewer.TextData = string.Empty;
            }
            else
            {
                byte[] data = Classes.Managers.DataManager.DecompressFile((byte[])obj).ToArray();
                FrmViewer.TextData = Encoding.Unicode.GetString(data);
                FrmViewer.ShowDialog();
            }
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
            DataSourceRow = (NICSQLTools.Data.Linq.vAppDatasource_LUE)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            Close();
        }
        private void repositoryItemButtonEditSearchSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            //Get Selected Row
            DataSourceRow = (NICSQLTools.Data.Linq.vAppDatasource_LUE)gridViewSearch.GetRow(gridViewSearch.FocusedRowHandle);
            Close();
        }
        private void treeListMain_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            NICSQLTools.Data.Linq.vAppDSCategory ds = (NICSQLTools.Data.Linq.vAppDSCategory)treeListMain.GetDataRecordByNode(treeListMain.FocusedNode);
            LSMSDatasource.QueryableSource = from q in dsLinq.vAppDatasource_LUEs where q.AppDatasourceTypeId == (int)DatasourceType && q.DSCategoryId == ds.DSCategoryId select q;
            gridViewMain.BestFitColumns();
        }
        private void repositoryItemButtonEditDSInfo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSourceRow = (NICSQLTools.Data.Linq.vAppDatasource_LUE)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            ShowInfo();
        }
        private void repositoryItemButtonEditDSSearchInfo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSourceRow = (NICSQLTools.Data.Linq.vAppDatasource_LUE)gridViewSearch.GetRow(gridViewSearch.FocusedRowHandle);
            ShowInfo();
        }
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageSearch)
                LSMSDatasourceSearch.QueryableSource = from q in dsLinq.vAppDatasource_LUEs where q.AppDatasourceTypeId == (int)DatasourceType select q;
        }
        #endregion

    }
}