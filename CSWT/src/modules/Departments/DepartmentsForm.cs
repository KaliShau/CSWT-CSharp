using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.modules.Roles;

namespace CSWT.src.modules.Departments
{
    public partial class DepartmentsForm : Form
    {
        DepartmentsController _controller;
        int _selectedId;
        public DepartmentsForm(DepartmentsController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.InitList(DepartmentList);
            _controller.GetDepartments(DepartmentList);
        }

        private void Departments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Departments.SelectedTab == tabPage1)
            {
                _controller.GetDepartments(DepartmentList);
            }
        }

        private void DepartmentList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTest = DepartmentList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);

                    contextMenuStrip1.Show(DepartmentList, e.Location);
                }
            }
        }

        private void createDepartmentButton_Click(object sender, EventArgs e)
        {
            _controller.CreateDepartment(nameBox, descriptionBox);
            _controller.GetDepartments(DepartmentList);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteDepartment(_selectedId);
            _controller.GetDepartments(DepartmentList);
        }
    }
}
