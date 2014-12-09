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
                if (item.GetType() != typeof(TileContainer))//Apply Only For Tiles Containers 
                    continue;

                if (((TileContainer)item).Items == null)
                    continue;
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
        }
        public void LoadLayout()
        {
            // Load Layout Saved Settings
            string FileName = Program.TilesLayoutFile + Classes.Managers.UserManager.defaultInstance.User.UserId.ToString();
            if (System.IO.File.Exists(FileName))
            {
                System.IO.FileStream Fs = new System.IO.FileStream(FileName, System.IO.FileMode.Open);
                windowsUIView.RestoreLayoutFromStream(Fs);
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
            NICSQLTools.Data.dsData.AppRuleDetailRow RuleElemet = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(docDashboardDesigner.ControlName);
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
            else if (e.Document == docEditorsAppDSCategory)
            {
                e.Control = new Views.Data.AppDSCategoryUC(RuleElemet);
            }
            else if (e.Document == docAppDatasource)
            {
                e.Control = new Views.Data.AppDatasourceUC(RuleElemet);
            }
            else if (e.Document == docAppDatasourceParam)
            {
                e.Control = new Views.Data.AppDatasourceParamUC(RuleElemet);
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
            else if (e.Document == docEditorsImportDamageReason)
            {
                e.Control = new Views.Import.ImportDamageReasonUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportDamageMaster)
            {
                e.Control = new Views.Import.ImportDMG_MasterUC(RuleElemet);
            }
            else if (e.Document == docEditorsImportEquipment)
            {
                e.Control = new Views.Import.ImportEquipmentUC(RuleElemet);
            }
            else if (e.Document == docReportsReportViewer)
            {
                e.Control = new System.Windows.Forms.Control();//ToDo
            }
        }
        #endregion

    }
}
