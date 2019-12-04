using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.ReportUtility.Services
{
    class XlsxReportHandler : ReportHandler
    {
        public override ReportServiceBase CreateReportService(string filename, string[] args)
        {
            if (filename.EndsWith(".xlsx"))
            {
                return new XlsxReportService(args);
            }
            return base.CreateReportService(filename, args);
        }

        public XlsxReportHandler(ReportHandler nextHandler) : base(nextHandler)
        { }
    }
}
