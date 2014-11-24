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
    public partial class TestFrm : Form
    {
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new Data.Linq.dsLinqDataDataContext();
        public TestFrm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
        

    }
}
