﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NICSQLTools
{
    public partial class TestFrm : Form
    {
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new Data.Linq.dsLinqDataDataContext(){ ObjectTrackingEnabled = false};
        NICSQLTools.Data.dsQry ds = new Data.dsQry();
        public TestFrm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(galleryControl1, true);
            //DevExpress.XtraBars.Helpers.SkinHelper.InitSkinPopupMenu(popupMenu1);

        }

    
      


    }
}
