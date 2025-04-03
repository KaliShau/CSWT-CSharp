using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.dto;

namespace CSWT.src.core.db
{
    public class UserContext
    {
        public UserDTO CurrentUser { get; set; } = null;
        public bool IsAuthenticated => CurrentUser != null;
    }
}
