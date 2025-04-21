using System;
using System.Linq;
using System.Windows.Forms;
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

        public RoleDTO[] GetRoles()
        {
            return _repository.Query<RoleDTO>(
             _sql.GetRoles,
             reader => new RoleDTO
             {
                 ID = Convert.ToInt32(reader["ID"]),
                 created_at = Convert.ToDateTime(reader["created_at"]),
                 updated_at = Convert.ToDateTime(reader["updated_at"]),
                 role_name = reader["role_name"].ToString(),
                 description = reader["description"].ToString()
             }).ToArray();
        }

        public void CreateRole(string role_name, string description)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@role_name", role_name),
                new NpgsqlParameter("@description", description),
            };

            var rowsAffected =  _repository.Execute(_sql.CreateRole, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Роль добавлена!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        public void DeleteRole(int ID)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@ID", ID),
            };

            var rowsAffected = _repository.Execute(_sql.DeleteRole, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Роль удалена!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
