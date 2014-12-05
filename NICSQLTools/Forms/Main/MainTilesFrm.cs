using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views;
using System.Drawing;

namespace NICSQLTools.Forms.Main
{
    public partial class MainTilesFrm : XtraForm
    {
        SampleDataSource dataSource;
        Dictionary<SampleDataGroup, PageGroup> groupsItemDetailPage;
        
        public MainTilesFrm()
        {
            InitializeComponent();
            windowsUIView.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;

            

            //dataSource = new SampleDataSource();
            //groupsItemDetailPage = new Dictionary<SampleDataGroup, PageGroup>();
            //CreateLayout();
            windowsUIView.ActivateDocument(docLogin);

           
        }
        public void ActivateRules()
        {
            if (Classes.Managers.UserManager.defaultInstance.User.IsAdmin == true)
                return;
            
            foreach (TileContainer item in windowsUIView.ContentContainers.ToArray())
            {
                if (item.Items == null)
                    continue;
                for (int InxContainers = 0; InxContainers < item.Items.Count; InxContainers++)
                {
                    for (int i = item.Items.Count - 1; i >= 0; i--)
                    {
                        NICSQLTools.Data.dsData.AppRuleDetailRow elementRule = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(((Tile)item.Items[i]).Name);
                        if (((Tile)item.Items[i]).Tag != null && (bool)((Tile)item.Items[i]).Tag)// Show Exception Tiles
                            ((Tile)item.Items[i]).Visible = true;
                        else
                            ((Tile)item.Items[i]).Visible = elementRule.Selecting;
                    }
                }
            }
        }
        void CreateLayout()
        {
            foreach (BaseDocument doc in windowsUIView.Documents)
            {
                switch (doc.ControlName)
                {
                    case "docLogin":
                        //doc.Control = new Views.Main.LoginUI();
                        break;
                    default:
                        break;
                }
            }
            
        }
        Tile CreateTile(Document document, SampleDataItem item)
        {
            Tile tile = new Tile();
            tile.Document = document;
            tile.Group = item.GroupName;
            tile.Tag = item;
            tile.Elements.Add(CreateTileItemElement(item.Subtitle, TileItemContentAlignment.BottomLeft, Point.Empty, 9));
            tile.Elements.Add(CreateTileItemElement(item.Subtitle, TileItemContentAlignment.Manual, new Point(0, 100), 12));
            tile.Appearances.Selected.BackColor = tile.Appearances.Hovered.BackColor = tile.Appearances.Normal.BackColor = Color.FromArgb(140, 140, 140);
            tile.Appearances.Selected.BorderColor = tile.Appearances.Hovered.BorderColor = tile.Appearances.Normal.BorderColor = Color.FromArgb(140, 140, 140);
            tile.Click += new TileClickEventHandler(tile_Click);
            windowsUIView.Tiles.Add(tile);
            tileContainerLogin.Items.Add(tile);
            return tile;
        }
        TileItemElement CreateTileItemElement(string text, TileItemContentAlignment alignment, Point location, float fontSize)
        {
            TileItemElement element = new TileItemElement();
            element.TextAlignment = alignment;
            if (!location.IsEmpty) element.TextLocation = location;
            element.Appearance.Normal.Options.UseFont = true;
            element.Appearance.Normal.Font = new System.Drawing.Font(new FontFamily("Segoe UI Symbol"), fontSize);
            element.Text = text;
            return element;
        }
        void tile_Click(object sender, TileClickEventArgs e)
        {
            PageGroup page = ((e.Tile as Tile).ActivationTarget as PageGroup);
            if (page != null)
            {
                page.Parent = tileContainerLogin;
                page.SetSelected((e.Tile as Tile).Document);
            }
        }
        PageGroup CreateGroupItemDetailPage(SampleDataGroup group, PageGroup child)
        {
            GroupDetailPage page = new GroupDetailPage(group, child);
            PageGroup pageGroup = page.PageGroup;
            BaseDocument document = windowsUIView.AddDocument(page);
            pageGroup.Parent = tileContainerLogin;
            pageGroup.Items.Add(document as Document);
            windowsUIView.ContentContainers.Add(pageGroup);
            windowsUIView.ActivateContainer(pageGroup);
            return pageGroup;
        }
        void buttonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            SampleDataGroup tileGroup = (e.Button.Properties.Tag as SampleDataGroup);
            if (tileGroup != null)
            {
                windowsUIView.ActivateContainer(groupsItemDetailPage[tileGroup]);

            }
        }
        private void windowsUIView_QueryControl(object sender, QueryControlEventArgs e)
        {
            if (e.Control != null)
                return;
            if (e.Document == docLogin)
            {
                e.Control = new Views.Main.LoginUC();
            }
            else if (e.Document == docEditorsRoutes)
            {
                e.Control = new Views.Data.RouteEditorUC();
            }
            else if (e.Document == docEditorsProducts)
            {
                e.Control = new Views.Data.ProductEditorUC();
            }
            else if (e.Document == docEditorsCustomers)
            {
                e.Control = new Views.Data.CustomerEditorUC();
            }
            else if (e.Document == docRuleUser)//----------------------- Rules
            {
                e.Control = new Views.Permission.UserUC();
            }
            else if (e.Document == docRuleRule)
            {
                e.Control = new Views.Permission.RuleUC();
            }
            else if (e.Document == docRuleUserRule)
            {
                e.Control = new Views.Permission.UserRuleUC();
            }
            else if (e.Document == docRuleRuleDetails)
            {
                e.Control = new Views.Permission.RuleDetailsUC();
            }
            else if (e.Document == docRuleRuleSalesDisitrct3)
            {
                e.Control = new Views.Permission.RuleSalesDisitrct3UC();
            }
            else if (e.Document == docQueriesQryPivot)//----------------------- Queries
            {
                e.Control = new Views.Qry.QryPivotUC();
            }
            else if (e.Document == docDashboardDesigner)
            {
                e.Control = new Views.Dashboard.DashboardDesignerUC();
            }
            else if (e.Document == docDashboardViewer)
            {
                e.Control = new Views.Dashboard.DashboardViewerUC();
            }
            else if (e.Document == docAppDatasource)
            {
                e.Control = new Views.Data.AppDatasourceUC();
            }
            else if (e.Document == docAppDatasourceParam)
            {
                e.Control = new Views.Data.AppDatasourceParamUC();
            }
            else if (e.Document == docEditorsTargetKPI)
            {
                e.Control = new Views.Data.TargetKPIEditorUC();
            }
            else if (e.Document == docEditorsTargetNCE)
            {
                e.Control = new Views.Data.TargetNCEEditorUC();
            }
            else if (e.Document == docEditorsImportDays)
            {
                e.Control = new Views.Import.ImportDaysUC();
            }
            else if (e.Document == docEditorsImportCustomerRoute)
            {
                e.Control = new Views.Import.ImportCustomerRouteUC();
            }
            else if (e.Document == docEditorsImportCustomerInfo)
            {
                e.Control = new Views.Import.ImportCustomerInfoUC();
            }
            else if (e.Document == docEditorsImportCustomerSSInfo)
            {
                e.Control = new Views.Import.ImportCustomerSSInfoUC();
            }
            else if (e.Document == docEditorsImportDamageReason)
            {
                e.Control = new Views.Import.ImportDamageReasonUC();
            }
            else if (e.Document == docEditorsImportDamageMaster)
            {
                e.Control = new Views.Import.ImportDMG_MasterUC();
            }
            else if (e.Document == docEditorsImportEquipment)
            {
                e.Control = new Views.Import.ImportEquipmentUC();
            }
            else if (e.Document == docQueriesFinalDataGrid)
            {
                e.Control = new Views.Qry.FinalDataGridUC();
            }
            else if (e.Document == docQueriesFinalDataPivot)
            {
                e.Control = new Views.Qry.FinalDataPivotUC();
            }
            else if (e.Document == docQueriesQrysp_DistributionNPDV1)
            {
                e.Control = new Views.Qry.Qrysp_DistributionNPDV1UC();
            }
            else if (e.Document == docQueriesQrysp_DistributionV1)
            {
                e.Control = new Views.Qry.Qrysp_DistributionV1UC();
            }
        }

        private void tileContainerMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            Views.Main.ChooseThemeFrm Frm = new Views.Main.ChooseThemeFrm();
            Frm.ShowDialog();
        }

    }
}
