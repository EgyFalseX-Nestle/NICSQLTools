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
using DevExpress.XtraGrid.Views.Grid;
using NICSQLTools.Classes.Managers;

namespace NICSQLTools.Views.Qry.MSrv
{public partial class MSrv_04 : DevExpress.XtraEditors.XtraUserControl
    {
        public MSrv_04()
        {
            InitializeComponent();
            DataManager.SetAllCommandTimeouts(qry04TableAdapter, DataManager.ConnectionTimeout);
        }
        private void MSrv_01_Load(object sender, EventArgs e)
        {
            DateTime? dt = DataManager.adpQry.GetServerDate();
            bbiStartDate.EditValue = bbiEndDate.EditValue = dt;
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
        private void bbiExecute_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bbiStartDate.EditValue == null || bbiEndDate.EditValue == null)
            {
                MsgDlg.Show("you should enter start and end date to before execute", MsgDlg.MessageType.Error);
                return;
            }
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    qry04TableAdapter.Fill(dsMSrc.Qry04, (DateTime)bbiStartDate.EditValue, (DateTime)bbiEndDate.EditValue, UserManager.defaultInstance.User.UserId);
                    gridViewMain.BestFitColumns();}));
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            });
        }
    }
}
