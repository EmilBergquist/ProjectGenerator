using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProjektGenerator_Test1
{
    class ModifyExcelFile
    {
        public void WriteToExcelFile(string pathToFile, string pathToSave, List<DataToInsert> data)
        {
            var excelApp = new Excel.Application();

            Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(pathToFile,
                Type.Missing, true, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            Excel._Worksheet excelWorksheet = (Excel._Worksheet)excelWorkbook.Sheets[1];

            foreach (DataToInsert item in data)
            {
                excelWorksheet.Cells[item.Row, item.Column].value2 = item.Text;
            }

            excelWorkbook.SaveAs(
                    pathToSave,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing
                );

            excelWorkbook.Close();
        }
    }
}
