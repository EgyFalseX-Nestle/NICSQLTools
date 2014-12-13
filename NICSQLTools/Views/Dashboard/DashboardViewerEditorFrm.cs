using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Dashboard
{
    public partial class DashboardViewerEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        
        public DashboardViewerEditorFrm(DevExpress.DashboardCommon.Dashboard db)
        {
            InitializeComponent();
            dashboardDesignerMain.Dashboard = db;
            
        }
    }
}