using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid;

namespace NICSQLTools.Views.Data.MSrv
{
    public partial class MSrv_TicketEditorUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(NICSQLTools.Views.Data.MSrv.MSrv_TicketEditorUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        #endregion
        #region - Fun -
        public MSrv_TicketEditorUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
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
                    LSMSData.QueryableSource = from q in dsLinq.vMSrv_Ticket_ByUsers 
                                               where q.VisibleToUserId == Classes.Managers.UserManager.defaultInstance.User.UserId 
                                               && q.TicketClosed == false 
                                               //&& q.CurrentDepartmentId == Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId
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
            if (!_elementRule.Inserting)
            {
                bbiAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                repositoryItemButtonEditChat.ReadOnly = true;
            }
            
            repositoryItemButtonEditAddVisit.ReadOnly = !_elementRule.Updateing;
            
            repositoryItemButtonEditChat.ReadOnly = !_elementRule.Deleting;
        }
        #endregion
        #region -  EventWhnd - 
        private void RouteEditorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            ActivateRules();
        }
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
            //    return;
            //DevExpress.Xpo.AsyncCommitCallback CommitCallBack = (o) =>
            //{
            //    SplashScreenManager.CloseForm();
            //    if (o == null)
            //    {
            //        MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
            //        Logger.Info("Data Saved ...");
            //    }
            //    else
            //    {
            //        MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, o.Message), MsgDlg.MessageType.Error, o);
            //        Classes.Core.LogException(Logger, o.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            //    }
            //};

            //SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            //UOW.CommitTransactionAsync(CommitCallBack);
            MSrv_TicketAddDlg dlg = new MSrv_TicketAddDlg();
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
        private void repositoryItemButtonEditAddVisit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser ticket = (NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
                if (ticket.CurrentDepartmentId != Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId)
                {
                    MsgDlg.Show("Controled by another department", MsgDlg.MessageType.Info);
                    return;
                }
                MSrv_TicketVisitAddDlg dlg = new MSrv_TicketVisitAddDlg(ticket.TicketId);
                dlg.ShowDialog();
                ReloadGrid();
            }
            catch (Exception ex)
            {
                MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        private void repositoryItemButtonEditChat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser ticket = (NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
                MSrv_TicketChatDlg dlg = new MSrv_TicketChatDlg(ticket.TicketId);
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        private void repositoryItemButtonEditCloseTicket_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser ticket = (NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
                if (ticket.CurrentDepartmentId != Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId)
                {
                    MsgDlg.Show("Controled by another department", MsgDlg.MessageType.Info);
                    return;
                }
                MSrv_TicketCloseDlg dlg = new MSrv_TicketCloseDlg(ticket);
                if (dlg.ShowDialog() == DialogResult.OK)
                    ReloadGrid();
            }
            catch (Exception ex)
            {
                MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        private void gridViewMain_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "gcAddVisit":
                case "gcClose":
                case "gcChat":
                    if (e.RepositoryItem.GetType() != typeof(DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit))
                        return;
                    NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser row1 = (NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser)gridViewMain.GetRow(e.RowHandle);
                    if (row1 == null)
                        return;
                    DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit be = (DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit)e.RepositoryItem;
                    if (row1.CurrentDepartmentId != Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId && e.Column.Name != "gcChat")
                        be.Buttons[0].Enabled = false;
                    break;
                default:
                    break;
            }
        }
        private void gridViewMain_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "gcAddVisit":
                case "gcClose":
                case "gcChat":
                    if (e.RepositoryItem.GetType() != typeof(DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit))
                        return;
                    NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser row1 = (NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser)gridViewMain.GetRow(e.RowHandle);
                    if (row1 == null)
                        return;
                    DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit be = (DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit)e.RepositoryItem;
                    if (row1.CurrentDepartmentId != Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId && e.Column.Name != "gcChat")
                        be.Buttons[0].Enabled = false;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
