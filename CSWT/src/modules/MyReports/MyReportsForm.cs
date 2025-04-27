using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.MyReports
{
    public partial class MyReportsForm : Form
    {
        MyReportsController _controller;
        int _selectedId;
        public MyReportsForm(MyReportsController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.InitList(ReportsList);
            _controller.GetReports(ReportsList);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                _controller.GetReports(ReportsList);
            } else
            {
                _controller.GetReportsSearch(ReportsList, searchTerm);
            }
        }

        private void ReportsList_MouseClick(object sender, MouseEventArgs e)
        {
                ListViewHitTestInfo hitTest = ReportsList.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    hitTest.Item.Selected = true;

                    _selectedId = Convert.ToInt16(hitTest.Item.SubItems[0].Text);
                }
        }

        private void ReportsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _controller.OpenReport(_selectedId);
        }
    }
}
