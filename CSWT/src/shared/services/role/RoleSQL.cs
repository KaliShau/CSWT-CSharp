using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.services.role
{
    public class RoleSQL
    {
        public string GetRoleByRoleName = @"
            SELECT * FROM Roles WHERE role_name = @role_name;
        ";

        public string GetRoleByID = @"
            SELECT * FROM Roles WHERE ID = @ID;
        ";

        public string GetRoles = @"
             SELECT * FROM Roles;
        ";

        public string DeleteRole = @"
             DELETE FROM Roles WHERE ID = @ID;
        ";

        public string CreateRole = @"
            INSERT INTO Roles (role_name, description) VALUES 
            (@role_name, @description);
        ";
    }
}
