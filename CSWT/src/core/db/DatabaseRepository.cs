using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CSWT.src.core.db
{
    public class DatabaseRepository
    {
        private readonly string _connectionString = "Server=localhost; User Id=postgres ;Password=root;database=cswt;";

        public DatabaseRepository()
        {
        }

        public List<T> Query<T>(
            string sql,
            Func<NpgsqlDataReader, T> mapper,
            params NpgsqlParameter[] parameters)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
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

        public int Execute(string sql, params NpgsqlParameter[] parameters)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            using (var command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}
