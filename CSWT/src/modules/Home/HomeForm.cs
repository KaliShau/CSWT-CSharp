using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.shared.utils;

namespace CSWT
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            AddDragControl.EnableDrag(panel1, this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
