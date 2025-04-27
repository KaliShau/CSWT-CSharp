using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.Main
{
    public partial class MainForm : Form
    {
        MainController _controller;
        public MainForm(MainController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.InitChildrenPanel(childrenPanel);
            _controller.DrugForm(drugPanel, this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openCreateTicket_Click(object sender, EventArgs e)
        {
            _controller.OpenCreateTicker(childrenPanel);
        }

        private void openMyTickets_Click(object sender, EventArgs e)
        {
            _controller.OpenMyTickets(childrenPanel);
        }

        private void openAllTickets_Click(object sender, EventArgs e)
        {
            _controller.OpenAllTickets(childrenPanel);
        }

        private void openAssignedTickets_Click(object sender, EventArgs e)
        {
            _controller.OpenAssignedTickets(childrenPanel);
        }

        private void openEntitiesButton_Click(object sender, EventArgs e)
        {
            _controller.OpenEntities(childrenPanel);
        }

        

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.OpenProfile(childrenPanel);
        }

        private void openCreateReports_Click(object sender, EventArgs e)
        {
            _controller.OpenCreateReports(childrenPanel);
        }

        private void openMyReports_Click(object sender, EventArgs e)
        {
            _controller.OpenMyReports(childrenPanel);
        }

        private void openAllReports_Click(object sender, EventArgs e)
        {
            _controller.OpenAllReports(childrenPanel);
        }
    }
}
