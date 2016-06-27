using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Data.MSrv.Ticket
{public partial class MSrvTicketVisitAddDlg : XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrvTicketVisitAddDlg));
        readonly NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule;
        readonly NICSQLTools.Data.Linq.dsLinqDataDataContext _dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        readonly NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTableAdapter _adp = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTableAdapter();
        readonly NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTypeTableAdapter _adpTicketVisitType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTypeTableAdapter();
        
        public delegate void RequestRefreshEventhandler(); public event RequestRefreshEventhandler RequestRefresh;
        private bool _closeAfterSave;
        #endregion
        #region - Fun -
        public MSrvTicketVisitAddDlg(NICSQLTools.Data.dsData.AppRuleDetailRow ruleElement)
        {
            InitializeComponent();
            LoadDefaultData();
            _elementRule = ruleElement;
        }
        public MSrvTicketVisitAddDlg(NICSQLTools.Data.dsData.AppRuleDetailRow ruleElement, int ticketId)
        {
            InitializeComponent();
            LoadDefaultData();
            _elementRule = ruleElement;
            lueTicket.EditValue = ticketId;
            lueTicket.RefreshEditValue();
            _closeAfterSave = true;
        }
        private void LoadDefaultData()
        {
            mSrv_TypeTableAdapter.FillByMSrv_TypeConditionId(dsMSrc.MSrv_Type, (int)Classes.MSrvType.TypeCondition.Open_Ticket);
            LSMSTicket.QueryableSource = from q in _dsLinq.vMSrv_Ticket_ByUsers
                                         where q.VisibleToUserId == Classes.Managers.UserManager.defaultInstance.User.UserId
                                         && q.TicketClosed == false
                                         && q.CurrentDepartmentId == (short)Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId
                                         select q;
            LSMSTechnicianId.QueryableSource = from q in _dsLinq.vMSrv_Technician_ByUsers where q.UserId == Classes.Managers.UserManager.defaultInstance.User.UserId select q;
            LSMSPartId.QueryableSource = from q in _dsLinq.MSrv_Parts select q;
            LSMSDmg.QueryableSource = from q in _dsLinq.MSrv_Dmg_Reasons select q;
        }
        public void ActivateRules()
        {
            btnSave.Visible = btnSave.Enabled = _elementRule.Inserting;
        }
        private void ResetDlg()
        {
            lueTechnicianId.EditValue = null;
            deStartDate.EditValue = null;
            deEndDate.EditValue = null;
            tbOpenComment.EditValue = null;
            clbcReason.UnCheckAll();
            lueTicket.EditValue = null;
            dsMSrc.MSrv_TicketVisitPart.Clear();
            gridControlPart.RefreshDataSource(); gridViewPart.RefreshData();
            lueTicket.Focus();
        }
        #endregion
        #region - EventWhnd -
        private void Dlg_Load(object sender, EventArgs e)
        {
            ActivateRules();
        }
        private void lueTicket_EditValueChanged(object sender, EventArgs e)
        {
            if (lueTicket.EditValue == null || lueTicket.EditValue.ToString() == string.Empty)
                return;
            object obj = lueTicket.GetSelectedDataRow();
            if (obj == null)
                return;
            NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser ticket = (NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser)obj;
            deStartDate.EditValue = deEndDate.EditValue = ticket.OpenDate;
            lblContactPerson.Text = ticket.IssueContactPerson;
        }
        private void deDate_EditValueChanged(object sender, EventArgs e)
        {
            deStartDate.EditValue = deDate.DateTime.Add(deStartDate.DateTime.TimeOfDay);
            deEndDate.EditValue = deDate.DateTime.Add(deEndDate.DateTime.TimeOfDay);
        }
        private void gridViewPart_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (lueTicket.EditValue == null || lueTicket.EditValue.ToString() == string.Empty)
            {
                MsgDlg.Show("Please select a Ticket before adding a part", MsgDlg.MessageType.Error);
                return;
            }
            NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow row = (NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow)((DataRowView)gridViewPart.GetRow(gridViewPart.FocusedRowHandle)).Row;
            
            row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
            row.DateIn = Classes.Managers.DataManager.defaultInstance.ServerDateTime;
            row.TicketVisitId = Convert.ToInt32(lueTicket.EditValue);
            row.Quantity = 1;
            row.ActualPrice = 0;
        }
        private void repositoryItemLookUpEditPartId_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = (LookUpEdit)sender;
            NICSQLTools.Data.Linq.MSrv_Part part = (NICSQLTools.Data.Linq.MSrv_Part)lue.GetSelectedDataRow();
            NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow gridrow = (NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow)((DataRowView)gridViewPart.GetRow(gridViewPart.FocusedRowHandle)).Row;
            if (part.PartPrice != null) gridrow.ActualPrice = (double)part.PartPrice * gridrow.Quantity;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProviderMain.Validate() || clbcReason.CheckedItemsCount == 0)
             {
                if (clbcReason.CheckedItemsCount == 0)
                    MsgDlg.ShowAlert("Please select ticket reason", MsgDlg.MessageType.Warn, this);
                return;
            }
            try
            {
                int ticketVisitId = Convert.ToInt32(_adp.NewId());
                int ticketId = Convert.ToInt32(lueTicket.EditValue);
                int technicianId = Convert.ToInt32(lueTechnicianId.EditValue);
                string comment = string.Empty;
                if (tbOpenComment.EditValue != null)
                    comment = tbOpenComment.EditValue.ToString();
                DateTime serverDatetime = Classes.Managers.DataManager.defaultInstance.ServerDateTime;
                // Insert Visit
                int effected = _adp.Insert(ticketVisitId, ticketId, technicianId, deStartDate.DateTime, deEndDate.DateTime, comment
                    , Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime, (int?)lueDamage.EditValue);
                if (effected <= 0)
                {
                    MsgDlg.Show("No Data Saved", MsgDlg.MessageType.Error);
                    return;
                }
                // Insert Reasons
                string reasonMsg = string.Empty;
                foreach (object item in clbcReason.CheckedItems)
                {
                    NICSQLTools.Data.dsMSrc.MSrv_TypeRow ticketType = (NICSQLTools.Data.dsMSrc.MSrv_TypeRow)((DataRowView)item).Row;
                    _adpTicketVisitType.Insert(ticketVisitId, ticketType.MSrvTypeId, Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime);
                    reasonMsg += ticketType.MSrvType + ", ";
                }
                reasonMsg = reasonMsg.Substring(0, reasonMsg.Length - 2);
                //Add Action
                Classes.MSrv.CreateAction(Classes.MSrvType.ActionType.Visit_Added, ticketId, "Visit Added with reasons (" + reasonMsg + ") At " + deEndDate.DateTime);
                // Insert Parts
                foreach (var item in dsMSrc.MSrv_TicketVisitPart)
                {
                    item.TicketVisitId = ticketVisitId;
                    item.EndEdit();}      
                mSrv_TicketVisitPartTableAdapter.Update(dsMSrc.MSrv_TicketVisitPart);
                MsgDlg.ShowAlert("Data Saved ..", MsgDlg.MessageType.Success, this);
                ResetDlg();
                if (RequestRefresh != null)
                    RequestRefresh();
                if (MsgDlg.Show("Do you want to close ticket ?", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser ticket = (from q in _dsLinq.vMSrv_Ticket_ByUsers where q.TicketId == ticketId select q).ToArray()[0];
                    MSrv_TicketCloseDlg dlg = new MSrv_TicketCloseDlg(null, ticket);
                    dlg.ShowDialog();
                    Close();
                }
                if (_closeAfterSave)Close();
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }

        }
        #endregion

        
    }
}