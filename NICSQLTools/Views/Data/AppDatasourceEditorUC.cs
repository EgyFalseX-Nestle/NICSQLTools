using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using NICSQLTools.Classes.Managers;
using NICSQLTools.Views.Main;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;
using DevExpress.XtraGrid;

namespace NICSQLTools.Views.Data
{
    public partial class AppDatasourceEditorUC : XtraUserControl
    {
        #region - Variables -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(AppDatasourceEditorUC));
        private NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.dsDataTableAdapters.AppDSCategoryTableAdapter adpCategory = new NICSQLTools.Data.dsDataTableAdapters.AppDSCategoryTableAdapter();
        rtfTextEditorFrm Frm;
        GridHitInfo downHitInfo = null;

        #endregion
        #region - Functions -
        public AppDatasourceEditorUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
            Frm = new rtfTextEditorFrm(string.Empty);
        }
        void LoadData()
        {
            XPSCSCat.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
            treeListMain.DataSource = XPSCSCat;
            LSMSAppDatasourceType.QueryableSource = from q in dsLinq.AppDatasourceType_LUEs select q;
            LSMSLookup.QueryableSource = from q in dsLinq.AppDatasourceLookups select q;
        }
        public void ActivateRules()
        {
            XPSCSCat.AllowNew = _elementRule.Inserting;
            XPSCSCat.AllowRemove = _elementRule.Deleting;
            XPSCSCat.AllowEdit = _elementRule.Updateing;

            if (!_elementRule.Inserting)
                bbiAddNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (!_elementRule.Deleting)
                bbiDeleteNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }
        private void LoadParamGrid()
        {
            object id = null;
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewDS.GetRow(gridViewDS.FocusedRowHandle);
            //DataRowView row = (DataRowView)gridViewDS.GetRow(gridViewDS.FocusedRowHandle);
            if (row == null)
                id = -1;
            else
                id = row.GetMemberValue("DatasourceID");
            gridViewParam.ShowLoadingPanel();
            XPSCSParam.FixedFilterString = "[DatasourceID] = " + id;
            sessionParam.DropIdentityMap();
            XPSCSParam.Reload();
            gridViewParam.RefreshData();
            gridViewParam.HideLoadingPanel();
        }
        #endregion
        #region - EventWhnd -
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            ActivateRules();
            LoadData();
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
            sessionCat.DropIdentityMap();
            XPSCSCat.Reload();
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
        private void treeListMain_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            object id = null;
            if (treeListMain.FocusedNode == null)
                id = -1;
            else
                id = e.Node.GetValue("DSCategoryId");

