﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace NICSQLTools.Views.Data.MSrv.Ticket
{
    public partial class MSrv_TicketCloseDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrv_TicketCloseDlg));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter adp = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter adpTicketType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter();
        public delegate void RequestRefreshEventhandler(); public event RequestRefreshEventhandler RequestRefresh;
        NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser _ticket;
        #endregion
        #region - Fun -
        public MSrv_TicketCloseDlg(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement, NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser Ticket)
        {
            InitializeComponent();
            _elementRule = RuleElement;
            _ticket = Ticket;
            tbTecEquipmentSerial.EditValue = _ticket.EquipmentSerial;
        }
        public void ActivateRules()
        {
            if (_elementRule == null)
                return;
            btnSave.Visible = btnSave.Enabled = _elementRule.Deleting;
        }
        #endregion
        #region - EventWhnd -
        private void Dlg_Load(object sender, EventArgs e)
        {
            ActivateRules();
            MSrvOfflineModeDlg dlg = new MSrvOfflineModeDlg();
            dlg.ShowDialog();
            lueCloseMSrvTypeId.Properties.DisplayMember = "MSrvType";
            lueCloseMSrvTypeId.Properties.ValueMember = "MSrvTypeId";
            lueCloseMSrvTypeId.Properties.DataSource = Classes.MSrvOfflineData.MSrvTypeClosing;
        }
        private void btnSearchSerial_Click(object sender, EventArgs e)
        {
            MSrv.SelectEquipmentDlg dlg = new MSrv.SelectEquipmentDlg(_ticket.CustomerId);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbTecEquipmentSerial.EditValue = dlg._serialNumber;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProviderMain.Validate())
                return;
            try
            {
                string Comment = string.Empty;
                if (tbOpenComment.EditValue != null)
                    Comment = tbOpenComment.EditValue.ToString();
                int Effected = Classes.Managers.DataManager.adpMSrvQry.UpdateCloseTicket(tbTecEquipmentSerial.EditValue.ToString(), Comment
                    , (short)lueCloseMSrvTypeId.EditValue, Classes.Managers.UserManager.defaultInstance.User.UserId, (DateTime)deClosedDate.EditValue, _ticket.TicketId);
                if (Effected > 0)
                {
                    //Add Action
                    Classes.MSrv.CreateAction(Classes.MSrvType.ActionType.Action_Close, _ticket.TicketId, "Ticket closed with reason " + lueCloseMSrvTypeId.Text + " by " + Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId.ToString() + " department");
                    MsgDlg.ShowAlert("Data Saved ..", MsgDlg.MessageType.Success, this);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
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