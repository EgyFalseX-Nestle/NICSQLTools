namespace NICSQLTools.Views.Permission
{
    partial class RuleSalesDisitrct3UC
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colRuleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditRuleID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.rulesLUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRuleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuleDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesDistrict3Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSalesDistrict3Id = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSSalesDistrict3 = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesDistrict2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.appRuleSalesDistrict3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsData = new NICSQLTools.Data.dsData();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.rules_LUETableAdapter = new NICSQLTools.Data.dsQryTableAdapters.Rules_LUETableAdapter();
            this.appRuleSalesDistrict3TableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppRuleSalesDistrict3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRuleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesLUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSalesDistrict3Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSalesDistrict3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRuleSalesDistrict3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcDel,
            this.colRuleId,
            this.colSalesDistrict3Id});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "Click here to add a new";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // gcDel
            // 
            this.gcDel.AppearanceCell.Options.UseTextOptions = true;
            this.gcDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcDel.AppearanceHeader.Options.UseTextOptions = true;
            this.gcDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcDel.Caption = "Delete";
            this.gcDel.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gcDel.Name = "gcDel";
            this.gcDel.OptionsColumn.TabStop = false;
            this.gcDel.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // repositoryItemButtonEditDelete
            // 
            this.repositoryItemButtonEditDelete.AutoHeight = false;
            this.repositoryItemButtonEditDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditDelete.Name = "repositoryItemButtonEditDelete";
            this.repositoryItemButtonEditDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDelete_ButtonClick);
            // 
            // colRuleId
            // 
            this.colRuleId.AppearanceCell.Options.UseTextOptions = true;
            this.colRuleId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRuleId.AppearanceHeader.Options.UseTextOptions = true;
            this.colRuleId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRuleId.Caption = "Rule";
            this.colRuleId.ColumnEdit = this.repositoryItemGridLookUpEditRuleID;
            this.colRuleId.FieldName = "RuleID";
            this.colRuleId.Name = "colRuleId";
            this.colRuleId.Visible = true;
            this.colRuleId.VisibleIndex = 0;
            this.colRuleId.Width = 95;
            // 
            // repositoryItemGridLookUpEditRuleID
            // 
            this.repositoryItemGridLookUpEditRuleID.AutoHeight = false;
            this.repositoryItemGridLookUpEditRuleID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditRuleID.DataSource = this.rulesLUEBindingSource;
            this.repositoryItemGridLookUpEditRuleID.DisplayMember = "RuleName";
            this.repositoryItemGridLookUpEditRuleID.Name = "repositoryItemGridLookUpEditRuleID";
            this.repositoryItemGridLookUpEditRuleID.NullText = "";
            this.repositoryItemGridLookUpEditRuleID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditRuleID.ValueMember = "RuleID";
            this.repositoryItemGridLookUpEditRuleID.View = this.gridView1;
            // 
            // rulesLUEBindingSource
            // 
            this.rulesLUEBindingSource.DataMember = "Rules_LUE";
            this.rulesLUEBindingSource.DataSource = this.dsQry;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRuleName,
            this.colRuleDesc});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colRuleName
            // 
            this.colRuleName.FieldName = "RuleName";
            this.colRuleName.Name = "colRuleName";
            this.colRuleName.Visible = true;
            this.colRuleName.VisibleIndex = 0;
            // 
            // colRuleDesc
            // 
            this.colRuleDesc.Caption = "Rule Description";
            this.colRuleDesc.FieldName = "RuleDesc";
            this.colRuleDesc.Name = "colRuleDesc";
            this.colRuleDesc.Visible = true;
            this.colRuleDesc.VisibleIndex = 1;
            // 
            // colSalesDistrict3Id
            // 
            this.colSalesDistrict3Id.AppearanceCell.Options.UseTextOptions = true;
            this.colSalesDistrict3Id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesDistrict3Id.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalesDistrict3Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesDistrict3Id.Caption = "Sales District 2";
            this.colSalesDistrict3Id.ColumnEdit = this.repositoryItemGridLookUpEditSalesDistrict3Id;
            this.colSalesDistrict3Id.FieldName = "SalesDistrict3Id";
            this.colSalesDistrict3Id.Name = "colSalesDistrict3Id";
            this.colSalesDistrict3Id.Visible = true;
            this.colSalesDistrict3Id.VisibleIndex = 1;
            this.colSalesDistrict3Id.Width = 132;
            // 
            // repositoryItemGridLookUpEditSalesDistrict3Id
            // 
            this.repositoryItemGridLookUpEditSalesDistrict3Id.AutoHeight = false;
            this.repositoryItemGridLookUpEditSalesDistrict3Id.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSalesDistrict3Id.DataSource = this.LSMSSalesDistrict3;
            this.repositoryItemGridLookUpEditSalesDistrict3Id.DisplayMember = "Sales_District_2";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.Name = "repositoryItemGridLookUpEditSalesDistrict3Id";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.NullText = "";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSalesDistrict3Id.ValueMember = "SalesDistrict3Id";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // LSMSSalesDistrict3
            // 
            this.LSMSSalesDistrict3.ElementType = typeof(NICSQLTools.Data.Linq.SalesDistrict3);
            this.LSMSSalesDistrict3.KeyExpression = "[SalesDistrict3Id]";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesDistrict2,
            this.gridColumn1,
            this.gridColumn2});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSalesDistrict2
            // 
            this.colSalesDistrict2.Caption = "Sales District 2";
            this.colSalesDistrict2.FieldName = "Sales_District_2";
            this.colSalesDistrict2.Name = "colSalesDistrict2";
            this.colSalesDistrict2.Visible = true;
            this.colSalesDistrict2.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sales District";
            this.gridColumn1.FieldName = "SalesDistrict2Id.Sales_District";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sales District Name";
            this.gridColumn2.FieldName = "SalesDistrict2Id.SalesDistrict1Id.Sales_District_Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridControlMain
            // 
            this.gridControlMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMain.DataSource = this.appRuleSalesDistrict3BindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlMain_EmbeddedNavigator_ButtonClick);
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditSalesDistrict3Id,
            this.repositoryItemGridLookUpEditRuleID,
            this.repositoryItemButtonEditDelete});
            this.gridControlMain.Size = new System.Drawing.Size(679, 360);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // appRuleSalesDistrict3BindingSource
            // 
            this.appRuleSalesDistrict3BindingSource.DataMember = "AppRuleSalesDistrict3";
            this.appRuleSalesDistrict3BindingSource.DataSource = this.dsData;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bbiSave,
            this.bbiExport,
            this.bbiRefresh});
            this.barManagerMain.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Glyph = global::NICSQLTools.Properties.Resources.saveall_16x16;
            this.bbiSave.Id = 0;
            this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiSave.LargeGlyph = global::NICSQLTools.Properties.Resources.saveall_32x32;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.LargeGlyph = global::NICSQLTools.Properties.Resources.refresh2_32x32;
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
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // rules_LUETableAdapter
            // 
            this.rules_LUETableAdapter.ClearBeforeFill = true;
            // 
            // appRuleSalesDistrict3TableAdapter
            // 
            this.appRuleSalesDistrict3TableAdapter.ClearBeforeFill = true;
            // 
            // RuleSalesDisitrct3UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RuleSalesDisitrct3UC";
            this.Size = new System.Drawing.Size(679, 391);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRuleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesLUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSalesDistrict3Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSalesDistrict3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRuleSalesDistrict3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSalesDistrict3Id;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colRuleId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditRuleID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private NICSQLTools.Data.dsData dsData;
        private NICSQLTools.Data.dsQry dsQry;
        private System.Windows.Forms.BindingSource rulesLUEBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRuleName;
        private DevExpress.XtraGrid.Columns.GridColumn colRuleDesc;
        private NICSQLTools.Data.dsQryTableAdapters.Rules_LUETableAdapter rules_LUETableAdapter;
        private System.Windows.Forms.BindingSource appRuleSalesDistrict3BindingSource;
        private NICSQLTools.Data.dsDataTableAdapters.AppRuleSalesDistrict3TableAdapter appRuleSalesDistrict3TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDistrict3Id;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDistrict2;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSalesDistrict3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gcDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
    }
}
