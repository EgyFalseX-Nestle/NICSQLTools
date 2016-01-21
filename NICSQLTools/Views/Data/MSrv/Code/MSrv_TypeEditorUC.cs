using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace NICSQLTools.Views.Data.MSrv
{
    public partial class MSrv_TypeEditorUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(NICSQLTools.Views.Data.MSrv.MSrv_TypeEditorUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TypeTableAdapter adpType = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TypeTableAdapter();
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();

        int _newid = 0;
        #endregion
        #region - Fun -
        public MSrv_TypeEditorUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
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
                    LSMSMSrv_TypeConditionId.QueryableSource = from q in dsLinq.MSrv_TypeConditions select q;
                    XPSCS.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
                    gridControlMain.DataSource = XPSCS;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            XPSCS.AllowNew = _elementRule.Inserting;
            XPSCS.AllowRemove = _elementRule.Deleting;
            XPSCS.AllowEdit = _elementRule.Updateing;

            if (!_elementRule.Updateing)
                bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            if (!_elementRule.Inserting)
            {
                gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            }

            if (!_elementRule.Deleting)
                gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            
        }
        #endregion
        #region -  EventWhnd - 
        private void RouteEditorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            ActivateRules();
        }
        private void gridViewMain_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId == 0)
            {
                MsgDlg.Show("Your user can't insert because you don't have Department Id", MsgDlg.MessageType.Error);
                return;
            }
            DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewMain.GetRow(e.RowHandle));
            if (_newid == 0)
                row.SetMemberValue("MSrvTypeId", adpType.NewId());
            else
                row.SetMemberValue("MSrvTypeId", _newid + 1);
            _newid++;
            row.SetMemberValue("UserIn", Classes.Managers.UserManager.defaultInstance.User.UserId);
            row.SetMemberValue("DateIn", Classes.Managers.DataManager.defaultInstance.ServerDateTime);
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            DevExpress.Xpo.AsyncCommitCallback CommitCallBack = (o) =>
            {
                SplashScreenManager.CloseForm();
                if (o == null)
                {
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                    Logger.Info("Data Saved ...");
                }
                else
                {
                    MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, o.Message), MsgDlg.MessageType.Error, o);
                    Classes.Core.LogException(Logger, o.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
            };

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            UOW.CommitTransactionAsync(CommitCallBack);
        }
        private void UOW_BeforeCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            DevExpress.Xpo.Helpers.ObjectSet Rows = (DevExpress.Xpo.Helpers.ObjectSet)e.Session.GetObjectsToSave();
            DateTime DateIn = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;
            foreach (DevExpress.Xpo.Metadata.XPDataTableObject item in Rows)
            {
                item.SetMemberValue("UserIn", NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId);
                item.SetMemberValue("DateIn", DateIn);
            }
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
            //if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
            //    return;
            LSMSMSrv_TypeConditionId.Reload();
            UOW.DropIdentityMap();
            UOW.DropChanges();
            XPSCS.Reload();
            gridViewMain.RefreshData();
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
