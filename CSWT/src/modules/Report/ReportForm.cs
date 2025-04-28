using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.modules.Report
{
    public partial class ReportForm : Form
    {
        ReportController _controller;
        public ReportForm(ReportController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.Init(ReportList, titleBox, typeBox, createdAtLabel);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.SaveToDocx(ReportList, titleBox.Text);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.PrintReport(ReportList, titleBox.Text);
        }
    }
}
