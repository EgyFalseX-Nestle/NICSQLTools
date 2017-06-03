using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraWizard;
using log4net;
using NICSQLTools.Classes.msExcel.DynamicRefresh;

namespace NICSQLTools.Views.Qry
{
    public partial class OpenXlDlg : XtraForm
    {
        #region -   Variables   -
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OpenXlDlg));
        //NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        //Classes.QueryLayout.DatasourceStrc DataSourceList = new Classes.QueryLayout.DatasourceStrc();
        //List<Control> LayoutControlList = new List<Control>();
        //List<string> ProgressList = new List<string>();
        //NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        
        //NICSQLTools.Data.dsQry.vAppDatasourceForUserRow _selectedDatasource = null;
        //NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter appDashboardDSTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter();
        //NICSQLTools.Data.dsDataTableAdapters.AppDatasourceParamTableAdapter appDashboardDSPramTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppDatasourceParamTableAdapter();
        //NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter get_sp_PramTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter();
        //public NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateDataTable _m_DynTbl = new NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateDataTable();
        //public NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateParamDataTable _m_DynParamTbl = new NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateParamDataTable();

        public List<JobsViewer> JobsViewerTable;
        private List<string> _fileList;

        #endregion
        #region -   Functions   -
        public OpenXlDlg()
        {
            InitializeComponent();
        }
        #endregion
        #region -   EventWhnd   -
        private void beOpenFile_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            //beOpenFile.EditValue = ofd.FileName;
            _fileList = new List<string>();
            _fileList.AddRange(ofd.FileNames);
        }
        private void wizardControlMain_CancelClick(object sender, CancelEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void wizardControlMain_SelectedPageChanging(object sender, WizardPageChangingEventArgs e)
        {
            if (e.PrevPage == OpenExcelWizardPage)
            {
                if (!beOpenFile.DoValidate())
                    e.Cancel = true;
                if (_fileList == null || _fileList.Count == 0)
                {
                    MsgDlg.Show("Please select an Excel file to continue", MsgDlg.MessageType.Info);
                    e.Cancel = true;
                    return;
                }
                JobsViewerTable = new List<JobsViewer>();
                foreach (string filename in _fileList)
                {
                    xlDRJobManager jobManager = new xlDRJobManager(filename);
                    if (jobManager.Jobs.Count == 0)
                        continue;
                    foreach (xlDRJob job in jobManager.Jobs)
                    {
                        JobsViewer viewer = new JobsViewer { Select = false, Job = job, ConnectionName = job.ConName, DatasourceName = job.Datasource.Name };
                        JobsViewerTable.Add(viewer);
                    }
                }
                gridControlJobs.DataSource = JobsViewerTable;
            }
            else if (e.PrevPage == ParamtersWizardPage)
            {
                bool selected = false;
                foreach (JobsViewer viewer in JobsViewerTable)
                {
                    if (viewer.Select)
                        selected = true;
                }
                if (selected)
                {
                    DialogResult = DialogResult.OK;
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
        private void repositoryItemButtonEditParam_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                JobsViewer row = (JobsViewer)gridViewJobs.GetRow(gridViewJobs.FocusedRowHandle);
                using (ParamEditorDlg frm = new ParamEditorDlg(row.Job))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception.Message);
            }
        }
    
        #endregion
    
    }
}