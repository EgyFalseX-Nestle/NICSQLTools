using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace NICSQLTools.Views.Qry
{
    public partial class QryCustomerInfoUC : DevExpress.XtraEditors.XtraUserControl
    {
        
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(QryCustomerInfoUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        #endregion
        #region -   Functions   -
        public QryCustomerInfoUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
            sessionSales.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
        }
        #endregion
        #region -   Event Handlers   -
        private void txtSearchValue_EditValueChanged(object sender, EventArgs e)
        {
            try { lblLineCount.Text = txtSearchValue.Lines.Length.ToString(); }
            catch { }
        }
        private void btnSalesRefresh_Click(object sender, EventArgs e)
        {
            if (txtSearchValue.Lines.Length == 0)
                return;
            string customer = string.Empty;
            foreach (string item in txtSearchValue.Lines)
                customer += item + ",";
            customer = customer.Substring(0, customer.Length - 1);

            //UI
            btnSalesCancel.Enabled = true;
            btnSalesRefresh.Enabled = false;

            ThreadPool.QueueUserWorkItem((o) => 
            {
                DevExpress.Xpo.DB.SelectedData DataObj =
                NICSQLTools.Data.IC_DB.SprocHelper.Execsp_App_01A_Cus_Sal(sessionSales, customer);
                try
                {
                    xpDataViewSales.LoadData(DataObj);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error);
                    Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
                Invoke(new MethodInvoker(() => 
                {
                    btnSalesRefresh.Enabled = true;
                    btnSalesCancel.Enabled = false;
                }));
                //pgcSales.BestFit();
            });
        }
        private void btnSalesCancel_Click(object sender, EventArgs e)
        {
            if (sessionSales.IsConnected)
                sessionSales.Disconnect();
            btnSalesRefresh.Enabled = true;
            btnSalesCancel.Enabled = false;
        }
        private void btnEquipmentRefresh_Click(object sender, EventArgs e)
        {
            if (txtSearchValue.Lines.Length == 0)
                return;
            string customer = string.Empty;
            foreach (string item in txtSearchValue.Lines)
                customer += item + ",";
            customer = customer.Substring(0, customer.Length - 1);

            //UI
            btnEquipmentRefresh.Enabled = false;
            btnEquipmentCancel.Enabled = true;

            ThreadPool.QueueUserWorkItem((o) =>
            {
                DevExpress.Xpo.DB.SelectedData DataObj =
                NICSQLTools.Data.IC_DB.SprocHelper.Execsp_App_01B_Cus_Equip(sessionEquipment, customer);
                try
                {
                    xpDataViewEquipment.LoadData(DataObj);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error);
                    Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
                Invoke(new MethodInvoker(() =>
                {
                    btnEquipmentRefresh.Enabled = true;
                    btnEquipmentCancel.Enabled = false;
                }));
                
            });
        }
        private void btnRouteRefresh_Click(object sender, EventArgs e)
        {
            if (txtSearchValue.Lines.Length == 0)
                return;
            string customer = string.Empty;
            foreach (string item in txtSearchValue.Lines)
                customer += item + ",";
            customer = customer.Substring(0, customer.Length - 1);

            //UI
            btnRouteRefresh.Enabled = false;
            btnRouteCancel.Enabled = true;

            ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    DevExpress.Xpo.DB.SelectedData DataObj =
                NICSQLTools.Data.IC_DB.SprocHelper.Execsp_App_01C_Cus_Route(sessionRoute, customer);
                    xpDataViewRoute.LoadData(DataObj);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error);
                    Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
                Invoke(new MethodInvoker(() =>
                {
                    btnRouteRefresh.Enabled = true;
                    btnRouteCancel.Enabled = false;
                }));

            });
        }
        private void btnSalesExportGrid_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!pgcSales.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            pgcSales.ShowRibbonPrintPreview();
        }
        private void btnSalesExportData_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl();
            DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView(); view.OptionsView.ColumnAutoWidth = false;
            grid.MainView = view; grid.Parent = this;
            grid.DataSource = pgcSales.DataSource;
            grid.ShowRibbonPrintPreview();
            this.Controls.Remove(grid); grid.Parent = null;
        }
        private void btnEquipmentExportGrid_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gcEquipment.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gcEquipment.ShowRibbonPrintPreview();
        }
        private void btnEquipmentExportData_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl();
            DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView(); view.OptionsView.ColumnAutoWidth = false;
            grid.MainView = view; grid.Parent = this;
            grid.DataSource = gcEquipment.DataSource;
            grid.ShowRibbonPrintPreview();
            this.Controls.Remove(grid); grid.Parent = null;
        }
        private void btnRouteExportGrid_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gcRoute.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gcRoute.ShowRibbonPrintPreview();
        }
        private void btnRouteExportData_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl();
            DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView(); view.OptionsView.ColumnAutoWidth = false;
            grid.MainView = view; grid.Parent = this;
            grid.DataSource = gcRoute.DataSource;
            grid.ShowRibbonPrintPreview();
            this.Controls.Remove(grid); grid.Parent = null;
        }
        #endregion
        
    }
}
