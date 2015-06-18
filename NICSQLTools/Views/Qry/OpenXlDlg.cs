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
using DevExpress.XtraLayout;


namespace NICSQLTools.Views.Qry
{
    public partial class OpenXlDlg : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(OpenXlDlg));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        //Classes.QueryLayout.DatasourceStrc DataSourceList = new Classes.QueryLayout.DatasourceStrc();
        //List<Control> LayoutControlList = new List<Control>();
        List<string> ProgressList = new List<string>();
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        
        //NICSQLTools.Data.dsQry.vAppDatasourceForUserRow _selectedDatasource = null;
        //NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter appDashboardDSTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter();
        //NICSQLTools.Data.dsDataTableAdapters.AppDatasourceParamTableAdapter appDashboardDSPramTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppDatasourceParamTableAdapter();
        //NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter get_sp_PramTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter();
        //public NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateDataTable _m_DynTbl = new NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateDataTable();
        //public NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateParamDataTable _m_DynParamTbl = new NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateParamDataTable();

        public List<Classes.msExcel.DynamicRefresh.JobsViewer> JobsViewerTable;

        #endregion
        #region -   Functions   -
        public OpenXlDlg()
        {
            InitializeComponent();
        }
        #endregion
        #region -   EventWhnd   -
        private void beOpenFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            beOpenFile.EditValue = ofd.FileName;
        }
        private void wizardControlMain_CancelClick(object sender, CancelEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        private void wizardControlMain_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.PrevPage == OpenExcelWizardPage)
            {
                if (!beOpenFile.DoValidate())
                    e.Cancel = true;
                if (beOpenFile.EditValue == null || beOpenFile.EditValue.ToString() == string.Empty)
                {
                    MsgDlg.Show("Please select an Excel file to continue", MsgDlg.MessageType.Info);
                    e.Cancel = true;
                    return;
                }

                Classes.msExcel.DynamicRefresh.xlDRJobManager JobManager = new Classes.msExcel.DynamicRefresh.xlDRJobManager(beOpenFile.EditValue.ToString());
                if (JobManager.Jobs.Count == 0)
                {
                    MsgDlg.Show("Can't find any known connection", MsgDlg.MessageType.Info);
                    e.Cancel = true; return;
                }
                JobsViewerTable = new List<Classes.msExcel.DynamicRefresh.JobsViewer>();
                foreach (Classes.msExcel.DynamicRefresh.xlDRJob job in JobManager.Jobs)
                {
                    Classes.msExcel.DynamicRefresh.JobsViewer viewer = new Classes.msExcel.DynamicRefresh.JobsViewer() { Select = false, Job = job, ConnectionName = job.ConName, DatasourceName = job.Datasource.Name };
                    JobsViewerTable.Add(viewer);
                }
                gridControlJobs.DataSource = JobsViewerTable;
            }
            else if (e.PrevPage == ParamtersWizardPage)
            {
                bool selected = false;
                foreach (Classes.msExcel.DynamicRefresh.JobsViewer viewer in JobsViewerTable)
                {
                    if (viewer.Select)
                        selected = true;
                }
                if (selected)
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
                else
                    MsgDlg.Show("Please selected at least one connection to continue ", MsgDlg.MessageType.Info);
            }
            else if (e.PrevPage == completionWizardPage)
            {
                // completed validation
            }
        }
        private void repositoryItemButtonEditParam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Classes.msExcel.DynamicRefresh.JobsViewer row = (Classes.msExcel.DynamicRefresh.JobsViewer)gridViewJobs.GetRow(gridViewJobs.FocusedRowHandle);
            using (ParamEditorDlg frm = new ParamEditorDlg(row.Job))
            {
                frm.ShowDialog();
            }
        }
    
        #endregion
    
    }
}