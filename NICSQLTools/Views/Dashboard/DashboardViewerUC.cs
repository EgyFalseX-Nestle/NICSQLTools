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
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;

namespace NICSQLTools.Views.Dashboard
{
    public partial class DashboardViewerUC : DevExpress.XtraEditors.XtraUserControl
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DashboardViewerUC));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        List<Classes.Dashboard.DatasourceStrc> DataSourceList = new List<Classes.Dashboard.DatasourceStrc>();
        public DashboardViewerUC()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    LSMSSchema.QueryableSource = from q in dsLinq.AppDashboardSchemas select q;
                    LSMSUser.QueryableSource = from q in dsLinq.Users select q;
                }));
                SplashScreenManager.CloseForm();
            });
        }
        private void DashboardViewerUC_Load(object sender, EventArgs e)
        {
            LoadDefaultData();

            //TextEdit txt1 = new TextEdit();
            //layoutControlParamter.Controls.Add(txt1);
            //txt1.Location = new Point(120, 43);
            //txt1.Name = "textEdit1";
        }
        private void btnLoadDashboard_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(lueDashboard.EditValue))
                return;

            NICSQLTools.Data.dsData.AppDashboardSchemaRow SchemaRow = appDashboardSchemaTableAdapter.GetDataByDashboardSchemaId(Convert.ToInt32(lueDashboard.EditValue))[0];//Load Selected Schema Data From Database
            dashboardViewerMain.LoadDashboard(new System.IO.MemoryStream(SchemaRow.DashboardSchemaData));//Load Schema Into Viewer
            
            for (int i = 0; i < dashboardViewerMain.Dashboard.DataSources.Count; i++)
            {
                Classes.Dashboard.DatasourceStrc ds = new Classes.Dashboard.DatasourceStrc();//Struc for Datasource Controls
                ds.Controls = new Dictionary<string, Control>();

                int DatasourceID = Convert.ToInt32(dashboardViewerMain.Dashboard.DataSources[i].ComponentName.Replace(Classes.Dashboard.ComponentNamePerfix, string.Empty));
                CreateDatasource(DatasourceID, ref ds);
                
                DataSourceList.Add(ds);
            }
            

        }
        private void CreateDatasource(int DatasourceID, ref Classes.Dashboard.DatasourceStrc ds)
        {
            NICSQLTools.Data.dsData.AppDashboardDSRow DashboardDSRow = appDashboardDSTableAdapter.GetDataByDatasourceID(DatasourceID)[0];
            NICSQLTools.Data.dsData.AppDashboardDSPramDataTable dtParam = appDashboardDSPramTableAdapter.GetDataByDatasourceID(DatasourceID);

            ds.DashboadId = DatasourceID;
            ds.DatasourceName = DashboardDSRow.DatasourceName;
            ds.DatasourceSPName = DashboardDSRow.DatasourceSPName;

            //Create Data Source Group
            DevExpress.XtraLayout.LayoutControlGroup GroupPramX = new DevExpress.XtraLayout.LayoutControlGroup();
            GroupPramX.Name = String.Format("lcg{0}{1}", DashboardDSRow.DatasourceSPName, DashboardDSRow.DatasourceID);
            GroupPramX.Text = DashboardDSRow.DatasourceName; GroupPramX.CustomizationFormText = DashboardDSRow.DatasourceName;
            layoutControlGroupParamters.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { GroupPramX });
            if (layoutControlGroupParamters.Items.Count == 0)
                GroupPramX.Location = new Point(10, 10);
            else
                GroupPramX.Location = new Point(0, layoutControlGroupParamters.Items[layoutControlGroupParamters.Items.Count - 1].Location.Y + layoutControlGroupParamters.Items[layoutControlGroupParamters.Items.Count - 1].Size.Height);
            //Add Group to Paramters Group
            ///////////////////////////////layoutControlParamter.Controls.Add(GroupPramX);
            
            
            //Create All Datasource Paramters
            //foreach (NICSQLTools.Data.dsData.AppDashboardDSPramRow ParamRow in dtParam.Rows)
            //{
            //    NICSQLTools.Data.dsQry.Get_sp_PramDataTable tblPramType = get_sp_PramTableAdapter.GetDataByParamName(ParamRow.PramName, DashboardDSRow.DatasourceSPName);
            //    string ParamType = string.Empty;
            //    if (tblPramType.Rows.Count == 0)
            //    {
            //        ParamType = "NVARCHAR";
            //    }
            //    else
            //    {
            //        ParamType = ((NICSQLTools.Data.dsQry.Get_sp_PramRow)tblPramType.Rows[0]).type;
            //    }
            //    //Create and Add Item to Datasource Group
            //    DevExpress.XtraLayout.LayoutControlItem item = CreateDSElement(ParamRow, ParamType);
            //    GroupPramX.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { item });
            //    //Add Control to Datasource Controls List
            //    ds.Controls.Add(ParamRow.PramName, item.Control);
            //}
            ////Create btn for refresh here.....
            //DevExpress.XtraLayout.LayoutControlItem ElementRefresh = new DevExpress.XtraLayout.LayoutControlItem();
            //ElementRefresh.Name = String.Format("lci{0}{1}", DashboardDSRow.DatasourceSPName, DatasourceID); ElementRefresh.TextVisible = false;
            //ElementRefresh.Location = new Point(0, 0); ElementRefresh.Size = new Size(174, 24); ElementRefresh.TextSize = new Size(93, 13);

            //SimpleButton btnRefresh = new SimpleButton();
            //btnRefresh.Image = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            //btnRefresh.Name = String.Format("btnRefresh{0}{1}", DashboardDSRow.DatasourceSPName, DatasourceID);
            //btnRefresh.Size = new Size(170, 22);
            //btnRefresh.Location = new Point(120, layoutControlParamter.Controls.Count * 23);
            //btnRefresh.Text = "Refresh " + DashboardDSRow.DatasourceName;
            //btnRefresh.StyleController = layoutControlParamter;
            //btnRefresh.Click += btnRefresh_Click; btnRefresh.Tag = DatasourceID;
            //layoutControlGroupParamters.Add(ElementRefresh);
            //layoutControlParamter.Controls.Add(btnRefresh);

            ////Create btn for cancel here.....
            //DevExpress.XtraLayout.LayoutControlItem ElementCancel = new DevExpress.XtraLayout.LayoutControlItem();
            //ElementCancel.Name = String.Format("lci{0}{1}", DashboardDSRow.DatasourceSPName, DatasourceID); ElementCancel.TextVisible = false;
            //ElementCancel.Location = new Point(0, 0); ElementCancel.Size = new Size(174, 24); ElementCancel.TextSize = new Size(93, 13);

            //SimpleButton btnCancel = new SimpleButton();
            //btnCancel.Image = global::NICSQLTools.Properties.Resources.cancel_16x16;
            //btnCancel.Name = String.Format("btnCancel{0}{1}", DashboardDSRow.DatasourceSPName, DatasourceID);
            //btnCancel.Size = new Size(170, 22);
            //btnCancel.Location = new Point(120, btnRefresh.Location.Y + 21);
            //btnCancel.StyleController = layoutControlParamter;
            //btnCancel.Text = "Cancel";
            //btnCancel.Enabled = false;
            //btnCancel.Click += btnCancel_Click; btnCancel.Tag = DatasourceID;
            //layoutControlGroupParamters.Add(ElementCancel);
            //layoutControlParamter.Controls.Add(btnCancel);
            

            ////Add Control to Datasource Controls List
            //ds.ExeButton = btnRefresh;
            //ds.CancelButton = btnCancel;
        }
        private DevExpress.XtraLayout.LayoutControlItem CreateDSElement(NICSQLTools.Data.dsData.AppDashboardDSPramRow ParamRow, string ParamType)
        {
            
            object ctr = null;
            DevExpress.XtraLayout.LayoutControlItem Element = new DevExpress.XtraLayout.LayoutControlItem();
            Element.Name = String.Format("lci{0}{1}", ParamRow.PramName, ParamRow.DatasourceID);
            Element.Text = ParamRow.PramDisplayName;
            Element.Size = new Size(174, 24); Element.TextSize = new Size(93, 13);
            Element.Location = new Point(0, layoutControlParamter.Controls.Count * 23);


            switch (ParamType.ToLower())
            {
                case"nvarchar":
                    TextEdit txt1 = new TextEdit();
                    txt1.Name = String.Format("ctr{0}{1}{2}", ParamRow.PramName, ParamRow.DatasourcePramID, ParamRow.DatasourceID);
                    ctr = txt1;
                    break;
                case "int":
                case "smallint":
                case "bigint":
                    break;
                    TextEdit txt2 = new TextEdit();
                    txt2.Name = String.Format("ctr{0}{1}{2}", ParamRow.PramName, ParamRow.DatasourcePramID, ParamRow.DatasourceID);
                    txt2.Properties.DisplayFormat.FormatString = "n0";
                    txt2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    txt2.Properties.EditFormat.FormatString = "n0";
                    txt2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    txt2.Properties.Mask.EditMask = "n0";
                    txt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    ctr = txt2;
                case "float":
                    TextEdit txt3 = new TextEdit();
                    txt3.Name = String.Format("ctr{0}{1}{2}", ParamRow.PramName, ParamRow.DatasourcePramID, ParamRow.DatasourceID);
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
                    de1.Name = String.Format("ctr{0}{1}{2}", ParamRow.PramName, ParamRow.DatasourcePramID, ParamRow.DatasourceID);
                    de1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                    de1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
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
            Element.Control = (Control)ctr;
            Element.Control.Location = new Point(120, layoutControlParamter.Controls.Count * 23);

            layoutControlParamter.Controls.Add((Control)ctr);

            return Element;
        }
        void btnRefresh_Click(object sender, EventArgs e)
        {
            lciWait.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            SimpleButton btn = (SimpleButton)sender;
            int dsID = Convert.ToInt32(btn.Tag);
            int inx = -1;
            for (int i = 0; i < DataSourceList.Count; i++)
            {
                if (DataSourceList[i].DashboadId == dsID)
                {
                    inx = i;
                    break;
                }
            }
            if (Classes.Dashboard.ChekForEmptyPram(DataSourceList[inx]))
            {
                MsgDlg.Show("Please Fill All Paramters For Data Source: " + DataSourceList[inx].DatasourceName, MsgDlg.MessageType.Info);
                return;
            }
            //Executing SP
            Dictionary<string, object> Paramters = new Dictionary<string, object>();
            foreach (KeyValuePair<string, Control> ctrItem in DataSourceList[inx].Controls)
                Paramters.Add(ctrItem.Key, ((TextEdit)ctrItem.Value).EditValue);

            //UpdateInfo SpNotify = new UpdateInfo();
            //SpNotify.OnItemChanged += SpNotify_OnItemChanged;
            DataSourceList[inx].ExeButton.Enabled = false;
            DataSourceList[inx].CancelButton.Enabled = true;
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                DataManager.ExeDataSource(DataSourceList[inx].DatasourceSPName, Paramters, DataSourceList[inx].Execommand, StoredProcedure_InfoMessage, SelectCommand_StatementCompleted);
                Invoke(new MethodInvoker(() => 
                {
                    lciWait.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }));
            });
            

        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            int dsID = Convert.ToInt32(btn.Tag);
            int inx = -1;
            for (int i = 0; i < DataSourceList.Count; i++)
            {
                if (DataSourceList[i].DashboadId == dsID)
                {
                    inx = i;
                    break;
                }
            }
            if (inx != -1)
            {
                try
                {
                    DataSourceList[inx].ExeButton.Enabled = true;
                    DataSourceList[inx].CancelButton.Enabled = false;

                    if (DataSourceList[inx].Execommand != null)
                    {
                        DataSourceList[inx].Execommand.Cancel();
                    }
                }
                catch (SqlException ex)
                {
                    Logger.Error(ex.Message, ex);
                }
                
            }
        }
        static void StoredProcedure_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            foreach (SqlError error in e.Errors)
            {
                Logger.Error(String.Format("Error While Execute StoredProcedure: {0} - {1}", error.Procedure, error.Message));
            }

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormCaption("Updating .......");


        }
        static void SelectCommand_StatementCompleted(object sender, StatementCompletedEventArgs e)
        {
            
            throw new NotImplementedException();
        }

    }
}
