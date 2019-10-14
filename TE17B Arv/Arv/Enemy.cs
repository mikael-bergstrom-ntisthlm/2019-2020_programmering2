using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Enemy
    {
        public string name;

        public int hp = 100;

        protected int maxHp = 100;

        public void PrintStats()
        {
            Console.WriteLine(name + " [" + hp + "]");
        }

    }
}
