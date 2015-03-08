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

            NICSQLTools.Data.Linq.dsLinqDataDataContext ds = new Data.Linq.dsLinqDataDataContext();
            lsms.QueryableSource = from q in ds.vAppProductDetails select q;


            //checkedComboBoxEdit1.Properties.DataSource = lsms;
            //checkedComboBoxEdit1.Properties.DisplayMember = "Material Number";
            //checkedComboBoxEdit1.Properties.ValueMember = "Material Number";

            //checkedComboBoxEdit1.Properties.AllowMultiSelect = true;
            //checkedComboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            //checkedComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            
            //checkedComboBoxEdit1

            //this.checkedComboBoxEdit1.EditValue = "";
            //this.checkedComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            
        }

    }
}