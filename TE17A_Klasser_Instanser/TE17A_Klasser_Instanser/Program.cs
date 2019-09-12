using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Klasser_Instanser
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy firstEnemy = new Enemy();
            Enemy secondEnemy = new Enemy();
            

            firstEnemy.Hurt();

            firstEnemy.PrintHp();

            Console.ReadLine();

        }
    }
}
