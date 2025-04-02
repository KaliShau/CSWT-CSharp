using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.dto
{
    public class RoleDTO
    {
        public int ID { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string role_name {  get; set; }
        public string description { get; set; }
    }
}
