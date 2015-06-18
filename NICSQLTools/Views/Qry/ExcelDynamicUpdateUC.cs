using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Qry
{
    public partial class ExcelDynamicUpdateUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(ExcelDynamicUpdateUC));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        //List<Classes.msExcel.DynamicRefresh.xlDRJob> Jobs = new List<Classes.msExcel.DynamicRefresh.xlDRJob>();
        Classes.msExcel.DynamicRefresh.xlDRJobManager manager;
        UpdateInfo notify;
        #endregion
        #region -   Functions   -
        private void RefreshGrid()
        {
            gridControlMain.RefreshDataSource();
            gridViewMain.BestFitColumns();
        }
        private void AddLog(string strLog)
        {
            Invoke(new MethodInvoker(() =>
            {
                rtbLog.AppendText(string.Format("{0}{1}", strLog, Environment.NewLine));
                rtbLog.ScrollToCaret();
            }));
        }
        #endregion
        #region -   EventWhnd   -
        public ExcelDynamicUpdateUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;

            LSMSAppExcuteResult.QueryableSource = from Qry in dsLinq.AppExcuteResults select Qry;
            manager = new Classes.msExcel.DynamicRefresh.xlDRJobManager();
            gridControlMain.DataSource = manager.Jobs;
        }
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (OpenXlDlg dlg = new OpenXlDlg())
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                foreach (Classes.msExcel.DynamicRefresh.JobsViewer job in dlg.JobsViewerTable)
                {
                    if (!job.Select)//check if this job user didn't select it
                        continue;
                    if (!manager.JobExist(job.Job))// check if this job already exist
                        manager.AddJob(job.Job);    
                    
                }
                RefreshGrid();   
            }
        }
        private void repositoryItemButtonEditRemove_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MsgDlg.Show("Are you Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            Classes.msExcel.DynamicRefresh.xlDRJob job = (Classes.msExcel.DynamicRefresh.xlDRJob)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            manager.Jobs.Remove(job);
            RefreshGrid();
        }
        private void repositoryItemButtonEditParam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Classes.msExcel.DynamicRefresh.xlDRJob job = (Classes.msExcel.DynamicRefresh.xlDRJob)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            using (ParamEditorDlg frm = new ParamEditorDlg(job))
            {
                frm.ShowDialog();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (manager == null || manager.Jobs == null || manager.Jobs.Count == 0)
                return;
            //Prepare Jobs Queue
            manager.QueJobs = new Queue<Classes.msExcel.DynamicRefresh.xlDRJob>();
            foreach (Classes.msExcel.DynamicRefresh.xlDRJob item in manager.Jobs)
            {
                if (item.ExResult == Classes.msExcel.xlTypes.ExcuteResult.Ready)
                    manager.QueJobs.Enqueue(item);
            }
            if (manager.QueJobs.Count == 0)
            {
                MsgDlg.Show("No ready connection to start", MsgDlg.MessageType.Info);
                return;
            }

            //Disable UI
            btnStart.Enabled = false; btnCancel.Enabled = true;
            // Prepare Update notifier
            notify = new UpdateInfo();
            notify.AddItem(pbc.Properties.Maximum); notify.AddItem(pbc.EditValue);
            notify.AddItem("Messages"); notify.AddItem("Update Grid"); notify.AddItem("End of Exe");
            notify.OnItemChanged += notify_OnItemChanged;
            notify.SetValue(0, manager.QueJobs.Count); notify.SetValue(1, 0);//Set progress bar values
            
            manager.StartExecutionAsync(notify);
            
        }
        void notify_OnItemChanged(int index, object value)
        {
            switch (index)
            {
                case 0://Progress Max Value
                    pbc.Invoke(new MethodInvoker(() => { pbc.Properties.Maximum = Convert.ToInt32(value); }));
                    break;
                case 1://Progress Value
                    pbc.Invoke(new MethodInvoker(() => { pbc.EditValue = Convert.ToInt32(value); }));
                    break;
                case 2:// Messages
                    AddLog(value.ToString());
                    break;
                case 3:// Update Grid
                    gridControlMain.RefreshDataSource();
                    gridViewMain.BestFitColumns();
                    break;
                case 4:// End Of Exe
                    //Enable UI
                    btnStart.Enabled = true; 
                    btnCancel.Enabled = false;
                    notify.OnItemChanged -= notify_OnItemChanged; pbc.EditValue = 0; notify = null; AddLog("Ready");
                    break;
                default:
                    break;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            manager.CancelExecution();
            
            //manager.StopExecution();
            //if (notify != null)
            //{
            //    notify.OnItemChanged -= notify_OnItemChanged; pbc.EditValue = 0; AddLog("Ready");
            //}
            //btnStart.Enabled = true;
            
        }
        #endregion

    }
}
