using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.db;
using Npgsql;

namespace CSWT.src.shared.services.priority
{
    public class PriorityService
    {
        DatabaseRepository _repository;
        PrioritySQL _sql;
        public PriorityService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new PrioritySQL();
        }

        public PriorityDTO[] GetPriorities()
        {
            var priorities = _repository.Query<PriorityDTO>(
                _sql.GetPriorities, 
                reader => new PriorityDTO
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                priority_name = reader["priority_name"].ToString(),
                description = reader["description"].ToString(),
            });

            return priorities.ToArray();

        }
        public PriorityDTO GetPriorityByID(int ID)
        {
            var priority = _repository.Query<PriorityDTO>(
                _sql.GetPriorityByID,
                reader => new PriorityDTO
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    created_at = Convert.ToDateTime(reader["created_at"]),
                    updated_at = Convert.ToDateTime(reader["updated_at"]),
                    priority_name = reader["priority_name"].ToString(),
                    description = reader["description"].ToString(),
                }, new NpgsqlParameter("@ID", ID)).SingleOrDefault();

            return priority;
        }
    }
}
