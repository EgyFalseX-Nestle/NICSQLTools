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

namespace NICSQLTools
{
    public partial class TestFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public TestFrm()
        {
            InitializeComponent();

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("BirthDate", typeof(DateTime));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Salary", typeof(float));

            DataRow row1 = dt.NewRow();
            row1["Name"] = "Hassan";
            row1["Address"] = "57 ahmed";
            row1["BirthDate"] = new DateTime(2000, 5, 7);
            row1["Age"] = 17;
            row1["Salary"] = 1500;
            dt.Rows.Add(row1);

            DataRow row2 = dt.NewRow();
            row2["Name"] = "ahmed";
            row2["Address"] = "99 ahmed";
            row2["BirthDate"] = new DateTime(2005, 6, 8);
            row2["Age"] = 22;
            row2["Salary"] = 2000;
            dt.Rows.Add(row2);


        }

        private void TestFrm_Load(object sender, EventArgs e)
        {
            pivotGridControl1.DataSource = dt;
            pivotGridControl1.RetrieveFields();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Classes.msExcel.CreatePivotByRecordSet(pivotGridControl1, "New Data Sheet", @"C:\111.xlsx");
            MessageBox.Show("Done ...");
        }

    }
}