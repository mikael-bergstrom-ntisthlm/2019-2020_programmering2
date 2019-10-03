using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_value_reference
{
    class Enemy
    {
        public string name;
        public Sword weapon = new Sword();

        public Enemy nemesis;

        public Enemy()
        {

        }

        public Enemy(Enemy original)
        {
            name = original.name;
            nemesis = original.nemesis;

        }

    }
}
