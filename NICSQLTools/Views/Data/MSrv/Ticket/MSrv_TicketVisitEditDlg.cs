using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Data.MSrv.Ticket
{
    public partial class MSrv_TicketVisitEditDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrv_TicketVisitEditDlg));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTableAdapter adp = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTableAdapter();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTypeTableAdapter adpTicketVisitType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketVisitTypeTableAdapter();
        public delegate void RequestRefreshEventhandler(); public event RequestRefreshEventhandler RequestRefresh;
        NICSQLTools.Data.Linq.vMSrv_TicketVisit _visit;
        #endregion
        #region - Fun -
        public MSrv_TicketVisitEditDlg(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement, NICSQLTools.Data.Linq.vMSrv_TicketVisit Visit)
        {
            InitializeComponent();
            _elementRule = RuleElement;
            LSMSTechnicianId.QueryableSource = from q in dsLinq.vMSrv_Technician_ByUsers where q.UserId == Classes.Managers.UserManager.defaultInstance.User.UserId select q;
            LSMSPartId.QueryableSource = from q in dsLinq.MSrv_Parts select q;

            _visit = Visit;
            lueTicket.EditValue = Visit.TicketId; lueTicket.Enabled = false;
            layoutControlGroupTicket.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            mSrv_TypeTableAdapter.FillByMSrv_TypeConditionId(dsMSrc.MSrv_Type, (int)Classes.MSrvType.TypeCondition.Open_Ticket);
            adp.FillByID(dsMSrc.MSrv_TicketVisit, _visit.TicketVisitId);//Load Visit
            mSrv_TicketVisitPartTableAdapter.FillByTicketVisitId(dsMSrc.MSrv_TicketVisitPart, _visit.TicketVisitId);// Load Parts
            adpTicketVisitType.FillByTicketVisitId(dsMSrc.MSrv_TicketVisitType, _visit.TicketVisitId);// Load Types
            
        }
        public void ActivateRules()
        {
            btnSave.Visible = btnSave.Enabled = _elementRule.Updateing;
        }
        private void CtrBind()
        {
            NICSQLTools.Data.dsMSrc.MSrv_TicketVisitRow row = dsMSrc.MSrv_TicketVisit[0];
            lueTechnicianId.DataBindings.Add("EditValue", row, "TechnicianId");
            deStartDate.DataBindings.Add("EditValue", row, "StartDate");
            deEndDate.DataBindings.Add("EditValue", row, "EndDate");
            if (row.IsVisitCommentNull())
                row.VisitComment = string.Empty;
            tbVisitComment.DataBindings.Add("EditValue", row, "VisitComment");
            
            //Fill Types
            foreach (NICSQLTools.Data.dsMSrc.MSrv_TicketVisitTypeRow type in dsMSrc.MSrv_TicketVisitType)
            {
                for (int i = 0; i < dsMSrc.MSrv_Type.Count; i++)
                {
                    if (Convert.ToInt16(clbcReason.GetItemValue(i)) == type.MSrvTypeId)
                    {
                        clbcReason.SetItemChecked(i, true);
                    }
                }
                //foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in clbcReason.Items)
                //{
                //    if ((short)item.Value == type.MSrvTypeId)
                //    {
                //        item.CheckState = CheckState.Checked;
                //        break;
                //    }
                //}
            }
            lueTechnicianId.Focus();
        }
        #endregion
        #region - EventWhnd -
        private void Dlg_Load(object sender, EventArgs e)
        {
            ActivateRules();
            CtrBind();
        }
        private void gridViewPart_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow row = (NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow)((DataRowView)gridViewPart.GetRow(gridViewPart.FocusedRowHandle)).Row;
            
            row.UserIn = NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId;
            row.DateIn = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;
            row.TicketVisitId = (int)_visit.TicketId;
            row.Quantity = 1;
            row.ActualPrice = 0;
        }
        private void repositoryItemLookUpEditPartId_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = (LookUpEdit)sender;
            NICSQLTools.Data.Linq.MSrv_Part part = (NICSQLTools.Data.Linq.MSrv_Part)lue.GetSelectedDataRow();
            NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow Gridrow = (NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow)((DataRowView)gridViewPart.GetRow(gridViewPart.FocusedRowHandle)).Row;
            Gridrow.ActualPrice = (double)part.PartPrice * Gridrow.Quantity;
        }
        private void gridViewPart_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow Gridrow = (NICSQLTools.Data.dsMSrc.MSrv_TicketVisitPartRow)((DataRowView)gridViewPart.GetRow(gridViewPart.FocusedRowHandle)).Row;
            if (Gridrow.IsNull("PartId"))
                return;
            if (e.Column.FieldName == "Quantity")
            {
                double price = (double)Classes.Managers.DataManager.adpMSrvQry.Get_Part_PartPrice(Gridrow.PartId);
                Gridrow.ActualPrice = price * Gridrow.Quantity;
            }
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
                DateTime serverDatetime = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;

                NICSQLTools.Data.dsMSrc.MSrv_TicketVisitRow row = dsMSrc.MSrv_TicketVisit[0];
                row.DateIn = serverDatetime;
                row.UserIn = NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsMSrc.MSrv_TicketVisit[0].EndEdit();
                // Insert Visit
                int Effected = adp.Update(dsMSrc.MSrv_TicketVisit[0]);
                if (Effected <= 0)
                {
                    MsgDlg.Show("No Data Saved", MsgDlg.MessageType.Error);
                    return;
                }
                
                // Insert Reasons
                adpTicketVisitType.DeleteByTicketVisitId(_visit.TicketVisitId);// Delete All Visits before Adding New
                foreach (object item in clbcReason.CheckedItems)
                {
                    NICSQLTools.Data.dsMSrc.MSrv_TypeRow TicketType = (NICSQLTools.Data.dsMSrc.MSrv_TypeRow)((DataRowView)item).Row;
                    adpTicketVisitType.Insert(_visit.TicketVisitId, TicketType.MSrvTypeId, NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime);
                }
                // Insert Parts
                mSrv_TicketVisitPartTableAdapter.Update(dsMSrc.MSrv_TicketVisitPart);
                MsgDlg.ShowAlert("Data Saved ..", MsgDlg.MessageType.Success, this);
                if (RequestRefresh != null)
                    RequestRefresh();
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
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