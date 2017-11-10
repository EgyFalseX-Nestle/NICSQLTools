using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Data.MSrv.Ticket
{
    public partial class MSrvTicketAddDlg : XtraForm
    {
 
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrvTicketAddDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext _dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter _adp = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter _adpTicketType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter();
        public delegate void RequestRefreshEventhandler(); public event RequestRefreshEventhandler RequestRefresh;
        NICSQLTools.Data.dsMSrcTableAdapters.vMSrv_CustomerTableAdapter _adpCus = new NICSQLTools.Data.dsMSrcTableAdapters.vMSrv_CustomerTableAdapter();
        #endregion
        #region - Fun -
        public MSrvTicketAddDlg()
        {
            InitializeComponent();
            //LSMSCustomerId.QueryableSource = from c in dsLinq.vMSrv_Customers 
            //                                 join ss in dsLinq.AppRuleSalesDistrict3s on c.SalesDistrict3Id equals ss.SalesDistrict3Id 
            //                                 join userrole in dsLinq.AppUserRules on ss.RuleID equals userrole.RuleId
            //                                 where userrole.UserId == Classes.Managers.UserManager.defaultInstance.User.UserId
            //                                 select new { c.Customer};
            LSMSMSrvTypeId.QueryableSource = from q in _dsLinq.MSrv_Types where q.MSrv_TypeConditionId == (int)Classes.MSrvType.TypeCondition.Open_Ticket select q;
            //LSMSCustomerId.QueryableSource = from q in dsLinq.vMSrv_Customers where q.UserId == Classes.Managers.UserManager.defaultInstance.User.UserId select q;
        }
        private void ResetDlg()
        {
            tbCustomerId.EditValue = null;
            tbEquipmentSerial.EditValue = null;

            tbIssueContactPerson.EditValue = null;
            tbIssueContactPhone.EditValue = null;
            tbIssueContactPhone2.EditValue = null;
            tbIssueAddress.EditValue = null;

            tbOpenComment.EditValue = null;
            clbcReason.UnCheckAll();

            tbCustomerId.Focus();
        }
        #endregion
        #region - EventWhnd -
        private void Dlg_Load(object sender, EventArgs e)
        {
        }
        private void tbCustomerId_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private void tbCustomerId_Properties_Validating(object sender, CancelEventArgs e)
        {
            tbIssueContactPerson.EditValue = null; tbIssueAddress.EditValue = null;
            tbIssueContactPhone.EditValue = null; tbIssueContactPhone2.EditValue = null;

            if (tbCustomerId.EditValue == null || tbCustomerId.EditValue.ToString() == string.Empty)
                return;
            
            NICSQLTools.Data.dsMSrc.vMSrv_CustomerDataTable tbl = _adpCus.GetDataById_User(tbCustomerId.EditValue.ToString(), Classes.Managers.UserManager.defaultInstance.User.UserId);
            if (tbl.Count == 0)
            {
                MsgDlg.Show("Customer not found or you don't have role", MsgDlg.MessageType.Info);
                e.Cancel = true;
                return;
            }
            tbIssueContactPerson.EditValue = tbl[0].IsDisplayNameNull() ? null : tbl[0].DisplayName;
            tbIssueAddress.EditValue = tbl[0].IsAddressNull() ? null : tbl[0].Address;
            tbIssueContactPhone.EditValue = tbl[0].IsTelephoneNull() ? null: tbl[0].Telephone;
            tbIssueContactPhone2.EditValue = tbl[0].IsSupervisor_TelephoneNull() ? null : tbl[0].Supervisor_Telephone;
            //Get 1st Freezer
            tbEquipmentSerial.EditValue = Classes.Managers.DataManager.adpMSrvQry.GetCusEqpSerial(tbl[0].Customer);
        }
        private void btnSearchSerial_Click(object sender, EventArgs e)
        {
            if (tbCustomerId.EditValue != null && tbCustomerId.EditValue.ToString() != string.Empty)
            {
                MSrv.SelectEquipmentDlg dlg = new MSrv.SelectEquipmentDlg(tbCustomerId.EditValue.ToString());
                if (dlg.ShowDialog() == DialogResult.OK)
                    tbEquipmentSerial.EditValue = dlg._serialNumber;
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
            if ((bool)Classes.Managers.DataManager.adpMSrvQry.CustomerOpen(tbCustomerId.EditValue.ToString()))
            {
                MsgDlg.Show("Customer already have opened Ticket", MsgDlg.MessageType.Info);return;
            }
            try
            {
                int ticketId = (int)_adp.NewId();
                DateTime serverDatetime = Classes.Managers.DataManager.defaultInstance.ServerDateTime;
                NICSQLTools.Data.dsMSrc.vMSrv_CustomerDataTable tbl = _adpCus.GetDataById_User(tbCustomerId.EditValue.ToString(), Classes.Managers.UserManager.defaultInstance.User.UserId);
                if (tbl.Count == 0)
                {
                    MsgDlg.Show("Customer not found or you don't have role", MsgDlg.MessageType.Info);
                    return;
                }
                
                string comment = string.Empty;
                if (tbOpenComment.EditValue != null)
                    comment = tbOpenComment.EditValue.ToString();
                int effected = _adp.Insert(ticketId, tbCustomerId.EditValue.ToString(), tbEquipmentSerial.EditValue.ToString(), tbl[0].Route, serverDatetime, comment, Convert.ToInt16(tbl[0].SalesDistrict3Id)
                    , tbl[0].PlantNumber, tbIssueContactPerson.EditValue.ToString(), tbIssueAddress.EditValue.ToString(), tbIssueContactPhone.EditValue.ToString(), tbIssueContactPhone2.EditValue.ToString()
                    , null, (short)Classes.MSrvType.MSrvDepartment.Logistics, false, string.Empty, null, null, null, null, Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime);
                if (effected > 0)
                {
                    foreach (object item in clbcReason.CheckedItems)
                    {
                        NICSQLTools.Data.Linq.MSrv_Type ticketType = (NICSQLTools.Data.Linq.MSrv_Type)item;
                        _adpTicketType.Insert(ticketId, ticketType.MSrvTypeId, Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime);
                    }
                    // Add ActionClasses.MSrv.CreateAction(Classes.MSrvType.ActionType.Ticket_Created, TicketId, "Ticket Created #: " + TicketId + " request action from " + Classes.MSrvType.MSrvDepartment.Logistics.ToString()  + " department");
                    MsgDlg.ShowAlert("Data Saved ..", MsgDlg.MessageType.Success, this);
                    ResetDlg();
                    if (RequestRefresh != null)
                        RequestRefresh();
                    //DialogResult = System.Windows.Forms.DialogResult.OK;
                    //Close();
                }
                else
                    MsgDlg.ShowAlert("No Data Saved ..", MsgDlg.MessageType.Error, this);
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