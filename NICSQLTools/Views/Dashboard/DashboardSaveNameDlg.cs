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

namespace NICSQLTools.Views.Dashboard
{
    public partial class DashboardSaveNameDlg : DevExpress.XtraEditors.XtraForm
    {
        public string SavingName = string.Empty;
        public DashboardSaveNameDlg()
        {
            InitializeComponent();
        }
        public DashboardSaveNameDlg(string ExistingName)
        {
            InitializeComponent();

            SavingName = ExistingName;
            tbName.EditValue = SavingName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(tbName.EditValue))
                return;
            SavingName = tbName.EditValue.ToString();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}