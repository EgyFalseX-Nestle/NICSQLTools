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
    public partial class RichTextEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        public string TextData
        {
            get { return richEditControlMain.HtmlText; }
            set { richEditControlMain.HtmlText = value; } 
        }
        public RichTextEditorFrm(string text)
        {
            InitializeComponent();
            TextData = text;
        }
        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TextData = richEditControlMain.HtmlText;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}