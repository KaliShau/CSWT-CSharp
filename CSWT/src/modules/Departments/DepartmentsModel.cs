using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.dto;
using CSWT.src.shared.services;
using CSWT.src.shared.services.department;

namespace CSWT.src.modules.Departments
{
    public class DepartmentsModel
    {
        DepartmentsService _departmentService;
        public DepartmentsModel(DepartmentsService departmentsService)
        {
            _departmentService = departmentsService;
        }

        public DepartmentsDTO[] GetDepartments()
        {
            return _departmentService.GetDepartments();
        }

        public void CreateDepartment(string department_name, string description)
        {
            _departmentService.CreateDepartment(department_name, description);
        }

        public void DeleteDepartment(int ID)
        {
            _departmentService.DeleteDepartment(ID);
        }
    }
}
