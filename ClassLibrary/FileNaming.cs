﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FileNaming
    {
        public static List<string> namingOrder(List<Note> notes, int roundRobins, Dictionary<string,bool> dynamicsStates)
        {

            List<string> output = new List<string>();
            foreach (KeyValuePair<string, bool> item in dynamicsStates)
            {
                if (item.Value == true)
                {
                    foreach (Note note in notes)
                    {
                        for (int i = -1; i < roundRobins; i++)
                        {
                            output.Add(item.Key + " " + note.NoteName + Convert.ToString(note.Octave) + " "  + (i + 1) + "RR");

                        }

                    }


                }

            }



            return output;
        }

        public static string removeFormat(string fileName)
        {
            int index = fileName.IndexOf(".");
            string output = fileName.Substring(0, index);

            return output;
        }
    }
}
