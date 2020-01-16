using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Generiska_klasser_egna
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Container<int> c = new Container<int>();

            c.contents = 8;

            Container<string> c2 = new Container<string>();

            c2.contents*/

            Container<int> start = new Container<int>();
            start.next = new Container<int>();
            start.next.next = new Container<int>();
            start.next.next.next = new Container<int>();

            start.next.next.next = start;

            Space<int> s = new Space<int>();

            



            /*Container<int> current = start;

            for (int i = 0; i < 64; i++)
            {
                current.next = new Container<int>();
                current = current.next;
            }*/



        }
    }
}
