using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te17a_Static
{
    class Utils
    {

        public static void PrintArray(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + s[i]);
            }
        }

    }
}
