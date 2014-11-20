using System;
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
    public partial class Form1 : Form
    {
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new Data.Linq.dsLinqDataDataContext();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            LSMSGeneral.QueryableSource = from q in dsLinq.AppDashboardSchemas select q;
            LSMSSub.QueryableSource = from q in dsLinq.Users select q;
        }

    }
}
