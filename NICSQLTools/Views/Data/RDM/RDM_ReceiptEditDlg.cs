using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Data.RDM
{
    public partial class RDM_ReceiptEditDlg : DevExpress.XtraEditors.XtraForm
    {
 
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(RDM_ReceiptEditDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsRDMTableAdapters.RDM_ReceiptTableAdapter adp = new NICSQLTools.Data.dsRDMTableAdapters.RDM_ReceiptTableAdapter();
        public delegate void RequestRefreshEventhandler(); public event RequestRefreshEventhandler RequestRefresh;
        NICSQLTools.Data.Linq.vRDM_Receipt_ByUser _row;
        #endregion
        #region - Fun -
        public RDM_ReceiptEditDlg(NICSQLTools.Data.Linq.vRDM_Receipt_ByUser row)
        {
            InitializeComponent();

            _row = row;
            tbReceiptNo.EditValue = _row.ReceiptNo;
            deRDM_Date.EditValue = _row.RDM_Date;
            lueRouteNumber.EditValue = _row.RouteNumber;
            lueRDM_Promo_Type_Id.EditValue = _row.RDM_Promo_Type_Id;
            lueBaseProductId.EditValue = _row.BaseProductId;
            tbQun.EditValue = _row.Qun;
            if (_row.RDM_Description != null)
                tbOpenComment.EditValue = _row.RDM_Description;

            LSMSRoute.QueryableSource = from q in dsLinq.vRDM_Route_ByUsers where q.UserId == Classes.Managers.UserManager.defaultInstance.User.UserId select q;
            LSMSRDM_Promo_Type.QueryableSource = from q in dsLinq.MSrv_Types where q.MSrv_TypeConditionId == (int)Classes.MSrvType.TypeCondition.Open_Ticket select q;
            LSMSBaseProductId.QueryableSource = from q in dsLinq.PRD_BaseProducts select q;
        }
        private void ResetDlg()
        {
            tbReceiptNo.EditValue = null;
            deRDM_Date.EditValue = null;
            lueRouteNumber.EditValue = null;
            lueRDM_Promo_Type_Id.EditValue = null;
            lueBaseProductId.EditValue = null;
            tbQun.EditValue = null;
            tbOpenComment.EditValue = null;
            tbReceiptNo.Focus();
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
            try
            {
                DateTime serverDatetime = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;
                
                string Comment = string.Empty;
                if (tbOpenComment.EditValue != null)
                    Comment = tbOpenComment.EditValue.ToString();
                int Effected = adp.Update(tbReceiptNo.Text, deRDM_Date.DateTime, lueRouteNumber.EditValue.ToString(), Convert.ToInt16(lueBaseProductId.EditValue), Convert.ToInt32(lueRDM_Promo_Type_Id.EditValue), Convert.ToDouble(tbQun.EditValue),
                NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId, serverDatetime, Comment, _row.RDM_ID);
                if (Effected > 0)
                {
                    MsgDlg.ShowAlert("Data Saved ..", MsgDlg.MessageType.Success, this);
                    DialogResult = DialogResult.OK;
                    if (RequestRefresh != null)
                        RequestRefresh();
                    return;
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
