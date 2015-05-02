namespace NICSQLTools.Views.Data.TaskManager
{
    partial class EmpTaskActualEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpTaskActualEditorUC));
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.tskEmpEmpTaskActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTask = new NICSQLTools.Data.dsTask();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditTaskId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSTask = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colTaskActualDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LSMSUsers = new DevExpress.Data.Linq.LinqServerModeSource();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlFactors = new DevExpress.XtraGrid.GridControl();
            this.tskEmpEmpTaskActualFactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewFactors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditFactorId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSFactor = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colFactorEvalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tskEmp_EmpTaskActualTableAdapter = new NICSQLTools.Data.dsTaskTableAdapters.TskEmp_EmpTaskActualTableAdapter();
            this.tskEmp_EmpTaskActualFactorTableAdapter = new NICSQLTools.Data.dsTaskTableAdapters.TskEmp_EmpTaskActualFactorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tskEmpEmpTaskActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTaskId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tskEmpEmpTaskActualFactorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditFactorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
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
            this.bbiSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.LargeGlyph")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.barDockControlTop.Size = new System.Drawing.Size(936, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(936, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(936, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.tskEmpEmpTaskActualBindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 0);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditTaskId});
            this.gridControlMain.Size = new System.Drawing.Size(461, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // tskEmpEmpTaskActualBindingSource
            // 
            this.tskEmpEmpTaskActualBindingSource.DataMember = "TskEmp_EmpTaskActual";
            this.tskEmpEmpTaskActualBindingSource.DataSource = this.dsTask;
            // 
            // dsTask
            // 
            this.dsTask.DataSetName = "dsTask";
            this.dsTask.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.colTaskActualDesc});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewMain.OptionsImageLoad.AsyncLoad = true;
            this.gridViewMain.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridViewMain.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewMain_RowCellClick);
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Task";
            this.gridColumn7.ColumnEdit = this.repositoryItemLookUpEditTaskId;
            this.gridColumn7.FieldName = "TaskId";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 116;
            // 
            // repositoryItemLookUpEditTaskId
            // 
            this.repositoryItemLookUpEditTaskId.AutoHeight = false;
            this.repositoryItemLookUpEditTaskId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditTaskId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaskName", "Task Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaskDays", "Task Days", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaskDesc", "Task Desc", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditTaskId.DataSource = this.LSMSTask;
            this.repositoryItemLookUpEditTaskId.DisplayMember = "TaskName";
            this.repositoryItemLookUpEditTaskId.Name = "repositoryItemLookUpEditTaskId";
            this.repositoryItemLookUpEditTaskId.NullText = "";
            this.repositoryItemLookUpEditTaskId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditTaskId.ValueMember = "TaskId";
            // 
            // LSMSTask
            // 
            this.LSMSTask.ElementType = typeof(NICSQLTools.Data.Linq.TskEmp_Task);
            this.LSMSTask.KeyExpression = "[TaskId]";
            // 
            // colTaskActualDesc
            // 
            this.colTaskActualDesc.AppearanceCell.Options.UseTextOptions = true;
            this.colTaskActualDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTaskActualDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colTaskActualDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTaskActualDesc.Caption = "Comments";
            this.colTaskActualDesc.FieldName = "TaskActualDesc";
            this.colTaskActualDesc.Name = "colTaskActualDesc";
            this.colTaskActualDesc.Visible = true;
            this.colTaskActualDesc.VisibleIndex = 1;
            this.colTaskActualDesc.Width = 199;
            // 
            // LSMSUsers
            // 
            this.LSMSUsers.ElementType = typeof(NICSQLTools.Data.Linq.AppUser);
            this.LSMSUsers.KeyExpression = "[UserID]";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlMain);
            this.splitContainerControl1.Panel1.ShowCaption = true;
            this.splitContainerControl1.Panel1.Text = "Tasks";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlFactors);
            this.splitContainerControl1.Panel2.ShowCaption = true;
            this.splitContainerControl1.Panel2.Text = "Actual Completion";
            this.splitContainerControl1.ShowCaption = true;
            this.splitContainerControl1.Size = new System.Drawing.Size(936, 377);
            this.splitContainerControl1.SplitterPosition = 461;
            this.splitContainerControl1.TabIndex = 10;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlFactors
            // 
            this.gridControlFactors.DataSource = this.tskEmpEmpTaskActualFactorBindingSource;
            this.gridControlFactors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFactors.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlFactors.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlFactors.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlFactors.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlFactors.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlFactors.Location = new System.Drawing.Point(0, 0);
            this.gridControlFactors.MainView = this.gridViewFactors;
            this.gridControlFactors.MenuManager = this.barManagerMain;
            this.gridControlFactors.Name = "gridControlFactors";
            this.gridControlFactors.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditFactorId});
            this.gridControlFactors.Size = new System.Drawing.Size(470, 377);
            this.gridControlFactors.TabIndex = 6;
            this.gridControlFactors.UseEmbeddedNavigator = true;
            this.gridControlFactors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFactors});
            // 
            // tskEmpEmpTaskActualFactorBindingSource
            // 
            this.tskEmpEmpTaskActualFactorBindingSource.DataMember = "TskEmp_EmpTaskActualFactor";
            this.tskEmpEmpTaskActualFactorBindingSource.DataSource = this.dsTask;
            // 
            // gridViewFactors
            // 
            this.gridViewFactors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colFactorEvalValue,
            this.colUserIn,
            this.colDateIn});
            this.gridViewFactors.GridControl = this.gridControlFactors;
            this.gridViewFactors.Name = "gridViewFactors";
            this.gridViewFactors.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewFactors.OptionsImageLoad.AsyncLoad = true;
            this.gridViewFactors.OptionsView.ColumnAutoWidth = false;
            this.gridViewFactors.OptionsView.ShowDetailButtons = false;
            this.gridViewFactors.OptionsView.ShowGroupPanel = false;
            this.gridViewFactors.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridViewFactors.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewFactors_CellValueChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Criteria";
            this.gridColumn2.ColumnEdit = this.repositoryItemLookUpEditFactorId;
            this.gridColumn2.FieldName = "FactorId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 207;
            // 
            // repositoryItemLookUpEditFactorId
            // 
            this.repositoryItemLookUpEditFactorId.AutoHeight = false;
            this.repositoryItemLookUpEditFactorId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditFactorId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FactorName", "Factor Name", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaskName", "Task Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaskDays", "Task Days", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaskDesc", "Task Desc", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditFactorId.DataSource = this.LSMSFactor;
            this.repositoryItemLookUpEditFactorId.DisplayMember = "FactorName";
            this.repositoryItemLookUpEditFactorId.Name = "repositoryItemLookUpEditFactorId";
            this.repositoryItemLookUpEditFactorId.NullText = "";
            this.repositoryItemLookUpEditFactorId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditFactorId.ValueMember = "FactorId";
            // 
            // LSMSFactor
            // 
            this.LSMSFactor.ElementType = typeof(NICSQLTools.Data.Linq.TskEmp_Factor);
            this.LSMSFactor.KeyExpression = "[FactorId]";
            // 
            // colFactorEvalValue
            // 
            this.colFactorEvalValue.AppearanceCell.Options.UseTextOptions = true;
            this.colFactorEvalValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFactorEvalValue.AppearanceHeader.Options.UseTextOptions = true;
            this.colFactorEvalValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFactorEvalValue.Caption = "Score";
            this.colFactorEvalValue.FieldName = "FactorEvalValue";
            this.colFactorEvalValue.Name = "colFactorEvalValue";
            this.colFactorEvalValue.Visible = true;
            this.colFactorEvalValue.VisibleIndex = 1;
            this.colFactorEvalValue.Width = 130;
            // 
            // colUserIn
            // 
            this.colUserIn.AppearanceCell.Options.UseTextOptions = true;
            this.colUserIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            // 
            // colDateIn
            // 
            this.colDateIn.AppearanceCell.Options.UseTextOptions = true;
            this.colDateIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDateIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colDateIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            // 
            // tskEmp_EmpTaskActualTableAdapter
            // 
            this.tskEmp_EmpTaskActualTableAdapter.ClearBeforeFill = true;
            // 
            // tskEmp_EmpTaskActualFactorTableAdapter
            // 
            this.tskEmp_EmpTaskActualFactorTableAdapter.ClearBeforeFill = true;
            // 
            // EmpTaskActualEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "EmpTaskActualEditorUC";
            this.Size = new System.Drawing.Size(936, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tskEmpEmpTaskActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTaskId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tskEmpEmpTaskActualFactorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditFactorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUsers;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTask;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTaskId;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlFactors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFactors;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditFactorId;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskActualDesc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colFactorEvalValue;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSFactor;
        private System.Windows.Forms.BindingSource tskEmpEmpTaskActualBindingSource;
        private NICSQLTools.Data.dsTask dsTask;
        private System.Windows.Forms.BindingSource tskEmpEmpTaskActualFactorBindingSource;
        private NICSQLTools.Data.dsTaskTableAdapters.TskEmp_EmpTaskActualTableAdapter tskEmp_EmpTaskActualTableAdapter;
        private NICSQLTools.Data.dsTaskTableAdapters.TskEmp_EmpTaskActualFactorTableAdapter tskEmp_EmpTaskActualFactorTableAdapter;
    }
}
