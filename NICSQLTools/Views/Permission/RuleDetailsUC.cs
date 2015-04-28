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
            //XPSCSDS.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
            //gridControlMain.DataSource = XPSCSDS;
        }
        public static void LoadDefaultNodes(DevExpress.XtraTreeList.TreeList Tree, NICSQLTools.Views.Main.MainTilesFrm MainFrm)
        {
            Tree.Nodes.Clear();
            //NICSQLTools.Forms.Main.MainTilesFrm MainFrm = (NICSQLTools.Forms.Main.MainTilesFrm)Parent.Parent.Parent;

            Tree.BeginUnboundLoad();

            // Create a root node .
            TreeListNode RootNode = Tree.AppendNode(new object[] { "Main", false, false, false, false, "Main" }, 0); ;
            
            //TreeListNode RootEditorNode = Tree.AppendNode(new object[] { "Editors", false, false, false, false }, RootNode);
            //TreeListNode RootQueriesNode = Tree.AppendNode(new object[] { "Queries", false, false, false, false }, RootNode);
            //TreeListNode RootRulesNode = Tree.AppendNode(new object[] { "Rules", false, false, false, false }, RootNode);
            //TreeListNode RootReportsNode = Tree.AppendNode(new object[] { "Reports", false, false, false, false }, RootNode);
            //TreeListNode RootDashBoardNode = Tree.AppendNode(new object[] { "DashBoard", false, false, false, false }, RootNode);

            ExtractTilesFromTileContainer(MainFrm.tileContainerMain, RootNode);
            
            ////RootEditorNode.Tag = "root"; RootQueriesNode.Tag = "root"; RootRulesNode.Tag = "root"; RootReportsNode.Tag = "root"; RootDashBoardNode.Tag = "root";

            //foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerEditors.Items)
            //    Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootEditorNode);
            //foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerQueries.Items)
            //    Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootQueriesNode);
            //foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerRules.Items)
            //    Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootRulesNode);
            //foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerReports.Items)
            //    Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootReportsNode);
            //foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerDashboard.Items)
            //    Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootDashBoardNode);

            Tree.EndUnboundLoad();
        }
        private static void ExtractTilesFromTileContainer(DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer TCont, DevExpress.XtraTreeList.Nodes.TreeListNode RootNode)
        {
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in TCont.Items)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode NewNode = RootNode.TreeList.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootNode);
                
                if (tile.ActivationTarget != null)
                {
                    if (tile.ActivationTarget.GetType() == typeof(DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer))
                        ExtractTilesFromTileContainer((DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer)tile.ActivationTarget, NewNode);
                    else if (tile.ActivationTarget.GetType() == typeof(DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup))
                        ExtractTilesFromGroupContainer((DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup)tile.ActivationTarget, NewNode);
                }
            }
        }
        private static void ExtractTilesFromGroupContainer(DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup GCont, DevExpress.XtraTreeList.Nodes.TreeListNode RootNode)
        {
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document doc in GCont.Items)
                RootNode.TreeList.AppendNode(new object[] { doc.Caption, false, false, false, false, doc.ControlName }, RootNode);
        }

        void LoadUserData(int RuleID)
        {
            appRuleDetailTableAdapter.FillByRuleID(dsData.AppRuleDetail, RuleID);

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

            appRuleDetailTableAdapter.DeleteByRuleID(RuleID);//Delete All Rule Contains To Add New
            appRuleDetailTableAdapter.FillByRuleID(dsData.AppRuleDetail, RuleID);//Empty RuleDetail Table

            List<TreeListNode> Nodes = GetAllItems(TLItems);
         
            foreach (TreeListNode node in Nodes)
            {
                NICSQLTools.Data.dsData.AppRuleDetailRow row = dsData.AppRuleDetail.NewAppRuleDetailRow();
                row.RuleID = RuleID; row.ItemName = node.GetValue(tlcID).ToString();
                row.Selecting = Convert.ToBoolean(node.GetValue(tlcSelect)); row.Inserting = Convert.ToBoolean(node.GetValue(tlcInsert));
                row.Updateing = Convert.ToBoolean(node.GetValue(tlcUpdate)); row.Deleting = Convert.ToBoolean(node.GetValue(tlcDelete));
                dsData.AppRuleDetail.AddAppRuleDetailRow(row);
            }
            appRuleDetailTableAdapter.Update(dsData.AppRuleDetail);
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
                Nodes.Add(node);
                if (node.HasChildren)
                    GetSubNodes(node, ref Nodes);
                
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
        private void LoadLookup()
        {
            lookupForRuleSummaryTableAdapter.Fill(dsQry.LookupForRuleSummary, Convert.ToInt32(bbiRule.EditValue));
            gridViewLookupValues.BestFitColumns();
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

                    LoadLookup();
                }));
                SplashScreenManager.CloseForm();
            });
        }

        private void treeListMain_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null)
                return;
            NICSQLTools.Data.Linq.vAppDSCategory ds = (NICSQLTools.Data.Linq.vAppDSCategory)treeListMain.GetDataRecordByNode(treeListMain.FocusedNode);
            //LSMSDatasource.QueryableSource = from q in dsLinq.vAppDatasource_LUEs where q.DSCategoryId == ds.DSCategoryId select q;
            //appRuleDatasourceForRuleTableAdapter.Fill(dsData.AppRuleDatasourceForRule, Convert.ToInt32(bbiRule.EditValue), ds.DSCategoryId);
            //XPSCSDS.FixedFilterString = "[DSCategoryId] = " + ds.DSCategoryId;
            Classes.Managers.DataManager.LoadRuleDS(dsQry.DSForRule, Convert.ToInt32(bbiRule.EditValue), ds.DSCategoryId);
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
            NICSQLTools.Data.dsQry.DSForRuleRow row = (NICSQLTools.Data.dsQry.DSForRuleRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            ShowInfo(row.DatasourceID);
        }
        private void gridViewMain_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "EnableRule")
            {
                NICSQLTools.Data.dsQry.DSForRuleRow row = (NICSQLTools.Data.dsQry.DSForRuleRow)((DataRowView)gridViewMain.GetRow(e.RowHandle)).Row;
                bool EnableRule = !row.EnableRule;
                bool output;
                if (EnableRule)
                    output = Classes.Managers.DataManager.AddRuleDS(Convert.ToInt16(bbiRule.EditValue), row.DatasourceID);
                else
                    output = Classes.Managers.DataManager.RemoveRuleDS(Convert.ToInt16(bbiRule.EditValue), row.DatasourceID);
                if (output)
                    MsgDlg.ShowAlert("Rule Updated ...", MsgDlg.MessageType.Success, this.ParentForm);
                else
                    MsgDlg.Show("Rule Updated ...", MsgDlg.MessageType.Error);

            }

        }
        private void repositoryItemButtonEditLookupValuesDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            NICSQLTools.Data.dsQry.LookupForRuleSummaryRow row = (NICSQLTools.Data.dsQry.LookupForRuleSummaryRow)((DataRowView)gridViewLookupValues.GetRow(gridViewLookupValues.FocusedRowHandle)).Row;
            LookupValuesDetailsDlg dlg = new LookupValuesDetailsDlg(Convert.ToInt32(bbiRule.EditValue), row.ID);
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            LoadLookup();
            MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, this.ParentForm);
        }

        #endregion

    }
}
