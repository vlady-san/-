using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.ReportUtility.Services
{
    class ChainOfReports
    {
        private readonly ReportHandler _handler;

        public ChainOfReports()
        {
            _handler = new TxtReportHandler(null);
            _handler = new CsvReportHandler(_handler);
            _handler = new XlsxReportHandler(_handler);
        }

        public ReportServiceBase CreateReportService(string filename, string[] args)
        {
            return _handler.CreateReportService(filename, args);
        }
    }
}
