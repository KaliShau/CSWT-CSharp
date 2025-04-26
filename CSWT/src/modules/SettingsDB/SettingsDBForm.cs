using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core.db;

namespace CSWT.src.modules.SettingsDB
{
    public partial class SettingsDBForm : Form
    {
        SettingsDBController _controller;
        public SettingsDBForm(SettingsDBController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.LoadData(passwordBox, hostBox, dbNameBox, userBox, portBox);
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            ConnectionUtils.TestConnection(ConnectionUtils.LoadSettings());
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _controller.SaveData(passwordBox, hostBox, dbNameBox, userBox, portBox);

        }
    }
}
