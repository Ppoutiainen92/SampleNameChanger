using System;
using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Diagnostics;

namespace WPFUI.Models
{
    public class Initialize
    {
        //Initializes File dialogs and return it.
        public static Microsoft.Win32.OpenFileDialog InitializeOpenFileDialog(string filter)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = true;
            dlg.DefaultExt = ".wav";
            dlg.Filter = filter;

            return dlg;
        }

        public static Dictionary<string, bool> DynamicsCheckBoxDictionary()
        {
            Dictionary<string, bool> output = new Dictionary<string, bool>();
            output.Add("ppp", false);
            output.Add("pp", false);
            output.Add("p", false);
            output.Add("mp", false);
            output.Add("mf", false);
            output.Add("f", false);
            output.Add("ff", false);
            output.Add("fff", false);



            return output;
        }

        public static BindableCollection<Note> Notes()
        {
            BindableCollection<Note> output = new BindableCollection<Note>();
            List<Note> listOfNotes = NoteGenerator.createListOfNotes();

            foreach(var note in listOfNotes)
            {
                output.Add(note);

            }

            return output;
        }

    }
}
