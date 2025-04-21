using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.modules.Roles;
using CSWT.src.shared.dto;
using System.Windows.Forms;

namespace CSWT.src.modules.Users
{
    public class UsersController
    {
        UsersModel _model;
        public UsersController(UsersModel model)
        {
            _model = model;
        }

        public void InitList(ListView UsersList)
        {
            UsersList.View = View.Details;
            UsersList.FullRowSelect = true;

            UsersList.Columns.Add("ID", 50);
            UsersList.Columns.Add("Дата создания", 100);
            UsersList.Columns.Add("Логин", 100);
            UsersList.Columns.Add("Пароль", 100);
            UsersList.Columns.Add("Имя", 100);
            UsersList.Columns.Add("Фамилия", 100);
            UsersList.Columns.Add("Email", 100);
            UsersList.Columns.Add("Телефон", 100);
            UsersList.Columns.Add("Роль", 100);
        }

        public void GetUsers(ListView UsersList)
        {
            var users = _model.GetUsers();
            DisplayUsers(users, UsersList);
        }

        public void DisplayUsers(UserDTO[] users, ListView UsersList)
        {
            UsersList.Items.Clear();

            foreach (var user in users)
            {
                var item = new ListViewItem(user.ID.ToString());

                item.SubItems.Add(user.created_at.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(user.username);
                item.SubItems.Add(user.password);
                item.SubItems.Add(user.first_name);
                item.SubItems.Add(user.last_name);
                item.SubItems.Add(user.email);
                item.SubItems.Add(user.phone_number);
                item.SubItems.Add(user.role_name);

                item.Tag = user;
                UsersList.Items.Add(item);
            }

        }

        //public void CreateUser(TextBox nameBox, TextBox descriptionBox)
        //{
        //    string name = nameBox.Text;
        //    string description = descriptionBox.Text;

        //    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
        //    {
        //        return;
        //    }

        //    _model.CreateRole(name, description);
        //}

        public void DeleteRole(int ID)
        {
            _model.DeleteUser(ID);
        }
    }
}
