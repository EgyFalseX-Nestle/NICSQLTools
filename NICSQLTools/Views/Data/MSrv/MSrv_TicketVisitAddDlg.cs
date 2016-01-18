using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Data
{
    public partial class MSrv_TicketVisitAddDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrv_TicketVisitAddDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTableAdapter adp = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTableAdapter();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTypeTableAdapter adpTicketVisitType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTypeTableAdapter();
        public delegate void RequestRefreshEventhandler(); public event RequestRefreshEventhandler RequestRefresh;
        #endregion
        #region - Fun -
        public MSrv_TicketVisitAddDlg()
        {
            InitializeComponent();
        }
        public MSrv_TicketVisitAddDlg(int TicketId)
        {
            InitializeComponent();
            lueTicket.EditValue = TicketId;
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
            this.mSrv_TypeTableAdapter.Fill(this.dsMSrc.MSrv_Type);
            LSMSTicket.QueryableSource = from q in dsLinq.vMSrv_Ticket_ByUsers where q.VisibleToUserId == Classes.Managers.UserManager.defaultInstance.User.UserId && q.TicketClosed == false select q;
            LSMSTechnicianId.QueryableSource = from q in dsLinq.vMSrv_Technician_ByUsers where q.UserId == Classes.Managers.UserManager.defaultInstance.User.UserId select q;
            LSMSPartId.QueryableSource = from q in dsLinq.MSrv_Parts select q;
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
        }
        private void gridViewPart_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (lueTicket.EditValue == null || lueTicket.EditValue.ToString() == string.Empty)
            {
                MsgDlg.Show("Please select a Ticket before adding a part", MsgDlg.MessageType.Error);
                return;
            }
            NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow row = (NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow)((DataRowView)gridViewPart.GetRow(gridViewPart.FocusedRowHandle)).Row;
            
            row.UserIn = NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId;
            row.DateIn = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;
            row.TicketVisitId = Convert.ToInt32(lueTicket.EditValue);
            row.ActualPrice = 0;
        }
        private void repositoryItemLookUpEditPartId_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = (LookUpEdit)sender;
            NICSQLTools.Data.Linq.MSrv_Part part = (NICSQLTools.Data.Linq.MSrv_Part)lue.GetSelectedDataRow();
            NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow Gridrow = (NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow)((DataRowView)gridViewPart.GetRow(gridViewPart.FocusedRowHandle)).Row;
            Gridrow.ActualPrice = (double)part.PartPrice;
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
                int TicketVisitId = (int)adp.NewId();
                int TicketId = Convert.ToInt32(lueTicket.EditValue);
                int TechnicianId = Convert.ToInt32(lueTechnicianId.EditValue);
                string Comment = string.Empty;
                if (tbOpenComment.EditValue != null)
                    Comment = tbOpenComment.EditValue.ToString();
                DateTime serverDatetime = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;
                // Insert Visit
                int Effected = adp.Insert(TicketVisitId, TicketId, TechnicianId, deStartDate.DateTime, deEndDate.DateTime, Comment
                    , NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime);
                if (Effected <= 0)
                {
                    MsgDlg.Show("No Data Saved", MsgDlg.MessageType.Error);
                    return;
                }
                // Insert Reasons
                foreach (object item in clbcReason.CheckedItems)
                {
                    NICSQLTools.Data.dsMSrc.MSrv_TypeRow TicketType = (NICSQLTools.Data.dsMSrc.MSrv_TypeRow)((DataRowView)item).Row;
                    adpTicketVisitType.Insert(TicketVisitId, TicketType.MSrvTypeId, NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime);
                }
                // Insert Parts
                mSrv_TicketVisitPartTableAdapter.Update(dsMSrc.MSrv_TicketVisitPart);
                MsgDlg.ShowAlert("Data Saved ..", MsgDlg.MessageType.Success, this);
                ResetDlg();
                if (RequestRefresh != null)
                    RequestRefresh();
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                NICSQLTools.Classes.Core.LogException(Logger, ex, NICSQLTools.Classes.Core.ExceptionLevelEnum.General, NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId);
            }

        }
        #endregion

    }
}