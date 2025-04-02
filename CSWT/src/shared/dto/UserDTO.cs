using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.dto
{
    public class UserDTO
    {
        public string ID {  get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone_number { get; set; }
        public int role_id { get; set; }

    }
}
