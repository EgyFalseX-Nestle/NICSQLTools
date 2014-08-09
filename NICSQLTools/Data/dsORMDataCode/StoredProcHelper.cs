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
        public static DevExpress.Xpo.DB.SelectedData Execsp_DistributionV1(Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            return session.ExecuteSproc("sp_DistributionV1", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
        }
        static LoadDataMemberOrderItem[] sp_DistributionV1OrderArray = { new LoadDataMemberOrderItem(3, "APOS14"), new LoadDataMemberOrderItem(4, "APOS13"), new LoadDataMemberOrderItem(5, "TAPOS14"), new LoadDataMemberOrderItem(6, "TAPOS13"), new LoadDataMemberOrderItem(7, "ASM"), new LoadDataMemberOrderItem(8, "Supervisor") };
        public static XPDataView Execsp_DistributionV1IntoDataView(Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_DistributionV1", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
            return new XPDataView(session.Dictionary, session.GetClassInfo(typeof(sp_DistributionV1Result)), sp_DistributionV1OrderArray, sprocData);
        }
        public static void Execsp_DistributionV1IntoDataView(XPDataView dataView, Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_DistributionV1", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
            dataView.LoadData(sprocData);
        }
        public static DevExpress.Xpo.DB.SelectedData Execsp_DistributionV2(Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            return session.ExecuteSproc("sp_DistributionV2", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
        }
        static LoadDataMemberOrderItem[] sp_DistributionV2OrderArray = { new LoadDataMemberOrderItem(2, "APOS14"), new LoadDataMemberOrderItem(3, "APOS13"), new LoadDataMemberOrderItem(4, "TAPOS14"), new LoadDataMemberOrderItem(5, "TAPOS13") };
        public static System.Collections.Generic.ICollection<sp_DistributionV2Result> Execsp_DistributionV2IntoObjects(Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            return session.GetObjectsFromSproc<sp_DistributionV2Result>(sp_DistributionV2OrderArray, "sp_DistributionV2", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
        }
        public static XPDataView Execsp_DistributionV2IntoDataView(Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_DistributionV2", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
            return new XPDataView(session.Dictionary, session.GetClassInfo(typeof(sp_DistributionV2Result)), sp_DistributionV2OrderArray, sprocData);
        }
        public static void Execsp_DistributionV2IntoDataView(XPDataView dataView, Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_DistributionV2", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
            dataView.LoadData(sprocData);
        }
        public static DevExpress.Xpo.DB.SelectedData Execsp_DistributionV3(Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            return session.ExecuteSproc("sp_DistributionV3", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
        }
        static LoadDataMemberOrderItem[] sp_DistributionV3OrderArray = { new LoadDataMemberOrderItem(1, "APOS14"), new LoadDataMemberOrderItem(2, "APOS13"), new LoadDataMemberOrderItem(3, "TAPOS14"), new LoadDataMemberOrderItem(4, "TAPOS13") };
        public static System.Collections.Generic.ICollection<sp_DistributionV3Result> Execsp_DistributionV3IntoObjects(Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            return session.GetObjectsFromSproc<sp_DistributionV3Result>(sp_DistributionV3OrderArray, "sp_DistributionV3", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
        }
        public static XPDataView Execsp_DistributionV3IntoDataView(Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_DistributionV3", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
            return new XPDataView(session.Dictionary, session.GetClassInfo(typeof(sp_DistributionV3Result)), sp_DistributionV3OrderArray, sprocData);
        }
        public static void Execsp_DistributionV3IntoDataView(XPDataView dataView, Session session, DateTime DateStart, DateTime DateEnd, string SalesDistrict2, string SalesDistrictName)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("sp_DistributionV3", new OperandValue(DateStart), new OperandValue(DateEnd), new OperandValue(SalesDistrict2), new OperandValue(SalesDistrictName));
            dataView.LoadData(sprocData);
        }
    }
}
