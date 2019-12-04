using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrm.ReportUtility.Interfaces;

namespace Xrm.ReportUtility.Printers
{
    class WithTotalWeightPrinter : IReportPrinter
    {
        private IReportPrinter _printer;
        public WithTotalWeightPrinter(IReportPrinter printer)
        {
            _printer = printer;
        }
        public void Print(string headerRow, string rowTemplate)
        {
            _printer.Print(headerRow, rowTemplate);

            headerRow = headerRow + "\tСуммарный вес";
            rowTemplate = rowTemplate + "\t{7,13}";
        }
    }
}
