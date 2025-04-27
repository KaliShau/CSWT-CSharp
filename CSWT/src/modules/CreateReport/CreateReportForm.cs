using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.CreateReport
{
    public partial class CreateReportForm : Form
    {
        CreateReportController _controller;
        public CreateReportForm(CreateReportController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.Init(reportBox);
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            _controller.Generate(reportBox);
        }
    }
}
