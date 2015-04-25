using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace NICSQLTools.Classes
{
    public static class msExcel
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(msExcel));
        readonly static object useDefault = Type.Missing;

        #region ExportExcelPivot
        static public ADODB.Recordset ConvertToRecordset(System.Data.DataTable inTable)
        {
            ADODB.Recordset result = new ADODB.Recordset();
            result.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

            ADODB.Fields resultFields = result.Fields;
            System.Data.DataColumnCollection inColumns = inTable.Columns;

            foreach (System.Data.DataColumn inColumn in inColumns)
            {
                resultFields.Append(inColumn.ColumnName
                    , TranslateType(inColumn.DataType)
                    , inColumn.MaxLength
                    , inColumn.AllowDBNull ? ADODB.FieldAttributeEnum.adFldIsNullable : ADODB.FieldAttributeEnum.adFldUnspecified
                    , null);
            }

            result.Open(System.Reflection.Missing.Value
                    , System.Reflection.Missing.Value
                    , ADODB.CursorTypeEnum.adOpenStatic
                    , ADODB.LockTypeEnum.adLockOptimistic, 0);

            foreach (System.Data.DataRow dr in inTable.Rows)
            {
                result.AddNew(System.Reflection.Missing.Value,
                              System.Reflection.Missing.Value);

                for (int columnIndex = 0; columnIndex < inColumns.Count; columnIndex++)
                {
                    resultFields[columnIndex].Value = dr[columnIndex];
                }
            }

            return result;
        }
        static ADODB.DataTypeEnum TranslateType(Type columnType)
        {
            switch (columnType.UnderlyingSystemType.ToString())
            {
                case "System.Boolean":
                    return ADODB.DataTypeEnum.adBoolean;

                case "System.Byte":
                    return ADODB.DataTypeEnum.adUnsignedTinyInt;

                case "System.Char":
                    return ADODB.DataTypeEnum.adChar;

                case "System.DateTime":
                    return ADODB.DataTypeEnum.adDate;

                case "System.Decimal":
                    return ADODB.DataTypeEnum.adCurrency;

                case "System.Double":
                    return ADODB.DataTypeEnum.adDouble;

                case "System.Int16":
                    return ADODB.DataTypeEnum.adSmallInt;

                case "System.Int32":
                    return ADODB.DataTypeEnum.adInteger;

                case "System.Int64":
                    return ADODB.DataTypeEnum.adBigInt;

                case "System.SByte":
                    return ADODB.DataTypeEnum.adTinyInt;

                case "System.Single":
                    return ADODB.DataTypeEnum.adSingle;

                case "System.UInt16":
                    return ADODB.DataTypeEnum.adUnsignedSmallInt;

                case "System.UInt32":
                    return ADODB.DataTypeEnum.adUnsignedInt;

                case "System.UInt64":
                    return ADODB.DataTypeEnum.adUnsignedBigInt;

                case "System.String":
                default:
                    return ADODB.DataTypeEnum.adVarChar;
            }
        }
        static void DataTableToRange(Range anchorCell, System.Data.DataTable tableToCopy, string tableHeader = "")
        {
            if (tableHeader != "")
            {
                anchorCell.Value = tableHeader;
                anchorCell = anchorCell.Offset[1, 0];
                int tableHeaderOffet = 0;

                foreach (System.Data.DataColumn loopHeaders in tableToCopy.Columns)
                {
                    anchorCell.Offset[0, tableHeaderOffet].Value = loopHeaders.ColumnName;
                    tableHeaderOffet += 1;
                }
                anchorCell.Offset[1, 0].CopyFromRecordset(ConvertToRecordset(tableToCopy));
            }
        }
        /// <summary>
        /// Helper method to set a value on a single cell.
        /// </summary>
        static void SetCellValue(Worksheet targetSheet, string cell, object value)
        {
            targetSheet.get_Range(cell, useDefault).set_Value(XlRangeValueDataType.xlRangeValueDefault, value);
        }
        public static void CreatePivot(DevExpress.XtraPivotGrid.PivotGridControl pivotControl, string workSheetName, string workBookPath)
        {
            Application excelApplication = null;
            Workbook excelWorkBook = null;
            Worksheet targetSheet = null;
            //PivotTable pivotTable = null;
            //Range pivotData = null;
            Range pivotDestination = null;
            //PivotField salesRegion = null;
            //PivotField salesAmount = null;

            // Declare helper variables.
            //string workBookPath = @"C:\pivottablesample.xlsx";
            //string workSheetName = @"Quarterly Sales";
            const string pivotTableName = @"[NICSQLTools] by Mohamed Aly Omar";
            try
            {
                // Create an instance of Excel.
                excelApplication = new Application();
                //Create a workbook and add a worksheet.
                excelWorkBook = excelApplication.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                targetSheet = (Worksheet)(excelWorkBook.Worksheets[1]);
                if (workSheetName.Length > 30)
                    targetSheet.Name = workSheetName.Substring(0, 30);
                else
                    targetSheet.Name = workSheetName;
                // Create PivCache for the Pivot Table.
                PivotCache xlPc = excelWorkBook.PivotCaches().Add(XlPivotTableSourceType.xlExternal, useDefault);
                //inject PivCache's Recordset with data
                xlPc.Recordset = ConvertToRecordset((System.Data.DataTable)pivotControl.DataSource);
                // Select location of the Pivot Table.
                pivotDestination = targetSheet.get_Range("A1", useDefault);
                //Create Pivot Table
                PivotTable xlPivot = xlPc.CreatePivotTable(pivotDestination, pivotTableName);

                // Format the Pivot Table.
                //xlPivot.Format(XlPivotFormatType.xlPTClassic);
                //xlPivot.InGridDropZones = false;
                xlPivot.SmallGrid = false;
                xlPivot.ShowTableStyleRowStripes = true;
                xlPivot.TableStyle2 = "PivotStyleLight1";
 


                // Save the Workbook.
                excelWorkBook.SaveAs(workBookPath, useDefault, useDefault, useDefault, useDefault, useDefault,
                    XlSaveAsAccessMode.xlNoChange, useDefault, useDefault, useDefault, useDefault, useDefault);

                //for (int i = 0; i < pivotControl.Fields.Count; i++)
                //{
                //    DevExpress.XtraPivotGrid.PivotGridField xField = pivotControl.Fields[i];
                //    PivotField xlField = ((PivotField)xlPivot.PivotFields(i + 1));


                //    PivotField pageField = (PivotField)xlPivot.PivotFields("Route Name");
                //    pageField.Orientation = XlPivotFieldOrientation.xlRowField;

                //    //xlField.Name = xField.Caption;
                //    //Set Unbound Calculation
                    

                //    switch (xField.Area)
                //    {
                //        case DevExpress.XtraPivotGrid.PivotArea.ColumnArea:
                //            xlField.Orientation = XlPivotFieldOrientation.xlColumnField;
                //            break;
                //        case DevExpress.XtraPivotGrid.PivotArea.DataArea:
                //            xlField.Orientation = XlPivotFieldOrientation.xlDataField;
                //            //xfield.SummaryType
                //            switch (xField.SummaryType)
                //            {
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.Average:
                //                    xlField.Function = XlConsolidationFunction.xlAverage;
                //                    break;
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.Count:
                //                    xlField.Function = XlConsolidationFunction.xlCount;
                //                    break;
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.Custom:
                //                    xlField.Function = XlConsolidationFunction.xlUnknown;
                //                    break;
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.Max:
                //                    xlField.Function = XlConsolidationFunction.xlMax;
                //                    break;
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.Min:
                //                    xlField.Function = XlConsolidationFunction.xlMin;
                //                    break;
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.StdDev:
                //                    xlField.Function = XlConsolidationFunction.xlStDev;
                //                    break;
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.StdDevp:
                //                    xlField.Function = XlConsolidationFunction.xlStDevP;
                //                    break;
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.Sum:
                //                    xlField.Function = XlConsolidationFunction.xlSum;
                //                    break;
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.Var:
                //                    xlField.Function = XlConsolidationFunction.xlVar;
                //                    break;
                //                case DevExpress.Data.PivotGrid.PivotSummaryType.Varp:
                //                    xlField.Function = XlConsolidationFunction.xlVarP;
                //                    break;
                //                default:
                //                    break;
                //            }
                //            break;
                //        case DevExpress.XtraPivotGrid.PivotArea.FilterArea:
                //            xlField.Orientation = XlPivotFieldOrientation.xlPageField;
                //            break;
                //        case DevExpress.XtraPivotGrid.PivotArea.RowArea:
                //            xlField.Orientation = XlPivotFieldOrientation.xlRowField;
                //            break;
                //        default:
                //            break;
                //    }
                //    //Set Filtering
                //    //xlField.PivotFilters.Add2()
                //}
                
                //// Save the Workbook.
                //excelWorkBook.SaveAs(workBookPath, useDefault, useDefault, useDefault, useDefault, useDefault,
                //    XlSaveAsAccessMode.xlNoChange, useDefault, useDefault, useDefault, useDefault, useDefault);
            }
            catch (Exception ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MsgDlg.Show(ex.Message, System.Windows.Forms.MsgDlg.MessageType.Error, ex);
            }
            finally
            {
                // Release the references to the Excel objects.
                //salesAmount = null;
                //salesRegion = null;
                pivotDestination = null;
                //pivotData = null;
                //pivotTable = null;
                targetSheet = null;
                // Release the Workbook object.
                if (excelWorkBook != null)
                    excelWorkBook = null;
                // Release the ApplicationClass object.
                if (excelApplication != null)
                {
                    excelApplication.Quit();
                    excelApplication = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        #endregion

    }
}
