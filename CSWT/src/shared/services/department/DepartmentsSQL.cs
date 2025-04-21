using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.services.department
{
    public class DepartmentsSQL
    {
        public string GetDepartments = @"
             SELECT * FROM Departments;
        ";

        public string DeleteDepartment = @"
             DELETE FROM Departments WHERE ID = @ID;
        ";

        public string CreateDepartment = @"
            INSERT INTO Departments (department_name, description) VALUES 
            (@department_name, @description);
        ";
    }
}
