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

namespace NICSQLTools
{
    public partial class TestFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public TestFrm()
        {
            InitializeComponent();
        }

        private void TestFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMSrc.MSrv_Part' table. You can move, or remove it, as needed.
            //this.mSrv_PartTableAdapter.Fill(this.dsMSrc.MSrv_Part);
            //LSMSRoute.QueryableSource = new Data.Linq.dsLinqDataDataContext().vRouteDetails;
            new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_PartTableAdapter().Fill(
                Classes.MSrvOfflineData.DsMSrv.MSrv_Part);
            searchLookUpEdit1.Properties.DataSource = Classes.MSrvOfflineData.DsMSrv.MSrv_Part;
            searchLookUpEdit1.Properties.DisplayMember = "PartName";
            searchLookUpEdit1.Properties.ValueMember = "PartId";
            
        }
    }
}