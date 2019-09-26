using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17B_Static
{
    class Enemy
    {
        public string name;
        public int hp;

        public static int numberOf = 0;

        private static Random generator = new Random();

        public Enemy()
        {
            numberOf++;
        }

    }
}
