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
            Note note = new Note("C", 1);

            for (int i = 0; i < 9; i++)
            {
                listOfNotes.Add(new Note("C", i));
                listOfNotes.Add(new Note("C#", i));
                listOfNotes.Add(new Note("D", i));
                listOfNotes.Add(new Note("D#", i));
                listOfNotes.Add(new Note("E", i));
                listOfNotes.Add(new Note("F", i));
                listOfNotes.Add(new Note("F#", i));
                listOfNotes.Add(new Note("G", i));
                listOfNotes.Add(new Note("G#", i));
                listOfNotes.Add(new Note("A", i));
                listOfNotes.Add(new Note("A#", i));
                listOfNotes.Add(new Note("B", i));
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
