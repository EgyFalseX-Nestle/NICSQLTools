using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Text;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DashboardCommon.DataProcessing.InMemoryDataProcessor;
using DevExpress.Map;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraMap;
using DevExpress.XtraMap.Native;
using DevExpress.XtraMap.Services;
using DevExpress.XtraSplashScreen;
using NICSQLTools.Data;


namespace NICSQLTools.Views.Qry
{
    public partial class CustomerMapUC : DevExpress.XtraEditors.XtraUserControl
    {
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        private NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        public CustomerMapUC(NICSQLTools.Data.dsData.AppRuleDetailRow ruleElement)
        {
            InitializeComponent();
            _elementRule = ruleElement;
            LSMSRoute.QueryableSource = from q in dsLinq.vRouteDetails select q;
        }
        private async void beiRoute_EditValueChanged(object sender, EventArgs e)
        {
            if (beiRoute.EditValue == null)
                return;
            //Load selected route customer
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            try
            {
                await
                    Task.Run(() =>
                        {
                            mapRouteCustomerTableAdapter.Fill(dsQry.MapRouteCustomer, beiRoute.EditValue.ToString());
                        });
                if (dsQry.MapRouteCustomer.Count > 0)
                {
                    //mapControlMain.CenterPoint = new GeoPoint(dsQry.MapRouteCustomer[0].Latitude, dsQry.MapRouteCustomer[0].Longitude);
                    //mapControlMain.ZoomLevel = 10;
                    IInnerMapService ims = ((IServiceProvider)mapControlMain).GetService(typeof(IInnerMapService)) as IInnerMapService;
                    DeferredActionCommand.Execute(ims.Map, () => {
                        mapControlMain.ZoomToFitLayerItems(mapControlMain.Layers.Where(l => l is VectorItemsLayer));
                    });
                }}
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
            SplashScreenManager.CloseForm();
        }
       private void beiCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (beiCustomer.EditValue == null)
            {return;}

            RepositoryItemSearchLookUpEdit editor = (RepositoryItemSearchLookUpEdit)beiCustomer.Edit;
            SearchLookUpEdit search = (SearchLookUpEdit)barManagerMain.ActiveEditor;
            dsQry.MapRouteCustomerRow row = (dsQry.MapRouteCustomerRow)((DataRowView)search.GetSelectedDataRow()).Row;
            mapControlMain.CenterPoint = new GeoPoint(row.Latitude, row.Longitude);
            mapControlMain.ZoomLevel = 18;//mapControlMain.SetCenterPoint(new CoordPoint(1, 2));
        }
        private void bbiMakKindRoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImageTilesLayer imgLay = (ImageTilesLayer)mapControlMain.Layers[0];
            BingMapDataProvider provider = (BingMapDataProvider)imgLay.DataProvider;
            provider.Kind = BingMapKind.Road;
        }
        private void bbiMakKindArea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImageTilesLayer imgLay = (ImageTilesLayer)mapControlMain.Layers[0];
            BingMapDataProvider provider = (BingMapDataProvider)imgLay.DataProvider;
            provider.Kind = BingMapKind.Area;
        }
        private void bbiMakKindHybrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImageTilesLayer imgLay = (ImageTilesLayer)mapControlMain.Layers[0];
            BingMapDataProvider provider = (BingMapDataProvider)imgLay.DataProvider;
            provider.Kind = BingMapKind.Hybrid;
        }
        private void bbiFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
      
        
    }
}
