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
                listOfNotes.Add(new Note {NoteName = "C", Octave = i , FullName = $"C{i}"});
                listOfNotes.Add(new Note { NoteName = "C#", Octave = i, FullName = $"C#{i}" });
                listOfNotes.Add(new Note { NoteName = "D", Octave = i, FullName = $"D{i}" });
                listOfNotes.Add(new Note { NoteName = "D#", Octave = i, FullName = $"D#{i}" });
                listOfNotes.Add(new Note { NoteName = "E", Octave = i, FullName = $"E{i}" });
                listOfNotes.Add(new Note { NoteName = "F", Octave = i, FullName = $"F{i}" });
                listOfNotes.Add(new Note { NoteName = "F#", Octave = i, FullName = $"F#{i}" });
                listOfNotes.Add(new Note { NoteName = "G", Octave = i, FullName = $"G{i}" });
                listOfNotes.Add(new Note { NoteName = "G#", Octave = i, FullName = $"G#{i}" });
                listOfNotes.Add(new Note { NoteName = "A", Octave = i, FullName = $"A{i}" });
                listOfNotes.Add(new Note { NoteName = "A#", Octave = i, FullName = $"A#{i}" });
                listOfNotes.Add(new Note { NoteName = "B", Octave = i, FullName = $"B{i}" });

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

        public static List<string> namingOrder(List<Note> notes, int roundRobins)
        {

            List<string> output = new List<string>();

            foreach (Note note in notes)
            {
                for (int i = 0; i < roundRobins; i++)
                {
                    output.Add(note.NoteName + Convert.ToString(note.Octave) + " " + (i + 1) + "RR");

                }



            }



            return output;
        }

    }
}
