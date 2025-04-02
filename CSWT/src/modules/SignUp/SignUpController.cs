using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using CSWT.src.shared.utils;

namespace CSWT.src.modules.SignUp
{
    public class SignUpController
    {
        SignUpModel _model;
        public SignUpController(SignUpModel model)  
        {
            _model = model;
        }

        public void SignUp(string username, string passwrod, string first_name, string email, List<Panel> lines)
        {
            var valid = new ValidField();
            valid.field(username, lines[0]);
            valid.field(passwrod, lines[1]);
            valid.field(first_name, lines[2]);
            valid.field(email, lines[3]);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passwrod) || string.IsNullOrWhiteSpace(first_name) || string.IsNullOrWhiteSpace(email))
            {
                return;
            }

            Boolean isSignUp = _model.SignUp(username, passwrod, first_name, email);

            if (isSignUp)
            {
                MessageBox.Show("Вы успешно зарегистрировались!");
            } 

        }

        public void ClearField (List<TextBox> textBoxs)
        {
            textBoxs.ForEach(textBox =>
            {
                textBox.Clear();
            });
        }

      
    }
}
