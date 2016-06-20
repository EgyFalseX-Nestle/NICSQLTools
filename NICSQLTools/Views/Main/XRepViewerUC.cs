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

namespace NICSQLTools.Views.Main
{
    public partial class XRepViewerUC : DevExpress.XtraEditors.XtraUserControl
    {
        public XRepViewerUC(DevExpress.XtraReports.UI.XtraReport rep)
        {
            InitializeComponent();
            documentViewer.DocumentSource = rep;
        }
    }
}
