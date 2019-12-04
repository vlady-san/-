using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrm.ReportUtility.Interfaces;

namespace Xrm.ReportUtility.Printers
{
    class WithIndexPrinter : IReportPrinter
    {
        private IReportPrinter _printer;
        public WithIndexPrinter(IReportPrinter printer)
        {
            _printer = printer;
        }
        public void Print(string headerRow, string rowTemplate)
        {
            _printer.Print(headerRow, rowTemplate);

            headerRow = "№\t" + headerRow;
            rowTemplate = "{0}\t" + rowTemplate;
        }
    }
}
