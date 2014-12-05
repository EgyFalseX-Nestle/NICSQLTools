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

namespace NICSQLTools.Views.Main
{
    public partial class ChooseThemeFrm : DevExpress.XtraEditors.XtraForm
    {
        public ChooseThemeFrm()
        {
            InitializeComponent();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(galleryControlMain, true);
        }
    }
}