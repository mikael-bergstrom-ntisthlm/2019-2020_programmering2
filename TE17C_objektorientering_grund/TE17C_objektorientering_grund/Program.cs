using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_objektorientering_grund
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy firstEnemy = new Enemy();
            Enemy secondEnemy = new Enemy();

            firstEnemy.Hurt(11);

            firstEnemy.PrintHp();

            Console.ReadLine();
        }
    }
}
