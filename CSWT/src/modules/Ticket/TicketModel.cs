using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.comment;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.Ticket
{
    public class TicketModel
    {
        TicketService _ticketService;
        CommentService _commentService;

        public TicketModel(TicketService ticketService, CommentService commentService)
        {
            _ticketService = ticketService;
            _commentService = commentService;
        }

        public TicketWithJoinDTO GetTicketByID(int ID)
        {
            return _ticketService.GetTicketByID(ID);
        }

        public void CreateComment(string comment_text, int ticket_id, int user_id)
        {
            _commentService.CreateComment(comment_text, ticket_id, user_id);
        }

        public CommentDTO[] GetCommentsByTicketId(int ticket_id)
        {
            return _commentService.GetCommentsByTicketId(ticket_id);
        }
    }
}
