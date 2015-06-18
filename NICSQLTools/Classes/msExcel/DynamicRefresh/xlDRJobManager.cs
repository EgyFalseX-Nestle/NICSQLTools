using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace NICSQLTools.Classes.msExcel.DynamicRefresh
{
    public class xlDRJobManager
    {
        [DllImport("user32.dll")]
        static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);

        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(xlDRJobManager));
        readonly string _xlfilename;

        public List<xlDRJob> Jobs { get; set; }
        public xlDRJobManager()
        {
            Jobs = new List<xlDRJob>();
        }
        public xlDRJobManager(string xlfilename)
        {
            Jobs = new List<xlDRJob>();
            _xlfilename = xlfilename;
            GetJobs();
            
        }
        public xlDRJobManager(List<xlDRJob> jobs)
        {
            Jobs = jobs;
        }
        public bool Addjobs(List<xlDRJob> jobs)
        {
            int Id;
            if (Jobs.Count != 0)
                Id = Jobs[Jobs.Count - 1].ID + 1;
            else
                Id = 1;
            try
            {
                for (int i = 0; i < jobs.Count; i++)
                {
                    xlDRJob job = jobs[i];
                    job.ID = Id;
                    Jobs.Add(job);
                    Id++;
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
            }
            return false;
        }
        public void AddJob(xlDRJob job)
        {
            int Id;
            if (Jobs.Count != 0)
                Id = Jobs[Jobs.Count - 1].ID + 1;
            else
                Id = 1;
            job.ID = Id;
            Jobs.Add(job);
        }
        private void GetJobs()
        {
            // Create an instance of Excel.
            excelApplication = new Microsoft.Office.Interop.Excel.Application();
            //Create a workbook and add a worksheet.
            Microsoft.Office.Interop.Excel.Workbook excelWorkBook = excelApplication.Workbooks.Open(_xlfilename);//excelApplication.Workbooks.Open("csharp.net-informations.xls", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            try
            {
                for (int inx = 1; inx < excelWorkBook.Connections.Count + 1; inx++)
                {
                    Microsoft.Office.Interop.Excel.WorkbookConnection obj = excelWorkBook.Connections[inx];
                    if (obj.Type != Microsoft.Office.Interop.Excel.XlConnectionType.xlConnectionTypeOLEDB)
                        continue;
                    if (obj.OLEDBConnection.CommandType != Microsoft.Office.Interop.Excel.XlCmdType.xlCmdSql)// this connection is not cmd type
                        continue;
                    object job = xlDRJob.GetJob(_xlfilename, excelWorkBook, inx);
                    if (job == null)
                        continue;
                    Jobs.Add((xlDRJob)job);
                }
            }
            catch (Exception ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MsgDlg.Show(ex.Message, System.Windows.Forms.MsgDlg.MessageType.Error, ex);
            }

            //Release Object
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkBook);
            excelWorkBook = null;
            excelApplication.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApplication);
            excelApplication = null;
            GC.Collect();

        }
        private static void releaseObject_Deleted(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MsgDlg.Show(ex.Message, System.Windows.Forms.MsgDlg.MessageType.Error, ex);
            }
            finally
            {
                GC.Collect();
            }
        }
        public bool JobExist(xlDRJob job)
        {
            foreach (xlDRJob item in Jobs)// check if this job already added before
            {
                if (job.FileName == item.FileName && job.ConName == item.ConName)
                    return true;
            }
            return false;
        }

        #region  - Execution - 
        Microsoft.Office.Interop.Excel.Application excelApplication = null;
        xlDRJob _runningJob = null;
        public Queue<xlDRJob> QueJobs { get; set; }
        public async void StartExecutionAsync(UpdateInfo notify)
        {
            if (QueJobs == null || QueJobs.Count == 0)
                StopExecution();

            if (excelApplication == null)
            {
                notify.SetValue(2, "Start Excel ..."); 
                excelApplication = new Microsoft.Office.Interop.Excel.Application();
                //excelApplication.DisplayAlerts = true;
                //excelApplication.AlertBeforeOverwriting = false;
            }
            
            try
            {
                _runningJob = QueJobs.Dequeue();
                notify.SetValue(2, "Open Workbook " + _runningJob.FilePath); 
                Microsoft.Office.Interop.Excel.Workbook excelWorkBook = GetWorkbook(_runningJob);// Get Workbook to execute
                notify.SetValue(2, string.Format("Execute Datasource {0} On Connection {1}", _runningJob.Datasource.Name, _runningJob.ConName)); 
                await _runningJob.ExecuteJob(excelWorkBook);// Execute
                notify.SetValue(2, "Execution " + _runningJob.ExResult.ToString()); 
                _runningJob.SaveToDatabase();// Save Execution result
                notify.SetValue(2, "Execution Information Saved ..."); 
            }
            catch (Exception ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
            }
            notify.SetValue(1, (int)notify.GetValue(1) + 1);
            notify.SetValue(3, "Update Grid");
            if (QueJobs == null || QueJobs.Count == 0)
            {
                StopExecution();
                notify.SetValue(4, "End of Exe");
                return;
            }
            StartExecutionAsync(notify);
        }
        private Microsoft.Office.Interop.Excel.Workbook GetWorkbook(xlDRJob job)
        {
            foreach (Microsoft.Office.Interop.Excel.Workbook book in excelApplication.Workbooks)
            {
                if (book.FullName.ToLower() == job.FilePath.ToLower())
                    return book;
            }
            return excelApplication.Workbooks.Open(job.FilePath);
        }
        public void StopExecution()
        {
            QueJobs.Clear(); QueJobs = null;
            if (_runningJob != null)
            {
                _runningJob.CancelExecution();
                _runningJob.Dispose(); _runningJob = null;
            }

            //for (int i = excelApplication.Workbooks.Count; i > 0; i--)
            //{
            //    excelApplication.Workbooks[i].Close(false, Type.Missing, Type.Missing);
            //    releaseObject(excelApplication.Workbooks[i]);
            //}
            excelApplication.Workbooks.Close();
            excelApplication.Quit();
            
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApplication);
            excelApplication = null;
            GC.Collect();
        }
        public void CancelExecution()
        {
            QueJobs.Clear();
            _runningJob.ExResult = xlTypes.ExcuteResult.Canceled;
        }
        #endregion

        #region  - Dyn -

        Excel.Application xlApp_Dyn;
        
        int app_ProcessId_Dyn;
        public Task CreateDynamicWorkbookAsync(Classes.QueryLayout.DatasourceStrc ds, Dictionary<string, object> Paramters, UpdateInfo CreateDyn_Notify)
        {
            return Task.Run(() =>
            {
                DatasourceBase datasource = new DatasourceBase() { Id = ds.DashboadId, Name = ds.DatasourceName, SP_Name = ds.DatasourceSPName, Params = new List<ParamBase>() };
                int id = 1;
                foreach (KeyValuePair<string, object> item in Paramters)
                {
                    datasource.Params.Add(new ParamBase() { Id = id, Name = item.Key, ParamValue = item.Value.ToString() });
                    id++;
                }
                string commandtext = xlDRJob.PrepareCommandText(datasource);
                string connectionstring = xlDRJob.PrepareConnectionString(false);

                object misvalue = System.Reflection.Missing.Value;
                Excel.Workbook xlWorkbook_Dyn;
                Excel.Worksheet xlWorkSheet;
                Excel.WorkbookConnection _xlDynCon = null;

                xlApp_Dyn = new Excel.Application();//Create Applcation
                xlWorkbook_Dyn = xlApp_Dyn.Workbooks.Add(misvalue);//Create Workbook
                xlWorkbook_Dyn.EnableAutoRecover = false;
                
                xlWorkSheet = (Excel.Worksheet)xlWorkbook_Dyn.Worksheets.get_Item(1);//Create Worksheet
                _xlDynCon = xlWorkbook_Dyn.Connections.Add2(ds.DatasourceName + " con", "This Connection Created By NICSQLTools", connectionstring, commandtext
                    , Excel.XlCmdType.xlCmdSql);//Create Excel Connection

                Excel.PivotCache pivotCach = xlWorkbook_Dyn.PivotCaches().Create(Excel.XlPivotTableSourceType.xlExternal, _xlDynCon);// Create Pivot Cach
                GetWindowThreadProcessId(xlApp_Dyn.Hwnd, out app_ProcessId_Dyn);
                CreateDyn_Notify.OnItemChanged += CreateDyn_Notify_OnItemChanged;
                pivotCach.CreatePivotTable(xlWorkSheet.get_Range("A1", misvalue), ds.DatasourceName + " Table");
                if (_xlDynCon != null)
                    _xlDynCon.OLEDBConnection.Connection = xlDRJob.PrepareConnectionString(true);
                if (xlApp_Dyn != null)
                    xlApp_Dyn.Visible = true;
                //////////////xlWorkSheet.Protect()
            });   
        }
        void CreateDyn_Notify_OnItemChanged(int index, object value)
        {
            if (xlApp_Dyn != null)
            {
                Process pro = Process.GetProcessById(Convert.ToInt32(app_ProcessId_Dyn));
                if (pro != null)
                    pro.Kill();
            }
        }
        #endregion

    }

}
