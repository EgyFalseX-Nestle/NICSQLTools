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
    public partial class MSrv_TicketCloseDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrv_TicketCloseDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter adp = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketTableAdapter();
        NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter adpTicketType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrvTicketTypeTableAdapter();
        public delegate void RequestRefreshEventhandler(); public event RequestRefreshEventhandler RequestRefresh;
        NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser _ticket;
        #endregion
        #region - Fun -
        public MSrv_TicketCloseDlg(NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser Ticket)
        {
            InitializeComponent();
            LSMSCloseMSrvTypeId.QueryableSource = dsLinq.MSrv_Types;
            _ticket = Ticket;
            tbTecEquipmentSerial.EditValue = _ticket.EquipmentSerial;
        }
        #endregion
        #region - EventWhnd -
        private void Dlg_Load(object sender, EventArgs e)
        {
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