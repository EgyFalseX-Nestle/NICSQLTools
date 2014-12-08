using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using NICSQLTools.Classes.Managers;

namespace NICSQLTools.Views.Data
{
    public partial class AppDSCategoryUC : XtraUserControl
    {
        #region - Variables -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(AppDatasourceUC));
        private NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.dsDataTableAdapters.AppDSCategoryTableAdapter adpCategory = new NICSQLTools.Data.dsDataTableAdapters.AppDSCategoryTableAdapter();
        #endregion
        #region - Functions -
        public AppDSCategoryUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                Invoke(new MethodInvoker(() => {

                    XPSCS.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;

                    treeListMain.DataSource = XPSCS;
                    treeListMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            XPSCS.AllowNew = _elementRule.Inserting;
            XPSCS.AllowRemove = _elementRule.Deleting;
            XPSCS.AllowEdit = _elementRule.Updateing;

            if (!_elementRule.Inserting)
                bbiAddNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (!_elementRule.Deleting)
                bbiDeleteNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }
        #endregion
        #region - EventWhnd -
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            ActivateRules();
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             //Check whether the GridControl can be previewed.
            if (!treeListMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            treeListMain.ShowRibbonPrintPreview();
            
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            sessionMain.DropIdentityMap();
            XPSCS.Reload();
            treeListMain.RefreshDataSource();
        }
        private void bbiAddNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lock (this)
            {
                int ParentNode;
                if (treeListMain.FocusedNode != null)
                    ParentNode = treeListMain.FocusedNode.Id;
                else
                    ParentNode = 0;
                try
                {
                    int NewNodeId = (int)adpCategory.NewId();
                    treeListMain.AppendNode(new object[] { null, NewNodeId, "New Category", "New Category Desc" }, ParentNode, 0, 0, 0);
                }
                catch{ }
            }
        }
        private void bbiDeleteNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            treeListMain.DeleteSelectedNodes();
        }

        #endregion

    }
}
