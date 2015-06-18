namespace NICSQLTools.Views.Qry
{
    partial class ExcelDynamicUpdateUC
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colExcuteResultId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditExcuteResultId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSAppExcuteResult = new DevExpress.Data.Linq.LinqServerModeSource();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConnectionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatasourceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExcuteStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEditHMS = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colExcuteEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcElapsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditParam = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dsDataSource = new NICSQLTools.Data.dsDataSource();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditExcuteResultId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppExcuteResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEditHMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colExcuteResultId
            // 
            this.colExcuteResultId.AppearanceCell.Options.UseTextOptions = true;
            this.colExcuteResultId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExcuteResultId.AppearanceHeader.Options.UseTextOptions = true;
            this.colExcuteResultId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExcuteResultId.Caption = "State";
            this.colExcuteResultId.ColumnEdit = this.repositoryItemLookUpEditExcuteResultId;
            this.colExcuteResultId.FieldName = "ExResult";
            this.colExcuteResultId.Name = "colExcuteResultId";
            this.colExcuteResultId.Visible = true;
            this.colExcuteResultId.VisibleIndex = 1;
            this.colExcuteResultId.Width = 99;
            // 
            // repositoryItemLookUpEditExcuteResultId
            // 
            this.repositoryItemLookUpEditExcuteResultId.AutoHeight = false;
            this.repositoryItemLookUpEditExcuteResultId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditExcuteResultId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExcuteResultId", "Excute Result Id", 102, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExcuteResultName", "Excute Result Name", 106, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditExcuteResultId.DataSource = this.LSMSAppExcuteResult;
            this.repositoryItemLookUpEditExcuteResultId.DisplayMember = "ExcuteResultName";
            this.repositoryItemLookUpEditExcuteResultId.Name = "repositoryItemLookUpEditExcuteResultId";
            this.repositoryItemLookUpEditExcuteResultId.NullText = "";
            this.repositoryItemLookUpEditExcuteResultId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditExcuteResultId.ValueMember = "ExcuteResultId";
            // 
            // LSMSAppExcuteResult
            // 
            this.LSMSAppExcuteResult.ElementType = typeof(NICSQLTools.Data.Linq.AppExcuteResult);
            this.LSMSAppExcuteResult.KeyExpression = "[ExcuteResultId]";
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAdd});
            this.barManagerMain.MainMenu = this.bar2;
            this.barManagerMain.MaxItemId = 1;
            this.barManagerMain.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAdd)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add Excel";
            this.bbiAdd.Glyph = global::NICSQLTools.Properties.Resources.add_16x16;
            this.bbiAdd.Id = 0;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(900, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Size = new System.Drawing.Size(900, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 403);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(900, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 403);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rtbLog);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnStart);
            this.layoutControl1.Controls.Add(this.pbc);
            this.layoutControl1.Controls.Add(this.gridControlMain);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(820, 144, 250, 437);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(900, 403);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.Black;
            this.rtbLog.ForeColor = System.Drawing.Color.Lime;
            this.rtbLog.Location = new System.Drawing.Point(12, 296);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(876, 69);
            this.rtbLog.TabIndex = 8;
            this.rtbLog.Text = "Ready\n";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::NICSQLTools.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(172, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::NICSQLTools.Properties.Resources.apply_16x16;
            this.btnStart.Location = new System.Drawing.Point(12, 369);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 22);
            this.btnStart.StyleController = this.layoutControl1;
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbc
            // 
            this.pbc.Location = new System.Drawing.Point(264, 369);
            this.pbc.MenuManager = this.barManagerMain;
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(624, 18);
            this.pbc.StyleController = this.layoutControl1;
            this.pbc.TabIndex = 1;
            // 
            // gridControlMain
            // 
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(12, 12);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditRemove,
            this.repositoryItemTimeEditHMS,
            this.repositoryItemLookUpEditExcuteResultId,
            this.repositoryItemButtonEditParam});
            this.gridControlMain.Size = new System.Drawing.Size(876, 275);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRemove,
            this.colExcuteResultId,
            this.colFileName,
            this.colConnectionName,
            this.colDatasourceID,
            this.colExcuteStartDate,
            this.colExcuteEndDate,
            this.gcElapsed,
            this.colFilePath,
            this.gcParam});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colExcuteResultId;
            gridFormatRule1.ColumnApplyTo = this.colExcuteResultId;
            gridFormatRule1.Name = "ExcuteResultId=1[Success]";
            formatConditionRuleValue1.Appearance.BorderColor = System.Drawing.Color.Lime;
            formatConditionRuleValue1.Appearance.Options.UseBorderColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue1.Expression = "Iif([ExResult] = 1,  True, False)";
            formatConditionRuleValue1.PredefinedName = "Green Bold Text";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colExcuteResultId;
            gridFormatRule2.ColumnApplyTo = this.colExcuteResultId;
            gridFormatRule2.Name = "ExcuteResultId=2[Faild]";
            formatConditionRuleValue2.Appearance.BorderColor = System.Drawing.Color.Red;
            formatConditionRuleValue2.Appearance.Options.UseBorderColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue2.Expression = "Iif([ExResult] = 2,  True, False)";
            formatConditionRuleValue2.PredefinedName = "Red Bold Text";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridViewMain.FormatRules.Add(gridFormatRule1);
            this.gridViewMain.FormatRules.Add(gridFormatRule2);
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.ReadOnly = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.OptionsView.ShowIndicator = false;
            // 
            // gcRemove
            // 
            this.gcRemove.AppearanceCell.Options.UseTextOptions = true;
            this.gcRemove.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcRemove.AppearanceHeader.Options.UseTextOptions = true;
            this.gcRemove.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcRemove.Caption = "Remove";
            this.gcRemove.ColumnEdit = this.repositoryItemButtonEditRemove;
            this.gcRemove.Name = "gcRemove";
            this.gcRemove.Visible = true;
            this.gcRemove.VisibleIndex = 0;
            // 
            // repositoryItemButtonEditRemove
            // 
            this.repositoryItemButtonEditRemove.AutoHeight = false;
            this.repositoryItemButtonEditRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditRemove.Name = "repositoryItemButtonEditRemove";
            this.repositoryItemButtonEditRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditRemove.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditRemove_ButtonClick);
            // 
            // colFileName
            // 
            this.colFileName.AppearanceCell.Options.UseTextOptions = true;
            this.colFileName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.colFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FileName", "{0}")});
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 2;
            // 
            // colConnectionName
            // 
            this.colConnectionName.AppearanceCell.Options.UseTextOptions = true;
            this.colConnectionName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colConnectionName.AppearanceHeader.Options.UseTextOptions = true;
            this.colConnectionName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colConnectionName.Caption = "Connection Name";
            this.colConnectionName.FieldName = "ConName";
            this.colConnectionName.Name = "colConnectionName";
            this.colConnectionName.Visible = true;
            this.colConnectionName.VisibleIndex = 3;
            this.colConnectionName.Width = 125;
            // 
            // colDatasourceID
            // 
            this.colDatasourceID.AppearanceCell.Options.UseTextOptions = true;
            this.colDatasourceID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDatasourceID.AppearanceHeader.Options.UseTextOptions = true;
            this.colDatasourceID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDatasourceID.Caption = "Datasource";
            this.colDatasourceID.FieldName = "Datasource.Name";
            this.colDatasourceID.Name = "colDatasourceID";
            this.colDatasourceID.Visible = true;
            this.colDatasourceID.VisibleIndex = 4;
            this.colDatasourceID.Width = 89;
            // 
            // colExcuteStartDate
            // 
            this.colExcuteStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colExcuteStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExcuteStartDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colExcuteStartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExcuteStartDate.ColumnEdit = this.repositoryItemTimeEditHMS;
            this.colExcuteStartDate.FieldName = "ExcuteStartDate";
            this.colExcuteStartDate.Name = "colExcuteStartDate";
            this.colExcuteStartDate.Width = 106;
            // 
            // repositoryItemTimeEditHMS
            // 
            this.repositoryItemTimeEditHMS.AutoHeight = false;
            this.repositoryItemTimeEditHMS.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEditHMS.Name = "repositoryItemTimeEditHMS";
            // 
            // colExcuteEndDate
            // 
            this.colExcuteEndDate.AppearanceCell.Options.UseTextOptions = true;
            this.colExcuteEndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExcuteEndDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colExcuteEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExcuteEndDate.ColumnEdit = this.repositoryItemTimeEditHMS;
            this.colExcuteEndDate.FieldName = "ExcuteEndDate";
            this.colExcuteEndDate.Name = "colExcuteEndDate";
            this.colExcuteEndDate.Width = 100;
            // 
            // gcElapsed
            // 
            this.gcElapsed.AppearanceCell.Options.UseTextOptions = true;
            this.gcElapsed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcElapsed.AppearanceHeader.Options.UseTextOptions = true;
            this.gcElapsed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcElapsed.Caption = "Elapsed";
            this.gcElapsed.ColumnEdit = this.repositoryItemTimeEditHMS;
            this.gcElapsed.FieldName = "Elapsed";
            this.gcElapsed.Name = "gcElapsed";
            this.gcElapsed.Visible = true;
            this.gcElapsed.VisibleIndex = 5;
            // 
            // colFilePath
            // 
            this.colFilePath.AppearanceCell.Options.UseTextOptions = true;
            this.colFilePath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFilePath.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilePath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFilePath.FieldName = "FilePath";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.Visible = true;
            this.colFilePath.VisibleIndex = 6;
            this.colFilePath.Width = 190;
            // 
            // gcParam
            // 
            this.gcParam.AppearanceCell.Options.UseTextOptions = true;
            this.gcParam.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcParam.AppearanceHeader.Options.UseTextOptions = true;
            this.gcParam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcParam.Caption = "Paramters";
            this.gcParam.ColumnEdit = this.repositoryItemButtonEditParam;
            this.gcParam.Name = "gcParam";
            this.gcParam.Visible = true;
            this.gcParam.VisibleIndex = 7;
            // 
            // repositoryItemButtonEditParam
            // 
            this.repositoryItemButtonEditParam.AutoHeight = false;
            this.repositoryItemButtonEditParam.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditParam.Name = "repositoryItemButtonEditParam";
            this.repositoryItemButtonEditParam.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditParam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditParam_ButtonClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.splitterItem1,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(900, 403);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlMain;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(880, 279);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pbc;
            this.layoutControlItem2.Location = new System.Drawing.Point(252, 357);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(628, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnStart;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 357);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(160, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(160, 357);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(92, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 279);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(880, 5);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem5.Control = this.rtbLog;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 284);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(880, 73);
            this.layoutControlItem5.Text = "Result";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // dsDataSource
            // 
            this.dsDataSource.DataSetName = "dsDataSource";
            this.dsDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ofd
            // 
            this.ofd.Filter = "Excel workbook *.xlsx|*.xlsx|All Files *.*|*.*";
            this.ofd.Title = "choose excel file to add";
            // 
            // ExcelDynamicUpdateUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ExcelDynamicUpdateUC";
            this.Size = new System.Drawing.Size(900, 450);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditExcuteResultId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppExcuteResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEditHMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.OpenFileDialog ofd;
        private NICSQLTools.Data.dsDataSource dsDataSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colFilePath;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasourceID;
        private DevExpress.XtraGrid.Columns.GridColumn colExcuteStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExcuteEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExcuteResultId;
        private DevExpress.XtraGrid.Columns.GridColumn gcRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditRemove;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEditHMS;
        private DevExpress.XtraGrid.Columns.GridColumn gcElapsed;
        private DevExpress.XtraGrid.Columns.GridColumn colConnectionName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditExcuteResultId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAppExcuteResult;
        private DevExpress.XtraGrid.Columns.GridColumn gcParam;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditParam;
    }
}
