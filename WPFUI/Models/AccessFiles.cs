using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class AccessFiles
    {

        public static BindableCollection<string> AccessListOfFiles()
        {
            BindableCollection<string> output = new BindableCollection<string>();

            Microsoft.Win32.OpenFileDialog dlg = InitializeFileDialog.Initialize("RTF files(*.rtf)|*.rtf|TXT Files(*.txt)|*.txt");

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                foreach (String file in dlg.FileNames)
                {
                    output.Add(dlg.FileName);

                }

            }
            return output;

        }
        




    }
}
