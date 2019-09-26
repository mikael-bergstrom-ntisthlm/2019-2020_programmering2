using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_ReferenceValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hej";

            string h = s;

            s = "grej";

            Console.WriteLine(h);


            Enemy e1 = new Enemy();

            e1.name = "Herbert";

            

            Enemy e2 = e1;

            e2.name = "Jenny";

            Console.WriteLine(e1.name);

            Enemy[] enemies = {
                new Enemy(),
                new Enemy(),
                new Enemy(),
                e1,
                e2,
                e1,
                e1,
                e1,
                e1
            };

            e1.nemesis = e2;

            e2.nemesis = e1;

            Console.WriteLine(e2.nemesis.nemesis.name);



            Console.ReadLine();
        }
    }
}
