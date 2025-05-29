using System;
using System.Windows.Forms;
using CSWT.src.core;

namespace CSWT.src.modules.Ticket
{
    public partial class TicketForm : Form
    {
        TicketController _controller;
        SessionContext _sessionContext;
        int _selectedCommentId;
        public TicketForm(TicketController controller, SessionContext sessionContext)
        {
            InitializeComponent();
            _controller = controller;
            _sessionContext = sessionContext;

            if (_sessionContext.is_ticket_update == true)
            {
                _controller.InitTicket(EnumInitTicket.Update, _sessionContext.ticket_id, titleBox, descriptionBox, solutionBox, createdAtLabel, updateButton, priorityBox, statusBox);
            }
            else
            {
                _controller.InitTicket(EnumInitTicket.NoUpdate, _sessionContext.ticket_id, titleBox, descriptionBox, solutionBox, createdAtLabel, updateButton, priorityBox, statusBox);
            }
            _controller.InitCommentsList(CommentsList);
            _controller.AddCommentToList(_sessionContext.ticket_id, CommentsList);
        }

        private void createCommentButton_Click(object sender, EventArgs e)
        {
            _controller.CreateComment(commentBox.Text, _sessionContext.ticket_id, commentLine);
            _controller.AddCommentToList(_sessionContext.ticket_id, CommentsList);
        }

        private void CommentsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTest = CommentsList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedCommentId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);

                    contextMenuStrip1.Show(CommentsList, e.Location);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteCommentByIdAndUserId(_selectedCommentId, _sessionContext.ticket_id, CommentsList);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string title = titleBox.Text;
            string description = descriptionBox.Text;

            _controller.UpdateTicket(title, description, _sessionContext.ticket_id);

            if (_sessionContext.is_ticket_update == true)
            {
                _controller.InitTicket(EnumInitTicket.Update, _sessionContext.ticket_id, titleBox, descriptionBox, solutionBox, createdAtLabel, updateButton, priorityBox, statusBox);
            }
            else
            {
                _controller.InitTicket(EnumInitTicket.NoUpdate, _sessionContext.ticket_id, titleBox, descriptionBox, solutionBox, createdAtLabel, updateButton, priorityBox, statusBox);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.SaveToDocx(_sessionContext.ticket_id);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.Print(_sessionContext.ticket_id);
        }


    }
}
