using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();

            e1.name = "Freddie";
            e2.name = "Eddie";

            e1.nemesis = e2;
            e2.nemesis = e1;

            Console.WriteLine(e1.nemesis.nemesis.nemesis.nemesis.name);

            Console.WriteLine(Enemy.numberOf);

            string[] namn = { "Micke", "Herbert", "Lina", "Ann-Katrin" };

            Utils.PrintArray(namn);

            Hello();


            Console.ReadLine();

        }

        public static void Hello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
