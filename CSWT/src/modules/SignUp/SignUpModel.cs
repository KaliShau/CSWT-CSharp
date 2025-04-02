using System;
using System.Linq;
using System.Windows.Forms;
using CSWT.src.core.db;
using CSWT.src.shared.services;
using Npgsql;

namespace CSWT.src.modules.SignUp
{
    public class SignUpModel
    {
        DatabaseRepository _repository;
        public SignUpModel(DatabaseRepository repository)
        {
            _repository = repository;
        }

        public bool SignUp(string username, string passwrod, string first_name, string email)
        {
            if (UserExists(username))
            {
                MessageBox.Show("Пользователь с данным логином уже существуют!");
                return false;
            }

            var role = new RoleService(_repository).GetRoleByRoleName("Client");

            if (role == null)
            {
                return false;
            }

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", passwrod),
                new NpgsqlParameter("@first_name", first_name),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("role_id",  role.ID)
            };

            _repository.Execute(new SignUpSQL().signIn, parameters);

            Boolean isSignUp = UserExists(username);

            return isSignUp;
        }

        private bool UserExists(string username)
        {
            const string sql = "SELECT COUNT(1) FROM Users WHERE username = @username";

            var count = _repository.Query<int>(
                sql,
                reader => reader.GetInt32(0),
                new NpgsqlParameter("@username", username)
            ).FirstOrDefault();

            return count > 0;
        }
    }
}
