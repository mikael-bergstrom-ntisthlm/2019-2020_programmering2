using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Static
{
    class Enemy
    {
        public Enemy nemesis;

        public string name;

        public static int numberOf = 0;

        private static Random generator = new Random();

        public Enemy()
        {

            numberOf++;
        }

        public int Attack()
        {
            return generator.Next(0, 10);
        }

    }
}
