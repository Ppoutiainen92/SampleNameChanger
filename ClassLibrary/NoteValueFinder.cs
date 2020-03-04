using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NoteValueFinder
    {
        public static int returnNoteListElement(Note searchedNote)
        {
            List<Note> listOfNotes = NoteGenerator.createListOfNotes();





            for (int i = 0; i < listOfNotes.Count; i++)
            {



                if (listOfNotes[i].noteName == searchedNote.noteName && listOfNotes[i].octave == searchedNote.octave)
                {

                    return i;

                }
            }


            return 0;
        }




    }
}
