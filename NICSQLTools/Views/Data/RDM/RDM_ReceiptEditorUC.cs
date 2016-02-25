using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid;

namespace NICSQLTools.Views.Data.RDM
{
    public partial class RDM_ReceiptEditorUC : XtraUserControl
    {

        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(NICSQLTools.Views.Data.RDM.RDM_ReceiptEditorUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        NICSQLTools.Data.dsRDMTableAdapters.RDM_ReceiptTableAdapter adp = new NICSQLTools.Data.dsRDMTableAdapters.RDM_ReceiptTableAdapter();
        #endregion
        #region - Fun -
        public RDM_ReceiptEditorUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
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
                    LSMSData.QueryableSource = from q in dsLinq.vRDM_Receipt_ByUsers 
                                               where q.VisibleToUserId == Classes.Managers.UserManager.defaultInstance.User.UserId 
                                               select q;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        void ReloadGrid()
        {
            LSMSData.Reload();
        }
        public void ActivateRules()
        {
            //Insert
            if (!_elementRule.Inserting)
                bbiAddNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //Update
            repositoryItemButtonEditEdit.ReadOnly = !_elementRule.Updateing;
            //Delete
            repositoryItemButtonEditDelete.ReadOnly = !_elementRule.Deleting;
        }
        #endregion
        #region -  EventWhnd - 
        private void RouteEditorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            ActivateRules();
        }
        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RDM_ReceiptAddDlg dlg = new RDM_ReceiptAddDlg();
            dlg.RequestRefresh += () => { ReloadGrid(); };
            dlg.ShowDialog();
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
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReloadGrid();   
        }
        private void gridViewMain_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //switch (e.Column.Name)
            //{
            //    case "gcAddVisit":
            //    case "gcClose":
            //    case "gcChat":
            //        if (e.RepositoryItem.GetType() != typeof(DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit))
            //            return;
            //        NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser row1 = (NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser)gridViewMain.GetRow(e.RowHandle);
            //        if (row1 == null)
            //            return;
            //        DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit be = (DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit)e.RepositoryItem;
            //        if (row1.CurrentDepartmentId != (short)Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId && e.Column.Name != "gcChat")
            //            be.Buttons[0].Enabled = false;
            //        break;
            //    default:
            //        break;
            //}
        }
        private void gridViewMain_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            //switch (e.Column.Name)
            //{
            //    case "gcAddVisit":
            //    case "gcClose":
            //    case "gcChat":
            //        if (e.RepositoryItem.GetType() != typeof(DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit))
            //            return;
            //        NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser row1 = (NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser)gridViewMain.GetRow(e.RowHandle);
            //        if (row1 == null)
            //            return;
            //        DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit be = (DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit)e.RepositoryItem;
            //        if (row1.CurrentDepartmentId != (short)Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId && e.Column.Name != "gcChat")
            //            be.Buttons[0].Enabled = false;
            //        break;
            //    default:
            //        break;
            //}
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                NICSQLTools.Data.Linq.vRDM_Receipt_ByUser row = (NICSQLTools.Data.Linq.vRDM_Receipt_ByUser)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
                RDM_ReceiptEditDlg dlg = new RDM_ReceiptEditDlg(row);
                dlg.ShowDialog();
                ReloadGrid();
            }
            catch (Exception ex)
            {
                MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                NICSQLTools.Data.Linq.vRDM_Receipt_ByUser row = (NICSQLTools.Data.Linq.vRDM_Receipt_ByUser)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
                if (MsgDlg.Show("Do you want to delete selected row ?", MsgDlg.MessageType.Question) == DialogResult.No)
                    return;
                adp.Delete(row.RDM_ID);
                ReloadGrid();
                MsgDlg.ShowAlert("Row Deleted ..", MsgDlg.MessageType.Success, this.ParentForm); //(Form)Parent.Parent.Parent

            }
            catch (Exception ex)
            {
                MsgDlg.Show(String.Format("Deleting Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        #endregion
        
    }
}
