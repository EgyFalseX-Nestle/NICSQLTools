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
    public partial class MSrv_EquestActionDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrv_EquestActionDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter adp = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter adpTicketType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter();
        NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser _ticket;
        #endregion
        #region - Fun -
        public MSrv_EquestActionDlg(NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser Ticket)
        {
            InitializeComponent();
            LSMSMSrvDepartmentId.QueryableSource = dsLinq.MSrv_Departments;
            _ticket = Ticket;
        }
        #endregion
        #region - EventWhnd -
        private void Dlg_Load(object sender, EventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProviderMain.Validate())
                return;
            if (_ticket.CurrentDepartmentId == Convert.ToInt16(lueMSrvDepartmentId.EditValue))
            {
                MsgDlg.Show("Ticket department is same as your request department", MsgDlg.MessageType.Error);
                return;
            }
            try
            {
                //Add Action
                Classes.MSrv.CreateAction(Classes.MSrvType.ActionType.Request_Action, _ticket.TicketId, tbComment.Text);
                //Change Ticket Department
                Classes.Managers.DataManager.adpMSrvQry.Update_Ticket_CurrentDepartmentId(Convert.ToInt16(lueMSrvDepartmentId.EditValue), _ticket.TicketId);
                MsgDlg.ShowAlert("Data Saved ..", MsgDlg.MessageType.Success, this);
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