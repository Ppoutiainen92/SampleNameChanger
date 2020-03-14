using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Validator
    {
        public static bool CheckIfDynamicsAdded(Dictionary <string,bool> dynamicsStates)
        {
            

            foreach(KeyValuePair<string,bool> item in dynamicsStates)
            {
                if(item.Value == true)
                {
                    return true;
                }


            }

            return false;
        }



    }
}
