using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.dto;
using CSWT.src.shared.services;

namespace CSWT.src.modules.Roles
{
    public class RolesModel
    {
        RoleService _roleService;
        public RolesModel(RoleService roleService)
        {
            _roleService = roleService;
        }

        public RoleDTO[] GetRoles()
        {
            return _roleService.GetRoles();
        }

        public void CreateRole(string role_name, string description)
        {
            _roleService.CreateRole(role_name, description);
        }

        public void DeleteRole(int ID)
        {
            _roleService.DeleteRole(ID);
        }
    }
}
