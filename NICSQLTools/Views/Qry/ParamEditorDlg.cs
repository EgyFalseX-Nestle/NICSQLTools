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

namespace NICSQLTools.Views.Qry
{
    public partial class ParamEditorDlg : DevExpress.XtraEditors.XtraForm
    {
        public ParamEditorDlg(Classes.msExcel.DynamicRefresh.xlDRJob job)
        {
            InitializeComponent();
            job.CreateDatasourceControls(layoutControlMain, layoutControlGroupMain);
        }
        private void ParamEditorDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            //change focus from last edited control so can save its last value
            foreach (DevExpress.XtraLayout.BaseLayoutItem item in layoutControlMain.Items)
            {
                if (item.GetType() == typeof(DevExpress.XtraLayout.LayoutControlItem))
                {
                    DevExpress.XtraLayout.LayoutControlItem lci = (DevExpress.XtraLayout.LayoutControlItem)item;
                    lci.Control.Focus();
                }
            }
        }
    }
}