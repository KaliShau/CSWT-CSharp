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
    }
}
