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

            _controller.loadTicket(createdAtLabel, titleBox, descriptionBox, solutionBox, priorityBox, statusBox);
        }
    }
}
