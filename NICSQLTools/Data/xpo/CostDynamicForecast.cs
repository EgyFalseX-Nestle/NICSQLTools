using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System.ComponentModel;

namespace NICSQLTools.Data.xpo
{
    [Persistent("CostDynamicForecast"), OptimisticLocking(true)]
    public class CostDynamicForecast : XPBaseObject {
        public CostDynamicForecast(Session session) : base(session) { }
        public CostDynamicForecast(Session session, XPClassInfo classInfo) : base(session, classInfo) { }

        private DFKey fID;
        [Key, Persistent, Browsable(false)]
        public DFKey ID {
            get { return fID; }
            set { SetPropertyValue<DFKey>("ID", ref fID, value); }
        }
        [Persistent("DF")]
        public float DF;
        [Persistent("Type")]
        public string Type;
        [Persistent("UserIn")]
        public int UserIn;
        [Persistent("DateIn")]
        public System.DateTime DateIn;
    }

    public struct DFKey {
        [Persistent("Costcenter")]
        public string Costcenter {get; set;}
        [Persistent("GLAccount")]
        public string GLAccount { get; set; }
        [Persistent("Year")]
        public int Year { get; set; }
        [Persistent("BusinessUnit")]
        public string BusinessUnit { get; set; }
        [Persistent("Period")]
        public int Period { get; set; }
    }
}