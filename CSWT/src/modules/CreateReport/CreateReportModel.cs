using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.shared.services.report;

namespace CSWT.src.modules.CreateReport
{
    public class CreateReportModel
    {
        ReportService _reportService;
        public CreateReportModel(ReportService reportService)
        {
            _reportService = reportService;
        }

        public void GenerateUsersReport(int ID)
        {
            var data = _reportService.GenerateUsersReport(ID);

            if (data != null)
            {
                MessageBox.Show("Отчет создан!");
            }
        }
    }
}
