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
        RoleSQL _sql;
        public RoleService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new RoleSQL();
        }

        public RoleDTO GetRoleByRoleName(string role_name)
        {
            return _repository.Query<RoleDTO>(
             _sql.GetRoleByRoleName,
             reader => new RoleDTO
             {
                 ID = Convert.ToInt32(reader["ID"]),
                 created_at = Convert.ToDateTime(reader["created_at"]),
                 updated_at = Convert.ToDateTime(reader["updated_at"]),
                 role_name = reader["role_name"].ToString(),
                 description = reader["description"].ToString()
             }, new NpgsqlParameter("@role_name", role_name)).FirstOrDefault();
        }

        public RoleDTO GetRoleByID(int ID)
        {
            return _repository.Query<RoleDTO>(
             _sql.GetRoleByID,
             reader => new RoleDTO
             {
                 ID = Convert.ToInt32(reader["ID"]),
                 created_at = Convert.ToDateTime(reader["created_at"]),
                 updated_at = Convert.ToDateTime(reader["updated_at"]),
                 role_name = reader["role_name"].ToString(),
                 description = reader["description"].ToString()
             }, new NpgsqlParameter("@ID", ID)).FirstOrDefault();
        }
    }
}
