using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.dto;
using CSWT.src.shared.services;
using CSWT.src.shared.services.user;

namespace CSWT.src.modules.Users
{
    public class UsersModel
    {
        UserService _userService;
        public UsersModel(UserService userService)
        {
            _userService = userService; 
        }

        public UserDTO[] GetUsers()
        {
            return _userService.GetUsers();
        }

        public void CreateUser(string username, string password, string first_name, string last_name, string email, string phone_number, int role_id)
        {
            _userService.CreateUser(username, password, first_name, last_name, email, phone_number, role_id);
        }

        public void DeleteUser(int ID)
        {
            _userService.DeleteUser(ID);    
        }
    }
}
