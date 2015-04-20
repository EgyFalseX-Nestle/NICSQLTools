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
            checkedComboBoxEdit1.Properties.Items.Add("item1");
            checkedComboBoxEdit1.Properties.Items.Add("item2");
            checkedComboBoxEdit1.Properties.Items.Add("item3");
            checkedComboBoxEdit1.Properties.Items.Add("item4");
            checkedComboBoxEdit1.Properties.Items.Add("item5");

            
            //NICSQLTools.Data.Linq.dsLinqDataDataContext ds = new Data.Linq.dsLinqDataDataContext();
            //lsms.QueryableSource = from q in ds.vAppProductDetails select q;
            //////////////////////

            //checkedComboBoxEdit1.Properties.DataSource = lsms;
            //checkedComboBoxEdit1.Properties.DisplayMember = "Material Number";
            //checkedComboBoxEdit1.Properties.ValueMember = "Material Number";

            //checkedComboBoxEdit1.Properties.AllowMultiSelect = true;
            //checkedComboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            //checkedComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            
            //checkedComboBoxEdit1

            //this.checkedComboBoxEdit1.EditValue = "";
            //this.checkedComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //unitOfWork1.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
            //gridControl1.DataSource = xpServerCollectionSource1;
            //gridView1.PopulateColumns();
        }

        private void TestFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            checkedComboBoxEdit1.RefreshEditValue();
        }

        private void checkedComboBoxEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            MessageBox.Show("changing");
            
        }

    }
}