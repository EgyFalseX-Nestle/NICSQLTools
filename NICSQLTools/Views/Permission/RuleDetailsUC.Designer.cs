namespace NICSQLTools.Views.Permission
{
    partial class RuleDetailsUC
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
            this.rulesLUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.dsData = new NICSQLTools.Data.dsData();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiRule = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.rules_LUETableAdapter = new NICSQLTools.Data.dsQryTableAdapters.Rules_LUETableAdapter();
            this.TLItems = new DevExpress.XtraTreeList.TreeList();
            this.tlcName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcSelect = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tlcInsert = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcUpdate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcDelete = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ruleDetailTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.RuleDetailTableAdapter();
            this.tlcID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rulesLUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.bbiRefresh,
            this.bbiRule});
            this.barManagerMain.MaxItemId = 4;
            this.barManagerMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRule),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiRule
            // 
            this.bbiRule.Caption = "Rules";
            this.bbiRule.Edit = this.repositoryItemLookUpEdit1;
            this.bbiRule.Id = 3;
            this.bbiRule.Name = "bbiRule";
            this.bbiRule.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.bbiRule.Width = 200;
            this.bbiRule.EditValueChanged += new System.EventHandler(this.bbiRule_EditValueChanged);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RuleName", "Rule Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RuleDesc", "Rule Description", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.rulesLUEBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "RuleName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.NullValuePrompt = "Select A Rule To Edit";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "RuleID";
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
            this.barDockControlTop.Size = new System.Drawing.Size(700, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 332);
            this.barDockControlBottom.Size = new System.Drawing.Size(700, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 301);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(700, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 301);
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
            // TLItems
            // 
            this.TLItems.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcName,
            this.tlcSelect,
            this.tlcInsert,
            this.tlcUpdate,
            this.tlcDelete,
            this.tlcID});
            this.TLItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLItems.KeyFieldName = "Name";
            this.TLItems.Location = new System.Drawing.Point(0, 31);
            this.TLItems.Name = "TLItems";
            this.TLItems.OptionsBehavior.PopulateServiceColumns = true;
            this.TLItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.TLItems.Size = new System.Drawing.Size(700, 301);
            this.TLItems.TabIndex = 10;
            // 
            // tlcName
            // 
            this.tlcName.Caption = "Item Name";
            this.tlcName.FieldName = "Name";
            this.tlcName.Name = "tlcName";
            this.tlcName.OptionsColumn.AllowEdit = false;
            this.tlcName.Visible = true;
            this.tlcName.VisibleIndex = 0;
            this.tlcName.Width = 136;
            // 
            // tlcSelect
            // 
            this.tlcSelect.Caption = "View";
            this.tlcSelect.ColumnEdit = this.repositoryItemCheckEdit1;
            this.tlcSelect.FieldName = "Select";
            this.tlcSelect.Name = "tlcSelect";
            this.tlcSelect.Visible = true;
            this.tlcSelect.VisibleIndex = 1;
            this.tlcSelect.Width = 137;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // tlcInsert
            // 
            this.tlcInsert.Caption = "Insert";
            this.tlcInsert.ColumnEdit = this.repositoryItemCheckEdit1;
            this.tlcInsert.FieldName = "Insert";
            this.tlcInsert.Name = "tlcInsert";
            this.tlcInsert.Visible = true;
            this.tlcInsert.VisibleIndex = 2;
            this.tlcInsert.Width = 137;
            // 
            // tlcUpdate
            // 
            this.tlcUpdate.Caption = "Update";
            this.tlcUpdate.ColumnEdit = this.repositoryItemCheckEdit1;
            this.tlcUpdate.FieldName = "Update";
            this.tlcUpdate.Name = "tlcUpdate";
            this.tlcUpdate.Visible = true;
            this.tlcUpdate.VisibleIndex = 3;
            this.tlcUpdate.Width = 136;
            // 
            // tlcDelete
            // 
            this.tlcDelete.Caption = "Delete";
            this.tlcDelete.ColumnEdit = this.repositoryItemCheckEdit1;
            this.tlcDelete.FieldName = "Delete";
            this.tlcDelete.Name = "tlcDelete";
            this.tlcDelete.Visible = true;
            this.tlcDelete.VisibleIndex = 4;
            this.tlcDelete.Width = 136;
            // 
            // ruleDetailTableAdapter
            // 
            this.ruleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tlcID
            // 
            this.tlcID.Caption = "ID";
            this.tlcID.FieldName = "ID";
            this.tlcID.Name = "tlcID";
            this.tlcID.OptionsColumn.AllowEdit = false;
            // 
            // RuleDetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLItems);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RuleDetailsUC";
            this.Size = new System.Drawing.Size(700, 332);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rulesLUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private NICSQLTools.Data.dsData dsData;
        private NICSQLTools.Data.dsQry dsQry;
        private System.Windows.Forms.BindingSource rulesLUEBindingSource;
        private NICSQLTools.Data.dsQryTableAdapters.Rules_LUETableAdapter rules_LUETableAdapter;
        private DevExpress.XtraTreeList.TreeList TLItems;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcSelect;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcInsert;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcUpdate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private NICSQLTools.Data.dsDataTableAdapters.RuleDetailTableAdapter ruleDetailTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcName;
        private DevExpress.XtraBars.BarEditItem bbiRule;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcID;
    }
}
