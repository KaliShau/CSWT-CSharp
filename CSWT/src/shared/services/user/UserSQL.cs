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

        public string GetUserByID = @"
            SELECT u.*, r.role_name from users u JOIN roles r ON r.ID = u.role_id WHERE ID = @ID;
        ";

        public string CreateUser = @"
            INSERT INTO users (username, password, first_name, last_name, email, phone_number, role_id) VALUES
            (@username, @password, @first_name, @last_name, @email, @phone_number, @role_id);
        ";

        public string UpdateUser = @"
            UPDATE users SET username = @username, password = @password, first_name = @first_name, last_name = @last_name, email = @email, phone_number = @phone_number, role_id = @role_id);
        ";

        public string GetUsers = @"
            SELECT u.*, r.role_name from users u JOIN roles r ON r.ID = u.role_id;
        ";

        public string DeleteUser = @"
            BEGIN;

            UPDATE Reports SET user_id = NULL WHERE user_id = @ID;
            UPDATE Comments SET user_id = NULL WHERE user_id = @ID;
            UPDATE Tickets SET client_id = NULL WHERE client_id = @ID;
            UPDATE Tickets SET assigned_to = NULL WHERE assigned_to = @ID;
            UPDATE User_Departments SET user_id = NULL WHERE user_id = @ID;

            DELETE FROM Users WHERE ID = @ID;

            COMMIT;
        ";
    }
}
