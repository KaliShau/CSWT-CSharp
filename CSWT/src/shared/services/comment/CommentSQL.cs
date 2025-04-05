using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.services.comment
{
    public class CommentSQL
    {
        public string CreateComment = @"
            INSERT INTO Comments
            (comment_text, ticket_id, user_id) VALUES
            (@comment_text, @ticket_id, @user_id);
        ";

        public string GetCommentsByTicketId = @"
            SELECT c.*, u.first_name, u.last_name 
            FROM Comments c 
            JOIN Users u ON c.user_id = u.ID 
            WHERE c.ticket_id = @ticket_id; 
        ";

        public string DeleteCommentByIdAndUserId = @"
            DELETE FROM Comments WHERE ID = @ID AND user_id = @user_id;
        ";

    }
}
