using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core;

namespace CSWT.src.modules.UpdateTicket
{
    public class UpdateTicketController
    {
        UpdateTicketModel _model;
        SessionContext _sessionContext;
        public UpdateTicketController(UpdateTicketModel model, SessionContext sessionContext)
        {
            _model = model;
            _sessionContext = sessionContext;
        }

        public void loadTicket(Label createdAtLabel, TextBox titleBox, TextBox descriptionBox, TextBox solutionBox, ComboBox proirityBox, ComboBox statusBox)
        {
            var ticket = _model.GetTicketByID(_sessionContext.ticket_id);
            var statuses = _model.GetStatuses();
            var priorities = _model.GetPriotities();

            createdAtLabel.Text = Convert.ToString(ticket.created_at);
            titleBox.Text = ticket.title;
            descriptionBox.Text = ticket.description;
            solutionBox.Text = ticket.solution;

            proirityBox.DataSource = priorities;
            proirityBox.DisplayMember = "priority_name";
            proirityBox.ValueMember = "ID";
            proirityBox.SelectedValue = ticket.priority_id;

            statusBox.DataSource = statuses;
            statusBox.DisplayMember = "status_name";
            statusBox.ValueMember = "ID";
            statusBox.SelectedValue = ticket.status_id;
        }
    }
}
