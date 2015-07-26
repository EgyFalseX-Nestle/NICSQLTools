using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace NICSQLTools.Classes.msExcel.DynamicRefresh
{
    public class xlDRJob : IDisposable
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(xlDRJob));
        NICSQLTools.Data.dsDataSourceTableAdapters.AppDatasourceTableAdapter adpDS = new NICSQLTools.Data.dsDataSourceTableAdapters.AppDatasourceTableAdapter();
        NICSQLTools.Data.dsDataSourceTableAdapters.AppDatasourceParamTableAdapter _adpParam = new Data.dsDataSourceTableAdapters.AppDatasourceParamTableAdapter();
        NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter adp_spInfo = new Data.dsQryTableAdapters.Get_sp_PramTableAdapter();
        NICSQLTools.Views.Main.rtfTextViewerFrm FrmViewer;
        DevExpress.XtraLayout.LayoutControl _layoutControlMain;
        DevExpress.XtraLayout.LayoutControlGroup _layoutControlGroupMain;
        NICSQLTools.Data.dsDataSourceTableAdapters.AppExcelDynamicUpdateTableAdapter adpDynUp = new Data.dsDataSourceTableAdapters.AppExcelDynamicUpdateTableAdapter();
        NICSQLTools.Data.dsDataSourceTableAdapters.AppExcelDynamicUpdateParamTableAdapter adpDynUpParam = new Data.dsDataSourceTableAdapters.AppExcelDynamicUpdateParamTableAdapter();
        Microsoft.Office.Interop.Excel.WorkbookConnection _runningConnection = null;

        #region  - Properties - 

        private int _id;
        private bool _knownJob;
        private string _filename;
        private string _filepath;
        private DatasourceBase _datasource;
        private DateTime _exStartDate;
        private DateTime _exEndDate;
        private xlTypes.ExcuteResult _exResult;
        private string _conname;
        private TimeSpan _elapsed;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public bool KnownJob
        {
            get { return _knownJob; }
            set { _knownJob = value; }
        }
        public string FileName
        {
            get { return _filename; }
            set { _filename = value; }
        }
        public string FilePath
        {
            get { return _filepath; }
            set { _filepath = value; }
        }
        public DatasourceBase Datasource
        {
            get { return _datasource; }
            set { _datasource = value; }
        }
        public DateTime ExStartDate
        {
            get { return _exStartDate; }
            set { _exStartDate = value; }
        }
        public DateTime ExEndDate
        {
            get { return _exEndDate; }
            set { _exEndDate = value; }
        }
        public TimeSpan Elapsed
        {
            get { return _elapsed; }
            set { _elapsed = value; }
        }

        public xlTypes.ExcuteResult ExResult
        {
            get { return _exResult; }
            set { _exResult = value; }
        }
        public string ConName
        {
            get { return _conname; }
            set { _conname = value; }
        }
        public DevExpress.XtraEditors.SimpleButton _btnHelp { get; set; }

        #endregion
        #region  - Functions - 
        public void Dispose()
        {
            if (adpDS != null)
            {
                adpDS.Dispose();
                adpDS = null;
            }
            if (_adpParam != null)
            {
                _adpParam.Dispose();
                _adpParam = null;
            }
            if (adp_spInfo != null)
            {
                adp_spInfo.Dispose();
                adp_spInfo = null;
            }
            if (FrmViewer != null)
            {
                FrmViewer.Dispose();
                FrmViewer = null;
            }
            if (_layoutControlMain != null)
            {
                _layoutControlMain.Dispose();
                _layoutControlMain = null;
            }
            if (_layoutControlGroupMain != null)
            {
                _layoutControlGroupMain.Dispose();
                _layoutControlGroupMain = null;
            }
            if (_btnHelp != null)
            {
                _btnHelp.Dispose();
                _btnHelp = null;
            }
            if (adpDynUp != null)
            {
                adpDynUp.Dispose();
                adpDynUp = null;
            }
            if (adpDynUpParam != null)
            {
                adpDynUpParam.Dispose();
                adpDynUpParam = null;
            }
        }
        public xlDRJob(string filepath)
        {
            _filepath = filepath;
            _filename = System.IO.Path.GetFileName(filepath);
            _exResult = xlTypes.ExcuteResult.Ready;
        }
        public static xlDRJob GetJob(string filepath, Workbook wb, int conInx)
        {
            xlDRJob job = new xlDRJob(filepath) { _conname = wb.Connections[conInx].Name };

            if (wb.Connections[conInx].Type != XlConnectionType.xlConnectionTypeOLEDB)// bad connection type
                return null;
            if (wb.Connections[conInx].OLEDBConnection.CommandType != XlCmdType.xlCmdSql)// bad command type
                return null;
            //string cmdText = wb.Connections[conInx].OLEDBConnection.CommandText;
            if (!job.SetDatasourceIdAndParam(wb.Connections[conInx].OLEDBConnection.CommandText))// check if command is known and set datasource
                return null;
            return job;
        }
        private bool SetDatasourceIdAndParam(string commandtext)
        {
            bool output = false;
            //Get sp name
            string spName = string.Empty;
            int i = 0;
            for (i = 0; i < commandtext.Length; i++)
            {
                if (commandtext[i] == ' ' || commandtext[i] == '\'')
                    break;
                spName += commandtext[i];
            }
            //get datasource id
            foreach (Data.dsQry.UserRuleDatasourceRow row in Classes.Managers.UserManager.defaultInstance.UserDatasource)
            {
                string Prx_Name = spName.Replace("dbo.", "").Replace("db_accessadmin.", "").Replace("db_owner.", "").ToLower();
                if (row.DatasourceSPName.ToLower() == Prx_Name)
                {
                    _datasource = new DatasourceBase() { Id = row.DatasourceID, Name = row.DatasourceName, SP_Name = row.DatasourceSPName, Params = new List<ParamBase>() };
                  if (SetParam(commandtext.Substring(i)))
                        output = true;
                    break;
                }
            }
            return output;
        }
        private bool SetParam(string paramText)
        {
            bool output = false;
            try
            {
                List<string> lst = SplitParam(paramText);
                //string[] param = paramText.Trim().Split(',');
                //foreach (string item in param)
                //    lst.Add(item.Replace('\'', ' ').Trim());

                NICSQLTools.Data.dsDataSource.AppDatasourceParamDataTable tbl = _adpParam.GetDataByDatasourceID(_datasource.Id);
                for (int i = 0; i < tbl.Count; i++)
                {
                    string val;
                    if (i < lst.Count)
                        val = lst[i];
                    else
                        val = string.Empty;

                    ParamBase newParam = new ParamBase() { Id = tbl[i].AppDatasourceParamID, Name = tbl[i].ParamName, DisplayName = tbl[i].ParamDisplayName, ParamValue = val };
                    if (!tbl[i].IsLookupIDNull())
                        newParam.Lookup = tbl[i].LookupID;
                    _datasource.Params.Add(newParam);
                }
                output = true;
            }
            catch (Exception ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
            }
            return output;
        }
        private List<string> SplitParam(string param)
        {
            string[] split1 = param.Split(',');
            List<string> SplitedParam = new List<string>();

            for (int i = 0; i < split1.Length ; i++)
            {
                //have no '
                if (!split1[i].Contains('\''))
                {
                    SplitedParam.Add(split1[i].Trim());
                    continue;
                }
                //have 2 '
                int count = split1[i].Count(f => f == '\'');
                if (count == 2)
                {
                    SplitedParam.Add(split1[i].Replace("'", "").Trim());
                    continue;
                }
                //have 1 '
                string str = split1[i].Replace("'", "");
                for (int inx = i + 1; inx < split1.Length; inx++)
                {
                    i++;
                    if (split1[inx].Contains('\''))
                    {
                        str += "," + split1[inx].Replace("'", "");
                        SplitedParam.Add(str.Trim());
                        break;
                    }
                    str += "," + split1[inx];
                }
            }
            return SplitedParam;
        }
        /// <summary>
        /// Create Datasource Layout Controls
        /// </summary>
        /// <param name="layoutctr">this is the Layout Control</param>
        /// <param name="layoutgroup">this is the Main Layout Group</param>
        public async void CreateDatasourceControls(DevExpress.XtraLayout.LayoutControl layoutctr, DevExpress.XtraLayout.LayoutControlGroup layoutgroup)
        {
            _layoutControlMain = layoutctr;// Set Main Layout Control
            _layoutControlGroupMain = layoutgroup;// Set Main LayoutGroup

            await CreateDatasourceAsync();
            //Add Controls To Form
            CreateLayout();
        }
        private Task CreateDatasourceAsync()
        {
            return Task.Run(() =>
            {
                //Create All Datasource Paramters
                for (int i = 0; i < Datasource.Params.Count; i++)
                {
                    NICSQLTools.Data.dsQry.Get_sp_PramDataTable tblPramType = adp_spInfo.GetDataByParamName(Datasource.Params[i].Name, Datasource.SP_Name);//Get Paramter Information
                    string ParamType = string.Empty;
                    if (tblPramType.Rows.Count == 0)
                        ParamType = "NVARCHAR";
                    else
                        ParamType = ((NICSQLTools.Data.dsQry.Get_sp_PramRow)tblPramType.Rows[0]).type;
                    //Create Control For Parameter
                    System.Windows.Forms.Control item = CreateDSElement(Datasource.Params[i], ParamType);
                    //Add Control to Datasource Controls List
                    Datasource.Params[i].ctr = item;
                }
                //Create Refresh Button For Datasource
                _btnHelp = new DevExpress.XtraEditors.SimpleButton();
                _btnHelp.Image = global::NICSQLTools.Properties.Resources.info_16x16;
                _btnHelp.Name = String.Format("btnHelp{0}{1}", Datasource.SP_Name, Datasource.Id);
                _btnHelp.Size = new System.Drawing.Size(170, 22);
                //btnHelp.Location = new Point(120, layoutControlMain.Controls.Count * 23);
                _btnHelp.Location = new System.Drawing.Point(120, Datasource.Params.Count * 23);
                _btnHelp.Text = "show help for datasource"; //+ Datasource.Name;
                //btnHelp.StyleController = layoutControlMain;
                _btnHelp.Click += btnHelp_Click; _btnHelp.Tag = Datasource.Id;
            });
        }
        private System.Windows.Forms.Control CreateDSElement(ParamBase param, string ParamType)
        {
            object ctr = null;
            if (param.Lookup != null)
            {
                List<object> data = NICSQLTools.Classes.Managers.DataManager.ExeDSLookup((int)param.Lookup);
                DevExpress.XtraEditors.CheckedComboBoxEdit ccbe = new DevExpress.XtraEditors.CheckedComboBoxEdit();
                ccbe.Properties.AllowMultiSelect = true;
                ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
                ccbe.Properties.DataSource = Classes.Managers.UserManager.defaultInstance.LookupUserValue((System.Data.DataTable)data[0], data[2].ToString(), (int)param.Lookup);
                ccbe.Properties.DisplayMember = data[1].ToString();
                ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                ccbe.Properties.ValueMember = data[2].ToString();
                ccbe.EditValueChanged += new EventHandler((e, o) =>
                { ((DevExpress.XtraEditors.CheckedComboBoxEdit)e).RefreshEditValue(); });//validate edit value to do not select out of list items
                ctr = ccbe;
            }
            else
            {
                switch (ParamType.ToLower())
                {
                    case "nvarchar":
                        DevExpress.XtraEditors.TextEdit txt1 = new DevExpress.XtraEditors.TextEdit();
                        txt1.Name = String.Format("ctr{0}{1}{2}", param.Name, param.Id, Datasource.Id);
                        ctr = txt1;
                        break;
                    case "int":
                    case "smallint":
                    case "bigint":
                        DevExpress.XtraEditors.TextEdit txt2 = new DevExpress.XtraEditors.TextEdit();
                        txt2.Name = String.Format("ctr{0}{1}{2}", param.Id, param.Id, Datasource.Id);
                        txt2.Properties.DisplayFormat.FormatString = "n0";
                        txt2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        txt2.Properties.EditFormat.FormatString = "n0";
                        txt2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        txt2.Properties.Mask.EditMask = "n0";
                        txt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        ctr = txt2;
                        break;
                    case "float":
                        DevExpress.XtraEditors.TextEdit txt3 = new DevExpress.XtraEditors.TextEdit();
                        txt3.Name = String.Format("ctr{0}{1}{2}", param.Id, param.Id, Datasource.Id);
                        txt3.Properties.DisplayFormat.FormatString = "f2";
                        txt3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        txt3.Properties.EditFormat.FormatString = "f2";
                        txt3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        txt3.Properties.Mask.EditMask = "f2";
                        txt3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        ctr = txt3;
                        break;
                    case "datetime":
                        DevExpress.XtraEditors.DateEdit de1 = new DevExpress.XtraEditors.DateEdit();
                        de1.EditValue = null;
                        de1.Name = String.Format("ctr{0}{1}{2}", param.Id, param.Id, Datasource.Id);
                        de1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                        de1.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
                        de1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                        de1.Properties.EditFormat.FormatString = "yyyy-MM-dd";
                        de1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                        de1.Properties.Mask.EditMask = "yyyy-MM-dd";
                        de1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                        
                        ctr = de1;
                        break;
                    default:
                        break;
                }
            }
            ((DevExpress.XtraEditors.TextEdit)ctr).Properties.NullValuePrompt = param.DisplayName;
            //Binding Control
            if (ctr.GetType() == typeof(DevExpress.XtraEditors.DateEdit))
                ((DevExpress.XtraEditors.TextEdit)ctr).DataBindings.Add("Datetime", param, "ParamValue", true);
            else
                ((DevExpress.XtraEditors.TextEdit)ctr).DataBindings.Add("EditValue", param, "ParamValue", true);
            ((DevExpress.XtraEditors.TextEdit)ctr).Properties.MaxLength = 64000;
            return (System.Windows.Forms.Control)ctr;
        }
        private void CreateLayout()
        {
            //layoutControlGroupMain.Clear();
            //for (int i = 0; i < LayoutControlList.Count; i++)
            //{
            //    LayoutControlList[i].Dispose();
            //    LayoutControlList[i] = null;
            //}
            //LayoutControlList.Clear();
            DevExpress.XtraLayout.LayoutControlGroup LayGroup = _layoutControlGroupMain.AddGroup();
            LayGroup.Text = _datasource.Name;
            foreach (ParamBase param in _datasource.Params)
            {
                _layoutControlMain.Controls.Add(param.ctr);
                DevExpress.XtraLayout.LayoutControlItem layItem = LayGroup.AddItem();
                layItem.Text = ((DevExpress.XtraEditors.TextEdit)param.ctr).Properties.NullValuePrompt;
                layItem.Control = param.ctr;
            }
            //Add Help button
            DevExpress.XtraLayout.LayoutControlItem layItemBtnHelp = LayGroup.AddItem(string.Empty, _btnHelp);
            layItemBtnHelp.TextVisible = false;
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            FrmViewer = new NICSQLTools.Views.Main.rtfTextViewerFrm(string.Empty) { WindowState = System.Windows.Forms.FormWindowState.Maximized };

            object obj = adpDS.GetDesc(Datasource.Id);
            if (obj == null || obj.ToString() == string.Empty)
            {
                System.Windows.Forms.MsgDlg.Show("No Help Found  ...", System.Windows.Forms.MsgDlg.MessageType.Info);
                FrmViewer.TextData = string.Empty;
            }
            else
            {
                byte[] data = Classes.Managers.DataManager.DecompressFile((byte[])obj).ToArray();
                FrmViewer.TextData = Encoding.Unicode.GetString(data);
                FrmViewer.ShowDialog();
            }
        }
        public bool SaveToDatabase()
        {
            bool output = false;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("", con);
            System.Data.SqlClient.SqlTransaction trn = null;
            cmd.CommandText = @"INSERT INTO dbo.AppExcelDynamicUpdate (AppExcelDynamicUpdateId, FileName, FilePath, DatasourceID, ExcuteStartDate, ExcuteEndDate, ExcuteResultId, ConnectionName, UserIn, DateIn)
            VALUES (@AppExcelDynamicUpdateId, @FileName, @FilePath, @DatasourceID, @ExcuteStartDate, @ExcuteEndDate, @ExcuteResultId, @ConnectionName, @UserIn, GETDATE())";
            try
            {
                int AppExcelDynamicUpdateId = Convert.ToInt32(adpDynUp.NewId());
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AppExcelDynamicUpdateId", System.Data.SqlDbType.Int) { Value = AppExcelDynamicUpdateId });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar) { Value = _filename });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FilePath", System.Data.SqlDbType.NVarChar) { Value = _filepath });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@DatasourceID", System.Data.SqlDbType.Int) { Value = _datasource.Id });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ExcuteStartDate", System.Data.SqlDbType.DateTime) { Value = _exStartDate });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ExcuteEndDate", System.Data.SqlDbType.DateTime) { Value = _exEndDate });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ExcuteResultId", System.Data.SqlDbType.Int) { Value = _exResult });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ConnectionName", System.Data.SqlDbType.NVarChar) { Value = _conname });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserIn", System.Data.SqlDbType.Int) { Value = Classes.Managers.UserManager.defaultInstance.User.UserId });
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = @"INSERT INTO AppExcelDynamicUpdateParam (AppExcelDynamicUpdateParamId, AppExcelDynamicUpdateId, AppDatasourceParamID, ParamValue)
                VALUES (@AppExcelDynamicUpdateParamId, @AppExcelDynamicUpdateId, @AppDatasourceParamID, @ParamValue)";
                int AppExcelDynamicUpdateParamId = Convert.ToInt32(adpDynUpParam.NewId());
                System.Data.SqlClient.SqlParameter prmAppExcelDynamicUpdateParamId = new System.Data.SqlClient.SqlParameter("@AppExcelDynamicUpdateParamId", System.Data.SqlDbType.Int);
                System.Data.SqlClient.SqlParameter prmAppExcelDynamicUpdateId = new System.Data.SqlClient.SqlParameter("@AppExcelDynamicUpdateId", System.Data.SqlDbType.Int) { Value = AppExcelDynamicUpdateId };
                System.Data.SqlClient.SqlParameter prmAppDatasourceParamID = new System.Data.SqlClient.SqlParameter("@AppDatasourceParamID", System.Data.SqlDbType.Int);
                System.Data.SqlClient.SqlParameter prmParamValue = new System.Data.SqlClient.SqlParameter("@ParamValue", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] { prmAppExcelDynamicUpdateParamId, prmAppExcelDynamicUpdateId, prmAppDatasourceParamID, prmParamValue });
                foreach (ParamBase param in _datasource.Params)
                {
                    prmAppExcelDynamicUpdateParamId.Value = AppExcelDynamicUpdateParamId;
                    prmAppDatasourceParamID.Value = _datasource.Id;
                    prmParamValue.Value = param.ParamValue;
                    AppExcelDynamicUpdateParamId++;
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                output = true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                output = false;
                trn.Rollback();
            }
            con.Close(); cmd.Dispose(); cmd = null; con = null;
            return output;
        }
        public Task ExecuteJob(Microsoft.Office.Interop.Excel.Workbook excelWorkBook)
        {
            return Task.Run(() =>
            {
                //excelApplication.CalculationState = XlCalculationState.xlDone; //excelApplication.WorkbookOpen //excelApplication.AfterCalculate//excelApplication.Workbooks.Open("csharp.net-informations.xls", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                try
                {
                    _runningConnection = GetJobConnection(excelWorkBook);
                    if (_runningConnection == null)
                        return;
                    _runningConnection.OLEDBConnection.CommandText = PrepareCommandText(_datasource);// Set command text
                    _runningConnection.OLEDBConnection.Connection = PrepareConnectionString(false);// Set connection string
                    _runningConnection.OLEDBConnection.SavePassword = false;

                    _exStartDate = DateTime.Now; _exEndDate = DateTime.Now;
                    System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch(); stopWatch.Start();
                    
                    _runningConnection.OLEDBConnection.Refresh();// Execute refresh
                    
                    _exEndDate = DateTime.Now;
                    stopWatch.Stop(); Elapsed = stopWatch.Elapsed;

                    if (_exResult != xlTypes.ExcuteResult.Canceled)
                        _exResult = xlTypes.ExcuteResult.Success;
                    
                    //_runningConnection.OLEDBConnection.Connection = PrepareConnectionString(true);// Remove connection string
                    excelWorkBook.Save();// Save workbook
                    releaseObject(_runningConnection);
                }
                catch (Exception ex)
                {
                    Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
                    _exResult = xlTypes.ExcuteResult.Faild;
                }
            });
        }
        public void CancelExecution()
        {
            if (_runningConnection == null)
                return;
            //if (_runningConnection.OLEDBConnection.Refreshing)
            //{
            //    _runningConnection.OLEDBConnection.CancelRefresh();
            //}
            //_runningConnection.OLEDBConnection.Connection = PrepareConnectionString(true);// Remove connection string
        }
        /// <summary>
        /// Get connection related to this jobn
        /// </summary>
        /// <param name="excelWorkBook">excel workbook that have connection to search for</param>
        /// <returns>excel connection</returns>
        private Microsoft.Office.Interop.Excel.WorkbookConnection GetJobConnection(Microsoft.Office.Interop.Excel.Workbook excelWorkBook)
        {
            Microsoft.Office.Interop.Excel.WorkbookConnection xlcon = null;
            for (int i = 1; i <= excelWorkBook.Connections.Count; i++)// Find connection to execute
            {
                if (excelWorkBook.Connections[i].Name == _conname)
                    return xlcon = excelWorkBook.Connections[i];
            }
            return xlcon;
        }
        /// <summary>
        /// Prepare connection command text to new values
        /// </summary>
        /// <returns> return sp name + paramters in execution format</returns>
        public static string PrepareCommandText(DatasourceBase ds)
        {
            string commandtext = string.Empty;
            commandtext = ds.SP_Name;

            for (int i = 0; i < ds.Params.Count; i++)
            {
                NICSQLTools.Data.dsQry.Get_sp_PramDataTable tblPramType = new Data.dsQryTableAdapters.Get_sp_PramTableAdapter().GetDataByParamName(ds.Params[i].Name, ds.SP_Name);//Get Paramter Information
                string ParamType = ((NICSQLTools.Data.dsQry.Get_sp_PramRow)tblPramType.Rows[0]).type.ToLower();
                string paramPart = string.Empty;
                if (ParamType == "nvarchar" || ParamType == "date" || ParamType == "datetime" || ParamType == "nchar" || ParamType == "ntext" || ParamType == "text")
                    paramPart = string.Format(@" '{0}'", ds.Params[i].ParamValue);
                else
                    paramPart = string.Format(@" {0}", ds.Params[i].ParamValue);
                if (i == 0)
                    commandtext = commandtext + paramPart;
                else
                    commandtext = string.Format("{0}, {1}", commandtext, paramPart); 
            }
            
            return commandtext;
        }
        /// <summary>
        /// Prepare Excel Connection String
        /// </summary>
        /// <param name="servername"></param>
        /// <param name="databaseame"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string PrepareConnectionString(bool Fake)
        {
            if (Fake)
            {
                return string.Format(@"OLEDB;Provider=SQLOLEDB.1;Password={0};Persist Security Info=True;User ID={0};Initial Catalog={0};Data Source={0};Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=MohamedAlyOmarPC;Use Encryption for Data=False;Tag with column collation when possible=False", "RemovedBy" + System.Windows.Forms.Application.ProductName);
            }
            else
            {
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder() { ConnectionString = Properties.Settings.Default.IC_DBConnectionString };
                return string.Format(@"OLEDB;Provider=SQLOLEDB.1;Password={0};Persist Security Info=True;User ID={1};Initial Catalog={2};Data Source={3};Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID={4};Use Encryption for Data=False;Tag with column collation when possible=False", builder.Password, builder.UserID, builder.InitialCatalog, builder.DataSource, Environment.MachineName);
            }
            
        }
        private static void releaseObject(object obj)
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

        #endregion

    }
}
