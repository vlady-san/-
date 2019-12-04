using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.ReportUtility.Services
{
    public abstract class ReportHandler
    {
        private readonly ReportHandler _nextHandler;

        protected ReportHandler(ReportHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual ReportServiceBase CreateReportService(string filename, string[] args)
        {
            if (_nextHandler!=null)
            return _nextHandler.CreateReportService(filename, args);
            else throw new NotSupportedException("this extension not supported"); 
        }
    }
}
