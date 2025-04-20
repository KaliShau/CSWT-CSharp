using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core;
using CSWT.src.core.db;
using CSWT.src.core.form;
using CSWT.src.modules.Ticket;
using CSWT.src.modules.UpdateTicket;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.AssignedTickets
{
    public class AssignedTicketsController
    {
        AssignedTicketsModel _model;
        UserContext _userContext;
        SessionContext _sessionContext;
        FormManager _formManager;
        FormContext _formContext;
        public AssignedTicketsController(AssignedTicketsModel model, UserContext userContext, SessionContext sessionContext, FormManager formManager , FormContext formContext)
        {
            _model = model;
            _userContext = userContext;
            _sessionContext = sessionContext;
            _formManager = formManager;
            _formContext = formContext;
        }
        public void OpenTicket(int id)
        {
            _sessionContext.ticket_id = id;
            _sessionContext.is_ticket_update = false;
            _formManager.OpenChidrenForm<UpdateTicketForm>(_formContext.childrenPanel);
        }

        public void OpenComments(int id)
        {
            _sessionContext.ticket_id = id;
            _sessionContext.is_ticket_update = false;
            _formManager.OpenChidrenForm<TicketForm>(_formContext.childrenPanel);
        }

        public void InitTicketsList(ListView TicketsList)
        {
            TicketsList.View = View.Details;
            TicketsList.FullRowSelect = true;

            TicketsList.Columns.Add("ID", 50);
            TicketsList.Columns.Add("Дата создания", 120);
            TicketsList.Columns.Add("Заголовок", 200);
            TicketsList.Columns.Add("Описание", 200);
            TicketsList.Columns.Add("Создатель заявки", 200);
            TicketsList.Columns.Add("Статус", 100);
            TicketsList.Columns.Add("Приоритет", 100);
            TicketsList.Columns.Add("Назначено", 150);
            TicketsList.Columns.Add("Решение", 150);
            TicketsList.Columns.Add("Дата закрытия", 150);
        }

        public void AddTicketsToListView(ListView TicketsList)
        {
            var tickets = _model.GetAssignedTickets(_userContext.CurrentUser.ID);

            this.AddListView(tickets, TicketsList);
        }

        public void Search(ListView TicketsList, string searchTerm)
        {
            var tickets = _model.GetAssignedTicketsSearch(_userContext.CurrentUser.ID, searchTerm);
            this.AddListView(tickets, TicketsList);
        }

        private void AddListView(TicketWithJoinDTO[] tickets, ListView TicketsList)
        {
            TicketsList.Items.Clear();

            foreach (var ticket in tickets)
            {
                var item = new ListViewItem(ticket.ID.ToString());

                item.SubItems.Add(ticket.created_at.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(ticket.title);
                item.SubItems.Add(ticket.description);
                item.SubItems.Add(ticket.client_name);
                item.SubItems.Add(ticket.status_name);
                item.SubItems.Add(ticket.priority_name);
                item.SubItems.Add(ticket.assigned_user_name ?? "Не назначено");
                item.SubItems.Add(ticket.solution ?? "Еще нет решения");
                item.SubItems.Add(ticket.closed_at.HasValue ? ticket.closed_at.Value.ToString("dd.MM.yyyy HH:mm") : "Не закрыта");

                item.Tag = ticket;

                TicketsList.Items.Add(item);
            }
        }

    }
}
