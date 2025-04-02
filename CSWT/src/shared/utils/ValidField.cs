using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSWT.src.shared.utils
{
    public class ValidField
    {
        public void field(string field, Panel line)
        {
            if (string.IsNullOrWhiteSpace(field))
            {
                line.BackColor = Color.Red;
            }
            else
            {
                line.BackColor = Color.PowderBlue;
            }
        }

    }
}
