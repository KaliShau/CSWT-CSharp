using System;
using System.Windows.Forms;
using CSWT.src.core;

namespace CSWT.src.modules.Ticket
{
    public partial class TicketForm : Form
    {
        TicketController _controller;
        int _ticket_id;
        public TicketForm(TicketController controller, SessionContext sessionContext)
        {
            InitializeComponent();
            _controller = controller;
            _ticket_id = sessionContext.ticket_id;

            _controller.InitTicket(EnumInitTicket.NoUpdateSolution, _ticket_id, titleBox, descriptionBox, assignedBox, solutionBox, createdAtLabel);
            _controller.InitCommentsList(CommentsList);
            _controller.AddCommentToList(_ticket_id, CommentsList);
        }

        private void createCommentButton_Click(object sender, EventArgs e)
        {
            _controller.CreateComment(commentBox.Text, _ticket_id, commentLine);
            _controller.AddCommentToList(_ticket_id, CommentsList);
        }
    }
}
