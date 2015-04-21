using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Main
{
    public partial class rtfTextViewerFrm : DevExpress.XtraEditors.XtraForm
    {
        public string TextData
        {
            get { return rtb.Rtf; }
            set {
                try { rtb.Rtf = value; }
                catch { }
            }
 
        }
        public rtfTextViewerFrm(string text)
        {
            InitializeComponent();
            TextData = text;
        }
        private void barButtonItemExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtb.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
            }
        }
    }
}