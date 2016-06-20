using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NICSQLTools.Views.XRep.MSrv
{

    public partial class XRep01 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep01()
        {
            InitializeComponent();
            xRep01_ATableAdapter.Fill(dsMSrc1.XRep01_A, Classes.Managers.UserManager.defaultInstance.User.UserId);
            xrlUser.Text = Classes.Managers.UserManager.defaultInstance.User.RealName;
            DateTime dt = Classes.Managers.DataManager.defaultInstance.ServerDateTime;
            xrlDate.Text = dt.ToLongDateString();
            Parameters["paramStartDate"].Value = dt;
            Parameters["paramEndDate"].Value = dt;
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (e.ParametersInformation[0].Parameter.Value == null || e.ParametersInformation[1].Parameter.Value == null || e.ParametersInformation[2].Parameter.Value == null)
            {
                return;
            }
            DateTime start = (DateTime)e.ParametersInformation[0].Parameter.Value;
            DateTime end = (DateTime)e.ParametersInformation[1].Parameter.Value;
            string SV = e.ParametersInformation[2].Parameter.Value.ToString();

            xrlSuperviros.Text = e.ParametersInformation[2].Parameter.Value.ToString();
            xRep01TableAdapter.Fill(dsMSrc1.XRep01, start, end, SV);
        }

    }
}
