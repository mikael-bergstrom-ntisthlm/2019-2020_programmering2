using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Virtual_Override
{
    class Weapon
    {
        protected int minDmg = 5;
        protected int maxDmg = 10;

        static Random generator = new Random();

        public virtual int Attack()
        {
            return generator.Next(minDmg, maxDmg);
        }
    }
}
