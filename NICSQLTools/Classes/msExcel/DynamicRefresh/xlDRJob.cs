using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace NICSQLTools.Classes.msExcel.DynamicRefresh
{
    public class xlDRJob
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(xlDRJob));
        NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter adpDS = new NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter();
        NICSQLTools.Data.dsDataTableAdapters.AppDatasourceParamTableAdapter _adpParam = new Data.dsDataTableAdapters.AppDatasourceParamTableAdapter();
        NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter adp_spInfo = new Data.dsQryTableAdapters.Get_sp_PramTableAdapter();
        NICSQLTools.Views.Main.rtfTextViewerFrm FrmViewer;
        DevExpress.XtraLayout.LayoutControl _layoutControlMain;
        DevExpress.XtraLayout.LayoutControlGroup _layoutControlGroupMain;

        #region  - Properties - 

        private int _id;
        private bool _knownJob;
        private string _filename;
        private string _filepath;
        private DatasourceBase _datasource;
        private DateTime _exStartDate;
        private DateTime _exEndDate;
        private xlTypes.ExcuteResult _exResult;
        private Workbook _xlworkbook;
        private WorkbookConnection _xlconnection;
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
        public xlTypes.ExcuteResult ExResult
        {
            get { return _exResult; }
            set { _exResult = value; }
        }
        public string ConName
        {
            get { return _xlconnection.Name; }
            set { _xlconnection.Name = value; }
        }
        public Workbook xlWorkbook
        {
            get { return _xlworkbook; }
            set { _xlworkbook = value; }
        }
        public WorkbookConnection xlconnection
        {
            get { return _xlconnection; }
            set { _xlconnection = value; }
        }
        public DevExpress.XtraEditors.SimpleButton _btnHelp { get; set; }

        #endregion
        #region  - Functions - 
        public xlDRJob(string filepath)
        {
            _filepath = filepath;
            _filename = System.IO.Path.GetFileName(filepath);
            _exResult = xlTypes.ExcuteResult.Ready;
        }
        public static xlDRJob? GetJob(string filepath, Workbook wb, int conInx, DevExpress.XtraLayout.LayoutControl layoutctr, DevExpress.XtraLayout.LayoutControlGroup layoutgroup)
        {
            xlDRJob job = new xlDRJob(filepath) { _xlworkbook = wb, _xlconnection = wb.Connections[conInx] };

            if (job._xlconnection.Type != XlConnectionType.xlConnectionTypeOLEDB)// bad connection type
                return null;
            if (job._xlconnection.OLEDBConnection.CommandType != XlCmdType.xlCmdSql)// bad command type
                return null;
            if (!SetDatasourceIdAndParam(job._xlconnection.OLEDBConnection.CommandText))// check if command is known and set datasource
                return null;
            job._layoutControlMain = layoutctr;// Set Main Layout Control
            job._layoutControlGroupMain = layoutgroup;// Set Main LayoutGroup
            job.CreateDatasourceControls();// Create Datasource Layout Controls
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
                if (row.DatasourceSPName.ToLower() == spName.ToLower())
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
                List<string> lst = new List<string>();
                string[] param = paramText.Trim().Split(',');
                foreach (string item in param)
                    lst.Add(item.Replace('\'', ' ').Trim());

                NICSQLTools.Data.dsData.AppDatasourceParamDataTable tbl = _adpParam.GetDataByDatasourceID(_datasource.Id);
                for (int i = 0; i < tbl.Count; i++)
                {
                    string val;
                    if (i <= lst.Count)
                        val = lst[i];
                    else
                        val = string.Empty;
                    _datasource.Params.Add(new ParamBase() { Id = tbl[i].AppDatasourceParamID, Name = tbl[i].ParamName, DisplayName = tbl[i].ParamDisplayName, ParamValue = val, Lookup = tbl[i].LookupID });
                }
                output = true;
            }
            catch (Exception ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
            }
            return output;
        }

        private async void CreateDatasourceControls()
        {
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
                _btnHelp.Text = "show help " + Datasource.Name;
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
                        de1.Properties.DisplayFormat.FormatString = "d/M/yyyy";
                        de1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                        de1.Properties.EditFormat.FormatString = "d/M/yyyy";
                        de1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                        de1.Properties.Mask.EditMask = "d/M/yyyy";
                        de1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                        ctr = de1;
                        break;
                    default:
                        break;
                }
            }
            ((DevExpress.XtraEditors.TextEdit)ctr).Properties.NullValuePrompt = param.DisplayName;
            ((DevExpress.XtraEditors.TextEdit)ctr).EditValue = param.ParamValue;
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
            DevExpress.XtraLayout.LayoutControlItem layItemBtnRefresh = LayGroup.AddItem(string.Empty, _btnHelp);
            layItemBtnRefresh.TextVisible = false;
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

        #endregion

    }
}
