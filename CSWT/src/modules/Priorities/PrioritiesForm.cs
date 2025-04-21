using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.modules.Statuses;

namespace CSWT.src.modules.Priorities
{
    public partial class PrioritiesForm : Form
    {
        PrioritiesController _controller;
        int _selectedId;
        public PrioritiesForm(PrioritiesController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.InitList(PrioritiesList);
            _controller.GetPriorities(PrioritiesList);
        }

        private void createPriorityButton_Click(object sender, EventArgs e)
        {
            _controller.CreatePriority(nameBox, descriptionBox);
            _controller.GetPriorities(PrioritiesList);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeletePriority(_selectedId);
            _controller.GetPriorities(PrioritiesList);
        }

        private void Priorities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Priorities.SelectedTab == tabPage1)
            {
                _controller.GetPriorities(PrioritiesList);
            }
        }

        private void PrioritiesList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTest = PrioritiesList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);

                    contextMenuStrip1.Show(PrioritiesList, e.Location);
                }
            }
        }
    }
}
