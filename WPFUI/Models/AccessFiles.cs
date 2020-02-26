using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPFUI.Models
{
    public class AccessFiles
    {
        //Opens a dialog and returns list of file's paths.
        public static BindableCollection<string> AccessListOfFilePaths()
        {
            BindableCollection<string> output = new BindableCollection<string>();

            Microsoft.Win32.OpenFileDialog dlg = Initialize.InitializeOpenFileDialog("RTF files(*.rtf)|*.rtf|TXT Files(*.txt)|*.txt");

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                foreach (String file in dlg.FileNames)
                {
                    output.Add(file);
                    
                }

            }
            return output;

        }

        public static List<FileInfo> ListOfFiles(BindableCollection <string>ListOfFilePaths)
        {
            var output = new List<FileInfo>();





            return output;
        }
        




    }
}
