using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_value_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();

            e1.nemesis = e2;
            e2.nemesis = e1;

            Console.WriteLine(e1.nemesis.nemesis.nemesis.nemesis.name);
            Enemy e = e1;
            while (e.nemesis != null)
            {
                e = e.nemesis;
            }


            Enemy e3 = new Enemy(e1);


            Console.WriteLine(e1.weapon.dmg);

            List<Enemy> enemies = new List<Enemy>();

            enemies.Add(new Enemy());

            Console.WriteLine(enemies[0].name);


            /*e1.name = "Herbert";

            Enemy e2 = e1;

            e2.name = "Jenny";

            Console.WriteLine(e1.name);

            string s1 = "hej";
            string s2 = s1;

            s1 = "grej";

            Console.WriteLine(s2);*/

            DoThings(e1);

            Console.WriteLine(e1.name);

            Console.ReadLine();
        }

        static void DoThings(Enemy target)
        {
            target.name = "Apa";
        }
    }
}
