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
    public static class SprocHelper
    {
        public static DevExpress.Xpo.DB.SelectedData Execsp_App_01A_Cus_Sal(Session session, string Customers)
        {
            return session.ExecuteSproc("sp_App_01A_Cus_Sal", new OperandValue(Customers));
        }
        public static System.Collections.Generic.ICollection<sp_App_01A_Cus_SalResult> Execsp_App_01A_Cus_SalIntoObjects(Session session, string Customers)
        {
            return session.GetObjectsFromSproc<sp_App_01A_Cus_SalResult>("sp_App_01A_Cus_Sal", new OperandValue(Customers));
        }
        public static XPDataView Execsp_App_01A_Cus_SalIntoDataView(Session session, string Customers)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_App_01A_Cus_Sal", new OperandValue(Customers));
            return new XPDataView(session.Dictionary, session.GetClassInfo(typeof(sp_App_01A_Cus_SalResult)), sprocData);
        }
        public static void Execsp_App_01A_Cus_SalIntoDataView(XPDataView dataView, Session session, string Customers)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_App_01A_Cus_Sal", new OperandValue(Customers));
            dataView.PopulateProperties(session.GetClassInfo(typeof(sp_App_01A_Cus_SalResult)));
            dataView.LoadData(sprocData);
        }
        public static DevExpress.Xpo.DB.SelectedData Execsp_App_01B_Cus_Equip(Session session, string Customers)
        {
            return session.ExecuteSproc("sp_App_01B_Cus_Equip", new OperandValue(Customers));
        }
        public static System.Collections.Generic.ICollection<sp_App_01B_Cus_EquipResult> Execsp_App_01B_Cus_EquipIntoObjects(Session session, string Customers)
        {
            return session.GetObjectsFromSproc<sp_App_01B_Cus_EquipResult>("sp_App_01B_Cus_Equip", new OperandValue(Customers));
        }
        public static XPDataView Execsp_App_01B_Cus_EquipIntoDataView(Session session, string Customers)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_App_01B_Cus_Equip", new OperandValue(Customers));
            return new XPDataView(session.Dictionary, session.GetClassInfo(typeof(sp_App_01B_Cus_EquipResult)), sprocData);
        }
        public static void Execsp_App_01B_Cus_EquipIntoDataView(XPDataView dataView, Session session, string Customers)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_App_01B_Cus_Equip", new OperandValue(Customers));
            dataView.PopulateProperties(session.GetClassInfo(typeof(sp_App_01B_Cus_EquipResult)));
            dataView.LoadData(sprocData);
        }
        public static DevExpress.Xpo.DB.SelectedData Execsp_App_01C_Cus_Route(Session session, string Customers)
        {
            return session.ExecuteSproc("sp_App_01C_Cus_Route", new OperandValue(Customers));
        }
        public static System.Collections.Generic.ICollection<sp_App_01C_Cus_RouteResult> Execsp_App_01C_Cus_RouteIntoObjects(Session session, string Customers)
        {
            return session.GetObjectsFromSproc<sp_App_01C_Cus_RouteResult>("sp_App_01C_Cus_Route", new OperandValue(Customers));
        }
        public static XPDataView Execsp_App_01C_Cus_RouteIntoDataView(Session session, string Customers)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_App_01C_Cus_Route", new OperandValue(Customers));
            return new XPDataView(session.Dictionary, session.GetClassInfo(typeof(sp_App_01C_Cus_RouteResult)), sprocData);
        }
        public static void Execsp_App_01C_Cus_RouteIntoDataView(XPDataView dataView, Session session, string Customers)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_App_01C_Cus_Route", new OperandValue(Customers));
            dataView.PopulateProperties(session.GetClassInfo(typeof(sp_App_01C_Cus_RouteResult)));
            dataView.LoadData(sprocData);
        }
    }
}
