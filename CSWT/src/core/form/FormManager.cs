using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using CSWT.src.modules.Entities;

namespace CSWT.src.core.form
{
    public class FormManager
    {
        private readonly IServiceProvider _serviceProvider;
        private Form _currentForm;
        private Form _childrenForm;
        private Form _entitiesForm;

        public FormManager(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }
        public void SetMainForm(HomeForm homeForm)
        {
            _currentForm = homeForm;
        }

        public void OpenForm<TForm>() where TForm : Form
        {
            if (typeof(TForm) == typeof(HomeForm))
            {
                if (_currentForm is HomeForm homeForm)
                {
                    homeForm.Show();
                    return;
                }
            }

            if (_currentForm is HomeForm)
            {
                _currentForm.Hide();
            }
            else
            {
                _currentForm?.Close();
            }

            _childrenForm?.Close();
            _entitiesForm?.Close();

            _currentForm = _serviceProvider.GetRequiredService<TForm>();

            _currentForm.Show();
        }

        public void OpenChidrenForm<TForm>(Panel childrenPanel) where TForm : Form
        {
            _childrenForm?.Close();
            _entitiesForm?.Close();
            _childrenForm = _serviceProvider.GetRequiredService<TForm>();

            _childrenForm.Dock = DockStyle.Fill;
            _childrenForm.TopLevel = false;
            _childrenForm.FormBorderStyle = FormBorderStyle.None;
            childrenPanel.Controls.Clear();
            childrenPanel.Controls.Add(_childrenForm);
            _childrenForm.Show();
        }

        public void OpenEntitiesForm<TForm>(Panel childrenPanel) where TForm : Form
        {
            _entitiesForm?.Close();
            _entitiesForm = _serviceProvider.GetRequiredService<TForm>();

            _entitiesForm.Dock = DockStyle.Fill;
            _entitiesForm.TopLevel = false;
            _entitiesForm.FormBorderStyle = FormBorderStyle.None;
            childrenPanel.Controls.Clear();
            childrenPanel.Controls.Add(_entitiesForm);
            _entitiesForm.Show();
        }
    }
}
