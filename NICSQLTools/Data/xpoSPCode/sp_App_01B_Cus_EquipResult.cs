//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace NICSQLTools.Data.IC_DB
{

    [NonPersistent]
    public partial class sp_App_01B_Cus_EquipResult
    {
        public string Equipment { get; set; }
        public string SerialNumber { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string FuncLoc { get; set; }
        public DateTime ValidFrom { get; set; }
        public string Inventorynumber { get; set; }
        public short ConstructYear { get; set; }
        public short YearNum { get; set; }
        public short MonthNum { get; set; }
        public double Cartons { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
    }

}