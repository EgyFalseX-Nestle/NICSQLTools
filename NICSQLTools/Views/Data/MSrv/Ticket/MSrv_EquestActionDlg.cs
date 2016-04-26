using System;
using System.Windows.Forms;
using System.Linq;

namespace NICSQLTools.Views.Data.MSrv.Ticket
{
    public partial class MSrvEquestActionDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrvEquestActionDlg));
        readonly NICSQLTools.Data.Linq.dsLinqDataDataContext _dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        private NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter _adp;
        NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter _adpTicketType;
        readonly NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser _ticket;
        #endregion
        #region - Fun -
        public MSrvEquestActionDlg(NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser ticket)
        {
            InitializeComponent();
            _adp = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter();
            _adpTicketType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter();
            LSMSMSrvDepartmentId.QueryableSource = _dsLinq.MSrv_Departments;
            LSMSRequestActionReason.QueryableSource = from q in _dsLinq.MSrv_Types where q.MSrv_TypeConditionId == (int)Classes.MSrvType.TypeCondition.RequestAction select q;
            _ticket = ticket;
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
                Classes.Managers.DataManager.adpMSrvQry.Update_Ticket_CurrentDepartmentId(Convert.ToInt16(lueMSrvDepartmentId.EditValue), Convert.ToInt16(lueRequestActionReason.EditValue), _ticket.TicketId);
                MsgDlg.ShowAlert("Data Saved ..", MsgDlg.MessageType.Success, this);
                DialogResult = DialogResult.OK;
                Close();
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