namespace NICSQLTools.Views.Data.MSrv
{
    partial class MSrv_TicketEditorUC
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu();
            this.barManagerMain = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcChat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditChat = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcAddVisit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditAddVisit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcClose = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditCloseTicket = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colTicketId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTecEquipmentSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditBigText = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colIssueContactPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueContactPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueContactPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTicketClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseMSrvType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosedComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_District_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTicket_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClose_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSrvDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartsCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditn2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditAddVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditCloseTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditBigText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).BeginInit();
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
            this.bbiAdd,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Create Ticket";
            this.bbiAdd.Glyph = global::NICSQLTools.Properties.Resources.add_16x16;
            this.bbiAdd.Id = 0;
            this.bbiAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiAdd.LargeGlyph = global::NICSQLTools.Properties.Resources.add_32x32;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NICSQLTools.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.gridControlMain.DataSource = this.LSMSData;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditn2,
            this.repositoryItemMemoExEditBigText,
            this.repositoryItemButtonEditAddVisit,
            this.repositoryItemButtonEditChat,
            this.repositoryItemButtonEditCloseTicket});
            this.gridControlMain.Size = new System.Drawing.Size(936, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(NICSQLTools.Data.Linq.vMSrv_Ticket_ByUser);
            this.LSMSData.KeyExpression = "[TicketId], [VisibleToUserId]";
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcChat,
            this.gcAddVisit,
            this.gcClose,
            this.colTicketId,
            this.colCustomerId,
            this.colEquipmentSerial,
            this.colTecEquipmentSerial,
            this.colOpenDate,
            this.colOpenComment,
            this.colIssueContactPerson,
            this.colIssueContactPhone2,
            this.colIssueAddress,
            this.colIssueContactPhone,
            this.colTicketClosed,
            this.colCloseMSrvType,
            this.colClosedComment,
            this.colClosedDate,
            this.colRoute,
            this.colSales_District_2,
            this.colPlant,
            this.colTicket_User,
            this.colClose_User,
            this.colMSrvDepartment,
            this.colVisitCount,
            this.colPartsCount});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewMain.OptionsImageLoad.AsyncLoad = true;
            this.gridViewMain.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridViewMain.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridViewMain_CustomRowCellEdit);
            this.gridViewMain.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridViewMain_CustomRowCellEditForEditing);
            // 
            // gcChat
            // 
            this.gcChat.AppearanceCell.Options.UseTextOptions = true;
            this.gcChat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcChat.AppearanceHeader.Options.UseTextOptions = true;
            this.gcChat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcChat.Caption = "Chat";
            this.gcChat.ColumnEdit = this.repositoryItemButtonEditChat;
            this.gcChat.Name = "gcChat";
            this.gcChat.Visible = true;
            this.gcChat.VisibleIndex = 1;
            // 
            // repositoryItemButtonEditChat
            // 
            this.repositoryItemButtonEditChat.AutoHeight = false;
            this.repositoryItemButtonEditChat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::NICSQLTools.Properties.Resources.MSrv_TicketChat16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.repositoryItemButtonEditChat.Name = "repositoryItemButtonEditChat";
            this.repositoryItemButtonEditChat.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditChat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditChat_ButtonClick);
            // 
            // gcAddVisit
            // 
            this.gcAddVisit.AppearanceCell.Options.UseTextOptions = true;
            this.gcAddVisit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcAddVisit.AppearanceHeader.Options.UseTextOptions = true;
            this.gcAddVisit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcAddVisit.Caption = "Visit";
            this.gcAddVisit.ColumnEdit = this.repositoryItemButtonEditAddVisit;
            this.gcAddVisit.Name = "gcAddVisit";
            this.gcAddVisit.Visible = true;
            this.gcAddVisit.VisibleIndex = 0;
            // 
            // repositoryItemButtonEditAddVisit
            // 
            this.repositoryItemButtonEditAddVisit.AutoHeight = false;
            this.repositoryItemButtonEditAddVisit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::NICSQLTools.Properties.Resources.MSrv_TicketVisit16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.repositoryItemButtonEditAddVisit.Name = "repositoryItemButtonEditAddVisit";
            this.repositoryItemButtonEditAddVisit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditAddVisit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditAddVisit_ButtonClick);
            // 
            // gcClose
            // 
            this.gcClose.AppearanceCell.Options.UseTextOptions = true;
            this.gcClose.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcClose.AppearanceHeader.Options.UseTextOptions = true;
            this.gcClose.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcClose.Caption = "Close Ticket";
            this.gcClose.ColumnEdit = this.repositoryItemButtonEditCloseTicket;
            this.gcClose.Name = "gcClose";
            this.gcClose.Visible = true;
            this.gcClose.VisibleIndex = 2;
            // 
            // repositoryItemButtonEditCloseTicket
            // 
            this.repositoryItemButtonEditCloseTicket.AutoHeight = false;
            this.repositoryItemButtonEditCloseTicket.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::NICSQLTools.Properties.Resources.MSrv_TicketClose16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.repositoryItemButtonEditCloseTicket.Name = "repositoryItemButtonEditCloseTicket";
            this.repositoryItemButtonEditCloseTicket.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditCloseTicket.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditCloseTicket_ButtonClick);
            // 
            // colTicketId
            // 
            this.colTicketId.Caption = "Ticket Id";
            this.colTicketId.FieldName = "TicketId";
            this.colTicketId.Name = "colTicketId";
            this.colTicketId.Visible = true;
            this.colTicketId.VisibleIndex = 3;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Caption = "Customer Id";
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 4;
            this.colCustomerId.Width = 79;
            // 
            // colEquipmentSerial
            // 
            this.colEquipmentSerial.Caption = "Equipment Serial";
            this.colEquipmentSerial.FieldName = "EquipmentSerial";
            this.colEquipmentSerial.Name = "colEquipmentSerial";
            this.colEquipmentSerial.Visible = true;
            this.colEquipmentSerial.VisibleIndex = 5;
            this.colEquipmentSerial.Width = 99;
            // 
            // colTecEquipmentSerial
            // 
            this.colTecEquipmentSerial.Caption = "Technician Equipment Serial";
            this.colTecEquipmentSerial.FieldName = "TecEquipmentSerial";
            this.colTecEquipmentSerial.Name = "colTecEquipmentSerial";
            this.colTecEquipmentSerial.Visible = true;
            this.colTecEquipmentSerial.VisibleIndex = 6;
            this.colTecEquipmentSerial.Width = 152;
            // 
            // colOpenDate
            // 
            this.colOpenDate.Caption = "Open Date";
            this.colOpenDate.FieldName = "OpenDate";
            this.colOpenDate.Name = "colOpenDate";
            this.colOpenDate.Visible = true;
            this.colOpenDate.VisibleIndex = 7;
            // 
            // colOpenComment
            // 
            this.colOpenComment.Caption = "Open Comment";
            this.colOpenComment.ColumnEdit = this.repositoryItemMemoExEditBigText;
            this.colOpenComment.FieldName = "OpenComment";
            this.colOpenComment.Name = "colOpenComment";
            this.colOpenComment.Visible = true;
            this.colOpenComment.VisibleIndex = 8;
            this.colOpenComment.Width = 94;
            // 
            // repositoryItemMemoExEditBigText
            // 
            this.repositoryItemMemoExEditBigText.AutoHeight = false;
            this.repositoryItemMemoExEditBigText.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditBigText.Name = "repositoryItemMemoExEditBigText";
            // 
            // colIssueContactPerson
            // 
            this.colIssueContactPerson.Caption = "Contact Person";
            this.colIssueContactPerson.FieldName = "IssueContactPerson";
            this.colIssueContactPerson.Name = "colIssueContactPerson";
            this.colIssueContactPerson.Visible = true;
            this.colIssueContactPerson.VisibleIndex = 9;
            this.colIssueContactPerson.Width = 94;
            // 
            // colIssueContactPhone2
            // 
            this.colIssueContactPhone2.Caption = "Nestle Contact Phone";
            this.colIssueContactPhone2.FieldName = "IssueContactPhone2";
            this.colIssueContactPhone2.Name = "colIssueContactPhone2";
            this.colIssueContactPhone2.Visible = true;
            this.colIssueContactPhone2.VisibleIndex = 12;
            this.colIssueContactPhone2.Width = 124;
            // 
            // colIssueAddress
            // 
            this.colIssueAddress.Caption = "Address";
            this.colIssueAddress.FieldName = "IssueAddress";
            this.colIssueAddress.Name = "colIssueAddress";
            this.colIssueAddress.Visible = true;
            this.colIssueAddress.VisibleIndex = 10;
            // 
            // colIssueContactPhone
            // 
            this.colIssueContactPhone.Caption = "Contact Phone";
            this.colIssueContactPhone.FieldName = "IssueContactPhone";
            this.colIssueContactPhone.Name = "colIssueContactPhone";
            this.colIssueContactPhone.Visible = true;
            this.colIssueContactPhone.VisibleIndex = 11;
            this.colIssueContactPhone.Width = 91;
            // 
            // colTicketClosed
            // 
            this.colTicketClosed.Caption = "Ticket Closed";
            this.colTicketClosed.FieldName = "TicketClosed";
            this.colTicketClosed.Name = "colTicketClosed";
            this.colTicketClosed.Visible = true;
            this.colTicketClosed.VisibleIndex = 13;
            this.colTicketClosed.Width = 83;
            // 
            // colCloseMSrvType
            // 
            this.colCloseMSrvType.Caption = "Close Reason";
            this.colCloseMSrvType.FieldName = "CloseMSrvType";
            this.colCloseMSrvType.Name = "colCloseMSrvType";
            this.colCloseMSrvType.Visible = true;
            this.colCloseMSrvType.VisibleIndex = 14;
            this.colCloseMSrvType.Width = 85;
            // 
            // colClosedComment
            // 
            this.colClosedComment.Caption = "Closed Comment";
            this.colClosedComment.FieldName = "ClosedComment";
            this.colClosedComment.Name = "colClosedComment";
            this.colClosedComment.Visible = true;
            this.colClosedComment.VisibleIndex = 15;
            this.colClosedComment.Width = 100;
            // 
            // colClosedDate
            // 
            this.colClosedDate.Caption = "Closed Date";
            this.colClosedDate.FieldName = "ClosedDate";
            this.colClosedDate.Name = "colClosedDate";
            this.colClosedDate.Visible = true;
            this.colClosedDate.VisibleIndex = 16;
            this.colClosedDate.Width = 78;
            // 
            // colRoute
            // 
            this.colRoute.AppearanceCell.Options.UseTextOptions = true;
            this.colRoute.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoute.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoute.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoute.Caption = "Route";
            this.colRoute.FieldName = "Route";
            this.colRoute.Name = "colRoute";
            this.colRoute.Visible = true;
            this.colRoute.VisibleIndex = 17;
            // 
            // colSales_District_2
            // 
            this.colSales_District_2.Caption = "Sales District";
            this.colSales_District_2.FieldName = "Sales_District_2";
            this.colSales_District_2.Name = "colSales_District_2";
            this.colSales_District_2.Visible = true;
            this.colSales_District_2.VisibleIndex = 18;
            this.colSales_District_2.Width = 81;
            // 
            // colPlant
            // 
            this.colPlant.AppearanceCell.Options.UseTextOptions = true;
            this.colPlant.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlant.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlant.Caption = "Plant";
            this.colPlant.FieldName = "Plant";
            this.colPlant.Name = "colPlant";
            this.colPlant.Visible = true;
            this.colPlant.VisibleIndex = 19;
            // 
            // colTicket_User
            // 
            this.colTicket_User.Caption = "Create By";
            this.colTicket_User.FieldName = "Ticket_User";
            this.colTicket_User.Name = "colTicket_User";
            this.colTicket_User.Visible = true;
            this.colTicket_User.VisibleIndex = 20;
            // 
            // colClose_User
            // 
            this.colClose_User.Caption = "Closed By";
            this.colClose_User.FieldName = "Close_User";
            this.colClose_User.Name = "colClose_User";
            this.colClose_User.Visible = true;
            this.colClose_User.VisibleIndex = 21;
            // 
            // colMSrvDepartment
            // 
            this.colMSrvDepartment.Caption = "Last Department";
            this.colMSrvDepartment.FieldName = "MSrvDepartment";
            this.colMSrvDepartment.Name = "colMSrvDepartment";
            this.colMSrvDepartment.Visible = true;
            this.colMSrvDepartment.VisibleIndex = 22;
            this.colMSrvDepartment.Width = 100;
            // 
            // colVisitCount
            // 
            this.colVisitCount.Caption = "Visit count";
            this.colVisitCount.FieldName = "VisitCount";
            this.colVisitCount.Name = "colVisitCount";
            this.colVisitCount.Visible = true;
            this.colVisitCount.VisibleIndex = 23;
            // 
            // colPartsCount
            // 
            this.colPartsCount.Caption = "Parts used";
            this.colPartsCount.FieldName = "PartCount";
            this.colPartsCount.Name = "colPartsCount";
            this.colPartsCount.Visible = true;
            this.colPartsCount.VisibleIndex = 24;
            // 
            // repositoryItemTextEditn2
            // 
            this.repositoryItemTextEditn2.AutoHeight = false;
            this.repositoryItemTextEditn2.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEditn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn2.EditFormat.FormatString = "n2";
            this.repositoryItemTextEditn2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn2.Mask.EditMask = "n2";
            this.repositoryItemTextEditn2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditn2.Name = "repositoryItemTextEditn2";
            // 
            // MSrv_TicketEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MSrv_TicketEditorUC";
            this.Size = new System.Drawing.Size(936, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditAddVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditCloseTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditBigText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditn2;
        private DevExpress.XtraGrid.Columns.GridColumn colTicketId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentSerial;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenComment;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditBigText;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueContactPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueContactPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colTicketClosed;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedComment;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_District_2;
        private DevExpress.XtraGrid.Columns.GridColumn colTicket_User;
        private DevExpress.XtraGrid.Columns.GridColumn colClose_User;
        private DevExpress.XtraGrid.Columns.GridColumn colMSrvDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPartsCount;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditAddVisit;
        private DevExpress.XtraGrid.Columns.GridColumn colRoute;
        private DevExpress.XtraGrid.Columns.GridColumn colPlant;
        private DevExpress.XtraGrid.Columns.GridColumn colTecEquipmentSerial;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueContactPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseMSrvType;
        private DevExpress.XtraGrid.Columns.GridColumn gcChat;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditChat;
        private DevExpress.XtraGrid.Columns.GridColumn gcAddVisit;
        private DevExpress.XtraGrid.Columns.GridColumn gcClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditCloseTicket;
    }
}
