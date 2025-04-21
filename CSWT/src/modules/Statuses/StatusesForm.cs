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

namespace CSWT.src.modules.Statuses
{
    public partial class StatusesForm : Form
    {
        StatusesController _controller;
        int _selectedId;
        public StatusesForm(StatusesController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.InitList(StatusesList);
            _controller.GetStatuses(StatusesList);
        }

       

        private void StatusesList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTest = StatusesList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);

                    contextMenuStrip1.Show(StatusesList, e.Location);
                }
            }
        }

        private void createRoleButton_Click(object sender, EventArgs e)
        {
            _controller.CreateStatus(nameBox, descriptionBox);
            _controller.GetStatuses(StatusesList);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteStatus(_selectedId);
            _controller.GetStatuses(StatusesList);
        }

        private void Statuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Statuses.SelectedTab == tabPage1)
            {
                _controller.GetStatuses(StatusesList);
            }
        }
    }
}
