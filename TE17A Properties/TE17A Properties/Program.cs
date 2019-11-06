using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero h = new Hero();

            h.Xp = 100;

            h.Xp = "hej";

            h.Name = "Hubert";

            Console.WriteLine(h.Name);



            Console.ReadLine();
        }
    }
}
