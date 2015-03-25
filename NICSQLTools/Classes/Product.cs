using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Product
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Product));
        public static string DefaultMaterialName
        {
            get { return "Auto Generate Material"; }
        }
        public static int UnknownProductBaseId
        {
            get { return 99999999; }
        }
        public static short UnknownMaterialTypeId
        {
            get { return 9999; }
        }
        public static short UnknownPriceChangesId
        {
            get { return 9999; }
        }
        public static short UnknownPricePointRangId
        {
            get { return 9999; }
        }
        public static short UnknownFlavorId
        {
            get { return 9999; }
        }
        public static short UnknownNPDSId
        {
            get { return 9999; }
        }
        public static short UnknownBrandId
        {
            get { return 9999; }
        }

        public static void CreateDefaultProduct(ref Data.dsData._0_4__Product_DetailsRow row)
        {
            row.Material_Name = DefaultMaterialName;
            row.Quin = 1;
            row.New_Qu = 1;
            row.Volum_Pice = 1;
            row.Vol = 1;
            row.Volum = 1;
        }
        public static Data.dsData._0_4__Product_DetailsRow GetProductRow(double MaterialNumber, Data.dsData._0_4__Product_DetailsDataTable tbl)
        {
            for (int i = 0; i < tbl.Count; i++)
            {
                if (tbl[i].Material_Number == MaterialNumber)
                    return tbl[i];
            }
            Data.dsData._0_4__Product_DetailsRow row = tbl.New_0_4__Product_DetailsRow();
            Product.CreateDefaultProduct(ref row);
            return row;
        }
        public static void RepairActiveCase()
        {
            throw new NotImplementedException("i should add here a sql statment to give every base product an active case product");
        }
        public static bool UpdateProductPricePoint(SqlCommand cmd, Data.dsData.TMP_UpdateProductPricePointDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            cmd.CommandText = @"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TMP_UpdateProductPricePoint]') AND type in (N'U'))
            DROP TABLE [dbo].[TMP_UpdateProductPricePoint]
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TMP_UpdateProductPricePoint]') AND type in (N'U'))
            BEGIN
            CREATE TABLE [dbo].[TMP_UpdateProductPricePoint](
	            [Material] [int] NOT NULL,
	            [Amount] [float] NULL,
	            [UoM] [nvarchar](50) NULL,
	            [Valid From] [datetime] NULL,
            PRIMARY KEY CLUSTERED 
            (
	            [Material] ASC
            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
            ) ON [PRIMARY]
            END";
            cmd.ExecuteNonQuery();// DROP when create tmp table
            const string BulkTableName = "TMP_UpdateProductPricePoint";
            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Material", "Material"); bulkCopy.ColumnMappings.Add("Amount", "Amount");
                bulkCopy.ColumnMappings.Add("Valid From", "Valid From");//bulkCopy.ColumnMappings.Add("UoM", "UoM");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"merge into dbo.[0-4  Product Details] as Target 
                using {0} as Source on Target.[Material Number] = Source.Material when matched then 
                update set 
                Target.[Trade_Price_SAP] = Source.[Amount],
                Target.[Valid Year] = Year(Source.[Valid From]),
                Target.[Valid Month] = Month(Source.[Valid From]);", BulkTableName);
                cmd.ExecuteNonQuery();
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                cmd.ExecuteNonQuery();
                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MessageBox.Show("Error while trying to save Product Bulk - " + ex.Message);
            }
            return outPut;
        }


    }
}
