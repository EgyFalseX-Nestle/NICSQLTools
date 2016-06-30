using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views;
using System.Drawing;
using System.Linq;
using System;
using NICSQLTools.Views.Data.MSrv.Ticket;

namespace NICSQLTools.Views.Main
{
    public partial class MainTilesFrm : XtraForm
    {
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MainTilesFrm));
        #endregion
        #region -   Functions   -
        private void AddGeneralButtions()
        {

            //Minimize Button
            DelegateAction btnMinimize = new DelegateAction(() => { return true; }, () =>
            {
                WindowState = System.Windows.Forms.FormWindowState.Minimized;
            });
            btnMinimize.Type = ActionType.Navigation;
            btnMinimize.Caption = "Minimize";
            btnMinimize.Behavior = ActionBehavior.Default;
            btnMinimize.Edge = ActionEdge.Default;
            btnMinimize.Image = Properties.Resources.next_32x32;
            windowsUIView.ContentContainerActions.Add(btnMinimize);
        }
        public void AddPrivateButtions()
        {
            //User Setting Button
            DelegateAction btnUserSettings = new DelegateAction(() => { return true; }, () =>
            {
                windowsUIView.Controller.Activate(pageUserSettings);
            });
            btnUserSettings.Type = ActionType.Context;
            btnUserSettings.Caption = "User Settings";
            btnUserSettings.Behavior = ActionBehavior.HideBarOnClick;
            btnUserSettings.Edge = ActionEdge.Left;
            btnUserSettings.Image = Properties.Resources.ide_32x32;
            windowsUIView.ContentContainerActions.Add(btnUserSettings);

        }
        public MainTilesFrm()
        {
            InitializeComponent();
            windowsUIView.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;

            //dataSource = new SampleDataSource();
            //groupsItemDetailPage = new Dictionary<SampleDataGroup, PageGroup>();
            //CreateLayout();
            AddGeneralButtions();

            //new TestFrm().ShowDialog();


        }
        public void ActivateRules()
        {
            if (Classes.Managers.UserManager.defaultInstance.User.IsAdmin == true)
                return;

            foreach (var item in windowsUIView.ContentContainers.ToArray())
            {
                if (item.GetType() == typeof(TileContainer))
                {
                    for (int InxContainers = 0; InxContainers < ((TileContainer)item).Items.Count; InxContainers++)
                    {
                        TileContainer cntr = (TileContainer)item;
                        for (int i = (cntr).Items.Count - 1; i >= 0; i--)
                        {
                            Tile tile = (Tile)(cntr).Items[i];
                            NICSQLTools.Data.dsData.AppRuleDetailRow elementRule = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(tile.Document.ControlName);
                            if (tile.Tag != null && (bool)tile.Tag)// Show Exception Tiles
                                tile.Visible = true;
                            else
                                tile.Visible = elementRule.Selecting;
                        }
                    }
                }
                else if (item.GetType() == typeof(TabbedGroup))
                {
                    TabbedGroup TGroup = (TabbedGroup)item;
                    for (int i = TGroup.Items.Count - 1; i >= 0; i--)
                    {
                        Document doc = ((TabbedGroup)item).Items[i];
                        NICSQLTools.Data.dsData.AppRuleDetailRow elementRule = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(doc.ControlName);
                        if (!elementRule.Selecting)
                            TGroup.Items.Remove(doc);
                    }
                }
            }

            //foreach (var item in windowsUIView.ContentContainers.ToArray())
            //{
            //    if (item.GetType() != typeof(TileContainer))//Apply Only For Tiles Containers 
            //        continue;

            //    if (((TileContainer)item).Items == null)
            //        continue;
            //    for (int InxContainers = 0; InxContainers < ((TileContainer)item).Items.Count; InxContainers++)
            //    {
            //        TileContainer cntr = (TileContainer)item;
            //        for (int i = (cntr).Items.Count - 1; i >= 0; i--)
            //        {
            //            Tile tile = (Tile)(cntr).Items[i];
            //            NICSQLTools.Data.dsData.AppRuleDetailRow elementRule = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(tile.Document.ControlName);
            //            if (tile.Tag != null && (bool)tile.Tag)// Show Exception Tiles
            //                tile.Visible = true;
            //            else
            //                tile.Visible = elementRule.Selecting;
            //        }
            //    }
            //}
            //Remove parent if all child are invisible
            documentTileEditors.Visible = IsTileContainerContainVisibleItem(tileContainerEditors);
            documentTileQueries.Visible = IsTileContainerContainVisibleItem(tileContainerQueries);
            documentTileRules.Visible = IsTileContainerContainVisibleItem(tileContainerRules);
            documentTileReports.Visible = IsTileContainerContainVisibleItem(tileContainerReports);
            documentTileDashboard.Visible = IsTileContainerContainVisibleItem(tileContainerDashboard);
        }
        private static bool IsTileContainerContainVisibleItem(TileContainer cont)
        {
            for (int InxContainers = 0; InxContainers < ((TileContainer)cont).Items.Count; InxContainers++)
            {
                for (int i = (cont).Items.Count - 1; i >= 0; i--)
                {
                    Tile tile = (Tile)(cont).Items[i];
                    if (tile.Visible == true)
                        return true;
                }
            }
            return false;
        }
        public void LoadLayout()
        {
            // Load Layout Saved Settings
            string FileName = Program.TilesLayoutFile + Classes.Managers.UserManager.defaultInstance.User.UserId.ToString();
            if (System.IO.File.Exists(FileName))
            {
                //backup
                System.IO.MemoryStream Resert_ms = new System.IO.MemoryStream();
                windowsUIView.SaveLayoutToStream(Resert_ms);
                string currentVersion = windowsUIView.OptionsLayout.LayoutVersion;

                System.IO.FileStream Fs = new System.IO.FileStream(FileName, System.IO.FileMode.Open);
                //TilesLayoutFile
                windowsUIView.RestoreLayoutFromStream(Fs);
                //if (windowsUIView.OptionsLayout.LayoutVersion != currentVersion)//Rollback is version is not the same
                //    windowsUIView.RestoreLayoutFromStream(Resert_ms);
            }
        }
       
        
        #endregion
        #region -   EventWhnd   -
        private void MainTilesFrm_Load(object sender, EventArgs e)
        {
            LoadLayout();
        }
        private void windowsUIView_QueryControl(object sender, QueryControlEventArgs e)
        {
            NICSQLTools.Data.dsData.AppRuleDetailRow RuleElemet = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(e.Document.ControlName);
            if (e.Control != null)
                return;
            if (e.Document == docLogin)
            {
                e.Control = new LoginUC();
            }
            else if (e.Document == docUserSetting)
            {
                e.Control = new UserSettingsUC();
            }

            else if (e.Document == docRuleUser)//----------------------- Rules
            {
                e.Control = new Permission.UserUC(RuleElemet);
            }
            else if (e.Document == docRuleRule)
            {
                e.Control = new Permission.RuleUC(RuleElemet);
            }
            else if (e.Document == docRuleUserRule)
            {
                e.Control = new Permission.UserRuleUC(RuleElemet);
            }
            else if (e.Document == docRuleRuleDetails)
            {
                e.Control = new Permission.RuleDetailsUC(RuleElemet);
            }
            else if (e.Document == docRuleRuleSalesDisitrct3)
            {
                e.Control = new Permission.RuleSalesDisitrct3UC(RuleElemet);
            }

            else if (e.Document == docQueriesQryPivot)//----------------------- Queries
            {
                e.Control = new Qry.QryPivotUC(RuleElemet);
            }
            else if (e.Document == docQueriesQryCustomerInfo)
            {
                e.Control = new Qry.QryCustomerInfoUC(RuleElemet);
            }
            else if (e.Document == docQueriesExcelDynamicUpdate)
            {
                e.Control = new Qry.ExcelDynamicUpdateUC(RuleElemet);
            }
            else if (e.Document == docQryPivotOLap)
            {
                e.Control = new Qry.QryPivotOLapUC(RuleElemet);
            }
            else if (e.Document == docQueriesCustomerMap)
            {
                e.Control = new NICSQLTools.Views.Qry.CustomerMapUC(RuleElemet);
            }

            else if (e.Document == docDashboardDesigner)//--------------------  Dashboard
            {
                e.Control = new Dashboard.DashboardDesignerUC(RuleElemet);
            }
            else if (e.Document == docDashboardViewer)
            {
                e.Control = new Dashboard.DashboardViewerUC();
            }

            else if (e.Document == docEditorsRoutes)//------------------------  Editors
            {
                e.Control = new Data.RouteEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsProducts)
            {
                e.Control = new Data.ProductEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsCustomers)
            {
                e.Control = new Data.CustomerEditorUC(RuleElemet);
            }
            else if (e.Document == docAppDatasourceEditor)
            {
                e.Control = new Data.AppDatasourceEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsAppDatasourceLookup)
            {
                e.Control = new Data.AppDatasourceLookupEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTargetKPI)
            {
                e.Control = new Data.TargetKPIEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTargetNCE)
            {
                e.Control = new Data.TargetNCEEditorUC(RuleElemet);
            }
            //else if (e.Document == docEditorsRoutesPlate)
            //{
            //    e.Control = new Data.GPS.TSrv_RoutePlateEditorUC(RuleElemet);
            //}
            //else if (e.Document == docEditorsPlate)
            //{
            //    e.Control = new Data.GPS.TSrv_PlateEditorUC(RuleElemet);
            //}
            else if (e.Document == docEditorsImportDays)
            {
                e.Control = new Import.ImportDaysUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportCustomerRoute)
            {
                e.Control = new Import.ImportCustomerRouteUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportCustomerInfo)
            {
                e.Control = new Import.ImportCustomerInfoUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportCustomerSSInfo)
            {
                e.Control = new Import.ImportCustomerSSInfoUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportUMD)
            {
                e.Control = new Import.ImportUMDUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportDamageMaster)
            {
                e.Control = new Import.ImportDMG_MasterUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportEquipment)
            {
                e.Control = new Import.ImportEquipmentUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportEquipmentAll)
            {
                e.Control = new Import.ImportEquipmentAllUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportUpdateProductDetails)
            {
                e.Control = new Import.ImportUpdateProductDetailsUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportStock_List)
            {
                e.Control = new Import.ImportStock_ListUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportStock_Material)
            {
                e.Control = new Import.ImportStock_MaterialUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportStock_Data)
            {
                e.Control = new Import.ImportStock_DataUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportDst_Master)
            {
                e.Control = new Import.ImportDst_MasterUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportEst_Actual_R3UC)
            {
                e.Control = new Import.ImportEst_Actual_R3UC(RuleElemet);
            }
            else if (e.Document == docEditorsImportActualBillArg)
            {
                e.Control = new Import.ImportActualBillArgUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportGPS_Data)
            {
                e.Control = new Import.ImportGPS_DataUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportHH_Data)
            {
                e.Control = new Import.ImportHH_DataUC(RuleElemet);
            }
            else if (e.Document == docEditorsCostControl)
            {
                e.Control = new Data.CostControlEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerTask)// Tasks
            {
                e.Control = new Data.TaskManager.TaskEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerEmp)
            {
                e.Control = new Data.TaskManager.EmpEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerEmpTask)
            {
                e.Control = new Data.TaskManager.EmpTaskEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerFactor)
            {
                e.Control = new Data.TaskManager.FactorEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerEmpTaskActual)
            {
                e.Control = new Data.TaskManager.EmpTaskActualEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsActivities_Actual)// Activities
            {
                e.Control = new Data.Activities.ImportSTI_Actv_ActualUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TypeEditor)// MSrv
            {
                e.Control = new Data.MSrv.MSrv_TypeEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TechnicianEditor)
            {
                e.Control = new Data.MSrv.MSrv_TechnicianEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TicketEditor){
                e.Control = new MSrv_TicketEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TechnicianSalesDistrictEditor)
            {
                e.Control = new Data.MSrv.MSrv_TechnicianSalesDistrictUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TechnicianCompanyEditor){
                e.Control = new Data.MSrv.MSrv_TechnicianCompanyEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_PartEditor)
            {
                e.Control = new Data.MSrv.MSrv_PartEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_01)
            {
                e.Control = new Qry.MSrv.MSrv_01();
            }
            else if (e.Document == docEditorsMSrv_02)
            {
                e.Control = new Qry.MSrv.MSrv_02();
            }
            else if (e.Document == docEditorsMSrv_03)
            {
                e.Control = new Qry.MSrv.MSrv_03();
            }
            else if (e.Document == docEditorsMSrv_04)
            {
                e.Control = new Qry.MSrv.MSrv_04();
            }
            else if (e.Document == docEditorsTSrv_TruckServiceEditor)//TSrv
            {
                e.Control = new Data.TSrv.Data.TSrv_TruckServiceEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTSrv_DriverEditor)
            {
                e.Control = new Data.TSrv.Code.TSrv_DriverEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTSrv_PlateEditor)
            {
                e.Control = new Data.TSrv.Code.TSrv_PlateEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTSrv_RoutePlateEditor)
            {
                e.Control = new Data.TSrv.Code.TSrv_RoutePlateEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTSrv_RouteTypeEditor)
            {
                e.Control = new Data.TSrv.Code.TSrv_RouteTypeEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTSrv_StatusEditor)
            {
                e.Control = new Data.TSrv.Code.TSrv_StatusEditorUC(RuleElemet);
            }

            else if (e.Document == docEditorsXRep01)
            {
                XRep.MSrv.XRep01 rep = new XRep.MSrv.XRep01();
                e.Control = new Main.XRepViewerUC(rep);
            }
            else if (e.Document == docEditorsMSrv_Dmg_ReasonEditor){
                e.Control = new Data.MSrv.MSrv_Dmg_ReasonEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsRDMEditorRDM_Promo_Type)// RDM
            {
                e.Control = new Data.RDM.RDM_Promo_TypeEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsRDMEditorRDM_Receipt)
            {
                e.Control = new Data.RDM.RDM_ReceiptEditorUC(RuleElemet);
            }

            else if (e.Document == docReportsReportViewer)
            {
                e.Control = new System.Windows.Forms.Control();//ToDo
            }
        }
        #endregion

    }
}
