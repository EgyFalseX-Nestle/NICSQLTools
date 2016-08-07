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

namespace NICSQLTools.Views.Data.MSrv
{
    public partial class MSrvOfflineModeDlg : DevExpress.XtraEditors.XtraForm
    {
        public MSrvOfflineModeDlg()
        {
            InitializeComponent();
        }

        private Task LoadDataAsync()
        {
            return Task.Run(() =>
            {
                Invoke(new MethodInvoker(() => {
                    pbc.Properties.Maximum = 6;
                    pbc.EditValue = 0;
                }));

                if (Classes.MSrvOfflineData.DsMSrv.MSrv_Type.Count == 0)
                {
                    new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TypeTableAdapter().FillByMSrv_TypeConditionId(
                        Classes.MSrvOfflineData.DsMSrv.MSrv_Type, (int)Classes.MSrvType.TypeCondition.Open_Ticket);
                }
                Invoke(new MethodInvoker(() => {
                    pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                    Application.DoEvents();
                }));

                if (Classes.MSrvOfflineData.DsMSrv.vMSrv_Ticket_ByUser.Count == 0)
                {
                    new NICSQLTools.Data.dsMSrcTableAdapters.vMSrv_Ticket_ByUserTableAdapter().FillByUser_Dep_Close(
                    Classes.MSrvOfflineData.DsMSrv.vMSrv_Ticket_ByUser
                    , Classes.Managers.UserManager.defaultInstance.User.UserId
                    , false
                    , (short)Classes.Managers.UserManager.defaultInstance.User.MSrvDepartmentId);
                }
                Invoke(new MethodInvoker(() => {
                    pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                    Application.DoEvents();
                }));

                if (Classes.MSrvOfflineData.DsMSrv.vMSrv_Technician_ByUser.Count == 0)
                {
                    new NICSQLTools.Data.dsMSrcTableAdapters.vMSrv_Technician_ByUserTableAdapter().FillByUserId(
                    Classes.MSrvOfflineData.DsMSrv.vMSrv_Technician_ByUser,
                    Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
                Invoke(new MethodInvoker(() => {
                    pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                    Application.DoEvents();
                }));

                if (Classes.MSrvOfflineData.DsMSrv.MSrv_Part.Count == 0)
                {
                    new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_PartTableAdapter().Fill(
                    Classes.MSrvOfflineData.DsMSrv.MSrv_Part);
                }
                Invoke(new MethodInvoker(() => {
                    pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                    Application.DoEvents();
                }));

                if (Classes.MSrvOfflineData.DsMSrv.MSrv_Dmg_Reason.Count == 0)
                {
                    new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_Dmg_ReasonTableAdapter().Fill(
                    Classes.MSrvOfflineData.DsMSrv.MSrv_Dmg_Reason);
                }
                Invoke(new MethodInvoker(() => {
                    pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                    Application.DoEvents();
                }));

                if (Classes.MSrvOfflineData.MSrvTypeClosing.Count == 0)
                {
                    new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TypeTableAdapter().FillByMSrv_TypeConditionId(
                        Classes.MSrvOfflineData.MSrvTypeClosing, (int)Classes.MSrvType.TypeCondition.Close_Ticket);
                }
                Invoke(new MethodInvoker(() => {
                    pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                    Application.DoEvents();
                }));

            });
        }

        private async void MSrvOfflineModeDlg_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            Close();
        }
    }
}