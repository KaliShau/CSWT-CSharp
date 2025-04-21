using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.shared.dto;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.Roles
{
    public class RolesController
    {
        RolesModel _model;
        public RolesController(RolesModel model)
        {
            _model = model;
        }

        public void InitList(ListView RolesList)
        {
            RolesList.View = View.Details;
            RolesList.FullRowSelect = true;

            RolesList.Columns.Add("ID", 50);
            RolesList.Columns.Add("Дата создания", 120);
            RolesList.Columns.Add("Наименование", 200);
            RolesList.Columns.Add("Описание", 300);
        }

        public void GetRoles(ListView RolesList)
        {
            var roles = _model.GetRoles();
            DisplayRoles(roles, RolesList);
        }

        public void DisplayRoles(RoleDTO[] roles, ListView RolesList)
        {
            RolesList.Items.Clear();

            foreach (var role in roles)
            {
                var item = new ListViewItem(role.ID.ToString());

                item.SubItems.Add(role.created_at.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(role.role_name);
                item.SubItems.Add(role.description);

                item.Tag = role;
                RolesList.Items.Add(item);
            }

        }

        public void CreateRole(TextBox nameBox, TextBox descriptionBox)
        {
            string name = nameBox.Text;
            string description = descriptionBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description)) {
                return;
            }

            _model.CreateRole(name, description);
        }

        public void DeleteRole(int ID)
        {
            _model.DeleteRole(ID);
        }

    }
}
