using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NoteGenerator
    {
        public static List<Note> createListOfNotes()
        {
            List<Note> listOfNotes = new List<Note>();
            

            for (int i = 0; i < 9; i++)
            {
                listOfNotes.Add(new Note {NoteName = "C", Octave = i });
                listOfNotes.Add(new Note { NoteName = "C#", Octave = i });
                listOfNotes.Add(new Note { NoteName = "D", Octave = i });
                listOfNotes.Add(new Note { NoteName = "D#", Octave = i });
                listOfNotes.Add(new Note { NoteName = "E", Octave = i });
                listOfNotes.Add(new Note { NoteName = "F", Octave = i });
                listOfNotes.Add(new Note { NoteName = "F#", Octave = i });
                listOfNotes.Add(new Note { NoteName = "G", Octave = i });
                listOfNotes.Add(new Note { NoteName = "G#", Octave = i });
                listOfNotes.Add(new Note { NoteName = "A", Octave = i });
                listOfNotes.Add(new Note { NoteName = "A#", Octave = i });
                listOfNotes.Add(new Note { NoteName = "B", Octave = i });

            }
                                 
            return listOfNotes;
        }

        public static List<Note> createNotes(Note startingNote, Note endingNote)
        {
            List<Note> listOfNotes = NoteGenerator.createListOfNotes();

            List<Note> output = new List<Note>();

            for (int i = startingNote.noteIndex(); i <= endingNote.noteIndex(); i++)
            {
                output.Add(listOfNotes[i]);




            }

            return output;


        }
    }
}
