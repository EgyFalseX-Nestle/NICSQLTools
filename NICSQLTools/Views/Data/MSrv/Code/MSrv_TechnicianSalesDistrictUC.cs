using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;

namespace NICSQLTools.Views.Data.MSrv
{
    public partial class MSrv_TechnicianSalesDistrictUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MSrv_TechnicianSalesDistrictUC));
        private NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        #endregion
        #region - Fun -
        public MSrv_TechnicianSalesDistrictUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                Invoke(new MethodInvoker(() => {
                    mSrv_TechnicianTableAdapter.Fill(dsMSrc.MSrv_Technician);
                    mSrv_TechnicianSalesDistrictTableAdapter.Fill(dsMSrc.MSrv_TechnicianSalesDistrict);
                    salesDistrictInfoTableAdapter.Fill(dsQry.SalesDistrictInfo);
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            if (!_elementRule.Updateing)
                bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            if (!_elementRule.Inserting)
            {
                mSrvTechnicianSalesDistrictBindingSource.AllowNew = _elementRule.Inserting;
                gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            }

            if (!_elementRule.Deleting)
                gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
        }
        #endregion
        #region -  EventWhnd - 
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            ActivateRules();
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                try
                {
                    mSrv_TechnicianSalesDistrictTableAdapter.Update(dsMSrc.MSrv_TechnicianSalesDistrict);
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                    Logger.Info("Data Saved ...");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MsgDlg.ShowAlert(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                    Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
                SplashScreenManager.CloseForm();
            });
            
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            LoadData();
            gridViewMain.RefreshData();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MsgDlg.Show("Do you want to delete selected row ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);

        }
        private void gridControlMain_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (MsgDlg.Show("Do you want to delete selected rows ?", MsgDlg.MessageType.Question) == DialogResult.No)
                    e.Handled = true;
            }
        }

        #endregion
    }
}
