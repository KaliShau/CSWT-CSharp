using System;
using System.Linq;
using CSWT.src.core.db;
using CSWT.src.shared.dto;
using CSWT.src.shared.services.role;
using Npgsql;

namespace CSWT.src.shared.services
{
    public class RoleService
    {
        DatabaseRepository _repository;
        public RoleService(DatabaseRepository repository)
        {
            _repository = repository;
        }

        public RoleDTO GetRoleByRoleName(string role_name)
        {
            return _repository.Query<RoleDTO>(
             new RoleSQL().GetRoleByRoleName,
             reader => new RoleDTO
             {
                 ID = Convert.ToInt32(reader["id"]),
                 created_at = Convert.ToDateTime(reader["created_at"]),
                 updated_at = Convert.ToDateTime(reader["updated_at"]),
                 role_name = reader["role_name"].ToString(),
                 description = reader["description"].ToString()
             }, new NpgsqlParameter("@role_name", role_name)).FirstOrDefault();
        }
    }
}
