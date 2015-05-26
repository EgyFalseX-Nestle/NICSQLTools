using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools.Classes.msExcel.DynamicRefresh
{
    public class DatasourceBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SP_Name { get; set; }
        public List<ParamBase> Params { get; set; }
        
    }
}
