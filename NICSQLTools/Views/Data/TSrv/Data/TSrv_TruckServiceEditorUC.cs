using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using DevExpress.XtraBars;
using DevExpress.XtraCharts.Native;
using NICSQLTools.Data.Linq;

namespace NICSQLTools.Views.Data.TSrv.Data
{
    public partial class TSrv_TruckServiceEditorUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TSrv_TruckServiceEditorUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        dsLinqDataDataContext dsLinq = new dsLinqDataDataContext();
        #endregion
        #region - Fun -
        public TSrv_TruckServiceEditorUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
            Classes.Managers.DataManager.SetAllCommandTimeouts(tSrv_TruckServiceTableAdapter, Classes.Managers.DataManager.ConnectionTimeout);
            Classes.Managers.DataManager.SetAllCommandTimeouts(vRouteDetailsTableAdapter, Classes.Managers.DataManager.ConnectionTimeout);
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                Invoke(new MethodInvoker(() =>
                {
                    LSMSSalesDistrict3Id.QueryableSource = dsLinq.SalesDistrict3s;
                    LSMSUserIn.QueryableSource = dsLinq.AppUsers;
                    LSMSStatusId.QueryableSource = dsLinq.TSrv_Status;
                    LSMSDriverId.QueryableSource = dsLinq.TSrv_Drivers;
                    vRouteDetailsTableAdapter.Fill(dsTSrv.vRouteDetails, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }));
                SplashScreenManager.CloseForm();
            });}

        void LoadDate(DateTime dt){
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    tSrv_TruckServiceTableAdapter.FillBy_Date_UserId(dsTSrv.TSrv_TruckService,
                        Classes.Managers.UserManager.defaultInstance.User.UserId, dt);
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
                gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
                bbiAddDate.Visibility = BarItemVisibility.Never;
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
        private void bbiAddDate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TSrv_AddDayDlg dlg = new TSrv_AddDayDlg();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            LoadDate(dlg.To.Date);
        }
        private void beiDate_EditValueChanged(object sender, EventArgs e)
        {
            LoadDate(Convert.ToDateTime(beiDate.EditValue).Date);
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            int result = tSrv_TruckServiceTableAdapter.Update(dsTSrv.TSrv_TruckService);
            MsgDlg.ShowAlert(result + "Recored Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
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
            LSMSSalesDistrict3Id.Reload();
            LSMSUserIn.Reload();
            LSMSStatusId.Reload();
            LSMSDriverId.Reload();
            LSMSRouteNumber.Reload();
            vRouteDetailsTableAdapter.Fill(dsTSrv.vRouteDetails, Classes.Managers.UserManager.defaultInstance.User.UserId);
            if (beiDate.EditValue != null)
            {
                LoadDate(Convert.ToDateTime(beiDate.EditValue).Date);
                gridViewMain.RefreshData();
            }
        }


        #endregion
        
    }
}
