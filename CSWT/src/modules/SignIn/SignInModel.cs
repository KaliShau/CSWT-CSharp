using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.dto;
using CSWT.src.shared.services;
using CSWT.src.shared.services.user;

namespace CSWT.src.modules.SignIn
{
    public class SignInModel
    {
        UserService _userService;
        RoleService _roleService;
        public SignInModel(UserService userService, RoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        public UserDTO SignIn(string username, string password)
        {
            var user = _userService.SignIn(username, password);
        
            if (user == null)
            {
                return null;
            }

            return user;
        }
    }
}