            gridViewDS.ShowLoadingPanel();
            XPSCSDS.FixedFilterString = "[DSCategoryId] = " + id;
            sessionDS.DropIdentityMap();
            XPSCSDS.Reload();
            gridViewDS.RefreshData();
            gridViewDS.HideLoadingPanel();
            LoadParamGrid();
        }
        private void treeListMain_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            treeListMain.BestFitColumns();
        }
        private void gridViewDS_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewDS.GetRow(e.RowHandle));
            if (row != null && row.GetMemberValue("DatasourceID") != null)
            {
                LoadParamGrid();
            }
        }
        private void gridViewDS_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            object id = null;
            if (treeListMain.FocusedNode == null)
            {
                MsgDlg.Show("You Must Select Category To Add Datasource", MsgDlg.MessageType.Error);
                return;
            }
            else
                id = treeListMain.FocusedNode.GetValue("DSCategoryId");

            DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewDS.GetRow(e.RowHandle));
            row.SetMemberValue("DSCategoryId", id);
            row.SetMemberValue("UserIn", Classes.Managers.UserManager.defaultInstance.User.UserId);
            row.SetMemberValue("DateIn", Classes.Managers.DataManager.defaultInstance.ServerDateTime);
        }
        private void gridViewParam_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject rowDS = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewDS.GetRow(gridViewDS.FocusedRowHandle));
            //NICSQLTools.Data.dsQry.vAppDatasourceForUserRow rowDS = (NICSQLTools.Data.dsQry.vAppDatasourceForUserRow)((DataRowView)gridViewDS.GetRow(gridViewDS.FocusedRowHandle)).Row;
            if (rowDS == null)
            {
                MsgDlg.Show("You Must Select Datasource To Add Paramter", MsgDlg.MessageType.Error);
                return;
            }
            DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewParam.GetRow(e.RowHandle));
            row.SetMemberValue("DatasourceID", Convert.ToInt32(rowDS.GetMemberValue("DatasourceID")));
        }
        private void sessionDS_BeforeCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            DevExpress.Xpo.Helpers.ObjectSet Rows = (DevExpress.Xpo.Helpers.ObjectSet)e.Session.GetObjectsToSave();
            DateTime DateIn = DataManager.defaultInstance.ServerDateTime;
            foreach (DevExpress.Xpo.Metadata.XPDataTableObject item in Rows)
            {
                item.SetMemberValue("UserIn", UserManager.defaultInstance.User.UserId);
                item.SetMemberValue("DateIn", DateIn);
                
            }
            
        }
        private void sessionParam_BeforeCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            DevExpress.Xpo.Helpers.ObjectSet Rows = (DevExpress.Xpo.Helpers.ObjectSet)e.Session.GetObjectsToSave();
            DateTime DateIn = DataManager.defaultInstance.ServerDateTime;
            foreach (DevExpress.Xpo.Metadata.XPDataTableObject item in Rows)
            {
                item.SetMemberValue("UserIn", UserManager.defaultInstance.User.UserId);
                item.SetMemberValue("DateIn", DateIn);
            }
        }
        private void gridControlDS_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (MsgDlg.Show("Do you want to delete selected rows ?", MsgDlg.MessageType.Question) == DialogResult.No)
                    e.Handled = true;
            }
        }
        private void gridControlParam_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (MsgDlg.Show("Do you want to delete selected rows ?", MsgDlg.MessageType.Question) == DialogResult.No)
                    e.Handled = true;
            }
        }
        private void repositoryItemButtonEditParamDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MsgDlg.Show("Do you want to delete selected row ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            gridViewParam.DeleteRow(gridViewParam.FocusedRowHandle);
        }
        private void repositoryItemButtonEditDesc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                gridViewDS.ShowLoadingPanel();
                System.Threading.ThreadPool.QueueUserWorkItem((o) =>
                {
                    try
                    {
                        DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewDS.GetRow(gridViewDS.FocusedRowHandle));
                        object obj = row.GetMemberValue("Desc");
                        if (obj == null)
                            obj = string.Empty;
                        else
                        {
                            obj = System.Text.Encoding.Unicode.GetString(DataManager.DecompressFile((byte[])obj).ToArray());
                        }
                        Invoke(new MethodInvoker(() =>
                        {
                            Frm = new rtfTextEditorFrm(obj.ToString());
                            if (Frm.ShowDialog() == DialogResult.OK)
                            {
                                byte[] Data;
                                if (Frm.TextData != string.Empty)
                                    Data = DataManager.CompressFile(System.Text.Encoding.Unicode.GetBytes(Frm.TextData)).ToArray();
                                else
                                    Data = null;
                                row.SetMemberValue("Desc", Data);
                                row.Save();
                            }
                        }));
                    }
                    catch (Exception ex)
                    {
                        MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                        Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                    }
                    Invoke(new MethodInvoker(() => { gridViewDS.HideLoadingPanel(); }));
                });
                
            }
        }

        private void treeListMain_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(int)) || e.Data.GetDataPresent(typeof(DevExpress.XtraTreeList.Nodes.TreeListNode)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private void treeListMain_DragDrop(object sender, DragEventArgs e)
        {
            DevExpress.XtraTreeList.TreeList tree = sender as DevExpress.XtraTreeList.TreeList;
            Point p = tree.PointToClient(new Point(e.X, e.Y));
            DevExpress.XtraTreeList.Nodes.TreeListNode node = tree.CalcHitInfo(p).Node;
            if (node == null)
                return;
            object dsID = e.Data.GetData(typeof(int));
            if (dsID == null)
                return;
            Classes.Managers.DataManager.adpQry.UpdateDatasourceCategory((int)node.GetValue("DSCategoryId"), (int)dsID);
            treeListMain.FocusedNode = node;
        }
        private void gridViewDS_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
                downHitInfo = hitInfo;
        }
        private void gridViewDS_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewDS.GetRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row.GetMemberValue("DatasourceID"), DragDropEffects.Move);
                    //if (row != null && row.GetMemberValue("DatasourceID") != null)

                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }
        
        #endregion
        
    }
}
