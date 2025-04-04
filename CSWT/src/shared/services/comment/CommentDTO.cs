using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.services.comment
{
    public class CommentDTO
    {
        public int ID { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string comment_text { get; set; }
        public int ticket_id{ get; set; }
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}
