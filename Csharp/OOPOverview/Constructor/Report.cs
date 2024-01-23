using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Report
    {
        public string ExcelFilePath { get; set; }

        public string ReportType { get; set; }

        public Report(string filePath)
        {
            ExcelFilePath = filePath;
            ReportType = "PDF";
        }

        public void Process()
        {
            //Excel dosyasını oku ve verileri rapora dönüştür.

        }
    }
}
