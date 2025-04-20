using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core;
using CSWT.src.shared.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public void loadTicket(TextBox closedAtTextBox, Label createdAtLabel, TextBox titleBox, TextBox descriptionBox, TextBox solutionBox, ComboBox proirityBox, ComboBox statusBox)
        {
            var ticket = _model.GetTicketByID(_sessionContext.ticket_id);
            var statuses = _model.GetStatuses();
            var priorities = _model.GetPriotities();

            createdAtLabel.Text = Convert.ToString(ticket.created_at);
            closedAtTextBox.Text = ticket.closed_at != null ? Convert.ToString(ticket.closed_at) : "Не закрыто";
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

        public void UpdateTicket(TextBox titleBox, TextBox descriptionBox, TextBox solutionBox, ComboBox proirityBox, ComboBox statusBox, List<Panel> lines)
        {
            string title = titleBox.Text;
            string description = descriptionBox.Text;
            string solution = solutionBox.Text;
            int priority = Convert.ToInt32(proirityBox.SelectedValue);
            int status = Convert.ToInt32(statusBox.SelectedValue);

            var valid = new ValidField();
        
            valid.field(titleBox.Text, lines[0]);
            valid.field(descriptionBox.Text, lines[1]);
            valid.field(solutionBox.Text, lines[2]);
            valid.field(proirityBox.Text, lines[3]);
            valid.field(statusBox.Text, lines[4]);

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(solution) || string.IsNullOrWhiteSpace(proirityBox.Text) || string.IsNullOrWhiteSpace(statusBox.Text))
            {
                return;
            }

            var validStatus = _model.GetStatusByID(status);
            if (validStatus == null)
            {
                MessageBox.Show("Статус не найден!");
                return;
            }

            var validPriority = _model.GetPriotitiesByID(priority);
            if (validPriority == null)
            {
                MessageBox.Show("Приоритет не найден!");
                return;
            }

            var closedStatus = _model.GetClosedStatus("Решена");
            var ticket = _model.GetTicketByID(_sessionContext.ticket_id);

            if (closedStatus.ID != ticket.status_id && status == closedStatus.ID)
            {
                _model.UpdateClosedAt(ticket.ID);
            } 

            _model.UpdateTicket(title, description, solution, priority, status, ticket.ID);
        }
    }
}
