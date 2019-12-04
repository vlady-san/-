using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.ReportUtility.Interfaces
{
    interface IReportPrinter
    {
        void Print(String headerRow, String rowTemplate);
    }
}
