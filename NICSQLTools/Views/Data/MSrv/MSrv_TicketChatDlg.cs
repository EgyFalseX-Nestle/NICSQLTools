﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Data.MSrv
{
    public partial class MSrv_TicketChatDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(NICSQLTools.Views.Data.MSrv.MSrv_TechnicianEditorUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        int _ticketId;
        #endregion
        #region - Fun -
        public MSrv_TicketChatDlg(int TicketId)
        {
            InitializeComponent();
            _ticketId = TicketId;
            LSMSUser.QueryableSource = dsLinq.AppUsers;
        }
        private void LoadData()
        {
            // TODO: This line of code loads data into the 'dsMSrc.MSrv_TicketChat' table. You can move, or remove it, as needed.
            this.mSrv_TicketChatTableAdapter.FillByID(this.dsMSrc.MSrv_TicketChat, _ticketId);
            gridViewMain.BestFitColumns();
        }
        #endregion
        #region -  EventWhnd -
        private void MSrv_TicketChatDlg_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void gridViewMain_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            NICSQLTools.Data.dsMSrc.MSrv_TicketChatRow row = (NICSQLTools.Data.dsMSrc.MSrv_TicketChatRow)((DataRowView)(gridViewMain.GetRow(gridViewMain.FocusedRowHandle))).Row;
            row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
            row.DateIn = Classes.Managers.DataManager.defaultInstance.ServerDateTime;
            row.TicketId = _ticketId;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbChat.EditValue == null || tbChat.EditValue.ToString() == string.Empty)
                return;
            try
            {
                int effected  = mSrv_TicketChatTableAdapter.Insert(_ticketId, tbChat.EditValue.ToString(), Classes.Managers.UserManager.defaultInstance.User.UserId, Classes.Managers.DataManager.defaultInstance.ServerDateTime);
                if (effected > 0)
                {
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, this);
                    Logger.Info("Data Saved ...");
                    LoadData();
                    tbChat.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error,ex);
                Classes.Core.LogException(Logger, ex.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        #endregion
       
    }
}