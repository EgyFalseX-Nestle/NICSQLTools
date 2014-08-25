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
    public partial class FinalDataGridUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region - Var -
        NICSQLTools.Data.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.dsLinqDataDataContext();
        #endregion
        #region - Fun -
        public FinalDataGridUC()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                this.Invoke(new MethodInvoker(() => {
                    LSMS.QueryableSource = from q in dsLinq._0_0_Final_Data_Alls select q;
                    //gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        #endregion
        #region -  EventWhnd - 
        private void FinalDataGridUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                return;

            DevExpress.Xpo.AsyncCommitCallback CommitCallBack = new DevExpress.Xpo.AsyncCommitCallback((o) =>
            {
                SplashScreenManager.CloseForm();
                if (o == null)
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)this.Parent.Parent.Parent);
                else
                    MsgDlg.ShowAlert("Saving Failed ..." + Environment.NewLine + o.Message, MsgDlg.MessageType.Error, (Form)this.Parent.Parent.Parent);
            });

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            //UOW.CommitTransactionAsync(CommitCallBack);
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion

    }
}
