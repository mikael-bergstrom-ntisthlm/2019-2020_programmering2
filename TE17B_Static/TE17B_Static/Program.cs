using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17B_Static
{
    class Program
    {
        static void Main(string[] args)
        { 
            Enemy e1 = new Enemy();

            Console.WriteLine(Enemy.numberOf);


            string[] adrg = { "sko", "drake", "rymdskepp" };

            Utils.PrintArray(adrg);

            Console.WriteLine("hej");
            Program.Main(args);

        }
    }
}
