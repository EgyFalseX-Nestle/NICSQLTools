using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;

namespace NICSQLTools.Views.Data.TaskManager
{
    public partial class TaskFactorDlg : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TaskFactorDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        int _m_task;

        #endregion
        #region -   Functions   -
        public TaskFactorDlg(int TaskId)
        {
            InitializeComponent();
            _m_task = TaskId;
        }
        void LoadData()
        {
            LSMSUsers.QueryableSource = from q in dsLinq.AppUsers select q;
            LSMSFactor.QueryableSource = from q in dsLinq.TskEmp_Factors select q;
            this.tskEmp_TaskFactorTableAdapter.FillByTaskId(this.dsTask.TskEmp_TaskFactor, _m_task);
            gridViewMain.BestFitColumns();
        }
        #endregion
        #region -   EventWhnd   -
        private void TaskFactorDlg_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void gridViewMain_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            NICSQLTools.Data.dsTask.TskEmp_TaskFactorRow row = (NICSQLTools.Data.dsTask.TskEmp_TaskFactorRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            row.TaskId = _m_task;
        }
        private void gridControlMain_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (MsgDlg.Show("Do you want to delete selected rows ?", MsgDlg.MessageType.Question) == DialogResult.No)
                    e.Handled = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime DateIn = NICSQLTools.Classes.Managers.DataManager.defaultInstance.ServerDateTime;
            try
            {
                //Set DateIn And UserIn
                for (int i = 0; i < dsTask.TskEmp_TaskFactor.Count; i++)
                {
                    if (dsTask.TskEmp_TaskFactor[i].RowState == DataRowState.Modified)
                    {
                        dsTask.TskEmp_TaskFactor[i].UserIn = NICSQLTools.Classes.Managers.UserManager.defaultInstance.User.UserId;
                        dsTask.TskEmp_TaskFactor[i].DateIn = DateIn;
                    }
                }
                tskEmpTaskFactorBindingSource.EndEdit();
                tskEmp_TaskFactorTableAdapter.Update(dsTask.TskEmp_TaskFactor);
                MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, new Form());
                Logger.Info("Data Saved ...");
                Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MsgDlg.Show(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            
        }
        
        #endregion

    }
}