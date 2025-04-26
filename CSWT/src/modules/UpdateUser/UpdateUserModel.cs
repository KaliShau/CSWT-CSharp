using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.dto;
using CSWT.src.shared.services.user;

namespace CSWT.src.modules.UpdateUser
{
    public class UpdateUserModel
    {
        UserService _userService;
        public UpdateUserModel(UserService userService)
        {
            _userService = userService;
        }

        public UserDTO GetUserByID(int ID)
        {
           return _userService.GetUserByID(ID);
        }

        public void UpdateUser(string username, string password, string first_name, string last_name, string email, string phone_number, int role_id)
        {
            _userService.UpdateUser(username, password, first_name, last_name, email, phone_number, role_id);
        }
    }
}
