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

        
        public void SelectFiles()
        {
            _blockText = "Jotain muuta";
            NotifyOfPropertyChange(() => Block);

        }

        public string Block
        {
            get { return _blockText; }



        }
    }
}
