using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages
{
    public class ExelService
    {
        public List<Word>getWords() 
        {
            Excel.Application excelApp = new Excel.Application();
            string file = @"C:\Users\User\source\repos\Languages\ViewerMessages.xlsx";
            Excel.Workbook xlWorkbook = excelApp.Workbooks.Open(file);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;

            List<Word> words = new List<Word>();

            for (int i = 1; i <= rowCount; i++)
            {
                var e = (string)xlRange.Cells[i, 1].Value.ToString();
                var r = (string)xlRange.Cells[i, 2].Value.ToString();
                words.Add(new Word { Russian = r, English = e });
            }

            xlWorkbook.Close();
            excelApp.Quit();
            
            return words;
        }
    }
}
