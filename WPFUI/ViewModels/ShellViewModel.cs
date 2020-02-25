using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WPFUI.Models;

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

            Items = AccessFiles.AccessListOfFiles();
            NotifyOfPropertyChange(() => Items);

        }

        public string Block
        {
            get { return _blockText; }



        }
    }
}
