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
        
        public TestFrm()
        {
            InitializeComponent();
            xpServerCollectionSource1.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
        }

        private void TestFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTask.TskEmp_EmpTask' table. You can move, or remove it, as needed.
            this.tskEmp_EmpTaskTableAdapter.Fill(this.dsTask.TskEmp_EmpTask);
            
            //gridControl1.DataSource = xpServerCollectionSource1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        
        }

        private void checkedComboBoxEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            MessageBox.Show("changing");
        }

        private void gridControlMain_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {

        }

        

    }
}