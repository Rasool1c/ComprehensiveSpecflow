using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveSpecflow.Hooks
{
    public class ExcelRead
    {
        public string ReadExcelData(int Cell, int Rowvalue  )
        {
            string path = @"C:\Users\mindc1may214\source\repos\ComprehensiveNunit\Details.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = workbook.GetSheetAt(0); //sheet number
            var row = sheet.GetRow(Rowvalue); //row number
            string Fname = row.GetCell(Cell).StringCellValue.Trim(); //clm/cell number
            Console.WriteLine("the first name from excels is " + Fname);
            return Fname;

        }
        
    }
}
