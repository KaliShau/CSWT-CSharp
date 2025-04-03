using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.modules.Home;
using CSWT.src.shared.utils;

namespace CSWT
{
    public partial class HomeForm : Form
    {
        HomeController _controller;
        public HomeForm(HomeController controller)
        {
            InitializeComponent();
            _controller = controller;

            controller.DrugForm(drugPanel, this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openSignUpButton_Click(object sender, EventArgs e)
        {
            _controller.OpenSignUp(childrenPanel);
        }

        private void openSignInButton_Click(object sender, EventArgs e)
        {
            _controller.OpenSignIn(childrenPanel);
        }
    }
}
