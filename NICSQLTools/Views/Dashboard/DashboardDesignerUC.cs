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
using log4net;
using DevExpress.XtraSplashScreen;
using NICSQLTools.Classes.Managers;

namespace NICSQLTools.Views.Dashboard
{
    public partial class DashboardDesignerUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(DashboardDesignerUC));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        NICSQLTools.Data.dsData.AppDashboardSchemaDataTable schemaTBL = new NICSQLTools.Data.dsData.AppDashboardSchemaDataTable();
        NICSQLTools.Data.dsData.AppDashboardSchemaRow DashboardSchema = null;
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        #endregion
        #region -   Functions   -
        public DashboardDesignerUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    dashboardDesignerMain.Dashboard.DataSources.Clear();
                    //Load All Saved Data Sources
                    appDashboardDSTableAdapter.Fill(dsData.AppDatasource);
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            
            if (!_elementRule.Updateing)
                bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            if (!_elementRule.Inserting)
            {
                bbiNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiSaveAs.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }
        #endregion
        #region -   EventWhnd   -
        private void DashboardDesignerUC_Load(object sender, EventArgs e)
        {
            LoadData();
            DashboardSchema = schemaTBL.NewAppDashboardSchemaRow();
            ActivateRules();
        }
        private void bbiAddDatasource_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DatasourceOpenDlg dlg = new DatasourceOpenDlg(Uti.Types.AppDatasourceTypeIdEnum.Dashboard);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            NICSQLTools.Data.Linq.vAppDatasource_LUE dsRow = dlg.DataSourceRow;
            //Check if this DS Already Added Before
            foreach (DevExpress.DashboardCommon.DataSource item in dashboardDesignerMain.Dashboard.DataSources)
            {
                if (item.ComponentName == "ID" + dsRow.DatasourceID)
                    return;
            }
            DataTable DSTbl = DataManager.GetStoredProcedureSchema(dsRow.DatasourceSPName);//Get Stored Procedure Schema
            //Add Data Source To Dashboard Data Sources List
            dashboardDesignerMain.Dashboard.DataSources.Add(Classes.Dashboard.CreateDashboardDatasource(DSTbl, dsRow.DatasourceName, dsRow.DatasourceID));
        }
        private void bbiOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DashboardOpenDlg dlg = new DashboardOpenDlg(_elementRule);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            DashboardSchema  = appDashboardSchemaTableAdapter.GetDataByDashboardSchemaId(dlg.DashboardSchemaId)[0];
            dashboardDesignerMain.Dashboard.LoadFromXml(new System.IO.MemoryStream(DashboardSchema.DashboardSchemaData));
            
            DataManager.RefreshDatasourceSchema(ref dashboardDesignerMain);
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            DashboardSchema = schemaTBL.NewAppDashboardSchemaRow();
            DashboardSchema.DashboardSchemaName = "New Dashboard";
            dashboardDesignerMain.Dashboard = new DevExpress.DashboardCommon.Dashboard();
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Open Choose Name dialog With Name If Existed
            NICSQLTools.Views.Main.ChooseSaveNameDlg dlg = null;
            if (DashboardSchema.DashboardSchemaId == -1)
                dlg = new NICSQLTools.Views.Main.ChooseSaveNameDlg();
            else
                dlg = new NICSQLTools.Views.Main.ChooseSaveNameDlg(DashboardSchema.DashboardSchemaName);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            DashboardSchema.DashboardSchemaName = dlg.SavingName;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            dashboardDesignerMain.Dashboard.SaveToXml(ms);
            DashboardSchema.DashboardSchemaData = ms.ToArray();
            if (DashboardSchema.DashboardSchemaId == -1)//Should Insert New Dashboard
            {
                int? ID = Classes.Dashboard.InsertDashboard(DashboardSchema);
                if (ID != null)
                {
                    DashboardSchema.DashboardSchemaId = (int)ID;
                    MsgDlg.Show("Dashboard Saved ...", MsgDlg.MessageType.Success);
                }
                else
                    MsgDlg.Show("Dashboard didn't saved", MsgDlg.MessageType.Error);
            }
            else//Should Update Existed Dashboard
            {
                Classes.Dashboard.UpdateDashboardSchema(DashboardSchema);
                MsgDlg.Show("Dashboard Updated ...", MsgDlg.MessageType.Success);
            }
        }
        private void bbiSaveAs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Open Choose Name dialog
            NICSQLTools.Views.Main.ChooseSaveNameDlg dlg = new NICSQLTools.Views.Main.ChooseSaveNameDlg();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            DashboardSchema.DashboardSchemaName = dlg.SavingName;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            dashboardDesignerMain.Dashboard.SaveToXml(ms);
            DashboardSchema.DashboardSchemaData = ms.ToArray();

            int? ID = Classes.Dashboard.InsertDashboard(DashboardSchema);
            if (ID != null)
            {
                DashboardSchema = appDashboardSchemaTableAdapter.GetDataByDashboardSchemaId((int)ID)[0];
                MsgDlg.Show("Dashboard Saved ...", MsgDlg.MessageType.Success);
            }
            else
                MsgDlg.Show("Dashboard didn't saved", MsgDlg.MessageType.Error);

        }
        #endregion}

        
    }
}
