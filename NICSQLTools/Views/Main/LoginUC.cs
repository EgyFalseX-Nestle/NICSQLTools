﻿using System;
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
    public partial class LoginUC : DevExpress.XtraEditors.XtraUserControl
    {
        
        public LoginUC()
        {
            InitializeComponent();
        }
        private void LoginUI_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm _parent = (MainForm)this.ParentForm;
            _parent.windowsUIView.ActivateContainer(_parent.tileContainerMain);

        }
        
    }
}
