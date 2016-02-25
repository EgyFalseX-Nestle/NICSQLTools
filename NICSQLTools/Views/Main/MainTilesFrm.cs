using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views;
using System.Drawing;
using System.Linq;
using System;

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
            btnMinimize.Image = NICSQLTools.Properties.Resources.next_32x32;
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
            btnUserSettings.Image = NICSQLTools.Properties.Resources.ide_32x32;
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
                e.Control = new Views.Permission.UserUC(RuleElemet);
            }
            else if (e.Document == docRuleRule)
            {
                e.Control = new Views.Permission.RuleUC(RuleElemet);
            }
            else if (e.Document == docRuleUserRule)
            {
                e.Control = new Views.Permission.UserRuleUC(RuleElemet);
            }
            else if (e.Document == docRuleRuleDetails)
            {
                e.Control = new Views.Permission.RuleDetailsUC(RuleElemet);
            }
            else if (e.Document == docRuleRuleSalesDisitrct3)
            {
                e.Control = new Views.Permission.RuleSalesDisitrct3UC(RuleElemet);
            }

            else if (e.Document == docQueriesQryPivot)//----------------------- Queries
            {
                e.Control = new Views.Qry.QryPivotUC(RuleElemet);
            }
            else if (e.Document == docQueriesQryCustomerInfo)
            {
                e.Control = new Views.Qry.QryCustomerInfoUC(RuleElemet);
            }
            else if (e.Document == docQueriesExcelDynamicUpdate)
            {
                e.Control = new Views.Qry.ExcelDynamicUpdateUC(RuleElemet);
            }
            else if (e.Document == docQryPivotOLap)
            {
                e.Control = new Views.Qry.QryPivotOLapUC(RuleElemet);
            }

            else if (e.Document == docDashboardDesigner)//--------------------  Dashboard
            {
                e.Control = new Views.Dashboard.DashboardDesignerUC(RuleElemet);
            }
            else if (e.Document == docDashboardViewer)
            {
                e.Control = new Views.Dashboard.DashboardViewerUC();
            }

            else if (e.Document == docEditorsRoutes)//------------------------  Editors
            {
                e.Control = new Views.Data.RouteEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsProducts)
            {
                e.Control = new Views.Data.ProductEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsCustomers)
            {
                e.Control = new Views.Data.CustomerEditorUC(RuleElemet);
            }
            else if (e.Document == docAppDatasourceEditor)
            {
                e.Control = new Views.Data.AppDatasourceEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsAppDatasourceLookup)
            {
                e.Control = new Views.Data.AppDatasourceLookupEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTargetKPI)
            {
                e.Control = new Views.Data.TargetKPIEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTargetNCE)
            {
                e.Control = new Views.Data.TargetNCEEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportDays)
            {
                e.Control = new Views.Import.ImportDaysUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportCustomerRoute)
            {
                e.Control = new Views.Import.ImportCustomerRouteUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportCustomerInfo)
            {
                e.Control = new Views.Import.ImportCustomerInfoUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportCustomerSSInfo)
            {
                e.Control = new Views.Import.ImportCustomerSSInfoUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportUMD)
            {
                e.Control = new Views.Import.ImportUMDUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportDamageMaster)
            {
                e.Control = new Views.Import.ImportDMG_MasterUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportEquipment)
            {
                e.Control = new Views.Import.ImportEquipmentUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportEquipmentAll)
            {
                e.Control = new Views.Import.ImportEquipmentAllUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportUpdateProductDetails)
            {
                e.Control = new Views.Import.ImportUpdateProductDetailsUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportStock_List)
            {
                e.Control = new Views.Import.ImportStock_ListUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportStock_Material)
            {
                e.Control = new Views.Import.ImportStock_MaterialUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportStock_Data)
            {
                e.Control = new Views.Import.ImportStock_DataUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportDst_Master)
            {
                e.Control = new Views.Import.ImportDst_MasterUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportActual_OTRUC)
            {
                e.Control = new Views.Import.ImportActual_OTRUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportActualBillArg)
            {
                e.Control = new Views.Import.ImportActualBillArgUC(RuleElemet);
            }
            else if (e.Document == docEditorsCostControl)
            {
                e.Control = new Views.Data.CostControlEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerTask)// Tasks
            {
                e.Control = new NICSQLTools.Views.Data.TaskManager.TaskEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerEmp)
            {
                e.Control = new NICSQLTools.Views.Data.TaskManager.EmpEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerEmpTask)
            {
                e.Control = new NICSQLTools.Views.Data.TaskManager.EmpTaskEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerFactor)
            {
                e.Control = new NICSQLTools.Views.Data.TaskManager.FactorEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsTaskManagerEmpTaskActual)
            {
                e.Control = new NICSQLTools.Views.Data.TaskManager.EmpTaskActualEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsActivities_Actual)// Activities
            {
                e.Control = new NICSQLTools.Views.Data.Activities.ImportSTI_Actv_ActualUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TypeEditor)// MSrv
            {
                e.Control = new NICSQLTools.Views.Data.MSrv.MSrv_TypeEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TechnicianEditor)
            {
                e.Control = new NICSQLTools.Views.Data.MSrv.MSrv_TechnicianEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TicketEditor)
            {
                e.Control = new NICSQLTools.Views.Data.MSrv.MSrv_TicketEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TechnicianSalesDistrictEditor)
            {
                e.Control = new NICSQLTools.Views.Data.MSrv.MSrv_TechnicianSalesDistrictUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_TechnicianCompanyEditor)
            {
                e.Control = new NICSQLTools.Views.Data.MSrv.MSrv_TechnicianCompanyEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_PartEditor)
            {
                e.Control = new NICSQLTools.Views.Data.MSrv.MSrv_PartEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsMSrv_01)
            {
                e.Control = new NICSQLTools.Views.Qry.MSrv.MSrv_01();
            }
            else if (e.Document == docEditorsRDMEditorRDM_Promo_Type)// RDM
            {
                e.Control = new NICSQLTools.Views.Data.RDM.RDM_Promo_TypeEditorUC(RuleElemet);
            }
            else if (e.Document == docEditorsRDMEditorRDM_Receipt)
            {
                e.Control = new NICSQLTools.Views.Data.RDM.RDM_ReceiptEditorUC(RuleElemet);
            }

            else if (e.Document == docReportsReportViewer)
            {
                e.Control = new System.Windows.Forms.Control();//ToDo
            }
        }
        #endregion

    }
}
