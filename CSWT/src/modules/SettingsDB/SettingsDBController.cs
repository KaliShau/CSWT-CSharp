using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core.db;

namespace CSWT.src.modules.SettingsDB
{
    public class SettingsDBController
    {
        DatabaseRepository _databaseRepository;
        public SettingsDBController(DatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        public void LoadData(TextBox passwordBox, TextBox hostBox, TextBox dbNameBox, TextBox userBox, TextBox portBox)
        {
            ConnectionSettings data = ConnectionUtils.LoadSettings();

            passwordBox.Text = data.Password;
            hostBox.Text = data.Host;
            dbNameBox.Text = data.Database;
            userBox.Text = data.Username;
            portBox.Text = data.Port;
        }

        public void SaveData(TextBox passwordBox, TextBox hostBox, TextBox dbNameBox, TextBox userBox, TextBox portBox)
        {
            var settings = new ConnectionSettings();
            settings.Password = passwordBox.Text;
            settings.Host = hostBox.Text;
            settings.Database = dbNameBox.Text;
            settings.Username = userBox.Text;
            settings.Port = portBox.Text;

            ConnectionUtils.SaveSettings(settings);
            _databaseRepository.UpdateConnection();
        }
    }
}
