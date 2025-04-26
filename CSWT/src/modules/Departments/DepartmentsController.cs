using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.modules.Roles;
using CSWT.src.shared.dto;
using System.Windows.Forms;
using CSWT.src.shared.services.department;

namespace CSWT.src.modules.Departments
{
    public class DepartmentsController
    {
        DepartmentsModel _model;
        public DepartmentsController(DepartmentsModel model)
        {
            _model = model;
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

        public void GetDepartments(ListView DepartmentList)
        {
            var departments = _model.GetDepartments();
            DisplayDepartments(departments, DepartmentList);
        }

        public void DisplayDepartments(DepartmentsDTO[] departments, ListView DepartmentList)
        {
            DepartmentList.Items.Clear();

            foreach (var department in departments)
            {
                var item = new ListViewItem(department.ID.ToString());

                item.SubItems.Add(department.created_at.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(department.department_name);
                item.SubItems.Add(department.description);

                item.Tag = department;
                DepartmentList.Items.Add(item);
            }

        }

        public void CreateDepartment(TextBox nameBox, TextBox descriptionBox)
        {
            string name = nameBox.Text;
            string description = descriptionBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                return;
            }

            _model.CreateDepartment(name, description);
        }

        public void DeleteDepartment(int ID)
        {
            _model.DeleteDepartment(ID);
        }
    }
}
