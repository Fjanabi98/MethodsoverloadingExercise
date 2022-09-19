using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodoverloadingExercise
{

    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool a)
        {
            if (a == true && x + y > 1)
            {
                return ($"{x + y}dollars");
            }
            else

            {
                return ($"{x + y}dollar");
            }


        }
    }
}
    
