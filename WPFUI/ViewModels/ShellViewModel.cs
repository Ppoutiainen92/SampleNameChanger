using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _blockText = "jotain";
        public BindableCollection<string> Items { get; set; }

        public ShellViewModel()
        {
            Items = new BindableCollection<string>();

        }

        public void SelectFiles()
        {
            //_blockText = "Jotain muuta";
            //Items.Add(_blockText);
            //NotifyOfPropertyChange(() => Block);


            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = true;
            dlg.DefaultExt = ".rtf";
            dlg.Filter = "TXT Files(*.txt)|*.txt|RTF files(*.rtf)|*.rtf";

            Nullable<bool> result = dlg.ShowDialog();

            if(result== true)
            {
                foreach(String file in dlg.FileNames)
                {
                Items.Add(dlg.FileName);

                }

            }

        }

        public string Block
        {
            get { return _blockText; }



        }
    }
}
