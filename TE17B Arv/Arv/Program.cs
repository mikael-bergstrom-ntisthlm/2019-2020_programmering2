using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e = new Enemy();

            Goomba g = new Goomba();

            

            Enemy e2 = new Goomba();

            

            List<Enemy> enemies = new List<Enemy>();

            enemies.Add(new Goomba());


            g.PrintStats();

            


            Console.ReadLine();

        }
    }
}
