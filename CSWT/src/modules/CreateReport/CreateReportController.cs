using System.Windows.Forms;
using CSWT.src.core.db;

namespace CSWT.src.modules.CreateReport
{
    public class CreateReportController
    {
        CreateReportModel _model;
        UserContext _userContext;
        public CreateReportController(CreateReportModel model, UserContext userContext)
        {
            _model = model;
            _userContext = userContext;
        }

        public void Init(ComboBox reportBox)
        {
            reportBox.Items.Clear();

            reportBox.Items.AddRange(new object[]
            {
                "Отчет по пользователям",
                "Отчет по заявкам за последний месяц",
                "Отчет по всем заявкам"
            });

            reportBox.SelectedIndex = 0;
        }

        public void Generate(ComboBox reportBox)
        {
            if (reportBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тип отчета", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = reportBox.SelectedItem.ToString();

            switch (selectedReport)
            {
                case "Отчет по пользователям":
                    MessageBox.Show("Генерация отчета по пользователям...", "Информация",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _model.GenerateUsersReport(_userContext.CurrentUser.ID);
                    break;

                case "Отчет по заявкам за последний месяц":
                    MessageBox.Show("Генерация отчета по заявкаи...", "Информация",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                   _model.GenerateMonthlyRequestsReport(_userContext.CurrentUser.ID);
                    break;
                case "Отчет по всем заявкам":
                    MessageBox.Show("Генерация отчета по заявкаи...", "Информация",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _model.GenerateAllRequestsReport(_userContext.CurrentUser.ID);
                    break;
            }
        }

    }
}
