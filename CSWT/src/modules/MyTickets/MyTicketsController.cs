using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core.db;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.MyTickets
{
    public class MyTicketsController
    {
        MyTicketsModel _model;
        UserContext _userContext;
        public MyTicketsController(MyTicketsModel model, UserContext userContext)
        {
            _model = model;
            _userContext = userContext;
        }

        public void InitTicketsList(ListView TicketsList)
        {
            TicketsList.View = View.Details;
            TicketsList.FullRowSelect = true;

            TicketsList.Columns.Add("ID", 50);
            TicketsList.Columns.Add("Дата создания", 120);
            TicketsList.Columns.Add("Заголовок", 200);
            TicketsList.Columns.Add("Описание", 200);
            TicketsList.Columns.Add("Статус", 100);
            TicketsList.Columns.Add("Приоритет", 100);
            TicketsList.Columns.Add("Назначено", 150);
            TicketsList.Columns.Add("Решение", 150);
            TicketsList.Columns.Add("Дата закрытия", 150);
        }

        public void AddTicketsToListView(ListView TicketsList)
        {
            var tickets = _model.GetMyTickets(_userContext.CurrentUser.ID);

            this.AddListView(tickets, TicketsList);

        }

        public void Search(ListView TicketsList, string searchTerm)
        {
            var tickets = _model.GetMyTicketsSearch(_userContext.CurrentUser.ID, searchTerm);
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
