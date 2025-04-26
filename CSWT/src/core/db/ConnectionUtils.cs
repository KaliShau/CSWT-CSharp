using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CSWT.src.core.db
{
    public static class ConnectionUtils
    {
        private const string SettingsFileName = "pg_connection_settings.json";
        private static readonly string SettingsPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            SettingsFileName);

        // Стандартные настройки по умолчанию
        private static readonly ConnectionSettings DefaultSettings = new ConnectionSettings
        {
            Host = "localhost",
            Port = "5432",
            Database = "cswt",
            Username = "postgres",
            Password = "root"
        };

        // Создаёт файл с настройками по умолчанию, если его нет
        public static void InitializeConnectionFile()
        {
            if (!File.Exists(SettingsPath))
            {
                SaveSettings(DefaultSettings);
            }
        }

        // Загружает настройки из файла
        public static ConnectionSettings LoadSettings()
        {
            InitializeConnectionFile(); // Убедимся, что файл существует

            try
            {
                var json = File.ReadAllText(SettingsPath);
                return JsonSerializer.Deserialize<ConnectionSettings>(json) ?? DefaultSettings;
            }
            catch (Exception)
            {
                return DefaultSettings; // Возвращаем настройки по умолчанию в случае ошибки
            }
        }

        // Сохраняет настройки в файл
        public static void SaveSettings(ConnectionSettings settings)
        {
            try
            {
                var json = JsonSerializer.Serialize(settings, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(SettingsPath, json);
                MessageBox.Show("Данные сохранены!");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Не удалось сохранить настройки подключения", ex);
            }
        }

        // Проверяет валидность подключения
        public static bool TestConnection(ConnectionSettings settings)
        {
            try
            {
                 var connection = new NpgsqlConnection(settings.ToConnectionString());
                connection.Open();
                MessageBox.Show("Успешное подключение!");
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка подключения!");
                return false;
            }
        }

        // Генерирует строку подключения на основе настроек
        public static string GenerateConnectionString(ConnectionSettings settings)
        {
            return $"Host={settings.Host};Port={settings.Port};" +
                   $"Database={settings.Database};Username={settings.Username};" +
                   $"Password={settings.Password}";
        }
    }

    public class ConnectionSettings
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string ToConnectionString() =>
            ConnectionUtils.GenerateConnectionString(this);
    }
}
