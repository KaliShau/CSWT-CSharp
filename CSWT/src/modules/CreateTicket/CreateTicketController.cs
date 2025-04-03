using System.Windows.Forms;

namespace CSWT.src.modules.CreateTicket
{
    public class CreateTicketController
    {
        CreateTicketModel _model;
        public CreateTicketController(CreateTicketModel model)
        {
            _model = model;
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

        public void CreateTicket(int ID)
        {
            var priority = _model.GetPriority(ID);

            if (priority == null)
            {
                MessageBox.Show("Приоритет не найден!");
                return;
            }

            MessageBox.Show(priority.priority_name);
        }
    }
}
