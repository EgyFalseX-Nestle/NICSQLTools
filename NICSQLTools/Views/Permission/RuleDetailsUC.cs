using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using DevExpress.XtraTreeList.Nodes;
using System.Text;

namespace NICSQLTools.Views.Permission
{
    public partial class RuleDetailsUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(RuleDetailsUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Views.Main.rtfTextViewerFrm FrmViewer;
        NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter adpDS = new NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter();
        #endregion
        #region - Fun -
        public RuleDetailsUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadRulesList()
        {
            rules_LUETableAdapter.Fill(dsQry.Rules_LUE);
            XPSCSDS.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
            gridControlMain.DataSource = XPSCSDS;
        }
        public static void LoadDefaultNodes(DevExpress.XtraTreeList.TreeList Tree, NICSQLTools.Views.Main.MainTilesFrm MainFrm)
        {
            Tree.Nodes.Clear();
            //NICSQLTools.Forms.Main.MainTilesFrm MainFrm = (NICSQLTools.Forms.Main.MainTilesFrm)Parent.Parent.Parent;

            Tree.BeginUnboundLoad();

            // Create a root node .
            TreeListNode RootNode = null;
            TreeListNode RootEditorNode = Tree.AppendNode(new object[] { "Editors", false, false, false, false }, RootNode);
            TreeListNode RootQueriesNode = Tree.AppendNode(new object[] { "Queries", false, false, false, false }, RootNode);
            TreeListNode RootRulesNode = Tree.AppendNode(new object[] { "Rules", false, false, false, false }, RootNode);
            TreeListNode RootReportsNode = Tree.AppendNode(new object[] { "Reports", false, false, false, false }, RootNode);
            TreeListNode RootDashBoardNode = Tree.AppendNode(new object[] { "DashBoard", false, false, false, false }, RootNode);

            //RootEditorNode.Tag = "root"; RootQueriesNode.Tag = "root"; RootRulesNode.Tag = "root"; RootReportsNode.Tag = "root"; RootDashBoardNode.Tag = "root";

            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerEditors.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootEditorNode);
            }
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerQueries.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootQueriesNode);
            }
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerRules.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootRulesNode);
            }
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerReports.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootReportsNode);
            }
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerDashboard.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootDashBoardNode);
            }
            Tree.EndUnboundLoad();
        }
        void LoadUserData(int RuleID)
        {
            ruleDetailTableAdapter.FillByRuleID(dsData.AppRuleDetail, RuleID);

            foreach (NICSQLTools.Data.dsData.AppRuleDetailRow row in dsData.AppRuleDetail)
            {
                TreeListNode node = (TreeListNode)TLItems.FindNodeByFieldValue("ID", row.ItemName);
                if (node != null)
                {
                    node.SetValue(tlcSelect, row.Selecting);
                    node.SetValue(tlcInsert, row.Inserting);
                    node.SetValue(tlcUpdate, row.Updateing);
                    node.SetValue(tlcDelete, row.Deleting);
                }
            }
        }
        void SaveUserData(int RuleID)
        {
            
            ruleDetailTableAdapter.DeleteByRuleID(RuleID);//Delete All Rule Contains To Add New
            ruleDetailTableAdapter.FillByRuleID(dsData.AppRuleDetail, RuleID);//Empty RuleDetail Table

            List<TreeListNode> Nodes = GetAllItems(TLItems);
         
            foreach (TreeListNode node in Nodes)
            {
                NICSQLTools.Data.dsData.AppRuleDetailRow row = dsData.AppRuleDetail.NewAppRuleDetailRow();
                row.RuleID = RuleID; row.ItemName = node.GetValue(tlcID).ToString();
                row.Selecting = Convert.ToBoolean(node.GetValue(tlcSelect)); row.Inserting = Convert.ToBoolean(node.GetValue(tlcInsert));
                row.Updateing = Convert.ToBoolean(node.GetValue(tlcUpdate)); row.Deleting = Convert.ToBoolean(node.GetValue(tlcDelete));
                dsData.AppRuleDetail.AddAppRuleDetailRow(row);
            }
            ruleDetailTableAdapter.Update(dsData.AppRuleDetail);
        }
        public static List<TreeListNode> GetAllItems(DevExpress.XtraTreeList.TreeList Tree)
        {
            List<TreeListNode> Nodes = new List<TreeListNode>();
            foreach (TreeListNode node in Tree.Nodes)
                GetSubNodes(node, ref Nodes);
            return Nodes;
        }
        static void GetSubNodes(TreeListNode NodesParent, ref List<TreeListNode> Nodes)
        {
            foreach (TreeListNode node in NodesParent.Nodes)
            {
                if (node.HasChildren)
                    GetSubNodes(node, ref Nodes);
                else
                    Nodes.Add(node);
            }
        }
        public void ActivateRules()
        {
            if (!_elementRule.Updateing)
                bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            
        }
        private void ShowInfo(int dsID)
        {
            FrmViewer = new Main.rtfTextViewerFrm(string.Empty);
            FrmViewer.WindowState = FormWindowState.Maximized;

            object obj = adpDS.GetDesc(dsID);
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
        #region -  EventWhnd - 
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            LoadRulesList();
            ActivateRules();
            
        }
        private void bbiRule_EditValueChanged(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    LoadDefaultNodes(TLItems, (NICSQLTools.Views.Main.MainTilesFrm)Parent.Parent.Parent);
                    LoadUserData(Convert.ToInt32(bbiRule.EditValue));

                    LSMSCategory.QueryableSource = from q in dsLinq.vAppDSCategories select q;
                    treeListMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        private void treeListMain_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            NICSQLTools.Data.Linq.vAppDSCategory ds = (NICSQLTools.Data.Linq.vAppDSCategory)treeListMain.GetDataRecordByNode(treeListMain.FocusedNode);
            //LSMSDatasource.QueryableSource = from q in dsLinq.vAppDatasource_LUEs where q.DSCategoryId == ds.DSCategoryId select q;
            //appRuleDatasourceForRuleTableAdapter.Fill(dsData.AppRuleDatasourceForRule, Convert.ToInt32(bbiRule.EditValue), ds.DSCategoryId);
            XPSCSDS.FixedFilterString = "[DSCategoryId] = " + ds.DSCategoryId;
            gridViewMain.BestFitColumns();
        }
        private void treeListMain_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            treeListMain.BestFitColumns();
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(bbiRule.EditValue))
                return;
            int RuleID = Convert.ToInt32(bbiRule.EditValue);

            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    SaveUserData(RuleID);
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                    Logger.Info("Data Saved ...");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MsgDlg.ShowAlert(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                    Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                   
                }
                SplashScreenManager.CloseForm();
            });
            
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!TLItems.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            TLItems.ShowRibbonPrintPreview();
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            LoadRulesList();
            bbiRule_EditValueChanged(bbiRule, EventArgs.Empty);
        }
        private void repositoryItemButtonEditDSInfo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //NICSQLTools.Data.dsData.AppRuleDatasourceForRuleRow row = (NICSQLTools.Data.dsData.AppRuleDatasourceForRuleRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            //ShowInfo(row.DatasourceID);
        }
        private void gridViewMain_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)(gridViewMain.GetRow(e.RowHandle));

            MessageBox.Show(row.GetMemberValue("EnableRule").ToString());
        }
        #endregion

    }
}
