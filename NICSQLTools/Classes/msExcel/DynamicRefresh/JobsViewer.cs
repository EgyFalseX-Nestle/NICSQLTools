using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools.Classes.msExcel.DynamicRefresh
{
    public class JobsViewer
    {
        public bool Select { get; set; }
        public string ConnectionName { get; set; }
        public string DatasourceName { get; set; }
        public xlDRJob Job { get; set; }
    }
}
