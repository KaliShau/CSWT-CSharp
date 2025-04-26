using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.UpdateUser
{
    public partial class UpdateUserForm : Form
    {
        UpdateUserController _controller;
        int _selectedId;
        public UpdateUserForm(UpdateUserController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.initData(usernameBox, passwordBox, firstNameBox, lastNameBox, emailBox, phoneNumberBox, roleBox, roleLabel, roleLine);
            _controller.InitList(DepartamentsList);
            _controller.InitDepartmentBox(departamentsBox);
            _controller.LoadDepartments(DepartamentsList);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _controller.UpdateUser(usernameBox, passwordBox, firstNameBox, lastNameBox, emailBox, phoneNumberBox, roleBox);
        }

        

        private void DepartamentsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTest = DepartamentsList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);

                    contextMenuStrip1.Show(DepartamentsList, e.Location);
                }
            }
        }

        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            _controller.AddDepartments(departamentsBox);
            _controller.LoadDepartments(DepartamentsList);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.RemoveDepartments(_selectedId);
            _controller.LoadDepartments(DepartamentsList);
        }
    }
}
