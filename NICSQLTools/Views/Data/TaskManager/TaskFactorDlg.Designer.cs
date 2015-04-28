namespace NICSQLTools.Views.Data.TaskManager
{
    partial class TaskFactorDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskFactorDlg));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.tskEmpTaskFactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTask = new NICSQLTools.Data.dsTask();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTaskFactorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditFactorId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSFactor = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colFactorContribution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUserIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSUsers = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tskEmp_TaskFactorTableAdapter = new NICSQLTools.Data.dsTaskTableAdapters.TskEmp_TaskFactorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tskEmpTaskFactorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditFactorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.gridControlMain);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(709, 146, 250, 350);
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
            this.layoutControl1.Size = new System.Drawing.Size(511, 262);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::NICSQLTools.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(364, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::NICSQLTools.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(380, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.tskEmpTaskFactorBindingSource;
            this.gridControlMain.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlMain_EmbeddedNavigator_ButtonClick);
            this.gridControlMain.Location = new System.Drawing.Point(12, 12);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditFactorId,
            this.repositoryItemLookUpEditUserIn});
            this.gridControlMain.Size = new System.Drawing.Size(487, 212);
            this.gridControlMain.TabIndex = 6;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // tskEmpTaskFactorBindingSource
            // 
            this.tskEmpTaskFactorBindingSource.DataMember = "TskEmp_TaskFactor";
            this.tskEmpTaskFactorBindingSource.DataSource = this.dsTask;
            // 
            // dsTask
            // 
            this.dsTask.DataSetName = "dsTask";
            this.dsTask.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTaskFactorId,
            this.colFactorId,
            this.colFactorContribution,
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
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridViewMain.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewMain_InitNewRow);
            // 
            // colTaskFactorId
            // 
            this.colTaskFactorId.FieldName = "TaskFactorId";
            this.colTaskFactorId.Name = "colTaskFactorId";
            this.colTaskFactorId.OptionsColumn.AllowEdit = false;
            this.colTaskFactorId.OptionsColumn.ReadOnly = true;
            // 
            // colFactorId
            // 
            this.colFactorId.Caption = "Factor";
            this.colFactorId.ColumnEdit = this.repositoryItemLookUpEditFactorId;
            this.colFactorId.FieldName = "FactorId";
            this.colFactorId.Name = "colFactorId";
            this.colFactorId.Visible = true;
            this.colFactorId.VisibleIndex = 0;
            this.colFactorId.Width = 105;
            // 
            // repositoryItemLookUpEditFactorId
            // 
            this.repositoryItemLookUpEditFactorId.AutoHeight = false;
            this.repositoryItemLookUpEditFactorId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditFactorId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FactorName", "Factor Name", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
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
            // colFactorContribution
            // 
            this.colFactorContribution.Caption = "Weight";
            this.colFactorContribution.FieldName = "FactorContribution";
            this.colFactorContribution.Name = "colFactorContribution";
            this.colFactorContribution.Visible = true;
            this.colFactorContribution.VisibleIndex = 1;
            this.colFactorContribution.Width = 85;
            // 
            // colUserIn
            // 
            this.colUserIn.ColumnEdit = this.repositoryItemLookUpEditUserIn;
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.OptionsColumn.AllowEdit = false;
            this.colUserIn.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemLookUpEditUserIn
            // 
            this.repositoryItemLookUpEditUserIn.AutoHeight = false;
            this.repositoryItemLookUpEditUserIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserIn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "User Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditUserIn.DataSource = this.LSMSUsers;
            this.repositoryItemLookUpEditUserIn.DisplayMember = "RealName";
            this.repositoryItemLookUpEditUserIn.Name = "repositoryItemLookUpEditUserIn";
            this.repositoryItemLookUpEditUserIn.ValueMember = "UserID";
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(511, 262);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlMain;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(491, 216);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(368, 216);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(123, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(368, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // tskEmp_TaskFactorTableAdapter
            // 
            this.tskEmp_TaskFactorTableAdapter.ClearBeforeFill = true;
            // 
            // TaskFactorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 262);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskFactorDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Factor";
            this.Load += new System.EventHandler(this.TaskFactorDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tskEmpTaskFactorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditFactorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskFactorId;
        private DevExpress.XtraGrid.Columns.GridColumn colFactorId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditFactorId;
        private DevExpress.XtraGrid.Columns.GridColumn colFactorContribution;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSFactor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserIn;
        private NICSQLTools.Data.dsTask dsTask;
        private System.Windows.Forms.BindingSource tskEmpTaskFactorBindingSource;
        private NICSQLTools.Data.dsTaskTableAdapters.TskEmp_TaskFactorTableAdapter tskEmp_TaskFactorTableAdapter;
    }
}