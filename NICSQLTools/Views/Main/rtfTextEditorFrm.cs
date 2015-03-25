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
    public partial class rtfTextEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        public string TextData
        {
            get { return rtb.Rtf; }
            set
            {
                try
                {
                    rtb.Rtf = value;
                }
                catch 
                {
                    rtb.Rtf = string.Empty;
                }
            } 
        }
        public rtfTextEditorFrm(string text)
        {
            InitializeComponent();
            TextData = text;
        }
        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TextData = rtb.Rtf;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void barButtonItemOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ofdRTF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtb.LoadFile(ofdRTF.FileName);
            }
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