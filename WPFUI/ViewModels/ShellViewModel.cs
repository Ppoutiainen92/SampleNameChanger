﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using WPFUI.Models;
using ClassLibrary;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _blockText = "jotain";

        private bool _checkBoxppp;
        private bool _checkBoxpp;
        private bool _checkBoxp;
        private bool _checkBoxmp;
        private bool _checkBoxmf;
        private bool _checkBoxf;
        private bool _checkBoxff;
        private bool _checkBoxfff;

        private List<FileInfo> listOfSelectedFiles;
        private int _roundRobinValue = 0;

        private BindableCollection<Note> _Notes;
        private string _noteName;

        private Note _selectedStartingNote;
        private Note _selectedEndingNote;


        public Dictionary<string ,bool> dynamicsCheckBoxStates;
        public BindableCollection<string> FilePaths { get; set; }
        public BindableCollection<string> CheckBoxStates { get; set; }

        public ShellViewModel()
        {
            FilePaths = new BindableCollection<string>();
            CheckBoxStates = new BindableCollection<string>();
            dynamicsCheckBoxStates = Initialize.DynamicsCheckBoxDictionary();
            _Notes = Initialize.Notes();

        }
        
        public void SelectFiles()
        {

            FilePaths = AccessFiles.AccessListOfFilePaths();
            NotifyOfPropertyChange(() => FilePaths);
            listOfSelectedFiles = AccessFiles.ListOfFileInfo(FilePaths);
            Trace.Write("");
        }

        public int RoundRobinValue
        {
            get { return _roundRobinValue; }

            set {
                _roundRobinValue = value;
                NotifyOfPropertyChange(() => RoundRobinValue);
            }
            
        }

        //Debugging
        public string Block
        {
            get { return _blockText; }

            set
            {
                _blockText = value;
                NotifyOfPropertyChange(() => Block);
            }

        }


        public void RenameFiles()
        {
            Trace.Write("");
            AccessFiles.Rename(listOfSelectedFiles, RoundRobinValue, dynamicsCheckBoxStates, _selectedStartingNote, _selectedEndingNote);

        }

        //Dynamics selection
        public bool CheckBoxppp
        {
            get { return _checkBoxppp; }
            set {
                string checkBoxName = "CheckBoxppp";
                _checkBoxppp = value;
                
                changeDynamicDictValue(checkBoxName, _checkBoxppp);
                CheckBoxStates.Add($"{checkBoxName} is {dynamicsCheckBoxStates[checkBoxName].ToString()}");
            }
        }
        public bool CheckBoxpp
        {
            get { return _checkBoxpp; }
            set
            {
                string checkBoxName = "CheckBoxpp";
                _checkBoxpp = value;

                changeDynamicDictValue(checkBoxName, _checkBoxpp);
                CheckBoxStates.Add($"{checkBoxName} is {dynamicsCheckBoxStates[checkBoxName].ToString()}");
            }
        }
        public bool CheckBoxp
        {
            get { return _checkBoxp; }
            set
            {
                string checkBoxName = "CheckBoxp";
                _checkBoxp = value;

                changeDynamicDictValue(checkBoxName, _checkBoxp);
                CheckBoxStates.Add($"{checkBoxName} is {dynamicsCheckBoxStates[checkBoxName].ToString()}");
            }
        }
        public bool CheckBoxmp
        {
            get { return _checkBoxmp; }
            set
            {
                string checkBoxName = "CheckBoxmp";
                _checkBoxmp = value;

                changeDynamicDictValue(checkBoxName, _checkBoxmp);
                CheckBoxStates.Add($"{checkBoxName} is {dynamicsCheckBoxStates[checkBoxName].ToString()}");
            }
        }
        public bool CheckBoxmf
        {
            get { return _checkBoxmf; }
            set
            {
                string checkBoxName = "CheckBoxmf";
                _checkBoxmf = value;

                changeDynamicDictValue(checkBoxName, _checkBoxmf);
                CheckBoxStates.Add($"{checkBoxName} is {dynamicsCheckBoxStates[checkBoxName].ToString()}");
            }
        }
        public bool CheckBoxf
        {
            get { return _checkBoxf; }
            set
            {
                string checkBoxName = "CheckBoxf";
                _checkBoxf = value;

                changeDynamicDictValue(checkBoxName, _checkBoxf);
                CheckBoxStates.Add($"{checkBoxName} is {dynamicsCheckBoxStates[checkBoxName].ToString()}");
            }
        }
        public bool CheckBoxff
        {
            get { return _checkBoxff; }
            set
            {
                string checkBoxName = "CheckBoxff";
                _checkBoxff = value;

                changeDynamicDictValue(checkBoxName, _checkBoxff);

                CheckBoxStates.Add($"{checkBoxName} is {dynamicsCheckBoxStates[checkBoxName].ToString()}");
            }
        }
        public bool CheckBoxfff
        {
            get { return _checkBoxfff; }
            set
            {
                string checkBoxName = "CheckBoxfff";
                _checkBoxfff = value;

                changeDynamicDictValue(checkBoxName, _checkBoxfff);

                CheckBoxStates.Add($"{checkBoxName} is {dynamicsCheckBoxStates[checkBoxName].ToString()}");
            }
        }

        //Change dynamics value at given key
        public void changeDynamicDictValue(string key, bool val)
        {
            dynamicsCheckBoxStates[key] = val;

        }

        //Show all notes in the combobox
        public BindableCollection<Note> StartingNotes
        {
            get { return _Notes; }
        }

        public BindableCollection<Note> EndingNotes
        {
            get { return _Notes; }
        }

        public string FullName {
            get { return _noteName; }
            set
            {
                _noteName = value;
                NotifyOfPropertyChange(() => FullName);
            }

        }

        
        //Selected note in combobox
        public Note SelectedStartingNote
        {
            get { return _selectedStartingNote; }
            set
            {
                _selectedStartingNote = value;

                NotifyOfPropertyChange(() => SelectedStartingNote);
            }
        }

        public Note SelectedEndingNote
        {
            get { return _selectedEndingNote; }
            set {
                _selectedEndingNote = value;
                NotifyOfPropertyChange(() => SelectedEndingNote);
            }
        }



    }
}
