using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.services.user
{
    public class UserSQL
    {
        public string UserExists = "SELECT COUNT(1) FROM Users WHERE username = @username;";

        public string SignUp = @"
            INSERT INTO users (username, password, first_name, email, role_id) VALUES
            (@username, @password, @first_name, @email, @role_id);
        ";

        public string SignIn = @"
            SELECT u.*, r.role_name from users u JOIN roles r ON r.ID = u.role_id WHERE username = @username AND password = @password;
        ";
    }
}
