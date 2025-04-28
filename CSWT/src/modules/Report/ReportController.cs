using System;
using System.Windows.Forms;
using CSWT.src.core;
using CSWT.src.shared.services.report;
using CSWT.src.shared.utils;
using Speckle.Newtonsoft.Json;

namespace CSWT.src.modules.Report
{
    public class ReportController
    {
        ReportModel _model;
        SessionContext _sessionContext;
        public ReportController(ReportModel model, SessionContext sessionContext)
        {
            _model = model;
            _sessionContext = sessionContext;
        }

        public void SaveToDocx(ListView listView, string reportTitle)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                FileName = $"{reportTitle}_{DateTime.Now:yyyyMMdd}.docx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    new SaveToFile().SaveReportToDocx(saveFileDialog.FileName, listView, reportTitle);
                    MessageBox.Show("Отчет успешно сохранен!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении отчета: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void PrintReport(ListView listView, string reportTitle)
        {
            try
            {
                new PrintReport().Print(listView, reportTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при печати отчета: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init(ListView List, TextBox titleBox, TextBox typeBox, Label createAtLabel)
        {
            var report = _model.GetReportById(_sessionContext.report_id);
            titleBox.Text = report.report_name;
            typeBox.Text = report.report_type;
            createAtLabel.Text = Convert.ToString(report.created_at);

            if (report.report_type == "users_report")
            {
                var users = JsonConvert.DeserializeObject<UsersReport>(report.json);
                this.AddUsers(users, List);
            }

            if (report.report_type == "requests_report")
            {
                var reports = JsonConvert.DeserializeObject<RequestsReport>(report.json);
                this.AddReports(reports, List);
            }

        }

        public void AddUsers(UsersReport users, ListView List)
        {

            List.View = View.Details;
            List.FullRowSelect = true;

            List.Columns.Add("ID", 50);
            List.Columns.Add("Логин", 200);
            List.Columns.Add("Полное имя", 200);
            List.Columns.Add("Email", 100);
            List.Columns.Add("Роль", 100);
            List.Columns.Add("Дата создания", 100);

            List.Items.Clear();

            foreach (var user in users.Users)
            {
                var item = new ListViewItem(user.Id.ToString());

                item.SubItems.Add(user.Username);
                item.SubItems.Add(user.FullName);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.Role);
                item.SubItems.Add(user.CreatedAt.ToString("dd.MM.yyyy HH:mm"));

                item.Tag = user;

                List.Items.Add(item);


            }
        }

        public void AddReports(RequestsReport reports, ListView List)
        {

            List.View = View.Details;
            List.FullRowSelect = true;

            List.Columns.Add("ID", 50);
            List.Columns.Add("Заголовок", 200);
            List.Columns.Add("Статус", 200);
            List.Columns.Add("Приоритет", 100);
            List.Columns.Add("Автор", 100);
            List.Columns.Add("Исполнитель", 100);
            List.Columns.Add("Дата создания", 100);
            List.Columns.Add("Дата выполнения", 100);

            List.Items.Clear();

            foreach (var report in reports.Requests)
            {
                var item = new ListViewItem(report.Id.ToString());

                item.SubItems.Add(report.Title);
                item.SubItems.Add(report.Status);
                item.SubItems.Add(report.Priority);
                item.SubItems.Add(report.Author);
                item.SubItems.Add(report.Assignee);
                item.SubItems.Add(report.CreatedDate.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(report.CompletedDate?.ToString("dd.MM.yyyy HH:mm"));

                item.Tag = report;

                List.Items.Add(item);
            }
        }


    }
}
