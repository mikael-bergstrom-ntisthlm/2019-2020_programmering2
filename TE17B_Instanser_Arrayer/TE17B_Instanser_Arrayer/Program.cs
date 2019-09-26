using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17B_Instanser_Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy();
            e1.name = "Herbert";

            Enemy[] enemies = new Enemy[3];

            string[] names = new string[3];

            Enemy[] thirdEnemies = enemies;

            List<Enemy> alsoEnemies = new List<Enemy>();

            alsoEnemies.Add(e1);

            

            //Console.WriteLine(alsoEnemies[0].name);

            int t = 3;
            int u = t;

            t = 6;

            Enemy e2 = e1;

            e2.name = "Jenny";

            Console.WriteLine(e1.name);

            e1.mySword.dmg = 9;

            Enemy e1;

            List<Enemy> lista = new List<Enemy>();

            for (int i = 0; i < 3; i++)
            {
                e1 = new Enemy();
                lista.Add(e1);
            }



            Console.ReadLine();
        }
    }
}
