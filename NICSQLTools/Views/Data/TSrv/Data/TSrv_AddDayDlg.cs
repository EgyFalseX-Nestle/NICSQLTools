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

namespace NICSQLTools.Views.Data.TSrv.Data
{
    public partial class TSrv_AddDayDlg : DevExpress.XtraEditors.XtraForm
    {
        private NICSQLTools.Data.dsTSrvTableAdapters.QueriesTableAdapter adpQ;
        public DateTime From { get; private set; }
        public DateTime To { get; private set; }

        public TSrv_AddDayDlg()
        {
            InitializeComponent();
            //Prepare Adapter
            adpQ = new NICSQLTools.Data.dsTSrvTableAdapters.QueriesTableAdapter();
            Classes.Managers.DataManager.SetAllCommandTimeouts(adpQ, Classes.Managers.DataManager.ConnectionTimeout);
            //Prepare form times
            DateTime serverDateTime = Classes.Managers.DataManager.defaultInstance.ServerDateTime;
            deTo.EditValue = serverDateTime;
            deFrom.EditValue = serverDateTime.Subtract(new TimeSpan(1, 0, 0, 0));

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            int insertResult = 0;
            int toExists = Convert.ToInt32(adpQ.CheckDateExists(deTo.DateTime));
            if (toExists != 0)
            {
                MsgDlg.Show("This day already exists", MsgDlg.MessageType.Error);
                return;
            }
            if (deFrom.EditValue != null)// Import
            {
                int fromExists = Convert.ToInt32(adpQ.CheckDateExists(deFrom.DateTime.Date));
                if (fromExists == 0)
                {
                    MsgDlg.Show("You can't import from day that doesn't exists", MsgDlg.MessageType.Error);
                    return;
                }
                insertResult =
                    adpQ.Insert_TSrv_TruckService_Import(deTo.DateTime.Date, Classes.Managers.UserManager.defaultInstance.User.UserId,
                        deFrom.DateTime.Date);
                From = deFrom.DateTime.Date;
            }
            else// No Import
            {
                insertResult = adpQ.Insert_TSrv_TruckService_NoImport(deTo.DateTime.Date,
                    Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            
            MsgDlg.ShowAlert(insertResult + " Recored Saved ...", MsgDlg.MessageType.Success, this);
            To = deTo.DateTime.Date;
            DialogResult = DialogResult.OK;
            
        }
    }
}