using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace NICSQLTools.Views.Qry
{
    public partial class FinalDataPivotUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region - Var -
        NICSQLTools.Data.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.dsLinqDataDataContext();
        #endregion
        #region - Fun -
        public FinalDataPivotUC()
        {
            InitializeComponent();
        }
        void LoadData()
        {

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    LSMS.QueryableSource = from q in dsLinq._0_0_Final_Data_Alls where q.Billing_date_for_bil == DateTime.Now.AddDays(-1) select q;
                    //XPClassInfo clsInfo = sessionMain.GetClassInfo(typeof(NICSQLTools.Data.dsQry._0_0_Final_Data_AllDataTable));
                    //xpServerCollectionSourceMain = new DevExpress.Xpo.XPServerCollectionSource(sessionMain, clsInfo);
                    //pivotGridControlMain.DataSource = xpServerCollectionSourceMain;
                    //gridViewMain.BestFitColumns();
                    //pivotGridControlMain.Prefilter.ChangePrefilterVisible();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        #endregion
        #region -  EventWhnd - 
        private void Frm_Load(object sender, EventArgs e)
        {
            //pivotGridControlMain.is
        }
        private void CustomerEditorFrm_Shown(object sender, EventArgs e)
        {
            LoadData();
            //filterEditorControlMain.SourceControl = pivotGridControlMain;
            //pivotGridControlMain.Prefilter.CriteriaString = "[fieldBillingdateforbil] Between(#2014-01-01#, #2014-12-31#)";
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
        private void btnExecute_Click(object sender, EventArgs e)
        {

            //filterEditorControlMain.SourceControl = NICSQLTools.Data.IC_DB.P_0_0FinalDataAll;
        }
        #endregion

    }
}
