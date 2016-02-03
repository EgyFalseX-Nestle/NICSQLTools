using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;


namespace NICSQLTools.Views.Data
{
    public partial class AddDatasourceWiz : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(AddDatasourceWiz));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        NICSQLTools.Data.dsDataSourceTableAdapters.AppDatasourceTableAdapter adpDS = new NICSQLTools.Data.dsDataSourceTableAdapters.AppDatasourceTableAdapter();
        NICSQLTools.Data.dsDataSourceTableAdapters.AppDatasourceParamTableAdapter adpParam = new NICSQLTools.Data.dsDataSourceTableAdapters.AppDatasourceParamTableAdapter();
        int _dSCategoryId;

        #endregion
        #region -   Functions   -
        public AddDatasourceWiz(int DSCategoryId)
        {
            InitializeComponent();

            _dSCategoryId = DSCategoryId;

            LSMSLookup.QueryableSource = from q in dsLinq.AppDatasourceLookups select q;
            LSMSAppDatasourceType.QueryableSource = from q in dsLinq.AppDatasourceType_LUEs select q;
            this.rOUTINESTableAdapter.Fill(this.dsDataSource.ROUTINES);
        }
        #endregion
        #region -   EventWhnd   -
        private void wizardControlMain_CancelClick(object sender, CancelEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        private void wizardControlMain_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.PrevPage == SelectSPWizardPage)
            {
                if (gridViewSP.SelectedRowsCount == 0)
                {
                    MsgDlg.Show("Please select item to continue", MsgDlg.MessageType.Info);
                    e.Cancel = true;
                    return;
                }
                NICSQLTools.Data.dsDataSource.ROUTINESRow RowSp = (NICSQLTools.Data.dsDataSource.ROUTINESRow)((DataRowView)gridViewSP.GetRow(gridViewSP.FocusedRowHandle)).Row;
                if (RowSp == null)
                {
                    MsgDlg.Show("Please select item to continue", MsgDlg.MessageType.Info);
                    e.Cancel = true;
                    return;
                }
                pARAMETERSTableAdapter.Fill(dsDataSource.PARAMETERS, RowSp.ROUTINE_NAME);
                foreach (NICSQLTools.Data.dsDataSource.PARAMETERSRow rowParam in dsDataSource.PARAMETERS)
                {
                    foreach (char chr in rowParam.PARAMETER_NAME)
                    {
                        if (chr == '@')
                            continue;
                        if (char.IsUpper(chr))
                        {
                            if (rowParam.ParamDisplayName != string.Empty)
                                rowParam.ParamDisplayName += " ";
                            rowParam.ParamDisplayName += chr;
                        }
                        else
                            rowParam.ParamDisplayName += chr;
                    }                 
                }
            }
            else if (e.PrevPage == ParamtersWizardPage)
            {
            }
            else if (e.PrevPage == completionWizardPage)
            {
            }
        }
        private void wizardControlMain_FinishClick(object sender, CancelEventArgs e)
        {
            if (lueType.EditValue == null || lueType.EditValue.ToString() == string.Empty || tbName.EditValue == null || tbName.EditValue.ToString() == string.Empty)
            {
                MsgDlg.Show("Please select data source type and enter a name to continue", MsgDlg.MessageType.Info);
                e.Cancel = true;
                return;
            }
            // inserting
            
            NICSQLTools.Data.dsDataSource.ROUTINESRow RowSp = (NICSQLTools.Data.dsDataSource.ROUTINESRow)((DataRowView)gridViewSP.GetRow(gridViewSP.FocusedRowHandle)).Row;
            byte[] Data = null;
            if (rtb.Text != string.Empty)
                Data = NICSQLTools.Classes.Managers.DataManager.CompressFile(System.Text.Encoding.Unicode.GetBytes(rtb.Rtf)).ToArray();

            int effected_DS = adpDS.Insert(_dSCategoryId, Convert.ToInt32(lueType.EditValue), tbName.EditValue.ToString(), RowSp.ROUTINE_NAME,
                Classes.Managers.UserManager.defaultInstance.User.UserId, Classes.Managers.DataManager.defaultInstance.ServerDateTime, Data);
            if (effected_DS <= 0)
            {
                MsgDlg.Show("Error Found ...", MsgDlg.MessageType.Error);
                e.Cancel = true;
                return;
            }
            int dsId = (int)adpDS.LastId();
            foreach (NICSQLTools.Data.dsDataSource.PARAMETERSRow param in dsDataSource.PARAMETERS)
            {
                int? LookupId = null;
                if (!param.IsNull("LookupID"))
                    LookupId = param.LookupID;

                adpParam.Insert(dsId, param.PARAMETER_NAME, param.ParamDisplayName, LookupId, Classes.Managers.UserManager.defaultInstance.User.UserId, Classes.Managers.DataManager.defaultInstance.ServerDateTime);
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
        #endregion

    }
}