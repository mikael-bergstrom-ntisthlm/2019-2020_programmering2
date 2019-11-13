using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17B_Inkapsling_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e = new Enemy();

            Console.WriteLine(e.Name);

            //e.Hp = -8;

            Console.WriteLine(e.Hp);

            Hero h = new Hero();

            Console.WriteLine(h.Level);



            Console.ReadLine();
            /*
            int h = e.GetHp();

            h++;

            e.SetHp(h);
            */

        }
    }
}
