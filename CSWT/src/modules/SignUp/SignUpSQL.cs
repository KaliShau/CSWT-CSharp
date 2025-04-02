using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.modules.SignUp
{
    public class SignUpSQL
    {
        public string signIn = @"
            INSERT INTO users (username, password, first_name, email, role_id) VALUES
            (@username, @password, @first_name, @email, @role_id);
        ";
    }
}
