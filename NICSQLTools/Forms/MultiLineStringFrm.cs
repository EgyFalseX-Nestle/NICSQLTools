using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Forms
{
    public partial class MultiLineStringFrm : DevExpress.XtraEditors.XtraForm
    {
        public List<string> Lines = new List<string>();
        public MultiLineStringFrm()
        {
            InitializeComponent();
        }

        private void txt_EditValueChanged(object sender, EventArgs e)
        {
            lblLineCount.Text = txt.Properties.LinesCount.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Lines.AddRange(txt.Lines);// Add To List
            for (int i = 0; i < Lines.Count; i++)// Delete Spaces
                Lines[i] = Lines[i].Trim();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

    }
}