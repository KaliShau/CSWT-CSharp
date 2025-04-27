using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.report;

namespace CSWT.src.modules.MyReports
{
    public class MyReportsModel
    {
        ReportService _reportService;
        public MyReportsModel(ReportService reportService)
        {
            _reportService = reportService;
        }

        public ReportDTO[] GetMyReporst(int ID)
        {
            return _reportService.GetMyReports(ID);
        }
        public ReportDTO[] GetMyReporstSearch(int ID, string searchTerm)
        {
            return _reportService.GetMyReportsSearch(ID, searchTerm);
        }
    }
}
