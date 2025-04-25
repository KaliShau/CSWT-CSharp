using System;
using System.Linq;
using System.Windows.Forms;
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

        public void UpdateClosedAt(int ID)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@ID", ID),
            };

            _repository.Execute(_sql.UpdateClosedAt, parameters);
        }

        public void UpdateTicket(string title, string description, string solution, int priority_id, int status_id, int ID)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@title", title),
                new NpgsqlParameter("@description", description),
                new NpgsqlParameter("@solution", solution),
                new NpgsqlParameter("@priority_id", priority_id),
                new NpgsqlParameter("@status_id",  status_id),
                new NpgsqlParameter("@ID",  ID)
            };

            var rowsAffected = _repository.Execute(_sql.UpdateTicket, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Заявка обновлена!");
            }
            else
            {
                MessageBox.Show("Ошибка обновления заявки!");
            }
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

        public void UpdateTicketClient(string title, string description, int ID)
        {
            var rowsAffected = _repository.Execute(_sql.UpdateTicketClient, new NpgsqlParameter("@title", title), new NpgsqlParameter("@description", description), new NpgsqlParameter("@ID", ID));

            if (rowsAffected > 0)
            {
                MessageBox.Show("Заявка обновлена!");
            }
            else
            {
                MessageBox.Show("Ошибка обновления заявки!");
            }
        }

        public void AssignedTicket(int assigned, int status_id, int ID)
        {
            var rowsAffected = _repository.Execute(_sql.AssignedTicket, new NpgsqlParameter("assigned_to", assigned), new NpgsqlParameter("@status_id", status_id), new NpgsqlParameter("@ID", ID));

            if (rowsAffected > 0)
            {
                MessageBox.Show("Заявка принята!");
            }
            else
            {
                MessageBox.Show("Ошибка обновления заявки!");
            }
        }

        public void DeleteTicket(int ID)
        {
            var rowsAffected = _repository.Execute(_sql.DeleteTicket, new NpgsqlParameter("@ID", ID));

            if (rowsAffected > 0)
            {
                MessageBox.Show("Заявка удалена!");
            }
            else
            {
                MessageBox.Show("Ошибка удаления заявки!");
            }
        }

        public TicketWithJoinDTO[] GetTicketsByClientId(int client_id)
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetTicketsByClientId,
             MapTicketWithJoinDTO, new NpgsqlParameter("@client_id", client_id)).ToArray();
        }

        public TicketWithJoinDTO[] GetTicketsByClientIdSearch(int client_id, string searchTerm)
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetTicketsByClientIdSearch,
             MapTicketWithJoinDTO, new NpgsqlParameter("@client_id", client_id),
                new NpgsqlParameter("@searchTerm", searchTerm)
             ).ToArray();
        }

        public TicketWithJoinDTO GetTicketByID(int ID)
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetTicketByID,
             MapTicketWithJoinDTO,
              new NpgsqlParameter("@ID", ID)
             ).SingleOrDefault();
        }

        public TicketWithJoinDTO[] GetTickets()
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetTickets,
             MapTicketWithJoinDTO
             ).ToArray();
        }

        public TicketWithJoinDTO[] GetNewTickets(int status_id)
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetNewTickets,
             MapTicketWithJoinDTO, new NpgsqlParameter("@status_id", status_id)).ToArray();
        }

        public TicketWithJoinDTO[] GetNewTicketsSearch(int status_id, string searchTerm)
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetNewTicketsSearch,
             MapTicketWithJoinDTO, new NpgsqlParameter("@status_id", status_id),
                new NpgsqlParameter("@searchTerm", searchTerm)
             ).ToArray();
        }

        public TicketWithJoinDTO[] GetAssignedTickets(int assigned_to)
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetAssignedTickets,
             MapTicketWithJoinDTO, new NpgsqlParameter("@assigned_to", assigned_to)).ToArray();
        }

        public TicketWithJoinDTO[] GetAssignedTicketsSearch(int assigned_to, string searchTerm)
        {
            return _repository.Query<TicketWithJoinDTO>(
             _sql.GetAssignedTicketsSearch,
             MapTicketWithJoinDTO, new NpgsqlParameter("@assigned_to", assigned_to),
                new NpgsqlParameter("@searchTerm", searchTerm)
             ).ToArray();
        }

        private TicketWithJoinDTO MapTicketWithJoinDTO(NpgsqlDataReader reader)
        {
            return new TicketWithJoinDTO
            {
                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                title = reader.GetString(reader.GetOrdinal("title")),
                description = reader.GetString(reader.GetOrdinal("description")),
                solution = reader.IsDBNull(reader.GetOrdinal("solution")) ? null : reader.GetString(reader.GetOrdinal("solution")),
                closed_at = reader.IsDBNull(reader.GetOrdinal("closed_at")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("closed_at")),
                client_id = reader.IsDBNull(reader.GetOrdinal("client_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("client_id")),
                client_name = reader.IsDBNull(reader.GetOrdinal("client_name")) ? "Удален" : reader.GetString(reader.GetOrdinal("client_name")),
                priority_name = reader.GetString(reader.GetOrdinal("priority_name")),
                priority_id = reader.GetInt32(reader.GetOrdinal("priority_id")),
                status_name = reader.GetString(reader.GetOrdinal("status_name")),
                status_id = reader.GetInt32(reader.GetOrdinal("status_id")),
                assigned_to = reader.IsDBNull(reader.GetOrdinal("assigned_to")) ? 0 : reader.GetInt32(reader.GetOrdinal("assigned_to")),
                assigned_user_name = reader.IsDBNull(reader.GetOrdinal("assigned_user_name")) ? null : reader.GetString(reader.GetOrdinal("assigned_user_name"))
            };
        }
    }
}
