using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.report;

namespace CSWT.src.modules.Report
{
    public class ReportModel
    {
        ReportService _reportService;
        public ReportModel(ReportService reportService)
        {
            _reportService = reportService;
        }

        public ReportWithJson GetReportById(int id)
        {
            return _reportService.GetReportById(id);
        }
    }
}
