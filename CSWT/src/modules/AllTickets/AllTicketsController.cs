using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.db;
using CSWT.src.core.form;
using CSWT.src.core;
using CSWT.src.modules.MyTickets;
using CSWT.src.modules.Ticket;
using CSWT.src.shared.services.ticket;
using System.Windows.Forms;

namespace CSWT.src.modules.AllTickets
{
    public class AllTicketsController
    {
        AllTicketsModel _model;
        UserContext _userContext;
        FormManager _formManager;
        FormContext _formContext;
        SessionContext _sessionContext;
        public AllTicketsController(AllTicketsModel model, UserContext userContext, FormManager formManager, FormContext formContext, SessionContext sessionContext)
        {
            _model = model;
            _userContext = userContext;
            _formManager = formManager;
            _formContext = formContext;
            _sessionContext = sessionContext;
        }

        public void OpenTicket(int id)
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
            var tickets = _model.GetNewTickets();

            this.AddListView(tickets, TicketsList);
        }

        public void Search(ListView TicketsList, string searchTerm)
        {
            var tickets = _model.GetNewTicketsSearch(searchTerm);
            this.AddListView(tickets, TicketsList);
        }

        public void AssignedTicket(int ticket_id, ListView TicketsList)
        {
            _model.AssignedTickets(ticket_id, _userContext.CurrentUser.ID);
            this.AddTicketsToListView(TicketsList);
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
                item.SubItems.Add(ticket.closed_at.ToString("dd.MM.yyyy HH:mm") ?? "Не закрыта");

                item.Tag = ticket;

                TicketsList.Items.Add(item);
            }
        }
    }
}
