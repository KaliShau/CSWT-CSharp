using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.SignIn
{
    public partial class SignInForm : Form
    {
        SignInController _controller;
        public SignInForm(SignInController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            var lines = new List<Panel> { usernameLine, passwordLine};

            _controller.SignIn(username, password, lines);
        }
    }
}
