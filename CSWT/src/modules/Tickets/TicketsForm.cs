using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.Tickets
{
    public partial class TicketsForm : Form
    {
        TicketsController _controller;
        int _selectedId;
        public TicketsForm(TicketsController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.InitTicketsList(TicketsList);
            _controller.AddTicketsToListView(TicketsList);
        }

        private void TicketsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTest = TicketsList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);

                    contextMenuStrip1.Show(TicketsList, e.Location);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteTicket(_selectedId);
            _controller.AddTicketsToListView(TicketsList);
        }

        private void commentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.OpenComments(_selectedId);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.OpenTicket(_selectedId);
        }
    }
}
