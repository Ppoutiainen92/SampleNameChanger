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
        private bool _checkBoxppp;
        public Dictionary<string ,bool> dynamicsCheckBoxStates;

        public BindableCollection<string> FilePaths { get; set; }
        public BindableCollection<string> CheckBoxStates { get; set; }
        List<FileInfo> listOfSelectedFiles;
        int _roundRobinValue = 0;

        public ShellViewModel()
        {
            FilePaths = new BindableCollection<string>();
            CheckBoxStates = new BindableCollection<string>();
            dynamicsCheckBoxStates = Initialize.DynamicsCheckBoxDictionary();
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


        public bool CheckBoxppp
        {
            get { return _checkBoxppp; }
            set {
                _checkBoxppp = value;
                changeDynamicDictValue("CheckBoxppp", _checkBoxppp);
                CheckBoxStates.Add($"CheckBoxppp is {dynamicsCheckBoxStates["CheckBoxppp"].ToString()}");
            }
        }

        public void changeDynamicDictValue(string key, bool val)
        {
            dynamicsCheckBoxStates[key] = val;

        }

    }
}
