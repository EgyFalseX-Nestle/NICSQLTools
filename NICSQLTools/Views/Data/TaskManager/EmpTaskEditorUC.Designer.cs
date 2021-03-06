﻿namespace NICSQLTools.Views.Data.TaskManager
{
    partial class EmpTaskEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpTaskEditorUC));
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
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
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpTaskId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditEmpId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSEmp = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colTaskId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditTaskId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSTask = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colTaskStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSUsers = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEmpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTaskId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            this.UOW.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.UOW_BeforeCommitTransaction);
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
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlMain_EmbeddedNavigator_ButtonClick);
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditUser,
            this.repositoryItemLookUpEditTaskId,
            this.repositoryItemLookUpEditEmpId});
            this.gridControlMain.Size = new System.Drawing.Size(936, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpTaskId,
            this.colEmpId,
            this.colTaskId,
            this.colTaskStartDate,
            this.colTaskEndDate,
            this.colUserIn,
            this.colDateIn});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "Click here to add a new";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewMain.OptionsImageLoad.AsyncLoad = true;
            this.gridViewMain.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            // 
            // colEmpTaskId
            // 
            this.colEmpTaskId.FieldName = "EmpTaskId";
            this.colEmpTaskId.Name = "colEmpTaskId";
            this.colEmpTaskId.OptionsColumn.AllowEdit = false;
            this.colEmpTaskId.OptionsColumn.ReadOnly = true;
            // 
            // colEmpId
            // 
            this.colEmpId.Caption = "Employee";
            this.colEmpId.ColumnEdit = this.repositoryItemLookUpEditEmpId;
            this.colEmpId.FieldName = "EmpId";
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.Visible = true;
            this.colEmpId.VisibleIndex = 0;
            this.colEmpId.Width = 108;
            // 
            // repositoryItemLookUpEditEmpId
            // 
            this.repositoryItemLookUpEditEmpId.AutoHeight = false;
            this.repositoryItemLookUpEditEmpId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditEmpId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Empname", "Empname", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpSite", "Emp Site", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditEmpId.DataSource = this.LSMSEmp;
            this.repositoryItemLookUpEditEmpId.DisplayMember = "Empname";
            this.repositoryItemLookUpEditEmpId.Name = "repositoryItemLookUpEditEmpId";
            this.repositoryItemLookUpEditEmpId.NullText = "";
            this.repositoryItemLookUpEditEmpId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditEmpId.ValueMember = "EmpId";
            // 
            // LSMSEmp
            // 
            this.LSMSEmp.ElementType = typeof(NICSQLTools.Data.Linq.TskEmp_Emp);
            this.LSMSEmp.KeyExpression = "[EmpId]";
            // 
            // colTaskId
            // 
            this.colTaskId.Caption = "Task";
            this.colTaskId.ColumnEdit = this.repositoryItemLookUpEditTaskId;
            this.colTaskId.FieldName = "TaskId";
            this.colTaskId.Name = "colTaskId";
            this.colTaskId.Visible = true;
            this.colTaskId.VisibleIndex = 1;
            this.colTaskId.Width = 108;
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
            // colTaskStartDate
            // 
            this.colTaskStartDate.Caption = "Start Date";
            this.colTaskStartDate.FieldName = "TaskStartDate";
            this.colTaskStartDate.Name = "colTaskStartDate";
            this.colTaskStartDate.Visible = true;
            this.colTaskStartDate.VisibleIndex = 2;
            this.colTaskStartDate.Width = 103;
            // 
            // colTaskEndDate
            // 
            this.colTaskEndDate.Caption = "End Date";
            this.colTaskEndDate.FieldName = "TaskEndDate";
            this.colTaskEndDate.Name = "colTaskEndDate";
            this.colTaskEndDate.Visible = true;
            this.colTaskEndDate.VisibleIndex = 3;
            this.colTaskEndDate.Width = 103;
            // 
            // colUserIn
            // 
            this.colUserIn.ColumnEdit = this.repositoryItemLookUpEditUser;
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.OptionsColumn.AllowEdit = false;
            this.colUserIn.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemLookUpEditUser
            // 
            this.repositoryItemLookUpEditUser.AutoHeight = false;
            this.repositoryItemLookUpEditUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUser.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditUser.DataSource = this.LSMSUsers;
            this.repositoryItemLookUpEditUser.DisplayMember = "RealName";
            this.repositoryItemLookUpEditUser.Name = "repositoryItemLookUpEditUser";
            this.repositoryItemLookUpEditUser.NullText = "";
            this.repositoryItemLookUpEditUser.ValueMember = "UserID";
            // 
            // LSMSUsers
            // 
            this.LSMSUsers.ElementType = typeof(NICSQLTools.Data.Linq.AppUser);
            this.LSMSUsers.KeyExpression = "[UserID]";
            // 
            // colDateIn
            // 
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.OptionsColumn.AllowEdit = false;
            this.colDateIn.OptionsColumn.ReadOnly = true;
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsTask.TskEmp_EmpTaskDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // EmpTaskEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "EmpTaskEditorUC";
            this.Size = new System.Drawing.Size(936, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEmpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTaskId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork UOW;
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
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUsers;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUser;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTask;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSEmp;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTaskId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditEmpId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpTaskId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpId;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskId;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
    }
}
