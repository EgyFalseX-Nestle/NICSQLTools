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
            else if (e.Document == docEditorsImportDays)
            {
                e.Control = new Views.Data.ImportDaysUC();
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
        }

    }
}
