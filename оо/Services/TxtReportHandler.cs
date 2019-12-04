using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.ReportUtility.Services
{
    class TxtReportHandler : ReportHandler
    {
        public override ReportServiceBase CreateReportService(string filename, string[] args)
        {
            if (filename.EndsWith(".txt"))
            {
                return new TxtReportService(args);
            }
            return base.CreateReportService(filename, args);
        }

            public TxtReportHandler(ReportHandler nextHandler) : base(nextHandler)
        { }
    }
}
