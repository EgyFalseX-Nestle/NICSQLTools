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
    public partial class DynamicForecastEditorDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DynamicForecastEditorDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsDataTableAdapters.CostDynamicForecastTableAdapter adp = new NICSQLTools.Data.dsDataTableAdapters.CostDynamicForecastTableAdapter();
        public DynamicForecastEditorDlg(bool New, string Costcenter, string GLAccount, int? Year, string BusinessUnit, int? Period)
        {
            InitializeComponent();

            LSMSCostcenter.QueryableSource = from q in dsLinq.CostCostcenters select q;
            LSMSGLAccount.QueryableSource = from q in dsLinq.CostAccountNatures select q;

            try
            {
                DateTime ServerDatetime = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;

                if (New)
                {
                    NICSQLTools.Data.dsData.CostDynamicForecastRow row = dsData.CostDynamicForecast.NewCostDynamicForecastRow();
                    row.Costcenter = string.Empty;
                    row.GLAccount = string.Empty;
                    row.BusinessUnit = string.Empty;
                    row.Year = ServerDatetime.Year;
                    row.Period = (ServerDatetime.Month - 1) / 3 + 1;
                    row.DF = 0;
                    row.Type = string.Empty;
                    row.UserIn = NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId;
                    row.DateIn = ServerDatetime;
                    dsData.CostDynamicForecast.AddCostDynamicForecastRow(row);
                }
                else
                    adp.FillByPK(dsData.CostDynamicForecast, Costcenter.ToString(), GLAccount.ToString(), (int)Year, BusinessUnit.ToString(), (int)Period);
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                NICSQLTools.Classes.Core.LogException(Logger, ex, NICSQLTools.Classes.Core.ExceptionLevelEnum.General, NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId);
                Close();
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.CostDynamicForecast[0].UserIn = NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.CostDynamicForecast[0].DateIn = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                try
                {
                    dsData.CostDynamicForecast[0].EndEdit();
                    adp.Update(dsData.CostDynamicForecast[0]);
                    MsgDlg.ShowAlert("Data Saved ..", MsgDlg.MessageType.Success, this);
                    Close();
                }
                catch (Exception ex)
                {
                    MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                    NICSQLTools.Classes.Core.LogException(Logger, ex, NICSQLTools.Classes.Core.ExceptionLevelEnum.General, NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
            }
            
        }
    }
}