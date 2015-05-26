using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Qry
{
    public partial class ExcelDynamicUpdateUC : DevExpress.XtraEditors.XtraUserControl
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(ExcelDynamicUpdateUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;

        public ExcelDynamicUpdateUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenXlDlg dlg = new OpenXlDlg();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;


        }
    }
}
