using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public ReportWithJson GetReportById(int ID)
        {
            return _repository.Query<ReportWithJson>(_sql.GetReportById, reader => new ReportWithJson
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                report_name = reader["report_name"].ToString(),
                report_type = reader["report_type"].ToString(),
                json = reader["report_data"].ToString()
            }, new NpgsqlParameter("ID", ID)).SingleOrDefault();
        }

        public ReportDTO[] GetMyReports(int ID)
        {
            return _repository.Query<ReportDTO>(_sql.GetMyReports, reader => new ReportDTO
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                report_name = reader["report_name"].ToString(),
                report_type = reader["report_type"].ToString()
            }, new NpgsqlParameter("user_id", ID)).ToArray();
        }
        public ReportDTO[] GetMyReportsSearch(int ID, string searchTerm)
        {
            return _repository.Query<ReportDTO>(_sql.GetMyReportsSearch, reader => new ReportDTO
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                report_name = reader["report_name"].ToString(),
                report_type = reader["report_type"].ToString()
            }, new NpgsqlParameter("user_id", ID), new NpgsqlParameter("searchTerm", searchTerm)).ToArray();
        }

        public ReportDTO[] GetAllReports()
        {
            return _repository.Query<ReportDTO>(_sql.GetAllReports, reader => new ReportDTO
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                report_name = reader["report_name"].ToString(),
                report_type = reader["report_type"].ToString()
            }).ToArray();
        }
        public ReportDTO[] GetAllReportsSearch(string searchTerm)
        {
            return _repository.Query<ReportDTO>(_sql.GetAllReportsSearch, reader => new ReportDTO
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                report_name = reader["report_name"].ToString(),
                report_type = reader["report_type"].ToString()
            }, new NpgsqlParameter("searchTerm", searchTerm)).ToArray();
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

        public async Task<RequestsReport> GenerateAllRequestsReport(int currentUserId)
        {
            var requests = await _repository.QueryAsync<RequestReportItem>(_sql.GetAllRequests, reader => new RequestReportItem
            {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Status = reader.GetString(2),
                Priority = reader.GetString(3),
                Author = reader.GetString(4),
                Assignee = reader.IsDBNull(5) ? null : reader.GetString(5),
                CreatedDate = reader.GetDateTime(6),
                CompletedDate = reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7)
            });

            var report = new RequestsReport
            {
                Title = "Отчет по всем заявкам",
                GeneratedAt = DateTime.Now,
                CurrentUserId = currentUserId,
                Requests = requests.ToList(),
                PeriodDescription = "За все время"
            };

            var jsonData = JsonSerializer.Serialize(report, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            await _repository.ExecuteAsync(
                @"INSERT INTO Reports (report_name, report_type, report_data, user_id)
                  VALUES (@name, @type, @data::jsonb, @userId)",
                new NpgsqlParameter("@name", report.Title),
                new NpgsqlParameter("@type", "requests_report"),
                new NpgsqlParameter("@data", jsonData),
                new NpgsqlParameter("@userId", currentUserId)
            );

            return report;
        }

        public async Task<RequestsReport> GenerateMonthlyRequestsReport(int currentUserId, int year, int month)
        {
            var startDate = new DateTime(year, month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@startDate", startDate),
                new NpgsqlParameter("@endDate", endDate)
            };

            var requests = await _repository.QueryAsync<RequestReportItem>(_sql.GetRequestsByDateRange, reader => new RequestReportItem
            {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Status = reader.GetString(2),
                Priority = reader.GetString(3),
                Author = reader.GetString(4),
                Assignee = reader.IsDBNull(5) ? null : reader.GetString(5),
                CreatedDate = reader.GetDateTime(6),
                CompletedDate = reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7)
            }, parameters);

            var monthName = new DateTime(year, month, 1).ToString("MMMM yyyy");
            var report = new RequestsReport
            {
                Title = $"Отчет по заявкам за {monthName}",
                GeneratedAt = DateTime.Now,
                CurrentUserId = currentUserId,
                Requests = requests.ToList(),
                PeriodDescription = $"За {monthName}"
            };

            var jsonData = JsonSerializer.Serialize(report, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            await _repository.ExecuteAsync(
                @"INSERT INTO Reports (report_name, report_type, report_data, user_id)
                  VALUES (@name, @type, @data::jsonb, @userId)",
                new NpgsqlParameter("@name", report.Title),
                new NpgsqlParameter("@type", "requests_report"),
                new NpgsqlParameter("@data", jsonData),
                new NpgsqlParameter("@userId", currentUserId)
            );

            return report;
        }
    }
}