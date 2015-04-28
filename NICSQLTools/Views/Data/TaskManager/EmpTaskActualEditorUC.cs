using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace NICSQLTools.Views.Data.TaskManager
{
    public partial class EmpTaskActualEditorUC : XtraUserControl
    {

        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(EmpTaskActualEditorUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsTaskTableAdapters.QueriesTableAdapter adpTskQry = new NICSQLTools.Data.dsTaskTableAdapters.QueriesTableAdapter();
        DateTime _m_ServerDatetime = Classes.Managers.DataManager.defaultInstance.ServerDateTime;
        #endregion
        #region - Fun -
        public EmpTaskActualEditorUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
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
                    adpTskQry.PrepareDialyActualEmpTask(Classes.Managers.UserManager.defaultInstance.User.EmpId);
                    LSMSUsers.QueryableSource = from q in dsLinq.AppUsers select q;
                    LSMSTask.QueryableSource = from q in dsLinq.TskEmp_Tasks select q;
                    LSMSFactor.QueryableSource = from q in dsLinq.TskEmp_Factors select q;
                    tskEmp_EmpTaskActualTableAdapter.FillByEmpDialyTask(dsTask.TskEmp_EmpTaskActual, Classes.Managers.UserManager.defaultInstance.User.EmpId);
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            if (!_elementRule.Updateing)
            {
                bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                gridViewFactors.OptionsBehavior.Editable = false;
                gridViewFactors.OptionsBehavior.ReadOnly = false;
                gridViewMain.OptionsBehavior.Editable = false;
                gridViewMain.OptionsBehavior.ReadOnly = false;
            }

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
        private void gridViewMain_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            System.Data.DataRowView drv = ((System.Data.DataRowView)gridViewMain.GetRow(e.RowHandle));
            if (drv == null)
                return;
            NICSQLTools.Data.dsTask.TskEmp_EmpTaskActualRow row = (NICSQLTools.Data.dsTask.TskEmp_EmpTaskActualRow)drv.Row;
            if (row == null)
                return;
            //insert necessary data for selected task
            adpTskQry.PrepareDialyActualEmpTaskFactor(row.EmpTaskActualId);
            tskEmp_EmpTaskActualFactorTableAdapter.FillByEmpTaskActualId(dsTask.TskEmp_EmpTaskActualFactor, row.EmpTaskActualId);
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
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            try
            {
                tskEmpEmpTaskActualBindingSource.EndEdit();
                tskEmp_EmpTaskActualTableAdapter.Update(dsTask.TskEmp_EmpTaskActual);
                MsgDlg.ShowAlert("تم الحفظ ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                Logger.Info("تم الحفظ ...");
            }
            catch (Exception ex)
            {
                MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
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
        }
        private void gridViewFactors_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            try
            {
                tskEmpEmpTaskActualFactorBindingSource.EndEdit();
                tskEmp_EmpTaskActualFactorTableAdapter.Update(dsTask.TskEmp_EmpTaskActualFactor);
                MsgDlg.ShowAlert("تم الحفظ ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                Logger.Info("تم الحفظ ...");
            }
            catch (Exception ex)
            {
                MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        #endregion

        

    }
}
    