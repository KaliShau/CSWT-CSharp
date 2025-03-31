using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.shared.utils
{
    public static class AddDragControl
    {

        private static bool _dragging = false;
        private static Point _startPoint = Point.Empty;
        private static Form _dragForm;

        public static void EnableDrag(this Control control, Form formToDrag)
        {
            _dragForm = formToDrag;

            control.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _dragging = true;
                    _startPoint = new Point(e.X, e.Y);
                }
            };

            control.MouseMove += (sender, e) =>
            {
                if (_dragging && _dragForm != null)
                {
                    Point screenPoint = control.PointToScreen(e.Location);
                    _dragForm.Location = new Point(
                        screenPoint.X - _startPoint.X,
                        screenPoint.Y - _startPoint.Y);
                }
            };

            control.MouseUp += (sender, e) => _dragging = false;
            control.MouseLeave += (sender, e) => _dragging = false;
        }

    }
}
