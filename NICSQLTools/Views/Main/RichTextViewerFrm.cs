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
    public partial class RichTextViewerFrm : DevExpress.XtraEditors.XtraForm
    {
        public string TextData
        {
            get { return richEditCommentControlMain.HtmlText; }
            set { richEditCommentControlMain.HtmlText = value; }
        }
        public RichTextViewerFrm(string text)
        {
            InitializeComponent();
            TextData = text;
        }
        private void barButtonItemPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            richEditCommentControlMain.ShowPrintPreview();
        }
        
    }
}