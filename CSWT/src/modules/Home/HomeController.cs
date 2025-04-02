using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core.form;
using CSWT.src.modules.SignUp;
using CSWT.src.shared.utils;

namespace CSWT.src.modules.Home
{
    public class HomeController
    {
        FormManager _formManager;
        public HomeController(FormManager formManager)
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
    }
}
