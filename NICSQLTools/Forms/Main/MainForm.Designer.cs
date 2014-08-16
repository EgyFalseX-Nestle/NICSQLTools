namespace NICSQLTools
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.documentManagerMain = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.docLogin = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docEditors = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docQueries = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docRoles = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docLoginTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.documentTileEditors = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.documentTileQueries = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.documentTileRoles = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileContainerLogin = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.tileContainerMain = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docEditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLoginTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTileEditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTileQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTileRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerMain)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManagerMain
            // 
            this.documentManagerMain.ContainerControl = this;
            this.documentManagerMain.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManagerMain.View = this.windowsUIView;
            this.documentManagerMain.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView});
            // 
            // windowsUIView
            // 
            this.windowsUIView.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.windowsUIView.AppearanceCaption.Options.UseFont = true;
            this.windowsUIView.Caption = "Nestle Icecream Sales Administration";
            this.windowsUIView.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainerLogin,
            this.tileContainerMain});
            this.windowsUIView.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.docLogin,
            this.docEditors,
            this.docQueries,
            this.docRoles});
            this.windowsUIView.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.docLoginTile,
            this.documentTileEditors,
            this.documentTileQueries,
            this.documentTileRoles});
            this.windowsUIView.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView_QueryControl);
            // 
            // docLogin
            // 
            this.docLogin.Caption = "IceCream Login";
            this.docLogin.ControlName = "docLogin";
            this.docLogin.Footer = "";
            // 
            // docEditors
            // 
            this.docEditors.Caption = "Editors";
            this.docEditors.ControlName = "docEditors";
            // 
            // docQueries
            // 
            this.docQueries.Caption = "Queries";
            this.docQueries.ControlName = "docQueries";
            // 
            // docRoles
            // 
            this.docRoles.Caption = "Roles";
            this.docRoles.ControlName = "docRoles";
            // 
            // docLoginTile
            // 
            this.docLoginTile.Appearances.Normal.BackColor = System.Drawing.Color.Black;
            this.docLoginTile.Appearances.Normal.ForeColor = System.Drawing.Color.White;
            this.docLoginTile.Appearances.Normal.Options.UseBackColor = true;
            this.docLoginTile.Appearances.Normal.Options.UseForeColor = true;
            this.docLoginTile.Document = this.docLogin;
            tileItemFrame1.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown;
            tileItemElement1.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F);
            tileItemElement1.Appearance.Hovered.Options.UseFont = true;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Appearance.Selected.Font = new System.Drawing.Font("Tahoma", 12F);
            tileItemElement1.Appearance.Selected.Options.UseFont = true;
            tileItemElement1.Image = global::NICSQLTools.Properties.Resources.LoginLogo256;
            tileItemElement1.ImageLocation = new System.Drawing.Point(-12, -8);
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement1.ImageSize = new System.Drawing.Size(372, 180);
            tileItemElement1.TextLocation = new System.Drawing.Point(6, 4);
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Impact", 14F);
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.MaxWidth = 150;
            tileItemElement2.Text = "Nestle Icecream Sales Administration";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.TextLocation = new System.Drawing.Point(70, 20);
            tileItemFrame1.Elements.Add(tileItemElement1);
            tileItemFrame1.Elements.Add(tileItemElement2);
            tileItemFrame1.Image = global::NICSQLTools.Properties.Resources.LoginLogo256;
            tileItemElement3.Image = global::NICSQLTools.Properties.Resources.LoginTile64;
            tileItemElement3.Text = "Login Screen";
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Text = "Click To Login";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.TextLocation = new System.Drawing.Point(40, 0);
            tileItemFrame2.Elements.Add(tileItemElement3);
            tileItemFrame2.Elements.Add(tileItemElement4);
            tileItemFrame2.Image = global::NICSQLTools.Properties.Resources.LoginTile64;
            this.docLoginTile.Frames.Add(tileItemFrame1);
            this.docLoginTile.Frames.Add(tileItemFrame2);
            this.docLoginTile.Group = "";
            this.tileContainerLogin.SetID(this.docLoginTile, 1);
            this.docLoginTile.Name = "docLoginTile";
            this.docLoginTile.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.docLoginTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // documentTileEditors
            // 
            this.documentTileEditors.Document = this.docEditors;
            this.documentTileEditors.Group = "";
            this.documentTileEditors.Name = "documentTileEditors";
            // 
            // documentTileQueries
            // 
            this.documentTileQueries.Document = this.docQueries;
            this.documentTileQueries.Group = "";
            this.tileContainerMain.SetID(this.documentTileQueries, 1);
            this.documentTileQueries.Name = "documentTileQueries";
            // 
            // documentTileRoles
            // 
            this.documentTileRoles.Document = this.docRoles;
            this.documentTileRoles.Group = "";
            this.tileContainerMain.SetID(this.documentTileRoles, 2);
            this.documentTileRoles.Name = "documentTileRoles";
            // 
            // tileContainerLogin
            // 
            this.tileContainerLogin.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.docLoginTile});
            this.tileContainerLogin.Name = "tileContainerLogin";
            this.tileContainerLogin.Properties.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.tileContainerLogin.Properties.ShowGroupText = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileContainerMain
            // 
            this.tileContainerMain.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.documentTileEditors,
            this.documentTileQueries,
            this.documentTileRoles});
            this.tileContainerMain.Name = "tileContainerMain";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 423);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docEditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLoginTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTileEditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTileQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTileRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docLogin;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainerLogin;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile docLoginTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile documentTileEditors;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docEditors;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile documentTileQueries;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docQueries;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile documentTileRoles;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docRoles;
        public DevExpress.XtraBars.Docking2010.DocumentManager documentManagerMain;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainerMain;
    }
}

