using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class Initialize
    {
        //Initializes File dialogs and return it.
        public static Microsoft.Win32.OpenFileDialog InitializeOpenFileDialog(string filter)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = true;
            dlg.DefaultExt = ".rtf";
            dlg.Filter = filter;

            return dlg;
        }

    }
}
