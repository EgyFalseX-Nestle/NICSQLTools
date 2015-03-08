namespace NICSQLTools.Views.Data
{
    partial class AppDSCategoryUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppDSCategoryUC));
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiAddNode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeleteNode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionMain = new DevExpress.Xpo.Session(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.treeListMain = new DevExpress.XtraTreeList.TreeList();
            this.colDSCategoryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDSCategoryDesc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollectionNormal = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiExport,
            this.bbiRefresh,
            this.bbiAddNode,
            this.bbiDeleteNode});
            this.barManagerMain.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddNode),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDeleteNode),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiAddNode
            // 
            this.bbiAddNode.Caption = "Add Node";
            this.bbiAddNode.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiAddNode.Glyph")));
            this.bbiAddNode.Id = 3;
            this.bbiAddNode.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiAddNode.LargeGlyph")));
            this.bbiAddNode.Name = "bbiAddNode";
            this.bbiAddNode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAddNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddNode_ItemClick);
            // 
            // bbiDeleteNode
            // 
            this.bbiDeleteNode.Caption = "Delete Node";
            this.bbiDeleteNode.Glyph = global::NICSQLTools.Properties.Resources.cancel_16x16;
            this.bbiDeleteNode.Id = 4;
            this.bbiDeleteNode.Name = "bbiDeleteNode";
            this.bbiDeleteNode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiDeleteNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeleteNode_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.LargeGlyph = global::NICSQLTools.Properties.Resources.up_32x32;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NICSQLTools.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(679, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Size = new System.Drawing.Size(679, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 360);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(679, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 360);
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsData.AppDSCategoryDataTable);
            this.XPSCS.Session = this.sessionMain;
            // 
            // sessionMain
            // 
            this.sessionMain.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionMain.TrackPropertiesModifications = false;
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // treeListMain
            // 
            this.treeListMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDSCategoryName,
            this.colDSCategoryDesc});
            this.treeListMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMain.DragNodesMode = DevExpress.XtraTreeList.TreeListDragNodesMode.Advanced;
            this.treeListMain.KeyFieldName = "DSCategoryId";
            this.treeListMain.Location = new System.Drawing.Point(0, 31);
            this.treeListMain.Name = "treeListMain";
            this.treeListMain.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListMain.OptionsBehavior.AutoMoveRowFocus = true;
            this.treeListMain.OptionsBehavior.CanCloneNodesOnDrop = true;
            this.treeListMain.OptionsBehavior.DragNodes = true;
            this.treeListMain.OptionsBehavior.EnableFiltering = true;
            this.treeListMain.OptionsBehavior.EnterMovesNextColumn = true;
            this.treeListMain.OptionsBehavior.ImmediateEditor = false;
            this.treeListMain.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.treeListMain.OptionsLayout.LayoutVersion = "1";
            this.treeListMain.OptionsView.ShowAutoFilterRow = true;
            this.treeListMain.ParentFieldName = "DSCategoryParent";
            this.treeListMain.SelectImageList = this.imageCollectionNormal;
            this.treeListMain.Size = new System.Drawing.Size(679, 360);
            this.treeListMain.TabIndex = 10;
            // 
            // colDSCategoryName
            // 
            this.colDSCategoryName.Caption = "Category Name";
            this.colDSCategoryName.FieldName = "DSCategoryName";
            this.colDSCategoryName.MinWidth = 34;
            this.colDSCategoryName.Name = "colDSCategoryName";
            this.colDSCategoryName.Visible = true;
            this.colDSCategoryName.VisibleIndex = 0;
            this.colDSCategoryName.Width = 132;
            // 
            // colDSCategoryDesc
            // 
            this.colDSCategoryDesc.Caption = "Category Description";
            this.colDSCategoryDesc.FieldName = "DSCategoryDesc";
            this.colDSCategoryDesc.Name = "colDSCategoryDesc";
            this.colDSCategoryDesc.Visible = true;
            this.colDSCategoryDesc.VisibleIndex = 1;
            this.colDSCategoryDesc.Width = 132;
            // 
            // imageCollectionNormal
            // 
            this.imageCollectionNormal.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionNormal.ImageStream")));
            this.imageCollectionNormal.InsertImage(global::NICSQLTools.Properties.Resources.open_16x16, "open_16x16", typeof(global::NICSQLTools.Properties.Resources), 0);
            this.imageCollectionNormal.Images.SetKeyName(0, "open_16x16");
            // 
            // AppDSCategoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeListMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AppDSCategoryUC";
            this.Size = new System.Drawing.Size(679, 391);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraTreeList.TreeList treeListMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDSCategoryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDSCategoryDesc;
        private DevExpress.XtraBars.BarButtonItem bbiAddNode;
        private DevExpress.XtraBars.BarButtonItem bbiDeleteNode;
        private DevExpress.Xpo.Session sessionMain;
        private DevExpress.Utils.ImageCollection imageCollectionNormal;
    }
}
