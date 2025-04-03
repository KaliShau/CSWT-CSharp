using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.shared.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CSWT.src.modules.SignIn
{
    public class SignInController
    {
        SignInModel _model;
        public SignInController(SignInModel model)
        {
            _model = model;
        }

        public void SignIn(string username, string password, List<Panel> lines)
        {
            var valid = new ValidField();
            valid.field(username, lines[0]);
            valid.field(password, lines[1]);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return;
            }

            var user = _model.SignIn(username, password);

            if (user != null)
            {
                MessageBox.Show(user.email);
            } else
            {
                MessageBox.Show("Ошибка входа!");
            }
        }

    }
}
