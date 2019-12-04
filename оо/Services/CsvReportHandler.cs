using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.ReportUtility.Services
{
    class CsvReportHandler : ReportHandler
    {
        public override ReportServiceBase CreateReportService(string filename, string[] args)
        {
            if (filename.EndsWith(".csv"))
            {
                return new CsvReportService(args);
            }
            return base.CreateReportService(filename,args);
        }

        public CsvReportHandler(ReportHandler nextHandler) : base(nextHandler)
        { }
    }
}
