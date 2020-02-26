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
        public BindableCollection<string> FilePaths { get; set; }
        List<FileInfo> listOfSelectedFiles;
        int _roundRobinValue = 0;

        public ShellViewModel()
        {
            FilePaths = new BindableCollection<string>();

        }
        
        public void SelectFiles()
        {

            FilePaths = AccessFiles.AccessListOfFilePaths();
            NotifyOfPropertyChange(() => FilePaths);
            listOfSelectedFiles = AccessFiles.ListOfFileInfo(FilePaths);
            
        }

        public int RoundRobinValue
        {
            get { return _roundRobinValue; }

            set {
                _roundRobinValue = value;
                NotifyOfPropertyChange(() => RoundRobinValue);
            }
            
        }

        public string Block
        {
            get { return _blockText; }

     

        }
    }
}
