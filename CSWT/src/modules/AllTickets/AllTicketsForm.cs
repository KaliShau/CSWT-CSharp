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

namespace CSWT.src.modules.AllTickets
{
    public partial class AllTicketsForm : Form
    {
        AllTicketsController _controller;
        int _selectedTicketId;

        public AllTicketsForm(AllTicketsController controller)
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

        private void TicketsList_DoubleClick(object sender, EventArgs e)
        {
            var selectedTicket = (TicketWithJoinDTO)TicketsList.SelectedItems[0].Tag;
            _controller.OpenTicket(selectedTicket.ID);
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

        private void assignedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AssignedTicket(_selectedTicketId, TicketsList);
        }
    }
}
