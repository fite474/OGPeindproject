using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindproject
{
    static class ThreadExtension
    {
        public static void ActionInvoke(this Control control, Action action)
        {
            control.Invoke(action);
        }
    }
}
