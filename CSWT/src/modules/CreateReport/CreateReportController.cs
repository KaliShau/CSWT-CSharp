using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        "Отчет по заявкам",
        "Отчет по отделам",
        "Отчет по статусам заявок",
        "Отчет по приоритетам"
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

            // Обрабатываем выбор
            switch (selectedReport)
            {
                case "Отчет по пользователям":
                    MessageBox.Show("Генерация отчета по пользователям...", "Информация",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
            } 
        }

        public void GenerateUsersReport()
        {
            _model.GenerateUsersReport(_userContext.CurrentUser.ID);
        }
    }
}
