using System;
using System.Linq;
using System.Windows.Forms;
using CSWT.src.core.db;
using CSWT.src.shared.dto;
using Npgsql;

namespace CSWT.src.shared.services.department
{
    public class DepartmentsService
    {
        DatabaseRepository _repository;
        DepartmentsSQL _sql;
        public DepartmentsService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new DepartmentsSQL();
        }

        public DepartmentsDTO[] GetDepartments()
        {
            return _repository.Query<DepartmentsDTO>(
             _sql.GetDepartments,
             reader => new DepartmentsDTO
             {
                 ID = Convert.ToInt32(reader["ID"]),
                 created_at = Convert.ToDateTime(reader["created_at"]),
                 updated_at = Convert.ToDateTime(reader["updated_at"]),
                 department_name = reader["department_name"].ToString(),
                 description = reader["description"].ToString()
             }).ToArray();
        }

        public DepartmentsDTO GetDepartmentByID(int ID)
        {
            return _repository.Query<DepartmentsDTO>(
             _sql.GetDepartmentByID,
             reader => new DepartmentsDTO
             {
                 ID = Convert.ToInt32(reader["ID"]),
                 created_at = Convert.ToDateTime(reader["created_at"]),
                 updated_at = Convert.ToDateTime(reader["updated_at"]),
                 department_name = reader["department_name"].ToString(),
                 description = reader["description"].ToString()
             }, new NpgsqlParameter("@ID", ID)).SingleOrDefault();
        }

        public void CreateDepartment(string department_name, string description)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@department_name", department_name),
                new NpgsqlParameter("@description", description),
            };

            var rowsAffected = _repository.Execute(_sql.CreateDepartment, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Отдел добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        public void DeleteDepartment(int ID)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@ID", ID),
            };

            var rowsAffected = _repository.Execute(_sql.DeleteDepartment, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Отдел удален!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        public DepartmentsDTO[] GetUserDepartments(int userId)
        {
            return _repository.Query<DepartmentsDTO>(
                _sql.GetUserDepartments,
                reader => new DepartmentsDTO
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    created_at = Convert.ToDateTime(reader["created_at"]),
                    updated_at = Convert.ToDateTime(reader["updated_at"]),
                    department_name = reader["department_name"].ToString(),
                    description = reader["description"].ToString()
                },
                new NpgsqlParameter("user_id", userId)
            ).ToArray();
        }

        public void AddDepartmentToUser(int userId, int departmentId)
        {
            var rowsAffected = _repository.Execute(_sql.AddDepartmentToUser,
                new NpgsqlParameter("@userId", userId),
                new NpgsqlParameter("@departmentId", departmentId));

            if (rowsAffected > 0)
            {
                MessageBox.Show("Отдел добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }

        }

        public void RemoveDepartmentFromUser(int userId, int departmentId)
        {
            var rowsAffected = _repository.Execute(_sql.RemoveDepartmentFromUser,
                new NpgsqlParameter("@userId", userId),
                new NpgsqlParameter("@departmentId", departmentId));

            if (rowsAffected > 0)
            {
                MessageBox.Show("Отдел удален!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}

