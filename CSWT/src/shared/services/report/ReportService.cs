using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CSWT.src.core.db;
using Npgsql;

namespace CSWT.src.shared.services.report
{
    public class ReportService
    {
        DatabaseRepository _repository;
        ReportSQL _sql;
        public ReportService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new ReportSQL();
        }

        public async Task<UsersReport> GenerateUsersReport(int currentUserId)
        {
            var users = await _repository.QueryAsync<UserReportItem>(_sql.GenerateUsersReport, reader => new UserReportItem
            {
                Id = reader.GetInt32(0),
                Username = reader.GetString(1),
                FullName = reader.IsDBNull(2) ? null : reader.GetString(2),
                Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                Role = reader.IsDBNull(4) ? null : reader.GetString(4),
                CreatedAt = reader.GetDateTime(5)
            });

            var report = new UsersReport
            {
                Title = "Отчет по пользователям",
                GeneratedAt = DateTime.Now,
                CurrentUserId = currentUserId,
                Users = users.ToList()
            };

            var jsonData = JsonSerializer.Serialize(report, new JsonSerializerOptions
            {
                WriteIndented = true 
            });

            await _repository.ExecuteAsync(
                @"INSERT INTO Reports (report_name, report_type, report_data, user_id)
          VALUES (@name, @type, @data::jsonb, @userId)",
                new NpgsqlParameter("@name", report.Title + " " + DateTime.Now.ToString("yyyy-MM-dd")),
                new NpgsqlParameter("@type", "users_report"),
                new NpgsqlParameter("@data", jsonData),
                new NpgsqlParameter("@userId", currentUserId)
            );

            return report;
        }
    }
}