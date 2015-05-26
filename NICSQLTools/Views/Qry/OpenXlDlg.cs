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
        Classes.QueryLayout.DatasourceStrc DataSourceList = new Classes.QueryLayout.DatasourceStrc();
        List<Control> LayoutControlList = new List<Control>();
        List<string> ProgressList = new List<string>();
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.dsQry.vAppDatasourceForUserRow _selectedDatasource = null;

        NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter appDashboardDSTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppDatasourceTableAdapter();
        NICSQLTools.Data.dsDataTableAdapters.AppDatasourceParamTableAdapter appDashboardDSPramTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppDatasourceParamTableAdapter();
        NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter get_sp_PramTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter();

        public NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateDataTable _m_DynTbl = new NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateDataTable();
        public  NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateParamDataTable _m_DynParamTbl = new NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateParamDataTable();

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
        #endregion
        private void wizardControlMain_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.PrevPage == OpenExcelWizardPage)
            {
                if (!beOpenFile.DoValidate())
                    e.Cancel = true;
                
                List<DataTable> lst = Classes.msExcel.DynamicRefresh.DynamicRefresh.GetExcelConnections(beOpenFile.EditValue.ToString());
                _m_DynTbl = (NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateDataTable)lst[0]; _m_DynParamTbl = (NICSQLTools.Data.dsDataSource.AppExcelDynamicUpdateParamDataTable)lst[1];
                if (_m_DynTbl.Count == 0)
                {
                    MsgDlg.Show("Can't find any known connection", MsgDlg.MessageType.Info);
                    e.Cancel = true;
                }
                else
                    CreateDatasourceControls();
            }
            else if (e.PrevPage == ParamtersWizardPage)
            {
                //i should validate paramters before continue
            }
            else if (e.PrevPage == completionWizardPage)
            {
                // completed validation
            }

        }
        private async void CreateDatasourceControls()
        {
            DataSourceList = new Classes.QueryLayout.DatasourceStrc(); DataSourceList.Controls = new Dictionary<string, Control>(); //Inti Datasource
            await CreateDatasourceAsync(_m_DynTbl[0].DatasourceID);
            //Add Controls To Form
            CreateLayout(DataSourceList);
        }
        private Task CreateDatasourceAsync(int DatasourceID)
        {
            return Task.Run(() =>
            {
                NICSQLTools.Data.dsData.AppDatasourceRow DashboardDSRow = appDashboardDSTableAdapter.GetDataByDatasourceID(DatasourceID)[0];// Get information About DatasourceID
                NICSQLTools.Data.dsData.AppDatasourceParamDataTable dtParam = appDashboardDSPramTableAdapter.GetDataByDatasourceID(DatasourceID);// Get Paramters Information For DatasourceID

                DataSourceList.DashboadId = DatasourceID;
                DataSourceList.DatasourceName = DashboardDSRow.DatasourceName;
                DataSourceList.DatasourceSPName = DashboardDSRow.DatasourceSPName;

                //Create All Datasource Paramters
                foreach (NICSQLTools.Data.dsData.AppDatasourceParamRow ParamRow in dtParam.Rows)
                {
                    NICSQLTools.Data.dsQry.Get_sp_PramDataTable tblPramType = get_sp_PramTableAdapter.GetDataByParamName(ParamRow.ParamName, DashboardDSRow.DatasourceSPName);//Get Paramter Information
                    string ParamType = string.Empty;
                    if (tblPramType.Rows.Count == 0)
                        ParamType = "NVARCHAR";
                    else
                        ParamType = ((NICSQLTools.Data.dsQry.Get_sp_PramRow)tblPramType.Rows[0]).type;
                    //Create Control For Parameter
                    Control item = CreateDSElement(ParamRow, ParamType);
                    //Add Control to Datasource Controls List
                    DataSourceList.Controls.Add(ParamRow.ParamName, item);
                }
                //Create Refresh Button For Datasource
                SimpleButton btnHelp = new SimpleButton();
                btnHelp.Image = global::NICSQLTools.Properties.Resources.refresh2_16x16;
                btnHelp.Name = String.Format("btnHelp{0}{1}", DashboardDSRow.DatasourceSPName, DatasourceID);
                btnHelp.Size = new Size(170, 22);
                btnHelp.Location = new Point(120, layoutControlMain.Controls.Count * 23);
                btnHelp.Text = "Refresh " + DashboardDSRow.DatasourceName;
                btnHelp.StyleController = layoutControlMain;
                btnHelp.Click += btnHelp_Click; btnHelp.Tag = DatasourceID;

                //Add Buttons to Datasource Controls List
                DataSourceList.ExeButton = btnHelp;
            });

        }
        private Control CreateDSElement(NICSQLTools.Data.dsData.AppDatasourceParamRow ParamRow, string ParamType)
        {
            object ctr = null;
            if (!ParamRow.IsLookupIDNull())
            {
                ctr = CreateLookupedit(ParamRow.LookupID);
            }
            else
            {
                switch (ParamType.ToLower())
                {
                    case "nvarchar":
                        TextEdit txt1 = new TextEdit();
                        txt1.Name = String.Format("ctr{0}{1}{2}", ParamRow.ParamName, ParamRow.AppDatasourceParamID, ParamRow.DatasourceID);
                        ctr = txt1;
                        break;
                    case "int":
                    case "smallint":
                    case "bigint":
                        TextEdit txt2 = new TextEdit();
                        txt2.Name = String.Format("ctr{0}{1}{2}", ParamRow.ParamName, ParamRow.AppDatasourceParamID, ParamRow.DatasourceID);
                        txt2.Properties.DisplayFormat.FormatString = "n0";
                        txt2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        txt2.Properties.EditFormat.FormatString = "n0";
                        txt2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        txt2.Properties.Mask.EditMask = "n0";
                        txt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        ctr = txt2;
                        break;
                    case "float":
                        TextEdit txt3 = new TextEdit();
                        txt3.Name = String.Format("ctr{0}{1}{2}", ParamRow.ParamName, ParamRow.AppDatasourceParamID, ParamRow.DatasourceID);
                        txt3.Properties.DisplayFormat.FormatString = "f2";
                        txt3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        txt3.Properties.EditFormat.FormatString = "f2";
                        txt3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        txt3.Properties.Mask.EditMask = "f2";
                        txt3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        ctr = txt3;
                        break;
                    case "datetime":
                        DateEdit de1 = new DateEdit();
                        de1.EditValue = null;
                        de1.Name = String.Format("ctr{0}{1}{2}", ParamRow.ParamName, ParamRow.AppDatasourceParamID, ParamRow.DatasourceID);
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


            ((TextEdit)ctr).Properties.NullValuePrompt = ParamRow.ParamDisplayName;
            return (Control)ctr;
        }
        private void CreateLayout(Classes.QueryLayout.DatasourceStrc ds)
        {
            layoutControlGroupMain.Clear();
            for (int i = 0; i < LayoutControlList.Count; i++)
            {
                LayoutControlList[i].Dispose();
                LayoutControlList[i] = null;
            }
            LayoutControlList.Clear();
            
            LayoutControlGroup LayGroup = layoutControlGroupMain.AddGroup();
            LayGroup.Text = ds.DatasourceName;
            foreach (KeyValuePair<string, Control> item in ds.Controls)
            {
                layoutControlMain.Controls.Add(item.Value);

                LayoutControlItem layItem = LayGroup.AddItem();
                layItem.Text = ((TextEdit)item.Value).Properties.NullValuePrompt;
                layItem.Control = item.Value;
            }
            //Add Refresh button
            LayoutControlItem layItemBtnRefresh = LayGroup.AddItem(string.Empty, ds.ExeButton);
            layItemBtnRefresh.TextVisible = false;
            //Add Cancel button
            LayoutControlItem layItemBtnCancel = LayGroup.AddItem(string.Empty, ds.CancelButton);
            layItemBtnCancel.TextVisible = false;

        }
        private CheckedComboBoxEdit CreateLookupedit(int LookupID)
        {
            List<object> data = NICSQLTools.Classes.Managers.DataManager.ExeDSLookup(LookupID);
            CheckedComboBoxEdit ccbe = new CheckedComboBoxEdit();
            ccbe.Properties.AllowMultiSelect = true;
            ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            ccbe.Properties.DataSource = Classes.Managers.UserManager.defaultInstance.LookupUserValue((DataTable)data[0], data[2].ToString(), LookupID);
            ccbe.Properties.DisplayMember = data[1].ToString();
            ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ccbe.Properties.ValueMember = data[2].ToString();
            ccbe.EditValueChanged += new EventHandler((e, o) =>
            { ((CheckedComboBoxEdit)e).RefreshEditValue(); });//validate edit value to do not select out of list items
            return ccbe;
        }
        void btnHelp_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            int dsID = Convert.ToInt32(btn.Tag);
            if (Classes.QueryLayout.ChekForEmptyPram(DataSourceList))
            {
                MsgDlg.Show("Please fill all paramters for data source: " + DataSourceList.DatasourceName, MsgDlg.MessageType.Info);
                return;
            }
            MessageBox.Show("Under Dev. ...");
        }
    }
}