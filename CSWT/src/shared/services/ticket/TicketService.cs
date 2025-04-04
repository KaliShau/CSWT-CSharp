using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
