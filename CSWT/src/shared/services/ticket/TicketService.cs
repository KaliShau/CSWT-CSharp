using System;
using CSWT.src.core.db;
using Npgsql;

namespace CSWT.src.shared.services.ticket
{
    public class TicketService
    {
        DatabaseRepository _repository;
        TicketSQL _sql;
        public TicketService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new TicketSQL();
        }

        public void CreateTicket(string title, string description, int client_id, int priority_id, int status_id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@title", title),
                new NpgsqlParameter("@description", description),
                new NpgsqlParameter("@client_id", client_id),
                new NpgsqlParameter("@priority_id", priority_id),
                new NpgsqlParameter("@status_id",  status_id)
            };

            _repository.Execute(_sql.CreateTicket, parameters);
        }

        public TicketWithJoinDTO[] GetTicketsByClientId(int client_id)
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetTicketsByClientId,
             reader => new TicketWithJoinDTO
             {
                 ID = reader.GetInt32(reader.GetOrdinal("ID")),
                 created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                 updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                 title = reader.GetString(reader.GetOrdinal("title")),
                 description = reader.GetString(reader.GetOrdinal("description")),
                 solution = reader.IsDBNull(reader.GetOrdinal("solution")) ? null : reader.GetString(reader.GetOrdinal("solution")),
                 closed_at = reader.IsDBNull(reader.GetOrdinal("closed_at")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("closed_at")),
                 client_id = reader.GetInt32(reader.GetOrdinal("client_id")),
                 client_name = reader.GetString(reader.GetOrdinal("client_name")),
                 priority_name = reader.GetString(reader.GetOrdinal("priority_name")),
                 status_name = reader.GetString(reader.GetOrdinal("status_name")),
                 assigned_to = reader.IsDBNull(reader.GetOrdinal("assigned_to")) ? 0 : reader.GetInt32(reader.GetOrdinal("assigned_to")),
                 assigned_user_name = reader.IsDBNull(reader.GetOrdinal("assigned_user_name")) ? null : reader.GetString(reader.GetOrdinal("assigned_user_name"))
             }, new NpgsqlParameter("@client_id", client_id)).ToArray();
        }

        public TicketWithJoinDTO[] GetTicketsByClientIdSearch(int client_id, string searchTerm)
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetTicketsByClientIdSearch,
             reader => new TicketWithJoinDTO
             {
                 ID = reader.GetInt32(reader.GetOrdinal("ID")),
                 created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                 updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                 title = reader.GetString(reader.GetOrdinal("title")),
                 description = reader.GetString(reader.GetOrdinal("description")),
                 solution = reader.IsDBNull(reader.GetOrdinal("solution")) ? null : reader.GetString(reader.GetOrdinal("solution")),
                 closed_at = reader.IsDBNull(reader.GetOrdinal("closed_at")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("closed_at")),
                 client_id = reader.GetInt32(reader.GetOrdinal("client_id")),
                 client_name = reader.GetString(reader.GetOrdinal("client_name")),
                 priority_name = reader.GetString(reader.GetOrdinal("priority_name")),
                 status_name = reader.GetString(reader.GetOrdinal("status_name")),
                 assigned_to = reader.IsDBNull(reader.GetOrdinal("assigned_to")) ? 0 : reader.GetInt32(reader.GetOrdinal("assigned_to")),
                 assigned_user_name = reader.IsDBNull(reader.GetOrdinal("assigned_user_name")) ? null : reader.GetString(reader.GetOrdinal("assigned_user_name"))
             }, new NpgsqlParameter("@client_id", client_id),
                new NpgsqlParameter("@searchTerm", searchTerm)
             ).ToArray();
        }
    }
}
