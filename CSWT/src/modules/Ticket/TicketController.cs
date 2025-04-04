using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core.db;
using CSWT.src.shared.services.comment;
using CSWT.src.shared.services.ticket;
using CSWT.src.shared.utils;

namespace CSWT.src.modules.Ticket
{
    public enum EnumInitTicket
    {
        UpdateSolution,
        NoUpdateSolution
    }
    public class TicketController
    {
         TicketModel _model;
        UserContext _userContext;
        public TicketController(TicketModel model, UserContext userContext)
        {
            _model = model;
            _userContext = userContext;
        }

        public void InitTicket(EnumInitTicket initMode, int ID, TextBox titleBox, TextBox descriptionBox, TextBox assignedBox, TextBox solutionBox, Label createdAtLabel)
        {
            assignedBox.Enabled = false;

            var ticket = _model.GetTicketByID(ID);

            titleBox.Text = ticket.title;
            descriptionBox.Text = ticket.description;
            createdAtLabel.Text = Convert.ToString(ticket.created_at);

            if (ticket.assigned_user_name != null)
            {
                assignedBox.Text = ticket.assigned_user_name;
            }
            else
            {
                assignedBox.Text = "Не назначено";
            }

            if (ticket.solution != null)
            {
                solutionBox.Text = ticket.solution;
            }
            else
            {
                solutionBox.Text = "Нет решения";
            }

            if (initMode == EnumInitTicket.UpdateSolution)
            {
                solutionBox.Enabled = true;
            } else
            {
                solutionBox.Enabled = false;
            }
        }

        public void CreateComment(string comment_text, int ticket_id, Panel commentLine)
        {
            var valid = new ValidField();
            valid.field(comment_text, commentLine);

            if (string.IsNullOrWhiteSpace(comment_text))
            {
                return;
            }

            _model.CreateComment(comment_text, ticket_id, _userContext.CurrentUser.ID);
            MessageBox.Show("Комментарий создан");
        }

        public void InitCommentsList(ListView CommentssList)
        {
            CommentssList.View = View.Details;
            CommentssList.FullRowSelect = true;

            CommentssList.Columns.Add("ID", 50);
            CommentssList.Columns.Add("Дата создания", 120);
            CommentssList.Columns.Add("Содержание", 200);
            CommentssList.Columns.Add("Имя создателя", 200);
            CommentssList.Columns.Add("Фамилия создателя", 100);
            CommentssList.Columns.Add("ID заявки", 100);
        }

        public void AddCommentToList(int ticket_id, ListView CommentsList)
        {
            var comments = _model.GetCommentsByTicketId(ticket_id);

            this.AddListView(comments, CommentsList);
        }

        private void AddListView(CommentDTO[] comments, ListView CommentsList)
        {
            CommentsList.Items.Clear();

            foreach (var comment in comments)
            {
                var item = new ListViewItem(comment.ID.ToString());

                item.SubItems.Add(comment.created_at.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(comment.comment_text);
                item.SubItems.Add(comment.first_name);
                item.SubItems.Add(comment.last_name);
                item.SubItems.Add(Convert.ToString(comment.ticket_id));


                item.Tag = comment;

                CommentsList.Items.Add(item);
            }
        }

    }
}
