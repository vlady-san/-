using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrm.ReportUtility.Interfaces;

namespace Xrm.ReportUtility.Printers
{
    class StandartPrinter : IReportPrinter
    {
        public void Print(string headerRow, string rowTemplate)
        {
             headerRow = "Наименование\tОбъём упаковки\tМасса упаковки\tСтоимость\tКоличество";
             rowTemplate = "{1,12}\t{2,14}\t{3,14}\t{4,9}\t{5,10}";
        }
    }
}
