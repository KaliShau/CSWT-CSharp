using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.Roles
{
    public partial class RolesForm : Form
    {
        RolesController _controller;
        int _selectedId;
        public RolesForm(RolesController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.InitList(RolesList);
            _controller.GetRoles(RolesList);
        }

        private void Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Roles.SelectedTab == tabPage1)
            {
                _controller.GetRoles(RolesList);
            }
        }

        private void RolesList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTest = RolesList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);

                    contextMenuStrip1.Show(RolesList, e.Location);
                }
            }
        }

        private void createRoleButton_Click(object sender, EventArgs e)
        {
            _controller.CreateRole(nameBox, descriptionBox);
            _controller.GetRoles(RolesList);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteRole(_selectedId);
            _controller.GetRoles(RolesList);

        }
    }
}
