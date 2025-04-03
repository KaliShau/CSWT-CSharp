using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.SignUp
{
    public partial class SignUpForm : Form
    {
        SignUpController _controller;
        public SignUpForm(SignUpController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string first_name = firstNameBox.Text;
            string email = emailBox.Text;

            var lines = new List<Panel> {usernameLine, passwordLine, firstNameLine, emailLine };
            var textBoxs = new List<TextBox> {usernameBox, passwordBox, firstNameBox, emailBox};

            _controller.SignUp(username, password, first_name, email, lines);
            _controller.ClearField(textBoxs);
        }


    }
}
