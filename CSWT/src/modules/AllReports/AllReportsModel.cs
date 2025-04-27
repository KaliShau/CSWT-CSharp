using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.report;

namespace CSWT.src.modules.AllReports
{
    public class AllReportsModel
    {
        ReportService _reportService;
        public AllReportsModel(ReportService reportService)
        {
            _reportService = reportService;
        }

        public ReportDTO[] GetAllReporst()
        {
            return _reportService.GetAllReports();
        }
        public ReportDTO[] GetAllReporstSearch(string searchTerm)
        {
            return _reportService.GetAllReportsSearch(searchTerm);
        }
    }

}
