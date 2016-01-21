using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace NICSQLTools.Classes.msExcel
{
    public static class PivotCreator
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(PivotCreator));
        readonly static object useDefault = Type.Missing;

        #region  - Create Pivot - 

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
        /// <summary>
        /// Export DataTable to Excel file
        /// </summary>
        /// <param name="DataTable">Source DataTable</param>
        /// <param name="ExcelFilePath">Path to result file name</param>
        public static void ExportToExcel(this DevExpress.XtraPivotGrid.PivotGridControl pivotControl, string ExcelFilePath)
        {
            if (pivotControl.DataSource.GetType() != typeof(System.Data.DataTable))
                return;
            System.Data.DataTable dt = (System.Data.DataTable)pivotControl.DataSource;
            int ColumnsCount;
            if (dt == null || (ColumnsCount = dt.Columns.Count) == 0)
                throw new Exception("ExportToExcel: Null or empty input table!\n");

            Application ExcelApp = null;
            _Worksheet DataWorksheet = null;
            Range HeaderRange = null;
            object[,] Cells = null;
            Worksheet PivotWorksheet = null;
            Range pivotDestinationRange = null;
            Range pivotSourceRange = null;
            try
            {


                // load excel, and create a new workbook
                ExcelApp = new Application();
                ExcelApp.Workbooks.Add();
                // single worksheet
                DataWorksheet = ExcelApp.ActiveSheet;
                DataWorksheet.Name = "Data";
                object[] Header = new object[ColumnsCount];
                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = dt.Columns[i].ColumnName;
                HeaderRange = DataWorksheet.get_Range((Range)(DataWorksheet.Cells[1, 1]), (Range)(DataWorksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                HeaderRange.Font.Bold = true;
                // DataCells
                int RowsCount = dt.Rows.Count;
                Cells = new object[RowsCount, ColumnsCount];
                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = dt.Rows[j][i];
                DataWorksheet.get_Range((Range)(DataWorksheet.Cells[2, 1]), (Range)(DataWorksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;
                const string pivotTableName = @"[NICSQLTools]";
                PivotWorksheet = ExcelApp.Workbooks[1].Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                pivotSourceRange = DataWorksheet.get_Range((Range)(DataWorksheet.Cells[1, 1]), (Range)(DataWorksheet.Cells[RowsCount + 1, ColumnsCount]));
                PivotWorksheet.Name = "Pivot";
                pivotDestinationRange = PivotWorksheet.get_Range("A1", useDefault);

                PivotTable xlPivot = PivotWorksheet.PivotTableWizard(XlPivotTableSourceType.xlDatabase, pivotSourceRange, pivotDestinationRange, pivotTableName, true, true, true, false, useDefault, useDefault, false, false, XlOrder.xlDownThenOver, useDefault, useDefault, useDefault);


                for (int i = 0; i < pivotControl.Fields.Count; i++)
                {
                    DevExpress.XtraPivotGrid.PivotGridField DevField = pivotControl.Fields[i];
                    PivotField xlField = ((PivotField)xlPivot.PivotFields(i + 1));
                    //xlField.Name = DevField.Caption;

                    //Set Unbound Calculation
                    switch (DevField.Area)
                    {
                        case DevExpress.XtraPivotGrid.PivotArea.ColumnArea:
                            xlField.Orientation = XlPivotFieldOrientation.xlColumnField;
                            //xlPivot.AddFields(Type.Missing, xlField.Caption, Type.Missing, Type.Missing);
                            break;
                        case DevExpress.XtraPivotGrid.PivotArea.DataArea:
                            xlField.Orientation = XlPivotFieldOrientation.xlDataField;
                            //xlPivot.AddDataField(xlField.Caption, DevField.Caption, Type.Missing);
                            //xfield.SummaryType
                            switch (DevField.SummaryType)
                            {
                                case DevExpress.Data.PivotGrid.PivotSummaryType.Average:
                                    xlField.Function = XlConsolidationFunction.xlAverage;
                                    break;
                                case DevExpress.Data.PivotGrid.PivotSummaryType.Count:
                                    xlField.Function = XlConsolidationFunction.xlCount;
                                    break;
                                case DevExpress.Data.PivotGrid.PivotSummaryType.Custom:
                                    xlField.Function = XlConsolidationFunction.xlUnknown;
                                    break;
                                case DevExpress.Data.PivotGrid.PivotSummaryType.Max:
                                    xlField.Function = XlConsolidationFunction.xlMax;
                                    break;
                                case DevExpress.Data.PivotGrid.PivotSummaryType.Min:
                                    xlField.Function = XlConsolidationFunction.xlMin;
                                    break;
                                case DevExpress.Data.PivotGrid.PivotSummaryType.StdDev:
                                    xlField.Function = XlConsolidationFunction.xlStDev;
                                    break;
                                case DevExpress.Data.PivotGrid.PivotSummaryType.StdDevp:
                                    xlField.Function = XlConsolidationFunction.xlStDevP;
                                    break;
                                case DevExpress.Data.PivotGrid.PivotSummaryType.Sum:
                                    xlField.Function = XlConsolidationFunction.xlSum;
                                    break;
                                case DevExpress.Data.PivotGrid.PivotSummaryType.Var:
                                    xlField.Function = XlConsolidationFunction.xlVar;
                                    break;
                                case DevExpress.Data.PivotGrid.PivotSummaryType.Varp:
                                    xlField.Function = XlConsolidationFunction.xlVarP;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case DevExpress.XtraPivotGrid.PivotArea.FilterArea:
                            xlField.Orientation = XlPivotFieldOrientation.xlPageField;
                            //xlPivot.AddFields(Type.Missing, Type.Missing, xlField.Caption);
                            break;
                        case DevExpress.XtraPivotGrid.PivotArea.RowArea:
                            xlField.Orientation = XlPivotFieldOrientation.xlRowField;
                            //xlPivot.AddFields(xlField.Caption, Type.Missing, Type.Missing);
                            break;
                        default:
                            break;
                    }
                    //Set Filtering
                    //xlField.PivotFilters.Add2()
                }

            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
            finally
            {
                Cells = null;
                // Release the Ranges object.
                pivotDestinationRange = null;
                pivotSourceRange = null;
                // Release the WorkSheet object.
                DataWorksheet = null;
                PivotWorksheet = null;
                // Release the ApplicationClass object.
                if (ExcelApp != null)
                {
                    ExcelApp.Quit();
                    ExcelApp = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        public static void CreatePivotByRecordSet(DevExpress.XtraPivotGrid.PivotGridControl pivotControl, string workSheetName, string workBookPath)
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
            const string pivotTableName = @"[NICSQLTools]";
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
                //    DevExpress.XtraPivotGrid.PivotGridField DevField = pivotControl.Fields[i];
                //    PivotField xlField = ((PivotField)xlPivot.PivotFields(i + 1));


                //    //PivotField pageField = (PivotField)xlPivot.PivotFields("Route Name");
                //    //pageField.Orientation = XlPivotFieldOrientation.xlRowField;

                //    //xlField.Name = xField.Caption;
                //    //Set Unbound Calculation


                //    switch (DevField.Area)
                //    {
                //        case DevExpress.XtraPivotGrid.PivotArea.ColumnArea:
                //            //xlField.Orientation = XlPivotFieldOrientation.xlColumnField;
                //            xlPivot.AddFields(Type.Missing, xlField.Caption, Type.Missing, Type.Missing);
                //            break;
                //        case DevExpress.XtraPivotGrid.PivotArea.DataArea:
                //            //xlField.Orientation = XlPivotFieldOrientation.xlDataField;
                //            xlPivot.AddDataField(xlField.Caption, DevField.Caption, Type.Missing);
                //            //xfield.SummaryType
                //            switch (DevField.SummaryType)
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
                //            //xlField.Orientation = XlPivotFieldOrientation.xlPageField;
                //            xlPivot.AddFields(Type.Missing, Type.Missing, xlField.Caption);
                //            break;
                //        case DevExpress.XtraPivotGrid.PivotArea.RowArea:
                //            //xlField.Orientation = XlPivotFieldOrientation.xlRowField;
                //            //xlPivot.AddFields(xlField.Caption, Type.Missing, Type.Missing);
                //            xlPivot.AddDataField(xlField, "Eshta", Type.Missing);
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
        public static void CreatePivotByRange(DevExpress.XtraPivotGrid.PivotGridControl pivotControl, string workSheetName, string workBookPath)
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
            const string pivotTableName = @"[NICSQLTools]";
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

                PivotField xlField = ((PivotField)xlPivot.PivotFields(2));
                xlField.Orientation = XlPivotFieldOrientation.xlRowField;

                // Save the Workbook.
                excelWorkBook.SaveAs(workBookPath, useDefault, useDefault, useDefault, useDefault, useDefault,
                    XlSaveAsAccessMode.xlNoChange, useDefault, useDefault, useDefault, useDefault, useDefault);


                //for (int i = 0; i < pivotControl.Fields.Count; i++)
                //{
                //    DevExpress.XtraPivotGrid.PivotGridField DevField = pivotControl.Fields[i];
                //    PivotField xlField = ((PivotField)xlPivot.PivotFields(i + 1));


                //    //PivotField pageField = (PivotField)xlPivot.PivotFields("Route Name");
                //    //pageField.Orientation = XlPivotFieldOrientation.xlRowField;

                //    //xlField.Name = xField.Caption;
                //    //Set Unbound Calculation


                //    switch (DevField.Area)
                //    {
                //        case DevExpress.XtraPivotGrid.PivotArea.ColumnArea:
                //            //xlField.Orientation = XlPivotFieldOrientation.xlColumnField;
                //            xlPivot.AddFields(Type.Missing, xlField.Caption, Type.Missing, Type.Missing);
                //            break;
                //        case DevExpress.XtraPivotGrid.PivotArea.DataArea:
                //            //xlField.Orientation = XlPivotFieldOrientation.xlDataField;
                //            xlPivot.AddDataField(xlField.Caption, DevField.Caption, Type.Missing);
                //            //xfield.SummaryType
                //            switch (DevField.SummaryType)
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
                //            //xlField.Orientation = XlPivotFieldOrientation.xlPageField;
                //            xlPivot.AddFields(Type.Missing, Type.Missing, xlField.Caption);
                //            break;
                //        case DevExpress.XtraPivotGrid.PivotArea.RowArea:
                //            //xlField.Orientation = XlPivotFieldOrientation.xlRowField;
                //            //xlPivot.AddFields(xlField.Caption, Type.Missing, Type.Missing);
                //            xlPivot.AddDataField(xlField, "Eshta", Type.Missing);
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
