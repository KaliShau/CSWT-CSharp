using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.Users
{
    public partial class UsersForm : Form
    {
        UsersController _controller;
        int _selectedId;
        public UsersForm(UsersController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.InitList(UsersList);
            _controller.GetUsers(UsersList);
        }

        private void UsersList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTest = UsersList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);

                    contextMenuStrip1.Show(UsersList, e.Location);
                }
            }
        }
    }
}
