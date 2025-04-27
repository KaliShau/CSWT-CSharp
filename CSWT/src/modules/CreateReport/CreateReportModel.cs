using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.shared.services.report;

namespace CSWT.src.modules.CreateReport
{
    public class CreateReportModel
    {
        private readonly ReportService _reportService;

        public CreateReportModel(ReportService reportService)
        {
            _reportService = reportService;
        }

        public async Task GenerateUsersReport(int ID)
        {
            try
            {
                await _reportService.GenerateUsersReport(ID);
                MessageBox.Show("Отчет по пользователям успешно создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчета: {ex.Message}");
            }
        }

        public async Task GenerateAllRequestsReport(int ID)
        {
            try
            {
                await _reportService.GenerateAllRequestsReport(ID);
                MessageBox.Show("Отчет по всем заявкам успешно создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчета: {ex.Message}");
            }
        }

        public async Task GenerateMonthlyRequestsReport(int ID, int? year = null, int? month = null)
        {
            try
            {
                var now = DateTime.Now;
                var reportYear = year ?? now.Year;
                var reportMonth = month ?? now.Month;

                await _reportService.GenerateMonthlyRequestsReport(ID, reportYear, reportMonth);
                MessageBox.Show($"Отчет по заявкам за {reportMonth}.{reportYear} успешно создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчета: {ex.Message}");
            }
        }
    }
}
