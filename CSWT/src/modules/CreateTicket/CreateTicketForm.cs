using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.CreateTicket
{
    public partial class CreateTicketForm : Form
    {
        CreateTicketController _controller;
        public CreateTicketForm(CreateTicketController controller)
        {
            InitializeComponent();
            _controller = controller;
            _controller.PrioritiesAddBox(priorityBox);
        }

        private void createTicketButton_Click(object sender, EventArgs e)
        {
            int priorityID = Convert.ToInt32(priorityBox.SelectedValue);
            _controller.CreateTicket(priorityID);
        }
    }
}
