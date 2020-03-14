using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary;

namespace WPFUI.Models
{
    public class AccessFiles
    {
        //Opens a dialog and returns list of file's paths.
        public static BindableCollection<string> AccessListOfFilePaths(string fileFormat)
        {
            BindableCollection<string> output = new BindableCollection<string>();

            Microsoft.Win32.OpenFileDialog dlg = Initialize.InitializeOpenFileDialog($"Wave files (*.wav)|*.wav");

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

        public static List<FileInfo> ListOfFileInfo(BindableCollection <string>ListOfFilePaths)
        {
            var output = new List<FileInfo>();

            foreach (string item in ListOfFilePaths)
            {
                FileInfo fileInfo = new FileInfo(item);

                output.Add(fileInfo);

            }



            return output;
        }
        
        public static void Rename(List<FileInfo> listOfSelectedFiles, int roundRobinValue, Dictionary<string,bool> dynamicsCheckBoxStates, Note _selectedStartingNote, Note _selectedEndingNote, string _fileName, string fileFormat, Dictionary<string,bool> dynamicsStates)
        {
            int fileCount = 0;
            if (_fileName.Contains("."))
            {
                _fileName = FileNaming.removeFormat(_fileName);

            }

            List<Note> notesBetween = NoteGenerator.createNotes(_selectedStartingNote, _selectedEndingNote);

            List<string> namingOrder = FileNaming.namingOrder(notesBetween, roundRobinValue, dynamicsCheckBoxStates);

            string folderPath = listOfSelectedFiles[0].DirectoryName;
            

            foreach (FileInfo file in listOfSelectedFiles)
            {
                string newFileName = _fileName + $"({fileCount}) " + namingOrder[fileCount] + fileFormat;
                string temppath = Path.Combine(folderPath, newFileName);

                file.MoveTo(temppath);
                fileCount++;
            }

        }



    }
}
