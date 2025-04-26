using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.dto;
using System.Windows.Forms;
using CSWT.src.shared.services.status;

namespace CSWT.src.modules.Statuses
{
    public class StatusesController
    {
        StatusesModel _model;
        public StatusesController(StatusesModel model)
        {
            _model = model;
        }

        public void InitList(ListView StatusesList)
        {
            StatusesList.View = View.Details;
            StatusesList.FullRowSelect = true;

            StatusesList.Columns.Add("ID", 50);
            StatusesList.Columns.Add("Дата создания", 120);
            StatusesList.Columns.Add("Наименование", 200);
            StatusesList.Columns.Add("Описание", 300);
        }

        public void GetStatuses(ListView StatusList)
        {
            var statuses = _model.GetStatuses();
            DisplayStatuses(statuses, StatusList);
        }

        public void DisplayStatuses(StatusDTO[] statuses, ListView StatusesList)
        {
            StatusesList.Items.Clear();

            foreach (var status in statuses)
            {
                var item = new ListViewItem(status.ID.ToString());

                item.SubItems.Add(status.created_at.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(status.status_name);
                item.SubItems.Add(status.description);

                item.Tag = status;
                StatusesList.Items.Add(item);
            }

        }

        public void CreateStatus(TextBox nameBox, TextBox descriptionBox)
        {
            string name = nameBox.Text;
            string description = descriptionBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                return;
            }

            _model.CreateStatus(name, description);
        }

        public void DeleteStatus(int ID)
        {
            _model.DeleteStatus(ID);
        }
    }
}
