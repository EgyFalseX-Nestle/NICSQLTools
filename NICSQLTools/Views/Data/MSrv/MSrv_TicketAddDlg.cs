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
    public partial class MSrv_TicketAddDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrv_TicketAddDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter adp = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter adpTicketType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter();
        public delegate void RequestRefreshEventhandler(); public event RequestRefreshEventhandler RequestRefresh;
        #endregion
        #region - Fun -
        public MSrv_TicketAddDlg()
        {
            InitializeComponent();

            //LSMSCustomerId.QueryableSource = from c in dsLinq.vMSrv_Customers 
            //                                 join ss in dsLinq.AppRuleSalesDistrict3s on c.SalesDistrict3Id equals ss.SalesDistrict3Id 
            //                                 join userrole in dsLinq.AppUserRules on ss.RuleID equals userrole.RuleId
            //                                 where userrole.UserId == Classes.Managers.UserManager.defaultInstance.User.UserId
            //                                 select new { c.Customer};
            
            LSMSCustomerId.QueryableSource = from q in dsLinq.vMSrv_Customers where q.UserId == Classes.Managers.UserManager.defaultInstance.User.UserId select q;

            //try
            //{
            //    DateTime ServerDatetime = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;

            //    if (New)
            //    {
            //        NICSQLTools.Data.dsData.CostDynamicForecastRow row = dsData.CostDynamicForecast.NewCostDynamicForecastRow();
            //        row.Costcenter = string.Empty;
            //        row.GLAccount = string.Empty;
            //        row.BusinessUnit = string.Empty;
            //        row.Year = ServerDatetime.Year;
            //        row.Period = (ServerDatetime.Month - 1) / 3 + 1;
            //        row.DF = 0;
            //        row.Type = string.Empty;
            //        row.UserIn = NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId;
            //        row.DateIn = ServerDatetime;
            //        dsData.CostDynamicForecast.AddCostDynamicForecastRow(row);
            //    }
            //    else
            //        adp.FillByPK(dsData.CostDynamicForecast, Costcenter.ToString(), GLAccount.ToString(), (int)Year, BusinessUnit.ToString(), (int)Period);
            //}
            //catch (Exception ex)
            //{
            //    MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            //    NICSQLTools.Classes.Core.LogException(Logger, ex, NICSQLTools.Classes.Core.ExceptionLevelEnum.General, NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId);
            //    Close();
            //}

        }
        private void ResetDlg()
        {
            lueCustomerId.EditValue = null;
            tbEquipmentSerial.EditValue = null;

            tbIssueContactPerson.EditValue = null;
            tbIssueContactPhone.EditValue = null;
            tbIssueContactPhone2.EditValue = null;
            tbIssueAddress.EditValue = null;

            tbOpenComment.EditValue = null;
            clbcReason.UnCheckAll();

            lueCustomerId.Focus();
        }
        #endregion
        #region - EventWhnd -
        private void Dlg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMSrc.MSrv_Type' table. You can move, or remove it, as needed.
            this.mSrv_TypeTableAdapter.Fill(this.dsMSrc.MSrv_Type);
        }
        private void lueCustomerId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueCustomerId.EditValue == null || lueCustomerId.EditValue.ToString() == string.Empty)
                return;
            object obj = lueCustomerId.GetSelectedDataRow();
            if (obj == null)
                return;
            NICSQLTools.Data.Linq.vMSrv_Customer customer = (NICSQLTools.Data.Linq.vMSrv_Customer)obj;
            
            tbIssueContactPerson.EditValue = customer.DisplayName;
            tbIssueAddress.EditValue = customer.Address;
            //Get 1st Freezer
            tbEquipmentSerial.EditValue =  NICSQLTools.Classes.Managers.DataManager.adpMSrvQry.GetCusEqpSerial(customer.Customer);
        }
        private void btnSearchSerial_Click(object sender, EventArgs e)
        {
            if (lueCustomerId.EditValue != null && lueCustomerId.EditValue.ToString() != string.Empty)
            {
                MSrv.SelectEquipmentDlg dlg = new MSrv.SelectEquipmentDlg(lueCustomerId.EditValue.ToString());
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
            if ((bool)Classes.Managers.DataManager.adpMSrvQry.CustomerOpen(lueCustomerId.EditValue.ToString()) == true)
            {
                MsgDlg.Show("Customer already have opened Ticket", MsgDlg.MessageType.Info);
                return;
            }
            try
            {
                int TicketId = (int)adp.NewId();
                DateTime serverDatetime = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;
                NICSQLTools.Data.Linq.vMSrv_Customer customer = (NICSQLTools.Data.Linq.vMSrv_Customer)lueCustomerId.GetSelectedDataRow();
                
                string Comment = string.Empty;
                if (tbOpenComment.EditValue != null)
                    Comment = tbOpenComment.EditValue.ToString();
                int Effected = adp.Insert(TicketId, lueCustomerId.EditValue.ToString(), tbEquipmentSerial.EditValue.ToString(), customer.Route, serverDatetime, Comment, Convert.ToInt16(customer.SalesDistrict3Id)
                    , customer.PlantNumber, tbIssueContactPerson.EditValue.ToString(), tbIssueAddress.EditValue.ToString(), tbIssueContactPhone.EditValue.ToString(), tbIssueContactPhone2.EditValue.ToString()
                    , null, (short)Classes.MSrvType.MSrvDepartment.Logistics, false, string.Empty, null, null, null, null, NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime);
                if (Effected > 0)
                {
                    foreach (object item in clbcReason.CheckedItems)
                    {
                        NICSQLTools.Data.dsMSrc.MSrv_TypeRow TicketType = (NICSQLTools.Data.dsMSrc.MSrv_TypeRow)((DataRowView)item).Row;
                        adpTicketType.Insert(TicketId, TicketType.MSrvTypeId, NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime);
                    }
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
                NICSQLTools.Classes.Core.LogException(Logger, ex, NICSQLTools.Classes.Core.ExceptionLevelEnum.General, NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId);
            }

        }
        #endregion

    }
}