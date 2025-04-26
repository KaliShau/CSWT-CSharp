using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.dto;
using CSWT.src.shared.services;
using CSWT.src.shared.services.department;
using CSWT.src.shared.services.user;

namespace CSWT.src.modules.UpdateUser
{
    public class UpdateUserModel
    {
        UserService _userService;
        RoleService _roleService;
        DepartmentsService _departmentsService;
        public UpdateUserModel(UserService userService, RoleService roleService, DepartmentsService departmentsService)
        {
            _userService = userService;
            _roleService = roleService;
            _departmentsService = departmentsService;
        }

        public UserDTO GetUserByID(int ID)
        {
           return _userService.GetUserByID(ID);
        }

        public void UpdateUser(string username, string password, string first_name, string last_name, string email, string phone_number, int role_id, int ID)
        {
            _userService.UpdateUser(username, password, first_name, last_name, email, phone_number, role_id, ID);
        }

        public RoleDTO[] GetRoles()
        {
            return _roleService.GetRoles();
        }

        public RoleDTO GetRoleById(int ID)
        {
            return _roleService.GetRoleByID(ID);
        }

        public DepartmentsDTO[] GetDepartments()
        {
            return _departmentsService.GetDepartments();
        }

        public DepartmentsDTO GetDepartmentById(int ID)
        {
            return _departmentsService.GetDepartmentByID(ID);
        }

        public DepartmentsDTO[] GetUserDepartments(int user_id)
        {
            return _departmentsService.GetUserDepartments(user_id);
        }

        public void AddUserDepartments(int user_id, int department_id)
        {
            _departmentsService.AddDepartmentToUser(user_id, department_id);
        }

        public void RemoveUserDepartments(int user_id, int department_id)
        {
            _departmentsService.RemoveDepartmentFromUser(user_id, department_id);
        }
    }
}
