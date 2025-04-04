using System.Windows.Forms;
using CSWT.src.core.db;

namespace CSWT.src.modules.CreateTicket
{
    public class CreateTicketController
    {
        CreateTicketModel _model;
        UserContext _userContext;
        public CreateTicketController(CreateTicketModel model, UserContext userContext)
        {
            _model = model;
            _userContext = userContext;
        }

        public void PrioritiesAddBox(ComboBox priorityBox)
        {
            priorityBox.Items.Clear();
            var priorities = _model.GetPriorities();

            if (priorities == null || priorities.Length == 0)
            {
                MessageBox.Show("Приоритеты не найдены! Обратитесь к администратору!");
                return;
            }

            priorityBox.DataSource = priorities;
            priorityBox.DisplayMember = "priority_name";
            priorityBox.ValueMember = "ID";
        }

        public void CreateTicket(int priority_id, string title, string description)
        {
            var priority = _model.GetPriorityByID(priority_id);
            var status = _model.GetStatusByStatusName("Новая");

            if (priority == null)
            {
                MessageBox.Show("Приоритет не найден!");
                return;
            }

            if (status == null)
            {
                MessageBox.Show("Статус не найден!");
                return;
            }

            _model.CreateTicket(title, description, _userContext.CurrentUser.ID, priority.ID, status.ID);
            MessageBox.Show("Заявка создана!");
        }
    }
}
