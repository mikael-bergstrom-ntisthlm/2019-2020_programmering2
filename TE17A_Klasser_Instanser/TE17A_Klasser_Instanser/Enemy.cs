using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Klasser_Instanser
{
    class Enemy
    {
        private int hp = 10;
        public string name = "";

        public Enemy ()
        {
            Console.WriteLine("yay!");
        }
        
        public void Hurt()
        {
            hp--;
        }

        public void PrintHp()
        {
            Console.WriteLine(hp);
        }
    }
}
