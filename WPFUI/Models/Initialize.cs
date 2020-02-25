using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class InitializeFileDialog
    {
        public static Microsoft.Win32.OpenFileDialog Initialize(string filter)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = true;
            dlg.DefaultExt = ".rtf";
            dlg.Filter = filter;

            return dlg;
        }

    }
}
