using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CSWT.src.core.db
{
    public class DatabaseException : Exception
    {
        public DatabaseException(string message) : base(message) { }
        public DatabaseException(string message, Exception inner) : base(message, inner) { }
    }

    public class DatabaseRepository
    {
        private ConnectionSettings _settings;

        public DatabaseRepository()
        {
            _settings = ConnectionUtils.LoadSettings();
        }

        public void UpdateConnection()
        {
            _settings = ConnectionUtils.LoadSettings();
        }

        public List<T> Query<T>(
            string sql,
            Func<NpgsqlDataReader, T> mapper,
            params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_settings.ToConnectionString()))
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();

                    var results = new List<T>();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            results.Add(mapper(reader));
                    }

                    return results;
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при выполнении запроса к базе данных", ex);
                return new List<T>();
            }
        }

        public int Execute(string sql, params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_settings.ToConnectionString()))
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при выполнении команды в базе данных", ex);
                return 0; 
            }
        }

        public async Task<int> ExecuteAsync(string sql, params NpgsqlParameter[] parameters)
        {
            using (var connection = new NpgsqlConnection(_settings.ToConnectionString()))
            {
                await connection.OpenAsync();

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    return await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, Func<NpgsqlDataReader, T> mapper, params NpgsqlParameter[] parameters)
        {
            using (var connection = new NpgsqlConnection(_settings.ToConnectionString()))
            {
                await connection.OpenAsync();

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        var results = new List<T>();
                        while (await reader.ReadAsync())
                        {
                            results.Add(mapper(reader));
                        }
                        return results;
                    }
                }
            }
        }

        private void ShowError(string message, Exception ex)
        {
            string fullMessage = $"{message}:\n\n{ex.Message}";
            MessageBox.Show(fullMessage, "Ошибка базы данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}