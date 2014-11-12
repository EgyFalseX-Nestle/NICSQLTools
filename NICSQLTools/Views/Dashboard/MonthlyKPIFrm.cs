using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace NICSQLTools.Views.Dashboard
{
    public partial class ChartControlFrm : DevExpress.DashboardCommon.Dashboard
    {
        public ChartControlFrm()
        {
            InitializeComponent();
            //chartDashboardItemMain.DataSource.
            
            NICSQLTools.Data.dsSPTableAdapters.sp_DashboardV01TableAdapter adp = new NICSQLTools.Data.dsSPTableAdapters.sp_DashboardV01TableAdapter();
            DataManager.SetAllCommandTimeouts(adp, DataManager.ConnectionTimeout);

            DateTime dtStart = new DateTime(2014, 1, 1);
            DateTime dtEnd = new DateTime(2014, 2, 28);
            
            adp.Fill(dsSP1.sp_DashboardV01, dtStart, dtEnd, "");

            
            
        }
    }
}
