using System;
using System.Windows.Forms;
using CSWT.src.shared.services;
using CSWT.src.shared.services.user;

namespace CSWT.src.modules.SignUp
{
    public class SignUpModel
    {
        UserService _userService;
        RoleService _roleService;

        public SignUpModel(UserService userService, RoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        public bool SignUp(string username, string passwrod, string first_name, string email)
        {
            if (_userService.UserExists(username))
            {
                MessageBox.Show("Пользователь с данным логином уже существуют!");
                return false;
            }

            var role = _roleService.GetRoleByRoleName("Client");

            if (role == null)
            {
                return false;
            }

            _userService.SignUp(username, passwrod, first_name, email, role.ID);

            Boolean isSignUp = _userService.UserExists(username);

            return isSignUp;
        }

    }
}
