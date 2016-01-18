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

namespace NICSQLTools.Views.Data.MSrv
{
    public partial class SelectEquipmentDlg : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        public string _serialNumber = string.Empty;
        #endregion
        #region - Fun -
        public SelectEquipmentDlg(string Customer)
        {
            InitializeComponent();
            LSMSEquipment.QueryableSource = from q in dsLinq.vMSrv_Equipments where q.Func_Loc == Customer select q;
        }
        bool SetSelected()
        {
            int[] Inxs = gridViewMain.GetSelectedRows();
            if (Inxs == null || Inxs.Length == 0)
                return false;
            NICSQLTools.Data.Linq.vMSrv_Equipment row = (NICSQLTools.Data.Linq.vMSrv_Equipment)gridViewMain.GetRow(Inxs[0]);
            _serialNumber = row.Serial_Number;
            return true;
        }
        #endregion
        #region -  EventWhnd -
        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            if (SetSelected())
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (SetSelected())
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        #endregion
       
    }
}