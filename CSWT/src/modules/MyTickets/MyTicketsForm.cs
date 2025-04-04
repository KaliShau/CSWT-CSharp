using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.MyTickets
{
    public partial class MyTicketsForm : Form
    {
        MyTicketsController _controller;
        public MyTicketsForm(MyTicketsController controller)
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
            } else
            {
                _controller.Search(TicketsList, searchTerm);
            }
        }
    }
}
