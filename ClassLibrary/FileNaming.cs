using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FileNaming
    {
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
