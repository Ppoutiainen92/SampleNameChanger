using System;
using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

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

        public static Dictionary<string, bool> DynamicsCheckBoxDictionary()
        {
            Dictionary<string, bool> output = new Dictionary<string, bool>();
            output.Add("Checkxoxppp", false);
            output.Add("Checkxoxpp", false);
            output.Add("Checkxoxp", false);
            output.Add("Checkxoxmp", false);
            output.Add("Checkxoxmf", false);
            output.Add("Checkxoxf", false);
            output.Add("Checkxoxff", false);
            output.Add("Checkxoxfff", false);



            return output;
        }

        public static BindableCollection<Note> Notes()
        {
            BindableCollection<Note> output = new BindableCollection<Note>();


            return output;
        }

    }
}
