using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Inkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero h = new Hero();

            h.Name = "Herbert";
            Console.WriteLine(h.Name);

            h.Xp = 100;
            h.Xp = 90;

            //h.Level = 10;

            Console.WriteLine(h.Level);



            Console.ReadLine();

        }
    }
}
