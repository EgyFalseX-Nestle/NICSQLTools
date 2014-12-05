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

namespace NICSQLTools.Views.Main
{
    public partial class ChooseSaveNameDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(ChooseSaveNameDlg));
        public string SavingName = string.Empty;
        public ChooseSaveNameDlg()
        {
            InitializeComponent();
        }
        public ChooseSaveNameDlg(string ExistingName)
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