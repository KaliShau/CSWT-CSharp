using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.services.ticket
{
    public class TicketDTO
    {
        public int ID { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string solution { get; set; }
        public DateTime closed_at { get; set; }
        public int client_id { get; set; }
        public int priority_id { get; set; }
        public int status_id { get; set; }
        public int assigned_to {  get; set; }


    }
}
