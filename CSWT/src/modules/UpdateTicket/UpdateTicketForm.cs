using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.UpdateTicket
{
    public partial class UpdateTicketForm : Form
    {
        UpdateTicketController _controller;
        public UpdateTicketForm(UpdateTicketController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.loadTicket(closedAtTextBox, createdAtLabel, titleBox, descriptionBox, solutionBox, priorityBox, statusBox);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            List<Panel> lines = new List<Panel> {titleLine, descriptionLine, solutionLine, priorityLine, statusLine };

            _controller.UpdateTicket(titleBox, descriptionBox, solutionBox, priorityBox, statusBox, lines);
            _controller.loadTicket(closedAtTextBox, createdAtLabel, titleBox, descriptionBox, solutionBox, priorityBox, statusBox);
        }
    }
}
