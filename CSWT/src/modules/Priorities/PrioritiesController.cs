using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.modules.Statuses;
using CSWT.src.shared.services.status;
using System.Windows.Forms;
using CSWT.src.shared.services.priority;

namespace CSWT.src.modules.Priorities
{
    public class PrioritiesController
    {
        PrioritiesModel _model;
        public PrioritiesController(PrioritiesModel model)
        {
            _model = model;
        }

        public void InitList(ListView PriorityList)
        {
            PriorityList.View = View.Details;
            PriorityList.FullRowSelect = true;

            PriorityList.Columns.Add("ID", 50);
            PriorityList.Columns.Add("Дата создания", 120);
            PriorityList.Columns.Add("Наименование", 200);
            PriorityList.Columns.Add("Описание", 300);
        }

        public void GetPriorities(ListView PriorityList)
        {
            var priotities = _model.GetPriorities();
            DisplayPriorities(priotities, PriorityList);
        }

        public void DisplayPriorities(PriorityDTO[] priotities, ListView PriorityList)
        {
            PriorityList.Items.Clear();

            foreach (var priority in priotities)
            {
                var item = new ListViewItem(priority.ID.ToString());

                item.SubItems.Add(priority.created_at.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(priority.priority_name);
                item.SubItems.Add(priority.description);

                item.Tag = priority;
                PriorityList.Items.Add(item);
            }

        }

        public void CreatePriority(TextBox nameBox, TextBox descriptionBox)
        {
            string name = nameBox.Text;
            string description = descriptionBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                return;
            }

            _model.CreatePriority(name, description);
        }

        public void DeletePriority(int ID)
        {
            _model.DeletePriority(ID);
        }
    }
}
