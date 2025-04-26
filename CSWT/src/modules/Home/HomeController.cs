using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core.form;
using CSWT.src.modules.SettingsDB;
using CSWT.src.modules.SignIn;
using CSWT.src.modules.SignUp;
using CSWT.src.shared.utils;

namespace CSWT.src.modules.Home
{
    public class MainController
    {
        FormManager _formManager;
        public MainController(FormManager formManager)
        {
            _formManager = formManager;
        }

        public void DrugForm(Panel panel, Form form)
        {
            AddDragControl.EnableDrag(panel, form);
        }

        public void OpenSignUp(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<SignUpForm>(childrenPanel);
        }
        public void OpenSignIn(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<SignInForm>(childrenPanel);
        }

        public void OpenSettingsDB(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<SettingsDBForm>(childrenPanel);
        }
    }
}
