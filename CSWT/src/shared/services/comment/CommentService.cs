using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.db;
using CSWT.src.shared.services.priority;
using Npgsql;

namespace CSWT.src.shared.services.comment
{
    public class CommentService
    {
        DatabaseRepository _repository;
        CommentSQL _sql;
        public CommentService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new CommentSQL();
        }

        public void CreateComment(string comment_text, int ticket_id, int user_id)
        {
            _repository.Execute(_sql.CreateComment, 
                new NpgsqlParameter("@comment_text", comment_text),
                new NpgsqlParameter("@ticket_id", ticket_id),
                new NpgsqlParameter("@user_id", user_id)
                );
        }

        public CommentDTO[] GetCommentsByTicketId(int ticket_id)
        {
            return _repository.Query<CommentDTO>(
            _sql.GetCommentsByTicketId,
            reader => new CommentDTO
            {
                ID = Convert.ToInt32(reader["ID"]),
                created_at = Convert.ToDateTime(reader["created_at"]),
                updated_at = Convert.ToDateTime(reader["updated_at"]),
                comment_text = reader["comment_text"].ToString(),
                first_name = reader.IsDBNull(reader.GetOrdinal("first_name")) ? null : reader.GetString(reader.GetOrdinal("first_name")),
                last_name = reader.IsDBNull(reader.GetOrdinal("last_name")) ? null : reader.GetString(reader.GetOrdinal("last_name")),
                ticket_id = Convert.ToInt32(reader["ticket_id"]),
            }, new NpgsqlParameter("@ticket_id", ticket_id)).ToArray();

        }
    }
}
