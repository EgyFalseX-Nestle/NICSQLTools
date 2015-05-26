using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools.Classes.msExcel.DynamicRefresh
{
    public class ParamBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ParamValue { get; set; }
        public int? Lookup { get; set; }
        public System.Windows.Forms.Control ctr { get; set; }
    }
}
