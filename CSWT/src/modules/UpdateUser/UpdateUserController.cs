using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core;
using CSWT.src.core.db;
using CSWT.src.shared.dto;
using CSWT.src.shared.services.department;

namespace CSWT.src.modules.UpdateUser
{
    public class UpdateUserController
    {
        UpdateUserModel _model;
        SessionContext _sessionContext;
        UserContext _userContext;
        public UpdateUserController(UpdateUserModel model, SessionContext sessionContext, UserContext userContext)
        {
            _model = model;
            _sessionContext = sessionContext;
            _userContext = userContext;
        }

        public void InitList(ListView DepartmentList)
        {
            DepartmentList.View = View.Details;
            DepartmentList.FullRowSelect = true;

            DepartmentList.Columns.Add("ID", 50);
            DepartmentList.Columns.Add("Дата создания", 120);
            DepartmentList.Columns.Add("Наименование", 200);
            DepartmentList.Columns.Add("Описание", 300);
        }

        public void LoadDepartments(ListView DepartmentList)
        {
            var userDepartments = _model.GetUserDepartments(_sessionContext.user_id);
            DisplayDepartments(userDepartments, DepartmentList);
        }

        public void AddDepartments(ComboBox departmentBox)
        {

            int departmentId = Convert.ToInt32(departmentBox.SelectedValue);

            var department = _model.GetDepartmentById(departmentId);

            if (department == null)
            {
                MessageBox.Show("Отдел не найдена");
                return;
            }

            _model.AddUserDepartments(_sessionContext.user_id, department.ID);
        }

        public void RemoveDepartments(int ID)
        {

            _model.RemoveUserDepartments(_sessionContext.user_id, ID);
        }

        public void DisplayDepartments(DepartmentsDTO[] roles, ListView DepartmentList)
        {
            DepartmentList.Items.Clear();

            foreach (var role in roles)
            {
                var item = new ListViewItem(role.ID.ToString());

                item.SubItems.Add(role.created_at.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(role.department_name);
                item.SubItems.Add(role.description);

                item.Tag = role;
                DepartmentList.Items.Add(item);
            }

        }

        public void InitDepartmentBox(ComboBox departmentBox)
        {
            var departments = _model.GetDepartments();

            departmentBox.DataSource = departments;
            departmentBox.DisplayMember = "department_name";
            departmentBox.ValueMember = "ID";
        }

        public void InitRoleBox(ComboBox roleBox, int selectedValue)
        {
            var roles = _model.GetRoles();

            roleBox.DataSource = roles;
            roleBox.DisplayMember = "role_name";
            roleBox.ValueMember = "ID";
            roleBox.SelectedValue = selectedValue;
        }

        public void initData(TextBox usernameBox, TextBox passwordBox, TextBox firstNameBox, TextBox lastNameBox, TextBox emailBox, TextBox phoneNumbetBox, ComboBox roleBox, Label roleLabel, Panel roleLine)
        {
            if (_sessionContext.is_admin == false)
            {
                roleBox.Visible = false;
                roleLabel.Visible = false;
                roleLine.Visible = false;
            }

            var user = _model.GetUserByID(_sessionContext.user_id);

            this.InitRoleBox(roleBox, user.role_id);

            usernameBox.Text = user.username;
            passwordBox.Text = user.password;
            firstNameBox.Text = user.first_name;
            lastNameBox.Text = user.last_name;
            emailBox.Text = user.email;
            phoneNumbetBox.Text = user.phone_number;


        }

        public void UpdateUser(TextBox usernameBox, TextBox passwordBox, TextBox firstNameBox, TextBox lastNameBox, TextBox emailBox, TextBox phoneNumbetBox, ComboBox roleBox)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string email = emailBox.Text;
            string phone = phoneNumbetBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(firstName))
            {
                return;
            }

            int roleId = Convert.ToInt32(roleBox.SelectedValue);

            var role = _model.GetRoleById(roleId);

            if (role == null)
            {
                MessageBox.Show("Роль не найдена");
                return;
            }

            _model.UpdateUser(username, password, firstName, lastName, email, phone, role.ID, _sessionContext.user_id);

            if (_userContext.CurrentUser.ID == _sessionContext.user_id)
            {
                _userContext.CurrentUser = _model.GetUserByID(_userContext.CurrentUser.ID);
            }
        }


    }
}
