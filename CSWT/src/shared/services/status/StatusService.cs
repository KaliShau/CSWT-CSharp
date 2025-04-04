using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.db;
using CSWT.src.shared.dto;
using Npgsql;

namespace CSWT.src.shared.services.status
{
    public class StatusService
    {
        DatabaseRepository _repository;
        StatusSQL _sql;
        public StatusService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new StatusSQL();
        }
        public StatusDTO GetStatusByStatusName(string status_name)
        {
            return _repository.Query<StatusDTO>(
             _sql.GetStatusByStatusName,
             reader => new StatusDTO
             {
                 ID = Convert.ToInt32(reader["ID"]),
                 created_at = Convert.ToDateTime(reader["created_at"]),
                 updated_at = Convert.ToDateTime(reader["updated_at"]),
                 status_name = reader["status_name"].ToString(),
                 description = reader["description"].ToString()
             }, new NpgsqlParameter("@status_name", status_name)).SingleOrDefault();
        }
    }
}
