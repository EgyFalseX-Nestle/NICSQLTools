﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using log4net;
using DevExpress.XtraPivotGrid;

namespace NICSQLTools.Forms.Qry
{
    public partial class Qrysp_DistributionV1Frm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Qrysp_DistributionV1Frm));
        #endregion
        #region -   Functions   -
        public Qrysp_DistributionV1Frm()
        {
            InitializeComponent();
            DateTime now = DataManager.defaultInstance.ServerDateTime;
            bbiStartDate.EditValue = new DateTime(now.Year, now.Month, 1);
            bbiEndDate.EditValue = now.Date;

        }
        void LoadData()
        {
            //DataManager.SetAllCommandTimeouts(sp_DistributionV1TableAdapter, DataManager.ConnectionTimeout);
            //sp_DistributionV1TableAdapter.Fill(dsQry.sp_DistributionV1, Convert.ToDateTime(bbiStartDate.EditValue), Convert.ToDateTime(bbiEndDate.EditValue), SalesDistrict2);
            string SalesDistrict2;
            string SalesDistrictName;
            if (bbiSalesDistrict2.EditValue != null)
                SalesDistrict2 = bbiSalesDistrict2.EditValue.ToString();
            else
                SalesDistrict2 = string.Empty;
            if (bbiSalesDistrictName.EditValue != null)
                SalesDistrictName = bbiSalesDistrictName.EditValue.ToString();
            else
                SalesDistrictName = string.Empty;
            
            DevExpress.Xpo.DB.SelectedData DataObj = NICSQLTools.Data.IC_DB.SprocHelper.Execsp_DistributionV1(DevExpress.Xpo.XpoDefault.Session, Convert.ToDateTime(bbiStartDate.EditValue),
                Convert.ToDateTime(bbiEndDate.EditValue), SalesDistrict2, SalesDistrictName);
            xpDataViewMain.LoadData(DataObj);
            pivotGridControlMain.BestFit();

            chartControlMain.DataSource = pivotGridControlMain;

            
        }
        
        #endregion
        #region -   Event Handlers   -
        private void Qrysp_DistributionV1Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQry.SalesDistrictName' table. You can move, or remove it, as needed.
            this.salesDistrictNameTableAdapter.Fill(this.dsQry.SalesDistrictName);
            // TODO: This line of code loads data into the 'dsQry.SalesDistrict2' table. You can move, or remove it, as needed.
            this.salesDistrict2TableAdapter.Fill(this.dsQry.SalesDistrict2);

        }
        private void bbiGetData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bbiStartDate.EditValue == null || bbiEndDate.EditValue == null)
            {
                MsgDlg.Show("Please Select A Date", MsgDlg.MessageType.Warn);
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                LoadData();
            }));
            SplashScreenManager.CloseForm();

        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!pivotGridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            pivotGridControlMain.ShowRibbonPrintPreview();
        }
        private void pivotGridControlMain_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            Form form = new Form();
            form.Text = "Records";
            // Place a DataGrid control on the form.

            DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl();

            DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView(); view.OptionsView.ColumnAutoWidth = false;
            grid.MainView = view;

            grid.Parent = form;
            grid.Dock = DockStyle.Fill;
            // Get the recrd set associated with the current cell and bind it to the grid.
            grid.DataSource = e.CreateDrillDownDataSource();
            form.Bounds = new Rectangle(100, 100, 500, 400);
            // Display the form.
            form.ShowDialog();
            form.Dispose();
        }

        #endregion


    }
}
