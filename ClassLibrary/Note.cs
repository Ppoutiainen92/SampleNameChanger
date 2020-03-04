using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Note
    {
        public string NoteName { get; set; }
        public int Octave { get; set; }

        public Note()
        {


        }
        public int noteIndex()
        {
            return NoteValueFinder.returnNoteListElement(this);
        }



        public override string ToString()
        {
            return NoteName + Octave;
        }

    }
}
