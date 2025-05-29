using System;
using System.Windows.Forms;
using CSWT.src.core.db;
using CSWT.src.shared.services.comment;
using CSWT.src.shared.utils;

namespace CSWT.src.modules.Ticket
{
    public enum EnumInitTicket
    {
        Update,
        NoUpdate
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

        public void InitTicket(EnumInitTicket initMode, int ID, TextBox titleBox, TextBox descriptionBox, TextBox solutionBox, Label createdAtLabel, Button updateButton, TextBox priorityBox, TextBox statusBox)
        {
            solutionBox.Enabled = false;
            priorityBox.Enabled = false;
            statusBox.Enabled = false;

            var ticket = _model.GetTicketByID(ID);

            priorityBox.Text = ticket.priority_name;
            statusBox.Text = ticket.status_name;
            titleBox.Text = ticket.title;
            descriptionBox.Text = ticket.description;
            createdAtLabel.Text = Convert.ToString(ticket.created_at);

            if (ticket.solution != null)
            {
                solutionBox.Text = ticket.solution;
            }
            else
            {
                solutionBox.Text = "Нет решения";
            }

            if (initMode == EnumInitTicket.Update)
            {
                titleBox.Enabled = true;
                descriptionBox.Enabled = true;
                updateButton.Visible = true;
            }
            else
            {
                titleBox.Enabled = false;
                descriptionBox.Enabled = false;
                updateButton.Visible = false;
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

        public void DeleteCommentByIdAndUserId(int ID, int ticket_id, ListView CommentsList)
        {
            _model.DeleteComment(ID, _userContext.CurrentUser.ID);

            var comments = _model.GetCommentsByTicketId(ticket_id);

            this.AddListView(comments, CommentsList);
        }

        public void UpdateTicket(string title, string description, int ID)
        {
            _model.UpdateTicket(title, description, ID);
        }

        public void SaveToDocx(int ID)
        {
            var ticket = _model.GetTicketByID(ID);
            var comments = _model.GetCommentsByTicketId(ID);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                FileName = $"Заявка_{ticket.ID}_{DateTime.Now:yyyyMMdd_HHmm}.docx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    new SaveToFile().SaveTicketToDocx(saveFileDialog.FileName, ticket, comments);
                    MessageBox.Show("Заявка успешно сохранена!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении заявки: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Print(int ID)
        {
            var printer = new PrintTicket();

            var ticket = _model.GetTicketByID(ID);
            var comments = _model.GetCommentsByTicketId(ID);

            printer.Print(ticket, comments);
        }
    }
}
