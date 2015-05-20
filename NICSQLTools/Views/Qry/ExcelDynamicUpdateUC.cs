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
        public ExcelDynamicUpdateUC()
        {
            InitializeComponent();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

        }
    }
}
