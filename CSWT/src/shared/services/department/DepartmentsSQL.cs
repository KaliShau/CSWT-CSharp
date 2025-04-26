namespace CSWT.src.shared.services.department
{
    public class DepartmentsSQL
    {
        public string GetDepartments = @"
             SELECT * FROM Departments;
        ";

        public string GetUserDepartments = @"
            SELECT d.* FROM Departments d
            JOIN User_Departments ud ON d.id = ud.department_id
            WHERE ud.user_id = @user_id;
        ";

        public string DeleteDepartment = @"
             DELETE FROM Departments WHERE ID = @ID;
        ";

        public string AddDepartmentToUser = @"
                INSERT INTO User_Departments (user_id, department_id)
                VALUES (@userId, @departmentId)
                ON CONFLICT (user_id, department_id) DO NOTHING";

        public string RemoveDepartmentFromUser = @"
            DELETE FROM User_Departments
            WHERE user_id = @userId AND department_id = @departmentId";

        public string CreateDepartment = @"
            INSERT INTO Departments (department_name, description) VALUES 
            (@department_name, @description);
        ";

        public string GetDepartmentByID = @"
            SELECT * FROM Departments WHERE ID = @ID;
        ";
    }
}
