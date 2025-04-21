using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.Entities
{
    public partial class EntitiesForm : Form
    {
        EntitiesController _controller;
        public EntitiesForm(EntitiesController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void openRolesButton_Click(object sender, EventArgs e)
        {
            _controller.OpenRoles(childrenPanel);
        }

        private void openStatusesButton_Click(object sender, EventArgs e)
        {
            _controller.OpenStatuses(childrenPanel);
        }

        private void openPrioritiesButton_Click(object sender, EventArgs e)
        {
            _controller.OpenPriorities(childrenPanel);
        }
    }
}
