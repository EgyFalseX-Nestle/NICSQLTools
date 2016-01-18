namespace NICSQLTools
{
    partial class TestFrm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTicketId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesDistrict3Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueContactPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueContactPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTicketClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosedComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_District_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTicket_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClose_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSrvDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartCount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.LSMSData;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(908, 480);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(NICSQLTools.Data.Linq.vMSrv_Ticket);
            this.LSMSData.KeyExpression = "[TicketId]";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTicketId,
            this.colCustomerId,
            this.colEquipmentSerial,
            this.colRoute,
            this.colOpenDate,
            this.colOpenComment,
            this.colSalesDistrict3Id,
            this.colIssueContactPerson,
            this.colIssueAddress,
            this.colIssueContactPhone,
            this.colCurrentDepartmentId,
            this.colTicketClosed,
            this.colClosedComment,
            this.colCloseUserIn,
            this.colClosedDate,
            this.colUserIn,
            this.colDateIn,
            this.colSales_District_2,
            this.colTicket_User,
            this.colClose_User,
            this.colMSrvDepartment,
            this.colVisitCount,
            this.colPartCount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colTicketId
            // 
            this.colTicketId.FieldName = "TicketId";
            this.colTicketId.Name = "colTicketId";
            this.colTicketId.Visible = true;
            this.colTicketId.VisibleIndex = 0;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 1;
            // 
            // colEquipmentSerial
            // 
            this.colEquipmentSerial.FieldName = "EquipmentSerial";
            this.colEquipmentSerial.Name = "colEquipmentSerial";
            this.colEquipmentSerial.Visible = true;
            this.colEquipmentSerial.VisibleIndex = 2;
            // 
            // colRoute
            // 
            this.colRoute.FieldName = "Route";
            this.colRoute.Name = "colRoute";
            this.colRoute.Visible = true;
            this.colRoute.VisibleIndex = 3;
            // 
            // colOpenDate
            // 
            this.colOpenDate.FieldName = "OpenDate";
            this.colOpenDate.Name = "colOpenDate";
            this.colOpenDate.Visible = true;
            this.colOpenDate.VisibleIndex = 4;
            // 
            // colOpenComment
            // 
            this.colOpenComment.FieldName = "OpenComment";
            this.colOpenComment.Name = "colOpenComment";
            this.colOpenComment.Visible = true;
            this.colOpenComment.VisibleIndex = 5;
            // 
            // colSalesDistrict3Id
            // 
            this.colSalesDistrict3Id.FieldName = "SalesDistrict3Id";
            this.colSalesDistrict3Id.Name = "colSalesDistrict3Id";
            this.colSalesDistrict3Id.Visible = true;
            this.colSalesDistrict3Id.VisibleIndex = 6;
            // 
            // colIssueContactPerson
            // 
            this.colIssueContactPerson.FieldName = "IssueContactPerson";
            this.colIssueContactPerson.Name = "colIssueContactPerson";
            this.colIssueContactPerson.Visible = true;
            this.colIssueContactPerson.VisibleIndex = 7;
            // 
            // colIssueAddress
            // 
            this.colIssueAddress.FieldName = "IssueAddress";
            this.colIssueAddress.Name = "colIssueAddress";
            this.colIssueAddress.Visible = true;
            this.colIssueAddress.VisibleIndex = 8;
            // 
            // colIssueContactPhone
            // 
            this.colIssueContactPhone.FieldName = "IssueContactPhone";
            this.colIssueContactPhone.Name = "colIssueContactPhone";
            this.colIssueContactPhone.Visible = true;
            this.colIssueContactPhone.VisibleIndex = 9;
            // 
            // colCurrentDepartmentId
            // 
            this.colCurrentDepartmentId.FieldName = "CurrentDepartmentId";
            this.colCurrentDepartmentId.Name = "colCurrentDepartmentId";
            this.colCurrentDepartmentId.Visible = true;
            this.colCurrentDepartmentId.VisibleIndex = 10;
            // 
            // colTicketClosed
            // 
            this.colTicketClosed.FieldName = "TicketClosed";
            this.colTicketClosed.Name = "colTicketClosed";
            this.colTicketClosed.Visible = true;
            this.colTicketClosed.VisibleIndex = 11;
            // 
            // colClosedComment
            // 
            this.colClosedComment.FieldName = "ClosedComment";
            this.colClosedComment.Name = "colClosedComment";
            this.colClosedComment.Visible = true;
            this.colClosedComment.VisibleIndex = 12;
            // 
            // colCloseUserIn
            // 
            this.colCloseUserIn.FieldName = "CloseUserIn";
            this.colCloseUserIn.Name = "colCloseUserIn";
            this.colCloseUserIn.Visible = true;
            this.colCloseUserIn.VisibleIndex = 13;
            // 
            // colClosedDate
            // 
            this.colClosedDate.FieldName = "ClosedDate";
            this.colClosedDate.Name = "colClosedDate";
            this.colClosedDate.Visible = true;
            this.colClosedDate.VisibleIndex = 14;
            // 
            // colUserIn
            // 
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.Visible = true;
            this.colUserIn.VisibleIndex = 15;
            // 
            // colDateIn
            // 
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.Visible = true;
            this.colDateIn.VisibleIndex = 16;
            // 
            // colSales_District_2
            // 
            this.colSales_District_2.FieldName = "Sales_District_2";
            this.colSales_District_2.Name = "colSales_District_2";
            this.colSales_District_2.Visible = true;
            this.colSales_District_2.VisibleIndex = 17;
            // 
            // colTicket_User
            // 
            this.colTicket_User.FieldName = "Ticket_User";
            this.colTicket_User.Name = "colTicket_User";
            this.colTicket_User.Visible = true;
            this.colTicket_User.VisibleIndex = 18;
            // 
            // colClose_User
            // 
            this.colClose_User.FieldName = "Close_User";
            this.colClose_User.Name = "colClose_User";
            this.colClose_User.Visible = true;
            this.colClose_User.VisibleIndex = 19;
            // 
            // colMSrvDepartment
            // 
            this.colMSrvDepartment.FieldName = "MSrvDepartment";
            this.colMSrvDepartment.Name = "colMSrvDepartment";
            this.colMSrvDepartment.Visible = true;
            this.colMSrvDepartment.VisibleIndex = 20;
            // 
            // colVisitCount
            // 
            this.colVisitCount.FieldName = "VisitCount";
            this.colVisitCount.Name = "colVisitCount";
            this.colVisitCount.Visible = true;
            this.colVisitCount.VisibleIndex = 21;
            // 
            // colPartCount
            // 
            this.colPartCount.FieldName = "PartCount";
            this.colPartCount.Name = "colPartCount";
            this.colPartCount.Visible = true;
            this.colPartCount.VisibleIndex = 22;
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 480);
            this.Controls.Add(this.gridControl1);
            this.Name = "TestFrm";
            this.Text = "TestFrm";
            this.Load += new System.EventHandler(this.TestFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraGrid.Columns.GridColumn colTicketId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentSerial;
        private DevExpress.XtraGrid.Columns.GridColumn colRoute;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenComment;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDistrict3Id;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueContactPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueContactPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colTicketClosed;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedComment;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_District_2;
        private DevExpress.XtraGrid.Columns.GridColumn colTicket_User;
        private DevExpress.XtraGrid.Columns.GridColumn colClose_User;
        private DevExpress.XtraGrid.Columns.GridColumn colMSrvDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPartCount;





    }
}