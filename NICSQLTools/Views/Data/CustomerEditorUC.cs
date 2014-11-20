﻿using System;
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

namespace NICSQLTools.Views.Data
{
    public partial class CustomerEditorUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CustomerEditorUC));
        #endregion
        #region - Fun -
        public CustomerEditorUC()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                this.Invoke(new MethodInvoker(() => {
                    XPSCS.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
                    gridControlMain.DataSource = XPSCS;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        #endregion
        #region -  EventWhnd - 
        private void CustomerEditorUC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQry.DistributionChannel2' table. You can move, or remove it, as needed.
            this.distributionChannel2TableAdapter.Fill(this.dsQry.DistributionChannel2);
            // TODO: This line of code loads data into the 'dsQry.LevelCCSD' table. You can move, or remove it, as needed.
            this.levelCCSDTableAdapter.Fill(this.dsQry.LevelCCSD);
            // TODO: This line of code loads data into the 'dsQry.Subchannel' table. You can move, or remove it, as needed.
            this.subchannelTableAdapter.Fill(this.dsQry.Subchannel);
            // TODO: This line of code loads data into the 'dsQry.CustomerType2' table. You can move, or remove it, as needed.
            this.customerType2TableAdapter.Fill(this.dsQry.CustomerType2);
            // TODO: This line of code loads data into the 'dsQry.CustomerType' table. You can move, or remove it, as needed.
            this.customerTypeTableAdapter.Fill(this.dsQry.CustomerType);
            // TODO: This line of code loads data into the 'dsQry.CustomerGroup' table. You can move, or remove it, as needed.
            this.customerGroupTableAdapter.Fill(this.dsQry.CustomerGroup);
            LoadData();
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            DevExpress.Xpo.AsyncCommitCallback CommitCallBack = (o) =>
            {
                SplashScreenManager.CloseForm();
                if (o == null)
                {
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)this.Parent.Parent.Parent);
                    Logger.Info("Data Saved ...");
                }
                else
                {
                    MsgDlg.ShowAlert(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, o.Message), MsgDlg.MessageType.Error, (Form)this.Parent.Parent.Parent);
                    Logger.Error(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, o.InnerException.Message), o.InnerException);
                }
            };

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            UOW.CommitTransactionAsync(CommitCallBack);
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
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            UOW.DropIdentityMap();
            UOW.DropChanges();
            XPSCS.Reload();
            gridViewMain.RefreshData();

        }
        #endregion

        

    }
}
