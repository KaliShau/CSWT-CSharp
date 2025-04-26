using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core.db;
using CSWT.src.modules.SignUp;
using CSWT.src.shared.dto;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CSWT.src.shared.services.user
{
    public class UserService
    {
        DatabaseRepository _repository;
        UserSQL _sql;
        public UserService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new UserSQL();
        }
        public bool UserExists(string username)
        {

            var count = _repository.Query<int>(
                _sql.UserExists,
                reader => reader.GetInt32(0),
                new NpgsqlParameter("@username", username)
            ).FirstOrDefault();

            return count > 0;
        }

        public void SignUp(string username, string password, string first_name, string email, int role_id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password),
                new NpgsqlParameter("@first_name", first_name),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@role_id",  role_id)
            };

            _repository.Execute(_sql.SignUp, parameters);
        }

        public void CreateUser(string username, string password, string first_name, string last_name, string email, string phone_number, int role_id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password),
                new NpgsqlParameter("@first_name", first_name),
                new NpgsqlParameter("@last_name", last_name),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@phone_number", phone_number),
                new NpgsqlParameter("@role_id",  role_id)
            };

            var rowsAffected = _repository.Execute(_sql.CreateUser, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Пользователь добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        public void UpdateUser(string username, string password, string first_name, string last_name, string email, string phone_number, int role_id, int ID)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password),
                new NpgsqlParameter("@first_name", first_name),
                new NpgsqlParameter("@last_name", last_name),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@phone_number", phone_number),
                new NpgsqlParameter("@role_id",  role_id),
                new NpgsqlParameter("@ID",  ID)
            };

            var rowsAffected = _repository.Execute(_sql.UpdateUser, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Пользователь обновлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        public void DeleteUser(int ID)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@ID",  ID)
            };

            var rowsAffected = _repository.Execute(_sql.DeleteUser, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Пользователь удален!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        public UserDTO GetUserByID(int ID)
        {

            return _repository.Query<UserDTO>(_sql.GetUserByID, reader => new UserDTO
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                username = reader["username"].ToString(),
                password = reader["password"].ToString(),
                email = reader["email"].ToString(),
                first_name = reader["first_name"].ToString(),
                last_name = reader["last_name"].ToString(),
                phone_number = reader["phone_number"].ToString(),
                role_id = Convert.ToInt32(reader["role_id"]),
                role_name = reader["role_name"].ToString()
            }, new NpgsqlParameter("ID", ID)).SingleOrDefault();
        }

        public UserDTO[] GetUsers()
        {

            return _repository.Query<UserDTO>(_sql.GetUsers, reader => new UserDTO
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                username = reader["username"].ToString(),
                password = reader["password"].ToString(),
                email = reader["email"].ToString(),
                first_name = reader["first_name"].ToString(),
                last_name = reader["last_name"].ToString(),
                phone_number = reader["phone_number"].ToString(),
                role_id = Convert.ToInt32(reader["role_id"]),
                role_name = reader["role_name"].ToString()
            }).ToArray();
        }

        public UserDTO SignIn(string username, string password)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password),
            };

            return _repository.Query<UserDTO>(_sql.SignIn, reader => new UserDTO
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                username = reader["username"].ToString(),
                password = reader["password"].ToString(),
                email = reader["email"].ToString(),
                first_name = reader["first_name"].ToString(),
                last_name = reader["last_name"].ToString(),
                phone_number = reader["phone_number"].ToString(),
                role_id = Convert.ToInt32(reader["role_id"]),
                role_name = reader["role_name"].ToString()
            }, parameters).FirstOrDefault();
        }
    }
}
