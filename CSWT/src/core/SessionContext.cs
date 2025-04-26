using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.core
{
    public class SessionContext
    {
        // Tickets
        public int ticket_id {  get; set; }
        public bool is_ticket_update { get; set; } 
        
        // Users
        public int user_id{ get; set; }
        public bool is_admin { get; set; } = false;
    }
}
