using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.AssignedTickets
{
    public partial class AssignedTicketsForm : Form
    {
        AssignedTicketsController _controller;
        int _selectedTicketId;
        public AssignedTicketsForm(AssignedTicketsController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.InitTicketsList(TicketsList);
            _controller.AddTicketsToListView(TicketsList);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                _controller.AddTicketsToListView(TicketsList);
            }
            else
            {
                _controller.Search(TicketsList, searchTerm);
            }
        }

        private void TicketsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTest = TicketsList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedTicketId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);

                    contextMenuStrip1.Show(TicketsList, e.Location);
                }
            }
        }

        private void commentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.OpenComments(_selectedTicketId);
        }

        private void TicketsList_DoubleClick(object sender, EventArgs e)
        {
            var selectedTicket = (TicketWithJoinDTO)TicketsList.SelectedItems[0].Tag;
            _controller.OpenTicket(selectedTicket.ID);
        }
    }
}
