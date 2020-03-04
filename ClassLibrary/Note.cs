using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Note
    {
        public string noteName;
        public int octave;

        public Note(string NoteName, int Octave)
        {
            NoteName = noteName;
            Octave = octave;

        }



        public override string ToString()
        {
            return noteName +", Oct:" +octave;
        }

    }
}
