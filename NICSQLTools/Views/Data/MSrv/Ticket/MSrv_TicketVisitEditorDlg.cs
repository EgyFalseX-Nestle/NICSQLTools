using System;
using System.Linq;
using System.Windows.Forms;

namespace NICSQLTools.Views.Data.MSrv.Ticket
{
    public partial class MSrv_TicketVisitEditorDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrv_TicketVisitEditorDlg));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser _ticket;
        #endregion
        #region - Fun -
        public MSrv_TicketVisitEditorDlg(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement, NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser ticket)
        {
            InitializeComponent();
            _elementRule = RuleElement;
            _ticket = ticket;
            LSMSData.QueryableSource = from q in dsLinq.vMSrv_TicketVisits where q.TicketId == _ticket.TicketId select q;
        }
        public void ActivateRules()
        {
            if (!_elementRule.Inserting)
            {
                btnAdd.Visible = btnAdd.Enabled = false;
            }
            if (!_elementRule.Updateing)
            {
                repositoryItemButtonEditEdit.ReadOnly = true;
            }
            repositoryItemButtonEditDelete.ReadOnly = true;
        }
        void ReloadGrid()
        {
            LSMSData.Reload();
        }
        #endregion
        #region -  EventWhnd -
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ticket.CurrentDepartmentId != (short)Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId)
                {
                    MsgDlg.Show("Controled by another department", MsgDlg.MessageType.Info);
                    return;
                }
                MSrvTicketVisitAddDlg dlg = new MSrvTicketVisitAddDlg(_elementRule, _ticket.TicketId);
                dlg.ShowDialog();
                ReloadGrid();
            }
            catch (Exception ex)
            {
                MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (_ticket.CurrentDepartmentId != (short)Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId)
            {
                MsgDlg.Show("Controled by another department", MsgDlg.MessageType.Info);
                return;
            }
            NICSQLTools.Data.Linq.vMSrv_TicketVisit row = (NICSQLTools.Data.Linq.vMSrv_TicketVisit)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            MSrv_TicketVisitEditDlg dlg = new MSrv_TicketVisitEditDlg(_elementRule, row);
            dlg.ShowDialog();
            ReloadGrid();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (_ticket.CurrentDepartmentId != (short)Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId)
            {
                MsgDlg.Show("Controled by another department", MsgDlg.MessageType.Info);
                return;
            }
        }
       
        #endregion

    }
}