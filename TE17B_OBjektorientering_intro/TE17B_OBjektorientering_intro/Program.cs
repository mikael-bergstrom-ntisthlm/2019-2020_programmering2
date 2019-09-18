using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17B_OBjektorientering_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            


            Enemy e1 = new Enemy();

            Enemy e2 = new Enemy();

            e1.Hurt(7);

            e1.PrintHp();


            Console.ReadLine();
        }
    }
}
